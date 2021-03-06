﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018027C1B0-0x000000018027C210
	[Description] // 0x000000018027C1B0-0x000000018027C210
	public class GiveCraftableItem : ActionTask // TypeDefIndex: 15465
	{
		// Fields
		public BBParameter<string> craftableItemDefId; // 0x68
		public BBParameter<int> amount; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB1070-0x0000000180BB1280 
	
		// Constructors
		public GiveCraftableItem(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB0FE0-0x0000000180BB1070
	}
}
