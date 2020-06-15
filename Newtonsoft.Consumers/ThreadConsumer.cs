using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Consumers
{
	[ComVisible(false)]
	internal static class ThreadConsumer
	{
		public static readonly Guid _MerchantFilter;

		public static readonly Guid listenerFilter;

		public static readonly Guid m_TagFilter;

		public static readonly Guid _SpecificationFilter;

		public static readonly Guid m_WriterFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ThreadConsumer()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_MerchantFilter = new Guid(1935960438, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			listenerFilter = new Guid(1937138025, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			m_TagFilter = new Guid(1935963489, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			_SpecificationFilter = new Guid(1937012852, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			m_WriterFilter = new Guid(3828804483u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
		}
	}
}
