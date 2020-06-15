using GDBD.Mocks;
using GDBD.Workers;
using Newtonsoft.Annotations;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Filters
{
	[ComImport]
	[Guid("3137f1cd-fe5e-4805-a5d8-fb477448cb3d")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ProcInstance
	{
		void _0001([In] [MarshalAs(UnmanagedType.Interface)] PredicateIssuerMock param, out int b);

		void _0001([In] int versionres, [In] [MarshalAs(UnmanagedType.Interface)] PredicateIssuerMock second, [In] [MarshalAs(UnmanagedType.Interface)] MapperIssuerMock tag);

		void _0001();

		void _0001([In] int info_counter, [In] [MarshalAs(UnmanagedType.Interface)] DefinitionDic connection);

		void _0001([In] int no_info, [In] long polmin);

		void _0001([In] int init_High, [In] IntPtr selection);

		void _0001([In] int item_high);

		void _0002([In] int ID_last);

		void _0002();

		void _0001([In] int column_init, [In] ref Guid ord, [In] ref Guid proc, out IntPtr connection2);

		void _0001([In] int assetsize, [In] [Out] ParameterDic col);
	}
}
