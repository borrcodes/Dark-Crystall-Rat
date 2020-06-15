using _0008;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Filters;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	[_0008._0012(0)]
	internal sealed class TokenizerError : Attribute
	{
		internal ApplicationState? printerError;

		internal ConnectActionCursor? _MappingError;

		internal FacadeComposer? mockError;

		internal PageDicCandidate? observerError;

		internal SparklineAxisMinMaxValues? _DescriptorError;

		internal bool? m_ProducerError;

		internal int? m_StructError;

		internal SpecificationTestItem? m_StubError;

		internal bool? m_CodeError;

		internal FacadeComposer? _TaskError;

		internal SparklineAxisMinMaxValues? customerError;

		[CompilerGenerated]
		private Type _InterpreterError;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		private object[] _WatcherError;

		[CompilerGenerated]
		private Type m_CollectionError;

		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private object[] repositoryError;

		[CompilerGenerated]
		private string serverError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InterpreterError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public object[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _WatcherError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public Type _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_CollectionError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public object[] _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return repositoryError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return serverError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TokenizerError()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
