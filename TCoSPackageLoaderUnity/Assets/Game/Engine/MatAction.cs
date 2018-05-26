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

namespace Engine
{
    
    
    [System.Serializable] public class MatAction : MatObject
    {
        
        [FieldCategory(Category="MatAction")]
        public InterpolationPoint IntPoint;
        
        [FieldCategory(Category="MatAction")]
        public string Comment = string.Empty;
        
        [FieldCategory(Category="Time")]
        public float Duration;
        
        [FieldCategory(Category="Sub")]
        public List<MatSubAction> SubActions = new List<MatSubAction>();
        
        [FieldCategory(Category="Path")]
        public bool bSmoothCorner;
        
        [FieldCategory(Category="Path")]
        public Vector StartControlPoint;
        
        [FieldCategory(Category="Path")]
        public Vector EndControlPoint;
        
        [FieldCategory(Category="Path")]
        public bool bConstantPathVelocity;
        
        [FieldCategory(Category="Path")]
        public float PathVelocity;
        
        public float PathLength;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<Vector> SampleLocations = new List<Vector>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctStarting;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctEnding;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctDuration;
        
        public MatAction()
        {
        }
    }
}