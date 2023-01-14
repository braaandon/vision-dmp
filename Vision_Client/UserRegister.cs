using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x0200000C RID: 12
	public partial class UserRegister : Form
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000CB0E File Offset: 0x0000CB0E
		public UserRegister()
		{
			UserRegister.KeyAuthApp.init();
			this.InitializeComponent();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000CB34 File Offset: 0x0000CB34
		private void LoginBtn_Click_1(object sender, EventArgs e)
		{
			UserRegister.KeyAuthApp.register(this.user.Text, this.pass.Text, this.Keybox.Text);
			bool success = UserRegister.KeyAuthApp.response.success;
			if (success)
			{
				base.Hide();
				UserLogin userLogin = new UserLogin();
				userLogin.ShowDialog();
				base.Dispose();
			}
			else
			{
				MessageBox.Show(UserRegister.KeyAuthApp.response.message);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000CBB7 File Offset: 0x0000CBB7
		private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/heyimwoof");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000CBC5 File Offset: 0x0000CBC5
		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/NotBruce");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000CBD4 File Offset: 0x0000CBD4
		private void UserRegister_Load(object sender, EventArgs e)
		{
			UserRegister.KeyAuthApp.init();
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
				this.Keybox.BorderColor = Color.White;
				this.LoginBtn.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2CirclePictureBox3.Visible = false;
				this.guna2CirclePictureBox4.Visible = true;
				this.Exit.IconColor = Color.White;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000CCE4 File Offset: 0x0000CCE4
		private void Exit_Click(object sender, EventArgs e)
		{
			base.Dispose();
			StartupForm startupForm = new StartupForm();
			startupForm.ShowDialog();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000CD08 File Offset: 0x0000CD08
		private void usernamebox_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBtn_Click_1(sender, e);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000CD30 File Offset: 0x0000CD30
		private void passwordbox_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBtn_Click_1(sender, e);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000CD55 File Offset: 0x0000CD55
		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000CD58 File Offset: 0x0000CD58
		private void showpassword_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000CD5C File Offset: 0x0000CD5C
		private void UserRegister_Load_1(object sender, EventArgs e)
		{
			base.TopMost = true;
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				this.guna2GradientPanel1.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(17, 0, 27);
				this.guna2GradientPanel2.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
				this.Keybox.BorderColor = Color.FromArgb(17, 0, 27);
				this.LoginBtn.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2CirclePictureBox3.Visible = false;
				this.guna2CirclePictureBox4.Visible = true;
				this.Exit.IconColor = Color.White;
			}
		}

		// Token: 0x04000099 RID: 153
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");
	}
}
