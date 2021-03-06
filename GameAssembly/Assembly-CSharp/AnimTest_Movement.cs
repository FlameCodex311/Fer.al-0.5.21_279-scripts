﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AnimTest_Movement : MonoBehaviour // TypeDefIndex: 10436
{
	// Fields
	private Animator animator; // 0x20
	public float walkSpeed; // 0x28
	public float runSpeed; // 0x2C
	public float turnSpeed; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject harvestPoint; // 0x38
	private GameObject harvestPointInstance; // 0x40
	private Animator harvestPointAnimator; // 0x48
	private CharacterController harvestPointCharacterController; // 0x50
	private Vector3 moveDirection; // 0x58
	private CharacterController controller; // 0x68
	private float gravity; // 0x70
	private float moveX; // 0x74
	private float moveZ; // 0x78

	// Constructors
	public AnimTest_Movement(); // 0x0000000182155020-0x00000001821550B0

	// Methods
	private void Start(); // 0x00000001821547A0-0x00000001821549B0
	private void Update(); // 0x00000001821549B0-0x0000000182155020
}

