using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Maps
{
	[StructLayout(LayoutKind.Sequential)]
	[ComVisible(false)]
	internal sealed class TokenizerIteratorMapping
	{
		public Guid valFilter;

		public ChecksumType invocationFilter;

		public Size definitionFilter;

		public Size m_SystemFilter;

		public Size _IdentifierFilter;

		public int getterFilter;

		public int setterFilter;

		public int workerFilter;

		public int advisorFilter;

		public Size _RulesFilter;

		public Size _ContextFilter;

		public int paramFilter;

		public int publisherFilter;

		public int utilsFilter;

		public int m_StrategyFilter;

		public int _InfoFilter;

		public int _ValueFilter;

		public long _ParameterFilter;

		public long m_PrototypeFilter;

		public int m_ParserFilter;

		public int _StatusFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenizerIteratorMapping()
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
