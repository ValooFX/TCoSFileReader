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
using System.Collections.Generic;


namespace SBGamePlay
{


    public class Interaction_Action : Interaction_Component
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="Interaction_Action")]
        public List<Content_Event> Actions = new List<Content_Event>();
        
        public Interaction_Action()
        {
        }
    }
}
/*
function SvOnStart(Game_Actor aOwner,Game_Pawn aInstigator,bool aReverse) {
local int aI;
local bool doExecute;
Super.SvOnStart(aOwner,aInstigator);                                        
if (!aReverse) {                                                            
doExecute = True;                                                         
aI = 0;                                                                   
while (aI < Actions.Length) {                                             
if (Actions[aI] != None
&& !Actions[aI].sv_CanExecute(aInstigator,aInstigator)) {
doExecute = False;                                                    
goto jl0086;                                                          
}
aI++;                                                                   
}
if (doExecute) {                                                          
aI = 0;                                                                 
while (aI < Actions.Length) {                                           
if (Actions[aI] != None) {                                            
Actions[aI].sv_Execute(aInstigator,aInstigator);                    
}
aI++;                                                                 
}
}
}
}
*/