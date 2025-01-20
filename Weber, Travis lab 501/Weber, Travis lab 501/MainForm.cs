/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 2/25/2016
 * Time: 2:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_lab_501
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
		void Button1Click(object sender, EventArgs e)
		{
			string words = (textBox1.Text);
			
			words = words.ToLower();
			
			
			string wordadd = "ay"; 
			string vowel1 = "a";
			string vowel2 = "e";
			string vowel3 = "i";
			string vowel4 = "o";
			string vowel5 = "u";
			
			
			if 
				(words.Substring(0,1) == vowel1 ||
			    words.Substring(0,1) == vowel2 ||
			    words.Substring(0,1) == vowel3 ||
			    words.Substring(0,1) == vowel4 ||
			    words.Substring(0,1) == vowel5 )
			   
		
				{
				label2.Text = words + wordadd ;
				
				}
			else if 
				(words.Substring(1,1) == vowel1 ||
			    words.Substring(1,1) == vowel2 ||
			    words.Substring(1,1) == vowel3 ||
			    words.Substring(1,1) == vowel4 ||
			    words.Substring(1,1) == vowel5 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,1);
				words=words.Remove(0,1);
				label2.Text = words + cons + wordadd;
				}
			else if 
				(words.Substring(2,1) == vowel1 ||
			    words.Substring(2,1) == vowel2 ||
			    words.Substring(2,1) == vowel3 ||
			    words.Substring(2,1) == vowel4 ||
			    words.Substring(2,1) == vowel5 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,2);
				words=words.Remove(0,2);
				label2.Text = words + cons + wordadd;
				}
			else if 
				(words.Substring(3,1) == vowel1 ||
			    words.Substring(3,1) == vowel2 ||
			    words.Substring(3,1) == vowel3 ||
			    words.Substring(3,1) == vowel4 ||
			    words.Substring(3,1) == vowel5 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,3);
				words=words.Remove(0,3);
				label2.Text = words + cons + wordadd;
			}
			else if 
				(words.Substring(4,1) == vowel1 ||
			    words.Substring(4,1) == vowel2 ||
			    words.Substring(4,1) == vowel3 ||
			    words.Substring(4,1) == vowel4 ||
			    words.Substring(4,1) == vowel5 )
			
			
				{
		
				string cons;
				cons = words.Substring(0,4);
				words=words.Remove(0,4);
				label2.Text = words + cons + wordadd ;
		
				}
	
		  }
		}
	}

