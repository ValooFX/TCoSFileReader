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
        
        [Sirenix.OdinInspector.FoldoutGroup("Type")]
        [FieldConst()]
        [TypeProxyDefinition(TypeName="Game_NPCController")]
        public System.Type controllerType;
        
        [Sirenix.OdinInspector.FoldoutGroup("Policy")]
        [FieldConst()]
        public bool TriggeredSpawn;
        
        [Sirenix.OdinInspector.FoldoutGroup("Policy")]
        [FieldConst()]
        public bool TriggeredRespawn;
        
        [Sirenix.OdinInspector.FoldoutGroup("Policy")]
        [FieldConst()]
        public bool TriggeredDespawn;
        
        [Sirenix.OdinInspector.FoldoutGroup("Policy")]
        [FieldConst()]
        public NameProperty EventOnWiped;
        
        [Sirenix.OdinInspector.FoldoutGroup("Policy")]
        [FieldConst()]
        public NameProperty EventOnSpawn;
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public List<NPC_AI> Scripts = new List<NPC_AI>();
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public float ChaseRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public float VisualRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public float LineOfSightRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public float ThreatRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public bool ShowAIRanges;
        
        [Sirenix.OdinInspector.FoldoutGroup("Hormones")]
        public float AggressionFactor;
        
        [Sirenix.OdinInspector.FoldoutGroup("Hormones")]
        public float FearFactor;
        
        [Sirenix.OdinInspector.FoldoutGroup("Hormones")]
        public float SocialFactor;
        
        [Sirenix.OdinInspector.FoldoutGroup("Hormones")]
        public float BoredomFactor;
        
        public List<Game_NPCController> Spawns = new List<Game_NPCController>();
        
        [System.NonSerialized, UnityEngine.HideInInspector]
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
