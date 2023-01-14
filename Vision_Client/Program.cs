using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Timers;
using System.Windows.Forms;
using DiscordRPC;
using KeyAuth;
using NetLimiter.Service;
using Vision_Client.discord;
using Vision_Client.limiter;
using Vision_Client.Properties;
using Vision_Client.splash;

namespace Vision_Client
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000C54E File Offset: 0x0000C54E
		public static bool IsAdministrator
		{
			get
			{
				return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000C564 File Offset: 0x0000C564
		[STAThread]
		private static void Main()
		{
			bool flag = !Program.IsAdministrator;
			if (flag)
			{
				MessageBox.Show("Please run as Administrator");
				Program.restartAsAdministrator();
			}
			else
			{
				try
				{
					Program.nlClient.Connect(null, 0, null, null);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				Program.filters = new List<D2Filter>
				{
					new D2Filter(0, Program.nlClient, RuleDir.In, Program.cfg.AppPath, "Destiny 2", Util.GetKey(Program.cfg.Hotkeys[0]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[0], 0, 0),
					new D2Filter(1, Program.nlClient, RuleDir.In, Program.cfg.AppPath, "3074", Util.GetKey(Program.cfg.Hotkeys[1]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[1], 3074, 3074),
					new D2Filter(2, Program.nlClient, RuleDir.Out, Program.cfg.AppPath, "3074 UL", Util.GetKey(Program.cfg.Hotkeys[2]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[2], 3074, 3074),
					new D2Filter(3, Program.nlClient, RuleDir.In, Program.cfg.AppPath, "30k", Util.GetKey(Program.cfg.Hotkeys[3]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[3], 30000, 30009),
					new D2Filter(4, Program.nlClient, RuleDir.In, Program.cfg.AppPath, "27k", Util.GetKey(Program.cfg.Hotkeys[4]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[4], 27015, 27200),
					new D2Filter(5, Program.nlClient, RuleDir.In, Program.cfg.AppPath, "7k", Util.GetKey(Program.cfg.Hotkeys[5]), Util.GetModifier(Program.cfg.HotkeyModifier), Program.cfg.bytesPerSecond[5], 7500, 7509)
				};
				Program.client = new DiscordRpcClient("1054128570756251698");
				Program.client.Initialize();
				Timer timer = new Timer(150.0);
				timer.Elapsed += delegate(object sender, ElapsedEventArgs args)
				{
					Program.client.Invoke();
				};
				timer.Start();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				NLConfig nlconfig = NLConfig.Load();
				bool flag2 = nlconfig.theme == "Bruce";
				if (flag2)
				{
					try
					{
					}
					catch (Exception)
					{
					}
					Program.setPresence("Browsing Modules", new Button[]
					{
						new Button
						{
							Label = "Server",
							Url = "https://discord.gg/woofs"
						}
					}, new Assets
					{
						LargeImageKey = "vision_client_logo",
						LargeImageText = "",
						SmallImageKey = ""
					});
					Application.Run(new MainSplash());
				}
				else
				{
					bool flag3 = nlconfig.theme == "Woof";
					if (flag3)
					{
						Program.setPresence("Browsing Modules", new Button[]
						{
							new Button
							{
								Label = "Server",
								Url = "https://discord.gg/woofs"
							}
						}, new Assets
						{
							LargeImageKey = "wooficon",
							LargeImageText = "",
							SmallImageKey = ""
						});
						Application.Run(new MainSplash());
					}
					else
					{
						Program.setPresence("Browsing Modules", new Button[]
						{
							new Button
							{
								Label = "Server",
								Url = "https://discord.gg/woofs"
							}
						}, new Assets
						{
							LargeImageKey = "wooficon",
							LargeImageText = "",
							SmallImageKey = ""
						});
						Application.Run(new MainSplash());
					}
				}
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000C9C4 File Offset: 0x0000C9C4
		public static void setPresence(string state, Button[] buttons, Assets assets)
		{
			bool flag = Program.account != null;
			if (flag)
			{
				Program.client.SetPresence(new RichPresence
				{
					Details = "User: " + Settings.Default.User,
					State = state,
					Timestamps = Program.timestamps,
					Buttons = buttons,
					Assets = assets
				});
			}
			else
			{
				Program.client.SetPresence(new RichPresence
				{
					Details = "User: " + Settings.Default.User,
					State = state,
					Timestamps = Program.timestamps,
					Buttons = buttons,
					Assets = assets
				});
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000CA80 File Offset: 0x0000CA80
		public static void restartAsAdministrator()
		{
			Process.Start(new ProcessStartInfo(Assembly.GetEntryAssembly().Location, "Vision")
			{
				UseShellExecute = true,
				Verb = "runas"
			});
		}

		// Token: 0x04000092 RID: 146
		public static Timestamps timestamps = new Timestamps(DateTime.UtcNow);

		// Token: 0x04000093 RID: 147
		public static DiscordRpcClient client;

		// Token: 0x04000094 RID: 148
		public static NLClient nlClient = new NLClient();

		// Token: 0x04000095 RID: 149
		public static NLConfig cfg = NLConfig.Load();

		// Token: 0x04000096 RID: 150
		public static Account account;

		// Token: 0x04000097 RID: 151
		public static List<D2Filter> filters;

		// Token: 0x04000098 RID: 152
		public static api KeyAuthApp = new api("vision", "KY9CDwpQ4Z", "229acf0e5407f53d0440d96b272d509ece74bec18748ac46daa64a5ef514adac", "1.2");
	}
}
