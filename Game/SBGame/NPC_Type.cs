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
using TCosReborn.Framework.Common;


namespace SBGame
{
    
    
    public class NPC_Type : Content_Type
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool ShowNameAboveHeads;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public LocalizedString LongName;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public LocalizedString ShortName;

        //Custom addition
        public LocalizedString Name;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public string Note = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte Category;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Basics")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float CorpseTimeout;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Combat")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool Invulnerable;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Sheet")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int FameLevel;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Sheet")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int PePRank;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Sheet")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float CreditMultiplier;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Combat")]
        public byte NPCClassClassification;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Combat")]
        public NPC_SkillDeck SkillDeck;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Combat")]
        public NPC_AttackSheet AttackSheet;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Sheet")]
        public NPC_StatTable Stats;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public byte Movement;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float AccelRate;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float JumpSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float GroundSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float CombatSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float StrollSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float WaterSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float AirSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float AirControl;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float AirMinSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float ClimbSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float TurnSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public float TerminalVelocity;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool CanStrafe;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool CanRest;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool CanWalkBackwards;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public bool bAlignToFloor;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool bAlignToFloorRoll;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool bAlignToFloorPitch;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Movement")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool bForceAttachmentUpdates;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Spawning")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Game_NPCPawn")]
        public System.Type PawnType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Spawning")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public int BossPriority;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Appearance")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public NPC_Appearance Appearance;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Appearance")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public NPC_Effects Effects;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Items")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public NPC_Equipment Equipment;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Items")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public Content_Inventory Inventory;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Items")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<LootTable> Loot = new List<LootTable>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Items")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool IndividualKillCredit;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Conversations")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<Conversation_Topic> Topics = new List<Conversation_Topic>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public List<Conversation_Topic> QuestTopics = new List<Conversation_Topic>();
        
        public bool TriggersKilledHook;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Faction")]
        public NPC_Taxonomy TaxonomyFaction;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Services")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool Travel;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Services")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public bool Arena;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Services")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
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
