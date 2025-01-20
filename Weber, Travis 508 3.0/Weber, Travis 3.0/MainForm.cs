/*
 * Created by SharpDevelop.
 * User: s570086
 * Date: 3/11/2016
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weber__Travis_3._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\legol\Documents\School stuff\Frying_Food-J_Bravo-1591470421.wav");//laptop
		System.Media.SoundPlayer startSoundPlayer2 = new System.Media.SoundPlayer(@"C:\Users\legol\Documents\School stuff\Pig Oinking-SoundBible.com-1904855325.wav");//laptop
		
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
		int attempts = 0;
		int time = 0;
		Random random = new Random();
		int rando;
		int time2; 
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			rando = random.Next(1,21);
			label6.Visible = true;
			
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
		

		void Timer1Tick(object sender, EventArgs e)
		{
			time++;
			time2 = 15-time;
			label1.Text = ""+time2;
			if (time >= 15)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				startSoundPlayer2.Play();
			}
		}
		void A1Click(object sender, EventArgs e)
		{
			if (rando == 1)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				label2.Visible = true;
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void A2Click(object sender, EventArgs e)
		{
			if (rando == 2)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void A3Click(object sender, EventArgs e)
		{
			if (rando == 3)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void A4Click(object sender, EventArgs e)
		{
			if (rando == 4)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void B1Click(object sender, EventArgs e)
		{
			if (rando == 2)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void B2Click(object sender, EventArgs e)
		{
			if (rando == 6)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void B3Click(object sender, EventArgs e)
		{
			if (rando == 7)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void B4Click(object sender, EventArgs e)
		{
			if (rando == 8)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void C1Click(object sender, EventArgs e)
		{
			if (rando == 9)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void C2Click(object sender, EventArgs e)
		{
			if (rando == 10)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void C3Click(object sender, EventArgs e)
		{
			if (rando == 11)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void C4Click(object sender, EventArgs e)
		{
			if (rando == 12)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void D1Click(object sender, EventArgs e)
		{
			if (rando == 13)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}	
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void D2Click(object sender, EventArgs e)
		{
			if (rando == 14)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void D3Click(object sender, EventArgs e)
		{
			if (rando == 15)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void D4Click(object sender, EventArgs e)
		{
			if (rando == 16)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void E1Click(object sender, EventArgs e)
		{
			if (rando == 17)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void E2Click(object sender, EventArgs e)
		{
			if (rando == 18)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void E3Click(object sender, EventArgs e)
		{
			if (rando == 19)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
			}
			if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void E4Click(object sender, EventArgs e)
		{
			if (rando == 20)
			{
				label2.Text = "You caught the pig bacon tonight";
				label2.Visible = true;
				MessageBox.Show("You caught the pig bacon tonight", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				startSoundPlayer.Play();
			}
			else 
			{
				attempts++;
				
				if (attempts >= 5)
			{
				label2.Text = "The pig got away get quick";
				label2.Visible = true;
				MessageBox.Show("The pig got away get quick", "Player status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				startSoundPlayer2.Play();
			}
			if (time2 == 0)
			{
				timer1.Enabled = false;
			}
				
			}
			
			string att = attempts.ToString();
			label5.Text = att; 
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
