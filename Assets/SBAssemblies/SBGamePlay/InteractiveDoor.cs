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
using SBAssemblies;

namespace SBGamePlay
{
    
    
    [System.Serializable] public class InteractiveDoor : InteractiveLevelElement
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("InteractiveDoor")]
        public int DestinationWorld;
        
        [Sirenix.OdinInspector.FoldoutGroup("InteractiveDoor")]
        public string Parameter = string.Empty;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public string spawnPointTag = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("InteractiveDoor")]
        public LocalizedString DoorSign;
        
        [Sirenix.OdinInspector.FoldoutGroup("InteractiveDoor")]
        public bool IsInstance;
        
        public InteractiveDoor()
        {
        }
    }
}
/*
event string cl_GetToolTip() {
return DoorSign.Text;                                                       
}
*/
