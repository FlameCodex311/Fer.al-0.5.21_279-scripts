﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	public abstract class AtomAction<T1, T2, T3, T4, T5> : AtomAction // TypeDefIndex: 7749
	{
		// Fields
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Action<T1, T2, T3, T4, T5> Action;
	
		// Constructors
		protected AtomAction();
	
		// Methods
		public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
	}
}
