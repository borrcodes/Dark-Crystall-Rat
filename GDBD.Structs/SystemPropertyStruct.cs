using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	internal abstract class SystemPropertyStruct
	{
		[CompilerGenerated]
		private SystemPropertyStruct wrapperIssuer;

		[CompilerGenerated]
		private int paramsIssuer;

		public abstract ChildRunStatus _0001();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public SystemPropertyStruct _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return wrapperIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(SystemPropertyStruct v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			wrapperIssuer = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return paramsIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(int spec_Low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			paramsIssuer = spec_Low;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SystemPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
