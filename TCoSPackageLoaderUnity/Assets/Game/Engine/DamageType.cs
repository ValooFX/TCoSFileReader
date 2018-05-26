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
    
    
    [System.Serializable] public class DamageType : Actor
    {
        
        [FieldCategory(Category="DamageType")]
        public string DeathString = string.Empty;
        
        [FieldCategory(Category="DamageType")]
        public string FemaleSuicide = string.Empty;
        
        [FieldCategory(Category="DamageType")]
        public string MaleSuicide = string.Empty;
        
        [FieldCategory(Category="DamageType")]
        public float ViewFlash;
        
        [FieldCategory(Category="DamageType")]
        public Vector ViewFog;
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Effects")]
        public System.Type DamageEffect;
        
        [FieldCategory(Category="DamageType")]
        public string DamageWeaponName = string.Empty;
        
        [FieldCategory(Category="DamageType")]
        public bool bArmorStops;
        
        [FieldCategory(Category="DamageType")]
        public bool bInstantHit;
        
        [FieldCategory(Category="DamageType")]
        public bool bFastInstantHit;
        
        [FieldCategory(Category="DamageType")]
        public bool bAlwaysGibs;
        
        [FieldCategory(Category="DamageType")]
        public bool bLocationalHit;
        
        [FieldCategory(Category="DamageType")]
        public bool bAlwaysSevers;
        
        [FieldCategory(Category="DamageType")]
        public bool bSpecial;
        
        [FieldCategory(Category="DamageType")]
        public bool bDetonatesGoop;
        
        [FieldCategory(Category="DamageType")]
        public bool bSkeletize;
        
        [FieldCategory(Category="DamageType")]
        public bool bCauseConvulsions;
        
        [FieldCategory(Category="DamageType")]
        public bool bSuperWeapon;
        
        [FieldCategory(Category="DamageType")]
        public bool bCausesBlood;
        
        [FieldCategory(Category="DamageType")]
        public bool bKUseOwnDeathVel;
        
        [FieldCategory(Category="DamageType")]
        public bool bKUseTearOffMomentum;
        
        public bool bDelayedDamage;
        
        public bool bNeverSevers;
        
        public bool bThrowRagdoll;
        
        public bool bRagdollBullet;
        
        public bool bLeaveBodyEffect;
        
        public bool bExtraMomentumZ;
        
        public bool bFlaming;
        
        public bool bRubbery;
        
        public bool bCausedByWorld;
        
        public bool bDirectDamage;
        
        public bool bBulletHit;
        
        public bool bVehicleHit;
        
        [FieldCategory(Category="DamageType")]
        public float GibModifier;
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Effects")]
        public System.Type PawnDamageEffect;
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Emitter")]
        public System.Type PawnDamageEmitter;
        
        [FieldCategory(Category="DamageType")]
        [IgnoreFieldExtraction()]
        public List<Sound> PawnDamageSounds = new List<Sound>();
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Effects")]
        public System.Type LowGoreDamageEffect;
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Emitter")]
        public System.Type LowGoreDamageEmitter;
        
        [FieldCategory(Category="DamageType")]
        [IgnoreFieldExtraction()]
        public List<Sound> LowGoreDamageSounds = new List<Sound>();
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Effects")]
        public System.Type LowDetailEffect;
        
        [FieldCategory(Category="DamageType")]
        [TypeProxyDefinition(TypeName="Emitter")]
        public System.Type LowDetailEmitter;
        
        [FieldCategory(Category="DamageType")]
        public float FlashScale;
        
        [FieldCategory(Category="DamageType")]
        public Vector FlashFog;
        
        [FieldCategory(Category="DamageType")]
        public int DamageDesc;
        
        [FieldCategory(Category="DamageType")]
        public int DamageThreshold;
        
        [FieldCategory(Category="DamageType")]
        public Vector DamageKick;
        
        [FieldCategory(Category="DamageType")]
        [IgnoreFieldExtraction()]
        public Material DamageOverlayMaterial;
        
        [FieldCategory(Category="DamageType")]
        [IgnoreFieldExtraction()]
        public Material DeathOverlayMaterial;
        
        [FieldCategory(Category="DamageType")]
        public float DamageOverlayTime;
        
        [FieldCategory(Category="DamageType")]
        public float DeathOverlayTime;
        
        [FieldCategory(Category="DamageType")]
        public float GibPerterbation;
        
        [FieldCategory(Category="Karma")]
        public float KDamageImpulse;
        
        [FieldCategory(Category="Karma")]
        public float KDeathVel;
        
        [FieldCategory(Category="Karma")]
        public float KDeathUpKick;
        
        public float VehicleDamageScaling;
        
        public float VehicleMomentumScaling;
        
        public DamageType()
        {
        }
    }
}
/*
static function string GetWeaponClass() {
return "";                                                                  
}
static function GetHitEffects(out class<xEmitter> HitEffects[4],int VictemHealth);
static function bool IsOfType(int Description) {
local int Result;
Result = Description & default.DamageDesc;                                  
return Result == Description;                                               
}
static function Sound GetPawnDamageSound() {
if (default.PawnDamageSounds.Length > 0) {                                  
return default.PawnDamageSounds[Rand(default.PawnDamageSounds.Length)];   
} else {                                                                    
return None;                                                              
}
}
static function class<Emitter> GetPawnDamageEmitter(Vector HitLocation,float Damage,Vector Momentum,Pawn Victim,bool bLowDetail) {
if (bLowDetail) {                                                           
if (default.LowDetailEmitter != None) {                                   
return default.LowDetailEmitter;                                        
} else {                                                                  
return None;                                                            
}
} else {                                                                    
if (default.PawnDamageEmitter != None) {                                  
return default.PawnDamageEmitter;                                       
} else {                                                                  
return None;                                                            
}
}
}
static function class<Effects> GetPawnDamageEffect(Vector HitLocation,float Damage,Vector Momentum,Pawn Victim,bool bLowDetail) {
if (bLowDetail) {                                                           
if (default.LowDetailEffect != None) {                                    
return default.LowDetailEffect;                                         
} else {                                                                  
return Victim.BloodEffect;                                              
}
} else {                                                                    
if (default.PawnDamageEffect != None) {                                   
return default.PawnDamageEffect;                                        
} else {                                                                  
return Victim.BloodEffect;                                              
}
}
}
static function ScoreKill(Controller Killer,Controller Killed) {
IncrementKills(Killer);                                                     
}
static function IncrementKills(Controller Killer);
*/