using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Workers
{
	[ComVisible(false)]
	internal static class AlgoComposerWorker
	{
		public static readonly Guid pageFilter;

		public static readonly Guid m_HelperFilter;

		public static readonly Guid m_ExceptionFilter;

		public static readonly Guid m_AttributeFilter;

		public static readonly Guid m_DatabaseFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AlgoComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			pageFilter = new Guid(1656642832, 24811, 4560, 189, 59, 0, 160, 201, 17, 206, 134);
			m_HelperFilter = new Guid(3828804531u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			m_ExceptionFilter = new Guid(3253993632u, 16136, 4563, 159, 11, 0, 96, 8, 3, 158, 55);
			m_AttributeFilter = new Guid(3213342433u, 35879, 4560, 179, 240, 0, 170, 0, 55, 97, 197);
			m_DatabaseFilter = new Guid(3828804533u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
		}
	}
}
