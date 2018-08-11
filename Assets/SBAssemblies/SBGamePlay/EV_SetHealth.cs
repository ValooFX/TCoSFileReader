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
    
    
    [System.Serializable] public class EV_SetHealth : Content_Event
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        [FieldConst()]
        public byte HealthMode;
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        [FieldConst()]
        public float HealthValue;
        
        public EV_SetHealth()
        {
        }
        
        public enum EHealthMode
        {
            
            HM_ABSOLUTE ,
            
            HM_RELATIVE ,
            
            HM_ABSOLUTE_PERCENTAGE ,
            
            HM_RELATIVE_PERCENTAGE,
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
switch (HealthMode) {                                                       
case 0 :                                                                  
aSubject.SetHealth(HealthValue);                                        
break;                                                                  
case 1 :                                                                  
aSubject.IncreaseHealth(HealthValue);                                   
break;                                                                  
case 2 :                                                                  
aSubject.SetHealth(HealthValue * aSubject.CharacterStats.mRecord.MaxHealth);
break;                                                                  
case 3 :                                                                  
aSubject.SetHealth(HealthValue * aSubject.GetHealth());                 
break;                                                                  
default:                                                                  
}
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
return aSubject != None;                                                    
}
*/
