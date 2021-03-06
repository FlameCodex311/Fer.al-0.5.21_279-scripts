﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins.Core
{
	public interface IPlugSetter<T1, out T2, TPlugin, out TPlugOptions> // TypeDefIndex: 5809
	{
		// Methods
		DOGetter<T1> Getter();
		DOSetter<T1> Setter();
		T2 EndValue();
		TPlugOptions GetOptions();
	}
}
