/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/17/2016
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_lab_._12_and_413
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
		{
		}
			
		}
		int attempts = 0;
		bool clicked = true;
		
		void Button1Click(object sender, EventArgs e)
		{
		
		label3.Text = "";
		label2.Visible = true;
		button2.Visible = true;
		textBox1.Visible = true;
	
		int random;
		
		Random tool = new Random();
		random = tool.Next(1,1001);
		
		label6.Text = random.ToString();

		}
		void Button2Click(object sender, EventArgs e)
		{
		
			int random = int.Parse(label6.Text);
			int guess =  int.Parse(textBox1.Text);
		
		if (clicked == true)
		{
			attempts++;
		}
		
		
		if (guess > random)
		{
		label3.Visible = true;
		label3.Text =  "You guessed high";
		}
		
		
		
		else if (guess<random)
		{
		label3.Visible = true;
		label3.Text =  "You guessed low";
		}

		else if (guess==random)
		{
		label2.Visible = true;
		label3.Text =  "You guessed Correct"; 
		button2.Visible = true;
		textBox1.Visible = true;
		clicked = false;
		}
		
		string att = attempts.ToString();
		label5.Text = att; 
	
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
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
