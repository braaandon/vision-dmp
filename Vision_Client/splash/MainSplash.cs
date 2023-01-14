using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using Vision_Client.limiter;

namespace Vision_Client.splash
{
	// Token: 0x02000013 RID: 19
	public partial class MainSplash : Form
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00017D26 File Offset: 0x00017D26
		public MainSplash()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00017D54 File Offset: 0x00017D54
		private void timer1_Tick(object sender, EventArgs e)
		{
			Thread.Sleep(100);
			this.timer1.Enabled = true;
			this.ProgressBar.Increment(5);
			bool flag = this.ProgressBar.Value == 100;
			if (flag)
			{
				this.timer1.Enabled = false;
				base.Hide();
				NLConfig cfg = Program.cfg;
				bool flag2 = Program.account != null;
				if (flag2)
				{
					bool flag3 = cfg.theme == "Woof";
					if (flag3)
					{
						base.Hide();
						WoofSplash woofSplash = new WoofSplash();
						woofSplash.ShowDialog();
						base.Dispose();
					}
					else
					{
						base.Hide();
						VisionSplash visionSplash = new VisionSplash();
						visionSplash.ShowDialog();
						base.Dispose();
					}
				}
				else
				{
					StartupForm startupForm = new StartupForm();
					startupForm.ShowDialog();
					base.Dispose();
				}
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00017E34 File Offset: 0x00017E34
		private void timer2_Tick(object sender, EventArgs e)
		{
			bool flag = base.Opacity == 1.0;
			if (flag)
			{
				this.timer2.Stop();
			}
			base.Opacity += 0.2;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00017E7C File Offset: 0x00017E7C
		private void guna2PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00017E80 File Offset: 0x00017E80
		private void MainSplash_Load(object sender, EventArgs e)
		{
			MainSplash.KeyAuthApp.init();
			MainSplash.KeyAuthApp.check();
			bool flag = MainSplash.KeyAuthApp.checkblack();
			if (flag)
			{
				Environment.Exit(0);
			}
			bool flag2 = MainSplash.KeyAuthApp.response.message == "invalidver";
			if (flag2)
			{
				this.timer1.Enabled = false;
				bool flag3 = !string.IsNullOrEmpty(MainSplash.KeyAuthApp.app_data.downloadLink);
				if (flag3)
				{
					DialogResult dialogResult = MessageBox.Show("Yes to download Vision in browser?\nNo to attempt to download Vision automatically", "New Vision Client found!", MessageBoxButtons.YesNoCancel);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.Cancel)
					{
						if (dialogResult3 != DialogResult.Yes)
						{
							if (dialogResult3 != DialogResult.No)
							{
								MessageBox.Show("Invalid option");
								Environment.Exit(0);
							}
							else
							{
								WebClient webClient = new WebClient();
								string text = Application.ExecutablePath;
								string str = MainSplash.random_string();
								text = text.Replace(".exe", "-" + str + ".exe");
								webClient.DownloadFile(MainSplash.KeyAuthApp.app_data.downloadLink, text);
								Process.Start(text);
								Process.Start(new ProcessStartInfo
								{
									Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
									WindowStyle = ProcessWindowStyle.Hidden,
									CreateNoWindow = true,
									FileName = "cmd.exe"
								});
								Environment.Exit(0);
							}
						}
						else
						{
							Process.Start(MainSplash.KeyAuthApp.app_data.downloadLink);
							Environment.Exit(0);
						}
					}
					else
					{
						Environment.Exit(0);
					}
				}
				MessageBox.Show("You will need to manually obtain the download link from the developer");
				Environment.Exit(0);
			}
			this.txts = this.scroll.Text;
			this.mimic = this.txts.Length;
			this.scroll.Text = "";
			NLConfig cfg = Program.cfg;
			bool flag4 = cfg.theme == "Woof";
			if (flag4)
			{
				this.guna2GradientPanel2.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
				this.ProgressBar.FillColor = Color.Black;
				this.ProgressBar.ProgressColor = Color.FromArgb(185, 93, 255);
				this.ProgressBar.ProgressColor2 = Color.FromArgb(148, 6, 255);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000180F4 File Offset: 0x000180F4
		private static string random_string()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00018160 File Offset: 0x00018160
		private void timer3_Tick(object sender, EventArgs e)
		{
			this.counter++;
			bool flag = this.counter > this.mimic;
			if (flag)
			{
				this.counter = 0;
				this.scroll.Text = "";
			}
			else
			{
				this.scroll.Text = this.txts.Substring(0, this.counter);
				bool flag2 = this.scroll.ForeColor == Color.White;
				if (flag2)
				{
					this.scroll.ForeColor = Color.White;
				}
				else
				{
					this.scroll.ForeColor = Color.White;
				}
			}
		}

		// Token: 0x0400013C RID: 316
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");

		// Token: 0x0400013D RID: 317
		private int counter = 0;

		// Token: 0x0400013E RID: 318
		private int mimic = 0;

		// Token: 0x0400013F RID: 319
		private string txts;
	}
}
