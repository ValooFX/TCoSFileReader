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

namespace SBGame
{
    
    
    [System.Serializable] public class NPC_Habitat : Actor
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("aI")]
        public float HabitatRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("Hormones")]
        public float DesolationRate;
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public List<NPC_Spawner> Prey = new List<NPC_Spawner>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public List<WanderSmell> Smells = new List<WanderSmell>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public int SmellSpawns;
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public List<WanderObstacle> Obstacles = new List<WanderObstacle>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public float IntruderAttraction;
        
        [Sirenix.OdinInspector.FoldoutGroup("Habitat")]
        public float SocialAttraction;
        
        public NPC_Habitat()
        {
        }
        
        [System.Serializable] public struct WanderObstacle
        {
            
            public Actor Obstacle;
            
            public Vector Offset;
            
            public float Size;
            
            public float Range;
        }
        
        [System.Serializable] public struct WanderSmell
        {
            
            public Vector Location;

            public float Strength;

            public float Size;
        }
    }
}
/*
final native function bool CheckHabitat(Vector aLocation);
*/
