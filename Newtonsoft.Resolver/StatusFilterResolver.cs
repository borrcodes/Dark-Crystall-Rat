using _0008;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Pools;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal sealed class StatusFilterResolver : FieldIssuer, CreatorIssuer, IndexerIssuer
	{
		private readonly XDocumentType m_RegIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StatusFilterResolver(XDocumentType def)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(def);
			m_RegIssuer = def;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RegIssuer.Name;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RegIssuer.SystemId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0006()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RegIssuer.PublicId;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RegIssuer.InternalSubset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return "DOCTYPE";
		}
	}
}
