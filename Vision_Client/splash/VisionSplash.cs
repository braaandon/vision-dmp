using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client.splash
{
	// Token: 0x02000014 RID: 20
	public partial class VisionSplash : Form
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00018969 File Offset: 0x00018969
		public VisionSplash()
		{
			this.InitializeComponent();
			base.TopMost = true;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0001898C File Offset: 0x0001898C
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
	}
}
