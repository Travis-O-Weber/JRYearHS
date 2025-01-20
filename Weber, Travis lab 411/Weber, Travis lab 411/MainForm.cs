/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/12/2016
 * Time: 3:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_lab_411
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox6TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			double tax = .085; 
			
			double CDPI = 11.95;
			double CDPLC = 15.95; 
			double CDPBP = 12.95;
			
			double jewelryPI = 25.00;
			double jewelryPLC = 40.00;
			double jewelryPBP = 33.00;
			
			double TI = 20.00;
			double TLC = 35.00;
			double TBP = 25.00;
			
			
			
			if (radioButton1.Checked == true)
			{
			double CDQ = double.Parse(textBox1.Text);
				
			double jewelryq = double.Parse(textBox2.Text);
			
			double TQ = double.Parse(textBox3.Text);
			
			
			double Ttot1 = TQ*TI; 
			double Jtot1 = jewelryq *jewelryPI;
			double CDtot1 = CDQ*CDPI;
			
			double sub1 = Ttot1+Jtot1+CDtot1;
			double tax1 = sub1*tax;
			double Tall1 = sub1+tax1;

			label8.Text = "$"+sub1;
			label8.Visible = true;
			
			label9.Text = "$"+tax1;
			label9.Visible = true;
			
			label10.Text = "$"+Tall1;
			label10.Visible = true;			
			
			}
			
			
			if (radioButton2.Checked == true)
			{
			double CDQ = double.Parse(textBox1.Text);
				
			double jewelryq = double.Parse(textBox2.Text);
			
			double TQ = double.Parse(textBox3.Text);
			
			double Ttot2 = TQ*TLC; 
			double Jtot2 = jewelryq *jewelryPLC;
			double CDtot2 = CDQ*CDPLC;
			
			double sub2 = Ttot2+Jtot2+CDtot2; 
			double tax2 = sub2*tax;
			double Tall2 = sub2+tax2; 
			
			label8.Text = "$"+sub2;
			label8.Visible = true;
			
			label9.Text = "$"+tax2;
			label9.Visible = true;
			
			label10.Text = "$"+Tall2;
			label10.Visible = true;
			
			}
			
			
			if (radioButton3.Checked == true)
			{
			double CDQ = double.Parse(textBox1.Text);
				
			double jewelryq = double.Parse(textBox2.Text);
			
			double TQ = double.Parse(textBox3.Text);
			
			double Ttot3 = TQ*TBP; 
			double Jtot3 = jewelryq *jewelryPBP;
			double CDtot3 = CDQ*CDPBP;
			
			double sub3 = Ttot3+Jtot3+CDtot3;
			double tax3 = sub3*tax;
			double Tall3 = sub3+tax3; 

			label8.Text = "$"+sub3;
			label8.Visible = true;
			
			label9.Text = "$"+tax3;
			label9.Visible = true;
			
			label10.Text = "$"+Tall3;
			label10.Visible = true;
			
				
			}
			
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
		void Label9Click(object sender, EventArgs e)
		{
	
		}
	}
}
