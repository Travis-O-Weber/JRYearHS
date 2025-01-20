/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 3/11/2016
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Weber__Travis_3._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button A1;
		private System.Windows.Forms.Button A3;
		private System.Windows.Forms.Button A2;
		private System.Windows.Forms.Button A4;
		private System.Windows.Forms.Button B1;
		private System.Windows.Forms.Button E1;
		private System.Windows.Forms.Button B2;
		private System.Windows.Forms.Button C2;
		private System.Windows.Forms.Button D2;
		private System.Windows.Forms.Button E2;
		private System.Windows.Forms.Button C1;
		private System.Windows.Forms.Button B3;
		private System.Windows.Forms.Button C3;
		private System.Windows.Forms.Button D3;
		private System.Windows.Forms.Button E3;
		private System.Windows.Forms.Button D1;
		private System.Windows.Forms.Button B4;
		private System.Windows.Forms.Button C4;
		private System.Windows.Forms.Button D4;
		private System.Windows.Forms.Button E4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.A1 = new System.Windows.Forms.Button();
			this.A3 = new System.Windows.Forms.Button();
			this.A2 = new System.Windows.Forms.Button();
			this.A4 = new System.Windows.Forms.Button();
			this.B1 = new System.Windows.Forms.Button();
			this.E1 = new System.Windows.Forms.Button();
			this.B2 = new System.Windows.Forms.Button();
			this.C2 = new System.Windows.Forms.Button();
			this.D2 = new System.Windows.Forms.Button();
			this.E2 = new System.Windows.Forms.Button();
			this.C1 = new System.Windows.Forms.Button();
			this.B3 = new System.Windows.Forms.Button();
			this.C3 = new System.Windows.Forms.Button();
			this.D3 = new System.Windows.Forms.Button();
			this.E3 = new System.Windows.Forms.Button();
			this.D1 = new System.Windows.Forms.Button();
			this.B4 = new System.Windows.Forms.Button();
			this.C4 = new System.Windows.Forms.Button();
			this.D4 = new System.Windows.Forms.Button();
			this.E4 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(2160, 566);
			this.button1.Margin = new System.Windows.Forms.Padding(6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(382, 144);
			this.button1.TabIndex = 0;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Lime;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(1698, 566);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 144);
			this.label1.TabIndex = 1;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Lime;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(1698, 760);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(844, 506);
			this.label2.TabIndex = 2;
			this.label2.Visible = false;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// A1
			// 
			this.A1.Location = new System.Drawing.Point(336, 465);
			this.A1.Margin = new System.Windows.Forms.Padding(6);
			this.A1.Name = "A1";
			this.A1.Size = new System.Drawing.Size(116, 104);
			this.A1.TabIndex = 9;
			this.A1.Text = "A1";
			this.A1.UseVisualStyleBackColor = true;
			this.A1.Click += new System.EventHandler(this.A1Click);
			// 
			// A3
			// 
			this.A3.Location = new System.Drawing.Point(336, 938);
			this.A3.Margin = new System.Windows.Forms.Padding(6);
			this.A3.Name = "A3";
			this.A3.Size = new System.Drawing.Size(116, 104);
			this.A3.TabIndex = 10;
			this.A3.Text = "A3";
			this.A3.UseVisualStyleBackColor = true;
			this.A3.Click += new System.EventHandler(this.A3Click);
			// 
			// A2
			// 
			this.A2.Location = new System.Drawing.Point(336, 690);
			this.A2.Margin = new System.Windows.Forms.Padding(6);
			this.A2.Name = "A2";
			this.A2.Size = new System.Drawing.Size(116, 104);
			this.A2.TabIndex = 11;
			this.A2.Text = "A2";
			this.A2.UseVisualStyleBackColor = true;
			this.A2.Click += new System.EventHandler(this.A2Click);
			// 
			// A4
			// 
			this.A4.Location = new System.Drawing.Point(336, 1162);
			this.A4.Margin = new System.Windows.Forms.Padding(6);
			this.A4.Name = "A4";
			this.A4.Size = new System.Drawing.Size(116, 104);
			this.A4.TabIndex = 12;
			this.A4.Text = "A4";
			this.A4.UseVisualStyleBackColor = true;
			this.A4.Click += new System.EventHandler(this.A4Click);
			// 
			// B1
			// 
			this.B1.Location = new System.Drawing.Point(582, 465);
			this.B1.Margin = new System.Windows.Forms.Padding(6);
			this.B1.Name = "B1";
			this.B1.Size = new System.Drawing.Size(116, 104);
			this.B1.TabIndex = 13;
			this.B1.Text = "B1";
			this.B1.UseVisualStyleBackColor = true;
			// 
			// E1
			// 
			this.E1.Location = new System.Drawing.Point(1332, 465);
			this.E1.Margin = new System.Windows.Forms.Padding(6);
			this.E1.Name = "E1";
			this.E1.Size = new System.Drawing.Size(116, 104);
			this.E1.TabIndex = 14;
			this.E1.Text = "E1";
			this.E1.UseVisualStyleBackColor = true;
			this.E1.Click += new System.EventHandler(this.E1Click);
			// 
			// B2
			// 
			this.B2.Location = new System.Drawing.Point(582, 690);
			this.B2.Margin = new System.Windows.Forms.Padding(6);
			this.B2.Name = "B2";
			this.B2.Size = new System.Drawing.Size(116, 104);
			this.B2.TabIndex = 15;
			this.B2.Text = "B2";
			this.B2.UseVisualStyleBackColor = true;
			this.B2.Click += new System.EventHandler(this.B2Click);
			// 
			// C2
			// 
			this.C2.Location = new System.Drawing.Point(844, 690);
			this.C2.Margin = new System.Windows.Forms.Padding(6);
			this.C2.Name = "C2";
			this.C2.Size = new System.Drawing.Size(116, 104);
			this.C2.TabIndex = 16;
			this.C2.Text = "C2";
			this.C2.UseVisualStyleBackColor = true;
			this.C2.Click += new System.EventHandler(this.C2Click);
			// 
			// D2
			// 
			this.D2.Location = new System.Drawing.Point(1090, 690);
			this.D2.Margin = new System.Windows.Forms.Padding(6);
			this.D2.Name = "D2";
			this.D2.Size = new System.Drawing.Size(116, 104);
			this.D2.TabIndex = 17;
			this.D2.Text = "D2";
			this.D2.UseVisualStyleBackColor = true;
			this.D2.Click += new System.EventHandler(this.D2Click);
			// 
			// E2
			// 
			this.E2.Location = new System.Drawing.Point(1332, 690);
			this.E2.Margin = new System.Windows.Forms.Padding(6);
			this.E2.Name = "E2";
			this.E2.Size = new System.Drawing.Size(116, 104);
			this.E2.TabIndex = 18;
			this.E2.Text = "E2";
			this.E2.UseVisualStyleBackColor = true;
			this.E2.Click += new System.EventHandler(this.E2Click);
			// 
			// C1
			// 
			this.C1.Location = new System.Drawing.Point(844, 465);
			this.C1.Margin = new System.Windows.Forms.Padding(6);
			this.C1.Name = "C1";
			this.C1.Size = new System.Drawing.Size(116, 104);
			this.C1.TabIndex = 19;
			this.C1.Text = "C1";
			this.C1.UseVisualStyleBackColor = true;
			this.C1.Click += new System.EventHandler(this.C1Click);
			// 
			// B3
			// 
			this.B3.Location = new System.Drawing.Point(582, 938);
			this.B3.Margin = new System.Windows.Forms.Padding(6);
			this.B3.Name = "B3";
			this.B3.Size = new System.Drawing.Size(116, 104);
			this.B3.TabIndex = 20;
			this.B3.Text = "B3";
			this.B3.UseVisualStyleBackColor = true;
			this.B3.Click += new System.EventHandler(this.B3Click);
			// 
			// C3
			// 
			this.C3.Location = new System.Drawing.Point(844, 938);
			this.C3.Margin = new System.Windows.Forms.Padding(6);
			this.C3.Name = "C3";
			this.C3.Size = new System.Drawing.Size(116, 104);
			this.C3.TabIndex = 21;
			this.C3.Text = "C3";
			this.C3.UseVisualStyleBackColor = true;
			this.C3.Click += new System.EventHandler(this.C3Click);
			// 
			// D3
			// 
			this.D3.Location = new System.Drawing.Point(1090, 938);
			this.D3.Margin = new System.Windows.Forms.Padding(6);
			this.D3.Name = "D3";
			this.D3.Size = new System.Drawing.Size(116, 104);
			this.D3.TabIndex = 22;
			this.D3.Text = "D3";
			this.D3.UseVisualStyleBackColor = true;
			this.D3.Click += new System.EventHandler(this.D3Click);
			// 
			// E3
			// 
			this.E3.Location = new System.Drawing.Point(1332, 938);
			this.E3.Margin = new System.Windows.Forms.Padding(6);
			this.E3.Name = "E3";
			this.E3.Size = new System.Drawing.Size(116, 104);
			this.E3.TabIndex = 23;
			this.E3.Text = "E3";
			this.E3.UseVisualStyleBackColor = true;
			this.E3.Click += new System.EventHandler(this.E3Click);
			// 
			// D1
			// 
			this.D1.Location = new System.Drawing.Point(1090, 465);
			this.D1.Margin = new System.Windows.Forms.Padding(6);
			this.D1.Name = "D1";
			this.D1.Size = new System.Drawing.Size(116, 104);
			this.D1.TabIndex = 24;
			this.D1.Text = "D1";
			this.D1.UseVisualStyleBackColor = true;
			this.D1.Click += new System.EventHandler(this.D1Click);
			// 
			// B4
			// 
			this.B4.Location = new System.Drawing.Point(582, 1162);
			this.B4.Margin = new System.Windows.Forms.Padding(6);
			this.B4.Name = "B4";
			this.B4.Size = new System.Drawing.Size(116, 104);
			this.B4.TabIndex = 25;
			this.B4.Text = "B4";
			this.B4.UseVisualStyleBackColor = true;
			this.B4.Click += new System.EventHandler(this.B4Click);
			// 
			// C4
			// 
			this.C4.Location = new System.Drawing.Point(844, 1162);
			this.C4.Margin = new System.Windows.Forms.Padding(6);
			this.C4.Name = "C4";
			this.C4.Size = new System.Drawing.Size(116, 104);
			this.C4.TabIndex = 26;
			this.C4.Text = "C4";
			this.C4.UseVisualStyleBackColor = true;
			this.C4.Click += new System.EventHandler(this.C4Click);
			// 
			// D4
			// 
			this.D4.Location = new System.Drawing.Point(1090, 1162);
			this.D4.Margin = new System.Windows.Forms.Padding(6);
			this.D4.Name = "D4";
			this.D4.Size = new System.Drawing.Size(116, 104);
			this.D4.TabIndex = 27;
			this.D4.Text = "D4";
			this.D4.UseVisualStyleBackColor = true;
			this.D4.Click += new System.EventHandler(this.D4Click);
			// 
			// E4
			// 
			this.E4.Location = new System.Drawing.Point(1332, 1162);
			this.E4.Margin = new System.Windows.Forms.Padding(6);
			this.E4.Name = "E4";
			this.E4.Size = new System.Drawing.Size(116, 104);
			this.E4.TabIndex = 28;
			this.E4.Text = "E4";
			this.E4.UseVisualStyleBackColor = true;
			this.E4.Click += new System.EventHandler(this.E4Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Lime;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(2160, 352);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(374, 144);
			this.label5.TabIndex = 29;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.Label3Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SaddleBrown;
			this.label6.ForeColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(111, 1366);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(2583, 54);
			this.label6.TabIndex = 30;
			this.label6.Click += new System.EventHandler(this.Label4Click);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.SaddleBrown;
			this.label8.ForeColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(162, 148);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 1352);
			this.label8.TabIndex = 31;
			this.label8.Click += new System.EventHandler(this.Label5Click);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.SaddleBrown;
			this.label7.ForeColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(2579, 148);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 1352);
			this.label7.TabIndex = 32;
			this.label7.Click += new System.EventHandler(this.Label6Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Lime;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label4.Location = new System.Drawing.Point(1698, 352);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(376, 144);
			this.label4.TabIndex = 33;
			this.label4.Text = "Number of Attempts:You only have five chances";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.Label7Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SaddleBrown;
			this.label3.ForeColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(111, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(2583, 54);
			this.label3.TabIndex = 34;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(2740, 1696);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.E4);
			this.Controls.Add(this.D4);
			this.Controls.Add(this.C4);
			this.Controls.Add(this.B4);
			this.Controls.Add(this.D1);
			this.Controls.Add(this.E3);
			this.Controls.Add(this.D3);
			this.Controls.Add(this.C3);
			this.Controls.Add(this.B3);
			this.Controls.Add(this.C1);
			this.Controls.Add(this.E2);
			this.Controls.Add(this.D2);
			this.Controls.Add(this.C2);
			this.Controls.Add(this.B2);
			this.Controls.Add(this.E1);
			this.Controls.Add(this.B1);
			this.Controls.Add(this.A4);
			this.Controls.Add(this.A2);
			this.Controls.Add(this.A3);
			this.Controls.Add(this.A1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "Weber, Travis 3.0";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
