using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace engine {
	public class game
	{
		#region vars
		public Dictionary<string, menu> menus=new Dictionary<string, menu>();
		public Dictionary<string, room> rooms=new Dictionary<string, room>();
		public string startRoom="";
		private bool m_active=false;
		public int frameRate=60;
		#endregion
	
		#region shared
		public static game Load() {
			game rv=new game();
			room rm;
			menu mnu;
			
			rv.startRoom="home";
			
			rm=new room();
			rm.name="home";
			rm.m_loaded=true;
			
			rv.rooms.Add(rm.name, rm);
			
			return rv;
		}
		#endregion
		
		public game() {
			
		}
	
		#region properties
		public bool active { get { return m_active; } }
		#endregion
		
		public void Activate() {
			roomRunner.SetGame(this);
			m_active=true;
		}
	}
}
