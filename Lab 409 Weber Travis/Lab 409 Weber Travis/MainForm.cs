/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/8/2016
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_409_Weber_Travis
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
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			double hoursworked = double.Parse (textBox1.Text);
			double hourlypay = double.Parse (textBox2.Text);
			double yourtotalpay = hoursworked*hourlypay;
		    double Tax = 0.89;
		    double totalTax = Tax*yourtotalpay;
		    double total = yourtotalpay + totalTax; 
		
			if (radioButton1.Checked == true)
			{
            hoursworked = double.Parse (textBox1.Text);
			hourlypay = double.Parse (textBox2.Text);
		    yourtotalpay = hoursworked*hourlypay;
			
			label5.Text = "$"+yourtotalpay;
			label5.Visible = true;
			}
			
			else if (radioButton2.Checked == true )
			{
			 hoursworked = double.Parse (textBox1.Text);
			 hourlypay = double.Parse (textBox2.Text);
			 yourtotalpay = hoursworked*hourlypay;
			 Tax = 0.11;
		     totalTax = Tax*yourtotalpay;
		     total = yourtotalpay - totalTax; 
		    
		     label5.Text = "$"+total;
			 label5.Visible = true;
			}
			
			
	
		}
		void Label5Click(object sender, EventArgs e)
		{
	
		}
	}
}
