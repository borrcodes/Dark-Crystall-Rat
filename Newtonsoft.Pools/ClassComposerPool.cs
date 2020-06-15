using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Pools
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	internal sealed class ClassComposerPool : RefDic
	{
		private ServerComposer _MapperError;

		internal InternalArrayTypeE? predicateError;

		internal SpecificationTestItem? m_PolicyError;

		internal ApplicationState? serviceError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new ServerComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _MapperError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassComposerPool()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
