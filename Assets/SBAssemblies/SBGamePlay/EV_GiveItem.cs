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
    
    
    [System.Serializable] public class EV_GiveItem : Content_Event
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        [FieldConst()]
        public Content_Inventory Items;
        
        public EV_GiveItem()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
GiveItems(aSubject,Items);                                                  
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
if (CanReceiveItems(aSubject,Items)) {                                      
return True;                                                              
}
return False;                                                               
}
*/
