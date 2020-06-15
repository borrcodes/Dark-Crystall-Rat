using GDBD.Maps;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace GDBD.Mappers
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct ImporterReaderMapper
	{
		[FieldOffset(0)]
		public short indexerDic;

		[FieldOffset(2)]
		public short decoratorDic;

		[FieldOffset(4)]
		public short m_FieldDic;

		[FieldOffset(6)]
		public short _ItemDic;

		[FieldOffset(8)]
		public sbyte m_RegDic;

		[FieldOffset(8)]
		public byte _ProcessDic;

		[FieldOffset(8)]
		public short baseDic;

		[FieldOffset(8)]
		public ushort m_ContainerDic;

		[FieldOffset(8)]
		public int _ProccesorDic;

		[FieldOffset(8)]
		public uint _AdapterDic;

		[FieldOffset(8)]
		public int m_TokenDic;

		[FieldOffset(8)]
		public uint dispatcherDic;

		[FieldOffset(8)]
		public long accountDic;

		[FieldOffset(8)]
		public long singletonDic;

		[FieldOffset(8)]
		public float _ModelDic;

		[FieldOffset(8)]
		public double _MessageDic;

		[FieldOffset(8)]
		public short _ProductDic;

		[FieldOffset(8)]
		public int interceptorDic;

		[FieldOffset(8)]
		public System.Runtime.InteropServices.ComTypes.FILETIME _AlgoDic;

		[FieldOffset(8)]
		public BridgeReaderMapper annotationDic;

		[FieldOffset(8)]
		public IntPtr exporterDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ImporterReaderMapper LogoutError(long minparam)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ImporterReaderMapper result = default(ImporterReaderMapper);
			result.indexerDic = 20;
			result.accountDic = minparam;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] VisitError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] array = new byte[annotationDic._ImporterDic];
			Marshal.Copy(annotationDic.reponseDic, array, 0, array.Length);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VarEnum _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (VarEnum)indexerDic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			VarEnum varEnum = this._0001();
			switch (varEnum)
			{
			case VarEnum.VT_I1:
				return _ProcessDic;
			case VarEnum.VT_I2:
				return baseDic;
			case VarEnum.VT_I4:
				return _ProccesorDic;
			case VarEnum.VT_I8:
				return accountDic;
			case VarEnum.VT_INT:
				return baseDic;
			case VarEnum.VT_UI4:
				return _AdapterDic;
			case VarEnum.VT_UI8:
				return singletonDic;
			case VarEnum.VT_LPWSTR:
				return Marshal.PtrToStringUni(exporterDic);
			case VarEnum.VT_BLOB:
			case (VarEnum)4113:
				return VisitError();
			case VarEnum.VT_CLSID:
				return MockIteratorMapping.RunError<Guid>(exporterDic);
			case VarEnum.VT_BOOL:
				switch (_ProductDic)
				{
				case -1:
					return true;
				case 0:
					return false;
				default:
					throw new NotSupportedException("PropVariant VT_BOOL must be either -1 or 0");
				}
			default:
				throw new NotImplementedException("PropVariant " + varEnum);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ViewError(IntPtr res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			TestInstanceRule.CloneError(res);
		}
	}
}
