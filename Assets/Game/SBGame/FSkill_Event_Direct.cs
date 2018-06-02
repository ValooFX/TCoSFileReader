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
    
    
    [System.Serializable] public class FSkill_Event_Direct : FSkill_Event_Target
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Timing")]
        [FieldConst()]
        public int RepeatCount;
        
        [Sirenix.OdinInspector.FoldoutGroup("Timing")]
        [FieldConst()]
        public float Interval;
        
        [Sirenix.OdinInspector.FoldoutGroup("Timing")]
        [FieldConst()]
        public bool KeepTargets;
        
        [Sirenix.OdinInspector.FoldoutGroup("Timing")]
        [FieldConst()]
        public int TargetsPerRepeat;
        
        [FieldConst()]
        public FSkill_EffectClass_Range Range;
        
        [FieldConst()]
        public FSkill_EffectClass_DirectDamage Damage;
        
        [FieldConst()]
        public FSkill_EffectClass_DirectHeal Heal;
        
        [FieldConst()]
        [ArraySizeForExtraction(Size = 3)]
        public FSkill_EffectClass_DirectState[] _State = new FSkill_EffectClass_DirectState[3];
        
        [FieldConst()]
        public FSkill_EffectClass_DirectDrain Drain;
        
        [FieldConst()]
        [ArraySizeForExtraction(Size = 4)]
        public FSkill_Event_Duff[] Buff = new FSkill_Event_Duff[4];
        
        [FieldConst()]
        [ArraySizeForExtraction(Size = 4)]
        public FSkill_Event_Duff[] Debuff = new FSkill_Event_Duff[4];
        
        [FieldConst()]
        public FSkill_EffectClass_DirectTeleport Teleport;
        
        [FieldConst()]
        public FSkill_EffectClass_DirectFireBodySlot FireBodySlot;
        
        [FieldConst()]
        public FSkill_EffectClass_DirectShapeShift ShapeShift;
        
        [Sirenix.OdinInspector.FoldoutGroup("Damage")]
        [FieldConst()]
        public float DamageMoraleBonus;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        [FieldConst()]
        public bool PlayHurtSound;
        
        [Sirenix.OdinInspector.FoldoutGroup("HitFx")]
        [FieldConst()]
        public bool RepeatTargetFX;
        
        [FieldConst()]
        public FSkill_Event_FX MissFXEvent;
        
        [FieldConst()]
        public FSkill_Event_FX HitFXEvent;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private bool LeaveTargetsBe;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private int ActualRepeatCount;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private int ActualTargetCount;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private float NextDirectEventTime;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public List<Game_Pawn> Targets = new List<Game_Pawn>();
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private bool FirstExecute;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        private Vector DetachedRangePosition;
        
        public FSkill_Event_Direct()
        {
        }
    }
}