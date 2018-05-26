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
    
    
    [System.Serializable] public class Sound : UObject
    {
        
        [FieldCategory(Category="Sound")]
        public float Likelihood;
        
        [FieldConst()]
        [ArraySizeForExtraction(Size=48)]
        public byte[] Data = new byte[0];
        
        [FieldConst()]
        public NameProperty FileType;
        
        [FieldConst()]
        public string fileName = string.Empty;
        
        [FieldConst()]
        public int OriginalSize;
        
        [FieldConst()]
        public float Duration;
        
        [FieldConst()]
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public int Handle;
        
        [FieldConst()]
        public int flags;
        
        [FieldConst()]
        public int VoiceCodec;
        
        [FieldConst()]
        public float InitialSeekTime;
        
        [FieldCategory(Category="Sound")]
        public float BaseRadius;
        
        [FieldCategory(Category="Sound")]
        public float VelocityScale;
        
        public Sound()
        {
        }
    }
}