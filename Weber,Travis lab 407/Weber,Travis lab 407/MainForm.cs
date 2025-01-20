/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/3/2016
 * Time: 2:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber_Travis_lab_407
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			double speedlimit = double.Parse (textBox1.Text);
			double speed = double.Parse (textBox2.Text);
			double speedlimitover = speed-speedlimit;
			
			
		
			if (speedlimitover  >= 0 && speedlimitover  <= 10 )
			{
				label5.Text="$125.00";
			}
			
			else if (speedlimitover >= 11 && speedlimitover <= 15 )
			{
				label5.Text="$175.00";
			}
			
			else if (speedlimitover >= 16 && speedlimitover <= 20 )
			{
				label5.Text="$225.00";
			}
			
			else if (speedlimitover >= 21 && speedlimitover <= 25 )
			{
				label5.Text="$300.00";
			}
			
			else if (speedlimitover >= 25)
			{
				label5.Text="$"+(((speedlimitover - 25) * 50) +300);
			}
				
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		}
	}
		
		

