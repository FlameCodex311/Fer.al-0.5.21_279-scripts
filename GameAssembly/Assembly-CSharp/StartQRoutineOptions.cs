﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public struct StartQRoutineOptions // TypeDefIndex: 11238
{
	// Fields
	public string name; // 0x00
	public QRoutineAddPriority addPriority; // 0x08
	public IEnumerator routine; // 0x10
	public Action<QRoutine> action; // 0x18
	public Action<QRoutine> finishedAction; // 0x20
	public Action<QRoutine> canceledAction; // 0x28
}

