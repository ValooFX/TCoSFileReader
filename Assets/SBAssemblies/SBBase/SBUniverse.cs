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

namespace SBBase
{
    
    
    [System.Serializable] public class SBUniverse : UObject
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public SBUniverseRules GameRules;
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public SBWorld EntryWorld;
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public SBPortal EntryPortal;
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public SBWorld LobbyWorld;
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public int MaxPlayers;
        
        [Sirenix.OdinInspector.FoldoutGroup("Universe")]
        public List<LocalizedString> LocalizedInstanceNames = new List<LocalizedString>();
        
        public List<SBWorld> Worlds = new List<SBWorld>();
        
        public SBUniverse()
        {
        }
    }
}
