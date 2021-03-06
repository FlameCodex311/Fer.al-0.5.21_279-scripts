﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	public class DOTweenSettings : ScriptableObject // TypeDefIndex: 5831
	{
		// Fields
		public const string AssetName = "DOTweenSettings"; // Metadata: 0x007634DD
		public const string AssetFullFilename = "DOTweenSettings.asset"; // Metadata: 0x007634F0
		public bool useSafeMode; // 0x18
		public SafeModeOptions safeModeOptions; // 0x20
		public float timeScale; // 0x28
		public bool useSmoothDeltaTime; // 0x2C
		public float maxSmoothUnscaledTime; // 0x30
		public RewindCallbackMode rewindCallbackMode; // 0x34
		public bool showUnityEditorReport; // 0x38
		public LogBehaviour logBehaviour; // 0x3C
		public bool drawGizmos; // 0x40
		public bool defaultRecyclable; // 0x41
		public AutoPlay defaultAutoPlay; // 0x44
		public UpdateType defaultUpdateType; // 0x48
		public bool defaultTimeScaleIndependent; // 0x4C
		public Ease defaultEaseType; // 0x50
		public float defaultEaseOvershootOrAmplitude; // 0x54
		public float defaultEasePeriod; // 0x58
		public bool defaultAutoKill; // 0x5C
		public LoopType defaultLoopType; // 0x60
		public bool showPreviewPanel; // 0x64
		public SettingsLocation storeSettingsLocation; // 0x68
		public ModulesSetup modules; // 0x70
		public bool showPlayingTweens; // 0x78
		public bool showPausedTweens; // 0x79
	
		// Nested types
		public enum SettingsLocation // TypeDefIndex: 5832
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}
	
		[Serializable]
		public class SafeModeOptions // TypeDefIndex: 5833
		{
			// Fields
			public NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x10
	
			// Constructors
			public SafeModeOptions(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		public class ModulesSetup // TypeDefIndex: 5834
		{
			// Fields
			public bool showPanel; // 0x10
			public bool audioEnabled; // 0x11
			public bool physicsEnabled; // 0x12
			public bool physics2DEnabled; // 0x13
			public bool spriteEnabled; // 0x14
			public bool uiEnabled; // 0x15
			public bool textMeshProEnabled; // 0x16
			public bool tk2DEnabled; // 0x17
	
			// Constructors
			public ModulesSetup(); // 0x0000000181791820-0x0000000181791920
		}
	
		// Constructors
		public DOTweenSettings(); // 0x00000001817878E0-0x00000001817879A0
	}
}
