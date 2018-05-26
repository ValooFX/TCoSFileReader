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
    
    
    [System.Serializable] public class NPC_Spawner : NPC_Habitat
    {
        
        [FieldCategory(Category="Type")]
        [FieldConst()]
        [TypeProxyDefinition(TypeName="Game_NPCController")]
        public System.Type controllerType;
        
        [FieldCategory(Category="Policy")]
        [FieldConst()]
        public bool TriggeredSpawn;
        
        [FieldCategory(Category="Policy")]
        [FieldConst()]
        public bool TriggeredRespawn;
        
        [FieldCategory(Category="Policy")]
        [FieldConst()]
        public bool TriggeredDespawn;
        
        [FieldCategory(Category="Policy")]
        [FieldConst()]
        public NameProperty EventOnWiped;
        
        [FieldCategory(Category="Policy")]
        [FieldConst()]
        public NameProperty EventOnSpawn;
        
        [FieldCategory(Category="aI")]
        public List<NPC_AI> Scripts = new List<NPC_AI>();
        
        [FieldCategory(Category="aI")]
        public float ChaseRange;
        
        [FieldCategory(Category="aI")]
        public float VisualRange;
        
        [FieldCategory(Category="aI")]
        public float LineOfSightRange;
        
        [FieldCategory(Category="aI")]
        public float ThreatRange;
        
        [FieldCategory(Category="aI")]
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public bool ShowAIRanges;
        
        [FieldCategory(Category="Hormones")]
        public float AggressionFactor;
        
        [FieldCategory(Category="Hormones")]
        public float FearFactor;
        
        [FieldCategory(Category="Hormones")]
        public float SocialFactor;
        
        [FieldCategory(Category="Hormones")]
        public float BoredomFactor;
        
        public List<Game_NPCController> Spawns = new List<Game_NPCController>();
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public int Triggerers;
        
        public Game_NPCController FakePlayer;
        
        [FieldConfig()]
        public bool SpawnFakePlayer;
        
        public NPC_Spawner()
        {
        }
    }
}
/*
final native function int GetSpawnsLeft();
event UnTrigger(Actor Other,Pawn EventInstigator) {
local Actor triggerer;
if (EventInstigator != None) {                                              
triggerer = EventInstigator;                                              
} else {                                                                    
triggerer = Other;                                                        
}
if (TriggeredRespawn) {                                                     
Triggerers--;                                                             
if (Triggerers == 0) {                                                    
} else {                                                                  
if (Triggerers < 0) {                                                   
Triggerers = 0;                                                       
}
}
}
if (TriggeredDespawn) {                                                     
if (!TriggeredRespawn || Triggerers == 0) {                               
sv_Despawn();                                                           
}
}
}
event Trigger(Actor Other,Pawn EventInstigator) {
local Actor triggerer;
if (EventInstigator != None) {                                              
triggerer = EventInstigator;                                              
} else {                                                                    
triggerer = Other;                                                        
}
if (TriggeredSpawn) {                                                       
if (!TriggeredRespawn || Triggerers == 0) {                               
sv_TriggeredSpawn(triggerer);                                           
}
}
if (TriggeredRespawn) {                                                     
if (Triggerers == 0) {                                                    
}
Triggerers++;                                                             
}
}
event sv_Despawn() {
}
native function sv_TriggeredSpawn(Actor aTriggerer);
*/