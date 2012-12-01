/*
 * Created by SharpDevelop.
 * User: Erin
 * Date: 11/29/2012
 * Time: 5:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace editor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem_Main_File = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Main_File_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatortoolStripMenuItem_Main_File_Exit = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Main_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Main_View = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_Main_View_GameWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip_Main
			// 
			this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem_Main_File,
									this.toolStripMenuItem_Main_View});
			this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_Main.Name = "menuStrip_Main";
			this.menuStrip_Main.Size = new System.Drawing.Size(599, 24);
			this.menuStrip_Main.TabIndex = 0;
			this.menuStrip_Main.Text = "menuStrip1";
			// 
			// toolStripMenuItem_Main_File
			// 
			this.toolStripMenuItem_Main_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem_Main_File_Open,
									this.toolStripSeparatortoolStripMenuItem_Main_File_Exit,
									this.toolStripMenuItem_Main_File_Exit});
			this.toolStripMenuItem_Main_File.Name = "toolStripMenuItem_Main_File";
			this.toolStripMenuItem_Main_File.Size = new System.Drawing.Size(35, 20);
			this.toolStripMenuItem_Main_File.Text = "&File";
			// 
			// toolStripMenuItem_Main_File_Open
			// 
			this.toolStripMenuItem_Main_File_Open.Name = "toolStripMenuItem_Main_File_Open";
			this.toolStripMenuItem_Main_File_Open.Size = new System.Drawing.Size(111, 22);
			this.toolStripMenuItem_Main_File_Open.Text = "&Open";
			// 
			// toolStripSeparatortoolStripMenuItem_Main_File_Exit
			// 
			this.toolStripSeparatortoolStripMenuItem_Main_File_Exit.Name = "toolStripSeparatortoolStripMenuItem_Main_File_Exit";
			this.toolStripSeparatortoolStripMenuItem_Main_File_Exit.Size = new System.Drawing.Size(108, 6);
			// 
			// toolStripMenuItem_Main_File_Exit
			// 
			this.toolStripMenuItem_Main_File_Exit.Name = "toolStripMenuItem_Main_File_Exit";
			this.toolStripMenuItem_Main_File_Exit.Size = new System.Drawing.Size(111, 22);
			this.toolStripMenuItem_Main_File_Exit.Text = "E&xit";
			// 
			// toolStripMenuItem_Main_View
			// 
			this.toolStripMenuItem_Main_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem_Main_View_GameWindow});
			this.toolStripMenuItem_Main_View.Name = "toolStripMenuItem_Main_View";
			this.toolStripMenuItem_Main_View.Size = new System.Drawing.Size(41, 20);
			this.toolStripMenuItem_Main_View.Text = "&View";
			// 
			// toolStripMenuItem_Main_View_GameWindow
			// 
			this.toolStripMenuItem_Main_View_GameWindow.Name = "toolStripMenuItem_Main_View_GameWindow";
			this.toolStripMenuItem_Main_View_GameWindow.Size = new System.Drawing.Size(112, 22);
			this.toolStripMenuItem_Main_View_GameWindow.Text = "&Game";
			this.toolStripMenuItem_Main_View_GameWindow.Click += new System.EventHandler(this.ToolStripMenuItem_Main_View_GameWindowClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 406);
			this.Controls.Add(this.menuStrip_Main);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip_Main;
			this.Name = "MainForm";
			this.Text = "editor";
			this.menuStrip_Main.ResumeLayout(false);
			this.menuStrip_Main.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Main_View_GameWindow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Main_View;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Main_File_Exit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatortoolStripMenuItem_Main_File_Exit;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Main_File_Open;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Main_File;
		private System.Windows.Forms.MenuStrip menuStrip_Main;
	}
}
