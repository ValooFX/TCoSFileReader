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
    
    
    [System.Serializable] public class NPC_Effects : Content_API
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("NPC_Effects")]
        public List<FSkill_EffectClass_AudioVisual> EffectList = new List<FSkill_EffectClass_AudioVisual>();
        
        public NPC_Effects()
        {
        }
    }
}
/*
function Apply(Game_Pawn aPawn) {
local int i;
if (IsClient()) {                                                           
if (aPawn.Effects != None) {                                              
i = 0;                                                                  
while (i < EffectList.Length) {                                         
aPawn.Effects.cl_Start(EffectList[i],Class'Game_Effects'.-1073741824,0.00000000,0.00000000,Class'FSkill_EffectClass_AudioVisual'.-1.00000000);
i++;                                                                  
}
}
}
}
*/
