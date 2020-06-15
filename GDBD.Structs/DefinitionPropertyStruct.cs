using GDBD.Maps;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDBD.Structs
{
	internal sealed class DefinitionPropertyStruct
	{
		private static readonly Encoding m_AlgoIssuer;

		private readonly BinaryWriter annotationIssuer;

		private byte[] m_ExporterIssuer;

		[CompilerGenerated]
		private DateTimeKind visitorIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public DateTimeKind _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return visitorIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CompareIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			annotationIssuer.Close();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddIterator(SystemPropertyStruct instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			StopIterator(instance);
			EnableIterator(instance);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnableIterator(SystemPropertyStruct asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (asset._0001())
			{
			case (ChildRunStatus)6:
			case (ChildRunStatus)10:
				break;
			case (ChildRunStatus)3:
			{
				TemplateIssuer templateIssuer = (TemplateIssuer)asset;
				annotationIssuer.Write(((SystemPropertyStruct)templateIssuer)._0001());
				using (IEnumerator<PageFilterResolver> enumerator2 = templateIssuer._0001())
				{
					while (enumerator2.MoveNext())
					{
						PageFilterResolver current2 = enumerator2.Current;
						annotationIssuer.Write((sbyte)current2._0001()._0001());
						MapIterator((string)((ValueRequestStrategy)current2._0001())._0001(), current2._0001()._0002(), null);
						EnableIterator(current2._0001());
					}
				}
				annotationIssuer.Write((byte)0);
				break;
			}
			case (ChildRunStatus)4:
			{
				InitializerComposerWorker initializerComposerWorker = (InitializerComposerWorker)asset;
				annotationIssuer.Write(((SystemPropertyStruct)initializerComposerWorker)._0001());
				ulong num2 = 0uL;
				using (IEnumerator<SystemPropertyStruct> enumerator = initializerComposerWorker._0001())
				{
					while (enumerator.MoveNext())
					{
						SystemPropertyStruct current = enumerator.Current;
						annotationIssuer.Write((sbyte)current._0001());
						MapIterator(num2.ToString(CultureInfo.InvariantCulture), IteratorComposerPool.ListIssuer(num2), null);
						EnableIterator(current);
						num2++;
					}
				}
				annotationIssuer.Write((byte)0);
				break;
			}
			case (ChildRunStatus)16:
			{
				ValueRequestStrategy valueRequestStrategy2 = (ValueRequestStrategy)asset;
				annotationIssuer.Write(Convert.ToInt32(valueRequestStrategy2._0001(), CultureInfo.InvariantCulture));
				break;
			}
			case (ChildRunStatus)18:
			{
				ValueRequestStrategy valueRequestStrategy3 = (ValueRequestStrategy)asset;
				annotationIssuer.Write(Convert.ToInt64(valueRequestStrategy3._0001(), CultureInfo.InvariantCulture));
				break;
			}
			case (ChildRunStatus)1:
			{
				ValueRequestStrategy valueRequestStrategy4 = (ValueRequestStrategy)asset;
				annotationIssuer.Write(Convert.ToDouble(valueRequestStrategy4._0001(), CultureInfo.InvariantCulture));
				break;
			}
			case (ChildRunStatus)2:
			{
				ParameterRequestStrategy parameterRequestStrategy = (ParameterRequestStrategy)asset;
				MapIterator((string)((ValueRequestStrategy)parameterRequestStrategy)._0001(), parameterRequestStrategy._0002(), ((SystemPropertyStruct)parameterRequestStrategy)._0001() - 4);
				break;
			}
			case (ChildRunStatus)8:
				annotationIssuer.Write(asset == IdentifierPropertyStruct._ProcIssuer);
				break;
			case (ChildRunStatus)9:
			{
				ValueRequestStrategy valueRequestStrategy = (ValueRequestStrategy)asset;
				long num = 0L;
				object obj = valueRequestStrategy._0001();
				if (obj is DateTime)
				{
					DateTime param = (DateTime)obj;
					if (_0001() == DateTimeKind.Utc)
					{
						param = param.ToUniversalTime();
					}
					else if (_0001() == DateTimeKind.Local)
					{
						param = param.ToLocalTime();
					}
					num = DescriptorIteratorMapping.RegisterProperty(param, usecont: false);
				}
				else
				{
					DateTimeOffset dateTimeOffset = (DateTimeOffset)valueRequestStrategy._0001();
					num = DescriptorIteratorMapping.ResetProperty(dateTimeOffset.UtcDateTime, dateTimeOffset.Offset);
				}
				annotationIssuer.Write(num);
				break;
			}
			case (ChildRunStatus)5:
			{
				FilterReader filterReader = (FilterReader)asset;
				byte[] array = (byte[])((ValueRequestStrategy)filterReader)._0001();
				annotationIssuer.Write(array.Length);
				annotationIssuer.Write((byte)filterReader._0001());
				annotationIssuer.Write(array);
				break;
			}
			case (ChildRunStatus)7:
			{
				byte[] buffer = (byte[])((ValueRequestStrategy)asset)._0001();
				annotationIssuer.Write(buffer);
				break;
			}
			case (ChildRunStatus)11:
			{
				MapperComposerPool mapperComposerPool = (MapperComposerPool)asset;
				MapIterator((string)((ValueRequestStrategy)mapperComposerPool._0001())._0001(), mapperComposerPool._0001()._0002(), null);
				MapIterator((string)((ValueRequestStrategy)mapperComposerPool._0002())._0001(), mapperComposerPool._0002()._0002(), null);
				break;
			}
			default:
				throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".ListReader(CultureInfo.InvariantCulture, asset._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MapIterator(string reference, int idxattr, int? third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (third.HasValue)
			{
				annotationIssuer.Write(third.GetValueOrDefault());
			}
			InsertIterator(reference, idxattr);
			annotationIssuer.Write((byte)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsertIterator(string def, int flags_connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == null)
			{
				return;
			}
			if (flags_connection <= 256)
			{
				if (m_ExporterIssuer == null)
				{
					m_ExporterIssuer = new byte[256];
				}
				m_AlgoIssuer.GetBytes(def, 0, def.Length, m_ExporterIssuer, 0);
				annotationIssuer.Write(m_ExporterIssuer, 0, flags_connection);
			}
			else
			{
				byte[] bytes = m_AlgoIssuer.GetBytes(def);
				annotationIssuer.Write(bytes);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int FlushIterator(int param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return param + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int CreateIterator(int var1Y, bool setpred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((!setpred) ? 1 : 5) + var1Y;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int StopIterator(SystemPropertyStruct ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (ident._0001())
			{
			case (ChildRunStatus)3:
			{
				TemplateIssuer templateIssuer = (TemplateIssuer)ident;
				int num4 = 4;
				using (IEnumerator<PageFilterResolver> enumerator2 = templateIssuer._0001())
				{
					while (enumerator2.MoveNext())
					{
						PageFilterResolver current2 = enumerator2.Current;
						int num5 = 1;
						num5 += StopIterator(current2._0001());
						num5 += StopIterator(current2._0001());
						num4 += num5;
					}
				}
				num4++;
				templateIssuer._0001(num4);
				return num4;
			}
			case (ChildRunStatus)4:
			{
				InitializerComposerWorker initializerComposerWorker = (InitializerComposerWorker)ident;
				int num2 = 4;
				ulong num3 = 0uL;
				using (IEnumerator<SystemPropertyStruct> enumerator = initializerComposerWorker._0001())
				{
					while (enumerator.MoveNext())
					{
						SystemPropertyStruct current = enumerator.Current;
						num2++;
						num2 += FlushIterator(IteratorComposerPool.ListIssuer(num3));
						num2 += StopIterator(current);
						num3++;
					}
				}
				num2++;
				initializerComposerWorker._0001(num2);
				return ((SystemPropertyStruct)initializerComposerWorker)._0001();
			}
			case (ChildRunStatus)16:
				return 4;
			case (ChildRunStatus)18:
				return 8;
			case (ChildRunStatus)1:
				return 8;
			case (ChildRunStatus)2:
			{
				ParameterRequestStrategy parameterRequestStrategy = (ParameterRequestStrategy)ident;
				string text = (string)((ValueRequestStrategy)parameterRequestStrategy)._0001();
				parameterRequestStrategy._0002((text != null) ? m_AlgoIssuer.GetByteCount(text) : 0);
				parameterRequestStrategy._0001(CreateIterator(parameterRequestStrategy._0002(), parameterRequestStrategy._0001()));
				return ((SystemPropertyStruct)parameterRequestStrategy)._0001();
			}
			case (ChildRunStatus)8:
				return 1;
			case (ChildRunStatus)6:
			case (ChildRunStatus)10:
				return 0;
			case (ChildRunStatus)9:
				return 8;
			case (ChildRunStatus)5:
			{
				FilterReader obj = (FilterReader)ident;
				byte[] array = (byte[])((ValueRequestStrategy)obj)._0001();
				obj._0001(5 + array.Length);
				return ((SystemPropertyStruct)obj)._0001();
			}
			case (ChildRunStatus)7:
				return 12;
			case (ChildRunStatus)11:
			{
				MapperComposerPool mapperComposerPool = (MapperComposerPool)ident;
				int num = 0;
				num += StopIterator(mapperComposerPool._0001());
				num += StopIterator(mapperComposerPool._0002());
				mapperComposerPool._0001(num);
				return ((SystemPropertyStruct)mapperComposerPool)._0001();
			}
			default:
				throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".ListReader(CultureInfo.InvariantCulture, ident._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefinitionPropertyStruct()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_AlgoIssuer = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
		}
	}
}
