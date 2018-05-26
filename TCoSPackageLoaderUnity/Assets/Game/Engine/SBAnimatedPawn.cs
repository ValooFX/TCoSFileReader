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

namespace Engine
{
#pragma warning disable 414   
    
    [System.Serializable] public class SBAnimatedPawn : Pawn
    {
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private List<SBAttachmentInfo> Attachments = new List<SBAttachmentInfo>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private List<SBDirectionFlagSet> animDirectionSet = new List<SBDirectionFlagSet>();
        
        private List<SBAnimationTypeStack> AnimTypeStacks = new List<SBAnimationTypeStack>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int xMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int yMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int zMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int oldXMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int oldYMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private int oldZMovement;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        private bool bSittingOnChair;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool bAnimationPaused;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool bPreviouslyRunning;
        
        public SBAnimatedPawn()
        {
        }
        
        [System.Serializable] public struct SBAttachmentInfo
        {
            
            public string AttachmentName;
            
            public string meshName;
            
            public NameProperty AttachmentBoneTag;
            
            public Vector ScaleFactor;
            
            public Rotator Orientation;
            
            public Vector PosOffset;
            
            public bool IgnoreParentRotation;
        }
        
        [System.Serializable] public struct SBAnimationParameters
        {
            
            public float BlendFactor;
            
            public float BlendInTime;
            
            public float BlendOutTime;
            
            public float AnimSpeed;
            
            public float StartFrame;
            
            public bool Looped;
            
            public bool Reversed;
        }
        
        [System.Serializable] public struct SBAnimationStackEntry
        {
            
            public NameProperty AnimationName;
            
            public List<int> ActionFlags;
            
            public byte directionFlag;
            
            public byte WeaponFlag;
            
            public byte VariationNumber;
            
            public SBAnimationParameters AnimParameters;
            
            public bool OverrideSequenceAnimTypes;
            
            public bool IgnoreNotifies;
        }
        
        [System.Serializable] public struct SBAnimationTypeStack
        {
            
            public byte AnimType;
            
            public List<SBAnimationStackEntry> AnimationStack;
        }
        
        [System.Serializable] public struct SBDirectionFlagSet
        {
            
            public int directionFlag;
            
            public float directionBlendFactor;
        }
        
        public enum SBAnimationType
        {
            
            SBAnimType_None ,
            
            SBAnimType_Idle ,
            
            SBAnimType_Emote ,
            
            SBAnimType_Movement ,
            
            SBAnimType_LightWound ,
            
            SBAnimType_Action ,
            
            SBAnimType_SpecialAction ,
            
            SBAnimType_HeavyWound ,
            
            SBAnimType_Death ,
            
            SBAnimType_AlwaysPlayed ,
            
            SBAnimType_Turning ,
            
            SBAnimType_Emerging,
        }
        
        public enum EPawnSound
        {
            
            EPS_Command_Enemies ,
            
            EPS_Command_GetReady ,
            
            EPS_Command_Charge ,
            
            EPS_Command_Attack ,
            
            EPS_Command_Retreat ,
            
            EPS_Command_Follow ,
            
            EPS_Command_Wait ,
            
            EPS_Command_ComeOn ,
            
            EPS_Command_Assistance ,
            
            EPS_Command_OverHere ,
            
            EPS_Command_BackOff ,
            
            EPS_Command_North ,
            
            EPS_Command_East ,
            
            EPS_Command_West ,
            
            EPS_Command_South ,
            
            EPS_Command_Flank ,
            
            EPS_Command_GoRound ,
            
            EPS_Action ,
            
            EPS_CriticalWound ,
            
            EPS_Death ,
            
            EPS_Interaction_No ,
            
            EPS_Interaction_Yes ,
            
            EPS_Interaction_Greet ,
            
            EPS_Interaction_Bye ,
            
            EPS_Interaction_Thanks ,
            
            EPS_Interaction_PwnieQues ,
            
            EPS_Interaction_PwnieExcl ,
            
            EPS_Interaction_Trade ,
            
            EPS_Interaction_Excuse ,
            
            EPS_Interaction_Wait ,
            
            EPS_Interaction_Veto ,
            
            EPS_Interaction_Sarcasm ,
            
            EPS_Interaction_Hey ,
            
            EPS_Interaction_Oldskool ,
            
            EPS_Interaction_Outfit ,
            
            EPS_Interaction_FashionPolice ,
            
            EPS_Interaction_Jazz ,
            
            EPS_Sound_Clap ,
            
            EPS_Sound_Kiss ,
            
            EPS_Sound_Sigh ,
            
            EPS_Sound_Bored ,
            
            EPS_Sound_Pain ,
            
            EPS_Sound_Pst ,
            
            EPS_Sound_Angry ,
            
            EPS_Sound_Cry ,
            
            EPS_Sound_Maniacal ,
            
            EPS_Sound_Laugh ,
            
            EPS_Sound_Cough ,
            
            EPS_Sound_Cheer ,
            
            EPS_Sound_WhistleHappy ,
            
            EPS_Sound_WhistleAttention ,
            
            EPS_Sound_WhistleMusic ,
            
            EPS_Sound_WhistleNote ,
            
            EPS_Sound_Ahh ,
            
            EPS_Sound_Gasp ,
            
            EPS_Sound_Stretch ,
            
            EPS_Sound_Huf ,
            
            EPS_Sound_Bah ,
            
            EPS_Sound_Dismiss ,
            
            EPS_Taunt_Oracle ,
            
            EPS_Taunt_Battle ,
            
            EPS_Taunt_Praise ,
            
            EPS_Taunt_Mock ,
            
            EPS_Taunt_Attention ,
            
            EPS_Taunt_Death ,
            
            EPS_Taunt_Stop ,
            
            EPS_Taunt_AdmireRoom ,
            
            EPS_Taunt_Victory ,
            
            EPS_Taunt_Survive ,
            
            EPS_Taunt_Again ,
            
            EPS_Taunt_Try ,
            
            EPS_Taunt_LetsGo ,
            
            EPS_Taunt_RTFM ,
            
            EPS_Taunt_Unique ,
            
            EPS_Wound ,
            
            EPS_Goodbye ,
            
            EPS_Greet ,
            
            EPS_Thanks ,
            
            EPS_Yay ,
            
            EPS_Weee ,
            
            EPS_NONE,
        }
    }
}
/*
native function RemoveAllAttachments();
native function InitializeAttachmentModel(string attachmentType,string boneTag,Object MeshObject);
native function PauseAnim(bool pause,optional byte AnimType);
native function PlayAnimType(name animName,byte AnimType,float Rate,float TweenTime,bool loop,bool keepLastFrame);
native function ClearAnimsByType(byte animationTypeId,float blendOutRate);
native function ClearPawnAnims();
function ClearAnims() {
ClearPawnAnims();                                                           
}
native function bool AnimationFlagsActive(array<int> ActionFlags,optional int directionFlag,optional int WeaponFlag,optional int varNumber);
native function bool AnimationPlaying(name AnimationName);
native function FadeInQueuedAnimations(float FadeInTime,optional bool keepLastFrame);
native function PlayQueuedAnimations(bool forceOverwrite,bool keepLastFrame,optional bool alowImmediateCull);
native function QueueAnimation(array<int> ActionFlags,int variationNr,float AnimSpeed,float BlendInTime,float BlendOutTime,bool isLooping,optional coerce int AnimationType);
native function Vector GetMovementDirectionVector();
native function float GetAnimationDuration(array<int> ActionFlags,int variationNr,float AnimSpeed);
event OnSheatheWeapon(byte WeaponFlag);
event OnDrawWeapon(byte WeaponFlag);
function PlayTopLevelAnim(name animName,float Rate,float TweenTime,bool loop,bool keepLastFrame) {
PlayAnimType(animName,9,Rate,TweenTime,loop,keepLastFrame);                 
}
event byte GetEquippedWeaponFlag() {
return 0;                                                                   
}
function sv_HackDamageActions(float aDamageFactor);
event FreezeRotation(bool aFreezeFlag);
event FreezeMovement(bool aFreezeFlag);
function ExecuteDeath(Pawn instigatedBy,Vector HitLocation,Vector Momentum,class<DamageType> DamageType) {
local Controller Killer;
if (DamageType.default.bCausedByWorld
&& (instigatedBy == None || instigatedBy == self)
&& LastHitBy != None) {
Killer = LastHitBy;                                                       
} else {                                                                    
if (instigatedBy != None) {                                               
Killer = instigatedBy.GetKillerController();                            
}
}
if (Killer == None
&& DamageType.default.bDelayedDamage) {            
Killer = DelayedDamageInstigatorController;                               
}
if (bPhysicsAnimUpdate) {                                                   
TearOffMomentum = Momentum;                                               
}
Died(Killer,DamageType,HitLocation);                                        
}
function TakeDamage(int Damage,Pawn instigatedBy,Vector HitLocation,Vector Momentum,class<DamageType> DamageType) {
local int actualDamage;
if (Damage <= 0) {                                                          
return;                                                                   
}
if (DamageType == Class'Crushed') {                                         
return;                                                                   
}
if (DamageType == None) {                                                   
if (instigatedBy != None) {                                               
Warn("No damagetype for damage by " $ string(instigatedBy));            
}
DamageType = Class'DamageType';                                           
}
if (SBRole != 1) {                                                          
return;                                                                   
}
if (GetHealth() <= 0) {                                                     
return;                                                                   
}
if ((instigatedBy == None
|| instigatedBy.Controller == None)
&& DamageType.default.bDelayedDamage
&& DelayedDamageInstigatorController != None) {
instigatedBy = DelayedDamageInstigatorController.Pawn;                    
}
if (Physics == 1
&& DamageType.default.bExtraMomentumZ) {             
Momentum.Z = FMax(Momentum.Z,0.40000001 * VSize(Momentum));               
}
if (instigatedBy == self) {                                                 
Momentum *= 0.60000002;                                                   
}
Momentum = Momentum / Mass;                                                 
actualDamage = Damage;                                                      
IncreaseHealth(-actualDamage);                                              
if (HitLocation == vect(0.000000, 0.000000, 0.000000)) {                    
HitLocation = Location;                                                   
}
if (GetHealth() <= 0) {                                                     
ExecuteDeath(instigatedBy,HitLocation,Momentum,DamageType);               
} else {                                                                    
AddVelocity(Momentum);                                                    
if (Controller != None) {                                                 
Controller.NotifyTakeHit(instigatedBy,HitLocation,actualDamage,DamageType,Momentum);
}
if (instigatedBy != None && instigatedBy != self) {                       
LastHitBy = instigatedBy.Controller;                                    
}
sv_HackDamageActions(actualDamage);                                       
}
MakeNoise(1.00000000);                                                      
}
function Died(Controller Killer,class<DamageType> DamageType,Vector HitLocation) {
local Trigger t;
local NavigationPoint N;
if (bDeleteMe || Level.bLevelChange
|| GetGameInfo() == None) {       
return;                                                                   
}
if (DamageType.default.bCausedByWorld
&& (Killer == None || Killer == Controller)
&& LastHitBy != None) {
Killer = LastHitBy;                                                       
}
SetHealth(Min(0,GetHealth()));                                              
if (Controller != None) {                                                   
Controller.WasKilledBy(Killer);                                           
goto jl00AA;                                                              
}
if (Killer != None) {                                                       
TriggerEvent(Event,self,Killer.Pawn);                                     
} else {                                                                    
TriggerEvent(Event,self,None);                                            
}
if (IsPlayerPawn() || WasPlayerPawn()) {                                    
PhysicsVolume.PlayerPawnDiedInVolume(self);                               
foreach TouchingActors(Class'Trigger',t) {                                
t.PlayerToucherDied(self);                                              
}
foreach TouchingActors(Class'NavigationPoint',N) {                        
if (N.bReceivePlayerToucherDiedNotify) {                                
N.PlayerToucherDied(self);                                            
}
}
}
Velocity.Z *= 1.29999995;                                                   
if (IsHumanControlled()) {                                                  
PlayerController(Controller).ForceDeathUpdate();                          
} else {                                                                    
PlayDying(DamageType,HitLocation);                                        
}
}
*/