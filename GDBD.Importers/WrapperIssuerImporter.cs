using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Importers
{
	[ComVisible(false)]
	internal static class WrapperIssuerImporter
	{
		public static readonly Guid m_FactoryEvent;

		public static readonly Guid serializerEvent;

		public static readonly Guid m_CallbackEvent;

		public static readonly Guid m_MerchantEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WrapperIssuerImporter()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_FactoryEvent = new Guid(869902178u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
			serializerEvent = new Guid(2248913680u, 23809, 4560, 189, 59, 0, 160, 201, 17, 206, 134);
			m_CallbackEvent = new Guid(869902176u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
			m_MerchantEvent = new Guid(869902177u, 37064, 4560, 189, 67, 0, 160, 201, 17, 206, 134);
		}
	}
}
