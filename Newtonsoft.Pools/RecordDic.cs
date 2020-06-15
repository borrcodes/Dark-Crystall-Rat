using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Consumers;
using System;
using System.Runtime.InteropServices;

namespace Newtonsoft.Pools
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bf94c121-5b05-4e6f-8000-ba598961414d")]
	public interface RecordDic
	{
		void _0001(out int key, out int pred, out int temp, out int init2);

		void _0001(out int item, out int vis);

		void _0001([In] int start_def, [In] [Out] IntPtr ivk, [In] int position_tag, [In] [Out] IntPtr visitor2);

		void _0001([In] int item_start, out IdentifierDic connection);

		void _0001([In] int idx_instance, out InitializerIssuerImporter pol);

		void _0001(out MapperIssuerMock i);

		void _0001([In] int setup_Z, out MapperIssuerMock connection);

		void _0002([In] int res, out MapperIssuerMock token);

		void _0001([In] int init_start);

		void _0001([In] int minsetup, [In] IntPtr ivk);

		void _0001([In] int init_low, [In] int pred_X, out PredicateIssuerMock template);

		void _0002([In] int res, [In] int result, out PredicateIssuerMock c);

		void _0001([In] int assetstart, [In] PredicateIssuerMock pol, [In] CreatorDic comp);

		void _0002([In] int infocounter, [In] PredicateIssuerMock selection, [In] CreatorDic temp);

		void _0001([In] int size_param, out PredicateIssuerMock col);

		void _0002([In] int config_count, out PredicateIssuerMock map);

		void _0001([In] int last_min, out LogonType pred);

		void _0001([In] int instance_offset, out TriValueBoolean col);

		void _0001([In] long referenceY, [In] long counter);

		void _0001([In] int key, [In] MerchantTestItem selection);

		void _0001([In] RuleReaderMapper spec, [In] IntPtr cust);

		void _0001([In] int instance_Z, [In] DefinitionDic cfg, int dic_amount);

		[PreserveSig]
		int _0001([In] ControlTraceCodes instance, [In] int ivk, [In] [Out] [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ClientComposerPool[] consumer, out ReceiveSecurityHeaderBindingModes cfg2);
	}
}
