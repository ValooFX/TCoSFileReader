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
    
    
    [System.Serializable] public class TerrainInfo : Info
    {
        
        [FieldConst()]
        public int HeightmapX;
        
        [FieldConst()]
        public int HeightmapY;
        
        [FieldConst()]
        public int SectorsX;
        
        [FieldConst()]
        public int SectorsY;
        
        [FieldConst()]
        public TerrainPrimitive Primitive;
        
        public TerrainInfo()
        {
        }
    }
}
/*
final native function PokeTerrain(Vector WorldLocation,int Radius,int MaxDepth);
*/
