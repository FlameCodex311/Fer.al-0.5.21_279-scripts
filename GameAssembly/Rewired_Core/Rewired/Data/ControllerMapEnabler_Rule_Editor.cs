﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x000000018020E0F0-0x000000018020E130
	[Preserve] // 0x000000018020E0F0-0x000000018020E130
	public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable // TypeDefIndex: 6654
	{
		// Fields
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _tag; // 0x10
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private bool _enable; // 0x18
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<int> _categoryIds; // 0x20
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<int> _layoutIds; // 0x28
		[Serialize] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x30
	
		// Properties
		public string tag { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public bool enable { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public List<int> categoryIds { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public List<int> layoutIds { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public ControllerSetSelector_Editor controllerSetSelector { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
		// Constructors
		public ControllerMapEnabler_Rule_Editor(); // 0x0000000180D7F620-0x0000000180D7F6D0
		public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor source); // 0x0000000180D7F6D0-0x0000000180D7F7C0
	
		// Methods
		internal ControllerMapEnabler.Rule ToRuntime(); // 0x0000000180D7F520-0x0000000180D7F620
		object IDeepCloneable.DeepClone(); // 0x0000000180D7F410-0x0000000180D7F520
	}
}
