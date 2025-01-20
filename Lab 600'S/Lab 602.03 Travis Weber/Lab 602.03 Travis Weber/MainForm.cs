/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 4/28/2016
 * Time: 3:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_602._3_Travis_Weber
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
		void Button1Click(object sender, EventArgs e)
		{
			int testnum = int.Parse(textBox1.Text);
			int counter = 0;
 			
			if (testnum <= 0){
				label2.Text = "That number can't be prime or composite";
			}
			else
			{
			for (int i = 2; i <= testnum; i++)
    		 if (testnum % i == 0)                        
          	counter++;

		 if (testnum != 1 && counter == 1)                 
   		  label2.Text = "you number is prime";
 			else
     		label2.Text = "your number is composite";
	
		}
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
