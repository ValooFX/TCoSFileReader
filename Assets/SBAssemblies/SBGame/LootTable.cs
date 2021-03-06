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
    
    
    [System.Serializable] public class LootTable : Content_Type
    {
        
        public List<LootEntry> Entries = new List<LootEntry>();

        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public string Name = string.Empty;

        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public byte TableType;
        
        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public int MinDropQuantity;
        
        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public int MaxDropQuantity;
        
        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public int MoneyBase;
        
        [Sirenix.OdinInspector.FoldoutGroup("LootTable")]
        public int MoneyPerLevel;
        
        public LootTable()
        {
        }
        
        [System.Serializable] public struct DroppedItem
        {
            
            public Item_Type Item;
            
            public int Quantity;
            
            public int MinLevel;
            
            public int MaxLevel;
        }
        
        [System.Serializable] public struct LootEntry
        {
            
            public Item_Type Item;
            
            public int MinQuantity;
            
            public int MaxQuantity;
            
            public int Chance;
            
            public int MinLevel;
            
            public int MaxLevel;
        }
        
        public enum ETableType
        {
            
            ETT_Loot ,
            
            ETT_Scavenge ,
            
            ETT_ShopStock,
        }
    }
}
/*
native function InitDroppedItems(out array<DroppedItem> aResultItems);
function bool HasScavengeItems() {
return TableType == 1;                                                      
}
function bool HasLootItems() {
return TableType == 0;                                                      
}
*/
