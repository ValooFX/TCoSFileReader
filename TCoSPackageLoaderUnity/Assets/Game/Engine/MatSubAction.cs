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
    
    
    [System.Serializable] public class MatSubAction : MatObject
    {
        
        [FieldCategory(Category="Time")]
        public float Delay;
        
        [FieldCategory(Category="Time")]
        public float Duration;
        
        [IgnoreFieldExtraction()]
        public string Icon; //Texture
        
        public byte Status;
        
        public string Desc = string.Empty;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctStarting;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctEnding;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float PctDuration;
        
        public MatSubAction()
        {
        }
        
        public enum ESAStatus
        {
            
            SASTATUS_Waiting ,
            
            SASTATUS_Running ,
            
            SASTATUS_Ending ,
            
            SASTATUS_Expired,
        }
    }
}