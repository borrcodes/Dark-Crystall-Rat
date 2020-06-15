using GDBD.Filter;
using GDBD.Workers;
using Newtonsoft.Pools;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace GDBD.Structs
{
	internal sealed class ManagerPropertyStruct : IDisposable
	{
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		internal sealed class AdapterEventEntry
		{
			public int testsInstance;

			[MarshalAs(UnmanagedType.U4)]
			public NotifyFilters methodInstance;

			public uint authenticationInstance;

			public int _MapperInstance;

			public IntPtr predicateInstance;

			public Guid m_PolicyInstance;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public AdapterEventEntry()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		internal sealed class ServiceInstance
		{
			public int m_QueueInstance;

			public int m_ProxyInstance;

			public int m_RegistryInstance;

			public int m_AttrInstance;

			public int m_ConfigurationInstance;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ServiceInstance()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		internal enum ProducerListAnnotation : uint
		{

		}

		[Flags]
		internal enum MergeTextBufferType : uint
		{

		}

		internal enum AnnotationComposerWorker : uint
		{

		}

		[Flags]
		internal enum DiskStatementType : uint
		{

		}

		[Flags]
		internal enum NotifyFilters : uint
		{

		}

		internal struct CandidateInstance
		{
			public uint _TokenizerInstance;

			public IntPtr m_PrinterInstance;
		}

		[ComImport]
		[SuppressUnmanagedCodeSecurity]
		[Guid("279AFA83-4981-11CE-A521-0020AF0BE560")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		internal interface ConnectionIssuerImporter
		{
			void _0001([In] AdapterEventEntry first, [MarshalAs(UnmanagedType.Interface)] out object reg, IntPtr proc);

			void _0001(IntPtr value);

			void _0001([In] [MarshalAs(UnmanagedType.Interface)] PublisherFilterResolver value, [In] [MarshalAs(UnmanagedType.Interface)] PublisherFilterResolver cont);

			void _0001(IntPtr config, [In] [MarshalAs(UnmanagedType.U4)] ProducerListAnnotation token);

			void _0001();

			void _0002(IntPtr res);

			void _0001(uint mean_last);

			void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid item);
		}

		[ComImport]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[Guid("279AFA85-4981-11CE-A521-0020AF0BE560")]
		[SuppressUnmanagedCodeSecurity]
		internal interface PublisherFilterResolver
		{
			void _0001([MarshalAs(UnmanagedType.LPStruct)] ServiceInstance task);

			void _0001(out uint spec, out uint second);

			void _0001();

			[return: MarshalAs(UnmanagedType.I4)]
			int _0001();

			void _0001(out uint def);

			[return: MarshalAs(UnmanagedType.I4)]
			int _0002();

			[return: MarshalAs(UnmanagedType.U4)]
			DiskStatementType _0001();

			void _0001([In] [MarshalAs(UnmanagedType.Interface)] ConnectionIssuerImporter var1, [In] AdapterEventEntry second);

			void _0001(int version_var1, uint remove_CFGAt, out IntPtr template, out int pred2, out IntPtr instance3, out int key4, [MarshalAs(UnmanagedType.U4)] AnnotationComposerWorker t5);

			void _0001(uint start_item, uint indexOf_connection, [In] [MarshalAs(UnmanagedType.U4)] MergeTextBufferType state);

			void _0001(uint indexOf_i);

			void _0001([In] RefList setup);

			void _0001(int index_res);

			void _0002(uint position_reference);

			void _0003(uint isize);

			void _0002();

			void _0001(IntPtr v, int regX, IntPtr third, int next_res2);

			void _0003();
		}

		[ComImport]
		[Guid("b0210783-89cd-11d0-af08-00a0c925cd16")]
		[SuppressUnmanagedCodeSecurity]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		internal interface AuthenticationIssuerMock
		{
			void _0001(uint config_High, [In] [MarshalAs(UnmanagedType.LPArray)] CandidateInstance[] cust);
		}

		private SourceMode errorInstance;

		private int m_ComposerInstance;

		private Guid _PropertyInstance;

		private Thread m_IssuerInstance;

		private SynchronizationContext _ReaderInstance;

		private object _ClientInstance;

		public static readonly Guid broadcasterInstance;

		public static readonly Guid m_ClassInstance;

		public static readonly Guid _RequestInstance;

		public static readonly Guid iteratorInstance;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(broadcasterInstance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerPropertyStruct(Guid ident)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			this._002Ector(ident, 40);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerPropertyStruct(Guid i, int pred_Y)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ClientInstance = new object();
			base._002Ector();
			if (i == Guid.Empty)
			{
				i = broadcasterInstance;
			}
			_PropertyInstance = i;
			m_ComposerInstance = pred_Y;
			_ReaderInstance = SynchronizationContext.Current;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				_0003();
			}
			finally
			{
				base.Finalize();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (Monitor.TryEnter(_ClientInstance, 50))
			{
				errorInstance = (SourceMode)0;
				Monitor.Exit(_ClientInstance);
			}
			else if (m_IssuerInstance != null)
			{
				m_IssuerInstance.Abort();
				m_IssuerInstance = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0002();
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ManagerPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			broadcasterInstance = new Guid("DEF00000-9C6D-47ED-AAF1-4DDA8F2B5C03");
			m_ClassInstance = new Guid("DEF00001-9C6D-47ED-AAF1-4DDA8F2B5C03");
			_RequestInstance = new Guid("DEF00002-9C6D-47ED-AAF1-4DDA8F2B5C03");
			iteratorInstance = new Guid("DEF00003-9C6D-47ED-AAF1-4DDA8F2B5C03");
		}
	}
}
