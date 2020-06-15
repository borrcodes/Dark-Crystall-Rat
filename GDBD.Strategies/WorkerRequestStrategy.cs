using Newtonsoft.Expressions;
using Newtonsoft.Pools;
using System.Runtime.InteropServices;

namespace GDBD.Strategies
{
	[ComVisible(false)]
	internal struct WorkerRequestStrategy
	{
		public IssuerComposerPool _PolicyFilter;

		public IssuerComposerPool serviceFilter;

		public int queueFilter;

		public int _ProxyFilter;

		public long registryFilter;

		public int m_AttrFilter;

		public int _ConfigurationFilter;

		public int m_CandidateFilter;

		public int tokenizerFilter;

		public int m_PrinterFilter;

		public int mappingFilter;

		public SingletonInstanceExpression _MockFilter;
	}
}
