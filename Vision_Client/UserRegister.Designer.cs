namespace Vision_Client
{
	// Token: 0x0200000C RID: 12
	public partial class UserRegister : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x0000CE44 File Offset: 0x0000CE44
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000CE7C File Offset: 0x0000CE7C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.UserRegister));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel2 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.LabelTxt = new global::System.Windows.Forms.Label();
			this.LoginBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Elipse2 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.pass = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Exit = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.user = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Keybox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2CirclePictureBox3 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2CirclePictureBox2 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2CirclePictureBox1 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2CirclePictureBox4 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.guna2GradientPanel2.SuspendLayout();
			this.guna2GradientPanel1.SuspendLayout();
			this.guna2CirclePictureBox3.BeginInit();
			this.guna2CirclePictureBox2.BeginInit();
			this.guna2CirclePictureBox1.BeginInit();
			this.guna2CirclePictureBox4.BeginInit();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this;
			this.guna2GradientPanel2.Controls.Add(this.label5);
			this.guna2GradientPanel2.Controls.Add(this.guna2CirclePictureBox2);
			this.guna2GradientPanel2.Controls.Add(this.label4);
			this.guna2GradientPanel2.Controls.Add(this.guna2CirclePictureBox1);
			this.guna2GradientPanel2.Controls.Add(this.label3);
			this.guna2GradientPanel2.Controls.Add(this.label2);
			this.guna2GradientPanel2.Controls.Add(this.LabelTxt);
			this.guna2GradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(169, 194, 238);
			this.guna2GradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel2.Location = new global::System.Drawing.Point(27, 18);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new global::System.Drawing.Size(310, 331);
			this.guna2GradientPanel2.TabIndex = 16;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(196, 289);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(46, 15);
			this.label5.TabIndex = 6;
			this.label5.Text = "- Woof";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(95, 289);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(50, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "- Bruce";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Inter", 9.5f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(77, 257);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(143, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Meet the developers!";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Inter SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(22, 98);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(169, 38);
			this.label2.TabIndex = 1;
			this.label2.Text = "The best \r\nNetlimiter alternative.";
			this.LabelTxt.AutoSize = true;
			this.LabelTxt.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTxt.Font = new global::System.Drawing.Font("Inter", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelTxt.ForeColor = global::System.Drawing.Color.White;
			this.LabelTxt.Location = new global::System.Drawing.Point(19, 65);
			this.LabelTxt.Name = "LabelTxt";
			this.LabelTxt.Size = new global::System.Drawing.Size(196, 35);
			this.LabelTxt.TabIndex = 0;
			this.LabelTxt.Text = "Vision Client";
			this.LoginBtn.Animated = true;
			this.LoginBtn.AutoRoundedCorners = true;
			this.LoginBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginBtn.BorderRadius = 16;
			this.LoginBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LoginBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.LoginBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LoginBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.LoginBtn.FillColor = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.LoginBtn.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.White;
			this.LoginBtn.Location = new global::System.Drawing.Point(447, 243);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new global::System.Drawing.Size(142, 34);
			this.LoginBtn.TabIndex = 14;
			this.LoginBtn.Text = "Register";
			this.LoginBtn.UseTransparentBackground = true;
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click_1);
			this.guna2Elipse2.BorderRadius = 12;
			this.guna2Elipse2.TargetControl = this.guna2GradientPanel2;
			this.guna2GradientPanel1.Controls.Add(this.pass);
			this.guna2GradientPanel1.Controls.Add(this.Exit);
			this.guna2GradientPanel1.Controls.Add(this.user);
			this.guna2GradientPanel1.Controls.Add(this.Keybox);
			this.guna2GradientPanel1.Controls.Add(this.LoginBtn);
			this.guna2GradientPanel1.Controls.Add(this.guna2CirclePictureBox4);
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-6, -7);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(671, 387);
			this.guna2GradientPanel1.TabIndex = 18;
			this.pass.Animated = true;
			this.pass.AutoRoundedCorners = true;
			this.pass.BackColor = global::System.Drawing.Color.Transparent;
			this.pass.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.pass.BorderRadius = 17;
			this.pass.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.pass.DefaultText = "";
			this.pass.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.pass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.pass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.pass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.pass.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.pass.ForeColor = global::System.Drawing.Color.Black;
			this.pass.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.pass.Location = new global::System.Drawing.Point(392, 147);
			this.pass.Name = "pass";
			this.pass.PasswordChar = '\0';
			this.pass.PlaceholderForeColor = global::System.Drawing.Color.LightGray;
			this.pass.PlaceholderText = "Password";
			this.pass.SelectedText = "";
			this.pass.Size = new global::System.Drawing.Size(229, 36);
			this.pass.TabIndex = 26;
			this.Exit.AccessibleName = "Exit";
			this.Exit.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Exit.Animated = true;
			this.Exit.BackColor = global::System.Drawing.Color.Transparent;
			this.Exit.CustomClick = true;
			this.Exit.FillColor = global::System.Drawing.Color.Transparent;
			this.Exit.ForeColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			this.Exit.HoverState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.Exit.IconColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.Exit.Location = new global::System.Drawing.Point(615, 5);
			this.Exit.Name = "Exit";
			this.Exit.Size = new global::System.Drawing.Size(57, 36);
			this.Exit.TabIndex = 22;
			this.Exit.UseTransparentBackground = true;
			this.Exit.Click += new global::System.EventHandler(this.Exit_Click);
			this.user.Animated = true;
			this.user.AutoRoundedCorners = true;
			this.user.BackColor = global::System.Drawing.Color.Transparent;
			this.user.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.user.BorderRadius = 17;
			this.user.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.user.DefaultText = "";
			this.user.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.user.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.user.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.user.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.user.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.user.ForeColor = global::System.Drawing.Color.Black;
			this.user.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.user.Location = new global::System.Drawing.Point(392, 105);
			this.user.Name = "user";
			this.user.PasswordChar = '\0';
			this.user.PlaceholderForeColor = global::System.Drawing.Color.LightGray;
			this.user.PlaceholderText = "Username";
			this.user.SelectedText = "";
			this.user.Size = new global::System.Drawing.Size(229, 36);
			this.user.TabIndex = 25;
			this.Keybox.Animated = true;
			this.Keybox.AutoRoundedCorners = true;
			this.Keybox.BackColor = global::System.Drawing.Color.Transparent;
			this.Keybox.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.Keybox.BorderRadius = 17;
			this.Keybox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Keybox.DefaultText = "";
			this.Keybox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Keybox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Keybox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Keybox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Keybox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Keybox.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.Keybox.ForeColor = global::System.Drawing.Color.Black;
			this.Keybox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Keybox.Location = new global::System.Drawing.Point(392, 189);
			this.Keybox.Name = "Keybox";
			this.Keybox.PasswordChar = '\0';
			this.Keybox.PlaceholderForeColor = global::System.Drawing.Color.LightGray;
			this.Keybox.PlaceholderText = "Key";
			this.Keybox.SelectedText = "";
			this.Keybox.Size = new global::System.Drawing.Size(229, 36);
			this.Keybox.TabIndex = 20;
			this.Keybox.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.usernamebox_KeyDown);
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.7;
			this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2DragControl2.DockIndicatorTransparencyValue = 0.7;
			this.guna2DragControl2.TargetControl = this.guna2GradientPanel2;
			this.guna2DragControl2.UseTransparentDrag = true;
			this.guna2CirclePictureBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox3.Image = global::Vision_Client.Properties.Resources.Vision_Client_Logo_Fill;
			this.guna2CirclePictureBox3.ImageRotate = 0f;
			this.guna2CirclePictureBox3.Location = new global::System.Drawing.Point(477, 33);
			this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
			this.guna2CirclePictureBox3.ShadowDecoration.Mode = 1;
			this.guna2CirclePictureBox3.Size = new global::System.Drawing.Size(52, 52);
			this.guna2CirclePictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox3.TabIndex = 17;
			this.guna2CirclePictureBox3.TabStop = false;
			this.guna2CirclePictureBox3.UseTransparentBackground = true;
			this.guna2CirclePictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox2.Image = global::Vision_Client.Properties.Resources.woofpfp1;
			this.guna2CirclePictureBox2.ImageRotate = 0f;
			this.guna2CirclePictureBox2.Location = new global::System.Drawing.Point(157, 280);
			this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
			this.guna2CirclePictureBox2.ShadowDecoration.Mode = 1;
			this.guna2CirclePictureBox2.Size = new global::System.Drawing.Size(34, 35);
			this.guna2CirclePictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox2.TabIndex = 5;
			this.guna2CirclePictureBox2.TabStop = false;
			this.guna2CirclePictureBox2.UseTransparentBackground = true;
			this.guna2CirclePictureBox2.Click += new global::System.EventHandler(this.guna2CirclePictureBox2_Click);
			this.guna2CirclePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = global::Vision_Client.Properties.Resources.brucepfp;
			this.guna2CirclePictureBox1.ImageRotate = 0f;
			this.guna2CirclePictureBox1.Location = new global::System.Drawing.Point(56, 280);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = 1;
			this.guna2CirclePictureBox1.Size = new global::System.Drawing.Size(34, 35);
			this.guna2CirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 3;
			this.guna2CirclePictureBox1.TabStop = false;
			this.guna2CirclePictureBox1.UseTransparentBackground = true;
			this.guna2CirclePictureBox1.Click += new global::System.EventHandler(this.guna2CirclePictureBox1_Click);
			this.guna2CirclePictureBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox4.Image = global::Vision_Client.Properties.Resources.wooflogo;
			this.guna2CirclePictureBox4.ImageRotate = 0f;
			this.guna2CirclePictureBox4.Location = new global::System.Drawing.Point(457, 19);
			this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
			this.guna2CirclePictureBox4.ShadowDecoration.Mode = 1;
			this.guna2CirclePictureBox4.Size = new global::System.Drawing.Size(104, 93);
			this.guna2CirclePictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox4.TabIndex = 19;
			this.guna2CirclePictureBox4.TabStop = false;
			this.guna2CirclePictureBox4.UseTransparentBackground = true;
			this.guna2CirclePictureBox4.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(665, 371);
			base.Controls.Add(this.guna2CirclePictureBox3);
			base.Controls.Add(this.guna2GradientPanel2);
			base.Controls.Add(this.guna2GradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "UserRegister";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			base.Load += new global::System.EventHandler(this.UserRegister_Load_1);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2CirclePictureBox3.EndInit();
			this.guna2CirclePictureBox2.EndInit();
			this.guna2CirclePictureBox1.EndInit();
			this.guna2CirclePictureBox4.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400009A RID: 154
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400009B RID: 155
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x0400009C RID: 156
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;

		// Token: 0x0400009D RID: 157
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400009F RID: 159
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000A1 RID: 161
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Label LabelTxt;

		// Token: 0x040000A5 RID: 165
		private global::Guna.UI2.WinForms.Guna2Button LoginBtn;

		// Token: 0x040000A6 RID: 166
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

		// Token: 0x040000A7 RID: 167
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x040000A8 RID: 168
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;

		// Token: 0x040000A9 RID: 169
		private global::Guna.UI2.WinForms.Guna2TextBox Keybox;

		// Token: 0x040000AA RID: 170
		private global::Guna.UI2.WinForms.Guna2ControlBox Exit;

		// Token: 0x040000AB RID: 171
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x040000AC RID: 172
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x040000AD RID: 173
		private global::Guna.UI2.WinForms.Guna2TextBox pass;

		// Token: 0x040000AE RID: 174
		private global::Guna.UI2.WinForms.Guna2TextBox user;
	}
}
