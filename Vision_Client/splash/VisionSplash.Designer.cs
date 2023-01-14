namespace Vision_Client.splash
{
	// Token: 0x02000014 RID: 20
	public partial class VisionSplash : global::System.Windows.Forms.Form
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00018A64 File Offset: 0x00018A64
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00018A9C File Offset: 0x00018A9C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.splash.VisionSplash));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.ProgressBar = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.guna2Elipse2 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2GradientPanel2 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2GradientPanel1.SuspendLayout();
			this.guna2GradientPanel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 14;
			this.guna2Elipse1.TargetControl = this;
			this.ProgressBar.AutoRoundedCorners = true;
			this.ProgressBar.BackColor = global::System.Drawing.Color.Transparent;
			this.ProgressBar.BorderColor = global::System.Drawing.Color.Transparent;
			this.ProgressBar.BorderRadius = 4;
			this.ProgressBar.FillColor = global::System.Drawing.Color.White;
			this.ProgressBar.ForeColor = global::System.Drawing.Color.White;
			this.ProgressBar.Location = new global::System.Drawing.Point(36, 236);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.ProgressColor = global::System.Drawing.Color.FromArgb(247, 194, 235);
			this.ProgressBar.ProgressColor2 = global::System.Drawing.Color.FromArgb(170, 194, 238);
			this.ProgressBar.Size = new global::System.Drawing.Size(179, 10);
			this.ProgressBar.TabIndex = 0;
			this.ProgressBar.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ProgressBar.UseTransparentBackground = true;
			this.ProgressBar.Value = 1;
			this.guna2Elipse2.BorderRadius = 0;
			this.guna2Elipse2.TargetControl = this.ProgressBar;
			this.guna2GradientPanel1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2GradientPanel1.Controls.Add(this.guna2GradientPanel2);
			this.guna2GradientPanel1.Controls.Add(this.pictureBox2);
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-3, -1);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(255, 360);
			this.guna2GradientPanel1.TabIndex = 1;
			this.guna2GradientPanel2.Controls.Add(this.label1);
			this.guna2GradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(168, 194, 238);
			this.guna2GradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel2.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel2.Location = new global::System.Drawing.Point(3, -1);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new global::System.Drawing.Size(265, 392);
			this.guna2GradientPanel2.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Hemisphers Bold Sans", 120f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(43, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(182, 160);
			this.label1.TabIndex = 0;
			this.label1.Text = "V";
			this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::Vision_Client.Properties.Resources.visionlogowhite;
			this.pictureBox2.Location = new global::System.Drawing.Point(0, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(302, 209);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			this.BackgroundImage = global::Vision_Client.Properties.Resources.visionsplash;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(251, 357);
			base.Controls.Add(this.ProgressBar);
			base.Controls.Add(this.guna2GradientPanel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "VisionSplash";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			base.TransparencyKey = global::System.Drawing.Color.Black;
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400014B RID: 331
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400014C RID: 332
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x0400014D RID: 333
		private global::Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;

		// Token: 0x0400014E RID: 334
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

		// Token: 0x0400014F RID: 335
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000152 RID: 338
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Label label1;
	}
}
