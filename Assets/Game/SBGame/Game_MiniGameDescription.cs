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
    
    
    [System.Serializable] public class Game_MiniGameDescription : UObject
    {
        
        public string Title = string.Empty;
        
        public string Description = string.Empty;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material IconMaterial;
        
        public Game_MiniGameDescription()
        {
        }
    }
}