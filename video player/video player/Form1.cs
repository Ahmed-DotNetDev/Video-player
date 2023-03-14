using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_player
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnsetlocation_Click(object sender, EventArgs e)
		{
			if(File.Exists(txtpath.Text))
			{
				formplayer.URL = txtpath.Text;
			}
			else
			{
				MessageBox.Show("File not found");
			}
		}

		private void btnplay_Click(object sender, EventArgs e)
		{
			formplayer.Ctlcontrols.play();
		}

		private void btnstop_Click(object sender, EventArgs e)
		{
			formplayer.Ctlcontrols.stop();
		}

		private void btnexit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtpath_TextChanged(object sender, EventArgs e)
		{
			if(txtpath.Text== "name.type")
			{
				txtpath.Text = " ";
			}
		}
	}
}
