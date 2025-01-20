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
		void Label3Click(object sender, EventArgs e)
		{
		}
		void Label4Click(object sender, EventArgs e)
		{
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			string wordOG = (textBox1.Text);
			string word = wordOG.ToLower();
			int length = wordOG.Length ;
			
			string ub = "ub";
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			string vowel6 = "y";
			
			
			if 
			
			   (word.LastIndexOf(vowel1) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel1) > word.LastIndexOf(vowel6))
			   
			   {
				word = word.Remove((word.IndexOf(vowel1)),(length-(word.IndexOf(vowel1))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }
			
			else if 
			
			   (word.LastIndexOf(vowel2) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel2) > word.LastIndexOf(vowel6))
			   
			   {
				word = word.Remove((word.IndexOf(vowel2)),(length-(word.IndexOf(vowel2))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }
			else if 
			
			   (word.LastIndexOf(vowel3) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel3) > word.LastIndexOf(vowel6))
			   
			   {
				word = word.Remove((word.IndexOf(vowel3)),(length-(word.IndexOf(vowel3))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }
			else if 
			
			   (word.LastIndexOf(vowel4) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel5) &&
			   word.LastIndexOf(vowel4) > word.LastIndexOf(vowel6))
			   
			   {
				word = word.Remove((word.IndexOf(vowel4)),(length-(word.IndexOf(vowel4))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }
		else if 
			
			   (word.LastIndexOf(vowel5) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel5) > word.LastIndexOf(vowel6))
			   
			   {
				word = word.Remove((word.IndexOf(vowel5)),(length-(word.IndexOf(vowel5))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }
		else if 
			
			  (word.LastIndexOf(vowel6) > word.LastIndexOf(vowel1) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel2) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel3) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel4) &&
			   word.LastIndexOf(vowel6) > word.LastIndexOf(vowel5)   )
			   
			   {
				word = word.Remove((word.IndexOf(vowel6)),(length-(word.IndexOf(vowel6))));
			    string ubword = word + ub;
			    label4.Text = ubword; 
			   }	
		}
	}
}
