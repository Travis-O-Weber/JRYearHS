/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 3/8/2016
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_lab_506
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			string wordOG = (textBox1.Text);
			string words = wordOG.ToLower();
			int length = wordOG.Length ;
			
			string ub = "ub";
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			
			if 
				(wordOG.Substring(0,1) == vowel1 ||
			    wordOG.Substring(0,1) == vowel2 ||
			    wordOG.Substring(0,1) == vowel3 ||
			    wordOG.Substring(0,1) == vowel4 ||
			    wordOG.Substring(0,1) == vowel5 |
			    wordOG.Substring(0,1) == vowel6 )
			   
				{
				words = words.Insert(0,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(1,1) == vowel1 ||
			    wordOG.Substring(1,1) == vowel2 ||
			    wordOG.Substring(1,1) == vowel3 ||
			    wordOG.Substring(1,1) == vowel4 ||
			    wordOG.Substring(1,1) == vowel5 ||
			    wordOG.Substring(1,1) == vowel6 )
	
				{
				words = words.Insert(1,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(2,1) == vowel1 ||
			    wordOG.Substring(2,1) == vowel2 ||
			    wordOG.Substring(2,1) == vowel3 ||
			    wordOG.Substring(2,1) == vowel4 ||
			    wordOG.Substring(2,1) == vowel5 ||
			    wordOG.Substring(2,1) == vowel6 )
			
				{
				words = words.Insert(2,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(3,1) == vowel1 ||
			    wordOG.Substring(3,1) == vowel2 ||
			    wordOG.Substring(3,1) == vowel3 ||
			    wordOG.Substring(3,1) == vowel4 ||
			    wordOG.Substring(3,1) == vowel5 ||
			    wordOG.Substring(3,1) == vowel6 )
			
				{
				words = words.Insert(3,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(4,1) == vowel1 ||
			    wordOG.Substring(4,1) == vowel2 ||
			    wordOG.Substring(4,1) == vowel3 ||
			    wordOG.Substring(4,1) == vowel4 ||
			    wordOG.Substring(4,1) == vowel5 ||
			    wordOG.Substring(4,1) == vowel6 )
			
				{
				words = words.Insert(4,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(5,1) == vowel1 ||
			    wordOG.Substring(5,1) == vowel2 ||
			    wordOG.Substring(5,1) == vowel3 ||
			    wordOG.Substring(5,1) == vowel4 ||
			    wordOG.Substring(5,1) == vowel5 ||
			    wordOG.Substring(5,1) == vowel6 )
		
				{
				words = words.Insert(5,ub);
				label4.Text = words;
				}
			else if 
				(wordOG.Substring(5,1) == vowel1 ||
			    wordOG.Substring(5,1) == vowel2 ||
			    wordOG.Substring(5,1) == vowel3 ||
			    wordOG.Substring(5,1) == vowel4 ||
			    wordOG.Substring(5,1) == vowel5 ||
			    wordOG.Substring(5,1) == vowel6 )
		
				{
				words = words.Insert(6,ub);
				label4.Text = words;
				}
		}
	}
}
