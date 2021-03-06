﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class WebResponses // TypeDefIndex: 12659
{
	// Nested types
	[Serializable]
	public class Login // TypeDefIndex: 12660
	{
		// Fields
		public int id; // 0x10
		public string screen_name; // 0x18
		public string language; // 0x20
		public int game_account_type; // 0x28
		public string web_auth_token; // 0x30
		public string game_auth_token; // 0x38
		public GameServerData game_server; // 0x40
		public int expiry_in_days; // 0x48
		public bool immortal; // 0x4C
		public UserData user; // 0x50
		public string uuid; // 0x58
		public bool rename_required; // 0x60
		public string token; // 0x68

		// Nested types
		[Serializable]
		public class GameServerData // TypeDefIndex: 12661
		{
			// Fields
			public string blueboxServer; // 0x10
			public string smartfoxServer; // 0x18

			// Constructors
			public GameServerData(); // 0x0000000180373240-0x0000000180373250
		}

		[Serializable]
		public class UserData // TypeDefIndex: 12662
		{
			// Fields
			public int id; // 0x10
			public string email; // 0x18

			// Constructors
			public UserData(); // 0x0000000180373240-0x0000000180373250
		}

		// Constructors
		public Login(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class AvailableGameServers // TypeDefIndex: 12663
	{
		// Fields
		public string blueboxServer; // 0x10
		public string smartfoxServer; // 0x18
		public LoginStatus status; // 0x20

		// Constructors
		public AvailableGameServers(); // 0x0000000180373240-0x0000000180373250
	}
}

