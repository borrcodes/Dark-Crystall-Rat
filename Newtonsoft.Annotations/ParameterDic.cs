using GDBD.Workers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Newtonsoft.Annotations
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class ParameterDic
	{
		public int _PrototypeDic;

		public long parserDic;

		public long statusDic;

		public long _PageDic;

		public long m_HelperDic;

		public long m_ExceptionDic;

		public long m_AttributeDic;

		public long databaseDic;

		public long _FactoryDic;

		public long m_SerializerDic;

		public int callbackDic;

		public long _MerchantDic;

		public int listenerDic;

		public int m_TagDic;

		public int specificationDic;

		public int _WriterDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ParameterDic()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
