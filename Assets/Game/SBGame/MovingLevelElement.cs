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

namespace SBGame
{
    
    
    [System.Serializable] public class MovingLevelElement : Game_Actor
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public byte NumKeys;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public bool bUseLocation;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public bool bUseRotation;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public bool bUseScale;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        public float Delay;
        
        public float WaitedTime;
        
        [Sirenix.OdinInspector.FoldoutGroup("KeyFrame")]
        public byte KeyNum;
        
        [Sirenix.OdinInspector.FoldoutGroup("KeyFrame")]
        public float KeyDuration;
        
        [Sirenix.OdinInspector.FoldoutGroup("KeyFrame")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Sound KeySound;
        
        [Sirenix.OdinInspector.FoldoutGroup("KeyFrame")]
        public NameProperty KeyTriggerEvent;
        
        [Sirenix.OdinInspector.FoldoutGroup("KeyFrame")]
        public NameProperty KeyUntriggerEvent;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Sound StartMoveSound;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Sound MovingSound;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Sound StoppingSound;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public byte WorldRaytraceKey;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [FieldConst()]
        public byte BrushRaytraceKey;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        public byte MLEType;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        public byte MLEMoveMode;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        public byte MLEEncroachMode;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        public byte MLEStoppingMode;
        
        public byte MLEState;
        
        [Sirenix.OdinInspector.FoldoutGroup("MovingLevelElement")]
        [ArraySizeForExtraction(Size=24)]
        public MLEKey[] Keys = new MLEKey[0];
        
        public float KeyTime;
        
        public float MoveSpeed;
        
        public Vector BasePos;
        
        public Vector OldPos;
        
        public Rotator BaseRot;
        
        public Rotator OldRot;
        
        public MovingLevelElement()
        {
        }
        
        [System.Serializable] public struct MLEKey
        {
            
            public Vector Location;
            
            public Rotator Rotation;
            
            public Vector Scale;
            
            public float Duration;
            
            public NameProperty TriggerEvent;
            
            public NameProperty UntriggerEvent;
            
            public Sound Sound;
        }
        
        public enum EMLESoundType
        {
            
            MLEST_StartSound ,
            
            MLEST_MovingSound ,
            
            MLEST_StopSound,
        }
        
        public enum EMLEState
        {
            
            MLES_StateStopped ,
            
            MLES_StateStopping ,
            
            MLES_StateMoving ,
            
            MLES_StateWaiting,
        }
        
        public enum EMLEStoppingMode
        {
            
            MLESM_FinishKey ,
            
            MLESM_FinishAnimation ,
            
            MLESM_Freeze,
        }
        
        public enum EMLEEncroachMode
        {
            
            MLEEM_EncroachCrush ,
            
            MLEEM_EncroachIgnore,
        }
        
        public enum EMLEMoveMode
        {
            
            MLEMM_Loop ,
            
            MLEMM_Bounce,
        }
        
        public enum EMLEType
        {
            
            MLET_TypeTriggerConstant ,
            
            MLET_TypeTriggerToggle,
        }
    }
}
/*
event cl_OnUpdate() {
Super.cl_OnUpdate();                                                        
}
event cl_OnBaseline() {
Super.cl_OnBaseline();                                                      
}
native function Rotator CalculateCurrentRotation();
native function Vector CalculateCurrentLocation();
native function Update(Vector vec,Rotator Rot);
native function ResetState();
native function UpdateRelevants();
native event cl_OnTick(float delta);
state() Stopped {
event UnTrigger(Actor Other,Pawn EventInstigator) {
switch (MLEType) {                                                      
case 0 :                                                              
ResetState();                                                       
break;                                                              
case 1 :                                                              
MLEStoppingMode = 0;                                                
MoveSpeed = -1.00000000;                                            
if (Delay > 0) {                                                    
GotoState('Waiting');                                             
} else {                                                            
GotoState('Stopping');                                            
}
break;                                                              
default:                                                              
}
}
event Trigger(Actor Other,Pawn EventInstigator) {
Instigator = EventInstigator;                                           
switch (MLEType) {                                                      
case 0 :                                                              
if (Delay > 0) {                                                    
GotoState('Waiting');                                             
} else {                                                            
GotoState('Moving');                                              
}
break;                                                              
case 1 :                                                              
MLEStoppingMode = 0;                                                
MoveSpeed = 1.00000000;                                             
if (Delay > 0) {                                                    
GotoState('Waiting');                                             
} else {                                                            
GotoState('Stopping');                                            
}
break;                                                              
default:                                                              
}
}
function BeginState() {
Instigator = None;                                                      
MLEState = 0;                                                           
UpdateRelevants();                                                      
}
function Reset() {
Reset();                                                                
}
function bool SelfTriggered() {
return False;                                                           
}
}
state() Moving {
event UnTrigger(Actor Other,Pawn EventInstigator) {
switch (MLEStoppingMode) {                                              
case 0 :                                                              
case 1 :                                                              
GotoState('Stopping');                                              
break;                                                              
case 2 :                                                              
GotoState('Stopped');                                               
break;                                                              
default:                                                              
break;                                                              
}
}
event Trigger(Actor Other,Pawn EventInstigator) {
}
function BeginState() {
MLEState = 2;                                                           
UpdateRelevants();                                                      
}
function Reset() {
Reset();                                                                
}
function bool SelfTriggered() {
return False;                                                           
}
}
state() Stopping {
event UnTrigger(Actor Other,Pawn EventInstigator) {
}
event Trigger(Actor Other,Pawn EventInstigator) {
}
function BeginState() {
MLEState = 1;                                                           
UpdateRelevants();                                                      
}
function Reset() {
Reset();                                                                
}
function bool SelfTriggered() {
return False;                                                           
}
}
state() Waiting {
event UnTrigger(Actor Other,Pawn EventInstigator) {
}
event Trigger(Actor Other,Pawn EventInstigator) {
}
function BeginState() {
MLEState = 3;                                                           
UpdateRelevants();                                                      
}
function Reset() {
Reset();                                                                
}
function bool SelfTriggered() {
return False;                                                           
}
}
*/