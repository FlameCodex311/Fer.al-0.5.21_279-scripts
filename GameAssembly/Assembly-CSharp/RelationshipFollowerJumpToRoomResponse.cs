﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x0000000180246240-0x0000000180246260
public class RelationshipFollowerJumpToRoomResponse : ServerMessage // TypeDefIndex: 12882
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <success>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <roomIssId>k__BackingField; // 0x34
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <otherNode>k__BackingField; // 0x38

	// Properties
	public bool success { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180455C10-0x0000000180455C20
	public int roomIssId { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804EF8F0-0x00000001804EF900 0x000000018041B180-0x000000018041B190
	public string otherNode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70

	// Constructors
	public RelationshipFollowerJumpToRoomResponse(INetMessageReader data); // 0x0000000180656F00-0x0000000180657070
}

