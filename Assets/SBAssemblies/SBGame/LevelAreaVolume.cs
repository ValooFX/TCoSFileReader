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

namespace SBGame
{
    
    
    [System.Serializable] public class LevelAreaVolume : Volume
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelAreaVolume")]
        public Actor TriggeredActor;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelAreaVolume")]
        public string RespawnPoint = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelAreaVolume")]
        public LocalizedString LevelAreaName;
        
        [Sirenix.OdinInspector.FoldoutGroup("ShardMap")]
        public bool IsShardMap;
        
        [Sirenix.OdinInspector.FoldoutGroup("ShardMap")]
        public int MapSectionID;
        
        [Sirenix.OdinInspector.FoldoutGroup("ShardMap")]
        public bool IsDiscovered;
        
        [Sirenix.OdinInspector.FoldoutGroup("ShardMap")]
        public string mGEDFile = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("PvP")]
        public PvPSettings PvPSettings;
        
        public LevelAreaVolume()
        {
        }
    }
}
/*
event Touch(Actor anActor) {
if (SBRole == 9 || SBRole == 1) {                                           
if (TriggeredActor != None && anActor.IsA('Game_PlayerPawn')) {           
TriggeredActor.Trigger(self,Game_PlayerPawn(anActor));                  
}
}
}
*/
