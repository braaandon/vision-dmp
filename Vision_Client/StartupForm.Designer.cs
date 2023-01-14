namespace Vision_Client
{
	// Token: 0x0200000E RID: 14
	public partial class StartupForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000F9BC File Offset: 0x0000F9BC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000F9F4 File Offset: 0x0000F9F4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.StartupForm));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel2 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Exit = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2PictureBox2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.Loginbtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2GradientPanel2.SuspendLayout();
			this.guna2PictureBox2.BeginInit();
			this.guna2PictureBox1.BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 12;
			this.guna2Elipse1.TargetControl = this;
			this.guna2GradientPanel2.Controls.Add(this.guna2Button1);
			this.guna2GradientPanel2.Controls.Add(this.Exit);
			this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox2);
			this.guna2GradientPanel2.Controls.Add(this.Loginbtn);
			this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox1);
			this.guna2GradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(169, 194, 238);
			this.guna2GradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel2.Location = new global::System.Drawing.Point(-6, -3);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new global::System.Drawing.Size(328, 370);
			this.guna2GradientPanel2.TabIndex = 12;
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button1.BorderRadius = 22;
			this.guna2Button1.BorderThickness = 2;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Inter", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.Black;
			this.guna2Button1.Location = new global::System.Drawing.Point(68, 231);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = global::System.Drawing.Color.White;
			this.guna2Button1.ShadowDecoration.BorderRadius = 0;
			this.guna2Button1.ShadowDecoration.Color = global::System.Drawing.Color.LightGray;
			this.guna2Button1.ShadowDecoration.Depth = 5;
			this.guna2Button1.Size = new global::System.Drawing.Size(191, 46);
			this.guna2Button1.TabIndex = 25;
			this.guna2Button1.Text = "Register";
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.Exit.AccessibleName = "Exit";
			this.Exit.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Exit.Animated = true;
			this.Exit.BackColor = global::System.Drawing.Color.Transparent;
			this.Exit.CustomClick = true;
			this.Exit.FillColor = global::System.Drawing.Color.Transparent;
			this.Exit.ForeColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			this.Exit.HoverState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.Exit.IconColor = global::System.Drawing.Color.White;
			this.Exit.Location = new global::System.Drawing.Point(273, 3);
			this.Exit.Name = "Exit";
			this.Exit.Size = new global::System.Drawing.Size(47, 31);
			this.Exit.TabIndex = 24;
			this.Exit.UseTransparentBackground = true;
			this.Exit.Click += new global::System.EventHandler(this.Exit_Click);
			this.guna2PictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox2.Image = global::Vision_Client.Properties.Resources.wooflogo;
			this.guna2PictureBox2.ImageRotate = 0f;
			this.guna2PictureBox2.Location = new global::System.Drawing.Point(94, 14);
			this.guna2PictureBox2.Name = "guna2PictureBox2";
			this.guna2PictureBox2.Size = new global::System.Drawing.Size(141, 126);
			this.guna2PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox2.TabIndex = 12;
			this.guna2PictureBox2.TabStop = false;
			this.guna2PictureBox2.UseTransparentBackground = true;
			this.guna2PictureBox2.Visible = false;
			this.Loginbtn.Animated = true;
			this.Loginbtn.AutoRoundedCorners = true;
			this.Loginbtn.BackColor = global::System.Drawing.Color.Transparent;
			this.Loginbtn.BorderRadius = 22;
			this.Loginbtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Loginbtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Loginbtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Loginbtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Loginbtn.FillColor = global::System.Drawing.Color.White;
			this.Loginbtn.Font = new global::System.Drawing.Font("Inter", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.Loginbtn.ForeColor = global::System.Drawing.Color.Black;
			this.Loginbtn.HoverState.FillColor = global::System.Drawing.Color.WhiteSmoke;
			this.Loginbtn.Location = new global::System.Drawing.Point(68, 179);
			this.Loginbtn.Name = "Loginbtn";
			this.Loginbtn.PressedColor = global::System.Drawing.Color.White;
			this.Loginbtn.ShadowDecoration.Color = global::System.Drawing.Color.LightGray;
			this.Loginbtn.ShadowDecoration.Depth = 5;
			this.Loginbtn.ShadowDecoration.Enabled = true;
			this.Loginbtn.Size = new global::System.Drawing.Size(191, 46);
			this.Loginbtn.TabIndex = 10;
			this.Loginbtn.Text = "Login";
			this.Loginbtn.UseTransparentBackground = true;
			this.Loginbtn.Click += new global::System.EventHandler(this.Loginbtn_Click);
			this.guna2PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::Vision_Client.Properties.Resources.visionlogowhite;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(96, 15);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(134, 115);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 2;
			this.guna2PictureBox1.TabStop = false;
			this.guna2PictureBox1.UseTransparentBackground = true;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.7;
			this.guna2DragControl1.TargetControl = this.guna2GradientPanel2;
			this.guna2DragControl1.UseTransparentDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(313, 366);
			base.Controls.Add(this.guna2GradientPanel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "StartupForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vision";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.StartupForm_FormClosing);
			base.Load += new global::System.EventHandler(this.StartupForm_Load);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2PictureBox2.EndInit();
			this.guna2PictureBox1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000BE RID: 190
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000BF RID: 191
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x040000C0 RID: 192
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x040000C1 RID: 193
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x040000C2 RID: 194
		private global::Guna.UI2.WinForms.Guna2Button Loginbtn;

		// Token: 0x040000C3 RID: 195
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;

		// Token: 0x040000C4 RID: 196
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x040000C5 RID: 197
		private global::Guna.UI2.WinForms.Guna2ControlBox Exit;

		// Token: 0x040000C6 RID: 198
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}
