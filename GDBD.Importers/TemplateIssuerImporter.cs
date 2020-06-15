using Newtonsoft.Database;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	internal sealed class TemplateIssuerImporter : AccountFilter
	{
		private readonly AccountFilter m_PolicyList;

		private readonly byte[] m_ServiceList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] EnableDic()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (byte[])m_ServiceList.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AccountFilter _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PolicyList;
		}
	}
}
