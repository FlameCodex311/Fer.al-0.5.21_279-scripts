﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AttachToPlayer : ManagedBehaviour // TypeDefIndex: 11541
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <AttachToPlayerCoroutine>d__1 : IEnumerator<object> // TypeDefIndex: 11542
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AttachToPlayer <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <AttachToPlayerCoroutine>d__1(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018215DBD0-0x000000018215DD50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018215DD50-0x000000018215E780
	}

	// Constructors
	public AttachToPlayer(); // 0x0000000182156E70-0x0000000182156ED0

	// Methods
	public override void MOnEnable(); // 0x0000000182156E00-0x0000000182156E70
	[IteratorStateMachine] // 0x0000000180218B20-0x0000000180218B70
	private IEnumerator AttachToPlayerCoroutine(); // 0x0000000182156DA0-0x0000000182156E00
}

