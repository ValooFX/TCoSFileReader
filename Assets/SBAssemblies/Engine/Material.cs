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
    
    
    [System.Serializable] public class Material : UObject
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Material")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material FallbackMaterial;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material DefaultMaterial;
        
        [FieldConst()]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public bool UseFallback;
        
        [FieldConst()]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public bool Validated;
        
        [Sirenix.OdinInspector.FoldoutGroup("Material")]
        public Actor.ESurfaceTypes SurfaceType;
        
        public int MaterialType;
        
        public Material()
        {
        }
    }
}
/*
native function int MaterialVSize();
native function int MaterialUSize();
function Trigger(Actor Other,Actor EventInstigator) {
if (FallbackMaterial != None) {                                             
FallbackMaterial.Trigger(Other,EventInstigator);                          
}
}
function Reset() {
if (FallbackMaterial != None) {                                             
FallbackMaterial.Reset();                                                 
}
}
*/
