﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using TCosReborn.Application;
using TCosReborn.Framework.Common;
using TCosReborn.Framework.Utility;
using Engine;
using System.Runtime.Serialization;
using TCosReborn.Framework.Attributes;

namespace TCosReborn.Framework.PackageExtractor
{
    public partial class PackageDeserializer
    {
        GlobalHeader Header;

        string[] NameTable { get; set; }
        ExportEntry[] ExportTable { get; set; }
        ImportEntry[] ImportTable { get; set; }

        string PackageName = string.Empty;

        const string NULL = "null";
        const string NONE = "none";

        Queue<ImportLink> LinkerLinks;

        SBResourcePackage resourceReceiver;

        void AddResource(string name, object value)
        {
            if (resourceReceiver != null) resourceReceiver.Resources.Add(name, value);
        }

        string FindReferenceName(int reference, bool showAncestors = true)
        {
            if (reference > 0)
            {
                var result = GetName(ExportTable[reference - 1].ObjectNameReference);
                if (showAncestors)
                {
                    var ancestors = FindReferenceName(ExportTable[reference - 1].PackageReference);
                    if (ancestors != NULL)
                        result = ancestors + "." + result;
                }
                return result;
            }
            if (reference < 0)
            {
                var result = GetName(ImportTable[-reference - 1].ObjectReference);
                if (showAncestors)
                {
                    var ancestors = FindReferenceName(ImportTable[-reference - 1].PackageReference);
                    if (ancestors != NULL)
                        result = ancestors + "." + result;
                }
                return result;
            }
            return NULL;
        }

        string FindAbsoluteObjectReference(int reference)
        {
            if(reference > 0)
            {
                return ExportTable[reference - 1].AbsoluteObjectReference;
            }
            if (reference < 0)
            {
                return ImportTable[-reference - 1].AbsoluteObjectReference;
            }
            return NULL;
        }

        NameProperty GetName(int reference)
        {
            return NameTable[reference];
        }

        void RegisterImport(ImportLink link)
        {
            if (!ReflectionHelper.CanSkipImport(link.SkipTestClassReference))
            {
                LinkerLinks.Enqueue(link);
            }
        }

        public void Load(string filePath, Queue<ImportLink> linkQueue, SBResourcePackage resourceReceiver = null)
        {
            LinkerLinks = linkQueue;
            this.resourceReceiver = resourceReceiver;
            PackageName = Path.GetFileNameWithoutExtension(filePath);
            var fileReader = new SBFileReader(filePath);
            fileReader.Read(out Header, Marshal.SizeOf(Header));
            fileReader.Seek(Header.NameOffset, SeekOrigin.Begin);

            NameTable = new string[Header.NameCount];
            //----------- READ NAME TABLE --------------

            #region NameTable

            for (uint k = 0; k < Header.NameCount; ++k)
            {
                int nameSize = fileReader.ReadByte();
                var stringArray = fileReader.ReadBytes(nameSize);
                fileReader.ReadUInt32(); //uint objectFlags
                var name = Encoding.ASCII.GetString(stringArray).Replace("\0", string.Empty);
                NameTable[k] = name;
            }
            //Log(string.Format("NameTable: {0} names read", NameTable.Length), 0);

            #endregion

            //------------------ READ IMPORT TABLE ---------------------------

            #region ImportTable

            ImportTable = new ImportEntry[Header.ImportCount];
            fileReader.Seek(Header.ImportOffset, SeekOrigin.Begin);
            for (uint k = 0; k < Header.ImportCount; ++k)
            {
                var entry = new ImportEntry
                {
                    ClassPackageReference = fileReader.ReadIndex(),
                    ClassReference = fileReader.ReadIndex(),
                    PackageReference = fileReader.ReadInt32(),
                    ObjectReference = fileReader.ReadIndex()
                };
                ImportTable[k] = entry;
            }
            //Log(string.Format("ImportTable: {0} imports read", ImportTable.Length), 0);

            #endregion

            //------------------- READ EXPORT TABLE --------------------------

            #region ExportTable

            ExportTable = new ExportEntry[Header.ExportCount];
            fileReader.Seek(Header.ExportOffset, SeekOrigin.Begin);
            for (uint k = 0; k < Header.ExportCount; ++k)
            {
                var entry = new ExportEntry
                {
                    ClassReference = fileReader.ReadIndex(),
                    SuperReference = fileReader.ReadIndex(),
                    PackageReference = fileReader.ReadInt32(),
                    ObjectNameReference = fileReader.ReadIndex(),
                    ObjectFlags = fileReader.ReadInt32(),
                    SerialSize = fileReader.ReadIndex()
                };
                if (entry.SerialSize > 0)
                {
                    entry.SerialOffset = fileReader.ReadIndex();
                }
                ExportTable[k] = entry;
            }
            //Log(string.Format("ExportTable: {0} exports read", ExportTable.Length), 0);

            #endregion

            //------------------- Resolve Import & Export references to readable names--------------------

            for (var i = 0; i < ImportTable.Length; i++)
            {
                ImportTable[i].ObjectPackageName = FindReferenceName(ImportTable[i].PackageReference);
                ImportTable[i].ClassPackageName = GetName(ImportTable[i].ClassPackageReference);
                ImportTable[i].ClassName = GetName(ImportTable[i].ClassReference);
                ImportTable[i].ObjectName = GetName(ImportTable[i].ObjectReference);

                var objFormatted = (ImportTable[i].ObjectPackageName != NULL ? ImportTable[i].ObjectPackageName : "") + (ImportTable[i].ObjectName != NULL ? (ImportTable[i].ObjectPackageName!=NULL?".":"") + ImportTable[i].ObjectName : "");
                var classFormatted = (ImportTable[i].ClassPackageName != NULL ? ImportTable[i].ClassPackageName : "") + (ImportTable[i].ClassName != NULL ? (ImportTable[i].ClassPackageName!=NULL?".":"") + ImportTable[i].ClassName : "");
                ImportTable[i].AbsoluteObjectReference = objFormatted;
                ImportTable[i].AbsoluteObjectTypeReference = classFormatted;
                ImportTable[i].IsClassType = classFormatted.Equals("Core.Class", StringComparison.OrdinalIgnoreCase);
            }

            for (var i = 0; i < ExportTable.Length; i++)
            {
                ExportTable[i].ClassName = FindReferenceName(ExportTable[i].ClassReference);
                ExportTable[i].ClassParentName = FindReferenceName(ExportTable[i].SuperReference);
                ExportTable[i].ObjectPackageName = FindReferenceName(ExportTable[i].PackageReference);
                ExportTable[i].ObjectName = GetName(ExportTable[i].ObjectNameReference);

                var objFormatted = (ExportTable[i].ObjectPackageName != NULL ? ExportTable[i].ObjectPackageName : "") + (ExportTable[i].ObjectName != NULL ? (ExportTable[i].ObjectPackageName!=NULL?".":"") + ExportTable[i].ObjectName : "");
                var classFormatted = (ExportTable[i].ClassParentName != NULL ? ExportTable[i].ClassParentName : "") + (ExportTable[i].ClassName != NULL ? (ExportTable[i].ClassParentName!=NULL?".":"") + ExportTable[i].ClassName : "");
                ExportTable[i].AbsoluteObjectReference = string.Format("{0}.{1}", PackageName, objFormatted);
                ExportTable[i].AbsoluteObjectTypeReference = classFormatted;
                ExportTable[i].IsClassType = classFormatted.Equals("Core.Class", StringComparison.OrdinalIgnoreCase);
            }

            //--------------- READ ALL OBJECTS EXPORTED -----------------------

            #region Objects

            //Log("Reading objects", 0);
            for (var i = 0; i < ExportTable.Length; i++)
            {
                var entry = ExportTable[i];
                var activeObject = new SBObject
                {
                    Class = new SBClass(),
                    Flags = new List<ObjectFlags>(),
                    ClassName = entry.ClassName,
                    PackageName = entry.ObjectPackageName,
                    ObjectName = entry.ObjectName,
                };
                var obj = ReadObject(activeObject, fileReader, entry);
                if (obj != null)
                {
                    try
                    {
                        PackageImportResolver.ObjectsByName.Add(entry.AbsoluteObjectReference, obj);
                        AddResource(entry.AbsoluteObjectReference, obj);
                    }catch(Exception e)
                    {
                        Logger.LogError(string.Format("Duplicate object name: {0}", entry.AbsoluteObjectReference));
                        //Logger.LogError(e.Message+" ("+entry.AbsoluteObjectReference+")");
                    }
                }
            }
            Logger.LogOk(string.Format("{0} Objects read", ExportTable.Length));

            #endregion

        }

        SBPackageResource ReadObject(SBObject activeObject, SBFileReader fileReader, ExportEntry entry)
        {            

            //Currently we cannot read null class
            if (entry.SerialSize <= 0 || activeObject.ClassName == NULL) return null;

            //Read Object data if present
            fileReader.Seek(entry.SerialOffset, SeekOrigin.Begin);

            if (ReflectionHelper.CanSkipExport(activeObject.ClassName))
            {
                fileReader.Seek(entry.SerialSize, SeekOrigin.Current);
                return null;
            }

            var realType = ReflectionHelper.GetTypeFromName(activeObject.ClassName);
            SBPackageResource realObject = null;
            if (realType != null)
            {
                realObject = Activator.CreateInstance(realType) as SBPackageResource;
            }

            if (realObject == null)
            {
                Logger.LogError("Could not create instance from class name: " + activeObject.ClassName);
                return null;
            }

            //If Object has a stack, read it but do nothing with it
            var hasExecutionStack = false;
            if ((entry.ObjectFlags & (int)ObjectFlags.RF_HasStack) != 0)
            {
                hasExecutionStack = true;
                activeObject.Flags.Add(ObjectFlags.RF_HasStack);
            }
            if (hasExecutionStack)
            {
                var stateFrameNode = fileReader.ReadIndex();
                fileReader.ReadIndex();
                fileReader.ReadInt64();
                fileReader.ReadInt32();
                if (stateFrameNode != 0)
                {
                    fileReader.ReadIndex();
                }
            }
            if (activeObject.ClassName.EndsWith("TerrainInfo"))
            {
                bool breakHere = true;
            }
            ReadProperties(fileReader, realObject, entry);

            //Try to read class
            string className;
            if (activeObject.ClassName.Contains("("))
            {
                className = activeObject.ClassName.Substring(0, activeObject.ClassName.IndexOf("(", StringComparison.Ordinal) - 1).Trim();
            }
            else
            {
                className = activeObject.ClassName;
            }
            switch (className)
            {
                case "Const":
                    activeObject.Class = ReadConstClass(fileReader);
                    break;
                case "Enum":
                    activeObject.Class = ReadEnumClass(fileReader);
                    break;
                case "Property":
                    activeObject.Class = ReadPropertyClass(fileReader);
                    break;
                case "ByteProperty":
                    activeObject.Class = ReadBytePropertyClass(fileReader);
                    break;
                case "ObjectProperty":
                    activeObject.Class = ReadObjectPropertyClass(fileReader);
                    break;
                case "FixedArrayProperty":
                    activeObject.Class = ReadFixedArrayPropertyClass(fileReader);
                    break;
                case "ArrayProperty":
                    activeObject.Class = ReadArrayPropertyClass(fileReader);
                    break;
                case "MapProperty":
                    activeObject.Class = ReadMapPropertyClass(fileReader);
                    break;
                case "ClassProperty":
                    activeObject.Class = ReadClassPropertyClass(fileReader);
                    break;
                case "StructProperty":
                    activeObject.Class = ReadStructPropertyClass(fileReader);
                    break;
                case "IntProperty":
                    activeObject.Class = ReadIntPropertyClass(fileReader);
                    break;
                case "BoolProperty":
                    activeObject.Class = ReadBoolPropertyClass(fileReader);
                    break;
                case "FloatProperty":
                    activeObject.Class = ReadFloatPropertyClass(fileReader);
                    break;
                case "NameProperty":
                    activeObject.Class = ReadNamePropertyClass(fileReader);
                    break;
                case "StrProperty":
                    activeObject.Class = ReadStrPropertyClass(fileReader);
                    break;
                case "StringProperty":
                    activeObject.Class = ReadIntPropertyClass(fileReader);
                    break;
                case "Struct":
                    activeObject.Class = ReadStructClass(fileReader);
                    break;
                case "Function":
                    activeObject.Class = ReadFunctionClass(fileReader);
                    break;
                case "State":
                    activeObject.Class = ReadStateClass(fileReader);
                    break;
                case NULL:
                case NONE:
                    activeObject.Class = ReadNullClass(fileReader);
                    break;
                default:
                    //Log("Encountered unknown class while reading properties", 1);
                    break;
            }
            if (activeObject.Class != null && activeObject.Class.Name != NULL)
            {
                Logger.LogWarning("!Wow, a class was read!");
                System.Console.ReadKey();
            }
            return realObject;
        }

        /// <summary>
        /// Read all of <paramref name="activeObject"/>'s properties
        /// </summary>
        void ReadProperties(SBFileReader fileReader, SBPackageResource activeObject, ExportEntry entry)
        {
            var allPropsSize = 0;
            do
            {
                var propBytesRead = 0;
                var activeProperty = ReadProperty(activeObject, fileReader, out propBytesRead);
                allPropsSize += propBytesRead;
                if (activeProperty == null)
                {
                    break;
                }
                var targetField = ReflectionHelper.FindField(activeObject, activeProperty.Name);
                if (targetField == null)
                {
                    throw new Exception(string.Format("Field: {0} doesn't exist for: {1} ", activeProperty.Name, activeObject));
                }
                if (ReflectionHelper.IsMarkedAsIgnored(targetField))
                {
                    allPropsSize = entry.SerialSize;
                    break;
                } 
                var propValue = ReadPropertyValue(activeObject, fileReader, activeProperty, out propBytesRead);
                allPropsSize += propBytesRead;
                if (propValue != null)
                {
                    ReflectionHelper.TrySetFieldValue(activeObject, targetField, propValue, activeProperty.ArrayIndex, RegisterImport);
                }     
            } while (fileReader.Position < entry.SerialOffset + entry.SerialSize);
            if (allPropsSize != entry.SerialSize)
            {
                var diff = entry.SerialSize - allPropsSize;
                //if (diff > 17) //ignore appended 'Standard' data (not sure if standard, but it's appended to a lot of objects (in map files!)
                //{
                //    Logger.LogWarning(string.Format("{1} has {0} bytes of additional data appended", diff, activeObject.ReferenceObjectName));
                //}
                fileReader.Seek(diff, SeekOrigin.Current);
            }
        }

        SBProperty ReadProperty(object activeObject, SBFileReader fileReader, out int returnBytesRead)
        {
            var readIndexBytes = 0;
            var activeProperty = new SBProperty();
            var propertyNameIndex = fileReader.ReadIndex(out readIndexBytes);
            returnBytesRead = readIndexBytes;
            try
            {
                activeProperty.Name = GetName(propertyNameIndex);
            }
            catch (IndexOutOfRangeException)
            {
                Logger.LogError("Error: failed to read a Property's name for: " + activeObject);
                return null;
            }
            //Detect end of property list
            if (activeProperty.Name == "DRFORTHEWIN" || activeProperty.Name == NONE)
                return null;

            //Read the property info byte
            var infoByte = fileReader.ReadByte();
            returnBytesRead += 1;

            const byte typeMask = 0x0F;
            const byte sizeMask = 0x70;
            const byte arrayIndexMask = 0x80;

            //Parse property info byte
            var type = (byte)(infoByte & typeMask);
            var size = (byte)((infoByte & sizeMask) >> 4);
            var arrayIndexBit = (byte)(infoByte & arrayIndexMask);

            activeProperty.Type = (PropertyType)type;

            //If type = struct, you have to read its name (but not always)
            if (activeProperty.Type == PropertyType.StructProperty)
            {
                var structNameIndex = fileReader.ReadIndex(out readIndexBytes);
                returnBytesRead += readIndexBytes;
                activeProperty.StructName = GetName(structNameIndex);
            }

            //Display value if not array flag but boolean value
            if (activeProperty.Type == PropertyType.BooleanProperty)
            {
                activeProperty.boolValue = arrayIndexBit > 0;
            }
            else
            {
                if (arrayIndexBit != 0)
                {
                    //new (something was wrong with the original method)
                    if (arrayIndexBit < 128)
                    {
                        activeProperty.ArrayIndex = arrayIndexBit;
                    }
                    else
                    {
                        var b = fileReader.ReadByte() & 0x0C; //not sure if correct, but works
                        returnBytesRead += 1;
                        if (b < 128)
                        {
                            activeProperty.ArrayIndex = b;
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
            }
            var realSize = 0;
            //Read real size
            if (size == 0)
                realSize = 1;
            else if (size == 1)
                realSize = 2;
            else if (size == 2)
                realSize = 4;
            else if (size == 3)
                realSize = 12;
            else if (size == 4)
                realSize = 16;
            else if (size == 5)
            {
                realSize = fileReader.ReadByte();
                returnBytesRead += 1;
            }
            else if (size == 6)
            {
                realSize = fileReader.ReadInt16();
                returnBytesRead += 2;
            }
            else if (size == 7)
            {
                realSize = fileReader.ReadInt32();
                returnBytesRead += 4;
            }
            activeProperty.SerialSize = realSize;
            return activeProperty;
        }

        object ReadPropertyValue(object activeObject, SBFileReader fileReader, SBProperty activeProperty, out int propValueBytesRead)
        {
            var readIndexBytes = 0;
            switch (activeProperty.Type)
            {
                case PropertyType.BooleanProperty:
                    if (activeProperty.SerialSize == 1)
                    {
                        propValueBytesRead = 1;
                        return fileReader.ReadByte() > 0;
                    }
                    propValueBytesRead = 0;
                    return activeProperty.boolValue;
                case PropertyType.ByteProperty:
                    propValueBytesRead = 1;
                    return fileReader.ReadByte();
                case PropertyType.IntegerProperty:
                    propValueBytesRead = 4;
                    return fileReader.ReadInt32();
                case PropertyType.FloatProperty:
                    propValueBytesRead = 4;
                    return fileReader.ReadFloat();
                case PropertyType.NameProperty:
                    return GetName(fileReader.ReadIndex(out propValueBytesRead));
                case PropertyType.StringProperty:
                case PropertyType.StrProperty:
                    var stringSize = fileReader.ReadIndex(out readIndexBytes);
                    propValueBytesRead = readIndexBytes;
                    var stringBytes = fileReader.ReadBytes(stringSize);
                    var stringValue = Encoding.ASCII.GetString(stringBytes).Replace("\0", string.Empty);
                    propValueBytesRead += stringSize;
                    return stringValue;
                case PropertyType.ObjectProperty:
                    var objectReference = fileReader.ReadIndex(out readIndexBytes);
                    propValueBytesRead = readIndexBytes;
                    var obj = FindAbsoluteObjectReference(objectReference);
                    var isClass = false;
                    if (!obj.Equals(NULL, StringComparison.OrdinalIgnoreCase))
                    {
                        if (objectReference < 0)
                        {
                            var importRef = ImportTable[-objectReference - 1];
                            if (importRef.IsClassType)
                            {
                                isClass = true;
                            }
                        }
                        else
                        {
                            var exportRef = ExportTable[objectReference - 1];
                            if (exportRef.IsClassType)
                            {
                                isClass = true;
                            }
                        }
                        return new ImportLink(obj, null) { IsTypeReference = isClass, indexReference = activeProperty.ArrayIndex };
                    }
                    else
                    {
                        return null;
                    }
                case PropertyType.VectorProperty:
                    propValueBytesRead = 12;
                    return new Vector(fileReader.ReadFloat(), fileReader.ReadFloat(), fileReader.ReadFloat());
                case PropertyType.RotatorProperty:
                    propValueBytesRead = 12;
                    return new Rotator(fileReader.ReadInt32(), fileReader.ReadInt32(), fileReader.ReadInt32());
                case PropertyType.StructProperty:
                    if (activeProperty.StructName == "Vector")
                    {
                        propValueBytesRead = 12;
                        return new Vector(fileReader.ReadFloat(), fileReader.ReadFloat(), fileReader.ReadFloat());
                    }
                    else if (activeProperty.StructName == "Rotator")
                    {
                        propValueBytesRead = 12;
                        return new Rotator(fileReader.ReadInt32(), fileReader.ReadInt32(), fileReader.ReadInt32());
                    }
                    else if (activeProperty.StructName == "Color")
                    {
                        propValueBytesRead = 4;
                        return new Color(fileReader.ReadByte(), fileReader.ReadByte(), fileReader.ReadByte(), fileReader.ReadByte());
                    }
                    else if (activeProperty.StructName == "LinearColor")
                    {
                        propValueBytesRead = 16;
                        return new Color(
                            (byte)(1f / 255 * fileReader.ReadFloat()), 
                            (byte)(1f / 255 * fileReader.ReadFloat()), 
                            (byte)(1f / 255 * fileReader.ReadFloat()),
                            (byte)(1f / 255 * fileReader.ReadFloat()));
                    }
                    else if (activeProperty.StructName == "LocalizedString")
                    {
                        propValueBytesRead = 4;
                        return new LocalizedString(fileReader.ReadInt32());
                    }
                    else
                    {
                        if (activeProperty.StructName.Length == 0) throw new Exception("This should not happen");
                        var type = ReflectionHelper.GetTypeFromName(activeProperty.StructName);
                        if (type == null)
                        {
                            Logger.LogError("Type not found for struct: " + activeProperty.StructName);
                            propValueBytesRead = 0;
                            return null;
                        }
                        var realStruct = FormatterServices.GetUninitializedObject(type);
                        if (realStruct == null) throw new Exception("This should not happen");
                        var structBytesRead = 0;
                        do
                        {
                            var structPropBytesRead = 0;
                            var structProp = ReadProperty(realStruct, fileReader, out structPropBytesRead);
                            structBytesRead += structPropBytesRead;
                            if (structProp == null)
                            {
                                break;
                            }
                            var targetField = realStruct.GetType().GetField(structProp.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase);
                            if (targetField == null) throw new Exception("Field does not exist in struct");
                            if (ReflectionHelper.IsMarkedAsIgnored(targetField))
                            {
                                fileReader.Seek(structProp.SerialSize - structPropBytesRead, SeekOrigin.Current);
                                continue;
                            }
                            var propValue = ReadPropertyValue(realStruct, fileReader, structProp, out structPropBytesRead);
                            structBytesRead += structPropBytesRead;
                            if (propValue != null)
                            {
                                ReflectionHelper.TrySetFieldValue(realStruct, targetField, propValue, structProp.ArrayIndex, RegisterImport);
                            }
                        } while (true);
                        propValueBytesRead = structBytesRead;
                        return realStruct;
                    }
                case PropertyType.ArrayProperty:
                    var arrayField = ReflectionHelper.FindField(activeObject, activeProperty.Name);
                    if (arrayField == null)
                    {
                        throw new NullReferenceException("Field must exist");
                    }
                    if (ReflectionHelper.IsMarkedAsIgnored(arrayField))
                    {
                        throw new Exception("This should not happen. Parent must filter ignored fields");
                    }
                    Type arrayType;
                    Type arrayContentType;
                    var arrayContentUType = ReflectionHelper.GetArrayType(activeObject, activeProperty.Name, out arrayType, out arrayContentType);
                    if (arrayContentUType == PropertyType.UnknownProperty) throw new Exception("should not happen");
                    var arraySize = fileReader.ReadIndex(out readIndexBytes);
                    propValueBytesRead = readIndexBytes;
                    //if array
                    if (arrayType.IsArray)
                    {
                        var array = Array.CreateInstance(arrayContentType, arraySize);
                        var arrayBytesRead = 0;
                        for (var i = 0; i < arraySize; i++)
                        {
                            var arrayContentProp = new SBProperty { Type = arrayContentUType, StructName = arrayContentType.Name };
                            var propBytesRead = 0;
                            object arrayContent = null;
                            arrayContent = ReadPropertyValue(activeObject, fileReader, arrayContentProp, out propBytesRead);
                            arrayBytesRead += propBytesRead;
                            if (arrayContent != null)
                            {
                                ReflectionHelper.TrySetArrayValue(array, arrayContent, i, arrayContentType, RegisterImport);
                            }
                        }
                        propValueBytesRead += arrayBytesRead;
                        return array;
                    }
                    else
                    {
                        //if list
                        if (arrayType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            var listType = typeof(List<>);
                            listType = listType.MakeGenericType(arrayContentType);
                            var list = Activator.CreateInstance(listType) as IList;
                            var elementType = listType.GetGenericArguments()[0];
                            for (int i = 0; i < arraySize; i++) //resize
                            {
                                list.Add(elementType.IsValueType ? Activator.CreateInstance(elementType) : null);
                            }
                            var listBytesRead = 0;
                            for (var i = 0; i < arraySize; i++)
                            {
                                var listContentProp = new SBProperty { Type = arrayContentUType, StructName = arrayContentType.Name };
                                var propBytesRead = 0;
                                object listContent = null;
                                listContent = ReadPropertyValue(activeObject, fileReader, listContentProp, out propBytesRead);
                                listBytesRead += propBytesRead;
                                if (listContent != null)
                                {
                                    ReflectionHelper.TrySetListValue(list, listContent, arrayContentType, i, RegisterImport);
                                }
                            }
                            propValueBytesRead += listBytesRead;
                            return list;
                        }
                        throw new Exception("should not happen");
                    }
                default:
                    fileReader.Seek(activeProperty.SerialSize, SeekOrigin.Current);
                    Logger.LogError("unhandled switch case: " + activeProperty.Type);
                    propValueBytesRead = activeProperty.SerialSize;
                    return null;
            }
        }

        #region Class reading Specific
        SBClass ReadFieldClass(SBFileReader reader)
        {
            var superField = reader.ReadIndex();
            var next = reader.ReadIndex();
            var field = new SBClass();
            field.Name = "Field";
            field.Fields.Add("SuperField", superField.ToString());
            field.Fields.Add("Next", next.ToString());
            return field;
        }

        SBClass ReadConstClass(SBFileReader reader)
        {
            var constClass = new SBClass();
            constClass.Ancestor = ReadFieldClass(reader);
            constClass.Name = "Const";

            var size = reader.ReadIndex();
            var constant = Encoding.ASCII.GetString(reader.ReadBytes(size)).Replace("\0", string.Empty);
            constClass.Fields.Add("Size", size.ToString());
            constClass.Fields.Add("Constant", constant);
            return constClass;
        }

        SBClass ReadEnumClass(SBFileReader reader)
        {
            var enumClass = new SBClass();
            enumClass.Name = "Enum";
            enumClass.Ancestor = ReadFieldClass(reader);
            var arraySize = reader.ReadIndex();
            enumClass.Fields.Add("ArraySize", arraySize.ToString());
            for (var i = 0; i < arraySize; ++i)
            {
                enumClass.Fields.Add("ElementName" + i, GetName(reader.ReadIndex()));
            }

            return enumClass;
        }

        SBClass ReadPropertyClass(SBFileReader reader)
        {
            var property = new SBClass();
            property.Name = "Property";
            property.Ancestor = ReadFieldClass(reader);

            var arrayDimension = reader.ReadInt16();
            var elementSize = reader.ReadInt16();
            var propertyFlags = reader.ReadInt32();
            var category = reader.ReadIndex();
            property.Fields.Add("ArrayDimension", arrayDimension.ToString());
            property.Fields.Add("ElementSize", elementSize.ToString());
            property.Fields.Add("PropertyFlags", propertyFlags.ToString());
            property.Fields.Add("Category", GetName(category));
            if ((propertyFlags & (int)PropertyFlags.CPF_Net) != 0)
            {
                int replicationOffset = reader.ReadInt16();
                property.Fields.Add("Replication Offset", replicationOffset.ToString());
            }

            return property;
        }

        SBClass ReadBytePropertyClass(SBFileReader reader)
        {
            var byteProperty = new SBClass();
            byteProperty.Name = "ByteProperty";
            byteProperty.Ancestor = ReadPropertyClass(reader);
            var enumType = reader.ReadIndex();
            byteProperty.Fields.Add("EnumType", enumType.ToString());

            return byteProperty;
        }

        SBClass ReadObjectPropertyClass(SBFileReader reader)
        {
            var objectProperty = new SBClass();
            objectProperty.Name = "ObjectProperty";
            objectProperty.Ancestor = ReadPropertyClass(reader);
            var objectType = reader.ReadIndex();
            objectProperty.Fields.Add("ObjectType", FindReferenceName(objectType));

            return objectProperty;
        }

        SBClass ReadFixedArrayPropertyClass(SBFileReader reader)
        {
            var fixedArrayProperty = new SBClass();
            fixedArrayProperty.Name = "FixedArrayProperty";
            fixedArrayProperty.Ancestor = ReadPropertyClass(reader);

            var inner = reader.ReadIndex();
            var count = reader.ReadIndex();

            fixedArrayProperty.Fields.Add("Inner", FindReferenceName(inner));
            fixedArrayProperty.Fields.Add("Count", FindReferenceName(count));

            return fixedArrayProperty;
        }

        SBClass ReadArrayPropertyClass(SBFileReader reader)
        {
            var arrayProperty = new SBClass();
            arrayProperty.Name = "ArrayProperty";
            arrayProperty.Ancestor = ReadPropertyClass(reader);

            var inner = reader.ReadIndex();

            arrayProperty.Fields.Add("Inner", FindReferenceName(inner));

            return arrayProperty;
        }

        SBClass ReadMapPropertyClass(SBFileReader reader)
        {
            var mapProperty = new SBClass();
            mapProperty.Name = "MapProperty";
            mapProperty.Ancestor = ReadPropertyClass(reader);

            var key = reader.ReadIndex();
            var value = reader.ReadIndex();

            mapProperty.Fields.Add("Key", key.ToString());
            mapProperty.Fields.Add("Value", value.ToString());

            return mapProperty;
        }

        SBClass ReadClassPropertyClass(SBFileReader reader)
        {
            var classProperty = new SBClass();
            classProperty.Name = "ClassProperty";
            classProperty.Ancestor = ReadPropertyClass(reader);

            var mclass = reader.ReadIndex();
            classProperty.Fields.Add("Class", GetName(mclass));

            return classProperty;
        }

        SBClass ReadStructPropertyClass(SBFileReader reader)
        {
            var structProperty = new SBClass();
            structProperty.Name = "StructProperty";
            structProperty.Ancestor = ReadPropertyClass(reader);

            var structType = reader.ReadIndex();

            structProperty.Fields.Add("StructType", structType.ToString());

            return structProperty;
        }

        SBClass ReadIntPropertyClass(SBFileReader reader)
        {
            var intProperty = new SBClass();
            intProperty.Name = "IntProperty";
            intProperty.Ancestor = ReadPropertyClass(reader);

            return intProperty;
        }

        SBClass ReadBoolPropertyClass(SBFileReader reader)
        {
            var boolProperty = new SBClass();
            boolProperty.Name = "BoolProperty";
            boolProperty.Ancestor = ReadPropertyClass(reader);

            return boolProperty;
        }

        SBClass ReadFloatPropertyClass(SBFileReader reader)
        {
            var floatProperty = new SBClass();
            floatProperty.Name = "FloatProperty";
            floatProperty.Ancestor = ReadPropertyClass(reader);

            return floatProperty;
        }

        SBClass ReadNamePropertyClass(SBFileReader reader)
        {
            var nameProperty = new SBClass();
            nameProperty.Name = "NameProperty";
            nameProperty.Ancestor = ReadPropertyClass(reader);

            return nameProperty;
        }

        SBClass ReadStrPropertyClass(SBFileReader reader)
        {
            var strProperty = new SBClass();
            strProperty.Name = "StrProperty";
            strProperty.Ancestor = ReadPropertyClass(reader);

            return strProperty;
        }

        SBClass ReadStringPropertyClass(SBFileReader reader)
        {
            var stringProperty = new SBClass();
            stringProperty.Name = "StringProperty";
            stringProperty.Ancestor = ReadPropertyClass(reader);

            return stringProperty;
        }

        SBClass ReadStructClass(SBFileReader reader)
        {
            var structClass = new SBClass();
            structClass.Name = "Struct";
            structClass.Ancestor = ReadFieldClass(reader);
            var scriptText = reader.ReadIndex();
            var children = reader.ReadIndex();
            var friendlyName = reader.ReadIndex();
            var line = reader.ReadInt32();
            var textPos = reader.ReadInt32();
            var scriptSize = reader.ReadInt32();
            //Try to "eat" the script code for children classes, but according
            //to the doc, it should not work, we have to reverse the bytecode...
            if (scriptSize > 0)
                reader.ReadBytes(scriptSize);
            structClass.Fields.Add("ScriptText", FindReferenceName(scriptText));
            structClass.Fields.Add("Children", FindReferenceName(children));
            structClass.Fields.Add("FriendlyName", GetName(friendlyName));
            structClass.Fields.Add("Line", line.ToString());
            structClass.Fields.Add("TextPos", textPos.ToString());
            structClass.Fields.Add("ScriptSize", scriptSize.ToString());

            return structClass;
        }

        SBClass ReadFunctionClass(SBFileReader reader)
        {
            var function = new SBClass();
            function.Name = "Function";
            function.Ancestor = ReadStructClass(reader);

            var inative = reader.ReadInt16();
            var operatorPrecedence = reader.ReadByte();
            var functionFlags = reader.ReadInt32();
            function.Fields.Add("iNative", inative.ToString());
            function.Fields.Add("OperatorPrecedence", operatorPrecedence.ToString());
            function.Fields.Add("FunctionFlags", functionFlags.ToString());

            if ((functionFlags & (int)FunctionFlags.FUNC_Net) != 0)
            {
                var replicationOffset = reader.ReadInt16();
                function.Fields.Add("ReplicationOffset", replicationOffset.ToString());
            }

            return function;
        }

        SBClass ReadStateClass(SBFileReader reader)
        {
            var state = new SBClass();
            state.Name = "State";
            state.Ancestor = ReadStructClass(reader);

            var probeMask = reader.ReadInt64();
            var ignoreMask = reader.ReadInt64();
            var labelTableOffset = reader.ReadInt16();
            var stateFlags = reader.ReadInt32();

            state.Fields.Add("ProbeMask", probeMask.ToString());
            state.Fields.Add("IgnoreMask", ignoreMask.ToString());
            state.Fields.Add("LabelTableOffset", labelTableOffset.ToString());
            state.Fields.Add("StateFlags", stateFlags.ToString());

            return state;
        }

        SBClass ReadNullClass(SBFileReader reader)
        {
            var nullClass = new SBClass();
            nullClass.Name = NULL;
            nullClass.Ancestor = ReadStateClass(reader);

            var classFlags = reader.ReadInt32();
            var classGuid = reader.ReadInt32();
            var dependencies_count = reader.ReadIndex();
            //for now skip the dependencies, just "eat" them
            for (var i = 0; i < dependencies_count; ++i)
            {
                reader.ReadIndex(); //Class
                reader.ReadInt32(); //Deep
                reader.ReadInt32(); //ScriptTextCRC
            }
            var packageImports_count = reader.ReadIndex();
            //for now skip the package Imports, just "eat" them
            for (var i = 0; i < packageImports_count; ++i)
                reader.ReadIndex(); //PackageImport
            var classWithin = reader.ReadIndex();
            var classConfigName = reader.ReadIndex();

            nullClass.Fields.Add("ClassFlags", classFlags.ToString());
            nullClass.Fields.Add("ClassGuid", classGuid.ToString());
            nullClass.Fields.Add("Dependencies Count", dependencies_count.ToString());
            nullClass.Fields.Add("Package Imports Count", packageImports_count.ToString());
            nullClass.Fields.Add("Class Within", FindReferenceName(classWithin));
            nullClass.Fields.Add("Class Config Name", GetName(classConfigName));

            return nullClass;
        }

        [StructLayout(LayoutKind.Sequential, Size = 44, Pack = 1)]
        struct GlobalHeader
        {
            public uint Signature;
            public short FileVersion;
            public short LicenseeMode;
            public uint PackageFlags;
            public uint NameCount;
            public uint NameOffset;
            public uint ExportCount;
            public uint ExportOffset;
            public uint ImportCount;
            public uint ImportOffset;
            public uint HeritageCount;
            public uint HeritageOffset;
        }

        class ImportEntry
        {
            //public Type ObjectType;
            /// <summary>
            /// [NameTableIndex] Package (namespace) in which the type/class of the object is defined
            /// </summary>
            public int ClassPackageReference;
            /// <summary>
            /// [NameTableIndex] type/class of the object 
            /// </summary>
            public int ClassReference;
            /// <summary>
            /// [ObjectReference] Package file where the object resides in
            /// </summary>
            public int PackageReference;
            /// <summary>
            /// [NameTableIndex] name of the object
            /// </summary>
            public int ObjectReference;
            

            /// <summary>
            /// Namespace (package) of imported object type/class
            /// </summary>
            public string ClassPackageName;
            /// <summary>
            /// Type/class of imported object
            /// </summary>
            public string ClassName;

            /// <summary>
            /// Package of imported object
            /// </summary>
            public string ObjectPackageName;
            /// <summary>
            /// Name of imported object
            /// </summary>
            public string ObjectName;

            public string AbsoluteObjectReference;
            public string AbsoluteObjectTypeReference;
            public bool IsClassType;

            public override string ToString()
            {
                return string.Format("{0} ({1})", AbsoluteObjectReference, AbsoluteObjectTypeReference);
            }
        }

        struct ExportEntry
        {

            //public Type ObjectType;
            /// <summary>
            /// [ObjectReference] class of the object
            /// </summary>
            public int ClassReference;      
            /// <summary>
            /// [ObjectReference] object parent
            /// </summary>
            public int SuperReference;  
            /// <summary>
            /// [ObjectReference] internal package/group of the object
            /// </summary>
            public int PackageReference;      
            /// <summary>
            /// [NameTableIndex] name of the object
            /// </summary>
            public int ObjectNameReference;

            public int ObjectFlags;
            public int SerialSize;
            public int SerialOffset;

            /// <summary>
            /// Type of the exported object (can be imported or exported)
            /// </summary>
            public string ClassName;
            /// <summary>
            /// 'Parent' Type of the exported object
            /// </summary>
            public string ClassParentName;
            /// <summary>
            /// Namespace (Package) of the object
            /// </summary>
            public string ObjectPackageName;
            /// <summary>
            /// Name of exported object
            /// </summary>
            public string ObjectName;

            public string AbsoluteObjectReference;
            public string AbsoluteObjectTypeReference;
            public bool IsClassType;

            public override string ToString()
            {
                return string.Format("{0} ({1})", AbsoluteObjectReference, AbsoluteObjectTypeReference);
            }
        }

        class SBProperty
        {
            public int ArrayIndex;
            public string Name = "";
            public int SerialSize;
            public string StructName = "";
            public PropertyType Type;
            public bool boolValue;
        }

        class SBObject
        {
            public SBClass Class;
            /// <summary>
            /// Type of the object
            /// </summary>
            public string ClassName;
            public List<ObjectFlags> Flags;
            public string ObjectName;
            public string PackageName;

        }

        public class SBClass
        {
            public SBClass Ancestor;
            public Dictionary<string, string> Fields;

            public string HexaDump;
            public string Name;

            public SBClass()
            {
                Name = NULL;
                Fields = new Dictionary<string, string>();
            }
        }


        #endregion
    }
}
