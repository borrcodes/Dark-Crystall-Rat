using _0008;
using GDBD.Workers;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	[_0008._0012(0)]
	internal struct InvocationTest
	{
		private readonly char[] definitionTest;

		private readonly int _SystemTest;

		private readonly int _IdentifierTest;

		public char this[int flags_def]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return definitionTest[flags_def];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public char[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return definitionTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SystemTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IdentifierTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InvocationTest(char[] spec, int maphigh, int next_tag)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			definitionTest = spec;
			_SystemTest = maphigh;
			_IdentifierTest = next_tag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new string(definitionTest, _SystemTest, _IdentifierTest);
		}
	}
}
