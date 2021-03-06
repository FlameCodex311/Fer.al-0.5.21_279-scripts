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

namespace NodeCanvas.Tasks.DOTween.Tweens.Audio
{
	[Category] // 0x00000001801F0A20-0x00000001801F0AE0
	[Description] // 0x00000001801F0A20-0x00000001801F0AE0
	[Icon] // 0x00000001801F0A20-0x00000001801F0AE0
	[Name] // 0x00000001801F0A20-0x00000001801F0AE0
	public class CreateFadeTween : ActionTask<AudioSource> // TypeDefIndex: 15645
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Fade; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F9190-0x00000001807F9230 
	
		// Constructors
		public CreateFadeTween(); // 0x00000001807F9110-0x00000001807F9150
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F8F30-0x00000001807F9010
	}
}
