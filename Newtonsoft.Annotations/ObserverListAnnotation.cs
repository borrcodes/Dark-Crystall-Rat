using Newtonsoft.Expressions;
using Newtonsoft.Pools;
using System.Runtime.InteropServices;

namespace Newtonsoft.Annotations
{
	[ComVisible(false)]
	internal struct ObserverListAnnotation
	{
		public IssuerComposerPool iteratorFilter;

		public IssuerComposerPool _TestsFilter;

		public int _MethodFilter;

		public int m_AuthenticationFilter;

		public long mapperFilter;

		public SingletonInstanceExpression predicateFilter;
	}
}
