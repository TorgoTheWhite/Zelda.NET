using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public static class C {
	public static void Out(string val) { Console.WriteLine(val); }
	
	#region MsgBox(....)
	public static DialogResult MsgBox(string val) { return MessageBox.Show(val); }
	#endregion
}
