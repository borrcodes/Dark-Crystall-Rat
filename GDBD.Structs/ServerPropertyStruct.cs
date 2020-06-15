using GDBD.Items;
using System.Runtime.InteropServices;

namespace GDBD.Structs
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
	[ComVisible(false)]
	internal struct ServerPropertyStruct
	{
		public SerializerTestItem m_IssuerFilter;

		public ChildType _ReaderFilter;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string _ClientFilter;
	}
}
