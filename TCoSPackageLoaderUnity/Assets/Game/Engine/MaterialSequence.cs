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
    
    
    [System.Serializable] public class MaterialSequence : Modifier
    {
        
        [FieldCategory(Category="MaterialSequence")]
        public List<MaterialSequenceItem> SequenceItems = new List<MaterialSequenceItem>();
        
        [FieldCategory(Category="MaterialSequence")]
        public byte TriggerAction;
        
        [FieldCategory(Category="MaterialSequence")]
        public bool LoopSequence;
        
        [FieldCategory(Category="MaterialSequence")]
        public bool Paused;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float CurrentTime;
        
        [IgnoreFieldExtraction()]
        [FieldTransient()]
        public float LastTime;
        
        public float TotalTime;
        
        public MaterialSequence()
        {
        }
        
        [System.Serializable] public struct MaterialSequenceItem
        {
            
            public Material Material;
            
            public float Time;
            
            public byte Action;
        }
        
        public enum EMaterialSequenceTriggerActon
        {
            
            MSTA_Ignore ,
            
            MSTA_Reset ,
            
            MSTA_Pause ,
            
            MSTA_Stop,
        }
        
        public enum EMaterialSequenceAction
        {
            
            MSA_ShowMaterial ,
            
            MSA_FadeToMaterial,
        }
    }
}
/*
function Trigger(Actor Other,Actor EventInstigator) {
switch (TriggerAction) {                                                    
case 1 :                                                                  
CurrentTime = 0.00000000;                                               
LastTime = 0.00000000;                                                  
break;                                                                  
case 2 :                                                                  
Paused = !Paused;                                                       
break;                                                                  
case 3 :                                                                  
Paused = True;                                                          
break;                                                                  
default:                                                                  
}
}
function Reset() {
CurrentTime = 0.00000000;                                                   
LastTime = 0.00000000;                                                      
Paused = default.Paused;                                                    
}
*/