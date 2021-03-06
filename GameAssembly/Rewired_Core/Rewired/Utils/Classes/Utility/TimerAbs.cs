﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class TimerAbs // TypeDefIndex: 7059
	{
		// Fields
		public bool running; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float IdzspxFpGVvCiRgzwzAhTPlwaHA; // 0x14
		public float length; // 0x18
	
		// Constructors
		public TimerAbs(); // 0x0000000180373240-0x0000000180373250
		public TimerAbs(float inLength); // 0x0000000180421FD0-0x0000000180422000
	
		// Methods
		public void Start(); // 0x00000001813FEFF0-0x00000001813FF070
		public void Start(float inLength); // 0x00000001813FF070-0x00000001813FF0F0
		public bool Update(); // 0x00000001813FF0F0-0x00000001813FF170
		public void Clear(); // 0x0000000180924290-0x00000001809242A0
		public void SetLength(float inLength); // 0x0000000180956BE0-0x0000000180956BF0
		public TimerAbs Clone(); // 0x00000001813FEF60-0x00000001813FEFF0
	}
}
