/*
 * Created by SharpDevelop.
 * User: Travis
 * Date: 3/2/2016
 * Time: 10:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Sound_test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private SoundPlayer _soundplayer;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			private SoundPlayer _soundplayer;
		
			_soundplayer = new SoundPlayer("Call On Me.wav"); 
			
			System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
player.Play();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
	
		}
		void DuelStatebuttonCheckedChanged(object sender, EventArgs e)
		{
			if (duelStatebutton.Checked)  
			{
				duelStatebutton.Text = "Stop";
				_soundplayer.Play();
			}
			
				else 
			{
					duelStatebutton.Text = "Play";
				_soundplayer.Stop();
					
			}
		}
	}
}

