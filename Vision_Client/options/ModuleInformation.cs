using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client.options
{
	// Token: 0x02000017 RID: 23
	public partial class ModuleInformation : Form
	{
		// Token: 0x06000173 RID: 371 RVA: 0x000199CD File Offset: 0x000199CD
		public ModuleInformation()
		{
			this.InitializeComponent();
			base.TopMost = true;
			base.ShowInTaskbar = false;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000199F8 File Offset: 0x000199F8
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			base.Dispose();
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				Vision vision = new Vision(new Overlay());
				vision.ShowDialog();
			}
			else
			{
				bool flag2 = cfg.theme == "Bruce";
				if (flag2)
				{
					BruceVision bruceVision = new BruceVision(new Overlay());
					bruceVision.ShowDialog();
				}
				else
				{
					Vision vision2 = new Vision(new Overlay());
					vision2.ShowDialog();
				}
			}
			base.Close();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00019A90 File Offset: 0x00019A90
		private void ModuleInformation_Load(object sender, EventArgs e)
		{
			NLConfig cfg = Program.cfg;
			this.timer1.Enabled = true;
			bool flag = cfg.theme == "Bruce";
			if (flag)
			{
				this.guna2GradientPanel1.FillColor = Color.FromArgb(44, 47, 51);
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(35, 39, 42);
				this.label1.ForeColor = Color.FromArgb(114, 137, 218);
				this.label2.ForeColor = Color.FromArgb(114, 137, 218);
				this.label4.ForeColor = Color.FromArgb(114, 137, 218);
				this.label6.ForeColor = Color.FromArgb(114, 137, 218);
				this.label8.ForeColor = Color.FromArgb(114, 137, 218);
			}
			bool flag2 = Settings.Default.Color == "Red";
			if (flag2)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Red;
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag3 = Settings.Default.Color == "Blue";
			if (flag3)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Blue;
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag4 = Settings.Default.Color == "Pink";
			if (flag4)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 0, 156);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag5 = Settings.Default.Color == "Green";
			if (flag5)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 205, 121);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag6 = Settings.Default.Color == "Orange";
			if (flag6)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 102, 0);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag7 = Settings.Default.Color == "Cyan";
			if (flag7)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00019EB8 File Offset: 0x00019EB8
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = Settings.Default.Color == "Red";
			if (flag)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Red;
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag2 = Settings.Default.Color == "Blue";
			if (flag2)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Blue;
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag3 = Settings.Default.Color == "Pink";
			if (flag3)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 0, 156);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag4 = Settings.Default.Color == "Green";
			if (flag4)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 205, 121);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag5 = Settings.Default.Color == "Orange";
			if (flag5)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 102, 0);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
			bool flag6 = Settings.Default.Color == "Cyan";
			if (flag6)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.label1.ForeColor = Color.White;
				this.label2.ForeColor = Color.White;
				this.label4.ForeColor = Color.White;
				this.label6.ForeColor = Color.White;
				this.label8.ForeColor = Color.White;
			}
		}
	}
}
