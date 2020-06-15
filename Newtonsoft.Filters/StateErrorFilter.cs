using _0008;
using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Filters
{
	[_0008._0012(0)]
	internal sealed class StateErrorFilter
	{
		[CompilerGenerated]
		private readonly Type m_ContextComposer;

		[CompilerGenerated]
		private readonly SettingsSerializeAs _ParamComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ContextComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public SettingsSerializeAs _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ParamComposer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StateErrorFilter(Type item, SettingsSerializeAs map)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_ContextComposer = item;
			_ParamComposer = map;
		}
	}
}
