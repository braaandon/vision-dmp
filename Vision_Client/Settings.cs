using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.WinForms;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x0200000D RID: 13
	public partial class Settings : Form
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0000E338 File Offset: 0x0000E338
		public Settings()
		{
			this.InitializeComponent();
			NLConfig cfg = Program.cfg;
			this.filePath.Text = Program.cfg.AppPath;
			bool timerEnabled = cfg.timerEnabled;
			if (timerEnabled)
			{
				this.guna2Button1.FillColor = Color.FromArgb(121, 207, 97);
				this.guna2Button1.Text = "Timer: Enabled";
			}
			else
			{
				this.guna2Button1.FillColor = Color.FromArgb(255, 128, 128);
				this.guna2Button1.Text = "Timer: Disabled";
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000E400 File Offset: 0x0000E400
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			base.Hide();
			ThemeSelector themeSelector = new ThemeSelector();
			themeSelector.ShowDialog();
			base.Dispose();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000E42B File Offset: 0x0000E42B
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000E42E File Offset: 0x0000E42E
		private void guna2Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000E431 File Offset: 0x0000E431
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000E440 File Offset: 0x0000E440
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			base.Hide();
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Bruce";
			if (flag)
			{
				BruceVision bruceVision = new BruceVision(new Overlay());
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
				bruceVision.ShowDialog();
				base.Dispose();
			}
			else
			{
				bool flag2 = cfg.theme == "Woof";
				if (flag2)
				{
					Vision vision = new Vision(new Overlay());
					Program.setPresence("Browsing Modules", new Button[]
					{
						new Button
						{
							Label = "Server",
							Url = "https://discord.gg/woofs"
						}
					}, new Assets
					{
						LargeImageKey = "wooficon",
						LargeImageText = "",
						SmallImageKey = ""
					});
					vision.ShowDialog();
					base.Dispose();
				}
				else
				{
					Vision vision2 = new Vision(new Overlay());
					Program.setPresence("Browsing Modules", new Button[]
					{
						new Button
						{
							Label = "Server",
							Url = "https://discord.gg/woofs"
						}
					}, new Assets
					{
						LargeImageKey = "wooficon",
						LargeImageText = "",
						SmallImageKey = ""
					});
					vision2.ShowDialog();
					base.Dispose();
				}
			}
			base.Close();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000E5FC File Offset: 0x0000E5FC
		private void label1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this.label1.ForeColor == Color.White;
			if (flag)
			{
				this.label1.ForeColor = this.labelColor;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000E638 File Offset: 0x0000E638
		private void guna2Panel2_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this.label1.ForeColor == Color.White;
			if (flag)
			{
				this.label1.ForeColor = this.labelColor;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000E673 File Offset: 0x0000E673
		private void guna2Panel2_MouseLeave(object sender, EventArgs e)
		{
			this.label1.ForeColor = Color.White;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000E688 File Offset: 0x0000E688
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this.label1.ForeColor == Color.White;
			if (flag)
			{
				this.label1.ForeColor = this.labelColor;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000E6C3 File Offset: 0x0000E6C3
		private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000E6D1 File Offset: 0x0000E6D1
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000E6E0 File Offset: 0x0000E6E0
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = !Path.GetFileName(openFileDialog.FileName).Equals("destiny2.exe");
				if (flag2)
				{
					MessageBox.Show("Please select 'destiny2.exe'");
				}
				else
				{
					this.filePath.Text = Path.GetFullPath(openFileDialog.FileName);
					Program.cfg.changeAppPath(Path.GetFullPath(openFileDialog.FileName), Program.cfg);
					foreach (D2Filter d2Filter in Program.filters)
					{
						d2Filter.updateAppPath(openFileDialog.FileName);
					}
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000E7B4 File Offset: 0x0000E7B4
		private void guna2Button6_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E7B7 File Offset: 0x0000E7B7
		private void guna2Button6_MouseLeave(object sender, EventArgs e)
		{
			this.guna2Button6.ForeColor = Color.White;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E7CB File Offset: 0x0000E7CB
		private void guna2Button6_MouseEnter(object sender, EventArgs e)
		{
			this.guna2Button6.ForeColor = this.labelColor;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E7E0 File Offset: 0x0000E7E0
		private void guna2Button1_Click_1(object sender, EventArgs e)
		{
			NLConfig cfg = Program.cfg;
			bool flag = !cfg.timerEnabled;
			if (flag)
			{
				this.guna2Button1.FillColor = Color.FromArgb(121, 207, 97);
				this.guna2Button1.Text = "Timer: Enabled";
				cfg.changeTimerEnabled(!cfg.timerEnabled, cfg);
			}
			else
			{
				this.guna2Button1.FillColor = Color.FromArgb(255, 128, 128);
				this.guna2Button1.Text = "Timer: Disabled";
				cfg.changeTimerEnabled(!cfg.timerEnabled, cfg);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000E888 File Offset: 0x0000E888
		private void Settings_Load(object sender, EventArgs e)
		{
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				this.guna2Button5.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2Panel2.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2Button6.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2GradientPanel1.Visible = true;
				this.GoBackBtn.FillColor = Color.Red;
				this.label2.Visible = true;
				this.label1.Visible = false;
			}
			bool flag2 = UserLogin.KeyAuthApp.user_data.subscriptions[0].subscription == "Member";
			if (flag2)
			{
				this.label3.Visible = true;
				cfg.timerEnabled = true;
				cfg.changeTimerEnabled(!cfg.timerEnabled, cfg);
				this.guna2Button1.Enabled = false;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000E99D File Offset: 0x0000E99D
		private void label2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/woofs");
		}

		// Token: 0x040000AF RID: 175
		private Color labelColor = Color.FromArgb(222, 227, 246);
	}
}
