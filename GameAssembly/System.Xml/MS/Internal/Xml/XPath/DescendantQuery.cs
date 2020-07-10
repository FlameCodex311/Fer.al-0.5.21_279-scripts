﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal class DescendantQuery : DescendantBaseQuery // TypeDefIndex: 1834
	{
		// Fields
		private XPathNodeIterator nodeIterator; // 0x60
	
		// Constructors
		internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis); // 0x0000000180C85B20-0x0000000180C85BF0
		public DescendantQuery(DescendantQuery other); // 0x0000000180C86290-0x0000000180C86300
	
		// Methods
		public override void Reset(); // 0x0000000180C86250-0x0000000180C86290
		public override XPathNavigator Advance(); // 0x0000000180C86020-0x0000000180C861B0
		public override XPathNodeIterator Clone(); // 0x0000000180C861B0-0x0000000180C86250
	}
}