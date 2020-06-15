using GDBD.Workers;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Resolver
{
	internal sealed class HelperFilterResolver
	{
		private static Assembly m_MapperReader;

		private static string[] _PredicateReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void InstantiateIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0024: Incompatible stack heights: 0 vs 1
			try
			{
				_ = AppDomain.CurrentDomain;
				ResolveEventHandler value = ReflectIterator;
				((AppDomain)/*Error near IL_002e: Stack underflow*/).ResourceResolve += value;
			}
			catch (Exception)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static Assembly ReflectIterator(object setup, ResolveEventArgs col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0055: Incompatible stack heights: 0 vs 1
			//IL_005f: Incompatible stack heights: 0 vs 1
			//IL_00e7: Incompatible stack heights: 0 vs 1
			//IL_00f7: Incompatible stack heights: 0 vs 1
			//IL_0101: Incompatible stack heights: 0 vs 1
			do
			{
				if ((object)m_MapperReader == null)
				{
					string[] predicateReader = _PredicateReader;
					Monitor.Enter((object)/*Error near IL_00f1: Stack underflow*/);
					try
					{
						Assembly.Load("{dba08d88-923f-4d55-bce8-3fab2740e8c7}, PublicKeyToken=3e56350693f7355e");
						m_MapperReader = (Assembly)/*Error near IL_0032: Stack underflow*/;
						if ((object)m_MapperReader != null)
						{
							m_MapperReader.GetManifestResourceNames();
							_PredicateReader = (string[])/*Error near IL_004b: Stack underflow*/;
						}
					}
					finally
					{
						Monitor.Exit(predicateReader);
					}
				}
				_ = ((ResolveEventArgs)/*Error near IL_0101: Stack underflow*/).Name;
				string b = (string)/*Error near IL_0107: Stack underflow*/;
				int num = 0;
				while (true)
				{
					int num2 = num;
					IntPtr intPtr;
					if (true)
					{
						intPtr = (IntPtr)(void*)_PredicateReader.LongLength;
						while (8u != 0 || 1 == 0)
						{
							intPtr = (IntPtr)(int)(long)intPtr;
							if (false)
							{
								continue;
							}
							goto IL_00d3;
						}
						goto IL_00b1;
					}
					goto IL_0092;
					IL_00b1:
					num = num2 + 1;
					continue;
					IL_0092:
					if (0 == 0)
					{
						if (num2 != 0)
						{
							if (!ResetIterator())
							{
								return null;
							}
							return m_MapperReader;
						}
						num2 = num;
					}
					intPtr = (IntPtr)1;
					goto IL_00b1;
					IL_00d3:
					if ((long)num2 >= (long)intPtr)
					{
						break;
					}
					num2 = ((_PredicateReader[num] == b) ? 1 : 0);
					goto IL_0092;
				}
			}
			while (5 == 0);
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe static bool ResetIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_008a: Incompatible stack heights: 0 vs 1
			//IL_0094: Incompatible stack heights: 0 vs 1
			//IL_00a0: Incompatible stack heights: 0 vs 1
			//IL_00a6: Incompatible stack heights: 0 vs 1
			//IL_00ac: Incompatible stack heights: 0 vs 1
			//IL_00b6: Incompatible stack heights: 0 vs 1
			//IL_00c0: Incompatible stack heights: 0 vs 1
			int num;
			while (true)
			{
				if (true)
				{
					num = 5;
					goto IL_000b;
				}
				goto IL_00d0;
				IL_000b:
				byte* intPtr = stackalloc byte[num];
				void* ptr;
				if (7u != 0)
				{
					ptr = intPtr;
				}
				try
				{
					new StackTrace();
					((StackTrace)/*Error near IL_0094: Stack underflow*/).GetFrames();
					StackFrame[] array = (StackFrame[])/*Error near IL_009a: Stack underflow*/;
					do
					{
						*(int*)(long)(IntPtr)(void*)/*Error near IL_002b: Stack underflow*/ = 2;
					}
					while (1 == 0);
					if (0 == 0)
					{
						while (true)
						{
							if (*(int*)ptr >= array.Length)
							{
								((byte*)ptr)[4] = 0;
								break;
							}
							int num2 = *(int*)(long)(IntPtr)(void*)/*Error near IL_0047: Stack underflow*/;
							((StackFrame)((object[])/*Error near IL_0048: Stack underflow*/)[num2]).GetMethod();
							_ = ((MemberInfo)/*Error near IL_00c0: Stack underflow*/).Module;
							if ((object)((Module)/*Error near IL_0057: Stack underflow*/).Assembly == Assembly.GetExecutingAssembly())
							{
								((byte*)ptr)[4] = 1;
								break;
							}
							(*(int*)ptr)++;
						}
					}
				}
				catch
				{
					((byte*)ptr)[4] = 1;
				}
				goto IL_00d0;
				IL_00d0:
				if (false)
				{
					continue;
				}
				num = ((byte*)ptr)[4];
				if (8u != 0 && 4u != 0)
				{
					break;
				}
				goto IL_000b;
			}
			return (byte)num != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HelperFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HelperFilterResolver()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_MapperReader = null;
			_PredicateReader = new string[0];
		}
	}
}
