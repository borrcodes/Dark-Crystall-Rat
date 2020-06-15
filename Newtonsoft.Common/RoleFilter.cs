using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Common
{
	[ComVisible(false)]
	internal static class RoleFilter
	{
		public static readonly Guid _CreatorFilter;

		public static readonly Guid ruleFilter;

		public static readonly Guid _BridgeFilter;

		public static readonly Guid _ImporterFilter;

		public static readonly Guid _ReponseFilter;

		public static readonly Guid indexerFilter;

		public static readonly Guid _DecoratorFilter;

		public static readonly Guid m_FieldFilter;

		public static readonly Guid _ItemFilter;

		public static readonly Guid m_RegFilter;

		public static readonly Guid m_ProcessFilter;

		public static readonly Guid m_BaseFilter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RoleFilter()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_CreatorFilter = new Guid(1448695129, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			ruleFilter = new Guid(1448433993, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			_BridgeFilter = new Guid(1146312260, 0, 16, 128, 0, 0, 170, 0, 56, 155, 113);
			_ImporterFilter = new Guid(3828804472u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			_ReponseFilter = new Guid(3828804473u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			indexerFilter = new Guid(3828804474u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			_DecoratorFilter = new Guid(3828804475u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			m_FieldFilter = new Guid(3828804476u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			_ItemFilter = new Guid(3828804477u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			m_RegFilter = new Guid(3828804478u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			m_ProcessFilter = new Guid(3828804488u, 21071, 4558, 159, 83, 0, 32, 175, 11, 167, 112);
			m_BaseFilter = new Guid(1035472784u, 37906, 4561, 173, 237, 0, 0, 248, 117, 75, 153);
		}
	}
}
