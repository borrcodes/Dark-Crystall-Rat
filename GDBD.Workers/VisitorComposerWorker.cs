using GDBD.Filter;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Resolver;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GDBD.Workers
{
	internal sealed class VisitorComposerWorker : UtilsFilterResolver
	{
		public sealed class StrategyInstance
		{
			[CompilerGenerated]
			private bool _InfoInstance;

			[CompilerGenerated]
			private bool _ValueInstance;

			[CompilerGenerated]
			private bool _ParameterInstance;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StrategyInstance()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				_0001(containsvar1: true);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public bool _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _InfoInstance;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public bool _0002()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _ValueInstance;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public bool _0003()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _ParameterInstance;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			public void _0001(bool containsvar1)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_ParameterInstance = containsvar1;
			}
		}

		private RefList _SystemInstance;

		private long identifierInstance;

		private StrategyInstance _GetterInstance;

		private readonly string _SetterInstance;

		private SystemDic workerInstance;

		private long advisorInstance;

		private byte[] _RulesInstance;

		private int _ContextInstance;

		private int _ParamInstance;

		private long m_PublisherInstance;

		[CompilerGenerated]
		private EventHandler m_UtilsInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected VisitorComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_PublisherInstance = -1L;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VisitorComposerWorker(string v)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(v, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VisitorComposerWorker(string ident, StrategyInstance connection)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_PublisherInstance = -1L;
			base._002Ector();
			_SetterInstance = ident;
			SortDic(connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SortDic(StrategyInstance setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ResolverDic.AddError();
			_GetterInstance = (setup ?? new StrategyInstance());
			SystemDic systemDic = _0001(_GetterInstance);
			_SystemInstance = CallDic(systemDic);
			systemDic._0001(-3, readivk: true);
			identifierInstance = WriteDic(systemDic);
			if (_GetterInstance._0002())
			{
				workerInstance = systemDic;
			}
			else
			{
				Marshal.ReleaseComObject(systemDic);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private RefList CallDic(SystemDic item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			item._0001(-3, out PredicateIssuerMock reg);
			BaseClassSpec baseClassSpec = new BaseClassSpec(reg);
			baseClassSpec._0002();
			Guid guid = baseClassSpec._0001();
			int num = baseClassSpec._0002();
			int attr_end = baseClassSpec._0003();
			int num2 = baseClassSpec._0001();
			if (guid == IndexerInstance._TokenInstance)
			{
				return new RefList(num2, attr_end, num);
			}
			if (guid == IndexerInstance.baseInstance)
			{
				return RefList.ListDic(num2, num);
			}
			string arg = BridgeInstance.ResolveError(typeof(IndexerInstance), guid);
			throw new InvalidDataException($"Unsupported audio sub Type {arg}");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BaseClassSpec PublishDic(SystemDic first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			first._0001(-3, out PredicateIssuerMock reg);
			return new BaseClassSpec(reg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual SystemDic _0001(StrategyInstance setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ValDic.FlushError(_SetterInstance, null, out SystemDic rule);
			rule._0001(-2, readivk: false);
			rule._0001(-3, readivk: true);
			BaseClassSpec baseClassSpec = new BaseClassSpec();
			baseClassSpec._0002(TemplateInstance.m_ConfigInstance);
			baseClassSpec._0001(setup._0001() ? IndexerInstance.baseInstance : IndexerInstance._TokenInstance);
			BaseClassSpec baseClassSpec2 = PublishDic(rule);
			baseClassSpec._0002(baseClassSpec2._0002());
			baseClassSpec._0001(baseClassSpec2._0001());
			try
			{
				rule._0001(-3, IntPtr.Zero, baseClassSpec._0001());
			}
			catch (COMException item) when (item.CompareError() == -1072875852)
			{
				if (!(baseClassSpec2._0001() == IndexerInstance._DecoratorInstance) || baseClassSpec2._0002() != 1)
				{
					throw;
				}
				int reference_low;
				baseClassSpec2._0001(reference_low = baseClassSpec2._0001() * 2);
				baseClassSpec._0001(reference_low);
				baseClassSpec2._0002(reference_low = baseClassSpec2._0002() * 2);
				baseClassSpec._0002(reference_low);
				rule._0001(-3, IntPtr.Zero, baseClassSpec._0001());
			}
			Marshal.ReleaseComObject(baseClassSpec2._0001());
			return rule;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private long WriteDic(SystemDic setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IntPtr intPtr = Marshal.AllocHGlobal(MockIteratorMapping.FillError<ImporterReaderMapper>());
			try
			{
				int num = setup._0001(-1, ComparatorConsumer.serviceDic, intPtr);
				switch (num)
				{
				case -1072875802:
					return 0L;
				default:
					Marshal.ThrowExceptionForHR(num);
					break;
				case 0:
					break;
				}
				return (long)MockIteratorMapping.RunError<ImporterReaderMapper>(intPtr)._0001() * _SystemInstance._0004() / 10000000;
			}
			finally
			{
				ImporterReaderMapper.ViewError(intPtr);
				Marshal.FreeHGlobal(intPtr);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RevertDic(int num_spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_RulesInstance == null || _RulesInstance.Length < num_spec)
			{
				_RulesInstance = new byte[num_spec];
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Read(byte[] reference, int indexOf_second, int sum_util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (workerInstance == null)
			{
				workerInstance = _0001(_GetterInstance);
			}
			if (m_PublisherInstance != -1)
			{
				CheckError(m_PublisherInstance);
			}
			int num = 0;
			if (_ParamInstance > 0)
			{
				num += LoginError(reference, indexOf_second, sum_util - num);
			}
			while (num < sum_util)
			{
				workerInstance._0001(-3, 0, out int _, out CrashDumpGrbit connection, out ulong _, out DefinitionDic pol);
				if ((connection & (CrashDumpGrbit)2) != 0)
				{
					break;
				}
				if ((connection & (CrashDumpGrbit)32) != 0)
				{
					_SystemInstance = CallDic(workerInstance);
					DisableError();
				}
				else if (connection != 0)
				{
					throw new InvalidOperationException($"MediaFoundationReadError {connection}");
				}
				pol._0001(out InvocationDic info);
				info._0001(out IntPtr v, out int _, out int dir);
				RevertDic(dir);
				Marshal.Copy(v, _RulesInstance, 0, dir);
				_ContextInstance = 0;
				_ParamInstance = dir;
				num += LoginError(reference, indexOf_second + num, sum_util - num);
				info._0001();
				Marshal.ReleaseComObject(info);
				Marshal.ReleaseComObject(pol);
			}
			advisorInstance += num;
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int LoginError(byte[] setup, int idx_second, int no_template)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = Math.Min(no_template, _ParamInstance);
			Array.Copy(_RulesInstance, _ContextInstance, setup, idx_second, num);
			_ContextInstance += num;
			_ParamInstance -= num;
			if (_ParamInstance == 0)
			{
				_ContextInstance = 0;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override RefList _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _SystemInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return identifierInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return advisorInstance;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long reference_Z)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference_Z < 0)
			{
				throw new ArgumentOutOfRangeException("value", "Position cannot be less than 0");
			}
			if (_GetterInstance._0003())
			{
				m_PublisherInstance = reference_Z;
				advisorInstance = reference_Z;
			}
			else
			{
				CheckError(reference_Z);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckError(long size_def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ImporterReaderMapper importerReaderMapper = ImporterReaderMapper.LogoutError(10000000 * m_PublisherInstance / _SystemInstance._0004());
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf((object)importerReaderMapper));
			Marshal.StructureToPtr((object)importerReaderMapper, intPtr, fDeleteOld: false);
			workerInstance._0001(Guid.Empty, intPtr);
			Marshal.FreeHGlobal(intPtr);
			_ParamInstance = 0;
			_ContextInstance = 0;
			advisorInstance = size_def;
			m_PublisherInstance = -1L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(bool acceptreference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (workerInstance != null)
			{
				Marshal.ReleaseComObject(workerInstance);
				workerInstance = null;
			}
			base.Dispose(acceptreference);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisableError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_UtilsInstance?.Invoke(this, EventArgs.Empty);
		}
	}
}
