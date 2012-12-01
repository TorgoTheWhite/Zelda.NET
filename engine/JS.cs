using engine;
using Noesis;
using Noesis.Javascript;
using System;
using System.Resources;
using System.Reflection;

namespace engine {
	public static class JS {
		#region vars(....)
		private static JavascriptContext m_context;
		#endregion

		public static void Main(string[] args) {
			Init();
			string str="{ \"name\": \"Rachel\" }";
			room rm=JsonToRoom(str);
			C.MsgBox("str="+str);
			C.MsgBox("rm.name="+rm.name);

		}

		#region Init(....)
		public static void Init() {
			Reset();
			m_context.Run(Properties.Resources.sys_js_JsonToRoom);
		}
		#endregion
		
		#region Reset(....)
		public static void Reset() { Reset(new JavascriptContext()); }
		public static void Reset(JavascriptContext context) {
			m_context = context;
		}
		#endregion
	
		#region JsonToRoom()
		public static room JsonToRoom(string json) {

			return JsonToRoom(json, new room());
		}
		public static room JsonToRoom(string json, room rm) {
			m_context.SetParameter("newRoom", rm);
			m_context.SetParameter("roomJson", json);
			m_context.Run("JsonToRoom(roomJson, newRoom);");
			
			return rm;
		}
		#endregion

		#region 
		#endregion



	}



}
