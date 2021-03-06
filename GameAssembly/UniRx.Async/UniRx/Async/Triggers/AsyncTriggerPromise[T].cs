﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.Internal;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	public class AsyncTriggerPromise<T> : ReusablePromise<T>, IPromise<T>, ICancelablePromise // TypeDefIndex: 8840
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CancellationToken <RegisteredCancellationToken>k__BackingField;
	
		// Properties
		public CancellationToken RegisteredCancellationToken { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
	
		// Constructors
		public AsyncTriggerPromise();
		public AsyncTriggerPromise(CancellationToken cancellationToken);
	
		// Methods
		public override T GetResult();
		public override bool TrySetResult(T result);
		public override bool TrySetCanceled();
	}
}
