using GDBD.Mocks;
using System.Runtime.InteropServices;

namespace Newtonsoft.Annotations
{
	internal static class ValDic
	{
		[DllImport("mfplat.dll", EntryPoint = "MFStartup", ExactSpelling = true, PreserveSig = false)]
		public static extern void MapError(int spec_end, int max_pol = 0);

		[DllImport("mfplat.dll", EntryPoint = "MFCreateMediaType", ExactSpelling = true, PreserveSig = false)]
		internal static extern void InsertError(out PredicateIssuerMock info);

		[DllImport("mfreadwrite.dll", EntryPoint = "MFCreateSourceReaderFromURL", ExactSpelling = true, PreserveSig = false)]
		public static extern void FlushError([In] [MarshalAs(UnmanagedType.LPWStr)] string init, [In] MapperIssuerMock pred, [MarshalAs(UnmanagedType.Interface)] out SystemDic rule);
	}
}
