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
    
    
    [System.Serializable] public class Content_Requirement : Content_Type
    {
        
        public int ControlLocationX;
        
        public int ControlLocationY;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int ControlRef;
        
        public bool ValidForPlayer;
        
        public bool ValidForRelevant;
        
        public Content_Requirement()
        {
        }
    }
}
/*
event string ToString();
native function GetActorRelations(Actor aSource,out array<ActorRelation> oRelations);
final native function bool cl_IsValidFor(Game_Pawn aPawn);
final native function bool CheckPawn(Game_Pawn aPawn);
*/
