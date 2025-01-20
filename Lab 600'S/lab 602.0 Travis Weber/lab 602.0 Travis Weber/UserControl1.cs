/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/28/2016
 * Time: 2:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace lab_602.__Travis_Weber
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			int testnum = int.Parse(textBox1.Text);
			int counter = 0;
 			for (int i = 2; i <= testnum; i++)
    		 if (testnum % i == 0)                        
          	counter++;

		 if (testnum != 1 && counter == 1)                 
   		  label2.Text = "you number is prime";
 			else
     		label2.Text = "your number is composite";
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}