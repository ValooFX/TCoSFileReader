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
    
    
    [System.Serializable] public class Conversation_Node : Content_Type
    {
        
        [FieldCategory(Category="Text")]
        public LocalizedString Text;
        
        [FieldCategory(Category="Results")]
        public List<Conversation_Response> Responses = new List<Conversation_Response>();
        
        [FieldCategory(Category="Results")]
        public bool locked;
        
        [FieldCategory(Category="Requirements")]
        public List<Content_Requirement> Requirements = new List<Content_Requirement>();
        
        [FieldCategory(Category="Events")]
        public List<Content_Event> Events = new List<Content_Event>();
        
        public Conversation_Node()
        {
        }
    }
}
/*
event bool sv_OnConversation(Game_Pawn aSpeaker,Game_Pawn aPartner) {
local int eventI;
eventI = 0;                                                                 
while (eventI < Events.Length) {                                            
if (Events[eventI] != None
&& !Events[eventI].sv_CanExecute(aSpeaker,aPartner)) {
return False;                                                           
}
eventI++;                                                                 
}
eventI = 0;                                                                 
while (eventI < Events.Length) {                                            
Events[eventI].sv_Execute(aSpeaker,aPartner);                             
eventI++;                                                                 
}
return True;                                                                
}
final native function bool CheckNode(export editinline Conversation_Topic aTopic,Game_Pawn aSpeaker,Game_Pawn aPartner);
function Render(export editinline Conversation_Topic aTopic,Game_Pawn aSpeaker,Game_Pawn aPartner,Object aRenderSlot) {
}
function string GetText() {
if (Len(Text.Text) > 0) {                                                   
return Text.Text;                                                         
} else {                                                                    
return "Empty Conversation";                                              
}
}
*/