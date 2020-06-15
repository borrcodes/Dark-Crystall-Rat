using _0008;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace GDBD.Workers
{
	[global::_0008._0012(0)]
	internal sealed class ExpressionComposerWorker : RecordClassDispatcher
	{
		private ConfigurationIssuer _ContextIssuer;

		private ConfigurationIssuer m_ParamIssuer;

		private PoolIssuer _PublisherIssuer;

		private ParserFilterResolver utilsIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_ContextIssuer != null)
			{
				return _ContextIssuer;
			}
			return _PublisherIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExpressionComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0002();
			ReadRequest(new DecoratorReaderMapper());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReadRequest(ConfigurationIssuer last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ParamIssuer == null)
			{
				_ContextIssuer = last;
			}
			else
			{
				m_ParamIssuer.SetupClass(last);
			}
			m_ParamIssuer = last;
			utilsIssuer = last;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InterruptRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			utilsIssuer = m_ParamIssuer;
			m_ParamIssuer = ((ParserFilterResolver)m_ParamIssuer)._0001();
			if (m_ParamIssuer != null && ((ParserFilterResolver)m_ParamIssuer)._0001() == Newtonsoft.Rules.UnicodeCategory.Property)
			{
				m_ParamIssuer = ((ParserFilterResolver)m_ParamIssuer)._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0003();
			ReadRequest(new InstanceClassDispatcher());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(param);
			ReadRequest(new IndexerReaderMapper(param));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(WatcherComposer def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InterruptRequest();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(string spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			(m_ParamIssuer as DecoratorReaderMapper)?._0002(spec);
			ReadRequest(new WatcherIssuer(spec));
			base._0002(spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CalcRequest(object ident, WatcherComposer b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InstantiateRequest(new PoolIssuer(ident), b);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InstantiateRequest(PoolIssuer first, WatcherComposer col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ParamIssuer != null)
			{
				m_ParamIssuer.Add(first);
				utilsIssuer = ((ParserFilterResolver)m_ParamIssuer)._0003();
				if (((ParserFilterResolver)m_ParamIssuer)._0001() == Newtonsoft.Rules.UnicodeCategory.Property)
				{
					m_ParamIssuer = ((ParserFilterResolver)m_ParamIssuer)._0001();
				}
			}
			else
			{
				_PublisherIssuer = (first ?? PoolIssuer.VisitRequest());
				utilsIssuer = _PublisherIssuer;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance is BigInteger)
			{
				GetTest(WatcherComposer.Integer);
				CalcRequest(instance, WatcherComposer.Integer);
			}
			else
			{
				base._0001(instance);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0008();
			InstantiateRequest(null, WatcherComposer.Null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._000E();
			InstantiateRequest(null, WatcherComposer.Undefined);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0003(first);
			InstantiateRequest(new MessageEventEntry(first), WatcherComposer.Raw);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0005(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0005(var1);
			InstantiateRequest(PoolIssuer.LogoutRequest(var1), WatcherComposer.Comment);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0004(string asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0004(asset);
			CalcRequest(asset, WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(int no__task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(no__task);
			CalcRequest(no__task, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(uint item_Z)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(item_Z);
			CalcRequest(item_Z, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long var1_X)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(var1_X);
			CalcRequest(var1_X, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ulong no_first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(no_first);
			CalcRequest(no_first, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(first);
			CalcRequest(first, WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(spec);
			CalcRequest(spec, WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(bool havevar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(havevar1);
			CalcRequest(havevar1, WatcherComposer.Boolean);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(short indexOf_config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(indexOf_config);
			CalcRequest(indexOf_config, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ushort previous_value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(previous_value);
			CalcRequest(previous_value, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(char reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(reference);
			string ident = reference.ToString(CultureInfo.InvariantCulture);
			CalcRequest(ident, WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte itemcounter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(itemcounter);
			CalcRequest(itemcounter, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(sbyte reference_start)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(reference_start);
			CalcRequest(reference_start, WatcherComposer.Integer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(decimal v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(v);
			CalcRequest(v, WatcherComposer.Float);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTime item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(item);
			item = DescriptorIteratorMapping.ReadProperty(item, base._0001());
			CalcRequest(item, WatcherComposer.Date);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTimeOffset last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(last);
			CalcRequest(last, WatcherComposer.Date);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(item);
			CalcRequest(item, WatcherComposer.Bytes);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(TimeSpan last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(last);
			CalcRequest(last, WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Guid instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(instance);
			CalcRequest(instance, WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Uri v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(v);
			CalcRequest(v, WatcherComposer.String);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void _0001(TagTestItem asset, bool excludepol, bool containstag, bool extractident2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DatabaseDicCandidate databaseDicCandidate = asset as DatabaseDicCandidate;
			if (databaseDicCandidate != null && excludepol && containstag && extractident2)
			{
				if (((TagTestItem)databaseDicCandidate)._0001() == WatcherComposer.None && !((TagTestItem)databaseDicCandidate)._0001())
				{
					return;
				}
				ParserFilterResolver parserFilterResolver = databaseDicCandidate._0001()._0001();
				if (m_ParamIssuer != null)
				{
					m_ParamIssuer.Add(parserFilterResolver);
					utilsIssuer = ((ParserFilterResolver)m_ParamIssuer)._0003();
					if (((ParserFilterResolver)m_ParamIssuer)._0001() == Newtonsoft.Rules.UnicodeCategory.Property)
					{
						m_ParamIssuer = ((ParserFilterResolver)m_ParamIssuer)._0001();
						GetTest(WatcherComposer.Null);
					}
				}
				else
				{
					utilsIssuer = parserFilterResolver;
					if (_ContextIssuer == null && _PublisherIssuer == null)
					{
						_ContextIssuer = (parserFilterResolver as ConfigurationIssuer);
						_PublisherIssuer = (parserFilterResolver as PoolIssuer);
					}
				}
				databaseDicCandidate.AssetError();
			}
			else
			{
				base._0001(asset, excludepol, containstag, extractident2);
			}
		}
	}
}
