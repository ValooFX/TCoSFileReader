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
    
    
    [System.Serializable] public class QT_Use : Quest_Target
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        [FieldConst()]
        public Item_Type Item;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        public byte Option;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        [FieldConst()]
        public int Amount;
        
        public QT_Use()
        {
        }
    }
}
/*
event string GetActiveText(Game_ActiveTextItem aItem) {
if (aItem.Tag == "O") {                                                     
if (Item != None) {                                                       
return Item.GetActiveText(aItem.SubItem);                               
} else {                                                                  
return "?Object?";                                                      
}
} else {                                                                    
if (aItem.Tag == "Q") {                                                   
return "" @ string(Amount);                                             
} else {                                                                  
return Super.GetActiveText(aItem);                                      
}
}
}
protected function AppendProgressText(out string aDescription,int aProgress) {
if (Amount > 1) {                                                           
}
}
protected function string GetDefaultDescription() {
return Class'StringReferences'.default.QT_UseText.Text;                     
}
event RadialMenuCollect(Game_Pawn aPlayerPawn,Object aObject,byte aMainOption,out array<byte> aSubOptions) {
if (aObject == None) {                                                      
aSubOptions[aSubOptions.Length] = Option;                                 
}
}
*/
