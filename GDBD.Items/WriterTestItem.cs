using _0008;
using GDBD.Mocks;
using GDBD.Workers;
using Newtonsoft.Database;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	internal static class WriterTestItem<T> where T : Attribute
	{
		[_0008._0012(new byte[]
		{
			1,
			1,
			2
		})]
		private static readonly Newtonsoft.Database.DispatcherEventEntry<object, T> m_PublisherTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CompareClient(object last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_PublisherTest.InitReader(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WriterTestItem()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_PublisherTest = new Newtonsoft.Database.DispatcherEventEntry<object, T>(ConfigProperty.ReadClass<T>);
		}
	}
}
