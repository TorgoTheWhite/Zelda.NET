using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using SdlDotNet.Graphics;

namespace engine {
	public enum tileSheetType { multi, single }
	
	public class tile {
		#region vars
		public tileSheet parent=null;
		public string parentName="";
		public string fullName="";
		public string name="";
		public Surface image=null;
		#endregion
		
		public tile() {
		
		}
	}

	public class tileSheet {
		#region vars
		public bool m_loaded=false;
		public tile tile=null;
		public Dictionary<string, tile> tiles=null;
		public tileSheetType type=tileSheetType.single;
		public string filePath="";
		public string imagePath="";
		public string name="";
		public Surface image=null;
		#endregion
		
		public tileSheet() {
		
		}
		
		public void Load(string filnam) { this.Load(filnam, null); }
		public void Load(string filnam, Collection<string> searchPaths) {
			
			this.m_loaded=true;
		}
		
	}
}
