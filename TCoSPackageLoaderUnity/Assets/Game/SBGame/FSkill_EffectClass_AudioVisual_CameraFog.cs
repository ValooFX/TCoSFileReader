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
    
    
    [System.Serializable] public class FSkill_EffectClass_AudioVisual_CameraFog : FSkill_EffectClass_AudioVisual_Camera
    {
        
        [FieldCategory(Category="CameraFog")]
        [FieldConst()]
        public float FogColorAmount;
        
        [FieldCategory(Category="CameraFog")]
        [FieldConst()]
        [IgnoreFieldExtraction()]
        public Color FogColor;
        
        [FieldCategory(Category="CameraFog")]
        [FieldConst()]
        public float FogDensity;
        
        public FSkill_EffectClass_AudioVisual_CameraFog()
        {
        }
    }
}