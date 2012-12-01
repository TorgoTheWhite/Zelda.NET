/*
 * Created by SharpDevelop.
 * User: Erin
 * Date: 11/29/2012
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace editor
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class app
	{
		#region vars
		static MainForm frmMain;
		#endregion

		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Splash splash=new Splash();

			splash.Show();

			frmMain=new MainForm();


			splash.Dispose();
			Application.Run(frmMain);
		}
		
	}
}
