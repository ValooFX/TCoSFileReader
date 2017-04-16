﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using TCosReborn.Framework.Common;


namespace Engine
{


    public class Controller : Actor
    {
        
        public const int LATENT_MOVETOWARD = 503;
        
        public Pawn Pawn;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int PlayerNum;
        
        public float SightCounter;
        
        public float FovAngle;
        
        public float Handedness;
        
        public bool bIsPlayer;
        
        public bool bGodMode;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool bLOSflag;
        
        public bool bAdvancedTactics;
        
        public bool bCanOpenDoors;
        
        public bool bCanDoSpecial;
        
        public bool bAdjusting;
        
        public bool bPreparingMove;
        
        public bool bControlAnimations;
        
        public bool bEnemyInfoValid;
        
        public bool bNotifyApex;
        
        public bool bUsePlayerHearing;
        
        public bool bJumpOverWall;
        
        public bool bEnemyAcquired;
        
        public bool bSoaking;
        
        public bool bNotifyFallingHitWall;
        
        public bool bSlowerZAcquire;
        
        public bool bInDodgeMove;
        
        public bool bVehicleTransition;
        
        public bool bForceStrafe;
        
        public bool bNotifyPostLanded;
        
        public byte bRun;
        
        public byte bDuck;
        
        public byte bFire;
        
        public byte bAltFire;
        
        public byte bVoiceTalk;
        
        public Vector AdjustLoc;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Controller nextController;
        
        public float Stimulus;
        
        public float MoveTimer;
        
        public Actor MoveTarget;
        
        public Vector Destination;
        
        public Vector FocalPoint;
        
        public Actor Focus;
        
        public float FocusLead;
        
        public Mover PendingMover;
        
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=4)]
        public Actor[] GoalList = new Actor[0];
        
        public NavigationPoint home;
        
        public float MinHitWall;
        
        public float RespawnPredictionTime;
        
        public float DodgeToGoalPct;
        
        public int AcquisitionYawRate;
        
        public float DodgeLandZ;
        
        public Pawn Enemy;
        
        public Actor Target;
        
        public Vector LastSeenPos;
        
        public Vector LastSeeingPos;
        
        public float LastSeenTime;
        
        public string VoiceType = string.Empty;
        
        public float OldMessageTime;
        
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=16)]
        public Actor[] RouteCache = new Actor[0];
        
        public ReachSpec CurrentPath;
        
        public ReachSpec NextRoutePath;
        
        public Vector CurrentPathDir;
        
        public Actor RouteGoal;
        
        public float RouteDist;
        
        public float LastRouteFind;
        
        public Vector DirectionHint;
        
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Pawn")]
        public SerializableTypeProxy PawnClass;
        
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Pawn")]
        public SerializableTypeProxy PreviousPawnClass;
        
        public float GroundPitchTime;
        
        public Vector ViewX;
        
        public Vector ViewY;
        
        public Vector ViewZ;
        
        public NavigationPoint StartSpot;
        
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=2)]
        public AvoidMarker[] FearSpots = new AvoidMarker[0];
        
        public float WarningDelay;
        
        public Pawn ShotTarget;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Actor LastFailedReach;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float FailedReachTime;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Vector FailedReachLocation;
        
        public Controller()
        {
        }
    }
}
/*
event NotifyTakeHit(Pawn instigatedBy,Vector HitLocation,int actualDamage,class<DamageType> DamageType,Vector Momentum);
event EnemyNotVisible();
event SeeMonster(Pawn Seen);
event SeePlayer(Pawn Seen);
event HearNoise(float Loudness,Actor NoiseMaker);
event SetupSpecialPathAbilities();
function FearThisSpot(AvoidMarker aSpot) {
local int i;
if (Pawn == None) {                                                         
return;                                                                   
}
if (!LineOfSightTo(aSpot)) {                                                
return;                                                                   
}
i = 0;                                                                      
while (i < 2) {                                                             
if (FearSpots[i] == None) {                                               
FearSpots[i] = aSpot;                                                   
return;                                                                 
}
i++;                                                                      
}
i = 0;                                                                      
while (i < 2) {                                                             
if (VSize(Pawn.Location - FearSpots[i].Location) > VSize(Pawn.Location - aSpot.Location)) {
FearSpots[i] = aSpot;                                                   
return;                                                                 
}
i++;                                                                      
}
}
function UnderLift(Mover M);
function MoverFinished();
function WaitForMover(Mover M);
event PrepareForMove(NavigationPoint Goal,ReachSpec Path);
function Vector AdjustToss(float TSpeed,Vector Start,Vector End,bool bNormalize) {
local Vector Dest2D;
local Vector Result;
local Vector Vel2D;
local float Dist2D;
if (Start.Z > End.Z + 64) {                                                 
Dest2D = End;                                                             
Dest2D.Z = Start.Z;                                                       
Dist2D = VSize(Dest2D - Start);                                           
TSpeed *= Dist2D / VSize(End - Start);                                    
Result = SuggestFallVelocity(Dest2D,Start,TSpeed,TSpeed);                 
Vel2D = Result;                                                           
Vel2D.Z = 0.00000000;                                                     
Result.Z = Result.Z + (End.Z - Start.Z) * VSize(Vel2D) / Dist2D;          
} else {                                                                    
Result = SuggestFallVelocity(End,Start,TSpeed,TSpeed);                    
}
if (bNormalize) {                                                           
return TSpeed * Normal(Result);                                           
} else {                                                                    
return Result;                                                            
}
}
function bool WouldReactToSeeing(Pawn Seen) {
return False;                                                               
}
function bool WouldReactToNoise(float Loudness,Actor NoiseMaker) {
return False;                                                               
}
function byte GetMessageIndex(name PhraseName) {
return 0;                                                                   
}
function int GetFacingDirection() {
return 0;                                                                   
}
simulated event RenderOverlays(Canvas Canvas);
function bool WantsSmoothedView() {
return Pawn != None
&& (Pawn.Physics == 1 || Pawn.Physics == 9
|| Pawn.Physics == 19
|| Pawn.Physics == 20)
&& !Pawn.bJustLanded;
}
event bool AllowDetourTo(NavigationPoint N) {
return True;                                                                
}
simulated event Destroyed() {
if (Role < 4) {                                                             
Super.Destroyed();                                                        
return;                                                                   
}
RemoveController();                                                         
Super.Destroyed();                                                          
}
event PostBeginPlay() {
Super.PostBeginPlay();                                                      
}
event PreBeginPlay() {
AddController();                                                            
Super.PreBeginPlay();                                                       
if (bDeleteMe) {                                                            
return;                                                                   
}
SightCounter = 0.20000000 * FRand();                                        
}
function PawnIsInPain(PhysicsVolume PainVolume);
function SetFall();
function SetDoubleJump();
event NotifyMissedJump();
event NotifyJumpApex();
event NotifyHitMover(Vector HitNormal,Mover Wall);
event bool NotifyBump(Actor Other);
event NotifyFallingHitWall(Vector HitNormal,Actor Wall);
event bool NotifyHitWall(Vector HitNormal,Actor Wall);
event NotifyPostLanded();
event bool NotifyLanded(Vector HitNormal);
event bool NotifyHeadVolumeChange(PhysicsVolume NewVolume);
event bool NotifyPhysicsVolumeChange(PhysicsVolume NewVolume);
event LongFall();
function WasKilledBy(Controller Other);
event SoakStop(string problem);
event int AIHearSBSound(Actor Actor,Sound s,Vector SoundLocation,float Volume,float Pitch,float Radius,bool Attenuate) {
return -1;                                                                  
}
event AIHearSound(Actor Actor,int Id,Sound s,Vector SoundLocation,Vector Parameters,bool Attenuate);
function bool AvoidCertainDeath() {
return False;                                                               
}
function Reset() {
Super.Reset();                                                              
Enemy = None;                                                               
LastSeenTime = 0.00000000;                                                  
StartSpot = None;                                                           
bAdjusting = False;                                                         
bPreparingMove = False;                                                     
bJumpOverWall = False;                                                      
bEnemyAcquired = False;                                                     
bInDodgeMove = False;                                                       
MoveTimer = -1.00000000;                                                    
MoveTarget = None;                                                          
PendingMover = None;                                                        
CurrentPath = None;                                                         
RouteGoal = None;                                                           
}
simulated function Rotator GetViewRotation() {
return Rotation;                                                            
}
simulated function string GetHumanReadableName() {
return GetItemName(string(self));                                           
}
function DisplayDebug(Canvas Canvas,out float YL,out float YPos) {
local string DebugString;
if (Pawn == None) {                                                         
Super.DisplayDebug(Canvas,YL,YPos);                                       
return;                                                                   
}
Canvas.SetDrawColor(255,0,0);                                               
Canvas.DrawText("CONTROLLER " $ GetItemName(string(self))
$ " Pawn "
$ GetItemName(string(Pawn))
$ " viewpitch "
$ string(Rotation.Pitch));
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
if (Enemy != None) {                                                        
Canvas.DrawText("     STATE: " $ string(GetStateName())
$ " Timer: "
$ string(TimerCounter)
$ " Enemy "
$ Enemy.GetHumanReadableName(),False);
} else {                                                                    
Canvas.DrawText("     STATE: " $ string(GetStateName())
$ " Timer: "
$ string(TimerCounter)
$ " NO Enemy ",False);
}
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
if (Target != None) {                                                       
} else {                                                                    
}
Canvas.DrawText(DebugString);                                               
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
YPos += YL;                                                                 
Canvas.SetPos(4.00000000,YPos);                                             
}
function PendingStasis() {
bStasis = True;                                                             
Pawn = None;                                                                
}
event MissedDodge();
event MayDodgeToMoveTarget();
event MayFall();
final native function bool CanMakePathTo(Actor A);
native function EndClimbLadder();
native function StopWaiting();
final native function bool InLatentExecution(int LatentActionNumber);
final native(530) function RemoveController();
final native(529) function AddController();
final native(527) latent function WaitForLanding();
final native(526) function bool PickWallAdjust(Vector HitNormal);
final native(520) function bool ActorReachable(Actor anActor);
final native(521) function bool PointReachable(Vector aPoint);
final native(523) function Vector EAdjustJump(float BaseZ,float XYSpeed);
final native(525) function NavigationPoint FindRandomDest();
final native function Actor FindPathTowardNearest(class<NavigationPoint> GoalClass,optional bool bWeightDetours);
final native function Actor FindPathToIntercept(Pawn P,Actor RouteGoal,optional bool bWeightDetours);
final native(517) function Actor FindPathToward(Actor anActor,optional bool bWeightDetours);
final native(518) function Actor FindPathTo(Vector aPoint);
final native(533) function bool CanSee(Pawn Other);
final native(514) function bool LineOfSightTo(Actor Other);
final native(508) latent function FinishRotation();
final native(502) latent function MoveToward(Actor NewTarget,optional Actor ViewFocus,optional float DestinationOffset,optional bool bUseStrafing,optional bool bShouldWalk);
final native(500) latent function MoveTo(Vector NewDestination,optional Actor ViewFocus,optional bool bShouldWalk);
*/