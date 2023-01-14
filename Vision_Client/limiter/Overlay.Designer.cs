namespace Vision_Client.limiter
{
	// Token: 0x0200001E RID: 30
	public partial class Overlay : global::System.Windows.Forms.Form
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0001D6B4 File Offset: 0x0001D6B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001D6EC File Offset: 0x0001D6EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vision_Client.limiter.Overlay));
			this.modulePanel = new global::Guna.UI2.WinForms.Guna2Panel();
			this.isEnabled = new global::System.Windows.Forms.Label();
			this.moduleLabel = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.moduleTick = new global::System.Windows.Forms.PictureBox();
			this.timerText = new global::System.Windows.Forms.Label();
			this.modulePanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.moduleTick).BeginInit();
			base.SuspendLayout();
			this.modulePanel.BackColor = global::System.Drawing.Color.Transparent;
			this.modulePanel.BorderRadius = 6;
			this.modulePanel.Controls.Add(this.isEnabled);
			this.modulePanel.Controls.Add(this.moduleLabel);
			this.modulePanel.Controls.Add(this.label1);
			this.modulePanel.Controls.Add(this.moduleTick);
			this.modulePanel.FillColor = global::System.Drawing.Color.FromArgb(44, 47, 51);
			this.modulePanel.ForeColor = global::System.Drawing.Color.Transparent;
			this.modulePanel.Location = new global::System.Drawing.Point(14, 42);
			this.modulePanel.Name = "modulePanel";
			this.modulePanel.Size = new global::System.Drawing.Size(210, 55);
			this.modulePanel.TabIndex = 0;
			this.modulePanel.VisibleChanged += new global::System.EventHandler(this.modulePanel_VisibleChanged);
			this.isEnabled.AutoSize = true;
			this.isEnabled.BackColor = global::System.Drawing.Color.Transparent;
			this.isEnabled.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.isEnabled.ForeColor = global::System.Drawing.Color.PaleGreen;
			this.isEnabled.Location = new global::System.Drawing.Point(131, 29);
			this.isEnabled.Name = "isEnabled";
			this.isEnabled.Size = new global::System.Drawing.Size(45, 16);
			this.isEnabled.TabIndex = 2;
			this.isEnabled.Text = "enabled";
			this.moduleLabel.AutoSize = true;
			this.moduleLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.moduleLabel.Font = new global::System.Drawing.Font("Arial Narrow", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.moduleLabel.ForeColor = global::System.Drawing.Color.White;
			this.moduleLabel.Location = new global::System.Drawing.Point(71, 29);
			this.moduleLabel.Name = "moduleLabel";
			this.moduleLabel.Size = new global::System.Drawing.Size(64, 16);
			this.moduleLabel.TabIndex = 1;
			this.moduleLabel.Text = "Module was";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(69, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(131, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Module Toggled";
			this.moduleTick.BackColor = global::System.Drawing.Color.Transparent;
			this.moduleTick.Image = global::Vision_Client.Properties.Resources.vecteezy_tick_icon_accept_approve_sign_design_10151789_177;
			this.moduleTick.Location = new global::System.Drawing.Point(0, 6);
			this.moduleTick.Name = "moduleTick";
			this.moduleTick.Size = new global::System.Drawing.Size(65, 41);
			this.moduleTick.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.moduleTick.TabIndex = 3;
			this.moduleTick.TabStop = false;
			this.timerText.AutoSize = true;
			this.timerText.ForeColor = global::System.Drawing.Color.White;
			this.timerText.Location = new global::System.Drawing.Point(14, 23);
			this.timerText.Name = "timerText";
			this.timerText.Size = new global::System.Drawing.Size(49, 13);
			this.timerText.TabIndex = 1;
			this.timerText.Text = "00:00:00";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(230, 223);
			base.Controls.Add(this.timerText);
			base.Controls.Add(this.modulePanel);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Overlay";
			this.modulePanel.ResumeLayout(false);
			this.modulePanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.moduleTick).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001AC RID: 428
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040001AD RID: 429
		private global::Guna.UI2.WinForms.Guna2Panel modulePanel;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.PictureBox moduleTick;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.Label isEnabled;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.Label moduleLabel;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Label timerText;
	}
}
