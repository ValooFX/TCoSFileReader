﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Engine;
using SBAI;
using SBAIScripts;
using SBBase;
using SBGame;
using SBGamePlay;
using SBMiniGames;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Engine
{
    
    
    [System.Serializable] public class ObjectPool : UObject
    {
        
        public List<UObject> Objects = new List<UObject>();
        
        public ObjectPool()
        {
        }
    }
}
/*
simulated function Shrink() {
while (Objects.Length > 0) {                                                
Objects.Remove(Objects.Length - 1,1);                                     
}
}
simulated function FreeObject(Object Obj) {
Objects.Length = Objects.Length + 1;                                        
Objects[Objects.Length - 1] = Obj;                                          
}
simulated function Object AllocateObject(class<Object> ObjectClass) {
local Object Result;
local int ObjectIndex;
ObjectIndex = 0;                                                            
while (ObjectIndex < Objects.Length) {                                      
if (Objects[ObjectIndex].Class == ObjectClass) {                          
Result = Objects[ObjectIndex];                                          
Objects.Remove(ObjectIndex,1);                                          
goto jl005F;                                                            
}
ObjectIndex++;                                                            
}
if (Result == None) {                                                       
Result = new (Outer) ObjectClass;                                         
}
return Result;                                                              
}
*/
