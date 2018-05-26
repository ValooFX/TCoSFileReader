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
    
    
    [System.Serializable] public class NPC_SkillCondition_Self : NPC_SkillCondition
    {
        
        [FieldCategory(Category="PMC")]
        public bool PhysiqueCheck;
        
        [FieldCategory(Category="PMC")]
        public bool MoraleCheck;
        
        [FieldCategory(Category="PMC")]
        public bool ConcentrationCheck;
        
        [FieldCategory(Category="BMF")]
        public bool BodyCheck;
        
        [FieldCategory(Category="BMF")]
        public bool MindCheck;
        
        [FieldCategory(Category="BMF")]
        public bool FocusCheck;
        
        [FieldCategory(Category="Misc")]
        public bool HealthCheck;
        
        [FieldCategory(Category="Misc")]
        public bool MovementFrozenCheck;
        
        [FieldCategory(Category="Misc")]
        public bool RotationFrozenCheck;
        
        [FieldCategory(Category="Misc")]
        public bool MovementFrozenValue;
        
        [FieldCategory(Category="Misc")]
        public bool RotationFrozenValue;
        
        [FieldCategory(Category="PMC")]
        public byte PhysiqueOperator;
        
        [FieldCategory(Category="PMC")]
        public byte MoraleOperator;
        
        [FieldCategory(Category="PMC")]
        public byte ConcentrationOperator;
        
        [FieldCategory(Category="BMF")]
        public byte BodyOperator;
        
        [FieldCategory(Category="BMF")]
        public byte MindOperator;
        
        [FieldCategory(Category="BMF")]
        public byte FocusOperator;
        
        [FieldCategory(Category="Misc")]
        public byte HealthOperator;
        
        [FieldCategory(Category="PMC")]
        public float PhysiqueValue;
        
        [FieldCategory(Category="PMC")]
        public float MoraleValue;
        
        [FieldCategory(Category="PMC")]
        public float ConcentrationValue;
        
        [FieldCategory(Category="BMF")]
        public float BodyValue;
        
        [FieldCategory(Category="BMF")]
        public float MindValue;
        
        [FieldCategory(Category="BMF")]
        public float FocusValue;
        
        [FieldCategory(Category="Misc")]
        public float HealthValue;
        
        public NPC_SkillCondition_Self()
        {
        }
    }
}