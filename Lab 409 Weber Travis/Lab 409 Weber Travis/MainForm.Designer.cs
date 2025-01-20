/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/8/2016
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lab_409_Weber_Travis
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
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(111, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hours Worked";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(111, 174);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(322, 58);
			this.label2.TabIndex = 1;
			this.label2.Text = "Base Hourly Pay ";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(111, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(243, 62);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tax Exempt";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(482, 97);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(267, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(482, 197);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(267, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(111, 359);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Yes";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(250, 359);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "No";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(111, 443);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(267, 68);
			this.label4.TabIndex = 7;
			this.label4.Text = "Your total pay is";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(515, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(214, 162);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LimeGreen;
			this.label5.Location = new System.Drawing.Point(482, 443);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(315, 76);
			this.label5.TabIndex = 9;
			this.label5.Text = "label5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Visible = false;
			this.label5.Click += new System.EventHandler(this.Label5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(900, 570);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Lab 409 Weber Travis";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
