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

namespace Engine
{
    
    
    [System.Serializable] public class SBAttachment : Actor
    {
        
        public byte AnimationType;
        
        public NameProperty AttachmentTag;
        
        public SBAttachment()
        {
        }
        
        public enum SBAttachment_AnimType
        {
            
            SBAttachAnim_None ,
            
            SBAttachAnim_UseOwnerBones ,
            
            SBAttachAnim_HasOwnAnim ,
            
            SBAttachAnim_ClothSim,
        }
    }
}
/*
function PostBeginPlay() {
Super.PostBeginPlay();                                                      
SetupParameters();                                                          
}
function SetupParameters() {
UpdateOffsetTransform();                                                    
}
function SetAnimType(byte newType) {
AnimationType = newType;                                                    
}
native function SetSkin(string skinName);
native function SetMesh(string meshName);
native function Initialize();
native function UpdateOffsetTransform();
native function AttachTo(Actor Actor);
*/
