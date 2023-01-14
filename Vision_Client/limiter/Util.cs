using System;
using System.Windows.Forms;

namespace Vision_Client.limiter
{
	// Token: 0x0200001F RID: 31
	internal class Util
	{
		// Token: 0x060001AF RID: 431 RVA: 0x0001DCD4 File Offset: 0x0001DCD4
		public static Keys GetKey(string key)
		{
			return (Keys)Util.keysConverter.ConvertFromString(key);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001DCF8 File Offset: 0x0001DCF8
		public static KeyModifiers GetModifier(string modifier)
		{
			KeyModifiers result;
			if (!(modifier == "None"))
			{
				if (!(modifier == "NoRepeat"))
				{
					if (!(modifier == "Control"))
					{
						if (!(modifier == "Windows"))
						{
							if (!(modifier == "Alt"))
							{
								if (!(modifier == "Shift"))
								{
									result = KeyModifiers.Control;
								}
								else
								{
									result = KeyModifiers.Shift;
								}
							}
							else
							{
								result = KeyModifiers.Alt;
							}
						}
						else
						{
							result = KeyModifiers.Windows;
						}
					}
					else
					{
						result = KeyModifiers.Control;
					}
				}
				else
				{
					result = KeyModifiers.NoRepeat;
				}
			}
			else
			{
				result = KeyModifiers.None;
			}
			return result;
		}

		// Token: 0x040001B3 RID: 435
		private static KeysConverter keysConverter = new KeysConverter();
	}
}
