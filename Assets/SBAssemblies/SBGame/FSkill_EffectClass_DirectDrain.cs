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
using SBAssemblies;

namespace SBGame
{
    
    
    [System.Serializable] public class FSkill_EffectClass_DirectDrain : FSkill_EffectClass_Direct
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Drain")]
        [FieldConst()]
        public byte DrainedCharacterStat;
        
        [Sirenix.OdinInspector.FoldoutGroup("Drain")]
        [FieldConst()]
        public byte GainedCharacterStat;
        
        [Sirenix.OdinInspector.FoldoutGroup("Drain")]
        [FieldConst()]
        public FSkill_ValueSpecifier DrainedAmount;
        
        [Sirenix.OdinInspector.FoldoutGroup("Drain")]
        [FieldConst()]
        public float Multiplier;
        
        [Sirenix.OdinInspector.FoldoutGroup("Drain")]
        [FieldConst()]
        public FSkill_ValueSpecifier MultiplierVS;
        
        public FSkill_EffectClass_DirectDrain()
        {
        }
    }
}
/*
event cl_CombatMessage(export editinline FSkill_Type aSkill,export editinline FSkill_Event_Duff aDuffEvent,Game_Pawn aSource,Game_Pawn aTarget,int aAmount,int aAmount2,int aAmount3) {
local string prefix;
local string Message;
if (aSource != None && aSource.IsLocalPlayer()) {                           
prefix = Class'StringReferences'.default.EffectYouText.Text;              
if (DrainedCharacterStat == 3) {                                          
Message = Class'StringReferences'.default.EffectDrainHealthSelfText.Text;
} else {                                                                  
Message = Class'StringReferences'.default.EffectDrainSelfText.Text;     
}
} else {                                                                    
assert(aTarget != None && aTarget.IsLocalPlayer());                       
prefix = Class'StringReferences'.default.EffectSourceText.Text;           
if (DrainedCharacterStat == 3) {                                          
Message = Class'StringReferences'.default.EffectDrainHealthTargetText.Text;
} else {                                                                  
Message = Class'StringReferences'.default.EffectDrainTargetText.Text;   
}
}
cl_CombatLogMessage(prefix,Message,aSkill,None,aSource,aTarget,aAmount,aAmount2,aAmount3);
if (aTarget != None) {                                                      
aTarget.cl_AddScrollingCombatTypeValue(DrainedCharacterStat,-aAmount);    
}
if (aSource != None) {                                                      
aSource.cl_AddScrollingCombatTypeValue(GainedCharacterStat,aAmount3);     
}
CheckAutoTarget(aSource,aTarget);                                           
}
*/
