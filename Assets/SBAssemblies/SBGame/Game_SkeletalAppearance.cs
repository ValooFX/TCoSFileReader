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
    
    
    [System.Serializable] public class Game_SkeletalAppearance : Game_Appearance
    {
        
        public float CollisionRadius;
        
        public float CollisionHeight;
        
        public float SkillRadius;
        
        public Game_SkeletalAppearance()
        {
        }
    }
}
/*
function app(int A) {
Super.app(0);                                                               
if (A == 0) {                                                               
cl_ConsoleMessage("Mesh == " $ string(SkeletalMesh));                     
}
}
function bool Check() {
return SkeletalMesh != None;                                                
}
*/
