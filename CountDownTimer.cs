using System;
using System.Diagnostics;
using System.Windows.Forms;

// Token: 0x02000002 RID: 2
public class CountDownTimer : IDisposable
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00002048
	public bool IsRunning
	{
		get
		{
			return this.timer.Enabled;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002055 File Offset: 0x00002055
	// (set) Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00002062
	public int StepMs
	{
		get
		{
			return this.timer.Interval;
		}
		set
		{
			this.timer.Interval = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002074 File Offset: 0x00002074
	public TimeSpan TimeLeft
	{
		get
		{
			return (this._max.TotalMilliseconds - (double)this._stpWatch.ElapsedMilliseconds > 0.0) ? TimeSpan.FromMilliseconds(this._max.TotalMilliseconds - (double)this._stpWatch.ElapsedMilliseconds) : TimeSpan.FromMilliseconds(0.0);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000005 RID: 5 RVA: 0x000020D1 File Offset: 0x000020D1
	private bool _mustStop
	{
		get
		{
			return this._max.TotalMilliseconds - (double)this._stpWatch.ElapsedMilliseconds < 0.0;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000006 RID: 6 RVA: 0x000020F8 File Offset: 0x000020F8
	public string TimeLeftStr
	{
		get
		{
			return this.TimeLeft.ToString("\\mm\\:ss");
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002118 File Offset: 0x00002118
	public string TimeLeftMsStr
	{
		get
		{
			return this.TimeLeft.ToString("mm\\:ss\\.fff");
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002138 File Offset: 0x00002138
	private void TimerTick(object sender, EventArgs e)
	{
		Action timeChanged = this.TimeChanged;
		if (timeChanged != null)
		{
			timeChanged();
		}
		bool mustStop = this._mustStop;
		if (mustStop)
		{
			Action countDownFinished = this.CountDownFinished;
			if (countDownFinished != null)
			{
				countDownFinished();
			}
			this._stpWatch.Stop();
			this.timer.Enabled = false;
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002190 File Offset: 0x00002190
	public CountDownTimer(int min, int sec)
	{
		this.SetTime(min, sec);
		this.Init();
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000021E0 File Offset: 0x000021E0
	public CountDownTimer(TimeSpan ts)
	{
		this.SetTime(ts);
		this.Init();
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000222E File Offset: 0x0000222E
	public CountDownTimer()
	{
		this.Init();
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002269 File Offset: 0x00002269
	private void Init()
	{
		this.StepMs = 1000;
		this.timer.Tick += this.TimerTick;
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002290 File Offset: 0x00002290
	public void SetTime(TimeSpan ts)
	{
		this._max = ts;
		Action timeChanged = this.TimeChanged;
		if (timeChanged != null)
		{
			timeChanged();
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000022AC File Offset: 0x000022AC
	public void SetTime(int min, int sec = 0)
	{
		this.SetTime(TimeSpan.FromSeconds((double)(min * 60 + sec)));
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000022C1 File Offset: 0x000022C1
	public void Start()
	{
		this.timer.Start();
		this._stpWatch.Start();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000022DC File Offset: 0x000022DC
	public void Pause()
	{
		this.timer.Stop();
		this._stpWatch.Stop();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000022F7 File Offset: 0x000022F7
	public void Stop()
	{
		this.Reset();
		this.Pause();
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002308 File Offset: 0x00002308
	public void Reset()
	{
		this._stpWatch.Reset();
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002317 File Offset: 0x00002317
	public void Restart()
	{
		this._stpWatch.Reset();
		this.timer.Start();
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002332 File Offset: 0x00002332
	public void Dispose()
	{
		this.timer.Dispose();
	}

	// Token: 0x04000001 RID: 1
	public Stopwatch _stpWatch = new Stopwatch();

	// Token: 0x04000002 RID: 2
	public Action TimeChanged;

	// Token: 0x04000003 RID: 3
	public Action CountDownFinished;

	// Token: 0x04000004 RID: 4
	private Timer timer = new Timer();

	// Token: 0x04000005 RID: 5
	private TimeSpan _max = TimeSpan.FromMilliseconds(30000.0);
}
