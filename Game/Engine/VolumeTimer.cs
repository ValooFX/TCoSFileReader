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


    public class VolumeTimer : Info
    {
        
        public Actor A;
        
        public float TimerFrequency;
        
        public VolumeTimer()
        {
        }
    }
}
/*
function Timer() {
A.TimerPop(self);                                                           
SetTimer(TimerFrequency,False);                                             
}
function PostBeginPlay() {
Super.PostBeginPlay();                                                      
SetTimer(1.00000000,False);                                                 
A = Owner;                                                                  
}
*/