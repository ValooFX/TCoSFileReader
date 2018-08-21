﻿using System;
using SBBase;

namespace SBGame
{
    [Serializable]
    public class Game_BodySlots: Base_Component
    {
        public const int MAX_BODYSLOT_ITEMS = 5;

        public byte Mode;

        public int SelectedBodySlot;

        public enum EBodySlotMode
        {
            BSM_None,
            BSM_PetSelectSystem,
            BSM_PetControlSystem,
            BSM_SkillUseItems,
            BSM_PlayerUseItems,
        }

        public void sv_SetMode(byte aNewMode)
        {
            if (Mode != aNewMode)
            {
                Mode = aNewMode;
                sv2cl_SetMode_CallStub(aNewMode);
            }
        }

        void sv2cl_SetMode_CallStub(byte newMode/*added*/) { throw new NotImplementedException(); }
    }
}
/*
protected native function sv2cl_FailedActivation_CallStub();
event sv2cl_FailedActivation(int aIndex) {
OnFailedActivation(aIndex);                                                 
}
final function BodySlotActivate(int aIndex,Game_Pawn aTarget) {
local Game_PetPawn petPawn;
local Game_Controller petController;
local Game_Item bodySlotItem;
if (Outer.sv_IsResting()) {                                                 
return;                                                                   
}
switch (Mode) {                                                             
case 2 :                                                                  
petPawn = Outer.GetPet();                                               
if (petPawn != None) {                                                  
petController = Game_Controller(petPawn.Controller);                  
switch (aIndex) {                                                     
case 0 :                                                            
if (aTarget != None) {                                            
petController.sv_PetAttack(aTarget);                            
}
break;                                                            
case 1 :                                                            
petController.sv_PetCallBack();                                   
break;                                                            
case 2 :                                                            
switch (petController.sv_GetPetMoveState()) {                     
case 0 :                                                        
petController.sv_SetPetMoveState(1);                          
break;                                                        
case 1 :                                                        
petController.sv_SetPetMoveState(0);                          
break;                                                        
default:                                                        
}
break;                                                            
case 3 :                                                            
switch (petController.sv_GetPetAttackState()) {                   
case 0 :                                                        
petController.sv_SetPetAttackState(1);                        
break;                                                        
case 1 :                                                        
petController.sv_SetPetAttackState(2);                        
break;                                                        
case 2 :                                                        
petController.sv_SetPetAttackState(3);                        
break;                                                        
case 3 :                                                        
petController.sv_SetPetAttackState(0);                        
break;                                                        
default:                                                        
}
break;                                                            
case 4 :                                                            
Outer.sv_DestroyPet(True);                                        
break;                                                            
default:                                                            
break;                                                            
}
}
break;                                                                  
case 3 :                                                                  
SelectedBodySlot = aIndex;                                              
break;                                                                  
case 1 :                                                                  
case 4 :                                                                  
bodySlotItem = Outer.itemManager.GetItem(3,aIndex);                     
if (bodySlotItem != None) {                                             
if (bodySlotItem.CanUse()) {                                          
bodySlotItem.OnUse();                                               
} else {                                                              
if (Outer.CharacterStats.GetCharacterClass() == 5) {                
sv2cl_FailedActivation_CallStub(aIndex);                          
}
}
}
break;                                                                  
default:                                                                  
break;                                                                  
}
}
}
protected native function cl2sv_BodySlotActivate_CallStub();
event cl2sv_BodySlotActivate(int anIndex,Game_Pawn aTarget) {
BodySlotActivate(anIndex,aTarget);                                          
}
final event Game_Item GetSelectedBodySlotItem() {
switch (Mode) {                                                             
case 3 :                                                                  
if (Outer.itemManager != None) {                                        
return Outer.itemManager.GetItem(3,SelectedBodySlot,0);               
}
return None;                                                            
default:                                                                  
return None;                                                            
}
}
}
final function byte GetMode() {
return Mode;                                                                
}
private final function cl_SetMode(byte aNewMode) {
local Game_PlayerController PlayerController;
if (Mode != aNewMode) {                                                     
PlayerController = Game_PlayerController(Outer.Controller);               
Mode = aNewMode;                                                          
if (PlayerController != None) {                                           
if (aNewMode == 0) {                                                    
PlayerController.Player.GUIDesktop.ShowStdWindow(57,2);               
} else {                                                                
PlayerController.Player.GUIDesktop.ShowStdWindow(57,1);               
}
}
OnModeChange(self);                                                       
}
}
final event sv2cl_SetMode(byte aNewMode) {
cl_SetMode(aNewMode);                                                       
}
final event byte GetBodySlotModeByClass() {
switch (Outer.CharacterStats.GetCharacterClass()) {                         
case 0 :                                                                  
case 2 :                                                                  
case 1 :                                                                  
case 3 :                                                                  
return 0;                                                               
break;                                                                  
case 4 :                                                                  
case 6 :                                                                  
return 3;                                                               
break;                                                                  
case 5 :                                                                  
case 7 :                                                                  
case 8 :                                                                  
case 9 :                                                                  
case 10 :                                                                 
case 11 :                                                                 
return 4;                                                               
break;                                                                  
case 12 :                                                                 
return 1;                                                               
break;                                                                  
default:                                                                  
return 0;                                                               
break;                                                                  
}
}
function cl_OnInit() {
Super.cl_OnInit();                                                          
if (Outer.IsLocalPlayer()) {                                                
cl_SetMode(GetBodySlotModeByClass());                                     
}
}
delegate OnFailedActivation(int aIndex);
delegate OnModeChange(export editinline Game_BodySlots aBodySlots);
*/
