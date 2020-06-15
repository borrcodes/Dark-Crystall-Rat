using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Filters;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	internal sealed class FilterReader : ValueRequestStrategy
	{
		[CompilerGenerated]
		private FileFormatVersions m_InstanceReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new FileFormatVersions _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InstanceReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(FileFormatVersions config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_InstanceReader = config;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilterReader(byte[] def, FileFormatVersions result)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(def, (ChildRunStatus)5);
			_0001(result);
		}
	}
}
