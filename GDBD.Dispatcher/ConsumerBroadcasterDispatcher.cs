using GDBD.Workers;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Dispatcher
{
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class ConsumerBroadcasterDispatcher : Attribute
	{
		[CompilerGenerated]
		private readonly bool _VisitorDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConsumerBroadcasterDispatcher(bool hasreference)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_VisitorDic = hasreference;
		}
	}
}
