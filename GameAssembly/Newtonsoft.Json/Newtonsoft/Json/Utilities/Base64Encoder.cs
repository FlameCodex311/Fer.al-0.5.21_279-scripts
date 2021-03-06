﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class Base64Encoder // TypeDefIndex: 7993
	{
		// Fields
		private readonly char[] _charsLine; // 0x10
		private readonly TextWriter _writer; // 0x18
		private byte[] _leftOverBytes; // 0x20
		private int _leftOverBytesCount; // 0x28
	
		// Constructors
		public Base64Encoder(TextWriter writer); // 0x0000000180C179D0-0x0000000180C17A40
	
		// Methods
		public void Encode(byte[] buffer, int index, int count); // 0x0000000180C17540-0x0000000180C178D0
		public void Flush(); // 0x0000000180C178D0-0x0000000180C179A0
		private void WriteChars(char[] chars, int index, int count); // 0x0000000180C179A0-0x0000000180C179D0
	}
}
