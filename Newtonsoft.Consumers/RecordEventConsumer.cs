using _0008;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = false)]
	[_0008._0012(0)]
	internal sealed class RecordEventConsumer : Attribute
	{
		private readonly Type m_ClassError;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private readonly object[] _RequestError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ClassError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public object[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RequestError;
		}
	}
}
