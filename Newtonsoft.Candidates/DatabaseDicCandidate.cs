using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[global::_0008._0012(0)]
	internal sealed class DatabaseDicCandidate : TagTestItem, IdentifierClientBridge
	{
		private readonly ParserFilterResolver m_SetterIssuer;

		[global::_0008._0012(2)]
		private string _WorkerIssuer;

		[global::_0008._0012(2)]
		private ParserFilterResolver advisorIssuer;

		[global::_0008._0012(2)]
		private ParserFilterResolver _RulesIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public new ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RulesIssuer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DatabaseDicCandidate(ParserFilterResolver spec)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			ContextClientBridge.RunClient(spec, "token");
			m_SetterIssuer = spec;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0001() != 0)
			{
				if (_RulesIssuer == null)
				{
					return false;
				}
				ConfigurationIssuer configurationIssuer = _RulesIssuer as ConfigurationIssuer;
				if (configurationIssuer != null && advisorIssuer != configurationIssuer)
				{
					return PushRequest(configurationIssuer);
				}
				return NewRequest(_RulesIssuer);
			}
			if (_RulesIssuer == m_SetterIssuer)
			{
				return false;
			}
			_RulesIssuer = m_SetterIssuer;
			AwakeRequest(_RulesIssuer);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool NewRequest(ParserFilterResolver key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (key == m_SetterIssuer)
			{
				return ForgotRequest();
			}
			ParserFilterResolver parserFilterResolver = key._0006();
			if (parserFilterResolver == null || parserFilterResolver == key || key == ((ParserFilterResolver)key._0001())._0003())
			{
				if (key._0001() == null)
				{
					return ForgotRequest();
				}
				return PrepareRequest(key._0001());
			}
			_RulesIssuer = parserFilterResolver;
			AwakeRequest(_RulesIssuer);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ForgotRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RulesIssuer = null;
			CustomizeError(WatcherComposer.None);
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private WatcherComposer? IncludeRequest(ConfigurationIssuer spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (((ParserFilterResolver)spec)._0001())
			{
			case UnicodeCategory.Object:
				return WatcherComposer.EndObject;
			case UnicodeCategory.Array:
				return WatcherComposer.EndArray;
			case UnicodeCategory.Constructor:
				return WatcherComposer.EndConstructor;
			case UnicodeCategory.Property:
				return null;
			default:
				throw CustomerListAnnotation.ConcatIssuer("Type", ((ParserFilterResolver)spec)._0001(), "Unexpected JContainer type.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PushRequest(ConfigurationIssuer first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ParserFilterResolver parserFilterResolver = first._0002();
			if (parserFilterResolver == null)
			{
				return PrepareRequest(first);
			}
			AwakeRequest(parserFilterResolver);
			_RulesIssuer = parserFilterResolver;
			advisorIssuer = first;
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PrepareRequest(ConfigurationIssuer first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer? watcherComposer = IncludeRequest(first);
			if (watcherComposer.HasValue)
			{
				CustomizeError(watcherComposer.GetValueOrDefault());
				_RulesIssuer = first;
				advisorIssuer = first;
				return true;
			}
			return NewRequest(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AwakeRequest(ParserFilterResolver item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (item._0001())
			{
			case UnicodeCategory.Object:
				CustomizeError(WatcherComposer.StartObject);
				break;
			case UnicodeCategory.Array:
				CustomizeError(WatcherComposer.StartArray);
				break;
			case UnicodeCategory.Constructor:
				QueryError(WatcherComposer.StartConstructor, ((IndexerReaderMapper)item)._0001());
				break;
			case UnicodeCategory.Property:
				QueryError(WatcherComposer.PropertyName, ((WatcherIssuer)item)._0001());
				break;
			case UnicodeCategory.Comment:
				QueryError(WatcherComposer.Comment, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Integer:
				QueryError(WatcherComposer.Integer, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Float:
				QueryError(WatcherComposer.Float, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.String:
				QueryError(WatcherComposer.String, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Boolean:
				QueryError(WatcherComposer.Boolean, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Null:
				QueryError(WatcherComposer.Null, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Undefined:
				QueryError(WatcherComposer.Undefined, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Date:
			{
				object obj2 = ((PoolIssuer)item)._0001();
				if (obj2 is DateTime)
				{
					DateTime param = (DateTime)obj2;
					obj2 = DescriptorIteratorMapping.ReadProperty(param, base._0001());
				}
				QueryError(WatcherComposer.Date, obj2);
				break;
			}
			case UnicodeCategory.Raw:
				QueryError(WatcherComposer.Raw, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Bytes:
				QueryError(WatcherComposer.Bytes, ((PoolIssuer)item)._0001());
				break;
			case UnicodeCategory.Guid:
				QueryError(WatcherComposer.String, UpdateRequest(((PoolIssuer)item)._0001()));
				break;
			case UnicodeCategory.Uri:
			{
				object obj = ((PoolIssuer)item)._0001();
				Uri uri = obj as Uri;
				QueryError(WatcherComposer.String, ((object)uri != null) ? uri.OriginalString : UpdateRequest(obj));
				break;
			}
			case UnicodeCategory.TimeSpan:
				QueryError(WatcherComposer.String, UpdateRequest(((PoolIssuer)item)._0001()));
				break;
			default:
				throw CustomerListAnnotation.ConcatIssuer("Type", item._0001(), "Unexpected JTokenType.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string UpdateRequest(object ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ident?.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0001() == (MethodAttributes)0)
			{
				return false;
			}
			return ((IdentifierClientBridge)_RulesIssuer)?._0002() ?? false;
		}

		bool IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0008();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new int _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0001() == (MethodAttributes)0)
			{
				return 0;
			}
			return ((IdentifierClientBridge)_RulesIssuer)?._0001() ?? 0;
		}

		int IdentifierClientBridge._0001()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (base._0001() == (MethodAttributes)0)
			{
				return 0;
			}
			return ((IdentifierClientBridge)_RulesIssuer)?._0002() ?? 0;
		}

		int IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0005();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = base._0002();
			if (_WorkerIssuer == null)
			{
				_WorkerIssuer = m_SetterIssuer._0003();
			}
			if (!SetterTest.StartReader(_WorkerIssuer))
			{
				if (SetterTest.StartReader(text))
				{
					return _WorkerIssuer;
				}
				text = ((!text.ExcludeReader('[')) ? (_WorkerIssuer + "." + text) : (_WorkerIssuer + text));
			}
			return text;
		}
	}
}
