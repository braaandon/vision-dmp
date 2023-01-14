namespace Vision_Client
{
	// Token: 0x02000009 RID: 9
	public partial class AdminPanel : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00005198 File Offset: 0x00005198
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000051D0 File Offset: 0x000051D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.AdminPanel));
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2GradientPanel2 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.Exit = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.BanUserLog = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.UserBoxLog = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Upgradebtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.key = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.UpgradeUserBox = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.numUsers = new global::System.Windows.Forms.Label();
			this.onlineUsersBox = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.guna2CirclePictureBox1 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.userLbl = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LabelTxt = new global::System.Windows.Forms.Label();
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2GradientPanel2.SuspendLayout();
			this.guna2CirclePictureBox1.BeginInit();
			base.SuspendLayout();
			this.guna2GradientPanel2.Controls.Add(this.Exit);
			this.guna2GradientPanel2.Controls.Add(this.guna2Button2);
			this.guna2GradientPanel2.Controls.Add(this.BanUserLog);
			this.guna2GradientPanel2.Controls.Add(this.label5);
			this.guna2GradientPanel2.Controls.Add(this.guna2Button1);
			this.guna2GradientPanel2.Controls.Add(this.UserBoxLog);
			this.guna2GradientPanel2.Controls.Add(this.label4);
			this.guna2GradientPanel2.Controls.Add(this.Upgradebtn);
			this.guna2GradientPanel2.Controls.Add(this.key);
			this.guna2GradientPanel2.Controls.Add(this.UpgradeUserBox);
			this.guna2GradientPanel2.Controls.Add(this.label3);
			this.guna2GradientPanel2.Controls.Add(this.numUsers);
			this.guna2GradientPanel2.Controls.Add(this.onlineUsersBox);
			this.guna2GradientPanel2.Controls.Add(this.guna2CirclePictureBox1);
			this.guna2GradientPanel2.Controls.Add(this.userLbl);
			this.guna2GradientPanel2.Controls.Add(this.label2);
			this.guna2GradientPanel2.Controls.Add(this.label1);
			this.guna2GradientPanel2.Controls.Add(this.LabelTxt);
			this.guna2GradientPanel2.FillColor = global::System.Drawing.Color.FromArgb(168, 194, 238);
			this.guna2GradientPanel2.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel2.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel2.Location = new global::System.Drawing.Point(-7, -6);
			this.guna2GradientPanel2.Name = "guna2GradientPanel2";
			this.guna2GradientPanel2.Size = new global::System.Drawing.Size(773, 467);
			this.guna2GradientPanel2.TabIndex = 4;
			this.Exit.AccessibleName = "Exit";
			this.Exit.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Exit.Animated = true;
			this.Exit.BackColor = global::System.Drawing.Color.Transparent;
			this.Exit.CustomClick = true;
			this.Exit.FillColor = global::System.Drawing.Color.Transparent;
			this.Exit.ForeColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			this.Exit.HoverState.FillColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.Exit.IconColor = global::System.Drawing.Color.White;
			this.Exit.Location = new global::System.Drawing.Point(716, 4);
			this.Exit.Name = "Exit";
			this.Exit.Size = new global::System.Drawing.Size(57, 36);
			this.Exit.TabIndex = 34;
			this.Exit.UseTransparentBackground = true;
			this.Exit.Click += new global::System.EventHandler(this.Exit_Click);
			this.guna2Button2.Animated = true;
			this.guna2Button2.AutoRoundedCorners = true;
			this.guna2Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button2.BorderRadius = 13;
			this.guna2Button2.BorderThickness = 1;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button2.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.FillColor = global::System.Drawing.Color.LightGray;
			this.guna2Button2.Location = new global::System.Drawing.Point(541, 179);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(140, 28);
			this.guna2Button2.TabIndex = 33;
			this.guna2Button2.Text = "Ban";
			this.guna2Button2.UseTransparentBackground = true;
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.BanUserLog.AutoRoundedCorners = true;
			this.BanUserLog.BackColor = global::System.Drawing.Color.Transparent;
			this.BanUserLog.BorderRadius = 12;
			this.BanUserLog.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.BanUserLog.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BanUserLog.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.BanUserLog.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.BanUserLog.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.BanUserLog.ForeColor = global::System.Drawing.Color.Black;
			this.BanUserLog.ItemHeight = 20;
			this.BanUserLog.Location = new global::System.Drawing.Point(541, 147);
			this.BanUserLog.MaxDropDownItems = 100;
			this.BanUserLog.Name = "BanUserLog";
			this.BanUserLog.Size = new global::System.Drawing.Size(140, 26);
			this.BanUserLog.TabIndex = 32;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(538, 129);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(58, 15);
			this.label5.TabIndex = 31;
			this.label5.Text = "Ban user";
			this.guna2Button1.Animated = true;
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button1.BorderRadius = 13;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.LightGray;
			this.guna2Button1.Location = new global::System.Drawing.Point(372, 179);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(140, 28);
			this.guna2Button1.TabIndex = 30;
			this.guna2Button1.Text = "Log";
			this.guna2Button1.UseTransparentBackground = true;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.UserBoxLog.AutoRoundedCorners = true;
			this.UserBoxLog.BackColor = global::System.Drawing.Color.Transparent;
			this.UserBoxLog.BorderRadius = 12;
			this.UserBoxLog.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.UserBoxLog.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UserBoxLog.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UserBoxLog.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UserBoxLog.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.UserBoxLog.ForeColor = global::System.Drawing.Color.Black;
			this.UserBoxLog.ItemHeight = 20;
			this.UserBoxLog.Location = new global::System.Drawing.Point(372, 147);
			this.UserBoxLog.MaxDropDownItems = 100;
			this.UserBoxLog.Name = "UserBoxLog";
			this.UserBoxLog.Size = new global::System.Drawing.Size(140, 26);
			this.UserBoxLog.TabIndex = 28;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(369, 129);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(99, 15);
			this.label4.TabIndex = 27;
			this.label4.Text = "Log information";
			this.Upgradebtn.Animated = true;
			this.Upgradebtn.AutoRoundedCorners = true;
			this.Upgradebtn.BackColor = global::System.Drawing.Color.Transparent;
			this.Upgradebtn.BorderColor = global::System.Drawing.Color.White;
			this.Upgradebtn.BorderRadius = 13;
			this.Upgradebtn.BorderThickness = 1;
			this.Upgradebtn.CustomBorderColor = global::System.Drawing.Color.White;
			this.Upgradebtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Upgradebtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Upgradebtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Upgradebtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Upgradebtn.FillColor = global::System.Drawing.Color.Transparent;
			this.Upgradebtn.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.Upgradebtn.ForeColor = global::System.Drawing.Color.White;
			this.Upgradebtn.HoverState.FillColor = global::System.Drawing.Color.LightGray;
			this.Upgradebtn.Location = new global::System.Drawing.Point(204, 209);
			this.Upgradebtn.Name = "Upgradebtn";
			this.Upgradebtn.Size = new global::System.Drawing.Size(140, 28);
			this.Upgradebtn.TabIndex = 26;
			this.Upgradebtn.Text = "Upgrade";
			this.Upgradebtn.UseTransparentBackground = true;
			this.Upgradebtn.Click += new global::System.EventHandler(this.Upgradebtn_Click);
			this.key.Animated = true;
			this.key.AutoRoundedCorners = true;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(217, 221, 226);
			this.key.BorderRadius = 12;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.key.ForeColor = global::System.Drawing.Color.Black;
			this.key.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.key.Location = new global::System.Drawing.Point(204, 178);
			this.key.Margin = new global::System.Windows.Forms.Padding(2);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderForeColor = global::System.Drawing.Color.LightGray;
			this.key.PlaceholderText = "Key";
			this.key.SelectedText = "";
			this.key.Size = new global::System.Drawing.Size(140, 26);
			this.key.TabIndex = 21;
			this.UpgradeUserBox.AutoRoundedCorners = true;
			this.UpgradeUserBox.BackColor = global::System.Drawing.Color.Transparent;
			this.UpgradeUserBox.BorderRadius = 12;
			this.UpgradeUserBox.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.UpgradeUserBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UpgradeUserBox.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UpgradeUserBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.UpgradeUserBox.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.UpgradeUserBox.ForeColor = global::System.Drawing.Color.Black;
			this.UpgradeUserBox.ItemHeight = 20;
			this.UpgradeUserBox.Location = new global::System.Drawing.Point(204, 147);
			this.UpgradeUserBox.MaxDropDownItems = 100;
			this.UpgradeUserBox.Name = "UpgradeUserBox";
			this.UpgradeUserBox.Size = new global::System.Drawing.Size(140, 26);
			this.UpgradeUserBox.TabIndex = 9;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(201, 129);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(88, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Upgrade user";
			this.numUsers.AutoSize = true;
			this.numUsers.BackColor = global::System.Drawing.Color.Transparent;
			this.numUsers.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.numUsers.ForeColor = global::System.Drawing.Color.White;
			this.numUsers.Location = new global::System.Drawing.Point(42, 129);
			this.numUsers.Name = "numUsers";
			this.numUsers.Size = new global::System.Drawing.Size(43, 15);
			this.numUsers.TabIndex = 7;
			this.numUsers.Text = "label3";
			this.onlineUsersBox.AutoRoundedCorners = true;
			this.onlineUsersBox.BackColor = global::System.Drawing.Color.Transparent;
			this.onlineUsersBox.BorderRadius = 12;
			this.onlineUsersBox.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.onlineUsersBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.onlineUsersBox.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.onlineUsersBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.onlineUsersBox.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold);
			this.onlineUsersBox.ForeColor = global::System.Drawing.Color.Black;
			this.onlineUsersBox.ItemHeight = 20;
			this.onlineUsersBox.Location = new global::System.Drawing.Point(45, 147);
			this.onlineUsersBox.MaxDropDownItems = 100;
			this.onlineUsersBox.Name = "onlineUsersBox";
			this.onlineUsersBox.Size = new global::System.Drawing.Size(140, 26);
			this.onlineUsersBox.TabIndex = 6;
			this.guna2CirclePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = global::Vision_Client.Properties.Resources.woof;
			this.guna2CirclePictureBox1.ImageRotate = 0f;
			this.guna2CirclePictureBox1.Location = new global::System.Drawing.Point(17, 398);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = 1;
			this.guna2CirclePictureBox1.Size = new global::System.Drawing.Size(40, 40);
			this.guna2CirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 5;
			this.guna2CirclePictureBox1.TabStop = false;
			this.guna2CirclePictureBox1.UseTransparentBackground = true;
			this.userLbl.AutoSize = true;
			this.userLbl.BackColor = global::System.Drawing.Color.Transparent;
			this.userLbl.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userLbl.ForeColor = global::System.Drawing.Color.White;
			this.userLbl.Location = new global::System.Drawing.Point(62, 419);
			this.userLbl.Name = "userLbl";
			this.userLbl.Size = new global::System.Drawing.Size(49, 19);
			this.userLbl.TabIndex = 5;
			this.userLbl.Text = "USER";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Inter", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(63, 404);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "LOGGED IN AS";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Inter", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(41, 76);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(125, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Admin Panel";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.LabelTxt.AutoSize = true;
			this.LabelTxt.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTxt.Font = new global::System.Drawing.Font("Inter", 38f, global::System.Drawing.FontStyle.Bold);
			this.LabelTxt.ForeColor = global::System.Drawing.Color.White;
			this.LabelTxt.Location = new global::System.Drawing.Point(19, 15);
			this.LabelTxt.Name = "LabelTxt";
			this.LabelTxt.Size = new global::System.Drawing.Size(345, 61);
			this.LabelTxt.TabIndex = 2;
			this.LabelTxt.Text = "Vision Client";
			this.guna2Elipse1.BorderRadius = 14;
			this.guna2Elipse1.TargetControl = this;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this.guna2GradientPanel2;
			this.guna2DragControl1.UseTransparentDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(766, 450);
			base.Controls.Add(this.guna2GradientPanel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "AdminPanel";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin Panel";
			base.Load += new global::System.EventHandler(this.AdminPanel_Load);
			this.guna2GradientPanel2.ResumeLayout(false);
			this.guna2GradientPanel2.PerformLayout();
			this.guna2CirclePictureBox1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label LabelTxt;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label userLbl;

		// Token: 0x04000021 RID: 33
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;

		// Token: 0x04000022 RID: 34
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000023 RID: 35
		private global::Guna.UI2.WinForms.Guna2ComboBox onlineUsersBox;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label numUsers;

		// Token: 0x04000025 RID: 37
		private global::Guna.UI2.WinForms.Guna2ComboBox UpgradeUserBox;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2TextBox key;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2Button Upgradebtn;

		// Token: 0x04000029 RID: 41
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400002A RID: 42
		private global::Guna.UI2.WinForms.Guna2ComboBox UserBoxLog;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002C RID: 44
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2ComboBox BanUserLog;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2ControlBox Exit;

		// Token: 0x04000030 RID: 48
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
	}
}
