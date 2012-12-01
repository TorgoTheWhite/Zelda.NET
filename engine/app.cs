//using engine;
using engine.input;
using System;
using System.Drawing;
using SdlDotNet.Graphics;
using SdlDotNet.Core;

namespace engine {
	public class app {

		#region vars

		private static Surface m_screen;
		public static keyMapDownState keyDownState = new keyMapDownState();
		private static int m_ticCount = 0;
		private static game m_curGame = null;

		#endregion

		public static void Main(string[] args) {
			m_curGame=game.Load();
			C.Out("starting...");
			Setup();
			C.Out("After setup");
			m_curGame.Activate();
			Events.Run();
		}

		#region setup
		private static void Setup() {
			SetupEventHandlers();
			SetupScreen();
			SetupInput();
		}
		private static void SetupEventHandlers() {
			Events.Quit += new EventHandler<QuitEventArgs>(AppQuitEvtHandler);
			Events.Tick += new EventHandler<TickEventArgs>(AppTickEvtHandler);
		}
		private static void SetupInput() {
			keyboardHandler.Init();
		}
		private static void SetupScreen() {
			m_screen = Video.SetVideoMode(640, 480, 32, false, false, false, true);
		}

		#endregion

		#region properties
		public static Surface screen { get { return m_screen; } }
		#endregion

		public static void Quit() { Events.QuitApplication(); }

		#region event handlers
		private static void AppQuitEvtHandler(object sender, QuitEventArgs e) { Quit(); }
		private static void AppTickEvtHandler(object sender, TickEventArgs e) {
			C.Out("**** m_ticCount= " + m_ticCount++);
		}
		#endregion
	}

}