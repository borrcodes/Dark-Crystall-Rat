using _0008;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Resolver;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Annotations
{
	internal sealed class CollectionProperty : InitializerTest
	{
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private GDBD.Specifications.AdapterClassSpec<object> _RepositoryProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new GDBD.Specifications.AdapterClassSpec<object> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RepositoryProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(GDBD.Specifications.AdapterClassSpec<object> ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RepositoryProperty = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CollectionProperty(Type instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(instance);
			_ErrorProperty = (ParameterFilterResolver)7;
		}
	}
}
