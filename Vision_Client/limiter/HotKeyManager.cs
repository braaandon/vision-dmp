using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Vision_Client.limiter
{
	// Token: 0x0200001A RID: 26
	public static class HotKeyManager
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600018D RID: 397 RVA: 0x0001CEA4 File Offset: 0x0001CEA4
		// (remove) Token: 0x0600018E RID: 398 RVA: 0x0001CED8 File Offset: 0x0001CED8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event EventHandler<HotKeyEventArgs> HotKeyPressed;

		// Token: 0x0600018F RID: 399 RVA: 0x0001CF0C File Offset: 0x0001CF0C
		public static int RegisterHotKey(Keys key, KeyModifiers modifiers)
		{
			HotKeyManager._windowReadyEvent.WaitOne();
			int num = Interlocked.Increment(ref HotKeyManager._id);
			HotKeyManager._wnd.Invoke(new HotKeyManager.RegisterHotKeyDelegate(HotKeyManager.RegisterHotKeyInternal), new object[]
			{
				HotKeyManager._hwnd,
				num,
				(uint)modifiers,
				(uint)key
			});
			return num;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001CF80 File Offset: 0x0001CF80
		public static int RegisterHotKey(Keys key)
		{
			HotKeyManager._windowReadyEvent.WaitOne();
			int num = Interlocked.Increment(ref HotKeyManager._id);
			HotKeyManager._wnd.Invoke(new HotKeyManager.RegisterHotKeyDelegate(HotKeyManager.RegisterHotKeyInternal), new object[]
			{
				HotKeyManager._hwnd,
				num,
				0,
				(uint)key
			});
			return num;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001CFF2 File Offset: 0x0001CFF2
		public static void UnregisterHotKey(int id)
		{
			HotKeyManager._wnd.Invoke(new HotKeyManager.UnRegisterHotKeyDelegate(HotKeyManager.UnRegisterHotKeyInternal), new object[]
			{
				HotKeyManager._hwnd,
				id
			});
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001D02C File Offset: 0x0001D02C
		private static void RegisterHotKeyInternal(IntPtr hwnd, int id, uint modifiers, uint key)
		{
			HotKeyManager.RegisterHotKey(hwnd, id, modifiers, key);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001D039 File Offset: 0x0001D039
		private static void UnRegisterHotKeyInternal(IntPtr hwnd, int id)
		{
			HotKeyManager.UnregisterHotKey(HotKeyManager._hwnd, id);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001D04C File Offset: 0x0001D04C
		private static void OnHotKeyPressed(HotKeyEventArgs e)
		{
			bool flag = HotKeyManager.HotKeyPressed != null;
			if (flag)
			{
				HotKeyManager.HotKeyPressed(null, e);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001D078 File Offset: 0x0001D078
		static HotKeyManager()
		{
			new Thread(delegate()
			{
				Application.Run(new HotKeyManager.MessageWindow());
			})
			{
				Name = "MessageLoopThread",
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000196 RID: 406
		[DllImport("user32", SetLastError = true)]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x06000197 RID: 407
		[DllImport("user32", SetLastError = true)]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x0400018F RID: 399
		private static volatile HotKeyManager.MessageWindow _wnd;

		// Token: 0x04000190 RID: 400
		private static volatile IntPtr _hwnd;

		// Token: 0x04000191 RID: 401
		private static ManualResetEvent _windowReadyEvent = new ManualResetEvent(false);

		// Token: 0x04000192 RID: 402
		private static int _id = 0;

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void RegisterHotKeyDelegate(IntPtr hwnd, int id, uint modifiers, uint key);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate void UnRegisterHotKeyDelegate(IntPtr hwnd, int id);

		// Token: 0x02000040 RID: 64
		private class MessageWindow : Form
		{
			// Token: 0x0600026A RID: 618 RVA: 0x0001F1F1 File Offset: 0x0001F1F1
			public MessageWindow()
			{
				HotKeyManager._wnd = this;
				HotKeyManager._hwnd = base.Handle;
				HotKeyManager._windowReadyEvent.Set();
			}

			// Token: 0x0600026B RID: 619 RVA: 0x0001F21C File Offset: 0x0001F21C
			protected override void WndProc(ref Message m)
			{
				bool flag = m.Msg == 786;
				if (flag)
				{
					HotKeyEventArgs e = new HotKeyEventArgs(m.LParam);
					HotKeyManager.OnHotKeyPressed(e);
				}
				base.WndProc(ref m);
			}

			// Token: 0x0600026C RID: 620 RVA: 0x0001F258 File Offset: 0x0001F258
			protected override void SetVisibleCore(bool value)
			{
				base.SetVisibleCore(false);
			}

			// Token: 0x0400022F RID: 559
			private const int WM_HOTKEY = 786;
		}
	}
}
