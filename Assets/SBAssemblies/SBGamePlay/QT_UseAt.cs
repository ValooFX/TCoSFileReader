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
    
    
    [System.Serializable] public class QT_UseAt : Quest_Target
    {
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        [FieldConst()]
        public Item_Type Item;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        public NameProperty UseLocationTag;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        public LocalizedString LocationDescription;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        [FieldConst()]
        public int Amount;
        
        [Sirenix.OdinInspector.FoldoutGroup("Use")]
        public byte Option;
        
        public QT_UseAt()
        {
        }
    }
}
/*
event string GetActiveText(Game_ActiveTextItem aItem) {
if (aItem.Tag == "T") {                                                     
return LocationDescription.Text;                                          
} else {                                                                    
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
}
protected function AppendProgressText(out string aDescription,int aProgress) {
if (Amount > 1) {                                                           
}
}
protected function string GetDefaultDescription() {
return Class'StringReferences'.default.QT_UseAtText.Text;                   
}
event RadialMenuCollect(Game_Pawn aPlayerPawn,Object aObject,byte aMainOption,out array<byte> aSubOptions) {
local Quest_Trigger Area;
if (aObject == None) {                                                      
foreach aPlayerPawn.TouchingActors(Class'Quest_Trigger',Area) {           
if (Area.Tag == UseLocationTag) {                                       
aSubOptions[aSubOptions.Length] = Option;                             
}
}
}
}
*/
