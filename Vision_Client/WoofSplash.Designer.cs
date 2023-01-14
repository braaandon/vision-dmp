namespace Vision_Client
{
	// Token: 0x0200000F RID: 15
	public partial class WoofSplash : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00010428 File Offset: 0x00010428
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00010460 File Offset: 0x00010460
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.WoofSplash));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.ProgressBar = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.guna2Elipse2 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2PictureBox2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2GradientPanel1.SuspendLayout();
			this.guna2PictureBox2.BeginInit();
			this.guna2PictureBox1.BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 14;
			this.guna2Elipse1.TargetControl = this;
			this.ProgressBar.AutoRoundedCorners = true;
			this.ProgressBar.BackColor = global::System.Drawing.Color.Transparent;
			this.ProgressBar.BorderRadius = 4;
			this.ProgressBar.FillColor = global::System.Drawing.Color.Black;
			this.ProgressBar.Location = new global::System.Drawing.Point(36, 236);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.ProgressColor = global::System.Drawing.Color.FromArgb(185, 93, 255);
			this.ProgressBar.ProgressColor2 = global::System.Drawing.Color.FromArgb(148, 6, 255);
			this.ProgressBar.Size = new global::System.Drawing.Size(179, 10);
			this.ProgressBar.TabIndex = 0;
			this.ProgressBar.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ProgressBar.Value = 5;
			this.ProgressBar.ValueChanged += new global::System.EventHandler(this.ProgressBar_ValueChanged);
			this.guna2Elipse2.BorderRadius = 0;
			this.guna2Elipse2.TargetControl = this.ProgressBar;
			this.guna2GradientPanel1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox2);
			this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-3, -1);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(255, 360);
			this.guna2GradientPanel1.TabIndex = 1;
			this.guna2PictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox2.Image = global::Vision_Client.Properties.Resources.wooflogo;
			this.guna2PictureBox2.ImageRotate = 0f;
			this.guna2PictureBox2.Location = new global::System.Drawing.Point(27, 20);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.Size = new global::System.Drawing.Size(203, 176);
			this.guna2PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox2.TabIndex = 1;
			this.guna2PictureBox2.TabStop = false;
			this.guna2PictureBox2.UseTransparentBackground = true;
			this.guna2PictureBox1.Image = global::Vision_Client.Properties.Resources.splashbg1;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(-495, -207);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(1230, 820);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(251, 357);
			base.Controls.Add(this.ProgressBar);
			base.Controls.Add(this.guna2GradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "WoofSplash";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2PictureBox2.EndInit();
			this.guna2PictureBox1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000C7 RID: 199
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000C8 RID: 200
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x040000C9 RID: 201
		private global::Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;

		// Token: 0x040000CA RID: 202
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

		// Token: 0x040000CB RID: 203
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x040000CC RID: 204
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x040000CD RID: 205
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.Timer timer1;
	}
}
