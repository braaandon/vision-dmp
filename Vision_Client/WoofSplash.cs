using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client
{
	// Token: 0x0200000F RID: 15
	public partial class WoofSplash : Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00010329 File Offset: 0x00010329
		public WoofSplash()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0001034C File Offset: 0x0001034C
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
			this.ProgressBar.Increment(5);
			bool flag = this.ProgressBar.Value == 100;
			if (flag)
			{
				this.timer1.Enabled = false;
				base.Hide();
				NLConfig cfg = Program.cfg;
				bool flag2 = cfg.theme == "Woof";
				if (flag2)
				{
					Vision vision = new Vision(new Overlay());
					vision.ShowDialog();
				}
				else
				{
					bool flag3 = cfg.theme == "Bruce";
					if (flag3)
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
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00010423 File Offset: 0x00010423
		private void ProgressBar_ValueChanged(object sender, EventArgs e)
		{
		}
	}
}
