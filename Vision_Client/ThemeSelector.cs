using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.WinForms;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x02000010 RID: 16
	public partial class ThemeSelector : Form
	{
		// Token: 0x060000CD RID: 205 RVA: 0x000108F0 File Offset: 0x000108F0
		public ThemeSelector()
		{
			this.InitializeComponent();
			this.config = Program.cfg;
			bool flag = this.config.theme == "Woof";
			if (flag)
			{
				this.label1.Text = "Bruce Theme";
				this.VisionLogo.Visible = true;
			}
			else
			{
				bool flag2 = this.config.theme == "Bruce";
				if (flag2)
				{
					this.label1.Text = " Woof Theme";
					this.label1.Font = new Font("Inter", this.label1.Font.Size, FontStyle.Bold);
					this.guna2Button2.Font = new Font("Inter", this.guna2Button2.Font.Size, FontStyle.Bold);
					this.guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 0);
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(17, 0, 27);
					this.woofLogo.Visible = true;
				}
				else
				{
					this.label1.Text = " Woof Theme";
					this.woofLogo.Visible = true;
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00010A34 File Offset: 0x00010A34
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			base.Hide();
			bool flag = this.config.theme == "Woof";
			if (flag)
			{
				this.config.changeTheme("Bruce", this.config);
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
				bool flag2 = this.config.theme == "Bruce";
				if (flag2)
				{
					this.config.changeTheme("Woof", this.config);
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
					this.config.changeTheme("Woof", this.config);
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
			base.Hide();
			base.Close();
		}

		// Token: 0x040000CF RID: 207
		private NLConfig config;
	}
}
