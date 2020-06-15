using _0008;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Consumers;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Common
{
	[_0008._0012(0)]
	internal class InitializerTest : ProcTest
	{
		private ProcTest _ObjectTest;

		private ProcTest schemaTest;

		[CompilerGenerated]
		private BroadcasterError refTest;

		[CompilerGenerated]
		private bool? _ThreadTest;

		[CompilerGenerated]
		private FacadeComposer? consumerTest;

		[CompilerGenerated]
		private SparklineAxisMinMaxValues? m_ComparatorTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new ProcTest _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ObjectTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _0001(ProcTest item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ObjectTest = item;
			if (_ObjectTest != null)
			{
				schemaTest = (_ObjectTest._0002().DisableClient() ? _ObjectTest : null);
			}
			else
			{
				schemaTest = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal new ProcTest _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return schemaTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new BroadcasterError _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return refTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(BroadcasterError reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			refTest = reference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new bool? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ThreadTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool? task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ThreadTest = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new FacadeComposer? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return consumerTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(FacadeComposer? first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			consumerTest = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new SparklineAxisMinMaxValues? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ComparatorTest;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(SparklineAxisMinMaxValues? setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ComparatorTest = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal InitializerTest(Type value)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(value);
			RefDic refDic = ConfigProperty.CreateClass<RefDic>(value);
			if (refDic != null)
			{
				if (refDic._0001() != null)
				{
					_0001(ConfigProperty.ConnectClass(refDic._0001(), refDic._0001()));
				}
				_0001(refDic.recordError);
				_0001(refDic.m_EventError);
				_0001(refDic.filterError);
			}
		}
	}
}
