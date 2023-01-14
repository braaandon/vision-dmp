namespace Vision_Client.splash
{
	// Token: 0x02000013 RID: 19
	public partial class MainSplash : global::System.Windows.Forms.Form
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00018208 File Offset: 0x00018208
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00018240 File Offset: 0x00018240
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.splash.MainSplash));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ProgressBar = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.guna2GradientPanel2 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.scroll = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.LabelTxt = new global::System.Windows.Forms.Label();
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2GradientPanel2.SuspendLayout();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 14;
			this.guna2Elipse1.TargetControl = this;
			this.timer1.Enabled = true;
			this.timer1.Interval = 343;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.ProgressBar.AutoRoundedCorners = true;
			this.ProgressBar.BackColor = global::System.Drawing.Color.Transparent;
			this.ProgressBar.BorderColor = global::System.Drawing.Color.Transparent;
			this.ProgressBar.BorderRadius = 4;
			this.ProgressBar.FillColor = global::System.Drawing.Color.White;
			this.ProgressBar.ForeColor = global::System.Drawing.Color.White;
			this.ProgressBar.Location = new global::System.Drawing.Point(60, 240);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.ProgressColor = global::System.Drawing.Color.FromArgb(247, 194, 235);
			this.ProgressBar.ProgressColor2 = global::System.Drawing.Color.FromArgb(170, 194, 238);
			this.ProgressBar.Size = new global::System.Drawing.Size(578, 10);
			this.ProgressBar.TabIndex = 1;
			this.ProgressBar.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ProgressBar.UseTransparentBackground = true;
			this.ProgressBar.Value = 1;
			this.guna2GradientPanel2.Controls.Add(this.scroll);
			this.guna2GradientPanel2.Controls.Add(this.label1);
			this.guna2GradientPanel2.Controls.Add(this.label2);
			this.guna2GradientPanel2.Controls.Add(this.LabelTxt);
			this.guna2GradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(168, 194, 238);
			this.guna2GradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel2.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel2.Location = new global::System.Drawing.Point(-14, -28);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new global::System.Drawing.Size(730, 374);
			this.guna2GradientPanel2.TabIndex = 3;
			this.scroll.AutoSize = true;
			this.scroll.BackColor = global::System.Drawing.Color.Transparent;
			this.scroll.Font = new global::System.Drawing.Font("Inter SemiBold", 12.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.scroll.ForeColor = global::System.Drawing.Color.White;
			this.scroll.Location = new global::System.Drawing.Point(133, 151);
			this.scroll.Name = "scroll";
			this.scroll.Size = new global::System.Drawing.Size(88, 20);
			this.scroll.TabIndex = 5;
			this.scroll.Text = "Netlimiter";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Arial", 12.75f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(86, 73);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(22, 100);
			this.label1.TabIndex = 4;
			this.label1.Text = "ヴ\r\nィ\r\nジ\r\nョ\r\nン";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Inter SemiBold", 12.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(133, 131);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(185, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "The best             \r\n                     alternative.";
			this.LabelTxt.AutoSize = true;
			this.LabelTxt.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTxt.Font = new global::System.Drawing.Font("Inter", 38f, global::System.Drawing.FontStyle.Bold);
			this.LabelTxt.ForeColor = global::System.Drawing.Color.White;
			this.LabelTxt.Location = new global::System.Drawing.Point(116, 70);
			this.LabelTxt.Name = "LabelTxt";
			this.LabelTxt.Size = new global::System.Drawing.Size(345, 61);
			this.LabelTxt.TabIndex = 2;
			this.LabelTxt.Text = "Vision Client";
			this.timer2.Enabled = true;
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			this.timer3.Enabled = true;
			this.timer3.Interval = 700;
			this.timer3.Tick += new global::System.EventHandler(this.timer3_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(707, 336);
			base.Controls.Add(this.ProgressBar);
			base.Controls.Add(this.guna2GradientPanel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MainSplash";
			base.Opacity = 0.0;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vision";
			base.Load += new global::System.EventHandler(this.MainSplash_Load);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000140 RID: 320
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000141 RID: 321
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000142 RID: 322
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000143 RID: 323
		private global::Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;

		// Token: 0x04000144 RID: 324
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x04000145 RID: 325
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000146 RID: 326
		private global::System.Windows.Forms.Label LabelTxt;

		// Token: 0x04000147 RID: 327
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x04000148 RID: 328
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000149 RID: 329
		private global::System.Windows.Forms.Label scroll;

		// Token: 0x0400014A RID: 330
		private global::System.Windows.Forms.Timer timer3;
	}
}
