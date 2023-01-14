using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using Vision_Client.limiter;
using Vision_Client.Properties;
using Vision_Client.splash;

namespace Vision_Client
{
	// Token: 0x02000011 RID: 17
	public partial class UserLogin : Form
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x000113CF File Offset: 0x000113CF
		public UserLogin()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000113E8 File Offset: 0x000113E8
		private void LoginBtn_Click_1(object sender, EventArgs e)
		{
			UserLogin.KeyAuthApp.login(this.user.Text, this.pass.Text);
			bool success = UserLogin.KeyAuthApp.response.success;
			if (success)
			{
				Settings.Default.User = this.user.Text;
				Settings.Default.Pass = this.pass.Text;
				Settings.Default.Save();
				NLConfig cfg = Program.cfg;
				bool flag = cfg.theme == "Woof";
				if (flag)
				{
					base.Hide();
					WoofSplash woofSplash = new WoofSplash();
					woofSplash.ShowDialog();
					base.Dispose();
				}
				else
				{
					base.Hide();
				}
				VisionSplash visionSplash = new VisionSplash();
				visionSplash.ShowDialog();
				base.Dispose();
			}
			MessageBox.Show(UserLogin.KeyAuthApp.response.message);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000114D6 File Offset: 0x000114D6
		private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/heyimwoof");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000114E4 File Offset: 0x000114E4
		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/NotBruce");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000114F4 File Offset: 0x000114F4
		private void UserLogin_Load(object sender, EventArgs e)
		{
			UserLogin.KeyAuthApp.init();
			UserLogin.KeyAuthApp.check();
			this.user.Text = Settings.Default.User;
			this.pass.Text = Settings.Default.Pass;
			base.TopMost = true;
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				this.guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(17, 0, 27);
				this.guna2GradientPanel2.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
				this.user.BorderColor = Color.White;
				this.pass.BorderColor = Color.White;
				this.LoginBtn.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2CirclePictureBox3.Visible = false;
				this.guna2CirclePictureBox4.Visible = true;
				this.Exit.IconColor = Color.White;
			}
			bool flag2 = this.pass.Text == Settings.Default.Pass && this.user.Text == Settings.Default.User;
			if (flag2)
			{
				this.LoginBtn.PerformClick();
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00011674 File Offset: 0x00011674
		private void Exit_Click(object sender, EventArgs e)
		{
			base.Dispose();
			StartupForm startupForm = new StartupForm();
			startupForm.ShowDialog();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00011698 File Offset: 0x00011698
		private void usernamebox_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBtn_Click_1(sender, e);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000116C0 File Offset: 0x000116C0
		private void passwordbox_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBtn_Click_1(sender, e);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000116E5 File Offset: 0x000116E5
		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000116E8 File Offset: 0x000116E8
		private void showpassword_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040000D8 RID: 216
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");
	}
}
