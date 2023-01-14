using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using NetLimiter.Service;
using Vision_Client.limiter;
using Vision_Client.Properties;

namespace Vision_Client.options
{
	// Token: 0x02000018 RID: 24
	public partial class ModuleOption : Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0001AE10 File Offset: 0x0001AE10
		public ModuleOption(string moduleName, Form form)
		{
			this.form = form;
			this.moduleName = moduleName;
			this.InitializeComponent();
			this.module.Text = moduleName + " Module";
			this.findWhichLimitAndChangeText();
			form.Opacity = 0.2;
			bool flag = moduleName == "Full Game";
			if (flag)
			{
				moduleName = "Destiny 2";
			}
			foreach (D2Filter d2Filter in Program.filters)
			{
				bool flag2 = d2Filter.Name == moduleName;
				if (flag2)
				{
					this.filter = d2Filter;
				}
			}
			this.bytesPerSecondText.Text = Program.cfg.bytesPerSecond[this.filter.whichFilter].ToString();
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001AF10 File Offset: 0x0001AF10
		private void findWhichLimitAndChangeText()
		{
			NLConfig cfg = Program.cfg;
			for (int i = 0; i < cfg.FilterList.Length; i++)
			{
				bool flag = cfg.FilterList[i] == this.moduleName;
				if (flag)
				{
					this.whichFilter = i;
				}
			}
			this.hotkeyTextBox.Text = cfg.Hotkeys[this.whichFilter];
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0001AF76 File Offset: 0x0001AF76
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			base.Close();
			this.form.Opacity = 1.0;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001AF98 File Offset: 0x0001AF98
		private void setHotkeyButton_Click(object sender, EventArgs e)
		{
			bool flag = !this.hotkeyTextBox.Text[0].ToString().ToLower().Equals("f") && this.hotkeyTextBox.Text.Length > 1;
			if (flag)
			{
				MessageBox.Show("Invalid Hotkey");
			}
			else
			{
				HotKeyManager.UnregisterHotKey(Program.filters[this.whichFilter]._id);
				Program.cfg.changeHotkey(this.whichFilter, this.hotkeyTextBox.Text.ToUpper(), Program.cfg);
				Program.filters[this.whichFilter].Hotkey = Util.GetKey(Program.cfg.Hotkeys[this.whichFilter].ToUpper());
				HotKeyManager.RegisterHotKey(Program.filters[this.whichFilter].Hotkey, Program.filters[this.whichFilter].Modifiers);
				MessageBox.Show("Changed Hotkey to: " + this.hotkeyTextBox.Text);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001B0B8 File Offset: 0x0001B0B8
		private void setBytes_Click(object sender, EventArgs e)
		{
			bool flag = this.moduleName == "3074 UL";
			if (flag)
			{
				this.filter.updateRuleBps(Convert.ToUInt32(this.bytesPerSecondText.Text), RuleDir.Out);
				Program.cfg.changesBytesPerSecond(this.filter.whichFilter, Convert.ToUInt32(this.bytesPerSecondText.Text), Program.cfg);
			}
			else
			{
				this.filter.updateRuleBps(Convert.ToUInt32(this.bytesPerSecondText.Text), RuleDir.In);
				Program.cfg.changesBytesPerSecond(this.filter.whichFilter, Convert.ToUInt32(this.bytesPerSecondText.Text), Program.cfg);
				MessageBox.Show("Changed Bytes Per Second : )");
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001B178 File Offset: 0x0001B178
		private void bytesPerSecondText_TextChanged(object sender, EventArgs e)
		{
			bool flag = Regex.IsMatch(this.bytesPerSecondText.Text, "[^0-9]");
			if (flag)
			{
				MessageBox.Show("Please enter only numbers.");
				this.bytesPerSecondText.Text = this.bytesPerSecondText.Text.Remove(this.bytesPerSecondText.Text.Length - 1);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001B1DC File Offset: 0x0001B1DC
		private void ModuleOption_Load(object sender, EventArgs e)
		{
			NLConfig cfg = Program.cfg;
			bool flag = cfg.theme == "Woof";
			if (flag)
			{
				this.setHotkeyButton.FillColor = Color.FromArgb(156, 0, 255);
				this.guna2GradientPanel1.FillColor = Color.Black;
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(156, 0, 255);
				this.guna2ControlBox1.FillColor = Color.Black;
				this.setBytes.FillColor = Color.FromArgb(156, 0, 255);
			}
			bool flag2 = Settings.Default.Color == "Cyan";
			if (flag2)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.setBytes.FillColor = Color.FromArgb(0, 204, 255);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 204, 255);
			}
			bool flag3 = Settings.Default.Color == "Red";
			if (flag3)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Red;
				this.setBytes.FillColor = Color.Red;
				this.setHotkeyButton.FillColor = Color.Red;
			}
			bool flag4 = Settings.Default.Color == "Blue";
			if (flag4)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Blue;
				this.setBytes.FillColor = Color.Blue;
				this.setHotkeyButton.FillColor = Color.Blue;
			}
			bool flag5 = Settings.Default.Color == "Pink";
			if (flag5)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 0, 156);
				this.setBytes.FillColor = Color.FromArgb(255, 0, 156);
				this.setHotkeyButton.FillColor = Color.FromArgb(255, 0, 156);
			}
			bool flag6 = Settings.Default.Color == "Green";
			if (flag6)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 205, 121);
				this.setBytes.FillColor = Color.FromArgb(0, 205, 121);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 205, 121);
			}
			bool flag7 = Settings.Default.Color == "Orange";
			if (flag7)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 102, 0);
				this.setBytes.FillColor = Color.FromArgb(255, 102, 0);
				this.setHotkeyButton.FillColor = Color.FromArgb(255, 102, 0);
			}
			bool flag8 = Settings.Default.Color == "Cyan";
			if (flag8)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.setBytes.FillColor = Color.FromArgb(0, 204, 255);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 204, 255);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001B534 File Offset: 0x0001B534
		private void timer1_Tick(object sender, EventArgs e)
		{
			bool flag = Settings.Default.Color == "Cyan";
			if (flag)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.setBytes.FillColor = Color.FromArgb(0, 204, 255);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 204, 255);
			}
			bool flag2 = Settings.Default.Color == "Red";
			if (flag2)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Red;
				this.setBytes.FillColor = Color.Red;
				this.setHotkeyButton.FillColor = Color.Red;
			}
			bool flag3 = Settings.Default.Color == "Blue";
			if (flag3)
			{
				this.guna2GradientPanel1.FillColor2 = Color.Blue;
				this.setBytes.FillColor = Color.Blue;
				this.setHotkeyButton.FillColor = Color.Blue;
			}
			bool flag4 = Settings.Default.Color == "Pink";
			if (flag4)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 0, 156);
				this.setBytes.FillColor = Color.FromArgb(255, 0, 156);
				this.setHotkeyButton.FillColor = Color.FromArgb(255, 0, 156);
			}
			bool flag5 = Settings.Default.Color == "Green";
			if (flag5)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 205, 121);
				this.setBytes.FillColor = Color.FromArgb(0, 205, 121);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 205, 121);
			}
			bool flag6 = Settings.Default.Color == "Orange";
			if (flag6)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(255, 102, 0);
				this.setBytes.FillColor = Color.FromArgb(255, 102, 0);
				this.setHotkeyButton.FillColor = Color.FromArgb(255, 102, 0);
			}
			bool flag7 = Settings.Default.Color == "Cyan";
			if (flag7)
			{
				this.guna2GradientPanel1.FillColor2 = Color.FromArgb(0, 204, 255);
				this.setBytes.FillColor = Color.FromArgb(0, 204, 255);
				this.setHotkeyButton.FillColor = Color.FromArgb(0, 204, 255);
			}
		}

		// Token: 0x04000167 RID: 359
		private D2Filter filter;

		// Token: 0x04000168 RID: 360
		private Form form;

		// Token: 0x04000169 RID: 361
		private int whichFilter;

		// Token: 0x0400016A RID: 362
		private string moduleName;
	}
}
