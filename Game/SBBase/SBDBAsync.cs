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
using TCosReborn.Framework.Common;


namespace SBBase
{


    public class SBDBAsync : SBPackageResource
    {
        
        public SBDBAsync()
        {
        }
        
        public struct SetPersistentVariableParams
        {
            
            public int character_id;
            
            public int context_id;
            
            public int value_id;
            
            public int Value;
            
            public Pawn Pawn;
        }
        
        public struct SBDBAsyncCallback
        {
            
            public string ObjectName;
            
            public string funcName;
            
            public int UserData;
            
            public int NativeFunction;
        }
    }
}
/*
static native function SetPersistentPlayerVariable(Pawn Pawn,int character_id,int context_id,int value_id,int Value);
static native function UpdateStatueNewPlayerByTag(Pawn Pawn,string Tag,int new_character_id,string new_player_name,string new_title,string new_description,array<byte> new_loddata0,array<byte> new_loddata1,array<byte> new_loddata2,array<byte> new_loddata3,int new_awarded_timestamp,int new_pose);
static native function GetStatueEnabledByTag(Pawn aPawn,string Tag,SBDBAsyncCallback callback);
static native function SetQuestObjective(Pawn Pawn,int CharacterID,int objectiveID,int Value,SBDBAsyncCallback callback);
static native function SetCharacterSkilldeckSkills(Pawn Pawn,int character_id,int skilldeck_id,array<int> skilldeck_skills);
static native function LogCSCommand(int aCSAccountID,string aCSname,string aCommand,int aPlayerAccountID,optional string aPlayerName,optional string aMessage,optional string lootItems,optional coerce string muteScope,optional int muteDuration,optional string killDetails);
static native function SetCharacterFaction(Pawn Pawn,int Id,int faction_id);
static native function SetCharacterClass(Pawn Pawn,int Id,int class_id);
static native function UpdateCharacterFamePep(Pawn Pawn,int Id,float fame_points,float pep_points);
static native function UpdateCharacterHealth(Pawn Pawn,int Id,float Health);
*/