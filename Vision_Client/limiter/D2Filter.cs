using System;
using System.Windows.Forms;
using NetLimiter.Service;

namespace Vision_Client.limiter
{
	// Token: 0x02000019 RID: 25
	internal class D2Filter
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0001CA34 File Offset: 0x0001CA34
		public D2Filter(int whichFilter, NLClient client, RuleDir rule, string appPath, string name, Keys hotkey, KeyModifiers modifiers, uint bps, ushort portStart = 0, ushort portEnd = 0)
		{
			this.whichFilter = whichFilter;
			this.Name = name;
			this.Hotkey = hotkey;
			this.Modifiers = modifiers;
			this._bps = bps;
			this._portStart = portStart;
			this._portEnd = portEnd;
			this._client = client;
			this._filtModel = new Filter(this.Name);
			this._filtModel.Functions.Add(new FFAppIdEqual(new AppId(appPath)));
			bool flag = this._portStart > 0 && this._portEnd > 0;
			if (flag)
			{
				this._filtModel.Functions.Add(new FFRemotePortInRange(new PortRangeFilterValue(this._portStart, this._portEnd)));
			}
			this._ruleModel = new LimitRule(rule, this._bps);
			this._filt = this._client.Filters.Find((Filter x) => x.Name == this.Name);
			bool flag2 = !this.Exists();
			if (flag2)
			{
				this._filt = this._client.AddFilter(this._filtModel);
				this._rule = this._client.AddRule(this._filtModel.Id, this._ruleModel);
			}
			else
			{
				this._rule = this._client.Rules.Find((Rule x) => x.FilterId == this._filt.Id);
			}
			this._rule.IsEnabled = false;
			this._client.UpdateRule(this._rule);
			bool flag3 = hotkey > Keys.None;
			if (flag3)
			{
				this._id = HotKeyManager.RegisterHotKey(this.Hotkey, this.Modifiers);
				HotKeyManager.HotKeyPressed += delegate(object sender, HotKeyEventArgs e)
				{
					bool flag4 = Program.cfg.HotkeyModifier.ToString().ToLower() == "none";
					if (flag4)
					{
						bool flag5 = e.Key == this.Hotkey;
						if (flag5)
						{
							this.Toggle();
						}
					}
					else
					{
						bool flag6 = e.Key == this.Hotkey && e.Modifiers == this.Modifiers;
						if (flag6)
						{
							this.Toggle();
						}
					}
				};
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001CBEC File Offset: 0x0001CBEC
		public void updateAppPath(string appPath)
		{
			this._client.RemoveFilter(this._filt);
			this._filtModel = new Filter(this.Name);
			this._filtModel.Functions.Add(new FFAppIdEqual(new AppId(appPath)));
			bool flag = this._portStart > 0 && this._portEnd > 0;
			if (flag)
			{
				this._filtModel.Functions.Add(new FFRemotePortInRange(new PortRangeFilterValue(this._portStart, this._portEnd)));
			}
			this._ruleModel = new LimitRule(this.rule, this._bps);
			this._filt = this._client.AddFilter(this._filtModel);
			this._rule = this._client.AddRule(this._filtModel.Id, this._ruleModel);
			this._rule.IsEnabled = false;
			this._client.UpdateRule(this._rule);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001CCE8 File Offset: 0x0001CCE8
		public void updateRuleBps(uint bps, RuleDir rule)
		{
			this._client.RemoveFilter(this._filt);
			this._filt = this._client.AddFilter(this._filtModel);
			this._ruleModel = new LimitRule(rule, bps);
			this._rule = this._client.AddRule(this._filtModel.Id, this._ruleModel);
			this._rule.IsEnabled = false;
			this._client.UpdateRule(this._rule);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001CD70 File Offset: 0x0001CD70
		public bool Exists()
		{
			return this._filt != null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001CD8C File Offset: 0x0001CD8C
		public bool IsEnabled()
		{
			return this._rule.IsEnabled;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001CDA9 File Offset: 0x0001CDA9
		public void Toggle()
		{
			this._rule.IsEnabled = !this._rule.IsEnabled;
			this._client.UpdateRule(this._rule);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001CDD8 File Offset: 0x0001CDD8
		public void Disable()
		{
			this._rule.IsEnabled = false;
			this._client.UpdateRule(this._rule);
		}

		// Token: 0x04000180 RID: 384
		public int _id;

		// Token: 0x04000181 RID: 385
		public int whichFilter;

		// Token: 0x04000182 RID: 386
		public string Name;

		// Token: 0x04000183 RID: 387
		public Keys Hotkey;

		// Token: 0x04000184 RID: 388
		public KeyModifiers Modifiers;

		// Token: 0x04000185 RID: 389
		public uint _bps;

		// Token: 0x04000186 RID: 390
		private ushort _portStart;

		// Token: 0x04000187 RID: 391
		private ushort _portEnd;

		// Token: 0x04000188 RID: 392
		private NLClient _client;

		// Token: 0x04000189 RID: 393
		private Filter _filt;

		// Token: 0x0400018A RID: 394
		private Rule _rule;

		// Token: 0x0400018B RID: 395
		private Filter _filtModel;

		// Token: 0x0400018C RID: 396
		private Rule _ruleModel;

		// Token: 0x0400018D RID: 397
		private RuleDir rule;
	}
}
