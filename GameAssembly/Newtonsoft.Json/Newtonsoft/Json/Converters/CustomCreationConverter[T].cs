﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 8180
	{
		// Properties
		public override bool CanWrite { get; }
	
		// Constructors
		protected CustomCreationConverter();
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);
		public abstract T Create(Type objectType);
		public override bool CanConvert(Type objectType);
	}
}
