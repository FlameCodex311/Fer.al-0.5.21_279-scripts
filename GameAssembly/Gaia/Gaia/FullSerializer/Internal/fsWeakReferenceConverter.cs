﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsWeakReferenceConverter : fsConverter // TypeDefIndex: 9152
	{
		// Constructors
		public fsWeakReferenceConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181905550-0x00000001819055C0
		public override bool RequestCycleSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override bool RequestInheritanceSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181905AB0-0x0000000181905E50
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181905610-0x0000000181905AB0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001819055C0-0x0000000181905610
	}
}