namespace Vision_Client.options
{
	// Token: 0x02000017 RID: 23
	public partial class ModuleInformation : global::System.Windows.Forms.Form
	{
		// Token: 0x06000177 RID: 375 RVA: 0x0001A1F0 File Offset: 0x0001A1F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001A228 File Offset: 0x0001A228
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.options.ModuleInformation));
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2GradientPanel1 = new global::Guna.UI2.WinForms.Guna2GradientPanel();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LBL3074 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2GradientPanel1.SuspendLayout();
			base.SuspendLayout();
			this.guna2Elipse1.BorderRadius = 10;
			this.guna2Elipse1.TargetControl = this;
			this.guna2GradientPanel1.Controls.Add(this.label8);
			this.guna2GradientPanel1.Controls.Add(this.label9);
			this.guna2GradientPanel1.Controls.Add(this.label6);
			this.guna2GradientPanel1.Controls.Add(this.label7);
			this.guna2GradientPanel1.Controls.Add(this.label4);
			this.guna2GradientPanel1.Controls.Add(this.label5);
			this.guna2GradientPanel1.Controls.Add(this.label2);
			this.guna2GradientPanel1.Controls.Add(this.label3);
			this.guna2GradientPanel1.Controls.Add(this.label1);
			this.guna2GradientPanel1.Controls.Add(this.LBL3074);
			this.guna2GradientPanel1.Controls.Add(this.guna2ControlBox1);
			this.guna2GradientPanel1.FillColor = global::System.Drawing.Color.Black;
			this.guna2GradientPanel1.FillColor2 = global::System.Drawing.Color.FromArgb(17, 0, 27);
			this.guna2GradientPanel1.Location = new global::System.Drawing.Point(-119, -6);
			this.guna2GradientPanel1.Name = "guna2GradientPanel1";
			this.guna2GradientPanel1.Size = new global::System.Drawing.Size(1044, 629);
			this.guna2GradientPanel1.TabIndex = 15;
			this.label8.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Transparent;
			this.label8.Font = new global::System.Drawing.Font("Inter Medium", 9f);
			this.label8.ForeColor = global::System.Drawing.Color.FromArgb(156, 0, 255);
			this.label8.Location = new global::System.Drawing.Point(131, 557);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(218, 45);
			this.label8.TabIndex = 28;
			this.label8.Text = "- GoS motes (quicker sync and DC)\t\t\t\t\t\t\t\t\t\t\t\t\t\t \t\r\n- Rally flag (quicker sync and DC)\t\t\t\t\t\t\t\t\t\t\t\t\t\t \r\n- Rhulk dunks (quicker sync and DC)";
			this.label9.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label9.AutoSize = true;
			this.label9.BackColor = global::System.Drawing.Color.Transparent;
			this.label9.Font = new global::System.Drawing.Font("Inter", 12f, global::System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(131, 537);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(83, 19);
			this.label9.TabIndex = 27;
			this.label9.Text = "Full game";
			this.label6.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.Transparent;
			this.label6.Font = new global::System.Drawing.Font("Inter Medium", 9f);
			this.label6.ForeColor = global::System.Drawing.Color.FromArgb(156, 0, 255);
			this.label6.Location = new global::System.Drawing.Point(131, 510);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(365, 15);
			this.label6.TabIndex = 26;
			this.label6.Text = "- 5s before hitting rally flag for unlimited rally flag (around 35s)";
			this.label7.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.Transparent;
			this.label7.Font = new global::System.Drawing.Font("Inter", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(131, 490);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(30, 19);
			this.label7.TabIndex = 25;
			this.label7.Text = "7K";
			this.label4.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.Transparent;
			this.label4.Font = new global::System.Drawing.Font("Inter Medium", 9f);
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(156, 0, 255);
			this.label4.Location = new global::System.Drawing.Point(131, 380);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(327, 105);
			this.label4.TabIndex = 24;
			this.label4.Text = componentResourceManager.GetString("label4.Text");
			this.label5.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Arial Rounded MT Bold", 12f);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(131, 360);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(40, 18);
			this.label5.TabIndex = 23;
			this.label5.Text = "27K";
			this.label2.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Inter Medium", 9f);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(156, 0, 255);
			this.label2.Location = new global::System.Drawing.Point(131, 252);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(617, 105);
			this.label2.TabIndex = 22;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			this.label3.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Inter", 12f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(131, 232);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(42, 19);
			this.label3.TabIndex = 21;
			this.label3.Text = "30K";
			this.label1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Inter Medium", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(156, 0, 255);
			this.label1.Location = new global::System.Drawing.Point(131, 75);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(655, 150);
			this.label1.TabIndex = 20;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.LBL3074.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
			this.LBL3074.AutoSize = true;
			this.LBL3074.BackColor = global::System.Drawing.Color.Transparent;
			this.LBL3074.Font = new global::System.Drawing.Font("Inter", 12f, global::System.Drawing.FontStyle.Bold);
			this.LBL3074.ForeColor = global::System.Drawing.Color.White;
			this.LBL3074.Location = new global::System.Drawing.Point(131, 55);
			this.LBL3074.Name = "LBL3074";
			this.LBL3074.Size = new global::System.Drawing.Size(51, 19);
			this.LBL3074.TabIndex = 19;
			this.LBL3074.Text = "3074";
			this.guna2ControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.BorderRadius = 10;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(972, 18);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(51, 38);
			this.guna2ControlBox1.TabIndex = 18;
			this.guna2ControlBox1.UseTransparentBackground = true;
			this.guna2ControlBox1.Click += new global::System.EventHandler(this.guna2ControlBox1_Click);
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.7;
			this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(919, 611);
			base.Controls.Add(this.guna2GradientPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ModuleInformation";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Module Information";
			base.Load += new global::System.EventHandler(this.ModuleInformation_Load);
			this.guna2GradientPanel1.ResumeLayout(false);
			this.guna2GradientPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000157 RID: 343
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000158 RID: 344
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000159 RID: 345
		private global::Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x0400015A RID: 346
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400015B RID: 347
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400015C RID: 348
		private global::System.Windows.Forms.Label LBL3074;

		// Token: 0x0400015D RID: 349
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400015E RID: 350
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400015F RID: 351
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000160 RID: 352
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000161 RID: 353
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000162 RID: 354
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000163 RID: 355
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000164 RID: 356
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.Timer timer1;
	}
}
