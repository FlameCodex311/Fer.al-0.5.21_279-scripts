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
	public class WaterFlowMap // TypeDefIndex: 9265
	{
		// Fields
		public float m_dropletVolume; // 0x10
		public float m_dropletAbsorbtionRate; // 0x14
		public int m_waterflowSmoothIterations; // 0x18
		private UnityHeightMap m_heightMap; // 0x20
		private HeightMap m_waterFlowMap; // 0x28
	
		// Constructors
		public WaterFlowMap(); // 0x0000000181703DE0-0x0000000181703E00
	
		// Methods
		public void CreateWaterFlowMap(Terrain terrain); // 0x0000000181703A30-0x0000000181703B70
		private void TraceWaterFlow(int startX, int startZ, int width, int height); // 0x0000000181703BB0-0x0000000181703DE0
		public void ExportWaterMapToPath(string path); // 0x0000000181703B70-0x0000000181703BB0
	}
}
