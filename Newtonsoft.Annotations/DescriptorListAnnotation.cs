using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Database;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	internal sealed class DescriptorListAnnotation : AccountFilter
	{
		private readonly byte[] _IteratorList;

		private readonly byte[] m_TestsList;

		private readonly MapperList methodList;

		private readonly int authenticationList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DescriptorListAnnotation(MapperList ident, int remove_CALLERAt, byte[] third, byte[] ident2)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			methodList = ident;
			m_TestsList = third;
			authenticationList = remove_CALLERAt;
			_IteratorList = ident2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual MapperList _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return methodList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return authenticationList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IteratorList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual byte[] _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_TestsList;
		}
	}
}
