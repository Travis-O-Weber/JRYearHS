/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/9/2016
 * Time: 2:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_lab_410
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
		void RadioButton3CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton4CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton5CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton6CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void RadioButton7CheckedChanged(object sender, EventArgs e)
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
		void CheckBox9CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox10CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox11CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			double Cost = 0.00;
			
			
			if (radioButton1.Checked == true) /*small*/
			{
                Cost = Cost +4.50;
			
			}
			
			else if (radioButton2.Checked == true ) /*mid*/
			{
			    Cost = Cost +5.75;
				
			}
			
			else if (radioButton3.Checked == true ) /*large*/
			{
			    Cost = Cost  +6.25;
				
			}
			else if (radioButton4.Checked == true ) /*crust*/
			{
			    Cost = Cost  +.00;
				
			}
			
			else if (radioButton5.Checked == true ) /*crust*/
			{
			    Cost = Cost  +.75;
				
			}
			else if (radioButton6.Checked == true ) /*crust*/
			{
			    Cost = Cost  +.50;
				
			}
			
			
			
			
			
			
			if (checkBox11.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost +.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
							
			}if (checkBox10.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost +.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
							
			}if (checkBox9.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost+.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
							
			}if (checkBox8.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost +.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
							
			}if (checkBox7.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost +.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
							
			}
			if (checkBox1.Checked == true)
			{
				if (radioButton1.Checked == true) /*small veg*/
				{
					Cost = Cost +.50;
				}
					else if (radioButton2.Checked == true) /*mid veg*/
				{
					Cost = Cost +.75;
				}
						else if (radioButton3.Checked == true) /*large veg*/
				{
					Cost = Cost +.75;
				}
				
			}
			
			if (checkBox2.Checked == true)
			{
				if (radioButton1.Checked == true) /*small m*/
				{
					Cost = Cost +1.00;
				}
					else if (radioButton2.Checked == true) /*mid m*/
				{
					Cost = Cost +1.50;
				}
						else if (radioButton3.Checked == true) /*large m*/
				{
					Cost = Cost +1.75;
				}
				
			}
			
			if (checkBox3.Checked == true)
			{
				if (radioButton1.Checked == true) /*small m*/
				{
					Cost = Cost +1.00;
				}
					else if (radioButton2.Checked == true) /*mid m*/
				{
					Cost = Cost +1.50;
				}
						else if (radioButton3.Checked == true) /*large m*/
				{
					Cost = Cost +1.75;
				}
				
			}
			
			if (checkBox4.Checked == true)
			{
				if (radioButton1.Checked == true) /*small m*/
				{
					Cost = Cost +1.00;
				}
					else if (radioButton2.Checked == true) /*mid m*/
				{
					Cost = Cost +1.50;
				}
						else if (radioButton3.Checked == true) /*large m*/
				{
					Cost = Cost +1.75;
				}
				
			}
		   
			
			if (checkBox5.Checked == true)
			{
				if (radioButton1.Checked == true) /*small m*/
				{
					Cost = Cost +1.00;
				}
					else if (radioButton2.Checked == true) /*mid m*/
				{
					Cost = Cost +1.50;
				}
						else if (radioButton3.Checked == true) /*large m*/
				{
					Cost = Cost +1.75;
				}
				
			}
			
			if (checkBox6.Checked == true)
			{
				if (radioButton1.Checked == true) /*small m*/
				{
					Cost = Cost +1.00;
				}
					else if (radioButton2.Checked == true) /*mid m*/
				{
					Cost = Cost +1.50;
				}
						else if (radioButton3.Checked == true) /*large m*/
				{
					Cost = Cost +1.75;
				}
				
			}
			label4.Text = "$"+Cost;
			label4.Visible = true;
		
		}
		void GroupBox2Enter(object sender, EventArgs e)
		{
	
		}
	}
}
