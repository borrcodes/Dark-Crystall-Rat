using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	internal struct ContextFilterResolver
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private long error;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private long composer;

		public long Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
			[MethodImpl(MethodImplOptions.NoInlining)]
			set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public long OrderRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return error;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void ResolveRecord(long instance_Ptr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			error = instance_Ptr;
		}
	}
}
