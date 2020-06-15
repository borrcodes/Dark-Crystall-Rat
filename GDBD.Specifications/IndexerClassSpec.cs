using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Specifications
{
	internal sealed class IndexerClassSpec
	{
		public readonly Size listenerEvent;

		public readonly int m_TagEvent;

		public readonly int _SpecificationEvent;

		public readonly int writerEvent;

		[Obsolete("No longer supported. Use AverageFrameRate instead.")]
		public int RunInstance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return m_TagEvent;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IndexerClassSpec()
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
		internal static IndexerClassSpec[] OrderInstance(RefEvent value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (value == null)
			{
				throw new ArgumentNullException("videoStreamConfig");
			}
			int def;
			int token;
			int num = value._0001(out def, out token);
			if (num != 0)
			{
				Marshal.ThrowExceptionForHR(num);
			}
			if (def <= 0)
			{
				throw new NotSupportedException("This video device does not report capabilities.");
			}
			if (token > Marshal.SizeOf(typeof(TokenizerIteratorMapping)))
			{
				throw new NotSupportedException("Unable to retrieve video device capabilities. This video device requires a larger VideoStreamConfigCaps structure.");
			}
			Dictionary<uint, IndexerClassSpec> dictionary = new Dictionary<uint, IndexerClassSpec>();
			for (int i = 0; i < def; i++)
			{
				try
				{
					IndexerClassSpec indexerClassSpec = new IndexerClassSpec(value, i);
					uint key = (uint)(indexerClassSpec.listenerEvent.Height | (indexerClassSpec.listenerEvent.Width << 16));
					if (!dictionary.ContainsKey(key))
					{
						dictionary.Add(key, indexerClassSpec);
					}
					else if (indexerClassSpec.writerEvent > dictionary[key].writerEvent)
					{
						dictionary[key] = indexerClassSpec;
					}
				}
				catch
				{
				}
			}
			IndexerClassSpec[] array = new IndexerClassSpec[dictionary.Count];
			dictionary.Values.CopyTo(array, 0);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IndexerClassSpec(RefEvent setup, int num_reg)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			PrototypeDicCandidate result = null;
			TokenizerIteratorMapping tokenizerIteratorMapping = new TokenizerIteratorMapping();
			try
			{
				int num = setup._0001(num_reg, out result, tokenizerIteratorMapping);
				if (num != 0)
				{
					Marshal.ThrowExceptionForHR(num);
				}
				if (result.m_DicFilter == FactoryFilter.serializerFilter)
				{
					ObserverListAnnotation observerListAnnotation = (ObserverListAnnotation)Marshal.PtrToStructure(result.propertyFilter, typeof(ObserverListAnnotation));
					listenerEvent = new Size(observerListAnnotation.predicateFilter._DescriptorFilter, observerListAnnotation.predicateFilter.m_ProducerFilter);
					writerEvent = observerListAnnotation.predicateFilter._StubFilter;
					m_TagEvent = (int)(10000000 / observerListAnnotation.mapperFilter);
					_SpecificationEvent = (int)(10000000 / tokenizerIteratorMapping._ParameterFilter);
				}
				else
				{
					if (!(result.m_DicFilter == FactoryFilter.m_CallbackFilter))
					{
						throw new ApplicationException("Unsupported format found.");
					}
					WorkerRequestStrategy workerRequestStrategy = (WorkerRequestStrategy)Marshal.PtrToStructure(result.propertyFilter, typeof(WorkerRequestStrategy));
					listenerEvent = new Size(workerRequestStrategy._MockFilter._DescriptorFilter, workerRequestStrategy._MockFilter.m_ProducerFilter);
					writerEvent = workerRequestStrategy._MockFilter._StubFilter;
					m_TagEvent = (int)(10000000 / workerRequestStrategy.registryFilter);
					_SpecificationEvent = (int)(10000000 / tokenizerIteratorMapping._ParameterFilter);
				}
				if (writerEvent <= 12)
				{
					throw new ApplicationException("Unsupported format found.");
				}
			}
			finally
			{
				result?._0002();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(object item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ResolveInstance(item as IndexerClassSpec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ResolveInstance(IndexerClassSpec var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (var1 == null)
			{
				return false;
			}
			return listenerEvent == var1.listenerEvent && writerEvent == var1.writerEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Size size = listenerEvent;
			return size.GetHashCode() ^ writerEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _0001(IndexerClassSpec init, IndexerClassSpec token)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == token)
			{
				return true;
			}
			if (init == null || token == null)
			{
				return false;
			}
			return init.ResolveInstance(token);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool _0002(IndexerClassSpec spec, IndexerClassSpec cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return !_0001(spec, cust);
		}
	}
}
