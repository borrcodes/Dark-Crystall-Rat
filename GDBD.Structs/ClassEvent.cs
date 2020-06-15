using GDBD.Workers;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace GDBD.Structs
{
	internal sealed class ClassEvent
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class ServiceConfigurationException
		{
			public static readonly ServiceConfigurationException _ValueComposer;

			public static Func<byte, string> _StrategyComposer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ServiceConfigurationException()
			{
				//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				//IL_0013: Incompatible stack heights: 0 vs 1
				//IL_001a: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_ValueComposer = new ServiceConfigurationException();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ServiceConfigurationException()
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
			internal string _0001(byte _0002)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _0002.ToString("x2");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ResetFilter(string task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (MD5 mD = MD5.Create())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(task);
				byte[] array = mD.ComputeHash(bytes);
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				return stringBuilder.ToString();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RegisterFilter(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] source = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(res));
			return string.Join("", source.Select((byte _0002) => _0002.ToString("x2")).ToArray());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string RestartFilter(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(var1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string SearchFilter(string last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return Encoding.UTF8.GetString(Convert.FromBase64String(last));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ComputeFilter(string param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return SearchFilter(Strings.StrReverse(param));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassEvent()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
