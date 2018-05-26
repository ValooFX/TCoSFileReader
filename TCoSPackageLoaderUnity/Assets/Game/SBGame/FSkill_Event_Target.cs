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
    
    
    [System.Serializable] public class FSkill_Event_Target : FSkill_Event_FX
    {
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public int MaxTargets;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetBase;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetSelf;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetEnemies;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetFriendlies;
        
        [FieldConst()]
        public byte TargetNeutrals;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetSpirits;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetBloodlinks;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetPartyMembers;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetGuildMembers;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public byte TargetPets;
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public List<NPC_Taxonomy> LimitToTaxonomy = new List<NPC_Taxonomy>();
        
        [FieldCategory(Category="Target")]
        [FieldConst()]
        public bool TargetAttached;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private bool DidNeedRangeCheck;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private bool DidHasAutoTargets;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private bool ResultNeedRangeCheck;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private bool ResultHasAutoTargets;
        
        public FSkill_Event_Target()
        {
        }
    }
}