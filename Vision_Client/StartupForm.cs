using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x0200000E RID: 14
	public partial class StartupForm : Form
	{
		// Token: 0x060000BE RID: 190 RVA: 0x0000F87F File Offset: 0x0000F87F
		public StartupForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000F897 File Offset: 0x0000F897
		private void Registerbtn_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000F89C File Offset: 0x0000F89C
		private void Loginbtn_Click(object sender, EventArgs e)
		{
			base.Hide();
			UserLogin userLogin = new UserLogin();
			userLogin.ShowDialog();
			base.Dispose();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000F8C8 File Offset: 0x0000F8C8
		private void StartupForm_Load(object sender, EventArgs e)
		{
			StartupForm.KeyAuthApp.init();
			base.TopMost = true;
			NLConfig nlconfig = NLConfig.Load();
			StartupForm.KeyAuthApp.check();
			bool flag = StartupForm.KeyAuthApp.checkblack();
			if (flag)
			{
				Environment.Exit(0);
			}
			bool flag2 = nlconfig.theme == "Woof";
			if (flag2)
			{
				this.guna2GradientPanel2.FillColor = Color.FromArgb(0, 0, 0);
				this.guna2GradientPanel2.FillColor2 = Color.FromArgb(17, 0, 27);
				this.guna2PictureBox1.Visible = false;
				this.Loginbtn.ShadowDecoration.Enabled = false;
				this.guna2PictureBox2.Visible = true;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000F97D File Offset: 0x0000F97D
		private void StartupForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000F986 File Offset: 0x0000F986
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000F990 File Offset: 0x0000F990
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			base.Hide();
			UserRegister userRegister = new UserRegister();
			userRegister.ShowDialog();
			base.Dispose();
		}

		// Token: 0x040000BD RID: 189
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");
	}
}
