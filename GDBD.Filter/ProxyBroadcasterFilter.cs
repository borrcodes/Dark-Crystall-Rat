using _0008;
using GDBD.Importers;
using GDBD.Maps;
using GDBD.Workers;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace GDBD.Filter
{
	[_0008._0012(0)]
	internal sealed class ProxyBroadcasterFilter : GetMemberBinder
	{
		private readonly GetMemberBinder _ConnectionComposer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProxyBroadcasterFilter(GetMemberBinder task)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(task.Name, task.IgnoreCase);
			_ConnectionComposer = task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DynamicMetaObject _0001(DynamicMetaObject res, DynamicMetaObject col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DynamicMetaObject dynamicMetaObject = _ConnectionComposer.Bind(res, ObserverIteratorMapping.CheckProperty<DynamicMetaObject>());
			return new DynamicMetaObject(new SchemaComposer().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
		}
	}
}
