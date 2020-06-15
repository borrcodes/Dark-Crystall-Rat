using GDBD.Workers;
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace GDBD.Bridges
{
	internal class InfoClientBridge
	{
		internal class ProductEventEntry : Attribute
		{
			internal class ExceptionFilterResolver<T>
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public ExceptionFilterResolver()
				{
					//Discarded unreachable code: IL_0002, IL_0006
					//IL_0003: Incompatible stack heights: 0 vs 1
					//IL_0007: Incompatible stack heights: 0 vs 1
					SingletonReader.PushGlobal();
					base._002Ector();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
			public ProductEventEntry(object res)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		internal class ParserRequestStrategy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
			internal static string VisitTests(string instance, string cont)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				byte[] bytes = Encoding.Unicode.GetBytes(instance);
				byte[] array = bytes;
				byte[] key = new byte[32]
				{
					82,
					102,
					104,
					110,
					32,
					77,
					24,
					34,
					118,
					181,
					51,
					17,
					18,
					51,
					12,
					109,
					10,
					32,
					77,
					24,
					34,
					158,
					161,
					41,
					97,
					28,
					118,
					181,
					5,
					25,
					1,
					88
				};
				byte[] iV = LoginTests(Encoding.Unicode.GetBytes(cont));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = WriteIterator();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ParserRequestStrategy()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint TokenReader(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr CustomerIteratorMapping();

		internal struct TestEventConsumer
		{
			internal bool m_DispatcherReader;

			internal byte[] _AccountReader;
		}

		[Flags]
		private enum InterpreterIteratorMapping
		{

		}

		private static Assembly _ExceptionReader;

		private static bool m_DatabaseReader;

		private static byte[] m_CallbackReader;

		private static IntPtr tagReader;

		internal static TokenReader m_DecoratorReader;

		private static long m_FieldReader;

		private static int _BaseReader;

		[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
		private static bool proccesorReader;

		internal static Hashtable _AdapterReader;

		private static int _ImporterReader;

		private static bool m_RuleReader;

		private static byte[] listenerReader;

		private static uint[] _AttributeReader;

		private static bool regReader;

		private static byte[] _MerchantReader;

		private static byte[] _SerializerReader;

		private static int[] m_RoleReader;

		private static bool factoryReader;

		private static object m_WriterReader;

		internal static TokenReader m_IndexerReader;

		private static bool _HelperReader;

		private static bool _ProcessReader;

		private static long reponseReader;

		private static int m_ItemReader;

		private static IntPtr m_ContainerReader;

		private static int m_CreatorReader;

		private static IntPtr specificationReader;

		private static SortedList _BridgeReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static InfoClientBridge()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			_HelperReader = false;
			_ExceptionReader = typeof(InfoClientBridge).Assembly;
			_AttributeReader = new uint[64]
			{
				3614090360u,
				3905402710u,
				606105819u,
				3250441966u,
				4118548399u,
				1200080426u,
				2821735955u,
				4249261313u,
				1770035416u,
				2336552879u,
				4294925233u,
				2304563134u,
				1804603682u,
				4254626195u,
				2792965006u,
				1236535329u,
				4129170786u,
				3225465664u,
				643717713u,
				3921069994u,
				3593408605u,
				38016083u,
				3634488961u,
				3889429448u,
				568446438u,
				3275163606u,
				4107603335u,
				1163531501u,
				2850285829u,
				4243563512u,
				1735328473u,
				2368359562u,
				4294588738u,
				2272392833u,
				1839030562u,
				4259657740u,
				2763975236u,
				1272893353u,
				4139469664u,
				3200236656u,
				681279174u,
				3936430074u,
				3572445317u,
				76029189u,
				3654602809u,
				3873151461u,
				530742520u,
				3299628645u,
				4096336452u,
				1126891415u,
				2878612391u,
				4237533241u,
				1700485571u,
				2399980690u,
				4293915773u,
				2240044497u,
				1873313359u,
				4264355552u,
				2734768916u,
				1309151649u,
				4149444226u,
				3174756917u,
				718787259u,
				3951481745u
			};
			m_DatabaseReader = false;
			factoryReader = false;
			_SerializerReader = new byte[0];
			m_CallbackReader = new byte[0];
			_MerchantReader = new byte[0];
			listenerReader = new byte[0];
			tagReader = IntPtr.Zero;
			specificationReader = IntPtr.Zero;
			m_WriterReader = new string[0];
			m_RoleReader = new int[0];
			m_CreatorReader = 1;
			m_RuleReader = false;
			_BridgeReader = new SortedList();
			_ImporterReader = 0;
			reponseReader = 0L;
			m_IndexerReader = null;
			m_DecoratorReader = null;
			m_FieldReader = 0L;
			m_ItemReader = 0;
			regReader = false;
			_ProcessReader = false;
			_BaseReader = 0;
			m_ContainerReader = IntPtr.Zero;
			proccesorReader = false;
			_AdapterReader = new Hashtable();
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveGlobal()
		{
		}//Discarded unreachable code: IL_0002
		//IL_0003: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ManageIterator(byte[] reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			uint[] array = new uint[16];
			int num = 448 - reference.Length * 8 % 512;
			uint num2 = (uint)((num + 512) % 512);
			if (num2 == 0)
			{
				num2 = 512u;
			}
			uint num3 = (uint)(reference.Length + num2 / 8u + 8);
			ulong num4 = (ulong)((long)reference.Length * 8L);
			byte[] array2 = new byte[num3];
			for (int i = 0; i < reference.Length; i++)
			{
				array2[i] = reference[i];
			}
			array2[reference.Length] |= 128;
			for (int num5 = 8; num5 > 0; num5--)
			{
				array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFF);
			}
			uint num6 = (uint)(array2.Length * 8) / 32u;
			uint def = 1732584193u;
			uint def2 = 4023233417u;
			uint def3 = 2562383102u;
			uint def4 = 271733878u;
			for (uint num7 = 0u; num7 < num6 / 16u; num7++)
			{
				uint num8 = num7 << 6;
				for (uint num9 = 0u; num9 < 61; num9 += 4)
				{
					array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
				}
				uint num10 = def;
				uint num11 = def2;
				uint num12 = def3;
				uint num13 = def4;
				InitIterator(ref def, def2, def3, def4, 0u, 7, 1u, array);
				InitIterator(ref def4, def, def2, def3, 1u, 12, 2u, array);
				InitIterator(ref def3, def4, def, def2, 2u, 17, 3u, array);
				InitIterator(ref def2, def3, def4, def, 3u, 22, 4u, array);
				InitIterator(ref def, def2, def3, def4, 4u, 7, 5u, array);
				InitIterator(ref def4, def, def2, def3, 5u, 12, 6u, array);
				InitIterator(ref def3, def4, def, def2, 6u, 17, 7u, array);
				InitIterator(ref def2, def3, def4, def, 7u, 22, 8u, array);
				InitIterator(ref def, def2, def3, def4, 8u, 7, 9u, array);
				InitIterator(ref def4, def, def2, def3, 9u, 12, 10u, array);
				InitIterator(ref def3, def4, def, def2, 10u, 17, 11u, array);
				InitIterator(ref def2, def3, def4, def, 11u, 22, 12u, array);
				InitIterator(ref def, def2, def3, def4, 12u, 7, 13u, array);
				InitIterator(ref def4, def, def2, def3, 13u, 12, 14u, array);
				InitIterator(ref def3, def4, def, def2, 14u, 17, 15u, array);
				InitIterator(ref def2, def3, def4, def, 15u, 22, 16u, array);
				DefineIterator(ref def, def2, def3, def4, 1u, 5, 17u, array);
				DefineIterator(ref def4, def, def2, def3, 6u, 9, 18u, array);
				DefineIterator(ref def3, def4, def, def2, 11u, 14, 19u, array);
				DefineIterator(ref def2, def3, def4, def, 0u, 20, 20u, array);
				DefineIterator(ref def, def2, def3, def4, 5u, 5, 21u, array);
				DefineIterator(ref def4, def, def2, def3, 10u, 9, 22u, array);
				DefineIterator(ref def3, def4, def, def2, 15u, 14, 23u, array);
				DefineIterator(ref def2, def3, def4, def, 4u, 20, 24u, array);
				DefineIterator(ref def, def2, def3, def4, 9u, 5, 25u, array);
				DefineIterator(ref def4, def, def2, def3, 14u, 9, 26u, array);
				DefineIterator(ref def3, def4, def, def2, 3u, 14, 27u, array);
				DefineIterator(ref def2, def3, def4, def, 8u, 20, 28u, array);
				DefineIterator(ref def, def2, def3, def4, 13u, 5, 29u, array);
				DefineIterator(ref def4, def, def2, def3, 2u, 9, 30u, array);
				DefineIterator(ref def3, def4, def, def2, 7u, 14, 31u, array);
				DefineIterator(ref def2, def3, def4, def, 12u, 20, 32u, array);
				CollectIterator(ref def, def2, def3, def4, 5u, 4, 33u, array);
				CollectIterator(ref def4, def, def2, def3, 8u, 11, 34u, array);
				CollectIterator(ref def3, def4, def, def2, 11u, 16, 35u, array);
				CollectIterator(ref def2, def3, def4, def, 14u, 23, 36u, array);
				CollectIterator(ref def, def2, def3, def4, 1u, 4, 37u, array);
				CollectIterator(ref def4, def, def2, def3, 4u, 11, 38u, array);
				CollectIterator(ref def3, def4, def, def2, 7u, 16, 39u, array);
				CollectIterator(ref def2, def3, def4, def, 10u, 23, 40u, array);
				CollectIterator(ref def, def2, def3, def4, 13u, 4, 41u, array);
				CollectIterator(ref def4, def, def2, def3, 0u, 11, 42u, array);
				CollectIterator(ref def3, def4, def, def2, 3u, 16, 43u, array);
				CollectIterator(ref def2, def3, def4, def, 6u, 23, 44u, array);
				CollectIterator(ref def, def2, def3, def4, 9u, 4, 45u, array);
				CollectIterator(ref def4, def, def2, def3, 12u, 11, 46u, array);
				CollectIterator(ref def3, def4, def, def2, 15u, 16, 47u, array);
				CollectIterator(ref def2, def3, def4, def, 2u, 23, 48u, array);
				SortIterator(ref def, def2, def3, def4, 0u, 6, 49u, array);
				SortIterator(ref def4, def, def2, def3, 7u, 10, 50u, array);
				SortIterator(ref def3, def4, def, def2, 14u, 15, 51u, array);
				SortIterator(ref def2, def3, def4, def, 5u, 21, 52u, array);
				SortIterator(ref def, def2, def3, def4, 12u, 6, 53u, array);
				SortIterator(ref def4, def, def2, def3, 3u, 10, 54u, array);
				SortIterator(ref def3, def4, def, def2, 10u, 15, 55u, array);
				SortIterator(ref def2, def3, def4, def, 1u, 21, 56u, array);
				SortIterator(ref def, def2, def3, def4, 8u, 6, 57u, array);
				SortIterator(ref def4, def, def2, def3, 15u, 10, 58u, array);
				SortIterator(ref def3, def4, def, def2, 6u, 15, 59u, array);
				SortIterator(ref def2, def3, def4, def, 13u, 21, 60u, array);
				SortIterator(ref def, def2, def3, def4, 4u, 6, 61u, array);
				SortIterator(ref def4, def, def2, def3, 11u, 10, 62u, array);
				SortIterator(ref def3, def4, def, def2, 2u, 15, 63u, array);
				SortIterator(ref def2, def3, def4, def, 9u, 21, 64u, array);
				def += num10;
				def2 += num11;
				def3 += num12;
				def4 += num13;
			}
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(def), 0, array3, 0, 4);
			Array.Copy(BitConverter.GetBytes(def2), 0, array3, 4, 4);
			Array.Copy(BitConverter.GetBytes(def3), 0, array3, 8, 4);
			Array.Copy(BitConverter.GetBytes(def4), 0, array3, 12, 4);
			return array3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void InitIterator(ref uint def, uint max_pred, uint remove_TAGAt, uint config2_high, uint item3_High, ushort def4X, uint indexOfresult5, uint[] param6)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			def = max_pred + CallIterator(def + ((max_pred & remove_TAGAt) | (~max_pred & config2_high)) + param6[item3_High] + _AttributeReader[indexOfresult5 - 1], def4X);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void DefineIterator(ref uint setup, uint b, uint state_length, uint minx2, uint endtask3, ushort ID_instance4, uint insert_POL5At, uint[] reg6)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			setup = b + CallIterator(setup + ((b & minx2) | (state_length & ~minx2)) + reg6[endtask3] + _AttributeReader[insert_POL5At - 1], ID_instance4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CollectIterator(ref uint first, uint minpol, uint column_comp, uint minconnection2, uint caller3_max, ushort columncol4, uint lengthparam5, uint[] t6)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			first = minpol + CallIterator(first + (minpol ^ column_comp ^ minconnection2) + t6[caller3_max] + _AttributeReader[lengthparam5 - 1], columncol4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SortIterator(ref uint value, uint b, uint helpercounter, uint info2high, uint attr3_Y, ushort column_item4, uint ivk5Z, uint[] def6)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			value = b + CallIterator(value + (helpercounter ^ (b | ~info2high)) + def6[attr3_Y] + _AttributeReader[ivk5Z - 1], column_item4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint CallIterator(uint ident_count, ushort token_offset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (ident_count >> 32 - token_offset) | (ident_count << (int)token_offset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PublishIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!m_DatabaseReader)
			{
				RevertIterator();
				m_DatabaseReader = true;
			}
			return factoryReader;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SymmetricAlgorithm WriteIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (PublishIterator())
			{
				return new AesCryptoServiceProvider();
			}
			try
			{
				return new RijndaelManaged();
			}
			catch
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void RevertIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				factoryReader = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] LoginTests(byte[] i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!PublishIterator())
			{
				return new MD5CryptoServiceProvider().ComputeHash(i);
			}
			return ManageIterator(i);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint DisableTests(uint def_X)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
		internal static string VerifyTests(int task_Low)
		{
			//Discarded unreachable code: IL_0002, IL_0bdd, IL_3959
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_3650: Incompatible stack heights: 0 vs 1
			//IL_365a: Incompatible stack heights: 0 vs 1
			//IL_3684: Incompatible stack heights: 0 vs 1
			//IL_368e: Incompatible stack heights: 0 vs 1
			//IL_3698: Incompatible stack heights: 0 vs 1
			//IL_36a2: Incompatible stack heights: 0 vs 1
			//IL_36ac: Incompatible stack heights: 0 vs 1
			//IL_36b6: Incompatible stack heights: 0 vs 1
			//IL_36c0: Incompatible stack heights: 0 vs 1
			//IL_36d4: Incompatible stack heights: 0 vs 1
			//IL_36de: Incompatible stack heights: 0 vs 1
			//IL_36e8: Incompatible stack heights: 0 vs 1
			//IL_36f2: Incompatible stack heights: 0 vs 1
			//IL_36fc: Incompatible stack heights: 0 vs 1
			//IL_3706: Incompatible stack heights: 0 vs 1
			//IL_3710: Incompatible stack heights: 0 vs 1
			//IL_371a: Incompatible stack heights: 0 vs 1
			//IL_3724: Incompatible stack heights: 0 vs 1
			//IL_3738: Incompatible stack heights: 0 vs 1
			//IL_3742: Incompatible stack heights: 0 vs 1
			//IL_374c: Incompatible stack heights: 0 vs 1
			//IL_3756: Incompatible stack heights: 0 vs 1
			//IL_3760: Incompatible stack heights: 0 vs 1
			//IL_376a: Incompatible stack heights: 0 vs 1
			//IL_3774: Incompatible stack heights: 0 vs 1
			//IL_377e: Incompatible stack heights: 0 vs 1
			//IL_3788: Incompatible stack heights: 0 vs 1
			//IL_379c: Incompatible stack heights: 0 vs 1
			//IL_37a6: Incompatible stack heights: 0 vs 1
			//IL_37b0: Incompatible stack heights: 0 vs 1
			//IL_37ba: Incompatible stack heights: 0 vs 2
			//IL_37c4: Incompatible stack heights: 0 vs 1
			//IL_37ce: Incompatible stack heights: 0 vs 1
			//IL_37d8: Incompatible stack heights: 0 vs 1
			//IL_37e2: Incompatible stack heights: 0 vs 1
			//IL_37ec: Incompatible stack heights: 0 vs 1
			//IL_37f6: Incompatible stack heights: 0 vs 1
			//IL_3800: Incompatible stack heights: 0 vs 1
			//IL_380a: Incompatible stack heights: 0 vs 1
			//IL_3814: Incompatible stack heights: 0 vs 1
			//IL_381e: Incompatible stack heights: 0 vs 1
			//IL_3832: Incompatible stack heights: 0 vs 1
			//IL_383c: Incompatible stack heights: 0 vs 1
			//IL_3846: Incompatible stack heights: 0 vs 1
			//IL_385a: Incompatible stack heights: 0 vs 1
			//IL_3864: Incompatible stack heights: 0 vs 1
			//IL_386e: Incompatible stack heights: 0 vs 1
			//IL_3878: Incompatible stack heights: 0 vs 1
			//IL_3882: Incompatible stack heights: 0 vs 1
			//IL_388c: Incompatible stack heights: 0 vs 1
			//IL_3896: Incompatible stack heights: 0 vs 1
			//IL_38aa: Incompatible stack heights: 0 vs 1
			//IL_38b4: Incompatible stack heights: 0 vs 1
			//IL_38be: Incompatible stack heights: 0 vs 1
			//IL_38c8: Incompatible stack heights: 0 vs 1
			//IL_38d2: Incompatible stack heights: 0 vs 1
			//IL_38dc: Incompatible stack heights: 0 vs 1
			//IL_38e6: Incompatible stack heights: 0 vs 1
			//IL_38f0: Incompatible stack heights: 0 vs 1
			//IL_38fa: Incompatible stack heights: 0 vs 1
			//IL_3904: Incompatible stack heights: 0 vs 1
			//IL_390e: Incompatible stack heights: 0 vs 1
			//IL_3922: Incompatible stack heights: 0 vs 1
			//IL_392c: Incompatible stack heights: 0 vs 1
			//IL_3936: Incompatible stack heights: 0 vs 1
			//IL_3940: Incompatible stack heights: 0 vs 1
			//IL_394a: Incompatible stack heights: 0 vs 1
			//IL_3954: Incompatible stack heights: 0 vs 1
			int num = 346;
			byte[] array2 = default(byte[]);
			int num6 = default(int);
			CryptoStream cryptoStream = default(CryptoStream);
			int num5 = default(int);
			byte[] array = default(byte[]);
			int num8 = default(int);
			byte[] array3 = default(byte[]);
			byte[] array4 = default(byte[]);
			int num32 = default(int);
			byte[] array5 = default(byte[]);
			int num7 = default(int);
			BinaryReader binaryReader = default(BinaryReader);
			int num26 = default(int);
			uint num10 = default(uint);
			int num29 = default(int);
			byte[] array6 = default(byte[]);
			int num30 = default(int);
			int num34 = default(int);
			uint num40 = default(uint);
			uint num33 = default(uint);
			int num39 = default(int);
			uint num9 = default(uint);
			SymmetricAlgorithm symmetricAlgorithm = default(SymmetricAlgorithm);
			byte[] array7 = default(byte[]);
			ICryptoTransform transform = default(ICryptoTransform);
			uint num36 = default(uint);
			int num11 = default(int);
			MemoryStream memoryStream = default(MemoryStream);
			uint num27 = default(uint);
			uint num38 = default(uint);
			int num35 = default(int);
			uint num12 = default(uint);
			int num4 = default(int);
			int num31 = default(int);
			int num28 = default(int);
			while (true)
			{
				IL_0be2:
				int num2 = num;
				while (true)
				{
					IL_0be6:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 93:
							array2[28] = (byte)num6;
							num2 = 321;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 358;
						case 358:
							WriteGlobal(cryptoStream);
							num3 = 177;
							continue;
						case 288:
							break;
						case 33:
							goto IL_0054;
						case 388:
							goto IL_006c;
						case 4:
							array2[29] = 67;
							num2 = 90;
							goto IL_0be6;
						case 60:
							array2[9] = (byte)num5;
							num3 = 91;
							continue;
						case 140:
							goto IL_00c6;
						case 99:
							array[6] = 60;
							num2 = 330;
							IncludeGlobal();
							if ((int)/*Error near IL_010d: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 294;
						case 294:
							array2[18] = 53;
							num = 6;
							goto IL_0be2;
						case 173:
							array[10] = (byte)num8;
							num = 157;
							goto IL_0be2;
						case 45:
							array2[23] = 145;
							num2 = 338;
							IncludeGlobal();
							if ((int)/*Error near IL_016c: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 120;
						case 118:
							array3[3] = array4[1];
							num2 = 166;
							LogoutGlobal();
							if ((int)/*Error near IL_018c: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 320;
						case 320:
							array[12] = (byte)num8;
							num = 402;
							goto IL_0be2;
						case 143:
							num6 = 79 - 16;
							num2 = 11;
							LogoutGlobal();
							if ((int)/*Error near IL_01c6: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 246;
						case 246:
							array[9] = 146;
							num2 = 398;
							goto IL_0be6;
						case 160:
							array[14] = 110;
							num = 136;
							goto IL_0be2;
						case 378:
							array3[13] = array4[6];
							num = 187;
							goto IL_0be2;
						case 125:
							num32 = array5.Length / 4;
							num = 190;
							goto IL_0be2;
						case 355:
							num7 = 136 - 45;
							num = 155;
							goto IL_0be2;
						case 32:
							ConnectGlobal(_ExceptionReader, "Class.Global");
							new BinaryReader((Stream)/*Error near IL_36b6: Stack underflow*/);
							binaryReader = (BinaryReader)/*Error near IL_0273: Stack underflow*/;
							num3 = 110;
							continue;
						case 169:
							array2[31] = (byte)num6;
							num2 = 285;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 110;
						case 110:
							SetGlobal(binaryReader);
							CollectGlobal((object)/*Error near IL_36ca: Stack underflow*/, 0L);
							num3 = 79;
							continue;
						case 176:
							num6 = 201 - 67;
							num3 = 138;
							continue;
						case 69:
							array2[30] = 96;
							num3 = 345;
							continue;
						case 251:
							if (num26 > 0)
							{
								num2 = 272;
								goto IL_0be6;
							}
							goto case 8;
						case 382:
							array[6] = (byte)num8;
							num2 = 99;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 325;
						case 325:
							array2[21] = 174;
							num = 303;
							goto IL_0be2;
						case 90:
							array2[29] = 105;
							num2 = 301;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 27;
						case 27:
							num10 <<= 8;
							num2 = 19;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 328;
						case 328:
							array2[6] = (byte)num5;
							num3 = 159;
							continue;
						case 89:
							array2[14] = (byte)num5;
							num3 = 224;
							continue;
						case 189:
						case 372:
							if (num29 < num26)
							{
								if (num29 > 0)
								{
									num3 = 27;
									continue;
								}
								goto case 19;
							}
							num = 47;
							goto IL_0be2;
						case 53:
							_MerchantReader = array6;
							num2 = 362;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 164;
						case 164:
							array6[num30 + num34] = (byte)((num40 & num33) >> num39);
							num2 = 336;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 391;
						case 391:
							num6 = 235 - 78;
							num2 = 386;
							goto IL_0be6;
						case 138:
							array2[19] = (byte)num6;
							num2 = 15;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 48;
						case 48:
							num40 = (num9 ^ num10);
							num2 = 415;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 124;
						case 124:
							array[9] = (byte)num7;
							num = 29;
							goto IL_0be2;
						case 155:
							array[13] = (byte)num7;
							num2 = 82;
							goto IL_0be6;
						case 232:
							array[7] = 81;
							num = 154;
							goto IL_0be2;
						case 204:
							array2[16] = (byte)num6;
							num2 = 111;
							goto IL_0be6;
						case 171:
							array[3] = (byte)num8;
							num2 = 168;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 371;
						case 371:
							num39 += 8;
							num3 = 164;
							continue;
						case 193:
							array2[1] = 98;
							num2 = 129;
							goto IL_0be6;
						case 151:
							array2[14] = (byte)num6;
							num2 = 376;
							LogoutGlobal();
							if ((int)/*Error near IL_0521: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 251;
						case 310:
							num6 = 39 + 45;
							num2 = 40;
							LogoutGlobal();
							if ((int)/*Error near IL_0548: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 277;
						case 277:
							array2[17] = 208;
							num = 253;
							goto IL_0be2;
						case 92:
							array2[12] = 95;
							num2 = 135;
							goto IL_0be6;
						case 240:
							array2[4] = 183;
							num2 = 81;
							goto IL_0be6;
						case 39:
							num6 = 220 - 73;
							num = 373;
							goto IL_0be2;
						case 267:
							array[13] = (byte)num7;
							num = 329;
							goto IL_0be2;
						case 223:
							num8 = 172 - 53;
							num3 = 85;
							continue;
						case 213:
							array2[26] = 159;
							num3 = 365;
							continue;
						case 70:
							array2[21] = 160;
							num2 = 325;
							IncludeGlobal();
							if ((int)/*Error near IL_063e: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 396;
						case 415:
							num34 = 0;
							num3 = 86;
							continue;
						case 234:
							ResetGlobal(symmetricAlgorithm, array7, array3);
							transform = (ICryptoTransform)/*Error near IL_065d: Stack underflow*/;
							num3 = 380;
							continue;
						case 224:
							num6 = 91 + 78;
							num = 16;
							goto IL_0be2;
						case 350:
							num7 = 240 - 80;
							num = 399;
							goto IL_0be2;
						case 20:
							num7 = 40 + 62;
							num2 = 283;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 109;
						case 109:
							num6 = 45 + 118;
							num2 = 219;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 7;
						case 7:
							num5 = 142 - 28;
							num3 = 394;
							continue;
						case 172:
							num10 = 0u;
							num = 243;
							goto IL_0be2;
						case 123:
							num8 = 58 + 113;
							num = 318;
							goto IL_0be2;
						case 2:
							array6[num30] = (byte)(num36 & 0xFF);
							num2 = 352;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 14;
						case 14:
							num5 = 50 + 86;
							num = 242;
							goto IL_0be2;
						case 321:
							num5 = 179 + 19;
							num3 = 84;
							continue;
						case 370:
							array2[27] = (byte)num5;
							num = 367;
							goto IL_0be2;
						case 218:
							array2[1] = 160;
							num2 = 281;
							LogoutGlobal();
							if ((int)/*Error near IL_07a3: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 295;
						case 295:
							SearchGlobal(_ExceptionReader);
							UpdateGlobal((object)/*Error near IL_3710: Stack underflow*/);
							array4 = (byte[])/*Error near IL_07b4: Stack underflow*/;
							num = 323;
							goto IL_0be2;
						case 66:
							array[13] = (byte)num7;
							num2 = 355;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 26;
						case 26:
							array2[5] = 45;
							num3 = 54;
							continue;
						case 385:
							array[7] = (byte)num8;
							num = 20;
							goto IL_0be2;
						case 174:
							array[8] = 173;
							num = 202;
							goto IL_0be2;
						case 139:
							num5 = 80 + 62;
							num = 390;
							goto IL_0be2;
						case 272:
							num32++;
							num = 8;
							goto IL_0be2;
						case 399:
							array[1] = (byte)num7;
							num2 = 104;
							goto IL_0be6;
						case 217:
							num5 = 181 - 60;
							num2 = 163;
							LogoutGlobal();
							if ((int)/*Error near IL_0898: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 284;
						case 284:
							array[7] = (byte)num8;
							num3 = 232;
							continue;
						case 289:
							if (num11 == num32 - 1)
							{
								num = 257;
								goto IL_0be2;
							}
							goto IL_3321;
						case 154:
							num8 = 149 - 49;
							num = 385;
							goto IL_0be2;
						case 56:
							array2[16] = (byte)num5;
							num2 = 7;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 83;
						case 83:
							num7 = 203 - 67;
							num3 = 288;
							continue;
						case 318:
							array[14] = (byte)num8;
							num3 = 141;
							continue;
						case 117:
							array2[15] = (byte)num5;
							num2 = 269;
							IncludeGlobal();
							if ((int)/*Error near IL_094d: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 129;
						case 129:
							num5 = 130 - 43;
							num2 = 348;
							goto IL_0be6;
						case 199:
							array2[3] = (byte)num5;
							num = 239;
							goto IL_0be2;
						case 44:
							num6 = 187 - 62;
							num = 93;
							goto IL_0be2;
						case 161:
							num8 = 104 - 67;
							num3 = 171;
							continue;
						case 96:
							num8 = 151 - 50;
							num2 = 173;
							goto IL_0be6;
						case 239:
							array2[3] = 76;
							num2 = 408;
							goto IL_0be6;
						case 9:
							goto IL_09f4;
						case 299:
							array[13] = (byte)num8;
							num2 = 71;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 256;
						case 256:
							array[8] = 94;
							num3 = 174;
							continue;
						case 150:
							array2[3] = 169;
							num2 = 145;
							goto IL_0be6;
						case 34:
							array2[10] = (byte)num5;
							num3 = 194;
							continue;
						case 271:
							num5 = 26 + 111;
							num2 = 180;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 408;
						case 408:
							num6 = 155 - 51;
							num = 185;
							goto IL_0be2;
						case 393:
							num6 = 194 + 18;
							num2 = 103;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 306;
						case 306:
							array2[30] = (byte)num5;
							num3 = 268;
							continue;
						case 208:
							array[2] = 102;
							num = 73;
							goto IL_0be2;
						case 31:
							array2[8] = 100;
							num3 = 259;
							continue;
						case 186:
							ChangeGlobal(binaryReader);
							num = 298;
							goto IL_0be2;
						case 220:
							num6 = 211 - 89;
							num = 134;
							goto IL_0be2;
						case 147:
							array2[31] = (byte)num6;
							num3 = 353;
							continue;
						case 300:
							RestartGlobal(memoryStream);
							_MerchantReader = (byte[])/*Error near IL_0b7a: Stack underflow*/;
							num = 401;
							goto IL_0be2;
						case 236:
							num8 = 23 + 83;
							num3 = 305;
							continue;
						case 37:
							array2[13] = 110;
							num2 = 143;
							IncludeGlobal();
							if ((int)/*Error near IL_0bc5: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 189;
						case 412:
							array2[30] = (byte)num6;
							goto case 69;
						default:
							num = 69;
							goto IL_0be2;
						case 16:
							array2[14] = (byte)num6;
							num3 = 201;
							continue;
						case 312:
							num5 = 101 + 117;
							num = 200;
							goto IL_0be2;
						case 54:
							num6 = 62 + 61;
							num3 = 112;
							continue;
						case 191:
							array2[7] = 204;
							num2 = 314;
							LogoutGlobal();
							if ((int)/*Error near IL_12ef: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 177;
						case 390:
							array2[5] = (byte)num5;
							num = 359;
							goto IL_0be2;
						case 286:
							array2[17] = 124;
							num = 360;
							goto IL_0be2;
						case 309:
							array2[7] = (byte)num6;
							num2 = 337;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 379;
						case 379:
							array[12] = (byte)num8;
							num3 = 87;
							continue;
						case 59:
							array2[7] = 72;
							num3 = 292;
							continue;
						case 296:
							num5 = 113 + 3;
							num3 = 119;
							continue;
						case 8:
							num27 = 0u;
							num = 67;
							goto IL_0be2;
						case 12:
						case 255:
							num6 = 39 + 106;
							num = 165;
							goto IL_0be2;
						case 341:
							num39 = 0;
							num = 52;
							goto IL_0be2;
						case 30:
							array[11] = 147;
							num2 = 276;
							goto IL_0be6;
						case 0:
							array[0] = (byte)num7;
							num = 132;
							goto IL_0be2;
						case 287:
							num7 = 5 + 47;
							num2 = 142;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 108;
						case 108:
							array[5] = (byte)num8;
							num = 130;
							goto IL_0be2;
						case 167:
							num38 = (uint)((array7[num27 + 3] << 24) | (array7[num27 + 2] << 16) | (array7[num27 + 1] << 8) | array7[num27]);
							num2 = 275;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 178;
						case 178:
							num26 = array5.Length % 4;
							num = 125;
							goto IL_0be2;
						case 132:
							array[0] = 185;
							goto case 183;
						case 253:
							num5 = 103 + 27;
							num3 = 235;
							continue;
						case 252:
							array[0] = (byte)num7;
							num3 = 74;
							continue;
						case 334:
							array2[10] = 159;
							num3 = 391;
							continue;
						case 188:
							array2[29] = 85;
							num = 381;
							goto IL_0be2;
						case 58:
							num29++;
							num2 = 189;
							LogoutGlobal();
							if ((int)/*Error near IL_1535: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 356;
						case 356:
							num10 = (uint)((array5[num27 + 3] << 24) | (array5[num27 + 2] << 16) | (array5[num27 + 1] << 8) | array5[num27]);
							num3 = 392;
							continue;
						case 307:
							num6 = 179 - 59;
							num = 412;
							goto IL_0be2;
						case 332:
							array3[9] = array4[4];
							num2 = 211;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 233;
						case 233:
							array2[25] = (byte)num6;
							num2 = 95;
							IncludeGlobal();
							if ((int)/*Error near IL_15bc: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 55;
						case 55:
							array[0] = 114;
							num2 = 24;
							goto IL_0be6;
						case 102:
							array[9] = 102;
							num3 = 246;
							continue;
						case 242:
							array2[2] = (byte)num5;
							num = 413;
							goto IL_0be2;
						case 163:
							array2[27] = (byte)num5;
							num3 = 146;
							continue;
						case 411:
							num6 = 92 + 9;
							num3 = 204;
							continue;
						case 366:
							num7 = 94 + 45;
							num3 = 263;
							continue;
						case 200:
							array2[0] = (byte)num5;
							LogoutGlobal();
							IncludeGlobal();
							if ((int)/*Error near IL_167d: Stack underflow*/ != 0)
							{
								num3 = 183;
								continue;
							}
							num2 = 255;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 179;
						case 179:
							num30 = num11 * 4;
							num2 = 65;
							IncludeGlobal();
							if ((int)/*Error near IL_16a6: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 187;
						case 187:
							array3[15] = array4[7];
							num2 = 266;
							goto IL_0be6;
						case 357:
							array2[26] = (byte)num5;
							num = 217;
							goto IL_0be2;
						case 237:
							num8 = 223 - 74;
							num3 = 78;
							continue;
						case 95:
							array2[25] = 201;
							num2 = 296;
							goto IL_0be6;
						case 247:
							array2[0] = (byte)num5;
							num2 = 312;
							goto IL_0be6;
						case 409:
							array[0] = (byte)num7;
							num = 215;
							goto IL_0be2;
						case 40:
							array2[25] = (byte)num6;
							num = 98;
							goto IL_0be2;
						case 386:
							array2[10] = (byte)num6;
							num3 = 221;
							continue;
						case 311:
							array2[10] = (byte)num5;
							num = 127;
							goto IL_0be2;
						case 177:
							array5 = _MerchantReader;
							num = 178;
							goto IL_0be2;
						case 406:
							num5 = 10 + 59;
							num2 = 72;
							goto IL_0be6;
						case 243:
							num9 += num38;
							num2 = 387;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 137;
						case 137:
							num8 = 32 + 95;
							num = 302;
							goto IL_0be2;
						case 348:
							array2[2] = (byte)num5;
							num2 = 14;
							goto IL_0be6;
						case 343:
							array[2] = 219;
							num3 = 100;
							continue;
						case 88:
							num38 = 0u;
							num = 363;
							goto IL_0be2;
						case 17:
							array2[11] = (byte)num5;
							num2 = 369;
							goto IL_0be6;
						case 400:
							array[10] = 232;
							num2 = 227;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 10;
						case 10:
							num7 = 26 + 119;
							num2 = 267;
							LogoutGlobal();
							if ((int)/*Error near IL_1894: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 151;
						case 128:
							array[11] = (byte)num7;
							num2 = 197;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 245;
						case 245:
							CheckGlobal(cryptoStream);
							num = 300;
							goto IL_0be2;
						case 113:
							array2[12] = 94;
							num2 = 92;
							goto IL_0be6;
						case 262:
							array2[3] = 88;
							num2 = 150;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 134;
						case 134:
							array2[24] = (byte)num6;
							num3 = 397;
							continue;
						case 290:
							array2[22] = (byte)num5;
							num3 = 396;
							continue;
						case 74:
							num7 = 241 - 80;
							num = 0;
							goto IL_0be2;
						case 182:
							array2[16] = (byte)num5;
							num2 = 270;
							IncludeGlobal();
							if ((int)/*Error near IL_1978: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 14;
						case 228:
							num6 = 113 + 58;
							num3 = 319;
							continue;
						case 244:
							num6 = 94 + 73;
							num2 = 149;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 305;
						case 305:
							array[5] = (byte)num8;
							num3 = 162;
							continue;
						case 207:
							num5 = 245 - 81;
							num2 = 182;
							IncludeGlobal();
							if ((int)/*Error near IL_19ee: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 249;
						case 115:
							array[7] = (byte)num7;
							num2 = 256;
							goto IL_0be6;
						case 76:
							num35 = array7.Length / 4;
							num = 297;
							goto IL_0be2;
						case 337:
							num6 = 156 + 46;
							num2 = 181;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 126;
						case 126:
							array2[4] = (byte)num5;
							num2 = 26;
							IncludeGlobal();
							if ((int)/*Error near IL_1a60: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 72;
						case 263:
							array[5] = (byte)num7;
							num3 = 236;
							continue;
						case 352:
							array6[num30 + 1] = (byte)((num36 & 0xFF00) >> 8);
							num2 = 68;
							goto IL_0be6;
						case 79:
						{
							SetGlobal(binaryReader);
							RateGlobal((object)/*Error near IL_37c4: Stack underflow*/);
							int num37 = (int)/*Error near IL_1aac: Stack underflow*/;
							ForgotGlobal((object)/*Error near IL_37ce: Stack underflow*/, num37);
							array5 = (byte[])/*Error near IL_1ab3: Stack underflow*/;
							num2 = 186;
							goto IL_0be6;
						}
						case 68:
							array6[num30 + 2] = (byte)((num36 & 0xFF0000) >> 16);
							num = 264;
							goto IL_0be2;
						case 258:
							num5 = 82 + 124;
							num3 = 216;
							continue;
						case 119:
							array2[26] = (byte)num5;
							num2 = 170;
							LogoutGlobal();
							if ((int)/*Error near IL_1b18: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 142;
						case 142:
							array[2] = (byte)num7;
							num3 = 42;
							continue;
						case 145:
							array2[3] = 204;
							num2 = 195;
							goto IL_0be6;
						case 354:
							array7 = array2;
							num3 = 395;
							continue;
						case 227:
							array[10] = 130;
							num3 = 96;
							continue;
						case 82:
							num7 = 163 - 54;
							num3 = 403;
							continue;
						case 414:
							array3[1] = array4[0];
							num2 = 118;
							LogoutGlobal();
							if ((int)/*Error near IL_1bb6: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 397;
						case 397:
							array2[25] = 48;
							num2 = 310;
							goto IL_0be6;
						case 275:
							num33 = 255u;
							num2 = 341;
							LogoutGlobal();
							if ((int)/*Error near IL_1bf3: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 112;
						case 302:
							array[2] = (byte)num8;
							num2 = 343;
							LogoutGlobal();
							if ((int)/*Error near IL_1c19: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 27;
						case 106:
							array2[2] = (byte)num5;
							num2 = 293;
							goto IL_0be6;
						case 81:
							num5 = 103 + 83;
							num3 = 126;
							continue;
						case 64:
							num9 = num12;
							num = 289;
							goto IL_0be2;
						case 168:
							array[4] = 141;
							num3 = 140;
							continue;
						case 1:
							array[14] = 123;
							num2 = 123;
							IncludeGlobal();
							if ((int)/*Error near IL_1ca8: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 366;
						case 222:
							array2[22] = 123;
							num2 = 5;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 57;
						case 57:
							array[4] = 168;
							num3 = 322;
							continue;
						case 198:
							new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
							cryptoStream = (CryptoStream)/*Error near IL_1cfc: Stack underflow*/;
							num = 291;
							goto IL_0be2;
						case 264:
							array6[num30 + 3] = (byte)((uint)((int)num36 & -16777216) >> 24);
							num3 = 317;
							continue;
						case 282:
							array2[13] = 123;
							num2 = 37;
							goto IL_0be6;
						case 303:
							array2[21] = 193;
							num3 = 393;
							continue;
						case 105:
							array[13] = 157;
							num = 160;
							goto IL_0be2;
						case 114:
							array2[9] = 128;
							num = 274;
							goto IL_0be2;
						case 127:
							num5 = 175 - 67;
							num3 = 34;
							continue;
						case 61:
							array[11] = (byte)num8;
							num2 = 51;
							goto IL_0be6;
						case 112:
							array2[5] = (byte)num6;
							num3 = 139;
							continue;
						case 121:
							num7 = 50 + 86;
							num3 = 35;
							continue;
						case 394:
							array2[16] = (byte)num5;
							num2 = 286;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 402;
						case 402:
							num8 = 183 - 61;
							num2 = 379;
							IncludeGlobal();
							if ((int)/*Error near IL_1e48: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 238;
						case 395:
							array = new byte[16];
							num = 55;
							goto IL_0be2;
						case 192:
							num5 = 80 + 69;
							num2 = 60;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 362;
						case 362:
							VerifyGlobal(_MerchantReader, task_Low);
							num4 = (int)/*Error near IL_1e90: Stack underflow*/;
							num2 = 416;
							goto IL_0be6;
						case 324:
							array2[22] = (byte)num5;
							num = 222;
							goto IL_0be2;
						case 107:
							GetGlobal(array3);
							num2 = 295;
							goto IL_0be6;
						case 116:
						case 317:
							num11++;
							num3 = 368;
							continue;
						case 319:
							array2[11] = (byte)num6;
							num2 = 231;
							goto IL_0be6;
						case 47:
						case 392:
							num12 = num9;
							num3 = 361;
							continue;
						case 250:
							array2[28] = 94;
							num2 = 44;
							LogoutGlobal();
							if ((int)/*Error near IL_1f43: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 221;
						case 75:
							num31++;
							num = 265;
							goto IL_0be2;
						case 313:
							num6 = 133 - 44;
							num2 = 36;
							IncludeGlobal();
							if ((int)/*Error near IL_1f7a: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 291;
						case 291:
							AddGlobal(cryptoStream, array5, 0, array5.Length);
							num2 = 245;
							IncludeGlobal();
							if ((int)/*Error near IL_1f9b: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 337;
						case 148:
							num6 = 132 + 103;
							num2 = 203;
							IncludeGlobal();
							if ((int)/*Error near IL_1fc2: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 222;
						case 84:
							array2[28] = (byte)num5;
							num = 109;
							goto IL_0be2;
						case 52:
							goto IL_1fdf;
						case 257:
							if (num26 > 0)
							{
								num2 = 48;
								if (0 == 0)
								{
									goto IL_0be6;
								}
								goto case 238;
							}
							goto IL_3321;
						case 238:
							num5 = 215 - 71;
							num2 = 153;
							LogoutGlobal();
							if ((int)/*Error near IL_202d: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 331;
						case 153:
							array2[23] = (byte)num5;
							num2 = 152;
							goto IL_0be6;
						case 194:
							array2[11] = 101;
							num2 = 22;
							IncludeGlobal();
							if ((int)/*Error near IL_2076: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 365;
						case 71:
							num7 = 242 - 80;
							num = 66;
							goto IL_0be2;
						case 158:
							num5 = 61 + 7;
							num3 = 117;
							continue;
						case 298:
							array2 = new byte[32];
							num2 = 39;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 326;
						case 326:
							array2[28] = 28;
							num2 = 250;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 292;
						case 292:
							num6 = 102 + 115;
							num2 = 309;
							goto IL_0be6;
						case 375:
							if (array4.Length > 0)
							{
								num3 = 414;
								continue;
							}
							goto case 266;
						case 339:
							num8 = 80 + 48;
							num = 108;
							goto IL_0be2;
						case 279:
							array2[18] = (byte)num5;
							num = 294;
							goto IL_0be2;
						case 183:
						case 229:
							num8 = 149 - 49;
							num3 = 344;
							continue;
						case 322:
							array[4] = 66;
							num2 = 223;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 6;
						case 6:
							array2[18] = 92;
							num2 = 405;
							goto IL_0be6;
						case 87:
							array[12] = 128;
							num2 = 10;
							goto IL_0be6;
						case 376:
							num5 = 104 + 100;
							num3 = 89;
							continue;
						case 201:
							array2[15] = 87;
							num = 244;
							goto IL_0be2;
						case 230:
							num6 = 56 + 74;
							num3 = 335;
							continue;
						case 165:
							array2[0] = (byte)num6;
							num3 = 271;
							continue;
						case 197:
							array[11] = 102;
							num2 = 340;
							LogoutGlobal();
							if ((int)/*Error near IL_2283: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 398;
						case 270:
							num5 = 194 - 64;
							num2 = 56;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 50;
						case 50:
							array2[8] = (byte)num6;
							num = 31;
							goto IL_0be2;
						case 225:
							array2[12] = 129;
							num3 = 113;
							continue;
						case 136:
							array[14] = 87;
							num3 = 1;
							continue;
						case 345:
							num5 = 151 + 26;
							num3 = 306;
							continue;
						case 344:
							array[1] = (byte)num8;
							num2 = 350;
							IncludeGlobal();
							if ((int)/*Error near IL_2336: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 283;
						case 283:
							array[7] = (byte)num7;
							num2 = 21;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 381;
						case 381:
							num6 = 232 - 77;
							num2 = 23;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 159;
						case 159:
							array2[6] = 179;
							num3 = 191;
							continue;
						case 49:
						case 86:
							if (num34 >= num26)
							{
								num = 116;
								goto IL_0be2;
							}
							if (num34 <= 0)
							{
								goto case 164;
							}
							num2 = 133;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 340;
						case 346:
							if (_MerchantReader.Length == 0)
							{
								num3 = 32;
								continue;
							}
							goto case 362;
						case 259:
							array2[8] = 7;
							num2 = 196;
							goto IL_0be6;
						case 35:
							array[1] = (byte)num7;
							num = 205;
							goto IL_0be2;
						case 342:
							array2[23] = (byte)num6;
							num3 = 238;
							continue;
						case 28:
							num7 = 235 - 78;
							num = 252;
							goto IL_0be2;
						case 122:
							num6 = 93 + 82;
							num = 33;
							goto IL_0be2;
						case 401:
							WriteGlobal(memoryStream);
							num2 = 358;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 209;
						case 209:
							array[1] = 87;
							num = 121;
							goto IL_0be2;
						case 214:
							array2[9] = (byte)num5;
							num3 = 273;
							continue;
						case 156:
							array2[6] = (byte)num6;
							num = 389;
							goto IL_0be2;
						case 146:
							num5 = 207 - 69;
							num2 = 370;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 365;
						case 365:
							num5 = 71 + 55;
							num2 = 357;
							goto IL_0be6;
						case 314:
							array2[7] = 84;
							num3 = 59;
							continue;
						case 13:
							num7 = 90 + 113;
							num3 = 128;
							continue;
						case 349:
							array[5] = (byte)num8;
							num = 339;
							goto IL_0be2;
						case 304:
						case 368:
							if (num11 < num32)
							{
								num28 = num11 % num35;
								num2 = 179;
								IncludeGlobal();
								if ((int)/*Error near IL_21f2: Stack underflow*/ == 0)
								{
									goto IL_0be6;
								}
								goto case 376;
							}
							num2 = 53;
							goto IL_0be6;
						case 359:
							array2[6] = 105;
							num = 63;
							goto IL_0be2;
						case 210:
							num5 = 191 - 63;
							num2 = 206;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 383;
						case 383:
							array[8] = (byte)num8;
							num = 102;
							goto IL_0be2;
						case 91:
							array2[9] = 165;
							num3 = 77;
							continue;
						case 364:
							num6 = 0 + 59;
							num2 = 147;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 94;
						case 94:
							num5 = 211 - 70;
							num2 = 407;
							goto IL_0be6;
						case 269:
							num6 = 189 - 63;
							num3 = 131;
							continue;
						case 281:
							array2[1] = 102;
							num = 193;
							goto IL_0be2;
						case 316:
							array2[20] = 115;
							num2 = 70;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 336;
						case 336:
							num34++;
							num2 = 49;
							IncludeGlobal();
							if ((int)/*Error near IL_2669: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 389;
						case 389:
							num5 = 87 + 80;
							num2 = 328;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 72;
						case 72:
							array2[13] = (byte)num5;
							num = 282;
							goto IL_0be2;
						case 384:
							num6 = 177 - 59;
							num2 = 377;
							goto IL_0be6;
						case 111:
							array2[16] = 192;
							num2 = 207;
							IncludeGlobal();
							if ((int)/*Error near IL_26e4: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 141;
						case 141:
							array[15] = 122;
							num3 = 254;
							continue;
						case 260:
							num5 = 245 - 81;
							num = 279;
							goto IL_0be2;
						case 211:
							array3[11] = array4[5];
							num = 378;
							goto IL_0be2;
						case 18:
							array3 = array;
							num = 107;
							goto IL_0be2;
						case 360:
							array2[17] = 100;
							num2 = 277;
							goto IL_0be6;
						case 333:
							array2[15] = 64;
							num = 313;
							goto IL_0be2;
						case 268:
							num6 = 238 - 79;
							num2 = 169;
							goto IL_0be6;
						case 327:
							num8 = 219 - 73;
							num = 284;
							goto IL_0be2;
						case 130:
							array[5] = 56;
							num2 = 237;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 196;
						case 196:
							array2[9] = 127;
							num3 = 192;
							continue;
						case 133:
							num33 <<= 8;
							num2 = 371;
							IncludeGlobal();
							if ((int)/*Error near IL_2829: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 303;
						case 373:
							array2[0] = (byte)num6;
							num3 = 120;
							continue;
						case 265:
						case 278:
							if (num31 >= array3.Length)
							{
								num2 = 144;
								goto IL_0be6;
							}
							array7[num31] = (byte)(array7[num31] ^ array3[num31]);
							num2 = 75;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 144;
						case 24:
							num7 = 40 + 101;
							num2 = 409;
							goto IL_0be6;
						case 280:
							array[15] = (byte)num8;
							num2 = 331;
							goto IL_0be6;
						case 249:
							array2[1] = 137;
							num3 = 218;
							continue;
						case 331:
							num8 = 159 - 53;
							num3 = 43;
							continue;
						case 62:
							array2[13] = 144;
							num2 = 406;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 380;
						case 101:
							array2[6] = (byte)num6;
							num = 94;
							goto IL_0be2;
						case 5:
							num5 = 114 + 109;
							num3 = 226;
							continue;
						case 273:
							array2[10] = 90;
							num3 = 334;
							continue;
						case 25:
							num5 = 69 + 5;
							num2 = 290;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 347;
						case 347:
							array[7] = (byte)num7;
							num3 = 327;
							continue;
						case 367:
							num5 = 138 - 106;
							num3 = 80;
							continue;
						case 410:
							num8 = 48 + 46;
							num2 = 320;
							LogoutGlobal();
							if ((int)/*Error near IL_29c6: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 265;
						case 144:
							if (task_Low != -1)
							{
								goto case 178;
							}
							num2 = 46;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 170;
						case 170:
							array2[26] = 154;
							num2 = 213;
							goto IL_0be6;
						case 195:
							num5 = 95 + 4;
							num3 = 199;
							continue;
						case 78:
							array[6] = (byte)num8;
							num2 = 315;
							goto IL_0be6;
						case 205:
							array[1] = 64;
							num3 = 208;
							continue;
						case 206:
							array2[24] = (byte)num5;
							num2 = 220;
							goto IL_0be6;
						case 38:
							num27 = (uint)num30;
							num3 = 356;
							continue;
						case 77:
							array2[9] = 146;
							num2 = 114;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 202;
						case 202:
							num8 = 103 - 98;
							num2 = 383;
							IncludeGlobal();
							if ((int)/*Error near IL_2ae8: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 162;
						case 162:
							num8 = 116 + 12;
							num2 = 349;
							goto IL_0be6;
						case 21:
							num7 = 105 - 80;
							num3 = 115;
							continue;
						case 407:
							array2[6] = (byte)num5;
							num2 = 175;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 166;
						case 166:
							array3[5] = array4[2];
							num2 = 97;
							IncludeGlobal();
							if ((int)/*Error near IL_2b56: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 369;
						case 369:
							array2[12] = 142;
							num = 225;
							goto IL_0be2;
						case 149:
							array2[15] = (byte)num6;
							num = 158;
							goto IL_0be2;
						case 274:
							num5 = 211 - 101;
							num = 214;
							goto IL_0be2;
						case 19:
							num10 |= array5[array5.Length - (1 + num29)];
							num3 = 58;
							continue;
						case 41:
							array2[31] = 205;
							num2 = 364;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 276;
						case 276:
							num8 = 140 + 84;
							num2 = 61;
							goto IL_0be6;
						case 315:
							num8 = 1 + 102;
							num = 382;
							goto IL_0be2;
						case 216:
							array2[29] = (byte)num5;
							num3 = 188;
							continue;
						case 135:
							array2[12] = 145;
							num2 = 148;
							IncludeGlobal();
							if ((int)/*Error near IL_2c5b: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 222;
						case 221:
							num5 = 120 + 112;
							num3 = 311;
							continue;
						case 398:
							num7 = 211 - 105;
							num = 124;
							goto IL_0be2;
						case 190:
							array6 = new byte[array5.Length];
							num2 = 76;
							LogoutGlobal();
							if ((int)/*Error near IL_2cb0: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 38;
						case 43:
							array[15] = (byte)num8;
							num2 = 308;
							LogoutGlobal();
							if ((int)/*Error near IL_2cd6: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 313;
						case 231:
							array2[11] = 185;
							num2 = 184;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 387;
						case 387:
							num29 = 0;
							num2 = 372;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 100;
						case 100:
							array[3] = 142;
							num3 = 83;
							continue;
						case 3:
							num6 = 220 - 73;
							num = 151;
							goto IL_0be2;
						case 351:
							array2[20] = 185;
							num2 = 316;
							LogoutGlobal();
							if ((int)/*Error near IL_2d71: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 133;
						case 241:
							CountGlobal(symmetricAlgorithm, CipherMode.CBC);
							num3 = 234;
							continue;
						case 413:
							num5 = 253 - 84;
							num2 = 106;
							goto IL_0be6;
						case 98:
							num6 = 111 + 99;
							num3 = 233;
							continue;
						case 215:
							array[0] = 167;
							num = 28;
							goto IL_0be2;
						case 340:
							array[11] = 131;
							num = 30;
							goto IL_0be2;
						case 353:
							array2[31] = 180;
							num3 = 354;
							continue;
						case 131:
							array2[15] = (byte)num6;
							num2 = 333;
							goto IL_0be6;
						case 65:
							num27 = (uint)(num28 * 4);
							num2 = 167;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 330;
						case 330:
							num7 = 65 + 102;
							num = 347;
							goto IL_0be2;
						case 184:
							num5 = 127 + 92;
							num2 = 17;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 36;
						case 36:
							array2[16] = (byte)num6;
							num2 = 411;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 235;
						case 235:
							array2[18] = (byte)num5;
							num2 = 260;
							goto IL_0be6;
						case 104:
							array[1] = 84;
							num2 = 209;
							LogoutGlobal();
							if ((int)/*Error near IL_2f00: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 185;
						case 185:
							array2[4] = (byte)num6;
							num3 = 240;
							continue;
						case 212:
						{
							uint num13 = num12;
							uint num14 = num12;
							uint num15 = 2076340001u;
							uint num16 = 94881374u;
							uint num17 = 1894166880u;
							uint num18 = num14;
							uint num19 = 1749243518u;
							uint num20 = 770293477u;
							uint num21 = ((num17 << 4) | (num17 >> 28)) + num19;
							uint num22 = num21 & 0x55555555;
							num21 = (uint)((int)num21 & -1431655766);
							num17 = ((num21 >> 1) | (num22 << 1));
							if ((double)num15 == 0.0)
							{
								num15--;
							}
							uint num23 = (uint)((double)(int)(ushort)num19 / (double)num15 + (double)num15);
							if (num23 == 0)
							{
								num23--;
							}
							if ((double)num19 == 0.0)
							{
								num19--;
							}
							num15 = (uint)((double)((uint)(1777979060.0 / (double)num19) / num23) + 1777979060.0);
							num16 += num17;
							if ((double)num19 == 0.0)
							{
								num19--;
							}
							uint num24 = (uint)(47508.0 / (double)num19 + (double)num19);
							num19 = ((1170549024 + num17) ^ num24) + 1170549024;
							if ((double)num20 == 0.0)
							{
								num20--;
							}
							uint num25 = (uint)(1207199045.0 / (double)num20 + (double)num20);
							num20 = (uint)((uint)(-18540 - (short)num17 - (int)num25) + -18540);
							num18 ^= num18 << 11;
							num18 += num16;
							num18 ^= num18 << 12;
							num18 += num19;
							num18 ^= num18 >> 7;
							num18 += num20;
							num18 = (((num16 << 20) - num15) ^ num19) - num18;
							num12 = num13 + (uint)(double)num18;
							num = 64;
							goto IL_0be2;
						}
						case 85:
							array[4] = (byte)num8;
							num3 = 366;
							continue;
						case 323:
							if (array4 != null)
							{
								num = 375;
								goto IL_0be2;
							}
							goto case 266;
						case 285:
							array2[31] = 138;
							num2 = 41;
							goto IL_0be6;
						case 51:
							array[12] = 129;
							num = 410;
							goto IL_0be2;
						case 67:
							num11 = 0;
							num2 = 304;
							IncludeGlobal();
							if ((int)/*Error near IL_31dc: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 361;
						case 361:
							num9 = 0u;
							num = 212;
							goto IL_0be2;
						case 301:
							array2[30] = 149;
							num3 = 307;
							continue;
						case 404:
							array2[24] = 67;
							num3 = 210;
							continue;
						case 219:
							array2[29] = (byte)num6;
							num = 258;
							goto IL_0be2;
						case 181:
							array2[7] = (byte)num6;
							num3 = 248;
							continue;
						case 175:
							num6 = 246 - 82;
							num2 = 156;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 261;
						case 261:
							array2[11] = (byte)num5;
							num2 = 228;
							IncludeGlobal();
							if ((int)/*Error near IL_3296: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 161;
						case 335:
							array2[23] = (byte)num6;
							num3 = 404;
							continue;
						case 363:
							num10 = 0u;
							num2 = 251;
							goto IL_0be6;
						case 203:
							array2[12] = (byte)num6;
							num = 62;
							goto IL_0be2;
						case 396:
							num5 = 60 + 105;
							num2 = 324;
							goto IL_0be6;
						case 29:
							array[10] = 181;
							num2 = 400;
							goto IL_0be6;
						case 180:
							array2[0] = (byte)num5;
							num3 = 249;
							continue;
						case 226:
							array2[22] = (byte)num5;
							num3 = 45;
							continue;
						case 377:
							array2[20] = (byte)num6;
							num = 351;
							goto IL_0be2;
						case 248:
							num6 = 127 - 42;
							num = 50;
							goto IL_0be2;
						case 266:
							num31 = 0;
							num = 278;
							goto IL_0be2;
						case 97:
							array3[7] = array4[3];
							num = 332;
							goto IL_0be2;
						case 103:
							array2[21] = (byte)num6;
							num = 25;
							goto IL_0be2;
						case 23:
							array2[29] = (byte)num6;
							num3 = 4;
							continue;
						case 73:
							num7 = 67 + 82;
							num2 = 374;
							goto IL_0be6;
						case 254:
							num8 = 223 - 74;
							num2 = 280;
							IncludeGlobal();
							if ((int)/*Error near IL_342f: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 249;
						case 80:
							array2[27] = (byte)num5;
							num2 = 326;
							goto IL_0be6;
						case 297:
							num9 = 0u;
							num3 = 88;
							continue;
						case 308:
							array[15] = 6;
							num3 = 18;
							continue;
						case 329:
							num8 = 103 + 117;
							num = 299;
							goto IL_0be2;
						case 405:
							array2[18] = 173;
							num2 = 176;
							goto IL_0be6;
						case 157:
							array[10] = 164;
							num2 = 13;
							goto IL_0be6;
						case 63:
							num6 = 45 + 87;
							num2 = 101;
							IncludeGlobal();
							if ((int)/*Error near IL_34fd: Stack underflow*/ == 0)
							{
								goto IL_0be6;
							}
							goto case 376;
						case 403:
							array[13] = (byte)num7;
							num3 = 105;
							continue;
						case 11:
							array2[13] = (byte)num6;
							num2 = 3;
							if (0 == 0)
							{
								goto IL_0be6;
							}
							goto case 374;
						case 374:
							array[2] = (byte)num7;
							num3 = 287;
							continue;
						case 15:
							array2[19] = 121;
							num2 = 388;
							goto IL_0be6;
						case 120:
							num5 = 157 - 52;
							num3 = 247;
							continue;
						case 152:
							array2[23] = 158;
							num2 = 230;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 338;
						case 338:
							num6 = 122 + 91;
							num3 = 342;
							continue;
						case 293:
							array2[2] = 125;
							num = 122;
							goto IL_0be2;
						case 22:
							num5 = 145 - 48;
							num2 = 261;
							goto IL_0be6;
						case 42:
							array[2] = 179;
							num2 = 137;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 416;
						case 416:
							try
							{
								VisitGlobal();
								byte[] merchantReader = _MerchantReader;
								DestroyGlobal((object)/*Error near IL_3650: Stack underflow*/, merchantReader, task_Low + 4, num4);
								return (string)/*Error near IL_365f: Stack underflow*/;
							}
							catch
							{
							}
							return "";
						case 46:
							LoginGlobal();
							symmetricAlgorithm = (SymmetricAlgorithm)/*Error near IL_1ee2: Stack underflow*/;
							num2 = 241;
							if (true)
							{
								goto IL_0be6;
							}
							goto case 319;
						case 380:
							{
								new MemoryStream();
								memoryStream = (MemoryStream)/*Error near IL_28fb: Stack underflow*/;
								num = 198;
								goto IL_0be2;
							}
							IL_3321:
							num36 = (num9 ^ num10);
							num2 = 2;
							LogoutGlobal();
							if ((int)/*Error near IL_333b: Stack underflow*/ != 0)
							{
								goto IL_0be6;
							}
							goto case 402;
						}
						array[3] = (byte)num7;
						num = 161;
						break;
						IL_1fdf:
						if (num11 == num32 - 1)
						{
							num = 9;
							break;
						}
						goto IL_2767;
						IL_0054:
						array2[2] = (byte)num6;
						num = 262;
						break;
						IL_09f4:
						if (num26 > 0)
						{
							num2 = 172;
							goto IL_0be6;
						}
						goto IL_2767;
						IL_006c:
						array2[19] = 223;
						num = 384;
						break;
						IL_2767:
						num9 += num38;
						num3 = 38;
						continue;
						IL_00c6:
						array[4] = 100;
						num = 57;
						break;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
		internal static string PatchTests(string item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(item);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int FindTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return 5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ValidateTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Delegate OrderTests(IntPtr asset, Type b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[2]
			{
				asset,
				b
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ResolveTests(object last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (File.Exists(((Assembly)last).Location))
				{
					return ((Assembly)last).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)last).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)last).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(last.GetType().GetProperty("Location").GetValue(last, new object[0])
					.ToString()))
				{
					return last.GetType().GetProperty("Location").GetValue(last, new object[0])
						.ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
		private static byte[] FillTests(string value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (FileStream fileStream = new FileStream(value, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				long length = fileStream.Length;
				int num2 = (int)length;
				byte[] array = new byte[num2];
				while (num2 > 0)
				{
					int num3 = fileStream.Read(array, num, num2);
					num += num3;
					num2 -= num3;
				}
				return array;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ProductEventEntry(typeof(ExceptionFilterResolver<object>[]))]
		private static byte[] RunTests(byte[] info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = WriteIterator();
			symmetricAlgorithm.Key = new byte[32]
			{
				28,
				7,
				88,
				136,
				232,
				83,
				252,
				221,
				115,
				42,
				236,
				139,
				156,
				151,
				53,
				51,
				60,
				205,
				165,
				61,
				13,
				8,
				79,
				160,
				233,
				94,
				129,
				91,
				204,
				121,
				86,
				162
			};
			symmetricAlgorithm.IV = new byte[16]
			{
				67,
				94,
				12,
				133,
				10,
				227,
				132,
				70,
				165,
				66,
				143,
				184,
				163,
				184,
				222,
				225
			};
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(info, 0, info.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] CompareTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] AddTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] EnableTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-20001-00001}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] MapTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-20001-00002}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] InsertTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-30001-00001}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] FlushTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-30001-00002}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] CreateTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-40001-00001}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] StopTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-40001-00002}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] CloneTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-50001-00001}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] LogoutTests()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = "{11111-22222-50001-00002}";
			if (text.Length > 0)
			{
				return new byte[2]
				{
					1,
					2
				};
			}
			return new byte[2]
			{
				1,
				2
			};
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InfoClientBridge()
		{
		}//Discarded unreachable code: IL_0002, IL_0006
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0007: Incompatible stack heights: 0 vs 1


		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ConnectGlobal(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SetGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((BinaryReader)P_0).BaseStream;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CollectGlobal(object P_0, long P_1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((Stream)P_0).Position = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static long RateGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((Stream)P_0).Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ForgotGlobal(object P_0, int P_1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((BinaryReader)P_0).ReadBytes(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ChangeGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((BinaryReader)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void GetGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Array.Reverse((Array)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object SearchGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((Assembly)P_0).GetName();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object UpdateGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object LoginGlobal()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return WriteIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CountGlobal(object P_0, CipherMode P_1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((SymmetricAlgorithm)P_0).Mode = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object ResetGlobal(object P_0, object P_1, object P_2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AddGlobal(object P_0, object P_1, int P_2, int P_3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CheckGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((CryptoStream)P_0).FlushFinalBlock();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object RestartGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((MemoryStream)P_0).ToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WriteGlobal(object P_0)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			((Stream)P_0).Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int VerifyGlobal(object P_0, int P_1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return BitConverter.ToInt32((byte[])P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object VisitGlobal()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Encoding.Unicode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object DestroyGlobal(object P_0, object P_1, int P_2, int P_3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool LogoutGlobal()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IncludeGlobal()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return false;
		}
	}
}
