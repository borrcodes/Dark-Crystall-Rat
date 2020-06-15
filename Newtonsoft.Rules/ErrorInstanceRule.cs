using System.Runtime.InteropServices;

namespace Newtonsoft.Rules
{
	[ComImport]
	[Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface ErrorInstanceRule
	{
		void _0001(out int setup);

		void _0001([In] int firsthigh, [MarshalAs(UnmanagedType.IUnknown)] out object reg);

		void _0001([In] [MarshalAs(UnmanagedType.IUnknown)] object v);

		void _0002([In] int info_ID, [MarshalAs(UnmanagedType.IUnknown)] out object b);

		void _0001([In] int indexOffirst, [In] [MarshalAs(UnmanagedType.IUnknown)] object ivk);

		void _0001();
	}
}
