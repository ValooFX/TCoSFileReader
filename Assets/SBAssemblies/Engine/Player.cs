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

namespace Engine
{
    
    
    [System.Serializable] public class Player : UObject
    {
        
        public const int IDC_WAIT = 6;
        
        public const int IDC_SIZEWE = 5;
        
        public const int IDC_SIZENWSE = 4;
        
        public const int IDC_SIZENS = 3;
        
        public const int IDC_SIZENESW = 2;
        
        public const int IDC_SIZEALL = 1;
        
        public const int IDC_ARROW = 0;
        
        [FieldConst()]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public PlayerController Actor;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public InteractionMaster InteractionMaster;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public List<Interaction> LocalInteractions = new List<Interaction>();
        
        public Player()
        {
        }
    }
}
