namespace Vision_Client
{
	// Token: 0x0200000D RID: 13
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000E9AC File Offset: 0x0000E9AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000E9E4 File Offset: 0x0000E9E4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.Settings));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.GoBackBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.guna2Button6 = new global::Guna.UI2.WinForms.Guna2Button();
			this.filePath = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.guna2GradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 20;
			this.guna2Elipse1.TargetControl = this;
			this.GoBackBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.GoBackBtn.BorderColor = global::System.Drawing.Color.FromArgb(196, 59, 59);
			this.GoBackBtn.BorderRadius = 6;
			this.GoBackBtn.BorderThickness = 1;
			this.GoBackBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.GoBackBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.GoBackBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.GoBackBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.GoBackBtn.FillColor = global::System.Drawing.Color.FromArgb(245, 66, 66);
			this.GoBackBtn.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GoBackBtn.ForeColor = global::System.Drawing.Color.White;
			this.GoBackBtn.Location = new global::System.Drawing.Point(12, 12);
			this.GoBackBtn.Name = "GoBackBtn";
			this.GoBackBtn.Size = new global::System.Drawing.Size(95, 44);
			this.GoBackBtn.TabIndex = 5;
			this.GoBackBtn.Text = "Go back";
			this.GoBackBtn.UseTransparentBackground = true;
			this.GoBackBtn.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.guna2Button5.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button5.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button5.BorderRadius = 8;
			this.guna2Button5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button5.FillColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.guna2Button5.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button5.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button5.Location = new global::System.Drawing.Point(98, 132);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new global::System.Drawing.Size(95, 44);
			this.guna2Button5.TabIndex = 6;
			this.guna2Button5.Text = "Themes";
			this.guna2Button5.UseTransparentBackground = true;
			this.guna2Button5.Click += new global::System.EventHandler(this.guna2Button5_Click);
			this.guna2Panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Panel2.BorderRadius = 11;
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Controls.Add(this.label1);
			this.guna2Panel2.Controls.Add(this.pictureBox1);
			this.guna2Panel2.FillColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.guna2Panel2.Location = new global::System.Drawing.Point(531, 136);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(200, 40);
			this.guna2Panel2.TabIndex = 8;
			this.guna2Panel2.UseTransparentBackground = true;
			this.guna2Panel2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
			this.guna2Panel2.MouseEnter += new global::System.EventHandler(this.guna2Panel2_MouseEnter);
			this.guna2Panel2.MouseLeave += new global::System.EventHandler(this.guna2Panel2_MouseLeave);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Inter", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(48, 11);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(127, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "CLICK TO JOIN";
			this.label2.Visible = false;
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("MOON GET!", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(45, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(133, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "CLICK TO JOIN";
			this.label1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseEnter += new global::System.EventHandler(this.label1_MouseEnter);
			this.pictureBox1.Image = global::Vision_Client.Properties.Resources.discord_logo_white;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(44, 29);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseEnter += new global::System.EventHandler(this.pictureBox1_MouseEnter);
			this.guna2Button6.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button6.BorderRadius = 8;
			this.guna2Button6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button6.FillColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.guna2Button6.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button6.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button6.Location = new global::System.Drawing.Point(551, 62);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new global::System.Drawing.Size(180, 45);
			this.guna2Button6.TabIndex = 10;
			this.guna2Button6.Text = "Destiny App Path";
			this.guna2Button6.UseTransparentBackground = true;
			this.guna2Button6.Click += new global::System.EventHandler(this.guna2Button6_Click);
			this.guna2Button6.MouseEnter += new global::System.EventHandler(this.guna2Button6_MouseEnter);
			this.guna2Button6.MouseLeave += new global::System.EventHandler(this.guna2Button6_MouseLeave);
			this.guna2Button6.MouseHover += new global::System.EventHandler(this.guna2Button6_MouseHover);
			this.filePath.BorderRadius = 6;
			this.filePath.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.filePath.DefaultText = "C:\\\\Program Files (x86)\\\\Steam\\\\steamapps\\\\common\\\\Destiny 2\\\\destiny2.exe";
			this.filePath.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.filePath.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.filePath.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.filePath.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.filePath.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.filePath.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.filePath.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.filePath.Location = new global::System.Drawing.Point(98, 67);
			this.filePath.Name = "filePath";
			this.filePath.PasswordChar = '\0';
			this.filePath.PlaceholderText = "";
			this.filePath.ReadOnly = true;
			this.filePath.SelectedText = "";
			this.filePath.Size = new global::System.Drawing.Size(447, 36);
			this.filePath.TabIndex = 11;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button1.BorderRadius = 8;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(121, 207, 97);
			this.guna2Button1.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.Location = new global::System.Drawing.Point(199, 132);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(140, 44);
			this.guna2Button1.TabIndex = 12;
			this.guna2Button1.Text = "Timer: Enabled";
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click_1);
			this.guna2GradientPanel1.Controls.Add(this.label3);
			this.guna2GradientPanel1.FillColor = global::System.Drawing.Color.Black;
			this.guna2GradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(17, 0, 27);
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-12, -9);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(767, 232);
			this.guna2GradientPanel1.TabIndex = 14;
			this.guna2GradientPanel1.Visible = false;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Inter", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(239, 188);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(82, 14);
			this.label3.TabIndex = 3;
			this.label3.Text = "Boosters only";
			this.label3.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			base.ClientSize = new global::System.Drawing.Size(743, 214);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.filePath);
			base.Controls.Add(this.guna2Button6);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Button5);
			base.Controls.Add(this.GoBackBtn);
			base.Controls.Add(this.guna2GradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Settings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000B0 RID: 176
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B1 RID: 177
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x040000B2 RID: 178
		private global::Guna.UI2.WinForms.Guna2Button guna2Button5;

		// Token: 0x040000B3 RID: 179
		private global::Guna.UI2.WinForms.Guna2Button GoBackBtn;

		// Token: 0x040000B4 RID: 180
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B7 RID: 183
		private global::Guna.UI2.WinForms.Guna2Button guna2Button6;

		// Token: 0x040000B8 RID: 184
		private global::Guna.UI2.WinForms.Guna2TextBox filePath;

		// Token: 0x040000B9 RID: 185
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x040000BA RID: 186
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Label label3;
	}
}
