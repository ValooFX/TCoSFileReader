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
        
        [Sirenix.OdinInspector.FoldoutGroup("Time")]
        public float Delay;
        
        [Sirenix.OdinInspector.FoldoutGroup("Time")]
        public float Duration;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string Icon; //Texture
        
        public byte Status;
        
        public string Desc = string.Empty;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float PctStarting;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float PctEnding;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
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
