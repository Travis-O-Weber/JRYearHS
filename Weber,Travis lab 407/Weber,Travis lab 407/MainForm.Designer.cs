/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/3/2016
 * Time: 2:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Weber_Travis_lab_407
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(734, 81);
			this.label1.TabIndex = 0;
			this.label1.Text = "Go Fast Program";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(70, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 57);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter the Speed limit:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(573, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 57);
			this.label3.TabIndex = 2;
			this.label3.Text = "Enter the speed they were going: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(70, 232);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(231, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(573, 232);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(231, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(284, 320);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(295, 91);
			this.button1.TabIndex = 5;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(284, 471);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(295, 59);
			this.label4.TabIndex = 6;
			this.label4.Text = "Your fine is ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(284, 530);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(295, 59);
			this.label5.TabIndex = 7;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(884, 629);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Weber,Travis lab 407";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
