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

namespace SBGamePlay
{
    
    
    [System.Serializable] public class NA_Skeletal : NA_RaceBodyGender
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("NA_Skeletal")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Mesh SkeletalMesh;
        
        [Sirenix.OdinInspector.FoldoutGroup("NA_Skeletal")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Mesh SkeletalMeshAddition;
        
        [Sirenix.OdinInspector.FoldoutGroup("NA_Skeletal")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material SkinTexture;
        
        [Sirenix.OdinInspector.FoldoutGroup("Modifiers")]
        public bool Ghostly;
        
        [Sirenix.OdinInspector.FoldoutGroup("Modifiers")]
        public bool Statue;
        
        [Sirenix.OdinInspector.FoldoutGroup("Modifiers")]
        public float Scale;
        
        public NA_Skeletal()
        {
        }
    }
}
/*
function Game_Appearance CreateAppearance(Game_Pawn aPawn,export editinline Game_Appearance aAppearance,bool aShifting) {
local export editinline Game_SkeletalAppearance pawnAppearance;
aAppearance = ForceAppearanceClass(aPawn,aAppearance,Class'Game_SkeletalAppearance');
aAppearance = Super.CreateAppearance(aPawn,aAppearance,aShifting);          
pawnAppearance = Game_SkeletalAppearance(aAppearance);                      
pawnAppearance.SkeletalMesh = SkeletalMesh;                                 
pawnAppearance.SkeletalMeshAddition = SkeletalMeshAddition;                 
pawnAppearance.SkinTexture = SkinTexture;                                   
pawnAppearance.SetScale(Scale);                                             
if (Statue) {                                                               
pawnAppearance.SetStatue(True);                                           
}
if (Ghostly) {                                                              
pawnAppearance.SetGhost(True);                                            
}
pawnAppearance.SetRace(Race);                                               
pawnAppearance.SetGender(Gender);                                           
pawnAppearance.SetBody(Bodytype);                                           
pawnAppearance.CollisionRadius = GetCollisionRadius();                      
pawnAppearance.CollisionHeight = GetCollisionHeight();                      
pawnAppearance.SkillRadius = GetSkillRadius();                              
return aAppearance;                                                         
}
*/
