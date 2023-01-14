using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Vision_Client.Properties
{
	// Token: 0x02000016 RID: 22
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00019828 File Offset: 0x00019828
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00019840 File Offset: 0x00019840
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00019862 File Offset: 0x00019862
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string FileString
		{
			get
			{
				return (string)this["FileString"];
			}
			set
			{
				this["FileString"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00019874 File Offset: 0x00019874
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00019896 File Offset: 0x00019896
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Username
		{
			get
			{
				return (string)this["Username"];
			}
			set
			{
				this["Username"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000198A8 File Offset: 0x000198A8
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000198CA File Offset: 0x000198CA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000198DC File Offset: 0x000198DC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000198FE File Offset: 0x000198FE
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool register
		{
			get
			{
				return (bool)this["register"];
			}
			set
			{
				this["register"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00019914 File Offset: 0x00019914
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00019936 File Offset: 0x00019936
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string User
		{
			get
			{
				return (string)this["User"];
			}
			set
			{
				this["User"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00019948 File Offset: 0x00019948
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0001996A File Offset: 0x0001996A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Pass
		{
			get
			{
				return (string)this["Pass"];
			}
			set
			{
				this["Pass"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0001997C File Offset: 0x0001997C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0001999E File Offset: 0x0001999E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Color
		{
			get
			{
				return (string)this["Color"];
			}
			set
			{
				this["Color"] = value;
			}
		}

		// Token: 0x04000156 RID: 342
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
