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
    
    
    [System.Serializable] public class AIScript_Trial25_Graidlon : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public FSkill_Type Skill;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public NPC_Type BossNPCType;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public int MinAttackRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public float AttackTimeOut;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public AIScript_Trial25_End_Boss CloudScript;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public string ArrivedEvent = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        [TypeProxyDefinition(TypeName="AIStateMachine")]
        public System.Type FightAIStateMachineClass;
        
        [Sirenix.OdinInspector.FoldoutGroup("Graidlon_Script")]
        public NavigationPoint Waitpoint;
        
        public Game_Pawn targetPawn;
        
        public Game_AIController Controller;
        
        public AIStateMachine OldMachine;
        
        public AIStateMachine FightAIStateMachine;
        
        public bool SkillStarted;
        
        public AIScript_Trial25_Graidlon()
        {
        }
    }
}
/*
protected event GetActorRelations(out array<ActorRelation> oRelations) {
local ActorRelation newRelation;
Super.GetActorRelations(oRelations);                                        
GetTaggedRelations(ArrivedEvent,static.RGB(100,100,255),"ArrivedEvent:" @ ArrivedEvent,oRelations);
if (Waitpoint != None) {                                                    
newRelation.mActor = Waitpoint;                                           
newRelation.mDescription = "WaitPoint";                                   
newRelation.mColour = static.RGB(100,255,100);                            
oRelations[oRelations.Length] = newRelation;                              
}
}
event bool OnDeath(Game_AIController aController,Actor aDeceasedActor) {
CloudScript.OnGraidlonDied();                                               
GotoState('RigorMortisState');                                              
return Super.OnDeath(aController,aDeceasedActor);                           
}
state RigorMortisState {
function BeginState() {
Controller = None;                                                      
targetPawn = None;                                                      
}
}
state SpecialSkillState {
event bool OnSkillFinished(Game_AIController aController,export editinline FSkill_Type aSkill) {
if (aSkill == Skill) {                                                  
GotoState('FightingState');                                           
}
return OnSkillFinished(aController,aSkill);                             
}
event bool OnTick(Game_AIController aController,float DeltaTime) {
if (VSize(targetPawn.Location - aController.Pawn.Location) > MinAttackRange) {
MoveTo(aController,targetPawn.Location,MinAttackRange * 0.69999999);  
} else {                                                                
if (!HasWeaponDrawn(aController)) {                                   
DrawWeapon(aController,3);                                          
} else {                                                              
if (CanPerformSkill(aController,Skill)) {                           
PerformSkill(aController,Skill,targetPawn.Location);              
}
}
}
return OnTick(aController,DeltaTime);                                   
}
function EndState() {
ContinueAI(Controller);                                                 
}
function BeginState() {
Debug("Start performing special skill");                                
if (targetPawn == None) {                                               
targetPawn = GetNPC(BossNPCType);                                     
}
PauseAI(Controller);                                                    
DrawWeapon(Controller,3);                                               
SetTarget(Controller,targetPawn);                                       
}
}
state FightingState {
event bool OnTimerEnded(Game_AIController aController,Actor aInstigator,name aTag) {
GotoState('SpecialSkillState');                                         
return OnTimerEnded(aController,aInstigator,aTag);                      
}
function BeginState() {
Debug("start fighting");                                                
OldMachine = SwapStateMachine(Controller,FightAIStateMachine);          
StartTimer(Controller,'SpecialAttack',AttackTimeOut);                   
}
}
state WaitingState {
event Trigger(Actor Other,Pawn EventInstigator) {
GotoState('FightingState');                                             
}
function BeginState() {
Debug("start waiting");                                                 
}
}
auto state WalkingState {
event bool OnArrived(Game_AIController aController,SBPoint aControlPoint,SBPoint aDestinationPoint,Vector aLocation) {
TriggerEvent(name(ArrivedEvent),None,None);                             
ContinueAI(Controller);                                                 
GotoState('WaitingState');                                              
return OnArrived(aController,aControlPoint,aDestinationPoint,aLocation);
}
function OnBegin(Game_AIController aController) {
OnBegin(aController);                                                   
Controller = aController;                                               
FightAIStateMachine = new FightAIStateMachineClass;                     
PauseAI(aController);                                                   
MoveTo(aController,Waitpoint.Location);                                 
}
}
*/
