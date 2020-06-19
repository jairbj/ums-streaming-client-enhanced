using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StreamingClient
{
	/// <summary>
	/// Summary description for RemoteLive.
	/// </summary>
	public class ViewRemoteLiveForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MediaServerIP;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AliasName;
		private System.Windows.Forms.Button OKBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button CancelBtn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton TCPProt;
		private System.Windows.Forms.RadioButton HTTPProt;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton RTPProt;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton Unicast;
		private System.Windows.Forms.RadioButton Multicast;
        private CheckBox AutoReconnect;
        private CheckBox AutoStart;
        private CheckBox PlayFullscreen;
        public MainForm.PlayerParams m_Params;

		public ViewRemoteLiveForm(ref MainForm.PlayerParams Params)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.m_Params = Params;
			this.AcceptButton = OKBtn;
			this.CancelButton = CancelBtn;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.MediaServerIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AliasName = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TCPProt = new System.Windows.Forms.RadioButton();
            this.HTTPProt = new System.Windows.Forms.RadioButton();
            this.RTPProt = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Multicast = new System.Windows.Forms.RadioButton();
            this.Unicast = new System.Windows.Forms.RadioButton();
            this.AutoReconnect = new System.Windows.Forms.CheckBox();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.PlayFullscreen = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media server IP address or Internet name";
            // 
            // MediaServerIP
            // 
            this.MediaServerIP.Location = new System.Drawing.Point(144, 11);
            this.MediaServerIP.Name = "MediaServerIP";
            this.MediaServerIP.Size = new System.Drawing.Size(160, 20);
            this.MediaServerIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transport protocol";
            // 
            // AliasName
            // 
            this.AliasName.Location = new System.Drawing.Point(144, 122);
            this.AliasName.Name = "AliasName";
            this.AliasName.Size = new System.Drawing.Size(160, 20);
            this.AliasName.TabIndex = 11;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(160, 157);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(64, 24);
            this.OKBtn.TabIndex = 12;
            this.OKBtn.Text = "&OK";
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Live broadcast alias ";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(240, 157);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(64, 24);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TCPProt);
            this.panel1.Controls.Add(this.HTTPProt);
            this.panel1.Controls.Add(this.RTPProt);
            this.panel1.Location = new System.Drawing.Point(136, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 32);
            this.panel1.TabIndex = 3;
            // 
            // TCPProt
            // 
            this.TCPProt.Location = new System.Drawing.Point(72, 8);
            this.TCPProt.Name = "TCPProt";
            this.TCPProt.Size = new System.Drawing.Size(48, 24);
            this.TCPProt.TabIndex = 5;
            this.TCPProt.TabStop = true;
            this.TCPProt.Text = "TCP";
            // 
            // HTTPProt
            // 
            this.HTTPProt.Location = new System.Drawing.Point(8, 8);
            this.HTTPProt.Name = "HTTPProt";
            this.HTTPProt.Size = new System.Drawing.Size(56, 24);
            this.HTTPProt.TabIndex = 4;
            this.HTTPProt.TabStop = true;
            this.HTTPProt.Text = "HTTP";
            // 
            // RTPProt
            // 
            this.RTPProt.Location = new System.Drawing.Point(128, 8);
            this.RTPProt.Name = "RTPProt";
            this.RTPProt.Size = new System.Drawing.Size(48, 24);
            this.RTPProt.TabIndex = 6;
            this.RTPProt.Text = "RTP";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delivery method";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Multicast);
            this.panel2.Controls.Add(this.Unicast);
            this.panel2.Location = new System.Drawing.Point(136, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 29);
            this.panel2.TabIndex = 17;
            // 
            // Multicast
            // 
            this.Multicast.Location = new System.Drawing.Point(72, 11);
            this.Multicast.Name = "Multicast";
            this.Multicast.Size = new System.Drawing.Size(104, 16);
            this.Multicast.TabIndex = 1;
            this.Multicast.Text = "Multicast (LAN)";
            this.Multicast.CheckedChanged += new System.EventHandler(this.Multicast_CheckedChanged);
            // 
            // Unicast
            // 
            this.Unicast.Location = new System.Drawing.Point(8, 11);
            this.Unicast.Name = "Unicast";
            this.Unicast.Size = new System.Drawing.Size(64, 16);
            this.Unicast.TabIndex = 0;
            this.Unicast.Text = "Unicast";
            this.Unicast.CheckedChanged += new System.EventHandler(this.Unicats_CheckedChanged);
            // 
            // AutoReconnect
            // 
            this.AutoReconnect.AutoSize = true;
            this.AutoReconnect.Location = new System.Drawing.Point(9, 146);
            this.AutoReconnect.Name = "AutoReconnect";
            this.AutoReconnect.Size = new System.Drawing.Size(104, 17);
            this.AutoReconnect.TabIndex = 18;
            this.AutoReconnect.Text = "Auto Reconnect";
            this.AutoReconnect.UseVisualStyleBackColor = true;
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(9, 167);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(73, 17);
            this.AutoStart.TabIndex = 19;
            this.AutoStart.Text = "Auto Start";
            this.AutoStart.UseVisualStyleBackColor = true;
            // 
            // PlayFullscreen
            // 
            this.PlayFullscreen.AutoSize = true;
            this.PlayFullscreen.Location = new System.Drawing.Point(9, 190);
            this.PlayFullscreen.Name = "PlayFullscreen";
            this.PlayFullscreen.Size = new System.Drawing.Size(97, 17);
            this.PlayFullscreen.TabIndex = 20;
            this.PlayFullscreen.Text = "Play Fullscreen";
            this.PlayFullscreen.UseVisualStyleBackColor = true;
            // 
            // ViewRemoteLiveForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(314, 224);
            this.Controls.Add(this.PlayFullscreen);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.AutoReconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.AliasName);
            this.Controls.Add(this.MediaServerIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewRemoteLiveForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Play remote live source";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewRemoteLiveForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void ViewRemoteLiveForm_Load(object sender, System.EventArgs e)
		{
            MediaServerIP.Text = Properties.Settings.Default.LiveIP;
            AliasName.Text = Properties.Settings.Default.LiveAlias;
            
            Unicast.Checked = (Properties.Settings.Default.LiveDeliveryMethod == "Unicast");
            Multicast.Checked = (Properties.Settings.Default.LiveDeliveryMethod == "Multicast");
            TCPProt.Checked = (Properties.Settings.Default.LiveTransport == "TCP");
            HTTPProt.Checked = (Properties.Settings.Default.LiveTransport == "HTTP");
            RTPProt.Checked = (Properties.Settings.Default.LiveTransport == "RTP");
            AutoReconnect.Checked = Properties.Settings.Default.LiveAutoReconnect;
            AutoStart.Checked = Properties.Settings.Default.LiveAutoStart;
            PlayFullscreen.Checked = Properties.Settings.Default.LivePlayFullscreen;

            if (m_Params.m_LiveID == 0)
			{
				m_Params.m_LiveID = 1; // Set Live ID #1 as default
			}
		}

		private void OKBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			
            Properties.Settings.Default.LivePlayFullscreen = PlayFullscreen.Checked;
            Properties.Settings.Default.LiveAutoReconnect = AutoReconnect.Checked;
            Properties.Settings.Default.LiveAutoStart = AutoStart.Checked;

            Properties.Settings.Default.LiveAlias = AliasName.Text;
            Properties.Settings.Default.LiveIP = MediaServerIP.Text;
            Properties.Settings.Default.LiveDeliveryMethod = "Unicast";
            if (Multicast.Checked)
            {
                Properties.Settings.Default.LiveDeliveryMethod = "Multicast";
            }

            if (TCPProt.Checked)
			{			
                Properties.Settings.Default.LiveTransport = "TCP";
            }
			else if (HTTPProt.Checked)
			{				
                Properties.Settings.Default.LiveTransport = "HTTP";
            } 
			else if (RTPProt.Checked)
			{				
                Properties.Settings.Default.LiveTransport = "RTP";
            }

            Properties.Settings.Default.Save();

            this.Close();
		}

		private void CancelBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();		
		}

		private void Unicats_CheckedChanged(object sender, System.EventArgs e)
		{
			HTTPProt.Enabled = true;
			TCPProt.Enabled  = true;
			TCPProt.Checked  = true;
		}

		private void Multicast_CheckedChanged(object sender, System.EventArgs e)
		{
			HTTPProt.Enabled = false;
			TCPProt.Enabled  = false;
			RTPProt.Checked  = true;
		}
	}
}
