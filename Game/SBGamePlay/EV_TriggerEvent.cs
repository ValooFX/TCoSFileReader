﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using SBGame;


namespace SBGamePlay
{


    public class EV_TriggerEvent : Content_Event
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Action")]
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public string EventTag = string.Empty;
        
        public EV_TriggerEvent()
        {
        }
    }
}
/*
function sv_Execute(Game_Pawn aObject,Game_Pawn aSubject) {
if (aObject != None) {                                                      
aObject.TriggerEvent(EventTag,aObject,aObject);                           
} else {                                                                    
if (aSubject != None) {                                                   
aSubject.TriggerEvent(EventTag,aSubject,aSubject);                      
}
}
}
function bool sv_CanExecute(Game_Pawn aObject,Game_Pawn aSubject) {
return aObject != None || aSubject != None;                                 
}
*/