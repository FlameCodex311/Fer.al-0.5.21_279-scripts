﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_DemoWelcome : UI_Window // TypeDefIndex: 14039
{
	// Fields
	private static bool _firstLoad; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14040
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_DemoWelcome> <>9__3_0; // 0x08
		public static Action<UI_Window> <>9__4_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F710-0x000000018047F770
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__3_0(UI_Window_DemoWelcome window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__4_0(UI_Window inWindow); // 0x000000018047E5B0-0x000000018047E630
	}

	// Constructors
	public UI_Window_DemoWelcome(); // 0x00000001803B50E0-0x00000001803B50F0
	static UI_Window_DemoWelcome(); // 0x00000001804898D0-0x0000000180489910

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void StaticInit(); // 0x00000001803774A0-0x00000001803774B0
	private static void OnLevelLoaded(Message inMessage); // 0x0000000180489600-0x00000001804896D0
	public static void OpenWindow(); // 0x00000001804896D0-0x00000001804897D0
	public static void QueueWindow(); // 0x00000001804897D0-0x00000001804898D0
	public static void CloseWindow(); // 0x00000001804895B0-0x0000000180489600
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

