using System;
using System.Windows.Forms;

namespace Vision_Client.limiter
{
	// Token: 0x0200001B RID: 27
	public class HotKeyEventArgs : EventArgs
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0001D0C8 File Offset: 0x0001D0C8
		public HotKeyEventArgs(Keys key, KeyModifiers modifiers)
		{
			this.Key = key;
			this.Modifiers = modifiers;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001D0E0 File Offset: 0x0001D0E0
		public HotKeyEventArgs(IntPtr hotKeyParam)
		{
			uint num = (uint)hotKeyParam.ToInt64();
			this.Key = (Keys)((num & 4294901760U) >> 16);
			this.Modifiers = (KeyModifiers)(num & 65535U);
		}

		// Token: 0x04000193 RID: 403
		public readonly Keys Key;

		// Token: 0x04000194 RID: 404
		public readonly KeyModifiers Modifiers;
	}
}
