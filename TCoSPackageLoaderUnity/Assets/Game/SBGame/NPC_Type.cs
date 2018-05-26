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
    
    
    [System.Serializable] public class NPC_Type : Content_Type
    {
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public bool ShowNameAboveHeads;
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public LocalizedString LongName;
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public LocalizedString ShortName;

        //Custom addition
        public new LocalizedString Name;
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public string Note = string.Empty;
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public byte Category;
        
        [FieldCategory(Category="Basics")]
        [FieldConst()]
        public float CorpseTimeout;
        
        [FieldCategory(Category="Combat")]
        [FieldConst()]
        public bool Invulnerable;
        
        [FieldCategory(Category="Sheet")]
        [FieldConst()]
        public int FameLevel;
        
        [FieldCategory(Category="Sheet")]
        [FieldConst()]
        public int PePRank;
        
        [FieldCategory(Category="Sheet")]
        [FieldConst()]
        public float CreditMultiplier;
        
        [FieldCategory(Category="Combat")]
        public byte NPCClassClassification;
        
        [FieldCategory(Category="Combat")]
        public NPC_SkillDeck SkillDeck;
        
        [FieldCategory(Category="Combat")]
        public NPC_AttackSheet AttackSheet;
        
        [FieldCategory(Category="Sheet")]
        public NPC_StatTable Stats;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public byte Movement;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float AccelRate;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float JumpSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float GroundSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float CombatSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float StrollSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float WaterSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float AirSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float AirControl;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float AirMinSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float ClimbSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float TurnSpeed;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public float TerminalVelocity;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool CanStrafe;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool CanRest;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool CanWalkBackwards;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool bAlignToFloor;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool bAlignToFloorRoll;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool bAlignToFloorPitch;
        
        [FieldCategory(Category="Movement")]
        [FieldConst()]
        public bool bForceAttachmentUpdates;
        
        [FieldCategory(Category="Spawning")]
        [FieldConst()]
        [TypeProxyDefinition(TypeName="Game_NPCPawn")]
        public System.Type PawnType;
        
        [FieldCategory(Category="Spawning")]
        [FieldConst()]
        public int BossPriority;
        
        [FieldCategory(Category="Appearance")]
        [FieldConst()]
        public NPC_Appearance Appearance;
        
        [FieldCategory(Category="Appearance")]
        [FieldConst()]
        public NPC_Effects Effects;
        
        [FieldCategory(Category="Items")]
        [FieldConst()]
        public NPC_Equipment Equipment;
        
        [FieldCategory(Category="Items")]
        [FieldConst()]
        public Content_Inventory Inventory;
        
        [FieldCategory(Category="Items")]
        [FieldConst()]
        public List<LootTable> Loot = new List<LootTable>();
        
        [FieldCategory(Category="Items")]
        [FieldConst()]
        public bool IndividualKillCredit;
        
        [FieldCategory(Category="Conversations")]
        [FieldConst()]
        public List<Conversation_Topic> Topics = new List<Conversation_Topic>();
        
        [FieldConst()]
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public List<Conversation_Topic> QuestTopics = new List<Conversation_Topic>();
        
        public bool TriggersKilledHook;
        
        [FieldCategory(Category="Faction")]
        public NPC_Taxonomy TaxonomyFaction;
        
        [FieldCategory(Category="Services")]
        [FieldConst()]
        public bool Travel;
        
        [FieldCategory(Category="Services")]
        [FieldConst()]
        public bool Arena;
        
        [FieldCategory(Category="Services")]
        [FieldConst()]
        public Shop_Base Shop;
        
        public NPC_Type()
        {
        }
        
        public enum ENPC_Category
        {
            
            ENPC_Human ,
            
            ENPC_Wildlife ,
            
            ENPC_Boss,
        }
    }
}
/*
final native function cl_CreateQuestsTopics(Game_NPCPawn aPawn);
event InitializeStats(int aFameLevel,int aPePRank,out int oMaxHp,out int oLevelHp,out int oBody,out int oMind,out int oFocus,out float oRuneResistance,out float oSpiritResistance,out float oSoulResistance) {
if (Stats != None) {                                                        
oMaxHp = Stats.GetBaseHitpoints(aFameLevel);                              
oLevelHp = Stats.GetHitpointsPerLevel(aFameLevel);                        
oBody = Stats.GetBody(aFameLevel);                                        
oMind = Stats.GetMind(aFameLevel);                                        
oFocus = Stats.GetFocus(aFameLevel);                                      
} else {                                                                    
oMaxHp = 100;                                                             
oLevelHp = 10;                                                            
oBody = 7 + aFameLevel / 9;                                               
oMind = 7 + aFameLevel / 9;                                               
oFocus = 7 + aFameLevel / 9;                                              
}
}
function NPC_Taxonomy GetFaction() {
return TaxonomyFaction;                                                     
}
native function int GetClassRank();
native function float CalcRequestedClassMatch(array<byte> ForbiddenClassTypes);
native function bool CalcForbiddenClassMatch(array<byte> ForbiddenClassTypes);
event string GetActiveText(Game_ActiveTextItem aItem) {
if (aItem == None || aItem.Tag == "N") {                                    
return GetShortName();                                                    
} else {                                                                    
if (aItem.Tag == "F") {                                                   
return GetLongName();                                                   
} else {                                                                  
return Super.GetActiveText(aItem);                                      
}
}
}
native function float GetCollisionRadius();
native function float GetCollisionHeight();
function string GetLongName() {
if (Len(LongName.Text) > 0) {                                               
return LongName.Text;                                                     
}
return GetShortName();                                                      
}
function string GetShortName() {
if (Len(ShortName.Text) > 0) {                                              
return ShortName.Text;                                                    
} else {                                                                    
return "NPC";                                                             
}
}
event cl_OnInit(Game_NPCPawn aPawn) {
aPawn.Appearance.InstallBaseAppearance(self);                               
if (Effects != None) {                                                      
Effects.Apply(aPawn);                                                     
}
InitMovement(aPawn);                                                        
}
event sv_OnInit(Game_NPCPawn aPawn) {
aPawn.Appearance.InstallBaseAppearance(self);                               
aPawn.bInvulnerable = Invulnerable;                                         
InitMovement(aPawn);                                                        
if (SkillDeck != None) {                                                    
Game_NPCSkills(aPawn.Skills).sv_SetSkilldeck(SkillDeck,Equipment);        
}
if (Inventory != None) {                                                    
GiveItems(aPawn,Inventory);                                               
}
}
event InitMovement(Game_Pawn aPawn) {
aPawn.SetPhysics(Movement);                                                 
aPawn.GroundSpeed = GroundSpeed;                                            
aPawn.bCanWalk = GroundSpeed > 0.00000000;                                  
aPawn.AirSpeed = AirSpeed;                                                  
aPawn.bCanFly = AirSpeed > 0.00000000;                                      
aPawn.MinFlySpeed = AirMinSpeed;                                            
aPawn.AirControl = AirControl;                                              
aPawn.bCanStrafe = CanStrafe;                                               
aPawn.bCanRest = CanRest;                                                   
aPawn.bCanWalkBackwards = CanWalkBackwards;                                 
if (aPawn.bCanFly) {                                                        
aPawn.CharacterStats.mBaseMovementSpeed = AirSpeed;                       
} else {                                                                    
aPawn.CharacterStats.mBaseMovementSpeed = GroundSpeed;                    
}
if (CombatSpeed >= 0.00000000) {                                            
aPawn.CharacterStats.mMovementSpeedMultiplier[1] = CombatSpeed / GroundSpeed;
}
if (GroundSpeed >= 1.00000000) {                                            
aPawn.WalkingPct = StrollSpeed / GroundSpeed;                             
}
aPawn.WaterSpeed = WaterSpeed;                                              
aPawn.bCanSwim = WaterSpeed > 0.00000000;                                   
aPawn.JumpZ = JumpSpeed;                                                    
aPawn.bCanJump = JumpSpeed > 0.00000000;                                    
aPawn.LadderSpeed = ClimbSpeed;                                             
aPawn.bCanClimbLadders = ClimbSpeed > 0.00000000;                           
aPawn.AccelRate = AccelRate;                                                
aPawn.RotationRate.Yaw = TurnSpeed;                                         
aPawn.RotationRate.Pitch = TurnSpeed;                                       
aPawn.RotationRate.Roll = TurnSpeed;                                        
aPawn.bAlignToFloor = bAlignToFloor;                                        
aPawn.bAlignToFloorRoll = bAlignToFloorRoll;                                
aPawn.bAlignToFloorPitch = bAlignToFloorPitch;                              
aPawn.bForceSkelUpdate = bForceAttachmentUpdates;                           
aPawn.SetCollisionSize(GetCollisionRadius(),GetCollisionHeight());          
aPawn.mMaxDamageFallSpeed = TerminalVelocity;                               
aPawn.mMinDamageFallSpeed = TerminalVelocity * 0.75000000;                  
if (Movement == 4) {                                                        
aPawn.bCanFly = True;                                                     
}
}
native function sv_OnSpawn(Game_NPCPawn aPawn);
*/