using System;
using System.Drawing;

namespace Vision_Client.discord
{
	// Token: 0x02000021 RID: 33
	internal class Role
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0001DF8C File Offset: 0x0001DF8C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0001DF94 File Offset: 0x0001DF94
		public string _name { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0001DF9D File Offset: 0x0001DF9D
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0001DFA5 File Offset: 0x0001DFA5
		public Color _color { get; set; }

		// Token: 0x060001C1 RID: 449 RVA: 0x0001DFAE File Offset: 0x0001DFAE
		public Role(string name, Color color)
		{
			this._name = name;
			this._color = color;
		}
	}
}
