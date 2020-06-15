using GDBD.Importers;
using GDBD.Workers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	internal sealed class StubErrorFilter
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int tests;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private VisitorIssuerImporter[] _Method;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private object[] _Authentication;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int m_Mapper;

		public VisitorIssuerImporter[] logins
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
			[MethodImpl(MethodImplOptions.NoInlining)]
			set;
		}

		public int version
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
			[MethodImpl(MethodImplOptions.NoInlining)]
			set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int InterruptRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return tests;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void CalcRecord(int next_ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tests = next_ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public object[] RegisterRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _Authentication;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void RestartRecord(object[] param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_Authentication = param;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StubErrorFilter()
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
}
