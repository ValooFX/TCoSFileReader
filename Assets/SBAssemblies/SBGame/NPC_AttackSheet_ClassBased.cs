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
    
    
    [System.Serializable] public class NPC_AttackSheet_ClassBased : NPC_AttackSheet
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("HealPhase")]
        public float HealthFraction;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float WarriorPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float CasterPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float RoguePriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float FriendlyPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float SocialAggroPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float ThreatMultiplier;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float LoveMultiplier;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float LowLevelPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float HighLevelPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("TargetPhase")]
        public float PlayerPriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("SkillPhase")]
        public float RangePriority;
        
        [Sirenix.OdinInspector.FoldoutGroup("SkillPhase")]
        public List<SkillWeight> WarriorPreferences = new List<SkillWeight>();
        
        [Sirenix.OdinInspector.FoldoutGroup("SkillPhase")]
        public List<SkillWeight> RoguePreferences = new List<SkillWeight>();
        
        [Sirenix.OdinInspector.FoldoutGroup("SkillPhase")]
        public List<SkillWeight> CasterPreferences = new List<SkillWeight>();
        
        public NPC_AttackSheet_ClassBased()
        {
        }
        
        [System.Serializable] public struct SkillWeight
        {
            
            public float Weight;
            
            public byte Tag;
        }
    }
}
