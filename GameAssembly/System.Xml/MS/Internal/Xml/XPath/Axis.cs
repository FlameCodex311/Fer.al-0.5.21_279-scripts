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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal class Axis : AstNode // TypeDefIndex: 1925
	{
		// Fields
		private AxisType axisType; // 0x10
		private AstNode input; // 0x18
		private string prefix; // 0x20
		private string name; // 0x28
		private XPathNodeType nodeType; // 0x30
		protected bool abbrAxis; // 0x34
		private string urn; // 0x38
	
		// Properties
		public override AstType Type { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override XPathResultType ReturnType { get; } // 0x000000018043E010-0x000000018043E020 
		public AstNode Input { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string Prefix { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public string Name { get; } // 0x00000001803745B0-0x00000001803745C0 
		public XPathNodeType NodeType { get; } // 0x00000001804AA650-0x00000001804AA660 
		public AxisType TypeOfAxis { get; } // 0x0000000180387590-0x0000000180387930 
		public bool AbbrAxis { get; } // 0x0000000180406600-0x0000000180406610 
		public string Urn { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	
		// Nested types
		public enum AxisType // TypeDefIndex: 1926
		{
			Ancestor = 0,
			AncestorOrSelf = 1,
			Attribute = 2,
			Child = 3,
			Descendant = 4,
			DescendantOrSelf = 5,
			Following = 6,
			FollowingSibling = 7,
			Namespace = 8,
			Parent = 9,
			Preceding = 10,
			PrecedingSibling = 11,
			Self = 12,
			None = 13
		}
	
		// Constructors
		public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype); // 0x00000001819BB240-0x00000001819BB2D0
		public Axis(AxisType axisType, AstNode input); // 0x00000001819BB2D0-0x00000001819BB390
	}
}
