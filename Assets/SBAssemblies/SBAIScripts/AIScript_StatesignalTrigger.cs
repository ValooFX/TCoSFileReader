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
    
    
    [System.Serializable] public class AIScript_StatesignalTrigger : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("StatesignalTrigger")]
        public List<StateSignalEvent> StateSignalEvents = new List<StateSignalEvent>();
        
        public AIScript_StatesignalTrigger()
        {
        }
        
        [System.Serializable] public struct StateSignalEvent
        {
            
            public string Event;
            
            public byte StateSignal;
        }
    }
}
/*
protected event GetActorRelations(out array<ActorRelation> oRelations) {
local int i;
Super.GetActorRelations(oRelations);                                        
i = 0;                                                                      
while (i < StateSignalEvents.Length) {                                      
GetTaggedRelations(StateSignalEvents[i].Event,static.RGB(100,100,255),string(StateSignalEvents[i].StateSignal)
@ "Event:"
@ StateSignalEvents[i].Event,oRelations);
i++;                                                                      
}
}
function bool OnStateSignal(Game_AIController aController,AIState aState,byte aSignal) {
local int i;
i = 0;                                                                      
while (i < StateSignalEvents.Length) {                                      
if (aSignal == StateSignalEvents[i].StateSignal
&& StateSignalEvents[i].Event != ""
&& StateSignalEvents[i].Event != "none") {
TriggerEvent(name(StateSignalEvents[i].Event),self,aController.Pawn);   
goto jl009F;                                                            
}
i++;                                                                      
}
return Super.OnStateSignal(aController,aState,aSignal);                     
}
*/
