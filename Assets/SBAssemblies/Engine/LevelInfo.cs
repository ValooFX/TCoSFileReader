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

namespace Engine
{
    
    
    [System.Serializable] public class LevelInfo : ZoneInfo
    {
        
        public float TimeDilation;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public float TimeSeconds;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Year;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Month;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Day;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int DayOfWeek;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Hour;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Minute;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Second;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int Millisecond;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        [ArraySizeForExtraction(Size=4)]
        public Actor[] SunLights = new Actor[0];
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public int NumSunLights;
        
        public float PauseDelay;
        
        [FieldConst()]
        public float RelativeTimeOfDay;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public EnvironmentManager EnvironmentManager;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public string Title = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public string Author = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public string Description = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material Screenshot;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public string DecoTextName = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public int IdealPlayerCountMin;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public int IdealPlayerCountMax;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public string ExtraInfo = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("SinglePlayer")]
        public int SinglePlayerTeamSize;
        
        [Sirenix.OdinInspector.FoldoutGroup("RadarMap")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Material RadarMapImage;
        
        [Sirenix.OdinInspector.FoldoutGroup("RadarMap")]
        public float CustomRadarRange;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [FieldConfig()]
        public byte PhysicsDetailLevel;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [FieldConfig()]
        public byte MeshLODDetailLevel;
        
        [Sirenix.OdinInspector.FoldoutGroup("Karma")]
        public float KarmaTimeScale;
        
        [Sirenix.OdinInspector.FoldoutGroup("Karma")]
        public float RagdollTimeScale;
        
        [Sirenix.OdinInspector.FoldoutGroup("Karma")]
        public int MaxRagdolls;
        
        [Sirenix.OdinInspector.FoldoutGroup("Karma")]
        public float KarmaGravScale;
        
        [Sirenix.OdinInspector.FoldoutGroup("Karma")]
        public bool bKStaticFriction;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public bool bKNoInit;
        
        [ArraySizeForExtraction(Size=2)]
        public int[] LastTaunt = new int[0];
        
        [FieldConfig()]
        public float DecalStayScale;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public string LevelEnterText = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public string LocalizedPkg = string.Empty;
        
        public LevelSummary Summary;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public string VisibleGroups = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelSummary")]
        public bool HideFromMenus;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public bool bLonePlayer;
        
        public bool bBegunPlay;
        
        public bool bPlayersOnly;
        
        public bool bFreezeKarma;
        
        [FieldConst()]
        public byte DetailMode;
        
        public bool bDropDetail;
        
        public bool bAggressiveLOD;
        
        public bool bStartup;
        
        [FieldConfig()]
        public bool bLowSoundDetail;
        
        public bool bPathsRebuilt;
        
        public bool bHasPathNodes;
        
        public bool bLevelChange;
        
        public bool bShouldPreload;
        
        public bool bDesireSkinPreload;
        
        public bool bKickLiveIdlers;
        
        public bool bSkinsPreloaded;
        
        public bool bClassicView;
        
        [Sirenix.OdinInspector.FoldoutGroup("RadarMap")]
        public bool bShowRadarMap;
        
        [Sirenix.OdinInspector.FoldoutGroup("RadarMap")]
        public bool bUseTerrainForRadarRange;
        
        public bool bIsSaveGame;
        
        [Sirenix.OdinInspector.FoldoutGroup("SaveGames")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public bool bSupportSaveGames;
        
        [FieldConfig()]
        public bool bNeverPrecache;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public int LevelTextureLODBias;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public float AnimMeshGlobalLOD;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Vector CameraLocationDynamic;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Vector CameraLocationTop;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Vector CameraLocationFront;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Vector CameraLocationSide;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Rotator CameraRotationDynamic;
        
        [Sirenix.OdinInspector.FoldoutGroup("Audio")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string Song = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("Audio")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public float PlayerDoppler;
        
        [Sirenix.OdinInspector.FoldoutGroup("Audio")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public float MusicVolumeOverride;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public float Brightness;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string DefaultTexture; //texture
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string WireframeTexture;//texture
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string WhiteSquareTexture;//texture
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string LargeVertex;
        
        public int HubStackLevel;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public byte LevelAction;
        
        public byte NetMode;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string ComputerName = string.Empty;
        
        public string EngineVersion = string.Empty;
        
        public string MinNetVersion = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public string DefaultGameType = string.Empty;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public string PreCacheGame = string.Empty;
        
        public float DefaultGravity;
        
        public float LastVehicleCheck;
        
        [Sirenix.OdinInspector.FoldoutGroup("LevelInfo")]
        public float StallZ;
        
        [FieldConst()]
        public NavigationPoint NavigationPointList;
        
        [FieldConst()]
        public Controller ControllerList;
        
        [Sirenix.OdinInspector.FoldoutGroup("Headlights")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public bool bUseHeadlights;
        
        [Sirenix.OdinInspector.FoldoutGroup("Headlights")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public float HeadlightScaling;
        
        public string NextURL = string.Empty;
        
        public bool bNextItems;
        
        public float NextSwitchCountdown;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public ObjectPool ObjectPool;
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public List<Material> PrecacheMaterials = new List<Material>();
        
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public List<StaticMesh> PrecacheStaticMeshes = new List<StaticMesh>();
        
        [Sirenix.OdinInspector.FoldoutGroup("Camouflage")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public StaticMesh IndoorCamouflageMesh;
        
        [Sirenix.OdinInspector.FoldoutGroup("Camouflage")]
        public float IndoorMeshDrawscale;
        
        [Sirenix.OdinInspector.FoldoutGroup("Camouflage")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public StaticMesh OutdoorCamouflageMesh;
        
        [Sirenix.OdinInspector.FoldoutGroup("Camouflage")]
        public float OutdoorMeshDrawscale;
        
        [Sirenix.OdinInspector.FoldoutGroup("DustColor")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Color DustColor;
        
        [Sirenix.OdinInspector.FoldoutGroup("DustColor")]
        [System.NonSerialized, UnityEngine.HideInInspector]
        public Color WaterDustColor;
        
        public float MoveRepSize;
        
        public float MaxClientFrameRate;
        
        public float MaxTimeMargin;
        
        public float TimeMarginSlack;
        
        public float MinTimeMargin;
        
        [FieldConst()]
        public PlayerController ReplicationViewer;
        
        [FieldConst()]
        public Actor ReplicationViewTarget;
        
        [FieldConst()]
        [System.NonSerialized, UnityEngine.HideInInspector]
        [FieldTransient()]
        public string LightingCubeMap; //SBLightingCubemap
        
        public LevelInfo()
        {
        }
        
        public enum ENetMode
        {
            
            NM_Standalone ,
            
            NM_DedicatedServer ,
            
            NM_ListenServer ,
            
            NM_Client,
        }
        
        public enum ELevelAction
        {
            
            LEVACT_None ,
            
            LEVACT_Loading ,
            
            LEVACT_Saving ,
            
            LEVACT_Connecting ,
            
            LEVACT_Precaching,
        }
        
        public enum EMeshLODDetailLevel
        {
            
            MDL_Low ,
            
            MDL_Medium ,
            
            MDL_High ,
            
            MDL_Ultra,
        }
        
        public enum EPhysicsDetailLevel
        {
            
            PDL_Low ,
            
            PDL_Medium ,
            
            PDL_High,
        }
    }
}
/*
native function EnvironmentManager GetEnvironmentManager();
function ObjectPool GetObjectPool() {
if (ObjectPool == None) {                                                   
ObjectPool = new (XLevel) Class'ObjectPool';                              
}
return ObjectPool;                                                          
}
native function PlayerController GetLocalPlayerController();
simulated event PreBeginPlay() {
Super.PreBeginPlay();                                                       
ObjectPool = new (XLevel) Class'ObjectPool';                                
}
function Reset() {
DefaultGravity = default.DefaultGravity;                                    
Super.Reset();                                                              
}
function ThisIsNeverExecuted() {
local DefaultPhysicsVolume P;
P = None;                                                                   
}
event ServerTravel(string URL,bool bItems) {
}
native simulated function string GetAddressURL();
final static native function bool IsSoftwareRendering();
final static native function bool IsDemoBuild();
native simulated function string GetLocalURL();
simulated function AddPrecacheStaticMesh(StaticMesh stat) {
local int Index;
if (NetMode == 1) {                                                         
return;                                                                   
}
if (stat == None) {                                                         
return;                                                                   
}
Log("Adding static mesh to precache array: "
$ string(stat));         
Index = Level.PrecacheStaticMeshes.Length;                                  
PrecacheStaticMeshes.Insert(Index,1);                                       
PrecacheStaticMeshes[Index] = stat;                                         
}
simulated function AddPrecacheMaterial(Material mat) {
local int Index;
if (NetMode == 1) {                                                         
return;                                                                   
}
if (mat == None) {                                                          
return;                                                                   
}
Index = Level.PrecacheMaterials.Length;                                     
PrecacheMaterials.Insert(Index,1);                                          
PrecacheMaterials[Index] = mat;                                             
}
simulated event FillPrecacheStaticMeshesArray(bool FullPrecache) {
local Actor A;
if (NetMode == 1) {                                                         
return;                                                                   
}
Log("Starting search for uncached static meshes");                          
foreach AllActors(Class'Actor',A) {                                         
if (!A.bAlreadyPrecachedMeshes || FullPrecache) {                         
A.UpdatePrecacheStaticMeshes();                                         
A.bAlreadyPrecachedMeshes = True;                                       
}
}
Log("Ending search");                                                       
}
simulated function PrecacheAnnouncements();
simulated event FillPrecacheMaterialsArray(bool FullPrecache) {
local Actor A;
if (NetMode == 1) {                                                         
return;                                                                   
}
if (!bSkinsPreloaded || FullPrecache) {                                     
}
foreach AllActors(Class'Actor',A) {                                         
if (!A.bAlreadyPrecachedMaterials || FullPrecache) {                      
A.UpdatePrecacheMaterials();                                            
A.bAlreadyPrecachedMaterials = True;                                    
}
}
}
simulated function PostBeginPlay() {
Super.PostBeginPlay();                                                      
DecalStayScale = Max(DecalStayScale,0);                                     
}
native simulated function PhysicsVolume GetPhysicsVolume(Vector loc);
native simulated function ForceLoadTexture(Texture Texture);
native simulated function UpdateDistanceFogLOD(float LOD);
native simulated function byte GetDetailMode();
native simulated function DetailChange(byte NewDetailMode);
*/
