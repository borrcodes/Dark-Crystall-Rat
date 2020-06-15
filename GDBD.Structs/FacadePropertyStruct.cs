using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Structs
{
	internal sealed class FacadePropertyStruct : Exception
	{
		private MathOperator m_WatcherList;

		private string collectionList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FacadePropertyStruct(MathOperator ident, string ord)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(LogoutDic(ident, ord));
			m_WatcherList = ident;
			collectionList = ord;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string LogoutDic(MathOperator reference, string cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return $"{reference} calling {cust}";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VisitDic(MathOperator key, string cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (key != 0)
			{
				throw new FacadePropertyStruct(key, cfg);
			}
		}
	}
}
