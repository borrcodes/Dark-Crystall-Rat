using GDBD.Workers;
using Newtonsoft.Common;
using System;
using System.Runtime.InteropServices;

namespace GDBD.Mocks
{
	[ComImport]
	[Guid("70ae66f2-c809-4e4f-8915-bdcb406b7993")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface SystemDic
	{
		void _0001([In] int param, [MarshalAs(UnmanagedType.Bool)] out bool b);

		void _0001([In] int lengthparam, [In] [MarshalAs(UnmanagedType.Bool)] bool readivk);

		void _0001([In] int firstID, [In] int pred_Y, out PredicateIssuerMock proc);

		void _0001([In] int def_X, out PredicateIssuerMock reg);

		void _0001([In] int indexOf_def, IntPtr ord, [In] PredicateIssuerMock temp);

		void _0001([In] [MarshalAs(UnmanagedType.LPStruct)] Guid reference, [In] IntPtr connection);

		void _0001([In] int first_low, [In] int cust_Z, out int template, out CrashDumpGrbit connection2, out ulong task3, out DefinitionDic pol4);

		void _0001([In] int next_setup);

		void _0001([In] int offsetinfo, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid cust, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid state, out IntPtr spec2);

		[PreserveSig]
		int _0001([In] int sizeinit, [In] [MarshalAs(UnmanagedType.LPStruct)] Guid result, [Out] IntPtr third);
	}
}
