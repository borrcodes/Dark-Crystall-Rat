using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	[AttributeUsage(AttributeTargets.Field)]
	internal sealed class FieldClassSpec : Attribute
	{
		[CompilerGenerated]
		private readonly string _RuleInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RuleInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FieldClassSpec(string spec)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_RuleInstance = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _0001();
		}
	}
}
