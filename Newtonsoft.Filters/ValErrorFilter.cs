using _0008;
using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	internal sealed class ValErrorFilter
	{
		[CompilerGenerated]
		private bool _BaseTest;

		[CompilerGenerated]
		private readonly Exception containerTest;

		[CompilerGenerated]
		[_0008._0012(2)]
		private readonly object m_ProccesorTest;

		[CompilerGenerated]
		[_0008._0012(2)]
		private readonly object adapterTest;

		[CompilerGenerated]
		private readonly string m_TokenTest;

		[CompilerGenerated]
		private bool _DispatcherTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ValErrorFilter(object asset, object result, string serv, Exception v2)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_ProccesorTest = asset;
			adapterTest = result;
			containerTest = v2;
			m_TokenTest = serv;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _BaseTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0001(bool containssetup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_BaseTest = containssetup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Exception _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return containerTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DispatcherTest;
		}
	}
}
