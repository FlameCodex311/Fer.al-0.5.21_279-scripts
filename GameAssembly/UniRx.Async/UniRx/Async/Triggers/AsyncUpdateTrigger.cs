﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8687
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> update; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> updates; // 0x38
	
		// Constructors
		public AsyncUpdateTrigger(); // 0x00000001816678F0-0x0000000181667950
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181667760-0x00000001816677D0
		private void Update(); // 0x0000000181667850-0x00000001816678F0
		public UniTask UpdateAsync(CancellationToken cancellationToken = default); // 0x00000001816677D0-0x0000000181667850
	}
}