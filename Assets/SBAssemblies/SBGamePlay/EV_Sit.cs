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
    
    
    [System.Serializable] public class EV_Sit : Content_Event
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        public NameProperty Chair;
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        public Vector Offset;
        
        public EV_Sit()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
local Actor chairActor;
if (string(Chair) != "None") {                                              
chairActor = FindClosestActor(Class'Actor',aObject,Chair);                
aObject.SetLocation(chairActor.Location + Offset);                        
aObject.SetRotation(chairActor.Rotation);                                 
ApiTrace("EV_Sit.sv_Execute Sitting down on chair"
@ string(Chair)
@ "="
@ string(chairActor));
aObject.sv_Sit(True,True);                                                
} else {                                                                    
ApiTrace("EV_Sit.sv_Execute Sitting down on the ground");                 
aObject.sv_Sit(True,False);                                               
}
}
function bool ApiTracing() {
return True;                                                                
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
local Actor chairActor;
if (string(Chair) != "None") {                                              
chairActor = FindClosestActor(Class'Actor',aObject,Chair);                
return chairActor != None;                                                
}
if (!Game_Controller(aObject.Controller).IsIdle()) {                        
return False;                                                             
}
return True;                                                                
}
*/
