using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StreamingClient
{	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ViewRemoteFileForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MediaServerIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton TCPProt;
		private System.Windows.Forms.RadioButton HTTPProt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FileLocation;
		private System.Windows.Forms.Button OKBtn;
		private System.Windows.Forms.Button CancelBtn;

		public MainForm.PlayerParams m_Params; // Remote File View parameters

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ViewRemoteFileForm(ref MainForm.PlayerParams Params)
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
            this.TCPProt = new System.Windows.Forms.RadioButton();
            this.HTTPProt = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Media Server IP address or Internet name";
            // 
            // MediaServerIP
            // 
            this.MediaServerIP.Location = new System.Drawing.Point(152, 15);
            this.MediaServerIP.Name = "MediaServerIP";
            this.MediaServerIP.Size = new System.Drawing.Size(128, 20);
            this.MediaServerIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connection protocol";
            // 
            // TCPProt
            // 
            this.TCPProt.Checked = true;
            this.TCPProt.Location = new System.Drawing.Point(152, 55);
            this.TCPProt.Name = "TCPProt";
            this.TCPProt.Size = new System.Drawing.Size(48, 16);
            this.TCPProt.TabIndex = 3;
            this.TCPProt.TabStop = true;
            this.TCPProt.Text = "TCP";
            // 
            // HTTPProt
            // 
            this.HTTPProt.Location = new System.Drawing.Point(224, 55);
            this.HTTPProt.Name = "HTTPProt";
            this.HTTPProt.Size = new System.Drawing.Size(56, 16);
            this.HTTPProt.TabIndex = 4;
            this.HTTPProt.Text = "HTTP";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "File location on media server (virtual)";
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(8, 108);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(272, 20);
            this.FileLocation.TabIndex = 6;
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(8, 136);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 7;
            this.OKBtn.Text = "&OK";
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(208, 136);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(72, 24);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ViewRemoteFileForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.MediaServerIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HTTPProt);
            this.Controls.Add(this.TCPProt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewRemoteFileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Remote File";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViewRemoteFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion		

		private void ViewRemoteFileForm_Load(object sender, System.EventArgs e)
		{
			MediaServerIP.Text = m_Params.m_MediaServerAddress;
			FileLocation.Text  = m_Params.m_MediaFileLocation;
			TCPProt.Checked    = (m_Params.m_Protocol == ConnectionProtocol.TCP);
			HTTPProt.Checked   = (m_Params.m_Protocol == ConnectionProtocol.HTTP);	

			if (!TCPProt.Checked && !HTTPProt.Checked)
			{
				TCPProt.Checked = true;
			}
		}

		private void OKBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			m_Params.m_MediaServerAddress = MediaServerIP.Text;
			m_Params.m_MediaFileLocation  = FileLocation.Text;
			m_Params.m_Protocol           = TCPProt.Checked ? ConnectionProtocol.TCP : ConnectionProtocol.HTTP;

			this.Close();
		}

		private void CancelBtn_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
