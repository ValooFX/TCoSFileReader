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
    
    
    [System.Serializable] public class AIScript_PT_Trial15_Lezu_Script : AI_Script
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("AIScript_PT_Trial15_Lezu_Script")]
        public float mMinPlayerRange;
        
        public Game_AIController mLezu;
        
        public bool mImprisoned;
        
        public AIScript_PT_Trial15_Lezu_Script()
        {
        }
    }
}
/*
function bool OnArrived(Game_AIController aController,SBPoint aControlPoint,SBPoint aDestinationPoint,Vector aLocation) {
if (!mImprisoned) {                                                         
if (HasPausedAI(aController)) {                                           
ContinueAI(aController);                                                
}
}
return Super.OnArrived(aController,aControlPoint,aDestinationPoint,aLocation);
}
event bool OnTick(Game_AIController aController,float DeltaTime) {
local Game_PlayerPawn lPlayerPawn;
if (!mImprisoned) {                                                         
foreach AllActors(Class'Game_PlayerPawn',lPlayerPawn) {                   
goto jl001F;                                                            
}
if (lPlayerPawn != None && !lPlayerPawn.IsDead()) {                       
if (VSize(mLezu.Pawn.Location - lPlayerPawn.Location) > mMinPlayerRange) {
if (!HasPausedAI(aController)) {                                      
PauseAI(mLezu);                                                     
}
MoveTo(mLezu,lPlayerPawn.Location);                                   
}
}
}
return Super.OnTick(aController,DeltaTime);                                 
}
event Trigger(Actor Other,Pawn EventInstigator) {
if (mLezu != None) {                                                        
SwapStateMachine(mLezu,new Class'AIKillingMachine');                      
mImprisoned = False;                                                      
}
}
function OnBegin(Game_AIController aController) {
Super.OnBegin(aController);                                                 
if (mLezu == None) {                                                        
mLezu = aController;                                                      
mImprisoned = True;                                                       
goto jl002C;                                                              
}
}
*/
