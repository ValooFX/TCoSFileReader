﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Engine
{


    public class BaseGUIController : Interaction
    {
        
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.ArraySizeForExtractionAttribute(Size=3)]
        public Material[] DefaultPens = new Material[0];
        
        [TCosReborn.Framework.Attributes.FieldConfigAttribute()]
        public string NetworkMsgMenu = string.Empty;
        
        [TCosReborn.Framework.Attributes.FieldConfigAttribute()]
        public string QuestionMenuClass = string.Empty;
        
        public BaseGUIController()
        {
        }
    }
}
/*
function HandleEvent(int eventID,Object Source,optional UObject context);
event SetRequiredGameResolution(string GameRes);
event bool NeedsMenuResolution();
event InitializeController();
function SetControllerStatus(bool On) {
bActive = On;                                                               
bVisible = On;                                                              
bRequiresTick = On;                                                         
}
event CloseAll(bool bCancel,optional bool bForced);
event bool CloseMenu(optional bool bCanceled) {
return True;                                                                
}
event bool ReplaceMenu(string NewMenuName,optional string Param1,optional string Param2,optional bool bCancelled) {
return False;                                                               
}
event AutoLoadMenus();
event bool OpenMenu(string NewMenuName,optional string Param1,optional string Param2) {
return False;                                                               
}
simulated event QuitGame();
simulated event SetTextData(int windowID,string textData);
simulated event CloseAllWindows();
simulated event CloseWindow(int windowID,optional bool bCanceled);
simulated event InternalFocusChanged(int windowID);
simulated event FocusWindow(int windowID);
simulated event EnableWindow(int windowID,bool newState);
simulated event SendWindowMessage(Object aSender,int windowID,optional int intParam,optional UObject objParam,optional string stringParam);
simulated event UpdateWindow(int windowID,optional int intParam,optional UObject objParam,optional string stringParam);
simulated event int OpenWindow(string windowName,optional int intParam,optional UObject objParam,optional string stringParam);
*/