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
    
    
    [System.Serializable] public class NA_Static : NPC_Appearance
    {
        
        [FieldCategory(Category="NA_Static")]
        [IgnoreFieldExtraction()]
        public StaticMesh StatMesh;
        
        [FieldCategory(Category="NA_Static")]
        public float Scale;
        
        [FieldCategory(Category="NA_Static")]
        public bool Statue;
        
        [FieldCategory(Category="NA_Static")]
        public bool Ghostly;
        
        [FieldCategory(Category="NA_Static")]
        public float CollisionRadius;
        
        [FieldCategory(Category="NA_Static")]
        public float CollisionHeight;
        
        [FieldCategory(Category="NA_Static")]
        public float SkillRadius;
        
        public NA_Static()
        {
        }
    }
}
/*
function Game_Appearance CreateAppearance(Game_Pawn aPawn,export editinline Game_Appearance aAppearance,bool aShifting) {
local export editinline Game_StaticAppearance pawnAppearance;
aAppearance = ForceAppearanceClass(aPawn,aAppearance,Class'Game_StaticAppearance');
aAppearance = Super.CreateAppearance(aPawn,aAppearance,aShifting);          
pawnAppearance = Game_StaticAppearance(aAppearance);                        
pawnAppearance.StatMesh = StatMesh;                                         
pawnAppearance.SetScale(Scale);                                             
if (Statue) {                                                               
pawnAppearance.SetStatue(True);                                           
}
if (Ghostly) {                                                              
pawnAppearance.SetGhost(True);                                            
}
pawnAppearance.CollisionRadius = GetCollisionRadius();                      
pawnAppearance.CollisionHeight = GetCollisionHeight();                      
pawnAppearance.SkillRadius = GetSkillRadius();                              
return aAppearance;                                                         
}
*/