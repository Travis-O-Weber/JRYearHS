/*
 * Created by SharpDevelop.
 * User: Travis
 * Date: 3/2/2016
 * Time: 10:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Sound_test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox duelStatebutton;
		
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
			this.duelStatebutton = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// duelStatebutton
			// 
			this.duelStatebutton.Location = new System.Drawing.Point(55, 45);
			this.duelStatebutton.Name = "duelStatebutton";
			this.duelStatebutton.Size = new System.Drawing.Size(104, 24);
			this.duelStatebutton.TabIndex = 0;
			this.duelStatebutton.Text = "Play";
			this.duelStatebutton.UseVisualStyleBackColor = true;
			this.duelStatebutton.CheckedChanged += new System.EventHandler(this.DuelStatebuttonCheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 316);
			this.Controls.Add(this.duelStatebutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Sound test";
			this.ResumeLayout(false);

		}
	}
}
