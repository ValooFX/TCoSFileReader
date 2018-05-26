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
    
    
    [System.Serializable] public class EV_NPC : Content_Event
    {
        
        [FieldCategory(Category="Action")]
        [FieldConst()]
        public NPC_Type NPC;
        
        [FieldCategory(Category="Action")]
        [FieldConst()]
        public Content_Event NPCAction;
        
        [FieldCategory(Category="Action")]
        [FieldConst()]
        public float Radius;
        
        public EV_NPC()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
local Game_Pawn npcPawn;
if (aObject != None) {                                                      
npcPawn = FindNPC(aObject,NPC,Radius);                                    
}
if (npcPawn == None) {                                                      
npcPawn = FindNPC(aSubject,NPC,Radius);                                   
}
NPCAction.sv_Execute(npcPawn,aSubject);                                     
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
local Game_Pawn npcPawn;
if (NPCAction != None) {                                                    
if (aObject != None) {                                                    
npcPawn = FindNPC(aObject,NPC,Radius);                                  
}
if (npcPawn == None) {                                                    
npcPawn = FindNPC(aSubject,NPC,Radius);                                 
}
if (npcPawn != None) {                                                    
return NPCAction.sv_CanExecute(npcPawn,aSubject);                       
}
}
return False;                                                               
}
*/