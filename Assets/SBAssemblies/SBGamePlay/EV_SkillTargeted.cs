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
    
    
    [System.Serializable] public class EV_SkillTargeted : Content_Event
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Action")]
        [FieldConst()]
        public FSkill_Type Skill;
        
        public EV_SkillTargeted()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
local Game_Pawn executor;
local Game_Pawn Target;
local bool sheathe;
if (aObject != None) {                                                      
executor = aObject;                                                       
} else {                                                                    
executor = aSubject;                                                      
}
if (aSubject != None) {                                                     
Target = aSubject;                                                        
} else {                                                                    
Target = aObject;                                                         
}
if (!executor.combatState.CheckWeaponType(Skill.RequiredWeapon)) {          
sheathe = executor.combatState.CombatReady();                             
executor.combatState.sv_SwitchToWeaponType(Skill.RequiredWeapon);         
}
if (Target != None) {                                                       
executor.Skills.ExecuteL(Skill,Target.Location,executor.Level.TimeSeconds);
} else {                                                                    
executor.Skills.ExecuteL(Skill,executor.Location,executor.Level.TimeSeconds);
}
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
return Skill != None
&& aObject.Skills.CanActivateSpecificSkill(Skill) == 0
&& (aObject != None || aSubject != None);
}
*/
