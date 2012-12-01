/*
 * Created by SharpDevelop.
 * User: Erin
 * Date: 11/29/2012
 * Time: 10:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace editor
{
	/// <summary>
	/// Description of Splash.
	/// </summary>
	public partial class Splash : Form
	{
		public Splash() {
			InitializeComponent();


		}
		void SplashLoad(object sender, EventArgs e) {
			Size ss=Screen.PrimaryScreen.WorkingArea.Size;
			Size ts=this.Size;
			this.Location=new Point(
				((ss.Width/2) - (ts.Width/2))
			,	((ss.Height/2) - (ts.Height/2))
			);
		
		}
		
	}
}
