/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/1/2016
 * Time: 4:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_604.__Travis_Weber
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		int lcm;
        int temp=1;
		void Button1Click(object sender, EventArgs e)
		{
	int num = int.Parse(textBox1.Text);
            int num1 = int.Parse(textBox2.Text);
            if (num > num1)
                lcm = lcmfinder(num, num1);
            else
                lcm = lcmfinder(num1, num);
            label1.Text = lcm.ToString();
        }
        int lcmfinder(int x, int y)
        {
          
            while (x != y)
            {
                if (temp %y==0 && temp %x ==0)
                {
                    return temp ;
                }
                    temp++;
                lcmfinder (x,y);
            }
            return temp ;
		}
	}
}
