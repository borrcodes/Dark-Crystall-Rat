using Newtonsoft.Database;
using System.Runtime.InteropServices;

namespace Newtonsoft.Common
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C6E13370-30AC-11d0-A18C-00A0C9118956")]
	internal interface SchemaEvent
	{
		[PreserveSig]
		int _0001([In] PipelinePublishProjectCfgTargets key, out int pred, out int role, out int pol2, out int reference3, out WatsonLoggingFlags connection4);

		[PreserveSig]
		int _0001([In] PipelinePublishProjectCfgTargets res, [In] int ivk_high, [In] WatsonLoggingFlags pool);

		[PreserveSig]
		int _0001([In] PipelinePublishProjectCfgTargets instance, out int second, out WatsonLoggingFlags temp);
	}
}
