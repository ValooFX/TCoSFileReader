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

namespace SBGame
{
    
    
    [System.Serializable] public class IC_Appearance : Item_Component
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("IC_Appearance")]
        [FieldConst()]
        public Appearance_Base Appearance;
        
        [Sirenix.OdinInspector.FoldoutGroup("IC_Appearance")]
        [FieldConst()]
        public int DyePrice;
        
        public IC_Appearance()
        {
        }
    }
}
/*
function ToConsole(Console C) {
C.Message("        Appearance = " $ string(Appearance)
@ string(Appearance.Part)
@ string(Appearance._AS_Index)
@ string(Appearance._AS_Set),0.00000000);
}
function Appearance_Base GetAppearance() {
return Appearance;                                                          
}
*/
