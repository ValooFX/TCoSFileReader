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

namespace SBAIScripts
{
    
    
    [System.Serializable] public class AIScript_TotA_2_Sequence : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public string SuccesEvent = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public string FailEvent = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public string BaseTimeoutEventString = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public float TimeoutTime;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public int MaxTimeout;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public int KillCountTarget;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public NPC_Type JudgeNPCType;
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_TotA_2_Sequence")]
        public NPC_Type EnemyNPCtype;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int TimeoutCount;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int killcount;
        
        public Game_AIController Judge;
        
        public AIScript_TotA_2_Sequence()
        {
        }
    }
}
/*
protected event GetActorRelations(out array<ActorRelation> oRelations) {
local int i;
Super.GetActorRelations(oRelations);                                        
GetTaggedRelations(SuccesEvent,static.RGB(100,100,255),"SuccesEvent:" @ SuccesEvent,oRelations);
GetTaggedRelations(FailEvent,static.RGB(100,100,255),"FailEvent:" @ FailEvent,oRelations);
i = 1;                                                                      
while (i < MaxTimeout) {                                                    
GetTaggedRelations(BaseTimeoutEventString $ string(i),static.RGB(100,100,255),"BaseTimeoutEvent" $ string(i) $ ":"
@ BaseTimeoutEventString
$ string(i),oRelations);
i++;                                                                      
}
}
function bool OnDeath(Game_AIController aController,Actor aCollaborator) {
if (++killcount == KillCountTarget) {                                       
StopTimer(aController,'TimeoutTimer');                                    
TimeoutCount = 0;                                                         
TriggerEvent(name(SuccesEvent),self,None);                                
}
return Super.OnDeath(aController,aCollaborator);                            
}
function bool OnTimerEnded(Game_AIController aGame_AIController,Actor aInstigator,name aTag) {
if (aInstigator == self) {                                                  
switch (aTag) {                                                           
case 'TimeoutTimer' :                                                   
TimeoutCount++;                                                       
if (!aGame_AIController.IsDead()
&& !aGame_AIController.IsDespawned()) {
UntriggerEvent(name(BaseTimeoutEventString $ string(TimeoutCount)),self,None);
}
if (TimeoutCount < MaxTimeout) {                                      
StartTimer(aGame_AIController,'TimeoutTimer',TimeoutTime);          
} else {                                                              
TriggerEvent(name(FailEvent),self,None);                            
}
break;                                                                
default:                                                                
}
}
return False;                                                               
}
function OnBegin(Game_AIController aController) {
local Game_Pawn enemyPawn;
Super.OnBegin(aController);                                                 
if (Game_NPCPawn(aController.Pawn).NPCType == EnemyNPCtype) {               
TimeoutCount = 0;                                                         
StartTimer(aController,'TimeoutTimer',TimeoutTime);                       
if (Judge != None) {                                                      
if (!HasPausedAI(Judge)) {                                              
PauseAI(Judge);                                                       
}
LookAt(Judge,aController.Pawn.Location);                                
}
} else {                                                                    
if (Game_NPCPawn(aController.Pawn).NPCType == JudgeNPCType) {             
Judge = aController;                                                    
enemyPawn = GetNPC(EnemyNPCtype);                                       
if (enemyPawn != None) {                                                
if (!HasPausedAI(aController)) {                                      
PauseAI(aController);                                               
}
LookAt(aController,enemyPawn.Location);                               
}
}
}
}
*/
