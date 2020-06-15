using System.Runtime.InteropServices;

namespace Newtonsoft.Expressions
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	[ComVisible(false)]
	internal struct SingletonInstanceExpression
	{
		public int _ObserverFilter;

		public int _DescriptorFilter;

		public int m_ProducerFilter;

		public short m_StructFilter;

		public short _StubFilter;

		public int m_CodeFilter;

		public int taskFilter;

		public int customerFilter;

		public int interpreterFilter;

		public int _WatcherFilter;

		public int _CollectionFilter;
	}
}
