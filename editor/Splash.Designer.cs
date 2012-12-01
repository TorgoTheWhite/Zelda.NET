/*
 * Created by SharpDevelop.
 * User: Erin
 * Date: 11/29/2012
 * Time: 10:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace editor
{
	partial class Splash
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
			this.label_Title = new System.Windows.Forms.Label();
			this.progressBar_Main = new System.Windows.Forms.ProgressBar();
			this.label_Task = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_Title
			// 
			this.label_Title.AutoSize = true;
			this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Title.Location = new System.Drawing.Point(12, 9);
			this.label_Title.Name = "label_Title";
			this.label_Title.Size = new System.Drawing.Size(212, 24);
			this.label_Title.TabIndex = 0;
			this.label_Title.Text = "Zelda.NET Game Editor";
			// 
			// progressBar_Main
			// 
			this.progressBar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar_Main.Location = new System.Drawing.Point(12, 207);
			this.progressBar_Main.Name = "progressBar_Main";
			this.progressBar_Main.Size = new System.Drawing.Size(475, 24);
			this.progressBar_Main.TabIndex = 1;
			// 
			// label_Task
			// 
			this.label_Task.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label_Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Task.Location = new System.Drawing.Point(12, 181);
			this.label_Task.Name = "label_Task";
			this.label_Task.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label_Task.Size = new System.Drawing.Size(475, 23);
			this.label_Task.TabIndex = 2;
			this.label_Task.Text = "Loading...";
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 243);
			this.ControlBox = false;
			this.Controls.Add(this.label_Task);
			this.Controls.Add(this.progressBar_Main);
			this.Controls.Add(this.label_Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Splash";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Loading....";
			this.Load += new System.EventHandler(this.SplashLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label_Task;
		private System.Windows.Forms.ProgressBar progressBar_Main;
		private System.Windows.Forms.Label label_Title;
	}
}
