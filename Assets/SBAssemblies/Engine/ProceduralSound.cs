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
    
    
    [System.Serializable] public class ProceduralSound : Sound
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Sound BaseSound;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        public float PitchModification;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        public float VolumeModification;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        public float PitchVariance;
        
        [Sirenix.OdinInspector.FoldoutGroup("Sound")]
        public float VolumeVariance;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float RenderedPitchModification;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float RenderedVolumeModification;
        
        public ProceduralSound()
        {
        }
    }
}
