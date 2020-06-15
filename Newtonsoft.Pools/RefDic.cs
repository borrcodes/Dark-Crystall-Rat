using _0008;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Filters;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	[_0008._0012(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
	internal abstract class RefDic : Attribute
	{
		[CompilerGenerated]
		private Type threadDic;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private object[] m_ConsumerDic;

		[CompilerGenerated]
		private ProducerIteratorMapping _ComparatorDic;

		internal bool? procDic;

		internal bool? recordError;

		internal FacadeComposer? m_EventError;

		internal SparklineAxisMinMaxValues? filterError;

		private Type listError;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private object[] _InstanceError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return threadDic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public object[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_ConsumerDic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Type _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return listError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object[] _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InstanceError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal ProducerIteratorMapping _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ComparatorDic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		internal void _0001(ProducerIteratorMapping ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_ComparatorDic = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected RefDic()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
