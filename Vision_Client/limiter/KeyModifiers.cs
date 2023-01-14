using System;

namespace Vision_Client.limiter
{
	// Token: 0x0200001C RID: 28
	[Flags]
	public enum KeyModifiers
	{
		// Token: 0x04000196 RID: 406
		None = 0,
		// Token: 0x04000197 RID: 407
		Alt = 1,
		// Token: 0x04000198 RID: 408
		Control = 2,
		// Token: 0x04000199 RID: 409
		Shift = 4,
		// Token: 0x0400019A RID: 410
		Windows = 8,
		// Token: 0x0400019B RID: 411
		NoRepeat = 16384
	}
}
