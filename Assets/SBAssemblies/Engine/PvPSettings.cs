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

namespace Engine
{
    
    
    [System.Serializable] public class PvPSettings : UObject
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("PvPSettings")]
        public bool AllowDrawWeapon;
        
        [Sirenix.OdinInspector.FoldoutGroup("PvPSettings")]
        public byte Type;
        
        [Sirenix.OdinInspector.FoldoutGroup("PvPSettings")]
        public bool FriendlyFire;
        
        [Sirenix.OdinInspector.FoldoutGroup("PvPSettings")]
        public int EnableTimeOut;
        
        [Sirenix.OdinInspector.FoldoutGroup("PvPSettings")]
        public bool PvPServerOnly;
        
        public PvPSettings()
        {
        }
        
        public enum EPvPTypes
        {
            
            PVP_None ,
            
            PVP_Off ,
            
            PVP_Guildwars ,
            
            PVP_HouseVSHouse ,
            
            PVP_GuildVSGuild ,
            
            PVP_Deprecated_DO_NOT_USE ,
            
            PVP_FFA,
        }
    }
}
