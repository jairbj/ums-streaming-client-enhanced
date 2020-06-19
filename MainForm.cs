///////////////////////////////////////////////////////////////////////////////
/// This code is provided for demonstration purposes only. 
/// There's only minimal error checking and the code does not
/// meet production quality standards. Use it at your own risk.
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StreamingClient
{
	public enum TransportMethod {Unicast = 0, Multicast = 1};
	public enum ConnectionProtocol {TCP = 0, HTTP = 1, RTP = 2};
	public enum PlayMode {File = 0, Live = 1, PlayList = 2};
	public enum ViewSize {HalfSize = 1, OriginalSize = 2, DoubleSize = 3, FullScreen = 4};

	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		///  Media Player's parameters
		/// </summary>
		public struct PlayerParams
		{
			public string             m_MediaServerAddress;
			public string             m_MediaFileLocation;
			public string             m_VirtualFolder;
			public string             m_LiveAddress;
			public string             m_Alias;
			public short              m_LiveID;
			public TransportMethod    m_Transport;
			public ConnectionProtocol m_Protocol;
		}

		private System.ComponentModel.IContainer  components;
		private System.Windows.Forms.MainMenu     mainMenu1;		

		private System.Windows.Forms.Timer        m_GCTimer;

		private System.Windows.Forms.MenuItem     m_menuSize;
		private System.Windows.Forms.MenuItem     m_menuViewHalfSize;
		private System.Windows.Forms.MenuItem     m_menuViewOriginalSize;
		private System.Windows.Forms.MenuItem     m_menuViewDoubleSize;
		private System.Windows.Forms.MenuItem     m_menuViewFullScreen;
		private System.Windows.Forms.MenuItem     m_menuMedia;				
		private System.Windows.Forms.MenuItem     m_menuViewRemoteFile;
		private System.Windows.Forms.MenuItem     m_menuViewRemoteLive;
		private System.Windows.Forms.MenuItem     m_menuAbout;		
		private System.Windows.Forms.MenuItem     m_menuProperties;
		private System.Windows.Forms.MenuItem     m_menuVideoSettings;
		private System.Windows.Forms.MenuItem     m_menuView;
		private System.Windows.Forms.MenuItem     m_menuHelp;
		private PlayerParams                      m_Params;
		private System.Windows.Forms.MenuItem	  m_ViewPlayList;
		private PlayMode                          m_PlayMode;
        private int m_XExtent;
        private AxUMediaControlLib.AxUMediaPlayer m_Player;
		private	int							      m_YExtent;

		public MainForm()
		{
			InitializeComponent();
			m_GCTimer.Start();
			m_XExtent = this.Size.Width - m_Player.Width;
			m_YExtent = this.Size.Height - m_Player.Height;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_GCTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.m_menuMedia = new System.Windows.Forms.MenuItem();
            this.m_menuViewRemoteFile = new System.Windows.Forms.MenuItem();
            this.m_menuViewRemoteLive = new System.Windows.Forms.MenuItem();
            this.m_ViewPlayList = new System.Windows.Forms.MenuItem();
            this.m_menuView = new System.Windows.Forms.MenuItem();
            this.m_menuSize = new System.Windows.Forms.MenuItem();
            this.m_menuViewHalfSize = new System.Windows.Forms.MenuItem();
            this.m_menuViewOriginalSize = new System.Windows.Forms.MenuItem();
            this.m_menuViewDoubleSize = new System.Windows.Forms.MenuItem();
            this.m_menuViewFullScreen = new System.Windows.Forms.MenuItem();
            this.m_menuProperties = new System.Windows.Forms.MenuItem();
            this.m_menuVideoSettings = new System.Windows.Forms.MenuItem();
            this.m_menuHelp = new System.Windows.Forms.MenuItem();
            this.m_menuAbout = new System.Windows.Forms.MenuItem();
            this.m_Player = new AxUMediaControlLib.AxUMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.m_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // m_GCTimer
            // 
            this.m_GCTimer.Enabled = true;
            this.m_GCTimer.Interval = 10000;
            this.m_GCTimer.Tick += new System.EventHandler(this.m_GCTimer_Tick);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_menuMedia,
            this.m_menuView,
            this.m_menuHelp});
            // 
            // m_menuMedia
            // 
            this.m_menuMedia.Index = 0;
            this.m_menuMedia.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_menuViewRemoteFile,
            this.m_menuViewRemoteLive,
            this.m_ViewPlayList});
            this.m_menuMedia.Text = "&Media";
            // 
            // m_menuViewRemoteFile
            // 
            this.m_menuViewRemoteFile.Index = 0;
            this.m_menuViewRemoteFile.Text = "Play Remote &File...";
            this.m_menuViewRemoteFile.Click += new System.EventHandler(this.ViewRemoteFile_Click);
            // 
            // m_menuViewRemoteLive
            // 
            this.m_menuViewRemoteLive.Index = 1;
            this.m_menuViewRemoteLive.Text = "Play Remote &Live Source...";
            this.m_menuViewRemoteLive.Click += new System.EventHandler(this.ViewRemoteLive_Click);
            // 
            // m_ViewPlayList
            // 
            this.m_ViewPlayList.Index = 2;
            this.m_ViewPlayList.Text = "Play Remote &Playlist...";
            this.m_ViewPlayList.Click += new System.EventHandler(this.OnViewPlayList_Click);
            // 
            // m_menuView
            // 
            this.m_menuView.Index = 1;
            this.m_menuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_menuSize,
            this.m_menuProperties,
            this.m_menuVideoSettings});
            this.m_menuView.Text = "&View";
            // 
            // m_menuSize
            // 
            this.m_menuSize.Enabled = false;
            this.m_menuSize.Index = 0;
            this.m_menuSize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_menuViewHalfSize,
            this.m_menuViewOriginalSize,
            this.m_menuViewDoubleSize,
            this.m_menuViewFullScreen});
            this.m_menuSize.Text = "Size";
            // 
            // m_menuViewHalfSize
            // 
            this.m_menuViewHalfSize.Index = 0;
            this.m_menuViewHalfSize.RadioCheck = true;
            this.m_menuViewHalfSize.Text = "50%";
            this.m_menuViewHalfSize.Click += new System.EventHandler(this.OnViewHalfSize);
            // 
            // m_menuViewOriginalSize
            // 
            this.m_menuViewOriginalSize.Index = 1;
            this.m_menuViewOriginalSize.RadioCheck = true;
            this.m_menuViewOriginalSize.Text = "100%";
            this.m_menuViewOriginalSize.Click += new System.EventHandler(this.OnViewOriginalSize);
            // 
            // m_menuViewDoubleSize
            // 
            this.m_menuViewDoubleSize.Index = 2;
            this.m_menuViewDoubleSize.RadioCheck = true;
            this.m_menuViewDoubleSize.Text = "200%";
            this.m_menuViewDoubleSize.Click += new System.EventHandler(this.OnViewDoubleSize);
            // 
            // m_menuViewFullScreen
            // 
            this.m_menuViewFullScreen.Index = 3;
            this.m_menuViewFullScreen.RadioCheck = true;
            this.m_menuViewFullScreen.Text = "Full Screen";
            this.m_menuViewFullScreen.Click += new System.EventHandler(this.OnViewFullScreen);
            // 
            // m_menuProperties
            // 
            this.m_menuProperties.Enabled = false;
            this.m_menuProperties.Index = 1;
            this.m_menuProperties.Text = "&Properties";
            this.m_menuProperties.Click += new System.EventHandler(this.OnViewProperties);
            // 
            // m_menuVideoSettings
            // 
            this.m_menuVideoSettings.Enabled = false;
            this.m_menuVideoSettings.Index = 2;
            this.m_menuVideoSettings.Text = "Video &Settings...";
            this.m_menuVideoSettings.Click += new System.EventHandler(this.OnVideoSettings);
            // 
            // m_menuHelp
            // 
            this.m_menuHelp.Index = 2;
            this.m_menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.m_menuAbout});
            this.m_menuHelp.Text = "&Help";
            // 
            // m_menuAbout
            // 
            this.m_menuAbout.Index = 0;
            this.m_menuAbout.Text = "Streaming Media Player C# Sample";
            // 
            // m_Player
            // 
            this.m_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_Player.Enabled = true;
            this.m_Player.Location = new System.Drawing.Point(0, 0);
            this.m_Player.Name = "m_Player";
            this.m_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("m_Player.OcxState")));
            this.m_Player.Size = new System.Drawing.Size(320, 200);
            this.m_Player.TabIndex = 0;
            this.m_Player.OnResize += new AxUMediaControlLib._IUMediaPlayerEvents_OnResizeEventHandler(this.OnPlayerResize);
            this.m_Player.OnStart += new System.EventHandler(this.OnPlayerStart);
            this.m_Player.OnPause += new AxUMediaControlLib._IUMediaPlayerEvents_OnPauseEventHandler(this.OnPlayerPause);
            this.m_Player.OnStop += new AxUMediaControlLib._IUMediaPlayerEvents_OnStopEventHandler(this.OnPlayerStop);
            this.m_Player.OnError += new AxUMediaControlLib._IUMediaPlayerEvents_OnErrorEventHandler(this.OnPlayerError);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.m_Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Streaming Player c# Sample";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.MenuStart += new System.EventHandler(this.OnMenuStart);
            ((System.ComponentModel.ISupportInitialize)(this.m_Player)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

		private void ResizeForm(int nWidth, int nHeight)
		{
			this.Size = new Size(nWidth + m_XExtent, nHeight + m_YExtent);
			
			m_Player.Width  = nWidth;
			m_Player.Height = nHeight;
		}

		private void CheckViewMenuItems(ViewSize Size)
		{
			switch (Size)
			{
				case ViewSize.HalfSize:     m_menuViewHalfSize.Checked     = true; 
							                m_menuViewOriginalSize.Checked = false;
							                m_menuViewDoubleSize.Checked   = false;
							                break;

				case ViewSize.OriginalSize: m_menuViewHalfSize.Checked     = false; 
							                m_menuViewOriginalSize.Checked = true;
					                        m_menuViewDoubleSize.Checked   = false;
					                        break;

				case ViewSize.DoubleSize:   m_menuViewHalfSize.Checked     = false; 
					  			            m_menuViewOriginalSize.Checked = false;
								            m_menuViewDoubleSize.Checked   = true;
								            break;
			}
		}

		private void EnableViewMenu(bool bEnable)
		{
			bool bVideoParams = bEnable;
			if (bEnable)
			{
				bVideoParams = m_Player.VideoExists;
			}

			m_menuSize.Enabled          = bVideoParams;			
			m_menuVideoSettings.Enabled = bVideoParams;
			m_menuProperties.Enabled    = bEnable;
		}

		private void LoadLive()
		{
			m_PlayMode = PlayMode.Live;
			m_Params.m_LiveID = 1;

			m_Params.m_Alias = Properties.Settings.Default.LiveAlias;
			m_Params.m_MediaServerAddress = Properties.Settings.Default.LiveIP;
			m_Params.m_Transport = (Properties.Settings.Default.LiveDeliveryMethod == "Unicast") ? TransportMethod.Unicast : TransportMethod.Multicast;

			if (Properties.Settings.Default.LiveTransport == "TCP")
			{
				m_Params.m_Protocol = ConnectionProtocol.TCP;
			}
			else if (Properties.Settings.Default.LiveTransport == "HTTP")
			{
				m_Params.m_Protocol = ConnectionProtocol.HTTP;
			}
			else if (Properties.Settings.Default.LiveTransport == "RTP")
			{
				m_Params.m_Protocol = ConnectionProtocol.RTP;
			}
		}
		private void Play()
		{
			try
			{
				m_Player.Stop();
				m_Player.UseMediaServer(m_Params.m_MediaServerAddress);				

				switch (m_Params.m_Protocol)
				{
					case ConnectionProtocol.TCP:  m_Player.UseTCP(); break;
					case ConnectionProtocol.HTTP: m_Player.UseHTTP(); break;
					case ConnectionProtocol.RTP: 
					if(m_Params.m_Transport == TransportMethod.Unicast)
						m_Player.UseRTPUnicast(); 
					else
						m_Player.UseRTPMulticast(); 
					break;
				}

				switch (m_PlayMode)
				{
					case PlayMode.Live:		m_Player.UseLiveAlias(m_Params.m_Alias); break;
					case PlayMode.File:     m_Player.UseFile(m_Params.m_MediaFileLocation); break;
					case PlayMode.PlayList: m_Player.UseFilePlayList(m_Params.m_VirtualFolder); break;
				}

				this.Text = "Connecting...";
				m_Player.Play();				
			}
			catch (Exception)
			{
				MessageBox.Show("Unexpected error", "C# Media Player", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void OnPlayerStart(object sender, System.EventArgs e)
		{
			m_Player.AdjustVolume(100);

			if ((m_PlayMode == PlayMode.Live) && Properties.Settings.Default.LivePlayFullscreen)
            {
				m_Player.ViewFullScreenSize();
            }
			
			EnableViewMenu(true);
			this.Text = "Playing";
		}

		private void OnPlayerStop(object sender, AxUMediaControlLib._IUMediaPlayerEvents_OnStopEvent e)
		{	
			if (e.bToBeContinued != 1)
			{
				ResizeForm(320, 240);
			}

			EnableViewMenu(false);
			this.Text = "Streaming Player c# Sample";
		}

		private void OnPlayerResize(object sender, AxUMediaControlLib._IUMediaPlayerEvents_OnResizeEvent e)
		{
			ResizeForm(e.nWidth, e.nHeight);
		}

		private void OnPlayerPause(object sender, AxUMediaControlLib._IUMediaPlayerEvents_OnPauseEvent e)
		{
			this.Text = "Paused";
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Visible = false;			
			m_GCTimer.Stop();	
		}

		private void m_GCTimer_Tick(object sender, System.EventArgs e)
		{
			GC.Collect();
		}

		private void ViewRemoteFile_Click(object sender, System.EventArgs e)
		{
			ViewRemoteFileForm ViewForm = new ViewRemoteFileForm(ref m_Params);
			ViewForm.Icon = null;
			
			ViewForm.ShowDialog(this);

			m_Params   = ViewForm.m_Params;
			m_PlayMode = PlayMode.File;

			if (ViewForm.DialogResult == DialogResult.OK)
			{
				Play();
			}
		}

		private void OnViewPlayList_Click(object sender, System.EventArgs e)
		{
			PlayListForm PlayListForm = new PlayListForm(ref m_Params);
			PlayListForm.Icon = null;

			PlayListForm.ShowDialog(this);

			m_Params   = PlayListForm.m_Params;
			m_PlayMode = PlayMode.PlayList;
			if (PlayListForm.DialogResult == DialogResult.OK)
			{	
				Play();
			}
		}

		private void ViewRemoteLive_Click(object sender, System.EventArgs e)
		{
			ViewRemoteLiveForm ViewForm = new ViewRemoteLiveForm(ref m_Params);
			ViewForm.Icon = null;

			ViewForm.ShowDialog(this);

			m_Params   = ViewForm.m_Params;
			m_PlayMode = PlayMode.Live;

			if (ViewForm.DialogResult == DialogResult.OK)
			{
				LoadLive();
				Play();
			}
		}

		private void OnFormLoad(object sender, System.EventArgs e)
		{
			if (m_Player != null)
			{
				m_Player.EnableFlowControl(true, true);
				m_Player.UseCustomErrorHandler(true);
				if (Properties.Settings.Default.LiveAutoStart)
                {
					LoadLive();
					Play();
                }
			}
		}

		private void OnViewHalfSize(object sender, System.EventArgs e)
		{
			m_Player.ViewHalfSize();
			CheckViewMenuItems(ViewSize.HalfSize);
		}

		private void OnViewOriginalSize(object sender, System.EventArgs e)
		{			
			m_Player.ViewOriginalSize();
			CheckViewMenuItems(ViewSize.OriginalSize);
		}

		private void OnViewDoubleSize(object sender, System.EventArgs e)
		{
			m_Player.ViewDoubleSize();
			CheckViewMenuItems(ViewSize.DoubleSize);
		}

		private void OnViewFullScreen(object sender, System.EventArgs e)
		{
			m_Player.ViewFullScreenSize();
		}

		private void OnViewProperties(object sender, System.EventArgs e)
		{
			m_Player.ViewProperties();
		}

		private void OnVideoSettings(object sender, System.EventArgs e)
		{
			m_Player.ViewVideoSettings();
		}

		private void OnMenuStart(object sender, System.EventArgs e)
		{
			int nSizePerc = m_Player.VideoCurrentViewSize_Percent;
			
			if(nSizePerc == 100)
				CheckViewMenuItems(ViewSize.OriginalSize);
			else if (nSizePerc == 50)
				CheckViewMenuItems(ViewSize.HalfSize);
			else if (nSizePerc == 200)
				CheckViewMenuItems(ViewSize.DoubleSize);
			else
			{
				m_menuViewHalfSize.Checked     = false; 
				m_menuViewOriginalSize.Checked = false;
				m_menuViewDoubleSize.Checked   = false;
			}
		}

        private void OnPlayerError(object sender, AxUMediaControlLib._IUMediaPlayerEvents_OnErrorEvent e)
        {
			if (Properties.Settings.Default.LiveAutoReconnect)
            {
				Play();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
			m_Player.Stop();
        }
    }
}
