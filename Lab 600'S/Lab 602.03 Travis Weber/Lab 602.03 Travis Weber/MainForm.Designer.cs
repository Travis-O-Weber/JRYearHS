/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/28/2016
 * Time: 3:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lab_602._3_Travis_Weber
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(587, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 31);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type a number to find out if it is prime or composite";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(405, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(489, 62);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(214, 55);
			this.button1.TabIndex = 3;
			this.button1.Text = "Test number";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(927, 757);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "Lab 602.03 Travis Weber";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
