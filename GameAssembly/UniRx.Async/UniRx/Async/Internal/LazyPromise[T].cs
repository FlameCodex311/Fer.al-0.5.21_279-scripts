﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise<T> : IAwaiter<T> // TypeDefIndex: 8864
	{
		// Fields
		private Func<UniTask<T>> factory;
		private UniTask<T> value;
	
		// Properties
		public bool IsCompleted { get; }
		public AwaiterStatus Status { get; }
	
		// Constructors
		public LazyPromise(Func<UniTask<T>> factory);
	
		// Methods
		private void Create();
		public T GetResult();
		void IAwaiter.GetResult();
		public void UnsafeOnCompleted(Action continuation);
		public void OnCompleted(Action continuation);
	}
}
