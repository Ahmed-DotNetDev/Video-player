namespace video_player
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnsetlocation = new System.Windows.Forms.Button();
			this.txtpath = new System.Windows.Forms.TextBox();
			this.formplayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.btnstop = new System.Windows.Forms.Button();
			this.btnplay = new System.Windows.Forms.Button();
			this.btnexit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.formplayer)).BeginInit();
			this.SuspendLayout();
			// 
			// btnsetlocation
			// 
			this.btnsetlocation.BackColor = System.Drawing.Color.Yellow;
			this.btnsetlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnsetlocation.Location = new System.Drawing.Point(611, 105);
			this.btnsetlocation.Name = "btnsetlocation";
			this.btnsetlocation.Size = new System.Drawing.Size(141, 37);
			this.btnsetlocation.TabIndex = 1;
			this.btnsetlocation.Text = "Set Path";
			this.btnsetlocation.UseVisualStyleBackColor = false;
			this.btnsetlocation.Click += new System.EventHandler(this.btnsetlocation_Click);
			// 
			// txtpath
			// 
			this.txtpath.BackColor = System.Drawing.SystemColors.HotTrack;
			this.txtpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.txtpath.ForeColor = System.Drawing.Color.Gray;
			this.txtpath.Location = new System.Drawing.Point(571, 12);
			this.txtpath.Name = "txtpath";
			this.txtpath.Size = new System.Drawing.Size(217, 38);
			this.txtpath.TabIndex = 2;
			this.txtpath.Text = "name.type";
			this.txtpath.TextChanged += new System.EventHandler(this.txtpath_TextChanged);
			// 
			// formplayer
			// 
			this.formplayer.Enabled = true;
			this.formplayer.Location = new System.Drawing.Point(0, -1);
			this.formplayer.Name = "formplayer";
			this.formplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("formplayer.OcxState")));
			this.formplayer.Size = new System.Drawing.Size(565, 451);
			this.formplayer.TabIndex = 0;
			// 
			// btnstop
			// 
			this.btnstop.BackColor = System.Drawing.Color.IndianRed;
			this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnstop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnstop.Location = new System.Drawing.Point(611, 267);
			this.btnstop.Name = "btnstop";
			this.btnstop.Size = new System.Drawing.Size(141, 37);
			this.btnstop.TabIndex = 3;
			this.btnstop.Text = "Stop";
			this.btnstop.UseVisualStyleBackColor = false;
			this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
			// 
			// btnplay
			// 
			this.btnplay.BackColor = System.Drawing.Color.ForestGreen;
			this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnplay.Location = new System.Drawing.Point(611, 184);
			this.btnplay.Name = "btnplay";
			this.btnplay.Size = new System.Drawing.Size(141, 37);
			this.btnplay.TabIndex = 4;
			this.btnplay.Text = "Play";
			this.btnplay.UseVisualStyleBackColor = false;
			this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
			// 
			// btnexit
			// 
			this.btnexit.BackColor = System.Drawing.Color.Red;
			this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnexit.Location = new System.Drawing.Point(611, 334);
			this.btnexit.Name = "btnexit";
			this.btnexit.Size = new System.Drawing.Size(141, 37);
			this.btnexit.TabIndex = 5;
			this.btnexit.Text = "Exit";
			this.btnexit.UseVisualStyleBackColor = false;
			this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(800, 451);
			this.Controls.Add(this.btnexit);
			this.Controls.Add(this.btnplay);
			this.Controls.Add(this.btnstop);
			this.Controls.Add(this.txtpath);
			this.Controls.Add(this.btnsetlocation);
			this.Controls.Add(this.formplayer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.formplayer)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer formplayer;
		private System.Windows.Forms.Button btnsetlocation;
		private System.Windows.Forms.TextBox txtpath;
		private System.Windows.Forms.Button btnstop;
		private System.Windows.Forms.Button btnplay;
		private System.Windows.Forms.Button btnexit;
	}
}

