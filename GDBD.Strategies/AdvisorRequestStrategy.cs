using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace GDBD.Strategies
{
	internal static class AdvisorRequestStrategy
	{
		[DllImport("ole32.dll", EntryPoint = "CreateBindCtx")]
		public static extern int ExcludeInstance(int key_offset, out IBindCtx selection);

		[DllImport("ole32.dll", CharSet = CharSet.Unicode, EntryPoint = "MkParseDisplayName")]
		public static extern int SetupInstance(IBindCtx task, string token, ref int third, out IMoniker res2);

		[DllImport("ntdll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcpy")]
		public unsafe static extern int ManageInstance(byte* setup, byte* reg, int third_high);

		[DllImport("oleaut32.dll", EntryPoint = "OleCreatePropertyFrame")]
		public static extern int InitInstance(IntPtr reference, int connection_counter, int rule_X, [MarshalAs(UnmanagedType.LPWStr)] string param2, int position_ivk3, [MarshalAs(UnmanagedType.Interface)] ref object def4, int versionconnection5, IntPtr cfg6, int previoustoken7, int column_spec8, IntPtr var19);
	}
}
