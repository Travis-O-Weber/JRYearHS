/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 1/21/2016
 * Time: 2:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber_Travis_lab402_Area_GUI
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
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e) // Next button  
		{
			if (radioButton1.Checked == true)  //Circle
			{
				label3.Visible = true;
				textBox1.Visible = true;
				button2.Visible = true;
				
				label4.Visible = false;
				label5.Visible = false;
				textBox2.Visible = false;
				textBox4.Visible = false;
				
				
				label6.Visible = false;
				label7.Visible = false;
				textBox3.Visible = false;
				textBox5.Visible = false;
				
				label8.Visible = false;
				label9.Visible = false;
			
			}
		    if (radioButton2.Checked == true)  //Rectangle 
			{
				label3.Visible = false;
				textBox1.Visible = false;
		    	
				label4.Visible = true;
				label5.Visible = true;
				textBox2.Visible = true;
				textBox4.Visible = true;
				button2.Visible = true;
				
				label6.Visible = false;
				label7.Visible = false;
				textBox3.Visible = false;
				textBox5.Visible = false;
				
				label8.Visible = false;
				label9.Visible = false;
				
			
		    }
		    if (radioButton3.Checked == true)  //Triangle
			{
				label3.Visible = false;
				textBox1.Visible = false;
				
				label4.Visible = false;
				label5.Visible = false;
				textBox2.Visible = false;
				textBox4.Visible = false;
				
		    	
		    	label6.Visible = true;
				label7.Visible = true;
				textBox3.Visible = true;
				textBox5.Visible = true;
				button2.Visible = true;
				
				label8.Visible = false;
				label9.Visible = false;
		
		    }
		
		
		
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
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
		void Button2Click(object sender, EventArgs e) /* Calculate */
		{
	
			label8.Visible = true;
			label9.Visible = true;
			
			if (radioButton1.Checked == true)  //Circle
			{	
		    double pi = 3.14159;
			double r = double.Parse(textBox1.Text);
			double C = (r*r*pi);
			label8.Text = ""+C;
			}
			if (radioButton3.Checked == true) //Triangle
			{
			double B= double.Parse(textBox3.Text);
			double H= double.Parse(textBox5.Text);
		    double T=(B*H*.5);
		    label8.Text = ""+T;
			}
		    if (radioButton2.Checked == true) //rectangle
			{
			double W= double.Parse(textBox4.Text);
			double L= double.Parse(textBox2.Text);
		    double R=(W*L);
		    label8.Text = ""+R;
			}
			
			
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
	}
}
