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
    
    
    [System.Serializable] public class RenderDevice : Subsystem
    {
        
        [FieldConfig()]
        public int TerrainLOD;
        
        [FieldConfig()]
        public bool HighDetailActors;
        
        [FieldConfig()]
        public bool SuperHighDetailActors;
        
        [FieldConfig()]
        public bool DetailTextures;
        
        [FieldConfig()]
        public bool UseCompressedLightmaps;
        
        [FieldConfig()]
        public bool UseStencil;
        
        [FieldConfig()]
        public bool Use16bit;
        
        [FieldConfig()]
        public bool Use16bitTextures;
        
        [FieldConfig()]
        public bool LowQualityTerrain;
        
        [FieldConfig()]
        public bool SkyboxHack;
        
        [FieldConfig()]
        public bool UseSpellbornShaders;
        
        [FieldConfig()]
        public bool UseHQFog;
        
        public RenderDevice()
        {
        }
    }
}
