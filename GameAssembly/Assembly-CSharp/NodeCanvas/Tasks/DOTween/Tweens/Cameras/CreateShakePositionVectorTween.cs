﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category] // 0x00000001801EF750-0x00000001801EF810
	[Description] // 0x00000001801EF750-0x00000001801EF810
	[Icon] // 0x00000001801EF750-0x00000001801EF810
	[Name] // 0x00000001801EF750-0x00000001801EF810
	public class CreateShakePositionVectorTween : ActionTask<Camera> // TypeDefIndex: 15642
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Vector3> Strength; // 0x70
		public BBParameter<int> vibrato; // 0x78
		public BBParameter<float> randomness; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FD010-0x00000001807FD1C0 
	
		// Constructors
		public CreateShakePositionVectorTween(); // 0x00000001807FCFD0-0x00000001807FD010
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FCE60-0x00000001807FCFD0
	}
}
