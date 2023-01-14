using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.WinForms;
using KeyAuth;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x02000009 RID: 9
	public partial class AdminPanel : Form
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004C56 File Offset: 0x00004C56
		public AdminPanel()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004C70 File Offset: 0x00004C70
		private void AdminPanel_Load(object sender, EventArgs e)
		{
			AdminPanel.KeyAuthApp.init();
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				this.guna2GradientPanel2.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
			}
			bool flag2 = cfg.avatarPath != "";
			if (flag2)
			{
				Image image = Image.FromFile(Program.cfg.avatarPath);
				this.guna2CirclePictureBox1.Image = image;
			}
			List<api.users> list = UserLogin.KeyAuthApp.fetchOnline();
			this.onlineUsersBox.Items.Clear();
			foreach (api.users users in list)
			{
				this.onlineUsersBox.Items.Add(users.credential);
			}
			this.onlineUsersBox.SelectedIndex = 0;
			List<api.users> list2 = UserLogin.KeyAuthApp.fetchOnline();
			this.UpgradeUserBox.Items.Clear();
			foreach (api.users users2 in list)
			{
				this.UpgradeUserBox.Items.Add(users2.credential);
			}
			this.UpgradeUserBox.SelectedIndex = 0;
			List<api.users> list3 = UserLogin.KeyAuthApp.fetchOnline();
			this.UserBoxLog.Items.Clear();
			foreach (api.users users3 in list)
			{
				this.UserBoxLog.Items.Add(users3.credential);
			}
			this.UserBoxLog.SelectedIndex = 0;
			this.numUsers.Text = "Number of users: " + UserLogin.KeyAuthApp.app_data.numUsers;
			this.userLbl.Text = UserLogin.KeyAuthApp.user_data.username;
			List<api.users> list4 = UserLogin.KeyAuthApp.fetchOnline();
			this.BanUserLog.Items.Clear();
			foreach (api.users users4 in list)
			{
				this.BanUserLog.Items.Add(users4.credential);
			}
			this.BanUserLog.SelectedIndex = 0;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004F44 File Offset: 0x00004F44
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004F47 File Offset: 0x00004F47
		private void Upgradebtn_Click(object sender, EventArgs e)
		{
			AdminPanel.KeyAuthApp.upgrade(this.UpgradeUserBox.Text, this.key.Text);
			MessageBox.Show(AdminPanel.KeyAuthApp.response.message);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004F80 File Offset: 0x00004F80
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			AdminPanel.KeyAuthApp.log(this.UserBoxLog.Text);
			MessageBox.Show(AdminPanel.KeyAuthApp.response.message);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004FAE File Offset: 0x00004FAE
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			AdminPanel.KeyAuthApp.ban(this.BanUserLog.Text);
			MessageBox.Show(AdminPanel.KeyAuthApp.response.message);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004FDC File Offset: 0x00004FDC
		private void Exit_Click(object sender, EventArgs e)
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

		// Token: 0x04000019 RID: 25
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");
	}
}
