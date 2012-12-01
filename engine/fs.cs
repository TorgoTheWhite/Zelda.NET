using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace engine {
	class fs {

		#region properties
		static public string appDir { get { return Path.GetDirectoryName(Application.ExecutablePath); } }
		static public string appPath { get { return Application.ExecutablePath; } }
		static public string curDir {
			get { return Directory.GetCurrentDirectory(); }
			set { Directory.SetCurrentDirectory(value); }
		}
		#endregion

		#region FindFile
		static public string FindFile(string filnam) { return FindFile(filnam, null, null); }
		static public string FindFile(string filnam, string falseVal) {
			return FindFile(filnam, null, falseVal);
		}
		static public string FindFile(string filnam, Collection<string> searchPaths) {
			return FindFile(filnam, searchPaths, null);
		}
		static public string FindFile(string filnam, Collection<string> searchPaths, string falseVal) {
			string rv = falseVal;
			
			if (filnam != null) {
				if (filnam.Substring(1, 2) != @":\") {
					if (File.Exists(filnam)) rv = filnam;
				}
				else {
					int cnt=2, i;
					if(searchPaths!=null) cnt+=searchPaths.Count;
					string[] sp=new string[cnt];
					string str;
					
					sp[0]=curDir;
					if (cnt>2)
						for (i = 1; i < (cnt - 2); i++) sp[i] = searchPaths.ElementAt(i - 1);
					sp[cnt-1]=appDir;

					i = 0;
					while(i < cnt) {
						str = Path.Combine(sp[i], filnam);
						if(File.Exists(str)) { i=200000; rv=str; }
						else i++;
					}

				}
				
			}

			return rv;
		}
		#endregion
	
	}
}
