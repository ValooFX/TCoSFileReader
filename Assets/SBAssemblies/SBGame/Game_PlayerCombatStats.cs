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
using SBAssemblies;

namespace SBGame
{
    
    
    [System.Serializable] public class Game_PlayerCombatStats : Game_CombatStats
    {
        
        public float mPvPTimer;
        
        [FieldConfig()]
        public float PvPTimeOut;
        
        public float mCombatIdleTimer;
        
        [FieldConfig()]
        public float CombatIdleTimeOut;
        
        public Game_PlayerCombatStats()
        {
        }
    }
}
/*
protected native function cl2sv_ShakeCombat_CallStub();
native event cl2sv_ShakeCombat();
protected native function bool GetOuterDead();
protected event string GetOuterName() {
return "Player" @ Outer.Character.sv_GetName();                             
}
function sv_QuestCredit(array<Game_Pawn> Enemies) {
local int enemyI;
local Game_Controller enemyController;
enemyI = 0;                                                                 
while (enemyI < Enemies.Length) {                                           
enemyController = Game_Controller(Enemies[enemyI].Controller);            
enemyController.sv_FireHook(6,Outer,0);                                   
enemyI++;                                                                 
}
}
*/
