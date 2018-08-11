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

namespace SBAIScripts
{
    
    
    [System.Serializable] public class AIScript_PatrolGate : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("PatrolGate")]
        [FieldConst()]
        public bool TriggerAble;
        
        [Sirenix.OdinInspector.FoldoutGroup("PatrolGate")]
        [FieldConst()]
        public List<Content_Requirement> Requirements = new List<Content_Requirement>();
        
        public bool Triggered;
        
        public bool IsAttached;
        
        public AIScript_PatrolGate()
        {
        }
    }
}
/*
event UnTrigger(Actor Other,Pawn EventInstigator) {
if (TriggerAble && Triggered && !IsAttached) {                              
Triggered = False;                                                        
}
}
event Trigger(Actor Other,Pawn EventInstigator) {
if (TriggerAble && !Triggered) {                                            
Triggered = True;                                                         
}
}
event bool AnnotationDone(Game_AIController aController) {
local int reqI;
if (!TriggerAble || Triggered) {                                            
reqI = 0;                                                                 
while (reqI < Requirements.Length) {                                      
if (Requirements[reqI] != None
&& !Requirements[reqI].CheckPawn(Game_Pawn(aController.Pawn))) {
return False;                                                         
}
reqI++;                                                                 
}
return True;                                                              
}
return False;                                                               
}
function OnEnd(Game_AIController aController) {
Super.OnEnd(aController);                                                   
Debug("<End>" @ string(self));                                              
IsAttached = False;                                                         
}
function OnBegin(Game_AIController aController) {
Super.OnBegin(aController);                                                 
Debug(">Begin<" @ string(self) @ string(Triggered));                        
IsAttached = True;                                                          
}
*/
