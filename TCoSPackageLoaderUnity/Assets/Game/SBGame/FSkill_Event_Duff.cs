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
    
    
    [System.Serializable] public class FSkill_Event_Duff : FSkill_Event_FX
    {
        
        [FieldConst()]
        public List<FSkill_Event_Duff_DirectEff> DirectEffects = new List<FSkill_Event_Duff_DirectEff>();
        
        [FieldConst()]
        public List<FSkill_Event_Duff_DuffEff> DuffEffects = new List<FSkill_Event_Duff_DuffEff>();
        
        [FieldConst()]
        public FSkill_Event Event;
        
        [FieldCategory(Category="Events")]
        [FieldConst()]
        public float EventInterval;
        
        [FieldCategory(Category="Events")]
        [FieldConst()]
        public int EventRepeatCount;
        
        [FieldConst()]
        public List<FSkill_Event_Duff_CondEv> ConditionalEvents = new List<FSkill_Event_Duff_CondEv>();

        [FieldCategory(Category = "Duff")]
        [FieldConst()]
        public new LocalizedString Name;

        [FieldCategory(Category="Duff")]
        [FieldConst()]
        [IgnoreFieldExtraction()]
        public string Icon;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public bool Visible;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public LocalizedString Description;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public float Duration;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public byte StackType;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public int StackCount;
        
        [FieldCategory(Category="Duff")]
        [FieldConst()]
        public byte Priority;
        
        [FieldConst()]
        public bool RunUntilAbort;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<DirectEffectRunData> DirectEffectTimers = new List<DirectEffectRunData>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<DuffEffectRunData> DuffEffectTimers = new List<DuffEffectRunData>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<ConditionalEventRunData> ConditionalEventTimers = new List<ConditionalEventRunData>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float EventTimer;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public int EventActualRepeatCount;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool DuffEventDone;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool UninstallWhenDone;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<Game_Pawn> Targets = new List<Game_Pawn>();
        
        public FSkill_Event_Duff()
        {
        }
        
        [System.Serializable] public struct ConditionalEventRunData
        {
            
            public float EarliestStartTime;
            
            public int UsesLeft;
        }
        
        [System.Serializable] public struct DirectEffectRunData
        {
            
            public float NextStartTime;
            
            public int ActualRepeatCount;
        }
        
        [System.Serializable] public struct DuffEffectRunData
        {
            
            public float NextStartTime;
            
            public int ActualRepeatCount;
            
            public List<FSkill_EffectClass_Duff.DuffRestoreData> History;
        }
    }
}
/*
final event string GetName() {
if (Len(Name.Text) > 0) {                                                   
return Name.Text;                                                         
} else {                                                                    
return "<Unnamed Buff or Debuff>";                                        
}
}
native function sv_FireCondition(array<Game_Pawn> aConditionTriggerPawn,Game_Pawn aOriginPawn,byte aCondition,optional byte aAttackType,optional byte aMagicType,optional byte aEffectType);
*/