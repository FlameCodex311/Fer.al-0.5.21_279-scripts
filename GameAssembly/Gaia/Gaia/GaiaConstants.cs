﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public static class GaiaConstants // TypeDefIndex: 9174
	{
		// Fields
		public static readonly string AssetDir; // 0x00
		public static readonly string AssetDirFromAssetDB; // 0x08
		public static float VirginTerrainCheckThreshold; // 0x10
		public const TextureFormat defaultTextureFormat = TextureFormat.RGBA32; // Metadata: 0x00778CAC
		public const TextureFormat fmtHmTextureFormat = TextureFormat.RGBA32; // Metadata: 0x00778CB0
		public const TextureFormat fmtRGBA32 = TextureFormat.RGBA32; // Metadata: 0x00778CB4
		public const StorageFormat defaultImageStorageFormat = StorageFormat.PNG; // Metadata: 0x00778CB8
		public const ImageChannel defaultImageStorageChannel = ImageChannel.R; // Metadata: 0x00778CBC
	
		// Nested types
		public enum RawByteOrder // TypeDefIndex: 9175
		{
			IBM = 0,
			Macintosh = 1
		}
	
		public enum RawBitDepth // TypeDefIndex: 9176
		{
			Sixteen = 0,
			Eight = 1
		}
	
		public enum EnvironmentTarget // TypeDefIndex: 9177
		{
			UltraLight = 0,
			MobileAndVR = 1,
			Desktop = 2,
			PowerfulDesktop = 3,
			Custom = 4
		}
	
		public enum EnvironmentRenderer // TypeDefIndex: 9178
		{
			BuiltIn = 0,
			LightWeight2018x = 1,
			HighDefinition2018x = 2
		}
	
		public enum EnvironmentSize // TypeDefIndex: 9179
		{
			FromDefaults = 0,
			Is256MetersSq = 1,
			Is512MetersSq = 2,
			Is1024MetersSq = 3,
			Is2048MetersSq = 4,
			Is4096MetersSq = 5,
			Is8192MetersSq = 6,
			Is16384MetersSq = 7
		}
	
		public enum EnvironmentControllerType // TypeDefIndex: 9180
		{
			FirstPerson = 0,
			FlyingCamera = 1,
			ThirdPerson = 2
		}
	
		public enum ManagerEditorMode // TypeDefIndex: 9181
		{
			Standard = 0,
			Advanced = 1,
			Extensions = 2,
			ShowMore = 3
		}
	
		public enum ManagerEditorNewsMode // TypeDefIndex: 9182
		{
			MoreOnGaia = 0,
			MoreOnProceduralWorlds = 1
		}
	
		public enum OperationMode // TypeDefIndex: 9183
		{
			DesignTime = 0,
			RuntimeInterval = 1,
			RuntimeTriggeredInterval = 2
		}
	
		public enum TerrainOperationType // TypeDefIndex: 9184
		{
			AddToTerrain = 0,
			ApplyMaskToSplatmap = 1,
			ContrastFilter = 2,
			GrowFeaturesFilter = 3,
			DeNoiseFilter = 4,
			HydraulicFilter = 5,
			MultiplyTerrain = 6,
			PowerOfFilter = 7,
			QuantizeFilter = 8,
			QuantizeCurvesFilter = 9,
			SetTerrainToHeight = 10,
			ShrinkFeaturesFilter = 11,
			SubtractFromTerrain = 12,
			ThermalFilter = 13,
			ExportAspectMap = 14,
			ExportBaseMap = 15,
			ExportCurvatureMap = 16,
			ExportFlowMap = 17,
			ExportHeightMap = 18,
			ExportNoiseMap = 19,
			ExportNormalMap = 20,
			ExportMasks = 21,
			ExportSlopeMap = 22
		}
	
		public enum MaskMergeType // TypeDefIndex: 9185
		{
			AssignMask2IfGreaterThan = 0,
			AssignMask2IfLessThan = 1,
			AddMask2 = 2,
			MultiplyByMask2 = 3,
			SubtractMask2 = 4
		}
	
		public enum ErosionRainType // TypeDefIndex: 9186
		{
			Constant = 0,
			ErodePeaks = 1,
			ErodeValleys = 2,
			ErodeSlopes = 3
		}
	
		public enum CurvatureType // TypeDefIndex: 9187
		{
			Average = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum AspectType // TypeDefIndex: 9188
		{
			Aspect = 0,
			Northerness = 1,
			Easterness = 2
		}
	
		public enum NoiseType // TypeDefIndex: 9189
		{
			None = 0,
			Perlin = 1,
			Billow = 2,
			Ridged = 3
		}
	
		public enum ImageFitnessFilterMode // TypeDefIndex: 9190
		{
			None = 0,
			ImageGreyScale = 1,
			ImageRedChannel = 2,
			ImageGreenChannel = 3,
			ImageBlueChannel = 4,
			ImageAlphaChannel = 5,
			TerrainTexture0 = 6,
			TerrainTexture1 = 7,
			TerrainTexture2 = 8,
			TerrainTexture3 = 9,
			TerrainTexture4 = 10,
			TerrainTexture5 = 11,
			TerrainTexture6 = 12,
			TerrainTexture7 = 13,
			PerlinNoise = 14,
			BillowNoise = 15,
			RidgedNoise = 16
		}
	
		public enum FeatureType // TypeDefIndex: 9191
		{
			Adhoc = 0,
			Bases = 1,
			Hills = 2,
			Islands = 3,
			Lakes = 4,
			Mesas = 5,
			Mountains = 6,
			Plains = 7,
			Rivers = 8,
			Rocks = 9,
			Valleys = 10,
			Villages = 11,
			Waterfalls = 12
		}
	
		public enum GeneratorBorderStyle // TypeDefIndex: 9192
		{
			None = 0,
			Mountains = 1,
			Water = 2
		}
	
		public enum FeatureOperation // TypeDefIndex: 9193
		{
			RaiseHeight = 0,
			LowerHeight = 1,
			BlendHeight = 2,
			StencilHeight = 3,
			DifferenceHeight = 4
		}
	
		public enum SpawnerShape // TypeDefIndex: 9194
		{
			Box = 0,
			Sphere = 1
		}
	
		public enum SpawnerLocation // TypeDefIndex: 9195
		{
			RandomLocation = 0,
			RandomLocationClustered = 1,
			EveryLocation = 2,
			EveryLocationJittered = 3
		}
	
		public enum SpawnerLocationCheckType // TypeDefIndex: 9196
		{
			PointCheck = 0,
			BoundedAreaCheck = 1
		}
	
		public enum SpawnerRuleSelector // TypeDefIndex: 9197
		{
			All = 0,
			Fittest = 1,
			WeightedFittest = 2,
			Random = 3
		}
	
		public enum SpawnerResourceType // TypeDefIndex: 9198
		{
			TerrainTexture = 0,
			TerrainDetail = 1,
			TerrainTree = 2,
			GameObject = 3
		}
	
		public enum ImageFileType // TypeDefIndex: 9199
		{
			Jpg = 0,
			Png = 1,
			Exr = 2
		}
	
		public enum StorageFormat // TypeDefIndex: 9200
		{
			PNG = 0,
			JPG = 1
		}
	
		public enum ImageChannel // TypeDefIndex: 9201
		{
			R = 0,
			G = 1,
			B = 2,
			A = 3
		}
	
		// Constructors
		static GaiaConstants(); // 0x0000000180E3BA90-0x0000000180E3BB00
	}
}
