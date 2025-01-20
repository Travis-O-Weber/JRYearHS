/*
 * Created by SharpDevelop.
 * User: legol
 * Date: 5/6/2016
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_607_Travis_Weber
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
		void Label5Click(object sender, EventArgs e)
		{
	
		}
		void Label6Click(object sender, EventArgs e)
		{
	
		}
		void Label7Click(object sender, EventArgs e)
		{
	
		}
		void Label8Click(object sender, EventArgs e)
		{
	
		}
		void Label9Click(object sender, EventArgs e)
		{
	
		}
		void Label10Click(object sender, EventArgs e)
		{
	
		}
		void Label11Click(object sender, EventArgs e)
		{
	
		}
		void Label12Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox5Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox6Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox7Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox8Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox9Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox10Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox11Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox12Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox13Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox14Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox15Click(object sender, EventArgs e)
		{
	
		}
		void PictureBox16Click(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
		Random rnd = new Random();
		int roll = 0;
		int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
		int dice2 = rnd.Next(1, 7);   // creates a number between 1 and 6

		roll++;
			
		label10.Text= ""+dice;
		label11.Text= ""+dice2;
		
		if (dice == 1)
		{
			pictureBox1.Visible = true;
			pictureBox9.Visible = true;
			
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox8.Visible = false;
		}
		
		if (dice == 2)
		{
			pictureBox1.Visible = true;
			pictureBox3.Visible = true;
			pictureBox8.Visible = true;
			
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox9.Visible = false;
			
		}
		
		if (dice == 3)
		{
			pictureBox1.Visible = true;
			pictureBox3.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
		}
		
		if (dice == 4)
		{
			pictureBox1.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox9.Visible = false;
		}
		
		if (dice == 5)
		{
			pictureBox1.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			
			
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			
		}
		
		if (dice == 6)
		{
			pictureBox1.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			
			pictureBox9.Visible = false;
		}
		
		if (dice2 == 1)
		{
			pictureBox2.Visible = true;
			pictureBox10.Visible = true;
			
			pictureBox11.Visible = false;
			pictureBox12.Visible = false;
			pictureBox13.Visible = false;
			pictureBox14.Visible = false;
			pictureBox15.Visible = false;
			pictureBox16.Visible = false;
		}
		
		if (dice2 == 2)
		{
			pictureBox2.Visible = true;
			pictureBox11.Visible =true;
			pictureBox16.Visible = true;
			
			pictureBox10.Visible = false;
			pictureBox12.Visible = false;
			pictureBox13.Visible = false;
			pictureBox14.Visible = false;
			pictureBox15.Visible = false;
			
		}
		
		if (dice2 == 3)
		{
			pictureBox2.Visible = true;
			pictureBox10.Visible = true;
			pictureBox11.Visible = true;
			pictureBox16.Visible = true;
			
			pictureBox12.Visible = false;
			pictureBox13.Visible = false;
			pictureBox14.Visible = false;
			pictureBox15.Visible = false;
		}
		
		if (dice2 == 4)
		{
			pictureBox2.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			
			pictureBox10.Visible = false;	
			pictureBox13.Visible = false;
			pictureBox14.Visible = false;
			
			
		}
		
		if (dice2 == 5)
		{
			pictureBox2.Visible = true;
			pictureBox10.Visible = true;	
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			
			pictureBox13.Visible = false;
			pictureBox14.Visible = false;			
		
		}
		
		if (dice2 == 6)
		{
			pictureBox2.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox13.Visible = true;
			pictureBox14.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			
			
			pictureBox10.Visible = false;	
		}
			int tot1 = (dice+dice2);
			int point=tot1;
			int tot2 = (dice+dice2);
				
				if (roll == 1)
			{
					if (point  == 2)
					{
						label12.Text= "You Lose!!! :)";
					}
					if (point == 3)
					{
						label12.Text= "You Lose!!! :)";
					}
					if (point == 12)
					{
						label12.Text= "You Lose!!! :)";
					}
					if (point == 7)
					{
						label12.Text= "You Win!!!";
					}
					if (point == 11)
					{
						label12.Text= "You Win!!!";
					}
					else 
					{
						point=tot1;
						label12.Text= "reroll";
						label14.Text=  ""+point;
					}
				
			}
				    if (roll == 2)
				    
                {
                  
                    
                    if (tot2 == point)
                    {
                        label12.Text= "You Win!!!";
                        label14.Text=  ""+point;
                    }
                    if (tot2 == 7)
                    {
                        label12.Text= "You Lose!!! :)";
                        label14.Text=  ""+point;
                    }
                    if (tot2 == 11)
                    {
                        label12.Text= "You Lose!!! :)";
                        label14.Text=  ""+point;
                    }
                    else 
                    {
                        point=tot1;
                        label12.Text= "reroll";
                    }
                    
                
                }
                  if (roll > 2)
                {
                     
                    
                    if (tot2 == point)
                    {
                        label12.Text= "You Win!!!";
                        label14.Text=  ""+point;
                    }
                      if (tot2 == 7)
                    {
                        label12.Text= "You Lose!!! :)";
                        label14.Text=  ""+point;
                    }
                    if (tot2 == 11)
                    {
                        label12.Text= "You Lose!!! :)";
                        label14.Text=  ""+point;
                    }
                    else 
                    {
                        point=tot1;
                        label12.Text= "reroll";
                    
                    }
                    
                
                

			
				}
		
		     }
		}
	
}
	
