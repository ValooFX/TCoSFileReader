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

namespace SBAIScripts
{
    
    
    [System.Serializable] public class AIOnScreenMessages : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("AIOnScreenMessages")]
        public LocalizedString Message;
        
        public AIOnScreenMessages()
        {
        }
    }
}
/*
event Trigger(Actor Other,Pawn EventInstigator) {
local Game_PlayerController lPlayer;
foreach AllActors(Class'Game_PlayerController',lPlayer) {                   
lPlayer.Chat.sv2cl_SendOnScreenMessage_CallStub(Message.Id);              
}
}
*/
