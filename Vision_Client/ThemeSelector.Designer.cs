namespace Vision_Client
{
	// Token: 0x02000010 RID: 16
	public partial class ThemeSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00010C48 File Offset: 0x00010C48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00010C80 File Offset: 0x00010C80
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.ThemeSelector));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.woofLogo = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.VisionLogo = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2GradientPanel1.SuspendLayout();
			this.woofLogo.BeginInit();
			this.VisionLogo.BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button1.BorderRadius = 1;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Black;
			this.guna2Button1.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.Location = new global::System.Drawing.Point(219, 117);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(95, 44);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Text = "Filters";
			this.guna2GradientPanel1.Controls.Add(this.woofLogo);
			this.guna2GradientPanel1.Controls.Add(this.VisionLogo);
			this.guna2GradientPanel1.Controls.Add(this.guna2Button2);
			this.guna2GradientPanel1.Controls.Add(this.label1);
			this.guna2GradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(169, 194, 238);
			this.guna2GradientPanel1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-15, -15);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(576, 283);
			this.guna2GradientPanel1.TabIndex = 5;
			this.woofLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.woofLogo.FillColor = global::System.Drawing.Color.Transparent;
			this.woofLogo.Image = global::Vision_Client.Properties.Resources.wooflogo;
			this.woofLogo.ImageRotate = 0f;
			this.woofLogo.Location = new global::System.Drawing.Point(236, 159);
			this.woofLogo.Name = "woofLogo";
			this.woofLogo.Size = new global::System.Drawing.Size(75, 99);
			this.woofLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.woofLogo.TabIndex = 5;
			this.woofLogo.TabStop = false;
			this.woofLogo.UseTransparentBackground = true;
			this.woofLogo.Visible = false;
			this.VisionLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.VisionLogo.FillColor = global::System.Drawing.Color.Transparent;
			this.VisionLogo.Image = global::Vision_Client.Properties.Resources.visionlogowhite;
			this.VisionLogo.ImageRotate = 0f;
			this.VisionLogo.Location = new global::System.Drawing.Point(245, 168);
			this.VisionLogo.Name = "VisionLogo";
			this.VisionLogo.Size = new global::System.Drawing.Size(55, 55);
			this.VisionLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.VisionLogo.TabIndex = 4;
			this.VisionLogo.TabStop = false;
			this.VisionLogo.UseTransparentBackground = true;
			this.VisionLogo.Visible = false;
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new global::System.Drawing.Font("Hemisphers Bold Sans", 15.75f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.Location = new global::System.Drawing.Point(91, 122);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(383, 40);
			this.guna2Button2.TabIndex = 1;
			this.guna2Button2.Text = "Click here to change theme";
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Hemisphers Bold Sans", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(151, 39);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(267, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "BRUCE THEME";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Vision_Client.Properties.Resources.splashMAIN;
			base.ClientSize = new global::System.Drawing.Size(539, 266);
			base.Controls.Add(this.guna2GradientPanel1);
			base.Controls.Add(this.guna2Button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ThemeSelector";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ThemeSelector";
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			this.woofLogo.EndInit();
			this.VisionLogo.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000D0 RID: 208
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D1 RID: 209
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x040000D2 RID: 210
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x040000D3 RID: 211
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x040000D4 RID: 212
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D6 RID: 214
		private global::Guna.UI2.WinForms.Guna2PictureBox woofLogo;

		// Token: 0x040000D7 RID: 215
		private global::Guna.UI2.WinForms.Guna2PictureBox VisionLogo;
	}
}
