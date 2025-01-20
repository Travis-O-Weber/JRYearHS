/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 1/26/2016
 * Time: 8:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber_Travis_lab403_GradeProgram
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
		void Label1Click(object sender, EventArgs e)// Title
		{
	
		}
		void Label2Click(object sender, EventArgs e)// instructons 
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)//type in letter
		{
		
	
		}
		void Button1Click(object sender, EventArgs e)// calc
		{
			if (textBox1.Text=="A")
			{
				label3.Visible = true;
				label4.Visible = true;
				label4.Text= "4.00" ;
			}
			
			if (textBox1.Text=="B")
			{
				label3.Visible = true;
				label4.Visible = true;
				label4.Text= "3.00" ;
			}
			
			if (textBox1.Text=="C")
			{
				label3.Visible = true;
				label4.Visible = true;
				label4.Text= "2.00" ;
			}
			
			if (textBox1.Text=="D")
			{
				label3.Visible = true;
				label4.Visible = true;
				label4.Text= "1.00" ;
			}
			
			if (textBox1.Text=="F")
			{
				label3.Visible = true;
				label4.Visible = true;
				label4.Text= "0.00" ;
			}
		    
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
	}
}
