
using SdlDotNet;
using SdlDotNet.Core;
using SdlDotNet.Input;
using System;
using System.Collections.Generic;

namespace engine {
	namespace input {

		public class keyMap {
			public Key showMenu = Key.Return;
			public Key hideMenu = Key.Return;

			public Key up = Key.W;
			public Key down = Key.S;
			public Key left = Key.A;
			public Key right = Key.D;

			public Key action = Key.K;
			public Key sword = Key.J;
			public Key item1 = Key.I;
			public Key item2 = Key.U;

		}
		public class keyMapDownState {
			#region constructors
			public keyMapDownState() {
				Reset();
			}
			public keyMapDownState(keyMapDownState dnState) {
				Reset(dnState);
			}
			#endregion

			#region Reset(....)
			public void Reset() {
				showMenu =
				hideMenu =

				up =
				down =
				left =
				right =

				action =
				sword =
				item1 =
				item2 = false;
			}
			public void Reset(keyMapDownState dnState) {
				showMenu = dnState.showMenu;
				hideMenu = dnState.hideMenu;

				up = dnState.up;
				down = dnState.down;
				left = dnState.left;
				right = dnState.right;

				action = dnState.action;
				sword = dnState.sword;
				item1 = dnState.item1;
				item2 = dnState.item2;
			}
			#endregion

			#region fields
			public bool showMenu;
			public bool hideMenu;

			public bool up;
			public bool down;
			public bool left;
			public bool right;

			public bool action;
			public bool sword;
			public bool item1;
			public bool item2;
			#endregion
		}
	
		public static class joysticHandler {

		}
		public static class keyboardHandler {
			#region vars
			private static keyMap m_map;
			private static keyMapDownState m_keyDownState;
			#endregion

			#region properties
			public static keyMap activeMap {
				get { return m_map; }
				set { m_map = value; }
			}
			#endregion

			#region Init(....)
			public static void Init() { Init(new keyMap()); }
			public static void Init(bool autoConnect) { Init(new keyMap(), autoConnect); }
			public static void Init(keyMap map, bool autoConnect = true) {

				try {
					Events.KeyboardDown -= (KeyDownEvtHandler);
					Events.KeyboardUp -= (KeyUpEvtHandler);
				} catch {}

				m_keyDownState = app.keyDownState;
				m_map = map;
				
				if (autoConnect) Connect();
			}
			#endregion

			public static void Connect() {
				Events.KeyboardDown += (KeyDownEvtHandler);
				Events.KeyboardUp += (KeyUpEvtHandler);
			}
			
			public static void SetDefMap(keyMap map) {

			}

			#region event handlers
			public static void KeyDownEvtHandler(object sender, KeyboardEventArgs e) {
				Key k = e.Key;

				if (e.Key == Key.Escape/* && e.Mod==ModifierKeys.LeftShift*/) app.Quit();
				else if (e.Key == m_map.action) m_keyDownState.action = true;
				else if (e.Key == m_map.down) m_keyDownState.down = true;
				else if (e.Key == m_map.hideMenu) m_keyDownState.hideMenu = true;
				else if (e.Key == m_map.item1) m_keyDownState.item1 = true;
				else if (e.Key == m_map.item2) m_keyDownState.item2 = true;
				else if (e.Key == m_map.left) m_keyDownState.left = true;
				else if (e.Key == m_map.right) m_keyDownState.right = true;
				else if (e.Key == m_map.showMenu) m_keyDownState.showMenu = true;
				else if (e.Key == m_map.sword) m_keyDownState.sword = true;
				else if (e.Key == m_map.up) m_keyDownState.up = true;

				
				C.Out("down: e.Key=" + e.Key + "  -  e.Scancode=" + e.Scancode);
			}
			public static void KeyUpEvtHandler(object sender, KeyboardEventArgs e) {
				if (e.Key == m_map.action) m_keyDownState.action = false;
				else if (e.Key == m_map.down) m_keyDownState.down= false;
				else if (e.Key == m_map.hideMenu) m_keyDownState.hideMenu= false;
				else if (e.Key == m_map.item1) m_keyDownState.item1 = false;
				else if (e.Key == m_map.item2) m_keyDownState.item2 = false;
				else if (e.Key == m_map.left) m_keyDownState.left = false;
				else if (e.Key == m_map.right) m_keyDownState.right = false;
				else if (e.Key == m_map.showMenu) m_keyDownState.showMenu = false;
				else if (e.Key == m_map.sword) m_keyDownState.sword = false;
				else if (e.Key == m_map.up) m_keyDownState.up = false;

				C.Out("up:   e.Key=" + e.Key + "  -  e.Scancode=" + e.Scancode);
			}
			#endregion

		}

	
	}

}