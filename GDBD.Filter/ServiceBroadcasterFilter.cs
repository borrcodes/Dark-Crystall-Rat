using GDBD.Mappers;
using GDBD.Structs;
using System.Runtime.InteropServices;

namespace GDBD.Filter
{
	internal struct ServiceBroadcasterFilter
	{
		public VisibleSearch poolList;

		public MappingDataType _ValList;

		public float m_InvocationList;

		public float _DefinitionList;

		public float m_SystemList;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string identifierList;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string m_GetterList;
	}
}
