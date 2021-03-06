﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_AstralShop : UI_LazyListItem<BaseDef> // TypeDefIndex: 13680
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _costText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rarityBadge; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x90
	[Header] // 0x00000001801D1670-0x00000001801D16C0
	[SerializeField] // 0x00000001801D1670-0x00000001801D16C0
	private WWImage _backgroundImage; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _backgroundSpriteRegular; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _backgroundSpriteSeasonPass; // 0xA8
	private BundlePackDefComponent _bundlePack; // 0xB0
	private PurchaseableDefComponent _purchaseable; // 0xB8

	// Constructors
	public UI_LazyListItem_AstralShop(); // 0x00000001803A1CE0-0x00000001803A1D20

	// Methods
	public override void Setup(Action<UI_LazyListItem<BaseDef>> inOnClicked, Action<UI_LazyListItem<BaseDef>> inOnSelected, BaseDef inData, UI_LazyItemList<BaseDef> inItemList); // 0x00000001803A1900-0x00000001803A1CE0
	protected override void OnClicked(); // 0x00000001803A18B0-0x00000001803A1900
}

