﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using TCosReborn.Framework.Common;


namespace SBGame
{


    public class Game_ItemContainerListener : SBPackageResource
    {
        
        public byte mLocationType;
        
        public int mLocationSlot;
        
        public int mLocationID;
        
        //public delegate<OnUpdateContainer> @__OnUpdateContainer__Delegate;
        
        //public delegate<OnSetContainerLock> @__OnSetContainerLock__Delegate;
        
        //public delegate<OnUsedItem> @__OnUsedItem__Delegate;
        
        public Game_ItemContainerListener()
        {
        }
    }
}
/*
event SetItemLocation(byte aLocationType,int aLocationSlot,optional int aLocationID) {
mLocationType = aLocationType;                                              
mLocationSlot = aLocationSlot;                                              
mLocationID = aLocationID;                                                  
}
delegate OnUsedItem();
delegate OnSetContainerLock(bool aLock);
delegate OnUpdateContainer(Game_Item aItem);
*/