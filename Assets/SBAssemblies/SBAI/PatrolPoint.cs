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

namespace SBAI
{
    
    
    [System.Serializable] public class PatrolPoint : AIPoint
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("PatrolPoint")]
        public bool PausePatrolScript;
        
        [Sirenix.OdinInspector.FoldoutGroup("PatrolPoint")]
        public bool bWalking;
        
        [Sirenix.OdinInspector.FoldoutGroup("PatrolPoint")]
        public float MinimalPathHeight;
        
        [Sirenix.OdinInspector.FoldoutGroup("Debugging")]
        public bool ShowPrecomputedPaths;
        
        public List<SBPath> PatrolPaths = new List<SBPath>();
        
        public PatrolPoint()
        {
        }
    }
}
