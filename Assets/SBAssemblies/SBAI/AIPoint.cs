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

namespace SBAI
{
    
    
    [System.Serializable] public class AIPoint : AnnotationActor
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Script")]
        public Annotation_Script AnnotationScript;
        
        [Sirenix.OdinInspector.FoldoutGroup("Script")]
        public bool TriggerScript;
        
        [Sirenix.OdinInspector.FoldoutGroup("Script")]
        public bool WaitForScript;
        
        public AIPoint()
        {
        }
    }
}
/*
event PointReached(Game_Pawn aPawn) {
if (Event != 'None') {                                                      
TriggerEvent(Event,self,aPawn);                                           
}
}
final native function bool GetWalking();
final native function AIPoint GetControlDestination(Game_Pawn aPawn);
*/
