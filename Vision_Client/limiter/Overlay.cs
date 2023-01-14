using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Vision_Client.Properties;

namespace Vision_Client.limiter
{
	// Token: 0x0200001E RID: 30
	public partial class Overlay : Form
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0001D328 File Offset: 0x0001D328
		public Overlay()
		{
			this.InitializeComponent();
			base.TopMost = true;
			base.ShowInTaskbar = false;
			base.FormBorderStyle = FormBorderStyle.None;
			base.WindowState = FormWindowState.Maximized;
			base.MinimizeBox = (base.MaximizeBox = false);
			this.MinimumSize = (this.MaximumSize = base.Size);
			base.TransparencyKey = (this.BackColor = Color.FromArgb(162, 164, 166));
			this.moduleLabel.Hide();
			this.modulePanel.Hide();
			this.moduleTick.Hide();
			this.isEnabled.Hide();
			this.timerCreate();
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001D40C File Offset: 0x0001D40C
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 524320;
				return createParams;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001D439 File Offset: 0x0001D439
		public void hideModule()
		{
			this.moduleLabel.Hide();
			this.modulePanel.Hide();
			this.moduleTick.Hide();
			this.isEnabled.Hide();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001D46C File Offset: 0x0001D46C
		public void showModule()
		{
			this.moduleTick.Show();
			this.moduleLabel.Show();
			this.modulePanel.Show();
			this.isEnabled.Show();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001D4A0 File Offset: 0x0001D4A0
		private void modulePanel_VisibleChanged(object sender, EventArgs e)
		{
			this.moduleLabel.Text = this.moduleName + " was";
			bool flag = this.moduleName.Length > 14;
			int num;
			if (flag)
			{
				num = this.moduleName.Length * 12 + 7;
			}
			else
			{
				bool flag2 = this.moduleName.Length < 4;
				if (flag2)
				{
					num = this.moduleName.Length * 9 + 15;
				}
				else
				{
					num = this.moduleName.Length * 9 + 9;
				}
			}
			this.isEnabled.Location = new Point(this.moduleLabel.Location.X + num, this.isEnabled.Location.Y);
			bool flag3 = !this.enabled;
			if (flag3)
			{
				this.isEnabled.ForeColor = Color.FromArgb(255, 128, 128);
				this.isEnabled.Text = "disabled";
			}
			else
			{
				this.isEnabled.ForeColor = Color.LightGreen;
				this.isEnabled.Text = "enabled";
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001D5CF File Offset: 0x0001D5CF
		private void OnTimeEvent(object sender, ElapsedEventArgs e)
		{
			base.Invoke(new Action(delegate()
			{
				this.second++;
				bool flag = this.second == 60;
				if (flag)
				{
					this.second = 0;
					this.minute++;
				}
				bool flag2 = this.minute == 60;
				if (flag2)
				{
					this.minute = 0;
					this.hour++;
				}
				this.timerText.Text = string.Format("{0}:{1}:{2}", this.hour.ToString().PadLeft(2, '0'), this.minute.ToString().PadLeft(2, '0'), this.second.ToString().PadLeft(2, '0'));
			}));
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001D5E8 File Offset: 0x0001D5E8
		public void isTimerEnabled()
		{
			bool flag = this.timerEnabled;
			if (flag)
			{
				this.timerText.Hide();
				this.timer.Stop();
				this.timerText.Text = "00:00:00";
				this.hour = 0;
				this.minute = 0;
				this.second = 0;
				this.timerEnabled = false;
			}
			else
			{
				this.timerEnabled = true;
				this.timer.Start();
				this.timerText.Show();
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0001D667 File Offset: 0x0001D667
		public void timerCreate()
		{
			this.timer = new Timer();
			this.timer.Interval = 1000.0;
			this.timer.Elapsed += this.OnTimeEvent;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001D6A2 File Offset: 0x0001D6A2
		public void hideTimerText()
		{
			this.timerText.Hide();
		}

		// Token: 0x040001A5 RID: 421
		public string moduleName = "Module";

		// Token: 0x040001A6 RID: 422
		public bool enabled = false;

		// Token: 0x040001A7 RID: 423
		private Timer timer;

		// Token: 0x040001A8 RID: 424
		public bool timerEnabled = false;

		// Token: 0x040001A9 RID: 425
		private int hour;

		// Token: 0x040001AA RID: 426
		private int minute;

		// Token: 0x040001AB RID: 427
		private int second;
	}
}
