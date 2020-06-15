using _0008;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	[_0008._0012(0)]
	internal class ProccesorClassSpec : ProcTest
	{
		[CompilerGenerated]
		private SettingsSerializeAs advisorProperty;

		private static readonly Dictionary<Type, Docking> m_RulesProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal new SettingsSerializeAs _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return advisorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0001(SettingsSerializeAs def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			advisorProperty = def;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProccesorClassSpec(Type config)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(config);
			_ErrorProperty = (ParameterFilterResolver)3;
			_0001(HelperDicCandidate.PatchProperty(config));
			composerProperty = true;
			if (m_RulesProperty.TryGetValue(_InstanceProperty, out Docking value))
			{
				dicProperty = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProccesorClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_RulesProperty = new Dictionary<Type, Docking>
			{
				[typeof(byte[])] = (Docking)3,
				[typeof(byte)] = (Docking)1,
				[typeof(short)] = (Docking)1,
				[typeof(int)] = (Docking)1,
				[typeof(decimal)] = (Docking)5,
				[typeof(bool)] = (Docking)9,
				[typeof(string)] = (Docking)4,
				[typeof(DateTime)] = (Docking)6,
				[typeof(DateTimeOffset)] = (Docking)7,
				[typeof(float)] = (Docking)8,
				[typeof(double)] = (Docking)8,
				[typeof(long)] = (Docking)2
			};
		}
	}
}
