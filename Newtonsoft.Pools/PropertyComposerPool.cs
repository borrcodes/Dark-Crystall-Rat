using Newtonsoft.Rules;
using System.Runtime.InteropServices;

namespace Newtonsoft.Pools
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
	internal interface PropertyComposerPool
	{
		[PreserveSig]
		int _0001(out StateFilter setup);
	}
}
