using _0008;
using GDBD.Bridges;
using GDBD.Filter;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Common;
using Newtonsoft.Database;
using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Resolver
{
	[_0008._0012(0)]
	internal sealed class ProducerProperty : InitializerTest
	{
		[CompilerGenerated]
		private readonly CreatorTestItem _StructProperty;

		[CompilerGenerated]
		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private Func<string, string> stubProperty;

		private readonly Newtonsoft.Database.DispatcherEventEntry<string, CallSite<Func<CallSite, object, object>>> _CodeProperty;

		[_0008._0012(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})]
		private readonly Newtonsoft.Database.DispatcherEventEntry<string, CallSite<Func<CallSite, object, object, object>>> m_TaskProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new CreatorTestItem _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _StructProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public new Func<string, string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return stubProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(Func<string, string> first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			stubProperty = first;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static CallSite<Func<CallSite, object, object>> CustomizeClient(string ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CallSite<Func<CallSite, object, object>>.Create(new ProxyBroadcasterFilter((GetMemberBinder)TokenEventEntry.GlobalComposer.AddIssuer(ident, typeof(TokenEventEntry))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static CallSite<Func<CallSite, object, object, object>> QueryClient(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CallSite<Func<CallSite, object, object, object>>.Create(new InitializerComposer((SetMemberBinder)TokenEventEntry.GlobalComposer.EnableIssuer(spec, typeof(TokenEventEntry))));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProducerProperty(Type instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_CodeProperty = new Newtonsoft.Database.DispatcherEventEntry<string, CallSite<Func<CallSite, object, object>>>(CustomizeClient);
			m_TaskProperty = new Newtonsoft.Database.DispatcherEventEntry<string, CallSite<Func<CallSite, object, object, object>>>(QueryClient);
			base._002Ector(instance);
			_ErrorProperty = (ParameterFilterResolver)6;
			_StructProperty = new CreatorTestItem(base._0002());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool CancelClient(IDynamicMetaObjectProvider first, string vis, [_0008._0012(2)] out object _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(first, "dynamicProvider");
			CallSite<Func<CallSite, object, object>> callSite = _CodeProperty.InitReader(vis);
			object obj = callSite.Target(callSite, first);
			if (obj != SchemaComposer.refComposer)
			{
				_0004 = obj;
				return true;
			}
			_0004 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool ExcludeClient(IDynamicMetaObjectProvider value, string second, object consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(value, "dynamicProvider");
			CallSite<Func<CallSite, object, object, object>> callSite = m_TaskProperty.InitReader(second);
			return callSite.Target(callSite, value, consumer) != SchemaComposer.refComposer;
		}
	}
}
