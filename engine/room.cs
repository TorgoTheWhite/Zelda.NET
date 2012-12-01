//using engine;
using SdlDotNet.Core;
using SdlDotNet.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Text;

namespace engine {
	public class room {
		#region vars

		private string m_filename;
		private string m_name;
		public bool m_loaded;
		private Collection<string> m_searchPaths;
		private Point m_size;
		private Surface m_screen;

		#endregion

		#region constructors

		public room() { Init(null, null, false); }
		public room(string filnam) { Init(filnam, null, true); }
		public room(string filnam, bool autoLoad) { Init(filnam, null, autoLoad); }
		public room(string filnam, Collection<string> searchPaths) { Init(filnam, searchPaths, false); }
		public room(Collection<string> searchPaths) { Init(null, searchPaths, false); }

		#endregion

		private void Init(string filnam, Collection<string> searchPaths, bool autoLoad) {
			m_screen = screen;
			m_searchPaths = searchPaths;

			if (filnam != null && filnam != "") {
				m_filename = filnam;
				if (autoLoad) Load(filnam);
				else Reset();
			}
			else {
				m_filename = "";
				Reset(true);
			}
			C.Out("kk");
		}

		#region Reset()
		public void Reset(bool doSearchPaths = false) {
			m_filename = "";
			m_loaded = false;
			m_name = "";
			m_screen = null;
			if(doSearchPaths) m_searchPaths = null;
			m_size = new Point(0, 0);
		}
		#endregion

		#region properties

		public bool isLoaded { get { return m_loaded; } }
		public string filename { get { return m_filename; } }
		public string name { get { return m_name; } set { m_name = value; } }
		public Surface screen {
			get { return m_screen; }
			set { m_screen = value; }
		}
		public Point size {
			get { return m_size; }
			set { m_size = value; }
		}

		#endregion

		#region load/save

		public string Load(string filnam) { m_filename=filnam; return Load(); }
		public string Load(string filnam, Collection<string> searchPaths) {
			m_filename = filnam;
			m_searchPaths = searchPaths;
			return Load();
		}
		public string Load() {
			string rv = "", filnam=m_filename;

			Reset(false);

			if (filnam != "") {
				m_filename = fs.FindFile(filnam, m_searchPaths, "");
				if (m_filename != "") {
					
				}

			}

			return rv;
		}
		
		#endregion

	}

	public static class roomRunner {
		#region vars

		private static game m_game;
		private static Collection<string> m_searchPaths;
		private static room m_room;
		private static Dictionary<string, room> m_rooms;
		private static Surface m_screen;
		#endregion

		#region Init()
		public static void Init() { Init(app.screen); }
		public static void Init(Surface screen) {
			m_screen = screen;


	
		}

		#endregion

		#region properties
		public static room room { get { return m_room; } set { m_room = value; } }
		public static Surface screen { get { return m_screen; } set { m_screen = value; } }
		#endregion

		#region load/save
		public static string Load(string filnam) { return Load(filnam, null); }
		public static string Load(string filnam, Collection<string> searchPaths) {
			string rv = "", str;
			if(searchPaths==null) searchPaths=m_searchPaths;

			if (filnam != null) {
				str=fs.FindFile(filnam, searchPaths, "");
				if (str != "") {

				}
			}

			return rv;
		}
		
		#endregion

		public static void SetGame(game gam) {
			m_game=gam;
			m_room=null;
			if(gam!=null) m_rooms=gam.rooms;
			else m_rooms=null;
		}
		public static void Tick() {
			if(m_room==null) {
				
			}
			else {
				
			}
		}
	}
}
