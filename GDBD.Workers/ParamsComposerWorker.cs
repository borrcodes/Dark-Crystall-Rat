using _0008;
using Newtonsoft.Rules;
using System.Runtime.CompilerServices;

namespace GDBD.Workers
{
	[_0008._0012(0)]
	internal sealed class ParamsComposerWorker
	{
		private readonly object errorTest;

		[_0008._0012(new byte[]
		{
			1,
			2,
			1
		})]
		private readonly Newtonsoft.Rules.ClientInstanceRule<object, object> _ComposerTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParamsComposerWorker(object key, Newtonsoft.Rules.ClientInstanceRule<object, object> col)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			errorTest = key;
			_ComposerTest = col;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ConnectIssuer(object[] task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ComposerTest(errorTest, task);
		}
	}
}
