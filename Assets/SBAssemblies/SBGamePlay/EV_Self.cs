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

namespace SBGamePlay
{
    
    
    [System.Serializable] public class EV_Self : Content_Event
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        [FieldConst()]
        public Content_Event SelfAction;
        
        public EV_Self()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
SelfAction.sv_Execute(aObject,aObject);                                     
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
if (SelfAction != None) {                                                   
return SelfAction.sv_CanExecute(aObject,aObject);                         
}
return False;                                                               
}
*/
