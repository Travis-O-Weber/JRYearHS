   /*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/1/2016
 * Time: 2:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber_Travis_lab406
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
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
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox3CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox4CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox5CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox6CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox7CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox8CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
		
			double total = 0; 
			
			if(radioButton1.Checked==true)
			{
				total = total + 23; 
			}
			else	
			if(radioButton2.Checked==true)
			{
				
				total = total + 27;
			}
			else	
			if(radioButton3.Checked==true)
			{
				
				total = total + 15;
			}
			
			if(checkBox1.Checked==true)
			{
				total = total + 2;
			}
			
			if(checkBox2.Checked==true)
			{
				total = total + 3.5;
			}
			
			if(checkBox3.Checked==true)
			{
				total = total + 1.5;
			}
			
			if(checkBox4.Checked==true)
			{
				total = total + 3.0;
			}
			
			if(checkBox5.Checked==true)
			{
				total = total + 5.0;
			}
			
			if(checkBox6.Checked==true)
			{
				total = total + 6.0;
			}
			
			if(checkBox7.Checked==true)
			{
				total = total + 10.0;
			}
			
			if(checkBox8.Checked==true)
			{
				total = total + 23.0;
			}
		
		
			label3.Text="$"+total;
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
	}
}
