using System;
using System.IO;
using Newtonsoft.Json;

namespace Vision_Client.limiter
{
	// Token: 0x0200001D RID: 29
	public class NLConfig
	{
		// Token: 0x0600019A RID: 410 RVA: 0x0001D11C File Offset: 0x0001D11C
		public static NLConfig Load()
		{
			NLConfig result;
			try
			{
				string text = File.ReadAllText("config.json");
				result = JsonConvert.DeserializeObject<NLConfig>(text);
			}
			catch (Exception)
			{
				NLConfig nlconfig = new NLConfig();
				File.WriteAllText("config.json", JsonConvert.SerializeObject(nlconfig));
				result = nlconfig;
			}
			return result;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001D170 File Offset: 0x0001D170
		public void changeTheme(string theme, NLConfig config)
		{
			config.theme = theme;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001D18B File Offset: 0x0001D18B
		public void changeAppPath(string appPath, NLConfig config)
		{
			config.AppPath = appPath;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001D1A6 File Offset: 0x0001D1A6
		public void changeHotkey(int hotkey, string changedTo, NLConfig config)
		{
			config.Hotkeys[hotkey] = changedTo;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001D1C3 File Offset: 0x0001D1C3
		public void changeTimerEnabled(bool isTimerEnabled, NLConfig config)
		{
			config.timerEnabled = isTimerEnabled;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001D1DE File Offset: 0x0001D1DE
		public void changesBytesPerSecond(int whichOption, uint bytesPerSecond, NLConfig config)
		{
			config.bytesPerSecond[whichOption] = bytesPerSecond;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001D1FB File Offset: 0x0001D1FB
		public void changeAvatarPath(string newPath, NLConfig config)
		{
			config.avatarPath = newPath;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001D216 File Offset: 0x0001D216
		public void changeUuid(string newUuid, NLConfig config)
		{
			config.uuid = newUuid;
			File.WriteAllText("config.json", JsonConvert.SerializeObject(config));
		}

		// Token: 0x0400019C RID: 412
		public bool timerEnabled = true;

		// Token: 0x0400019D RID: 413
		public string uuid = "0";

		// Token: 0x0400019E RID: 414
		public string theme = "Woof";

		// Token: 0x0400019F RID: 415
		public string avatarPath = "";

		// Token: 0x040001A0 RID: 416
		public string HotkeyModifier = "Control";

		// Token: 0x040001A1 RID: 417
		public uint[] bytesPerSecond = new uint[]
		{
			800U,
			1U,
			1U,
			1U,
			1U,
			1U
		};

		// Token: 0x040001A2 RID: 418
		public string[] FilterList = new string[]
		{
			"Destiny 2",
			"3074",
			"3074 UL",
			"30k",
			"27k",
			"7k",
			"pause"
		};

		// Token: 0x040001A3 RID: 419
		public string[] Hotkeys = new string[]
		{
			"4",
			"1",
			"2",
			"5",
			"6",
			"3",
			"0"
		};

		// Token: 0x040001A4 RID: 420
		public string AppPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Destiny 2\\destiny2.exe";
	}
}
