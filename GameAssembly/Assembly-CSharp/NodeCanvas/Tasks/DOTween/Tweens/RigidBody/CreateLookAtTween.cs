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

namespace NodeCanvas.Tasks.DOTween.Tweens.RigidBody
{
	[Category] // 0x00000001801DB200-0x00000001801DB2C0
	[Description] // 0x00000001801DB200-0x00000001801DB2C0
	[Icon] // 0x00000001801DB200-0x00000001801DB2C0
	[Name] // 0x00000001801DB200-0x00000001801DB2C0
	public class CreateLookAtTween : ActionTask<Rigidbody> // TypeDefIndex: 15611
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> LookAt; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public AxisConstraint AxisConstraint; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F9DF0-0x00000001807F9EC0 
	
		// Constructors
		public CreateLookAtTween(); // 0x00000001807F9D70-0x00000001807F9DB0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F9B50-0x00000001807F9C60
	}
}
