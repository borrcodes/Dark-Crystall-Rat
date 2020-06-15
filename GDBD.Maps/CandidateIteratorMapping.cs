using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace GDBD.Maps
{
	internal sealed class CandidateIteratorMapping
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public string _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
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
				if (@event._0001() == (SourceMode)1)
				{
					CheckRecord();
				}
				try
				{
					VisitorComposerWorker visitorComposerWorker = new VisitorComposerWorker(this._0001);
					using (ExporterComposerWorker exporterComposerWorker = new ExporterComposerWorker())
					{
						@event = exporterComposerWorker;
						m_Filter = visitorComposerWorker;
						exporterComposerWorker._0001(visitorComposerWorker);
						exporterComposerWorker._0001();
						while (exporterComposerWorker._0001() == (SourceMode)1)
						{
							Thread.Sleep(2000);
						}
						GC.Collect();
					}
				}
				catch
				{
				}
			}
		}

		private static ExporterComposerWorker @event;

		private static VisitorComposerWorker m_Filter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoginRecord(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			new Thread((ThreadStart)delegate
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (@event._0001() == (SourceMode)1)
				{
					CheckRecord();
				}
				try
				{
					VisitorComposerWorker visitorComposerWorker = new VisitorComposerWorker(var1);
					using (ExporterComposerWorker exporterComposerWorker = new ExporterComposerWorker())
					{
						@event = exporterComposerWorker;
						m_Filter = visitorComposerWorker;
						exporterComposerWorker._0001(visitorComposerWorker);
						exporterComposerWorker._0001();
						while (exporterComposerWorker._0001() == (SourceMode)1)
						{
							Thread.Sleep(2000);
						}
						GC.Collect();
					}
				}
				catch
				{
				}
			}).Start();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CheckRecord()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			@event._0002();
			@event._0006();
			m_Filter.Dispose();
			@event = new ExporterComposerWorker();
			m_Filter = null;
			GC.Collect();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CandidateIteratorMapping()
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
		static CandidateIteratorMapping()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			@event = new ExporterComposerWorker();
			m_Filter = null;
		}
	}
}
