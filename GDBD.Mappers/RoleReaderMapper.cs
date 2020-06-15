using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Structs;
using Newtonsoft.Annotations;
using Newtonsoft.Consumers;
using Newtonsoft.Expressions;
using System.Runtime.InteropServices;
using System.Security;

namespace GDBD.Mappers
{
	[ComImport]
	[SuppressUnmanagedCodeSecurity]
	[Guid("d8ad0f58-5494-4102-97c5-ec798e59bcf4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	internal interface RoleReaderMapper
	{
		[PreserveSig]
		int _0001(out int key, out int cfg);

		[PreserveSig]
		int _0001(int vamount, out VARIANTFLAGS vis);

		[PreserveSig]
		int _0001(int ilow, out VBRuntimeKind pred);

		[PreserveSig]
		int _0001(int instance_max, int meancust, out ConfigIssuerImporter tag);

		[PreserveSig]
		int _0002(int i_Ptr, int column_caller, out ConfigIssuerImporter serv);

		[PreserveSig]
		int _0001(int param_X, [In] ref ConfigIssuerImporter token, DiffGramOperationType third);

		[PreserveSig]
		int _0002(int no__i, [In] ref ConfigIssuerImporter token, DiffGramOperationType third);

		[PreserveSig]
		int _0001(int end_first, out ConfigIssuerImporter ivk);

		[PreserveSig]
		int _0002(int offsetlast, out ConfigIssuerImporter visitor);

		[PreserveSig]
		int _0001(int indexOfasset, out int vis, out int util, out int col2);

		[PreserveSig]
		int _0001(int configamount, out int counter, out int util);

		[PreserveSig]
		int _0001(int init_start, out long second);

		[PreserveSig]
		int _0001(int previous_init, long connectionhigh);

		[PreserveSig]
		int _0001();

		[PreserveSig]
		int _0001(int vPtr);

		[PreserveSig]
		int _0002();

		[PreserveSig]
		int _0003();

		[PreserveSig]
		int _0001(int spec_amount, out WrapSideValues cont);

		[PreserveSig]
		int _0001(int indexOf_init, [In] ResolverList vis, tagExtentMode template, long task2_X, long sum_config3);

		[PreserveSig]
		int _0001(ScannerAttributeKind key, int caller_High, [In] [Out] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] CallbackTestItem[] res, out int reg2);

		[PreserveSig]
		int _0001(bool requiressetup);
	}
}
