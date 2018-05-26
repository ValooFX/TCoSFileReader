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
using Framework.Attributes;

namespace SBGame
{
    
    
    [System.Serializable] public class FSkill_EffectClass_DuffShare : FSkill_EffectClass_Duff
    {
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public byte EffectType;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public byte AttackType;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public byte MagicType;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public byte Mode;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public float ShareRatio;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public byte Type;
        
        [FieldCategory(Category="Sharing")]
        [FieldConst()]
        public bool IsBloodLink;
        
        [FieldCategory(Category="Uses")]
        [FieldConst()]
        public float UseInterval;
        
        [FieldCategory(Category="Uses")]
        [FieldConst()]
        public int Uses;
        
        [FieldCategory(Category="Uses")]
        [FieldConst()]
        public float IncreasePerUse;
        
        [FieldCategory(Category="SharingFX")]
        [FieldConst()]
        public FSkill_EffectClass_AudioVisual_Emitter SourceFX;
        
        [FieldCategory(Category="SharingFX")]
        [FieldConst()]
        public FSkill_EffectClass_AudioVisual_Emitter TargetFX;
        
        [FieldCategory(Category="Applicant")]
        [FieldConst()]
        [IgnoreFieldExtraction()]
        public string Icon;
        
        [FieldCategory(Category="Applicant")]
        [FieldConst()]
        public string Description = string.Empty;
        
        [FieldConst()]
        public FSkill_ValueSpecifier _ShareValue;
        
        public FSkill_EffectClass_DuffShare()
        {
        }
    }
}
/*
event cl_CombatMessage(export editinline FSkill_Type aSkill,export editinline FSkill_Event_Duff aDuffEvent,Game_Pawn aSource,Game_Pawn aTarget,int aAmount,int aAmount2,int aAmount3) {
local string prefix;
local string Message;
if (Type == 1) {                                                            
if (aTarget != None && aTarget.IsLocalPlayer()) {                         
prefix = Class'StringReferences'.default.EffectSourceText.Text;         
if (aAmount3 == 0) {                                                    
Message = Class'StringReferences'.default.EffectDuffShareReturnSelfEETText.Text;
} else {                                                                
Message = Class'StringReferences'.default.EffectDuffShareReturnSelfText.Text;
}
aTarget.cl_AddScrollingCombatTypeValue(3,-aAmount);                     
} else {                                                                  
prefix = Class'StringReferences'.default.EffectYouText.Text;            
if (aAmount3 == 0) {                                                    
Message = Class'StringReferences'.default.EffectDuffShareReturnTargetEETText.Text;
} else {                                                                
Message = Class'StringReferences'.default.EffectDuffShareReturnTargetText.Text;
}
if (aTarget != None) {                                                  
aTarget.cl_AddScrollingCombatTypeValue(3,-aAmount);                   
}
}
} else {                                                                    
if (aTarget != None && aTarget.IsLocalPlayer()) {                         
prefix = Class'StringReferences'.default.EffectSourceText.Text;         
if (aAmount3 == 0) {                                                    
Message = Class'StringReferences'.default.EffectDuffShareDivideSelfEETText.Text;
} else {                                                                
Message = Class'StringReferences'.default.EffectDuffShareDivideSelfText.Text;
}
aTarget.cl_AddScrollingCombatTypeValue(3,-aAmount);                     
} else {                                                                  
prefix = Class'StringReferences'.default.EffectYouText.Text;            
if (aAmount3 == 0) {                                                    
Message = Class'StringReferences'.default.EffectDuffShareDivideTargetEETText.Text;
} else {                                                                
Message = Class'StringReferences'.default.EffectDuffShareDivideTargetText.Text;
}
if (aTarget != None) {                                                  
aTarget.cl_AddScrollingCombatTypeValue(3,-aAmount);                   
}
}
}
cl_CombatLogMessage(prefix,Message,aSkill,aDuffEvent,aSource,aTarget,aAmount,aAmount2,aAmount3);
}
final native function float GetShareEffect(float aSkillValue,int aNumUses);
final native function bool MatchEffect(byte aShareType,byte aAttackType,byte aMagicType,byte aEffectType);
*/