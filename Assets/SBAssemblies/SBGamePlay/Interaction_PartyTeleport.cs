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

namespace SBGamePlay
{
    
    
    [System.Serializable] public class Interaction_PartyTeleport : Interaction_Component
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Interaction_PartyTeleport")]
        public int TargetWorld;
        
        [Sirenix.OdinInspector.FoldoutGroup("Interaction_PartyTeleport")]
        public string portalName = string.Empty;
        
        public Interaction_PartyTeleport()
        {
        }
    }
}
/*
function SvOnStart(Game_Actor aOwner,Game_Pawn aInstigator,bool aReverse) {
local Game_Team team;
Super.SvOnStart(aOwner,aInstigator);                                        
if (!aReverse) {                                                            
team = aInstigator.GetTeam();                                             
if (team == None) {                                                       
TeleportPawn(aInstigator,TargetWorld,False,portalName);                 
return;                                                                 
}
Game_PlayerController(aInstigator.Controller).GroupingTeams.sv_StartPartyTravel(TargetWorld,portalName);
}
}
*/
