namespace Vision_Client.options
{
	// Token: 0x02000018 RID: 24
	public partial class ModuleOption : global::System.Windows.Forms.Form
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0001B7F8 File Offset: 0x0001B7F8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001B830 File Offset: 0x0001B830
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.options.ModuleOption));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.module = new global::System.Windows.Forms.Label();
			this.hotkeyTextBox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.setHotkeyButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel4 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label4 = new global::System.Windows.Forms.Label();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.setBytes = new global::Guna.UI2.WinForms.Guna2Button();
			this.bytesPerSecondText = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2GradientPanel1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel4.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 15;
			this.guna2Elipse1.TargetControl = this;
			this.guna2GradientPanel1.BorderRadius = 10;
			this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
			this.guna2GradientPanel1.Controls.Add(this.module);
			this.guna2GradientPanel1.FillColor = global::System.Drawing.Color.FromArgb(168, 194, 238);
			this.guna2GradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(249, 194, 235);
			this.guna2GradientPanel1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-3, -33);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(515, 88);
			this.guna2GradientPanel1.TabIndex = 0;
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderRadius = 10;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.FromArgb(139, 152, 166);
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(447, 40);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(51, 38);
			this.guna2ControlBox1.TabIndex = 17;
			this.guna2ControlBox1.UseTransparentBackground = true;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.module.AutoSize = true;
			this.module.BackColor = global::System.Drawing.Color.Transparent;
			this.module.Font = new global::System.Drawing.Font("Inter", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.module.ForeColor = global::System.Drawing.Color.White;
			this.module.Location = new global::System.Drawing.Point(15, 48);
			this.module.Name = "module";
			this.module.Size = new global::System.Drawing.Size(179, 25);
			this.module.TabIndex = 16;
			this.module.Text = "3074 DL Module";
			this.hotkeyTextBox.BorderRadius = 10;
			this.hotkeyTextBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.hotkeyTextBox.DefaultText = "F0";
			this.hotkeyTextBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.hotkeyTextBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.hotkeyTextBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.hotkeyTextBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.hotkeyTextBox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.hotkeyTextBox.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hotkeyTextBox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.hotkeyTextBox.Location = new global::System.Drawing.Point(10, 83);
			this.hotkeyTextBox.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.hotkeyTextBox.MaxLength = 5;
			this.hotkeyTextBox.Name = "hotkeyTextBox";
			this.hotkeyTextBox.PasswordChar = '\0';
			this.hotkeyTextBox.PlaceholderText = "";
			this.hotkeyTextBox.SelectedText = "";
			this.hotkeyTextBox.Size = new global::System.Drawing.Size(68, 36);
			this.hotkeyTextBox.TabIndex = 1;
			this.hotkeyTextBox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.setHotkeyButton.BorderRadius = 8;
			this.setHotkeyButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.setHotkeyButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.setHotkeyButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.setHotkeyButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.setHotkeyButton.FillColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.setHotkeyButton.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.setHotkeyButton.ForeColor = global::System.Drawing.Color.White;
			this.setHotkeyButton.Location = new global::System.Drawing.Point(85, 78);
			this.setHotkeyButton.Name = "setHotkeyButton";
			this.setHotkeyButton.Size = new global::System.Drawing.Size(111, 45);
			this.setHotkeyButton.TabIndex = 11;
			this.setHotkeyButton.Text = "Set Hotkey";
			this.setHotkeyButton.Click += new global::System.EventHandler(this.setHotkeyButton_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 142);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(227, 30);
			this.label1.TabIndex = 12;
			this.label1.Text = "PREVIOUSLY USED IN";
			this.guna2Panel1.Controls.Add(this.guna2Panel4);
			this.guna2Panel1.Controls.Add(this.guna2Panel3);
			this.guna2Panel1.Controls.Add(this.guna2Panel2);
			this.guna2Panel1.Location = new global::System.Drawing.Point(4, 176);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(720, 235);
			this.guna2Panel1.TabIndex = 13;
			this.guna2Panel4.AutoRoundedCorners = true;
			this.guna2Panel4.BackgroundImage = global::Vision_Client.Properties.Resources.Garden_of_salvation_final;
			this.guna2Panel4.BorderRadius = 26;
			this.guna2Panel4.Controls.Add(this.label5);
			this.guna2Panel4.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Panel4.Location = new global::System.Drawing.Point(3, 129);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new global::System.Drawing.Size(489, 55);
			this.guna2Panel4.TabIndex = 2;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(126, 9);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(255, 30);
			this.label5.TabIndex = 14;
			this.label5.Text = "GARDEN OF SALVATION";
			this.guna2Panel3.AutoRoundedCorners = true;
			this.guna2Panel3.BackgroundImage = global::Vision_Client.Properties.Resources.Garden_of_salvation_final;
			this.guna2Panel3.BorderRadius = 26;
			this.guna2Panel3.Controls.Add(this.label4);
			this.guna2Panel3.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Panel3.Location = new global::System.Drawing.Point(3, 68);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new global::System.Drawing.Size(489, 55);
			this.guna2Panel3.TabIndex = 1;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(126, 9);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(255, 30);
			this.label4.TabIndex = 14;
			this.label4.Text = "GARDEN OF SALVATION";
			this.guna2Panel2.AutoRoundedCorners = true;
			this.guna2Panel2.BackgroundImage = global::Vision_Client.Properties.Resources.DSC_Final;
			this.guna2Panel2.BorderRadius = 26;
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Panel2.Location = new global::System.Drawing.Point(3, 7);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(489, 55);
			this.guna2Panel2.TabIndex = 0;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(145, 9);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(207, 30);
			this.label2.TabIndex = 14;
			this.label2.Text = "DEEP STONE CRYPT";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Light", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Gray;
			this.label3.Location = new global::System.Drawing.Point(217, 149);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(142, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "(Just an example atm)";
			this.guna2AnimateWindow1.AnimationType = 262144;
			this.guna2AnimateWindow1.Interval = 0;
			this.guna2AnimateWindow1.TargetForm = this;
			this.setBytes.BorderRadius = 8;
			this.setBytes.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.setBytes.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.setBytes.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.setBytes.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.setBytes.FillColor = global::System.Drawing.Color.FromArgb(114, 137, 218);
			this.setBytes.Font = new global::System.Drawing.Font("Inter", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.setBytes.ForeColor = global::System.Drawing.Color.White;
			this.setBytes.Location = new global::System.Drawing.Point(366, 78);
			this.setBytes.Name = "setBytes";
			this.setBytes.Size = new global::System.Drawing.Size(111, 45);
			this.setBytes.TabIndex = 17;
			this.setBytes.Text = "Set Bytes";
			this.setBytes.Click += new global::System.EventHandler(this.setBytes_Click);
			this.bytesPerSecondText.BorderRadius = 10;
			this.bytesPerSecondText.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.bytesPerSecondText.DefaultText = "800";
			this.bytesPerSecondText.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.bytesPerSecondText.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.bytesPerSecondText.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.bytesPerSecondText.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.bytesPerSecondText.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.bytesPerSecondText.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bytesPerSecondText.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.bytesPerSecondText.Location = new global::System.Drawing.Point(291, 83);
			this.bytesPerSecondText.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bytesPerSecondText.MaxLength = 4;
			this.bytesPerSecondText.Name = "bytesPerSecondText";
			this.bytesPerSecondText.PasswordChar = '\0';
			this.bytesPerSecondText.PlaceholderText = "";
			this.bytesPerSecondText.SelectedText = "";
			this.bytesPerSecondText.Size = new global::System.Drawing.Size(68, 36);
			this.bytesPerSecondText.TabIndex = 16;
			this.bytesPerSecondText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.bytesPerSecondText.TextChanged += new global::System.EventHandler(this.bytesPerSecondText_TextChanged);
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.8;
			this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(32, 33, 36);
			base.ClientSize = new global::System.Drawing.Size(512, 373);
			base.Controls.Add(this.setBytes);
			base.Controls.Add(this.bytesPerSecondText);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.setHotkeyButton);
			base.Controls.Add(this.hotkeyTextBox);
			base.Controls.Add(this.guna2GradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ModuleOption";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Module Options";
			base.Load += new global::System.EventHandler(this.ModuleOption_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400016B RID: 363
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400016C RID: 364
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x0400016D RID: 365
		private global::Guna.UI2.WinForms.Guna2TextBox hotkeyTextBox;

		// Token: 0x0400016E RID: 366
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x0400016F RID: 367
		private global::Guna.UI2.WinForms.Guna2Button setHotkeyButton;

		// Token: 0x04000170 RID: 368
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x04000171 RID: 369
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000174 RID: 372
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel3;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000177 RID: 375
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel4;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Label module;

		// Token: 0x0400017A RID: 378
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400017B RID: 379
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400017C RID: 380
		private global::Guna.UI2.WinForms.Guna2Button setBytes;

		// Token: 0x0400017D RID: 381
		private global::Guna.UI2.WinForms.Guna2TextBox bytesPerSecondText;

		// Token: 0x0400017E RID: 382
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.Timer timer1;
	}
}
