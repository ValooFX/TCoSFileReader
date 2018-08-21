﻿using System;
using Engine;
using UnityEngine;

namespace SBGame
{
    [Serializable]
    public class Game_EquippedAppearance: Game_Appearance
    {
        public byte mHead;

        public int mChestClothes;

        public byte mLeftGlove;

        public byte mRightGlove;

        public byte mPants;

        public byte mShoes;

        public byte mHeadGearArmour;

        public byte mLeftShoulderArmour;

        public byte mRightShoulderArmour;

        public byte mLeftGauntlet;

        public byte mRightGauntlet;

        public byte mChestArmour;

        public byte mBelt;

        public byte mLeftThigh;

        public byte mRightThigh;

        public byte mLeftShin;

        public byte mRightShin;

        public byte mMainWeapon;

        public byte mOffhandWeapon;

        public byte mHair;

        public byte mMainSheath;

        public byte mOffhandSheath;

        [ArraySizeForExtraction(Size = 4)]
        public byte[] mTattoo = new byte[0];

        [ArraySizeForExtraction(Size = 4)]
        public byte[] mClassTattoo = new byte[0];

        public byte mBodyColor;

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mChestClothesColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mLeftGloveColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mRightGloveColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mPantsColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mShoesColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mHeadGearArmourColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mLeftShoulderArmourColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mRightShoulderArmourColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mLeftGauntletColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mRightGauntletColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mChestArmourColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mBeltColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mLeftThighColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mRightThighColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mLeftShinColors = new byte[0];

        [ArraySizeForExtraction(Size = 2)]
        public byte[] mRightShinColors = new byte[0];

        public byte mHairColor;

        public bool mDisplayLogo;

        public Appearance_Set mAppearanceSet;

        public float mFreezeTime;

        public float mFreezeStart;

        public bool mIgnoreCoversFlags;

        public bool GetDisplayLogo()
        {
            return mDisplayLogo;
        }
        public byte GetHead()
        {
            return mHead;
        }
        public void SetDisplayLogo(bool aNewVal)
        {
            mDisplayLogo = aNewVal;
        }
        public void SetHead(byte aNewVal)
        {
            mHead = aNewVal;
        }

        public override void cl_OnFrame(float DeltaTime)
        {
            if (mFreezeTime > 0)
            {
                if (Time.realtimeSinceStartup - mFreezeStart >= mFreezeTime)
                {
                    mFreezeTime = 0f;
                    (Outer as Game_Pawn).CharacterStats.FreezeMovement(false);
                }
            }
            base.cl_OnFrame(DeltaTime);
        }
    }
}
/*
protected native function string cl_GetPartName(byte aPart);
native function Texture GetBodyPalette();
native function Object GetAppearanceResource(byte aPartType,int aIndex);
native function bool Compatible(Appearance_Base Base,bool IsCharacterCreation);
native event CheckCompatibility(bool IsCharacterCreation);
native function SetRandom(int aMeshMaterialBits,int aColorBits,bool aFullRandomColors,bool IsCharacterCreation,optional bool LockGloves,optional bool LockGauntlets,optional bool LockShoulderArmour,optional bool LockArmTattoos);
function Appearance_Set GetAppearanceSet() {
return mAppearanceSet;                                                      
}
protected native function sv2rel_SetColorValue_CallStub();
event sv2rel_SetColorValue(byte aPart,byte aNewValue,byte aIndex) {
SetColorValue(aPart,aNewValue,aIndex);                                      
Apply();                                                                    
}
protected native function sv2rel_SetValue_CallStub();
event sv2rel_SetValue(byte aPart,int aNewValue,byte aIndex) {
SetValue(aPart,aNewValue,aIndex);                                           
Apply();                                                                    
}
native event int GetNetMax(byte aPart);
native function int GetMax(byte aPart);
native function byte GetColorValue(byte aPart,byte aIndex);
native function SneakySetColorValue(byte aPart,byte aNewValue,byte aIndex);
native function SetColorValue(byte aPart,byte aNewValue,byte aIndex);
native function int GetValue(byte aPart,optional byte aIndex);
native function SneakySetValue(byte aPart,int aNewValue,optional byte aIndex);
native function SetValue(byte aPart,int aNewValue,optional byte aIndex);

function app(int A) {
local byte appPart;
local int maxIndex;
local int i;
local int j;
local Appearance_Base appBase;
local Object Obj;
local byte val;
Super.app(A);                                                               
cl_ConsoleMessage("----------------------------");                          
appPart = 0;                                                                
while (appPart <= 23) {                                                     
if (A > 0 && A - 1 != appPart) {                                          
} else {                                                                  
if (appPart != 23 && appPart != 24) {                                   
maxIndex = 1;                                                         
} else {                                                                
maxIndex = 4;                                                         
}
i = 0;                                                                  
while (i < maxIndex) {                                                  
val = GetValue(appPart,i);                                            
Obj = GetAppearanceResource(appPart,val);                             
appBase = Appearance_Base(Obj);                                       
cl_ConsoleMessage("Part [Sirenix.OdinInspector.FoldoutGroup(" $ string(1 + appPart) $ "] "
$ cl_GetPartName(appPart)
$ "[Sirenix.OdinInspector.FoldoutGroup("
$ string(i)
$ "]: ("
$ string(val)
$ ") = "
$ string(Obj));
if (appBase != None && A - 1 == appPart) {                            
cl_ConsoleMessage("    Name:        " $ appBase.Name.Text);         
cl_ConsoleMessage("    Description: " $ appBase.Description.Text);  
cl_ConsoleMessage("    Palette1:    " $ string(appBase.Palette1));  
cl_ConsoleMessage("    Palette2:    " $ string(appBase.Palette2));  
cl_ConsoleMessage("    Part:        " $ string(appBase.Part));      
cl_ConsoleMessage("    Excludes:    " $ string(appBase.ExcludeHumans)
@ string(appBase.ExcludeDaevi)
@ string(appBase.ExcludeMale)
@ string(appBase.ExcludeFemale)
@ string(appBase.ExcludeFat)
@ string(appBase.ExcludeSkinny)
@ string(appBase.ExcludeHulk)
@ string(appBase.ExcludeAthletic));
cl_ConsoleMessage("    Item type:   " $ string(appBase._IT));       
cl_ConsoleMessage("    Set Index:   " $ string(appBase._AS_Index)
@ string(appBase._AS_Set));
cl_ConsoleMessage("    Attachments: "
$ string(appBase.Attachments.Length));
j = 0;                                                              
while (j < appBase.Attachments.Length) {                            
cl_ConsoleMessage("        [Sirenix.OdinInspector.FoldoutGroup(" $ string(j) $ "]: "
$ string(appBase.Attachments[j].SocketId)
@ appBase.Attachments[j].MeshGroup);
j++;                                                              
}
}
i++;                                                                  
}
}
appPart = appPart + 1;                                                    
}
}
function bool Check() {
if (GetAppearanceSet() == None) {                                           
return False;                                                             
}
return Super.Check();                                                       
}

event OnConstruct() {
Super.OnConstruct();                                                        
InitAppearanceSet();                                                        
}
protected native function InitAppearanceSet();
*/
