﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Unitilities.Tuples
{
	[Serializable]
	public class Tuple4<T1, T2, T3, T4> // TypeDefIndex: 16096
	{
		// Fields
		public T1 first;
		public T2 second;
		public T3 third;
		public T4 fourth;
		private static readonly IEqualityComparer<T1> Item1Comparer;
		private static readonly IEqualityComparer<T2> Item2Comparer;
		private static readonly IEqualityComparer<T3> Item3Comparer;
		private static readonly IEqualityComparer<T4> Item4Comparer;
	
		// Constructors
		public Tuple4(Tuple<T1, T2> _tuple2, T3 _third, T4 _fourth);
		public Tuple4(Tuple3<T1, T2, T3> _tuple3, T4 _fourth);
		public Tuple4(T1 _first, T2 _second, T3 _third, T4 _fourth);
		static Tuple4();
	
		// Methods
		public override string ToString();
		public override int GetHashCode();
		public override bool Equals(object obj);
		private static bool IsNull(object obj);
		public static bool operator ==(Tuple4<T1, T2, T3, T4> a, Tuple4<T1, T2, T3, T4> b);
		public static bool operator !=(Tuple4<T1, T2, T3, T4> a, Tuple4<T1, T2, T3, T4> b);
	}
}
