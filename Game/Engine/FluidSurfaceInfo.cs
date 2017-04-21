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
using TCosReborn.Framework.Common;


namespace Engine
{
    
    
    public class FluidSurfaceInfo : Info
    {
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public byte FluidGridType;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidGridSpacing;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public int FluidXSize;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public int FluidYSize;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidHeightScale;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidTimeScale;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidDamping;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float FluidNoiseFrequency;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public Range FluidNoiseStrength;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public bool TestRipple;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float TestRippleSpeed;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float TestRippleStrength;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float TestRippleRadius;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float UTiles;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float UOffset;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float VTiles;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float VOffset;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float AlphaCurveScale;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float AlphaHeightScale;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public byte AlphaMax;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float ShootStrength;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float ShootRadius;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float RippleVelocityFactor;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float TouchStrength;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Actor")]
        public System.Type ShootEffect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public bool OrientShootEffect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        [TCosReborn.Framework.Attributes.TypeProxyDefinition(TypeName="Actor")]
        public System.Type TouchEffect;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public bool OrientTouchEffect;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        public List<int> ClampBitmap = new List<int>();
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public TerrainInfo ClampTerrain;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public bool bShowBoundingBox;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public bool bUseNoRenderZ;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float NoRenderZ;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float WarmUpTime;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        public float UpdateRate;
        
        [TCosReborn.Framework.Attributes.FieldCategoryAttribute(Category="FluidSurfaceInfo")]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        public Color FluidColor;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public List<float> Verts0 = new List<float>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public List<float> Verts1 = new List<float>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public List<byte> VertAlpha = new List<byte>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public int LatestVerts;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Box FluidBoundingBox;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public Vector FluidOrigin;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float TimeRollover;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public float TestRippleAng;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public FluidSurfacePrimitive Primitive;
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public List<FluidSurfaceOscillator> Oscillators = new List<FluidSurfaceOscillator>();
        
        [TCosReborn.Framework.Attributes.FieldConstAttribute()]
        [TCosReborn.Framework.Attributes.IgnoreFieldExtractionAttribute()]
        [TCosReborn.Framework.Attributes.FieldTransientAttribute()]
        public bool bHasWarmedUp;
        
        public FluidSurfaceInfo()
        {
        }
        
        public enum EFluidGridType
        {
            
            FGT_Square ,
            
            FGT_Hexagonal,
        }
    }
}
/*
simulated function Touch(Actor Other) {
local Vector touchLocation;
Super.Touch(Other);                                                         
if (Other == None || !Other.bDisturbFluidSurface) {                         
return;                                                                   
}
touchLocation = Other.Location;                                             
Pling(touchLocation,ShootStrength * Other.FluidSurfaceShootStrengthMod,Other.CollisionRadius);
touchLocation.Z = Location.Z;                                               
if (TouchEffect != None
&& EffectIsRelevant(touchLocation,False)) {   
if (OrientTouchEffect) {                                                  
Spawn(TouchEffect,self,,touchLocation,rotator(Other.Velocity));         
} else {                                                                  
Spawn(TouchEffect,self,,touchLocation);                                 
}
}
}
simulated function TakeDamage(int Damage,Pawn instigatedBy,Vector HitLocation,Vector Momentum,class<DamageType> DamageType) {
if (DamageType.default.FluidSurfaceShootStrengthMod ~= 0) {                 
return;                                                                   
}
Pling(HitLocation,ShootStrength * DamageType.default.FluidSurfaceShootStrengthMod,ShootRadius);
if (ShootEffect != None
&& EffectIsRelevant(HitLocation,False)) {     
if (OrientShootEffect) {                                                  
Spawn(ShootEffect,self,,HitLocation,rotator(Momentum));                 
} else {                                                                  
Spawn(ShootEffect,self,,HitLocation);                                   
}
}
}
final native function Pling(Vector Position,float Strength,optional float Radius);
*/
