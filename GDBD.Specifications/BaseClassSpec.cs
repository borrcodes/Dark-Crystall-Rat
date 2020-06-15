using GDBD.Mocks;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Consumers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Specifications
{
	internal sealed class BaseClassSpec
	{
		private readonly PredicateIssuerMock m_RuleDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseClassSpec(PredicateIssuerMock res)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_RuleDic = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BaseClassSpec()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			m_RuleDic = ResolverDic.EnableError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CreateError(Guid def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0002(def, out int attr);
			return attr;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Guid StopError(Guid key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0001(key, out Guid visitor);
			return visitor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CreateError(ComparatorConsumer._StubDic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(int reference_low)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0001(ComparatorConsumer._StubDic, reference_low);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CreateError(ComparatorConsumer.structDic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(int info_count)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0001(ComparatorConsumer.structDic, info_count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CreateError(ComparatorConsumer.m_CodeDic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Guid _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return StopError(ComparatorConsumer._ObserverDic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(Guid value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0001(ComparatorConsumer._ObserverDic, value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Guid _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return StopError(ComparatorConsumer.mockDic);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002(Guid first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_RuleDic._0001(ComparatorConsumer.mockDic, first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PredicateIssuerMock _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_RuleDic;
		}
	}
}
