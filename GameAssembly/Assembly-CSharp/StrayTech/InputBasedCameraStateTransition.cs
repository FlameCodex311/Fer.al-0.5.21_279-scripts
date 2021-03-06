﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class InputBasedCameraStateTransition : MonoBehaviour // TypeDefIndex: 14578
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CameraStateDefinition[] _cameraStateDefinitionArray; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private KeyCode _transitionKey; // 0x28
		private int _currentStateIndex; // 0x2C
		private bool _pressedLastFrame; // 0x30
	
		// Constructors
		public InputBasedCameraStateTransition(); // 0x0000000180CB5680-0x0000000180CB5690
	
		// Methods
		private void Update(); // 0x0000000180CB5540-0x0000000180CB5680
	}
}
