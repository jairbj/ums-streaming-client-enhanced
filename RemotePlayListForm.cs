using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StreamingClient
{
	/// <summary>
	/// Summary description for PlayListForm.
	/// </summary>
	public class PlayListForm : System.Windows.Forms.Form
	{
		public MainForm.PlayerParams m_Params;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MediaServerIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton Unicast;
		private System.Windows.Forms.RadioButton Multicast;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton HTTPProt;
		private System.Windows.Forms.RadioButton TCPProt;
		private System.Windows.Forms.RadioButton RTPProt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox VirtualFolder;
		private System.Windows.Forms.Button OKBtn;
		private System.Windows.Forms.Button CancelBtn;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PlayListForm(ref MainForm.PlayerParams Params)
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.Multicast = new System.Windows.Forms.RadioButton();
			this.Unicast = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.TCPProt = new System.Windows.Forms.RadioButton();
			this.HTTPProt = new System.Windows.Forms.RadioButton();
			this.RTPProt = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.VirtualFolder = new System.Windows.Forms.TextBox();
			this.OKBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Media Server IP address or Internet name";
			// 
			// MediaServerIP
			// 
			this.MediaServerIP.Location = new System.Drawing.Point(140, 17);
			this.MediaServerIP.Name = "MediaServerIP";
			this.MediaServerIP.Size = new System.Drawing.Size(172, 20);
			this.MediaServerIP.TabIndex = 1;
			this.MediaServerIP.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Delivery method";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Multicast);
			this.panel1.Controls.Add(this.Unicast);
			this.panel1.Location = new System.Drawing.Point(136, 45);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 32);
			this.panel1.TabIndex = 3;
			// 
			// Multicast
			// 
			this.Multicast.Location = new System.Drawing.Point(73, 8);
			this.Multicast.Name = "Multicast";
			this.Multicast.Size = new System.Drawing.Size(120, 16);
			this.Multicast.TabIndex = 1;
			this.Multicast.Text = "Multicast (LAN)";
			this.Multicast.CheckedChanged += new System.EventHandler(this.Multicast_CheckedChanged);
			// 
			// Unicast
			// 
			this.Unicast.Location = new System.Drawing.Point(6, 8);
			this.Unicast.Name = "Unicast";
			this.Unicast.Size = new System.Drawing.Size(66, 16);
			this.Unicast.TabIndex = 0;
			this.Unicast.Text = "Unicast";
			this.Unicast.CheckedChanged += new System.EventHandler(this.Unicast_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Transport protocol";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.TCPProt);
			this.panel2.Controls.Add(this.HTTPProt);
			this.panel2.Controls.Add(this.RTPProt);
			this.panel2.Location = new System.Drawing.Point(136, 80);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(176, 32);
			this.panel2.TabIndex = 5;
			// 
			// TCPProt
			// 
			this.TCPProt.Location = new System.Drawing.Point(73, 8);
			this.TCPProt.Name = "TCPProt";
			this.TCPProt.Size = new System.Drawing.Size(51, 16);
			this.TCPProt.TabIndex = 1;
			this.TCPProt.Text = "TCP";
			// 
			// HTTPProt
			// 
			this.HTTPProt.Location = new System.Drawing.Point(6, 8);
			this.HTTPProt.Name = "HTTPProt";
			this.HTTPProt.Size = new System.Drawing.Size(56, 16);
			this.HTTPProt.TabIndex = 0;
			this.HTTPProt.Text = "HTTP";
			// 
			// RTPProt
			// 
			this.RTPProt.Location = new System.Drawing.Point(128, 8);
			this.RTPProt.Name = "RTPProt";
			this.RTPProt.Size = new System.Drawing.Size(48, 16);
			this.RTPProt.TabIndex = 2;
			this.RTPProt.Text = "RTP";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Virtual folder name";
			// 
			// VirtualFolder
			// 
			this.VirtualFolder.Location = new System.Drawing.Point(140, 120);
			this.VirtualFolder.Name = "VirtualFolder";
			this.VirtualFolder.Size = new System.Drawing.Size(172, 20);
			this.VirtualFolder.TabIndex = 7;
			this.VirtualFolder.Text = "";
			// 
			// OKBtn
			// 
			this.OKBtn.Location = new System.Drawing.Point(170, 152);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new System.Drawing.Size(64, 23);
			this.OKBtn.TabIndex = 8;
			this.OKBtn.Text = "&OK";
			this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(248, 152);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(64, 23);
			this.CancelBtn.TabIndex = 9;
			this.CancelBtn.Text = "&Cancel";
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// PlayListForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(322, 183);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.OKBtn);
			this.Controls.Add(this.VirtualFolder);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MediaServerIP);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PlayListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Play Remote Playlist";
			this.Load += new System.EventHandler(this.PlayListForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void PlayListForm_Load(object sender, System.EventArgs e)
		{
			MediaServerIP.Text = m_Params.m_MediaServerAddress;
			VirtualFolder.Text = m_Params.m_VirtualFolder;
			Unicast.Checked    = (m_Params.m_Transport == TransportMethod.Unicast);
			Multicast.Checked  = (m_Params.m_Transport == TransportMethod.Multicast);			
			TCPProt.Checked    = (m_Params.m_Protocol == ConnectionProtocol.TCP);
			HTTPProt.Checked   = (m_Params.m_Protocol == ConnectionProtocol.HTTP);
			RTPProt.Checked    = (m_Params.m_Protocol == ConnectionProtocol.RTP);
		}

		private void Unicast_CheckedChanged(object sender, System.EventArgs e)
		{
			TCPProt.Enabled  = true;
			HTTPProt.Enabled = true;
			TCPProt.Checked  = true;
		}

		private void Multicast_CheckedChanged(object sender, System.EventArgs e)
		{
			TCPProt.Enabled  = false;
			HTTPProt.Enabled = false;
			RTPProt.Checked  = true;
		}

		private void OKBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			
			m_Params.m_MediaServerAddress = MediaServerIP.Text;
			m_Params.m_Transport = Unicast.Checked ? TransportMethod.Unicast : TransportMethod.Multicast;
			m_Params.m_VirtualFolder = VirtualFolder.Text;

			if (TCPProt.Checked)
			{
				m_Params.m_Protocol = ConnectionProtocol.TCP;
			}
			else if (HTTPProt.Checked)
			{
				m_Params.m_Protocol = ConnectionProtocol.HTTP;
			} 
			else if (RTPProt.Checked)
			{
				m_Params.m_Protocol = ConnectionProtocol.RTP;
			}

			this.Close();
		}

		private void CancelBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
