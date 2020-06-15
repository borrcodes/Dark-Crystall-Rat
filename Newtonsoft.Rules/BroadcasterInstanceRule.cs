using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Mappers;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal sealed class BroadcasterInstanceRule : RuleTestItem
	{
		internal enum TaskbarItemProgressState
		{

		}

		[_0008._0012(0)]
		internal sealed class ModelEventEntry
		{
			[_0008._0012(1)]
			public readonly string adapterProperty;

			public ProductInstanceExpression m_TokenProperty;

			public ProductInstanceExpression m_DispatcherProperty;

			public TaskbarItemProgressState? m_AccountProperty;

			public object singletonProperty;

			public bool modelProperty;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ModelEventEntry(string spec)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				adapterProperty = spec;
			}
		}

		[CompilerGenerated]
		private sealed class _0002
		{
			[_0008._0012(0)]
			public ProductInstanceExpression _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0002()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(ModelEventEntry P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0.m_TokenProperty != this._0001;
			}
		}

		[Serializable]
		[CompilerGenerated]
		private sealed class MessageProperty
		{
			[_0008._0012(0)]
			public static readonly MessageProperty _ProductProperty;

			[_0008._0012(0)]
			public static Func<ProductInstanceExpression, string> m_InterceptorProperty;

			[_0008._0012(new byte[]
			{
				0,
				0,
				1
			})]
			public static Func<ProductInstanceExpression, string> m_AlgoProperty;

			[_0008._0012(0)]
			public static Func<ProductInstanceExpression, ProductInstanceExpression> annotationProperty;

			[_0008._0012(0)]
			public static Func<ProductInstanceExpression, TaskbarItemProgressState> m_ExporterProperty;

			[MethodImpl(MethodImplOptions.NoInlining)]
			static MessageProperty()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				_ProductProperty = new MessageProperty();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public MessageProperty()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string ChangeBroadcaster(ProductInstanceExpression instance)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return instance._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string CalculateBroadcaster(ProductInstanceExpression res)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return res._0001();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ProductInstanceExpression GetBroadcaster(ProductInstanceExpression i)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return i;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal TaskbarItemProgressState StartBroadcaster(ProductInstanceExpression init)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return (TaskbarItemProgressState)0;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BroadcasterInstanceRule(PrototypeError info)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(info);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ProcTest DisableBroadcaster(Type init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (init == null)
			{
				return null;
			}
			return VerifyBroadcaster(init);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ProcTest VerifyBroadcaster(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return baseProperty.listenerError._0001(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object PatchBroadcaster(TagTestItem var1, Type map, bool injectstate)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (var1 == null)
			{
				throw new ArgumentNullException("reader");
			}
			ProcTest procTest = DisableBroadcaster(map);
			try
			{
				BroadcasterError broadcasterError = CompareBroadcaster(procTest, null, null, null);
				if (var1._0001() == WatcherComposer.None && !var1.PublishError(procTest, broadcasterError != null))
				{
					if (procTest != null && !procTest.recordProperty)
					{
						throw StrategyError.PatchComposer(var1, "No JSON content found and type '{0}' is not nullable.".ListReader(CultureInfo.InvariantCulture, procTest._0002()));
					}
					return null;
				}
				object result = (broadcasterError == null || !broadcasterError._0002()) ? ResolveBroadcaster(var1, map, procTest, null, null, null, null) : ReflectBroadcaster(broadcasterError, var1, map, null);
				if (injectstate)
				{
					while (var1._0001())
					{
						if (var1._0001() != WatcherComposer.Comment)
						{
							throw StrategyError.PatchComposer(var1, "Additional text found in JSON string after finishing deserializing object.");
						}
					}
				}
				return result;
			}
			catch (Exception ident)
			{
				if (!CheckBroadcaster(null, procTest, null, var1 as IdentifierClientBridge, var1._0002(), ident))
				{
					LoginBroadcaster();
					throw;
				}
				PostBroadcaster(var1, excludetoken: false, 0);
				return null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AlgoInstanceExpression FindBroadcaster()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ProccesorProperty == null)
			{
				m_ProccesorProperty = new AlgoInstanceExpression(this);
			}
			return m_ProccesorProperty;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParserFilterResolver ValidateBroadcaster(TagTestItem config, ProcTest map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(config, "reader");
			if (map != null)
			{
				if (map._0002() == typeof(MessageEventEntry))
				{
					return MessageEventEntry.FlushRequest(config);
				}
				if (config._0001() == WatcherComposer.Null && !(map._0002() == typeof(PoolIssuer)) && !(map._0002() == typeof(ParserFilterResolver)))
				{
					return null;
				}
			}
			using (ExpressionComposerWorker expressionComposerWorker = new ExpressionComposerWorker())
			{
				expressionComposerWorker.IncludeTest(config);
				return expressionComposerWorker._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ParserFilterResolver OrderBroadcaster(TagTestItem last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(last, "reader");
			using (ExpressionComposerWorker expressionComposerWorker = new ExpressionComposerWorker())
			{
				((RecordClassDispatcher)expressionComposerWorker)._0002();
				do
				{
					if (last._0001() == WatcherComposer.PropertyName)
					{
						string text = (string)last._0001();
						if (!last.WriteError())
						{
							break;
						}
						if (!ComputeBroadcaster(last, text))
						{
							expressionComposerWorker._0002(text);
							expressionComposerWorker._0001(last, excludepol: true, containstag: true, extractident2: false);
						}
					}
					else if (last._0001() != WatcherComposer.Comment)
					{
						expressionComposerWorker._0011();
						return expressionComposerWorker._0001();
					}
				}
				while (last._0001());
				throw StrategyError.PatchComposer(last, "Unexpected end when deserializing object.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ResolveBroadcaster(TagTestItem setup, Type reg, ProcTest comp, ProductInstanceExpression info2, InitializerTest reference3, ProductInstanceExpression instance4, object spec5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (comp != null && comp._ErrorProperty == (ParameterFilterResolver)8)
			{
				return ValidateBroadcaster(setup, comp);
			}
			do
			{
				switch (setup._0001())
				{
				case WatcherComposer.StartObject:
					return AddBroadcaster(setup, reg, comp, info2, reference3, instance4, spec5);
				case WatcherComposer.StartArray:
					return CreateBroadcaster(setup, reg, comp, info2, spec5, null);
				case WatcherComposer.Integer:
				case WatcherComposer.Float:
				case WatcherComposer.Boolean:
				case WatcherComposer.Date:
				case WatcherComposer.Bytes:
					return CloneBroadcaster(setup, setup._0001(), CultureInfo.InvariantCulture, comp, reg);
				case WatcherComposer.String:
				{
					string text = (string)setup._0001();
					if (reg == typeof(byte[]))
					{
						return Convert.FromBase64String(text);
					}
					if (FillBroadcaster(reg, comp, text))
					{
						return null;
					}
					return CloneBroadcaster(setup, text, CultureInfo.InvariantCulture, comp, reg);
				}
				case WatcherComposer.StartConstructor:
				{
					string cust = setup._0001().ToString();
					return CloneBroadcaster(setup, cust, CultureInfo.InvariantCulture, comp, reg);
				}
				case WatcherComposer.Null:
				case WatcherComposer.Undefined:
					if (reg == typeof(DBNull))
					{
						return DBNull.Value;
					}
					return CloneBroadcaster(setup, setup._0001(), CultureInfo.InvariantCulture, comp, reg);
				case WatcherComposer.Raw:
					return new MessageEventEntry((string)setup._0001());
				default:
					throw StrategyError.PatchComposer(setup, "Unexpected token while deserializing object: " + setup._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (setup._0001());
			throw StrategyError.PatchComposer(setup, "Unexpected end when deserializing object.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool FillBroadcaster(Type v, ProcTest token, string filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(filter) && v != null && v != typeof(string) && v != typeof(object) && token != null)
			{
				return token.recordProperty;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string RunBroadcaster(ProcTest v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (v._ErrorProperty)
			{
			case (ParameterFilterResolver)1:
			case (ParameterFilterResolver)5:
			case (ParameterFilterResolver)6:
			case (ParameterFilterResolver)7:
				return "JSON object (e.g. {\"name\":\"value\"})";
			case (ParameterFilterResolver)2:
				return "JSON array (e.g. [1,2,3])";
			case (ParameterFilterResolver)3:
				return "JSON primitive value (e.g. string, number, boolean, null)";
			case (ParameterFilterResolver)4:
				return "JSON string value";
			default:
				throw new ArgumentOutOfRangeException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BroadcasterError CompareBroadcaster(ProcTest setup, BroadcasterError second, InitializerTest pool, ProductInstanceExpression reference2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			BroadcasterError result = null;
			if (second != null)
			{
				result = second;
			}
			else if (reference2?._0002() != null)
			{
				result = reference2._0002();
			}
			else if (pool?._0001() != null)
			{
				result = pool._0001();
			}
			else if (setup != null)
			{
				if (setup._0002() != null)
				{
					result = setup._0002();
				}
				else
				{
					BroadcasterError broadcasterError = baseProperty.CloneComposer(setup._0002());
					if (broadcasterError != null)
					{
						result = broadcasterError;
					}
					else if (setup._0003() != null)
					{
						result = setup._0003();
					}
				}
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object AddBroadcaster(TagTestItem init, Type counter, ProcTest control, ProductInstanceExpression setup2, InitializerTest last3, ProductInstanceExpression res4, object attr5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type b = counter;
			string map;
			if (baseProperty._0001() == (CacheActions)2)
			{
				init.SortError();
				map = null;
			}
			else if (baseProperty._0001() == (CacheActions)1)
			{
				DatabaseDicCandidate databaseDicCandidate = init as DatabaseDicCandidate;
				if (databaseDicCandidate == null)
				{
					databaseDicCandidate = (DatabaseDicCandidate)ParserFilterResolver.SelectClass(init).GetClass();
					databaseDicCandidate._0001(init._0001());
					databaseDicCandidate._0001(init._0003());
					databaseDicCandidate._0001(init._0001());
					databaseDicCandidate._0001(init._0001());
					databaseDicCandidate._0001(init._0001());
					databaseDicCandidate._0002(init._0004());
					databaseDicCandidate.SortError();
					init = databaseDicCandidate;
				}
				if (EnableBroadcaster(databaseDicCandidate, ref b, ref control, setup2, last3, res4, attr5, out object _000E, out map))
				{
					return _000E;
				}
			}
			else
			{
				init.SortError();
				if (MapBroadcaster(init, ref b, ref control, setup2, last3, res4, attr5, out object task, out map))
				{
					return task;
				}
			}
			if (StopBroadcaster(control))
			{
				return OrderBroadcaster(init);
			}
			switch (control._ErrorProperty)
			{
			case (ParameterFilterResolver)1:
			{
				bool setup4 = false;
				PrototypeFilterResolver prototypeFilterResolver = (PrototypeFilterResolver)control;
				object obj = (attr5 == null || (!(b == counter) && !b.IsAssignableFrom(attr5.GetType()))) ? RegisterBroadcaster(init, prototypeFilterResolver, setup2, res4, map, out setup4) : attr5;
				if (setup4)
				{
					return obj;
				}
				return RestartBroadcaster(obj, init, prototypeFilterResolver, setup2, map);
			}
			case (ParameterFilterResolver)3:
			{
				ProccesorClassSpec comp = (ProccesorClassSpec)control;
				if (baseProperty._0001() != (CacheActions)2 && init._0001() == WatcherComposer.PropertyName && string.Equals(init._0001().ToString(), "$value", StringComparison.Ordinal))
				{
					init.SortError();
					if (init._0001() == WatcherComposer.StartObject)
					{
						throw StrategyError.PatchComposer(init, "Unexpected token when deserializing primitive value: " + init._0001());
					}
					object result = ResolveBroadcaster(init, b, comp, setup2, null, null, attr5);
					init.SortError();
					return result;
				}
				break;
			}
			case (ParameterFilterResolver)5:
			{
				ParamClientBridge paramClientBridge = (ParamClientBridge)control;
				if (attr5 == null)
				{
					bool third;
					IDictionary dictionary = NewBroadcaster(init, paramClientBridge, out third);
					if (third)
					{
						if (map != null)
						{
							throw StrategyError.PatchComposer(init, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, control._0002()));
						}
						if (control._0004().Count > 0)
						{
							throw StrategyError.PatchComposer(init, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, control._0002()));
						}
						if (control._0001().Count > 0)
						{
							throw StrategyError.PatchComposer(init, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, control._0002()));
						}
						if (!paramClientBridge._0003())
						{
							throw StrategyError.PatchComposer(init, "Cannot deserialize readonly or fixed size dictionary: {0}.".ListReader(CultureInfo.InvariantCulture, control._0002()));
						}
					}
					PushBroadcaster(dictionary, init, paramClientBridge, setup2, map);
					if (third)
					{
						return (paramClientBridge._0002() ?? paramClientBridge._0001())(new object[1]
						{
							dictionary
						});
					}
					ProcessComposer processComposer = dictionary as ProcessComposer;
					if (processComposer != null)
					{
						return processComposer._0001();
					}
					return dictionary;
				}
				object setup3;
				if (!paramClientBridge._0001() && attr5 is IDictionary)
				{
					setup3 = (IDictionary)attr5;
				}
				else
				{
					IDictionary dictionary2 = paramClientBridge.CountClient(attr5);
					setup3 = dictionary2;
				}
				return PushBroadcaster((IDictionary)setup3, init, paramClientBridge, setup2, map);
			}
			case (ParameterFilterResolver)6:
			{
				ProducerProperty connection = (ProducerProperty)control;
				return CalcBroadcaster(init, connection, setup2, map);
			}
			case (ParameterFilterResolver)7:
			{
				CollectionProperty pol = (CollectionProperty)control;
				return ReadBroadcaster(init, pol, setup2, map);
			}
			}
			string spec = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
			spec = spec.SelectReader(CultureInfo.InvariantCulture, b, RunBroadcaster(control));
			throw StrategyError.PatchComposer(init, spec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool EnableBroadcaster([_0008._0012(1)] DatabaseDicCandidate _0002, ref Type b, ref ProcTest consumer, ProductInstanceExpression cust2, InitializerTest connection3, ProductInstanceExpression map4, object reg5, [ConsumerBroadcasterDispatcher(true)] out object _000E, out string map7)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			map7 = null;
			_000E = null;
			if (((TagTestItem)_0002)._0001() == WatcherComposer.StartObject)
			{
				DecoratorReaderMapper decoratorReaderMapper = (DecoratorReaderMapper)_0002._0001();
				WatcherIssuer watcherIssuer = decoratorReaderMapper.DisableRequest("$ref", StringComparison.Ordinal);
				if (watcherIssuer != null)
				{
					ParserFilterResolver parserFilterResolver = watcherIssuer._0004();
					if (parserFilterResolver._0001() != UnicodeCategory.String && parserFilterResolver._0001() != UnicodeCategory.Null)
					{
						throw StrategyError.ValidateComposer(parserFilterResolver, parserFilterResolver._0003(), "JSON reference {0} property must have a string or null value.".ListReader(CultureInfo.InvariantCulture, "$ref"), null);
					}
					string text = ParserFilterResolver._0002(watcherIssuer);
					if (text != null)
					{
						ParserFilterResolver parserFilterResolver2 = watcherIssuer._0006() ?? watcherIssuer._0007();
						if (parserFilterResolver2 != null)
						{
							throw StrategyError.ValidateComposer(parserFilterResolver2, parserFilterResolver2._0003(), "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".ListReader(CultureInfo.InvariantCulture, "$ref"), null);
						}
						_000E = baseProperty.StopComposer()._0001(this, text);
						if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
						{
							containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(_0002, ((TagTestItem)_0002)._0002(), "Resolved object reference '{0}' to {1}.".SelectReader(CultureInfo.InvariantCulture, text, _000E.GetType())), null);
						}
						_0002.AssetError();
						return true;
					}
				}
				ParserFilterResolver parserFilterResolver3 = decoratorReaderMapper["$type"];
				if (parserFilterResolver3 != null)
				{
					string t = ParserFilterResolver._0002(parserFilterResolver3);
					TagTestItem @class = parserFilterResolver3.GetClass();
					@class.SortError();
					InsertBroadcaster(@class, ref b, ref consumer, cust2, connection3, map4, t);
					if (decoratorReaderMapper["$value"] != null)
					{
						while (true)
						{
							_0002.SortError();
							if (((TagTestItem)_0002)._0001() == WatcherComposer.PropertyName && (string)((TagTestItem)_0002)._0001() == "$value")
							{
								break;
							}
							_0002.SortError();
							_0002.AssetError();
						}
						return false;
					}
				}
				ParserFilterResolver parserFilterResolver4 = decoratorReaderMapper["$id"];
				if (parserFilterResolver4 != null)
				{
					map7 = ParserFilterResolver._0002(parserFilterResolver4);
				}
				ParserFilterResolver parserFilterResolver5 = decoratorReaderMapper["$values"];
				if (parserFilterResolver5 != null)
				{
					TagTestItem class2 = parserFilterResolver5.GetClass();
					class2.SortError();
					_000E = CreateBroadcaster(class2, b, consumer, cust2, reg5, map7);
					_0002.AssetError();
					return true;
				}
			}
			_0002.SortError();
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MapBroadcaster([_0008._0012(1)] TagTestItem _0002, ref Type map, ref ProcTest filter, ProductInstanceExpression first2, InitializerTest visitor3, ProductInstanceExpression param4, object param5, out object task6, out string param7)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			param7 = null;
			task6 = null;
			if (_0002._0001() == WatcherComposer.PropertyName)
			{
				string text = _0002._0001().ToString();
				if (text.Length > 0 && text[0] == '$')
				{
					bool flag;
					do
					{
						text = _0002._0001().ToString();
						if (string.Equals(text, "$ref", StringComparison.Ordinal))
						{
							_0002.SortError();
							if (_0002._0001() != WatcherComposer.String && _0002._0001() != WatcherComposer.Null)
							{
								throw StrategyError.PatchComposer(_0002, "JSON reference {0} property must have a string or null value.".ListReader(CultureInfo.InvariantCulture, "$ref"));
							}
							string text2 = _0002._0001()?.ToString();
							_0002.SortError();
							if (text2 != null)
							{
								if (_0002._0001() == WatcherComposer.PropertyName)
								{
									throw StrategyError.PatchComposer(_0002, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".ListReader(CultureInfo.InvariantCulture, "$ref"));
								}
								task6 = baseProperty.StopComposer()._0001(this, text2);
								if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
								{
									containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(_0002 as IdentifierClientBridge, _0002._0002(), "Resolved object reference '{0}' to {1}.".SelectReader(CultureInfo.InvariantCulture, text2, task6.GetType())), null);
								}
								return true;
							}
							flag = true;
						}
						else if (string.Equals(text, "$type", StringComparison.Ordinal))
						{
							_0002.SortError();
							string t = _0002._0001().ToString();
							InsertBroadcaster(_0002, ref map, ref filter, first2, visitor3, param4, t);
							_0002.SortError();
							flag = true;
						}
						else if (string.Equals(text, "$id", StringComparison.Ordinal))
						{
							_0002.SortError();
							param7 = _0002._0001()?.ToString();
							_0002.SortError();
							flag = true;
						}
						else
						{
							if (string.Equals(text, "$values", StringComparison.Ordinal))
							{
								_0002.SortError();
								object obj = CreateBroadcaster(_0002, map, filter, first2, param5, param7);
								_0002.SortError();
								task6 = obj;
								return true;
							}
							flag = false;
						}
					}
					while (flag && _0002._0001() == WatcherComposer.PropertyName);
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InsertBroadcaster(TagTestItem key, ref Type vis, ref ProcTest state, ProductInstanceExpression key2, InitializerTest caller3, ProductInstanceExpression config4, string t5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if ((key2?._0001() ?? caller3?._0001() ?? config4?._0002() ?? baseProperty.m_ParserError) != 0)
			{
				GDBD.Workers.TemplateComposerWorker<string, string> templateComposerWorker = ResolverErrorFilter.IncludeReader(t5);
				Type type;
				try
				{
					type = baseProperty.writerError.BindToType(templateComposerWorker.workerTest, templateComposerWorker._AdvisorTest);
				}
				catch (Exception field)
				{
					throw StrategyError.FindComposer(key, "Error resolving type specified in JSON '{0}'.".ListReader(CultureInfo.InvariantCulture, t5), field);
				}
				if (type == null)
				{
					throw StrategyError.PatchComposer(key, "Type specified in JSON '{0}' was not resolved.".ListReader(CultureInfo.InvariantCulture, t5));
				}
				if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
				{
					containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(key as IdentifierClientBridge, key._0002(), "Resolved type '{0}' to {1}.".SelectReader(CultureInfo.InvariantCulture, t5, type)), null);
				}
				if (vis != null && vis != typeof(IDynamicMetaObjectProvider) && !vis.IsAssignableFrom(type))
				{
					throw StrategyError.PatchComposer(key, "Type specified in JSON '{0}' is not compatible with '{1}'.".SelectReader(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, vis.AssemblyQualifiedName));
				}
				vis = type;
				state = VerifyBroadcaster(type);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private MessageTest FlushBroadcaster(TagTestItem config, Type b, ProcTest role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (role == null)
			{
				throw StrategyError.PatchComposer(config, "Could not resolve type '{0}' to a JsonContract.".ListReader(CultureInfo.InvariantCulture, b));
			}
			MessageTest obj = role as MessageTest;
			if (obj == null)
			{
				string spec = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
				spec = spec.SelectReader(CultureInfo.InvariantCulture, b, RunBroadcaster(role));
				throw StrategyError.PatchComposer(config, spec);
			}
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object CreateBroadcaster(TagTestItem asset, Type visitor, ProcTest consumer, ProductInstanceExpression selection2, object visitor3, string second4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (StopBroadcaster(consumer))
			{
				return ValidateBroadcaster(asset, consumer);
			}
			MessageTest messageTest = FlushBroadcaster(asset, visitor, consumer);
			if (visitor3 == null)
			{
				bool res;
				IList list = PopBroadcaster(asset, messageTest, out res);
				if (res)
				{
					if (second4 != null)
					{
						throw StrategyError.PatchComposer(asset, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, consumer._0002()));
					}
					if (consumer._0004().Count > 0)
					{
						throw StrategyError.PatchComposer(asset, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, consumer._0002()));
					}
					if (consumer._0001().Count > 0)
					{
						throw StrategyError.PatchComposer(asset, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".ListReader(CultureInfo.InvariantCulture, consumer._0002()));
					}
					if (!messageTest._0006() && !messageTest._0002())
					{
						throw StrategyError.PatchComposer(asset, "Cannot deserialize readonly or fixed size list: {0}.".ListReader(CultureInfo.InvariantCulture, consumer._0002()));
					}
				}
				if (!messageTest._0001())
				{
					UpdateBroadcaster(list, asset, messageTest, selection2, second4);
				}
				else
				{
					PrepareBroadcaster(list, asset, messageTest, selection2, second4);
				}
				if (res)
				{
					if (messageTest._0001())
					{
						list = ObserverIteratorMapping.LoginProperty(list, messageTest._0001(), consumer._0003().GetArrayRank());
					}
					else
					{
						if (!messageTest._0002())
						{
							return (messageTest._0002() ?? messageTest._0001())(new object[1]
							{
								list
							});
						}
						Array array = Array.CreateInstance(messageTest._0001(), list.Count);
						list.CopyTo(array, 0);
						list = array;
					}
				}
				else
				{
					ManagerErrorFilter managerErrorFilter = list as ManagerErrorFilter;
					if (managerErrorFilter != null)
					{
						return managerErrorFilter._0001();
					}
				}
				return list;
			}
			if (!messageTest._0004())
			{
				throw StrategyError.PatchComposer(asset, "Cannot populate list type {0}.".ListReader(CultureInfo.InvariantCulture, consumer._0003()));
			}
			IList info;
			if (!messageTest._0003())
			{
				IList list2 = visitor3 as IList;
				if (list2 != null)
				{
					info = list2;
					goto IL_020f;
				}
			}
			IList list3 = messageTest.CalculateClient(visitor3);
			info = list3;
			goto IL_020f;
			IL_020f:
			return UpdateBroadcaster(info, asset, messageTest, selection2, second4);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool StopBroadcaster(ProcTest reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference != null && !(reference._0002() == typeof(object)) && reference._ErrorProperty != (ParameterFilterResolver)8)
			{
				return reference._0002() == typeof(IDynamicMetaObjectProvider);
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object CloneBroadcaster(TagTestItem config, object cust, CultureInfo consumer, ProcTest cont2, Type last3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last3 == null)
			{
				return cust;
			}
			if (ResolverErrorFilter.CallIssuer(cust) != last3)
			{
				if (cust == null && cont2.recordProperty)
				{
					return null;
				}
				try
				{
					if (cont2.m_EventProperty)
					{
						ProccesorClassSpec proccesorClassSpec = (ProccesorClassSpec)cont2;
						if (cont2._FilterProperty)
						{
							string text = cust as string;
							if (text != null)
							{
								return InfoFilterResolver.CloneIssuer(cont2._InstanceProperty, null, text, isvalue2: false);
							}
							if (HelperDicCandidate.CreateProperty(proccesorClassSpec._0001()))
							{
								return Enum.ToObject(cont2._InstanceProperty, cust);
							}
						}
						else if (cont2._InstanceProperty == typeof(DateTime))
						{
							string text2 = cust as string;
							if (text2 != null && DescriptorIteratorMapping.RemoveProperty(text2, config._0001(), config._0003(), config._0001(), out DateTime res))
							{
								return DescriptorIteratorMapping.ReadProperty(res, config._0001());
							}
						}
						if (cust is BigInteger)
						{
							BigInteger first = (BigInteger)cust;
							return HelperDicCandidate.CompareProperty(first, cont2._InstanceProperty);
						}
						return Convert.ChangeType(cust, cont2._InstanceProperty, consumer);
					}
					return HelperDicCandidate.MapProperty(cust, consumer, cont2._InstanceProperty);
				}
				catch (Exception field)
				{
					throw StrategyError.FindComposer(config, "Error converting value {0} to type '{1}'.".SelectReader(CultureInfo.InvariantCulture, CustomerListAnnotation.InvokeIssuer(cust), last3), field);
				}
			}
			return cust;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool LogoutBroadcaster(ProductInstanceExpression first, BroadcasterError visitor, InitializerTest tag, ProductInstanceExpression selection2, TagTestItem pol3, object res4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (VisitBroadcaster(first, ref visitor, tag, selection2, pol3, res4, out bool x, out object selection3, out ProcTest item, out bool item2, out bool second))
			{
				if (second)
				{
					return true;
				}
				return false;
			}
			object obj;
			if (visitor != null && visitor._0002())
			{
				if (!item2 && first._0002())
				{
					selection3 = first._0001()._0001(res4);
				}
				obj = ReflectBroadcaster(visitor, pol3, first._0002(), selection3);
			}
			else
			{
				obj = ResolveBroadcaster(pol3, first._0002(), item, first, tag, selection2, x ? selection3 : null);
			}
			if ((!x || obj != selection3) && MoveBroadcaster(first, tag as PrototypeFilterResolver, obj))
			{
				first._0001()._0001(res4, obj);
				if (first._0001() != null)
				{
					if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
					{
						containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(pol3 as IdentifierClientBridge, pol3._0002(), "IsSpecified for property '{0}' on {1} set to true.".SelectReader(CultureInfo.InvariantCulture, first._0001(), first._0001())), null);
					}
					first._0001()(res4, true);
				}
				return true;
			}
			return x;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool VisitBroadcaster([_0008._0012(1)] ProductInstanceExpression _0002, ref BroadcasterError caller, InitializerTest tag, ProductInstanceExpression info2, [_0008._0012(1)] TagTestItem _0006, [_0008._0012(1)] object _0007, out bool x5, out object selection6, out ProcTest item7, out bool item8, out bool second9)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			selection6 = null;
			x5 = false;
			item7 = null;
			item8 = false;
			second9 = false;
			if (_0002._0001())
			{
				return true;
			}
			WatcherComposer watcherComposer = _0006._0001();
			if (_0002._0001() == null)
			{
				_0002._0001(DisableBroadcaster(_0002._0002()));
			}
			if (_0002._0001().GetValueOrDefault(baseProperty._AttributeError) != (PageDicCandidate)2 && (watcherComposer == WatcherComposer.StartArray || watcherComposer == WatcherComposer.StartObject || caller != null) && _0002._0002())
			{
				selection6 = _0002._0001()._0001(_0007);
				item8 = true;
				if (selection6 != null)
				{
					item7 = VerifyBroadcaster(selection6.GetType());
					x5 = (!item7.composerProperty && !item7._0002().FindClient());
				}
			}
			if (!_0002._0003() && !x5)
			{
				if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
				{
					containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(_0006 as IdentifierClientBridge, _0006._0002(), "Unable to deserialize value to non-writable property '{0}' on {1}.".SelectReader(CultureInfo.InvariantCulture, _0002._0001(), _0002._0001())), null);
				}
				return true;
			}
			if (watcherComposer == WatcherComposer.Null && WriteClient(tag as PrototypeFilterResolver, _0002) == (ApplicationState)1)
			{
				second9 = true;
				return true;
			}
			if (ConnectBroadcaster(_0002._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)1) && !ConnectBroadcaster(_0002._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)2) && RulesClientBridge.StartIssuer(watcherComposer) && CustomerListAnnotation.TestIssuer(_0006._0001(), _0002.InitClient()))
			{
				second9 = true;
				return true;
			}
			if (selection6 == null)
			{
				item7 = _0002._0001();
			}
			else
			{
				item7 = VerifyBroadcaster(selection6.GetType());
				if (item7 != _0002._0001())
				{
					caller = CompareBroadcaster(item7, _0002._0001(), tag, info2);
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewBroadcaster(TagTestItem v, string map, object pool)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
				{
					containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(v as IdentifierClientBridge, v._0002(), "Read object reference Id '{0}' for {1}.".SelectReader(CultureInfo.InvariantCulture, map, pool.GetType())), null);
				}
				baseProperty.StopComposer()._0001(this, map, pool);
			}
			catch (Exception field)
			{
				throw StrategyError.FindComposer(v, "Error reading object reference '{0}'.".ListReader(CultureInfo.InvariantCulture, map), field);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ConnectBroadcaster(ConnectActionCursor def, ConnectActionCursor ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (def & ivk) == ivk;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveBroadcaster(ProductInstanceExpression last, PrototypeFilterResolver counter, object c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (c == null && WriteClient(counter, last) == (ApplicationState)1)
			{
				return false;
			}
			if (ConnectBroadcaster(last._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)1) && !ConnectBroadcaster(last._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)2) && CustomerListAnnotation.TestIssuer(c, last.InitClient()))
			{
				return false;
			}
			if (!last._0003())
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IList PopBroadcaster(TagTestItem ident, MessageTest ord, out bool res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ord._0004())
			{
				throw StrategyError.PatchComposer(ident, "Cannot create and populate list type {0}.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)ord)._0003()));
			}
			if (ord._0002() != null)
			{
				if (ord._0005())
				{
					res = true;
					return ord.GetClient();
				}
				object obj = ord._0002()(new object[0]);
				if (ord._0003())
				{
					obj = ord.CalculateClient(obj);
				}
				res = false;
				return (IList)obj;
			}
			if (ord.composerProperty)
			{
				res = true;
				IList list = ord.GetClient();
				if (ord._0003())
				{
					list = ord.CalculateClient(list);
				}
				return list;
			}
			if (((ProcTest)ord)._0001() != null && (!ord._0007() || baseProperty._SerializerError == (AttributeStyle)1))
			{
				object obj2 = ((ProcTest)ord)._0001()();
				if (ord._0003())
				{
					obj2 = ord.CalculateClient(obj2);
				}
				res = false;
				return (IList)obj2;
			}
			if (ord._0006())
			{
				res = true;
				return ord.GetClient();
			}
			if (!ord._IssuerProperty)
			{
				throw StrategyError.PatchComposer(ident, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)ord)._0002()));
			}
			throw StrategyError.PatchComposer(ident, "Unable to find a constructor to use for type {0}.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)ord)._0002()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IDictionary NewBroadcaster(TagTestItem first, ParamClientBridge attr, out bool third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr._0002() != null)
			{
				if (attr._0002())
				{
					third = true;
					return attr.AssetClient();
				}
				third = false;
				return (IDictionary)attr._0002()(new object[0]);
			}
			if (attr.composerProperty)
			{
				third = true;
				return attr.AssetClient();
			}
			if (((ProcTest)attr)._0001() != null && (!attr._0007() || baseProperty._SerializerError == (AttributeStyle)1))
			{
				object obj = ((ProcTest)attr)._0001()();
				if (attr._0001())
				{
					obj = attr.CountClient(obj);
				}
				third = false;
				return (IDictionary)obj;
			}
			if (attr._0003())
			{
				third = true;
				return attr.AssetClient();
			}
			if (!attr._IssuerProperty)
			{
				throw StrategyError.PatchComposer(first, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)attr)._0002()));
			}
			throw StrategyError.PatchComposer(first, "Unable to find a default constructor to use for type {0}.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)attr)._0002()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ForgotBroadcaster(TagTestItem ident, ProcTest connection, object role)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(ident as IdentifierClientBridge, ident._0002(), "Started deserializing {0}".ListReader(CultureInfo.InvariantCulture, connection._0002())), null);
			}
			connection.DeleteClient(role, baseProperty.roleError);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void IncludeBroadcaster(TagTestItem instance, ProcTest ivk, object third)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(instance as IdentifierClientBridge, instance._0002(), "Finished deserializing {0}".ListReader(CultureInfo.InvariantCulture, ivk._0002())), null);
			}
			ivk.TestClient(third, baseProperty.roleError);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object PushBroadcaster(IDictionary setup, TagTestItem caller, ParamClientBridge field, ProductInstanceExpression first2, string key3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProcessComposer processComposer = setup as ProcessComposer;
			object obj = (processComposer != null) ? processComposer._0001() : setup;
			if (key3 != null)
			{
				ViewBroadcaster(caller, key3, obj);
			}
			ForgotBroadcaster(caller, field, obj);
			int flags_helper = caller._0003();
			if (field._0003() == null)
			{
				field._0002(DisableBroadcaster(field._0001()));
			}
			if (((InitializerTest)field)._0001() == null)
			{
				field._0001(DisableBroadcaster(field._0004()));
			}
			BroadcasterError broadcasterError = ((InitializerTest)field)._0001() ?? CompareBroadcaster(((InitializerTest)field)._0001(), null, field, first2);
			SettingsSerializeAs settingsSerializeAs = (field._0003() as ProccesorClassSpec)?._0001() ?? ((SettingsSerializeAs)0);
			bool flag = false;
			do
			{
				switch (caller._0001())
				{
				case WatcherComposer.PropertyName:
				{
					object obj2 = caller._0001();
					if (!ComputeBroadcaster(caller, obj2.ToString()))
					{
						try
						{
							try
							{
								switch (settingsSerializeAs)
								{
								case (SettingsSerializeAs)26:
								case (SettingsSerializeAs)27:
								{
									obj2 = (DescriptorIteratorMapping.RemoveProperty(obj2.ToString(), caller._0001(), caller._0003(), caller._0001(), out DateTime res) ? ((object)res) : CloneBroadcaster(caller, obj2, CultureInfo.InvariantCulture, field._0003(), field._0001()));
									break;
								}
								case (SettingsSerializeAs)28:
								case (SettingsSerializeAs)29:
								{
									obj2 = (DescriptorIteratorMapping.ChangeProperty(obj2.ToString(), caller._0003(), caller._0001(), out DateTimeOffset connection) ? ((object)connection) : CloneBroadcaster(caller, obj2, CultureInfo.InvariantCulture, field._0003(), field._0001()));
									break;
								}
								default:
									obj2 = CloneBroadcaster(caller, obj2, CultureInfo.InvariantCulture, field._0003(), field._0001());
									break;
								}
							}
							catch (Exception field2)
							{
								throw StrategyError.FindComposer(caller, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".SelectReader(CultureInfo.InvariantCulture, caller._0001(), field._0001()), field2);
							}
							if (!caller.PublishError(((InitializerTest)field)._0001(), broadcasterError != null))
							{
								throw StrategyError.PatchComposer(caller, "Unexpected end when deserializing object.");
							}
							object obj4 = setup[obj2] = ((broadcasterError == null || !broadcasterError._0002()) ? ResolveBroadcaster(caller, field._0004(), ((InitializerTest)field)._0001(), null, field, first2, null) : ReflectBroadcaster(broadcasterError, caller, field._0004(), null));
						}
						catch (Exception ident)
						{
							if (!CheckBroadcaster(obj, field, obj2, caller as IdentifierClientBridge, caller._0002(), ident))
							{
								throw;
							}
							PostBroadcaster(caller, excludetoken: true, flags_helper);
						}
					}
					break;
				}
				case WatcherComposer.EndObject:
					flag = true;
					break;
				default:
					throw StrategyError.PatchComposer(caller, "Unexpected token when deserializing object: " + caller._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (!flag && caller._0001());
			if (!flag)
			{
				AwakeBroadcaster(caller, field, obj, "Unexpected end when deserializing object.");
			}
			IncludeBroadcaster(caller, field, obj);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object PrepareBroadcaster(IList ident, TagTestItem cont, MessageTest third, ProductInstanceExpression first2, string reg3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int arrayRank = ((ProcTest)third)._0002().GetArrayRank();
			if (reg3 != null)
			{
				ViewBroadcaster(cont, reg3, ident);
			}
			ForgotBroadcaster(cont, third, ident);
			ProcTest procTest = DisableBroadcaster(third._0001());
			BroadcasterError broadcasterError = CompareBroadcaster(procTest, null, third, first2);
			int? num = null;
			Stack<IList> stack = new Stack<IList>();
			stack.Push(ident);
			IList list = ident;
			bool flag = false;
			do
			{
				int num2 = cont._0003();
				if (stack.Count == arrayRank)
				{
					try
					{
						if (cont.PublishError(procTest, broadcasterError != null))
						{
							switch (cont._0001())
							{
							case WatcherComposer.EndArray:
								stack.Pop();
								list = stack.Peek();
								num = null;
								break;
							default:
							{
								object value = (broadcasterError == null || !broadcasterError._0002()) ? ResolveBroadcaster(cont, third._0001(), procTest, null, third, first2, null) : ReflectBroadcaster(broadcasterError, cont, third._0001(), null);
								list.Add(value);
								break;
							}
							case WatcherComposer.Comment:
								break;
							}
							continue;
						}
					}
					catch (Exception ex)
					{
						QueueError queueError = cont.DestroyError(num2);
						if (!CheckBroadcaster(ident, third, queueError._AttrError, cont as IdentifierClientBridge, cont._0002(), ex))
						{
							throw;
						}
						PostBroadcaster(cont, excludetoken: true, num2 + 1);
						if (num.HasValue && num == queueError._AttrError)
						{
							throw StrategyError.FindComposer(cont, "Infinite loop detected from error handling.", ex);
						}
						num = queueError._AttrError;
						continue;
					}
					break;
				}
				if (!cont._0001())
				{
					break;
				}
				switch (cont._0001())
				{
				case WatcherComposer.StartArray:
				{
					IList list2 = new List<object>();
					list.Add(list2);
					stack.Push(list2);
					list = list2;
					break;
				}
				case WatcherComposer.EndArray:
					stack.Pop();
					if (stack.Count > 0)
					{
						list = stack.Peek();
					}
					else
					{
						flag = true;
					}
					break;
				default:
					throw StrategyError.PatchComposer(cont, "Unexpected token when deserializing multidimensional array: " + cont._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (!flag);
			if (!flag)
			{
				AwakeBroadcaster(cont, third, ident, "Unexpected end when deserializing array.");
			}
			IncludeBroadcaster(cont, third, ident);
			return ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AwakeBroadcaster(TagTestItem setup, ProcTest ivk, object serv, string cont2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				throw StrategyError.PatchComposer(setup, cont2);
			}
			catch (Exception ident)
			{
				if (!CheckBroadcaster(serv, ivk, null, setup as IdentifierClientBridge, setup._0002(), ident))
				{
					throw;
				}
				PostBroadcaster(setup, excludetoken: false, 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object UpdateBroadcaster(IList info, TagTestItem attr, MessageTest pool, ProductInstanceExpression map2, string var13)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManagerErrorFilter managerErrorFilter = info as ManagerErrorFilter;
			object obj = (managerErrorFilter != null) ? managerErrorFilter._0001() : info;
			if (var13 != null)
			{
				ViewBroadcaster(attr, var13, obj);
			}
			if (info.IsFixedSize)
			{
				attr.AssetError();
				return obj;
			}
			ForgotBroadcaster(attr, pool, obj);
			int num = attr._0003();
			if (((InitializerTest)pool)._0001() == null)
			{
				pool._0001(DisableBroadcaster(pool._0001()));
			}
			BroadcasterError broadcasterError = CompareBroadcaster(((InitializerTest)pool)._0001(), null, pool, map2);
			int? num2 = null;
			bool flag = false;
			do
			{
				try
				{
					if (attr.PublishError(((InitializerTest)pool)._0001(), broadcasterError != null))
					{
						switch (attr._0001())
						{
						case WatcherComposer.EndArray:
							flag = true;
							break;
						default:
						{
							object value = (broadcasterError == null || !broadcasterError._0002()) ? ResolveBroadcaster(attr, pool._0001(), ((InitializerTest)pool)._0001(), null, pool, map2, null) : ReflectBroadcaster(broadcasterError, attr, pool._0001(), null);
							info.Add(value);
							break;
						}
						case WatcherComposer.Comment:
							break;
						}
						continue;
					}
				}
				catch (Exception ex)
				{
					QueueError queueError = attr.DestroyError(num);
					if (!CheckBroadcaster(obj, pool, queueError._AttrError, attr as IdentifierClientBridge, attr._0002(), ex))
					{
						throw;
					}
					PostBroadcaster(attr, excludetoken: true, num + 1);
					if (num2.HasValue && num2 == queueError._AttrError)
					{
						throw StrategyError.FindComposer(attr, "Infinite loop detected from error handling.", ex);
					}
					num2 = queueError._AttrError;
					continue;
				}
				break;
			}
			while (!flag);
			if (!flag)
			{
				AwakeBroadcaster(attr, pool, obj, "Unexpected end when deserializing array.");
			}
			IncludeBroadcaster(attr, pool, obj);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ReadBroadcaster(TagTestItem init, CollectionProperty pol, ProductInstanceExpression third, string instance2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type serv = ((ProcTest)pol)._0002();
			if (!ConfigProperty._0002())
			{
				string asset = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				asset = asset.ListReader(CultureInfo.InvariantCulture, serv);
				throw StrategyError.PatchComposer(init, asset);
			}
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(init as IdentifierClientBridge, init._0002(), "Deserializing {0} using ISerializable constructor.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)pol)._0002())), null);
			}
			SerializationInfo serializationInfo = new SerializationInfo(((ProcTest)pol)._0002(), new InstanceEventConsumer(this, pol, third));
			bool flag = false;
			do
			{
				switch (init._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string text = init._0001().ToString();
					if (!init._0001())
					{
						throw StrategyError.PatchComposer(init, "Unexpected end when setting {0}'s value.".ListReader(CultureInfo.InvariantCulture, text));
					}
					serializationInfo.AddValue(text, ParserFilterResolver.SelectClass(init));
					break;
				}
				case WatcherComposer.EndObject:
					flag = true;
					break;
				default:
					throw StrategyError.PatchComposer(init, "Unexpected token when deserializing object: " + init._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (!flag && init._0001());
			if (!flag)
			{
				AwakeBroadcaster(init, pol, serializationInfo, "Unexpected end when deserializing object.");
			}
			if (!pol._IssuerProperty)
			{
				throw StrategyError.PatchComposer(init, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)pol)._0002()));
			}
			if (pol._0001() == null)
			{
				throw StrategyError.PatchComposer(init, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".ListReader(CultureInfo.InvariantCulture, serv));
			}
			object obj = pol._0001()(new object[2]
			{
				serializationInfo,
				baseProperty.roleError
			});
			if (instance2 != null)
			{
				ViewBroadcaster(init, instance2, obj);
			}
			ForgotBroadcaster(init, pol, obj);
			IncludeBroadcaster(init, pol, obj);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal object InterruptBroadcaster(ParserFilterResolver var1, Type token, CollectionProperty state, ProductInstanceExpression value2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProcTest procTest = DisableBroadcaster(token);
			BroadcasterError broadcasterError = CompareBroadcaster(procTest, null, state, value2);
			TagTestItem @class = var1.GetClass();
			@class.SortError();
			if (broadcasterError != null && broadcasterError._0002())
			{
				return ReflectBroadcaster(broadcasterError, @class, token, null);
			}
			return ResolveBroadcaster(@class, token, procTest, null, state, value2, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object CalcBroadcaster(TagTestItem v, ProducerProperty connection, ProductInstanceExpression filter, string attr2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!connection._IssuerProperty)
			{
				throw StrategyError.PatchComposer(v, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)connection)._0002()));
			}
			if (((ProcTest)connection)._0001() != null && (!connection._0007() || baseProperty._SerializerError == (AttributeStyle)1))
			{
				IDynamicMetaObjectProvider dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)((ProcTest)connection)._0001()();
				if (attr2 != null)
				{
					ViewBroadcaster(v, attr2, dynamicMetaObjectProvider);
				}
				ForgotBroadcaster(v, connection, dynamicMetaObjectProvider);
				int flags_helper = v._0003();
				bool flag = false;
				do
				{
					switch (v._0001())
					{
					case WatcherComposer.PropertyName:
					{
						string text = v._0001().ToString();
						try
						{
							if (!v._0001())
							{
								throw StrategyError.PatchComposer(v, "Unexpected end when setting {0}'s value.".ListReader(CultureInfo.InvariantCulture, text));
							}
							ProductInstanceExpression productInstanceExpression = connection._0001().SortClient(text);
							if (productInstanceExpression != null && productInstanceExpression._0003() && !productInstanceExpression._0001())
							{
								if (productInstanceExpression._0001() == null)
								{
									productInstanceExpression._0001(DisableBroadcaster(productInstanceExpression._0002()));
								}
								BroadcasterError visitor = CompareBroadcaster(productInstanceExpression._0001(), productInstanceExpression._0001(), null, null);
								if (!LogoutBroadcaster(productInstanceExpression, visitor, null, filter, v, dynamicMetaObjectProvider))
								{
									v.AssetError();
								}
							}
							else
							{
								Type type = RulesClientBridge.StartIssuer(v._0001()) ? v._0001() : typeof(IDynamicMetaObjectProvider);
								ProcTest procTest = DisableBroadcaster(type);
								BroadcasterError broadcasterError = CompareBroadcaster(procTest, null, null, filter);
								object consumer = (broadcasterError == null || !broadcasterError._0002()) ? ResolveBroadcaster(v, type, procTest, null, null, filter, null) : ReflectBroadcaster(broadcasterError, v, type, null);
								connection.ExcludeClient(dynamicMetaObjectProvider, text, consumer);
							}
						}
						catch (Exception ident)
						{
							if (!CheckBroadcaster(dynamicMetaObjectProvider, connection, text, v as IdentifierClientBridge, v._0002(), ident))
							{
								throw;
							}
							PostBroadcaster(v, excludetoken: true, flags_helper);
						}
						break;
					}
					case WatcherComposer.EndObject:
						flag = true;
						break;
					default:
						throw StrategyError.PatchComposer(v, "Unexpected token when deserializing object: " + v._0001());
					}
				}
				while (!flag && v._0001());
				if (!flag)
				{
					AwakeBroadcaster(v, connection, dynamicMetaObjectProvider, "Unexpected end when deserializing object.");
				}
				IncludeBroadcaster(v, connection, dynamicMetaObjectProvider);
				return dynamicMetaObjectProvider;
			}
			throw StrategyError.PatchComposer(v, "Unable to find a default constructor to use for type {0}.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)connection)._0002()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object InstantiateBroadcaster(TagTestItem ident, PrototypeFilterResolver selection, ProductInstanceExpression serv, GDBD.Specifications.AdapterClassSpec<object> visitor2, string pol3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(visitor2, "creator");
			bool flag = selection._0001() || ConnectBroadcaster(baseProperty._FactoryError, (ConnectActionCursor)2);
			Type pred = ((ProcTest)selection)._0002();
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				string selection2 = string.Join(", ", from instance in selection._0002()
					select instance._0001());
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(ident as IdentifierClientBridge, ident._0002(), "Deserializing {0} using creator with parameters: {1}.".SelectReader(CultureInfo.InvariantCulture, ((ProcTest)selection)._0002(), selection2)), null);
			}
			List<ModelEventEntry> list = ResetBroadcaster(selection, serv, ident, pred);
			if (flag)
			{
				foreach (ProductInstanceExpression current in selection._0001())
				{
					if (!current._0001() && list.All((ModelEventEntry P_0) => P_0.m_TokenProperty != current))
					{
						list.Add(new ModelEventEntry(current._0001())
						{
							m_TokenProperty = current,
							m_AccountProperty = (TaskbarItemProgressState)0
						});
					}
				}
			}
			object[] array = new object[selection._0002().Count];
			foreach (ModelEventEntry item in list)
			{
				if (flag && item.m_TokenProperty != null && !item.m_AccountProperty.HasValue)
				{
					object singletonProperty = item.singletonProperty;
					TaskbarItemProgressState value;
					if (singletonProperty == null)
					{
						value = (TaskbarItemProgressState)1;
					}
					else
					{
						string text = singletonProperty as string;
						value = ((text == null) ? ((TaskbarItemProgressState)2) : (FillBroadcaster(item.m_TokenProperty._0002(), item.m_TokenProperty._0001(), text) ? ((TaskbarItemProgressState)1) : ((TaskbarItemProgressState)2)));
					}
					item.m_AccountProperty = value;
				}
				ProductInstanceExpression productInstanceExpression = item.m_DispatcherProperty;
				if (productInstanceExpression == null && item.m_TokenProperty != null)
				{
					productInstanceExpression = selection._0002().CountReader((ProductInstanceExpression res) => res._0001(), item.m_TokenProperty._0002());
				}
				if (productInstanceExpression != null && !productInstanceExpression._0001())
				{
					if (flag && (item.m_AccountProperty == (TaskbarItemProgressState)0 || item.m_AccountProperty == (TaskbarItemProgressState)1))
					{
						if (productInstanceExpression._0001() == null)
						{
							productInstanceExpression._0001(DisableBroadcaster(productInstanceExpression._0002()));
						}
						if (ConnectBroadcaster(productInstanceExpression._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)2))
						{
							item.singletonProperty = CloneBroadcaster(ident, productInstanceExpression.InitClient(), CultureInfo.InvariantCulture, productInstanceExpression._0001(), productInstanceExpression._0002());
						}
					}
					int num = selection._0002().IndexOf(productInstanceExpression);
					array[num] = item.singletonProperty;
					item.modelProperty = true;
				}
			}
			object obj = visitor2(array);
			if (pol3 != null)
			{
				ViewBroadcaster(ident, pol3, obj);
			}
			ForgotBroadcaster(ident, selection, obj);
			foreach (ModelEventEntry item2 in list)
			{
				if (!item2.modelProperty && item2.m_TokenProperty != null && !item2.m_TokenProperty._0001() && item2.m_AccountProperty != (TaskbarItemProgressState)0)
				{
					ProductInstanceExpression tokenProperty = item2.m_TokenProperty;
					object singletonProperty2 = item2.singletonProperty;
					if (MoveBroadcaster(tokenProperty, selection, singletonProperty2))
					{
						tokenProperty._0001()._0001(obj, singletonProperty2);
						item2.modelProperty = true;
					}
					else if (!tokenProperty._0003() && singletonProperty2 != null)
					{
						ProcTest procTest = baseProperty.listenerError._0001(tokenProperty._0002());
						if (procTest._ErrorProperty == (ParameterFilterResolver)2)
						{
							MessageTest messageTest = (MessageTest)procTest;
							if (messageTest._0004() && !messageTest.composerProperty)
							{
								object obj2 = tokenProperty._0001()._0001(obj);
								if (obj2 != null)
								{
									messageTest = (MessageTest)VerifyBroadcaster(obj2.GetType());
									object obj3;
									if (!messageTest._0003())
									{
										obj3 = (IList)obj2;
									}
									else
									{
										IList list2 = messageTest.CalculateClient(obj2);
										obj3 = list2;
									}
									IList list3 = (IList)obj3;
									if (!list3.IsFixedSize)
									{
										object obj4;
										if (!messageTest._0003())
										{
											obj4 = (IList)singletonProperty2;
										}
										else
										{
											IList list2 = messageTest.CalculateClient(singletonProperty2);
											obj4 = list2;
										}
										foreach (object item3 in (IEnumerable)obj4)
										{
											list3.Add(item3);
										}
									}
								}
							}
						}
						else if (procTest._ErrorProperty == (ParameterFilterResolver)5)
						{
							ParamClientBridge paramClientBridge = (ParamClientBridge)procTest;
							if (!paramClientBridge.composerProperty)
							{
								object obj5 = tokenProperty._0001()._0001(obj);
								if (obj5 != null)
								{
									object obj6;
									if (!paramClientBridge._0001())
									{
										obj6 = (IDictionary)obj5;
									}
									else
									{
										IDictionary dictionary = paramClientBridge.CountClient(obj5);
										obj6 = dictionary;
									}
									IDictionary dictionary2 = (IDictionary)obj6;
									object obj7;
									if (!paramClientBridge._0001())
									{
										obj7 = (IDictionary)singletonProperty2;
									}
									else
									{
										IDictionary dictionary = paramClientBridge.CountClient(singletonProperty2);
										obj7 = dictionary;
									}
									foreach (DictionaryEntry item4 in (IDictionary)obj7)
									{
										dictionary2[item4.Key] = item4.Value;
									}
								}
							}
						}
						item2.modelProperty = true;
					}
				}
			}
			if (selection._0001() != null)
			{
				foreach (ModelEventEntry item5 in list)
				{
					if (!item5.modelProperty && item5.m_AccountProperty != (TaskbarItemProgressState)0)
					{
						selection._0001()(obj, item5.adapterProperty, item5.singletonProperty);
					}
				}
			}
			if (flag)
			{
				foreach (ModelEventEntry item6 in list)
				{
					if (item6.m_TokenProperty != null)
					{
						RateBroadcaster(obj, ident, selection, ident._0003(), item6.m_TokenProperty, item6.m_AccountProperty.GetValueOrDefault(), !item6.modelProperty);
					}
				}
			}
			IncludeBroadcaster(ident, selection, obj);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object ReflectBroadcaster(BroadcasterError task, TagTestItem cfg, Type rule, object instance2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(cfg as IdentifierClientBridge, cfg._0002(), "Started deserializing {0} with converter {1}.".SelectReader(CultureInfo.InvariantCulture, rule, task.GetType())), null);
			}
			object result = task._0001(cfg, rule, instance2, FindBroadcaster());
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(cfg as IdentifierClientBridge, cfg._0002(), "Finished deserializing {0} with converter {1}.".SelectReader(CultureInfo.InvariantCulture, rule, task.GetType())), null);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<ModelEventEntry> ResetBroadcaster(PrototypeFilterResolver last, ProductInstanceExpression selection, TagTestItem role, Type pred2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<ModelEventEntry> list = new List<ModelEventEntry>();
			bool flag = false;
			do
			{
				switch (role._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string text = role._0001().ToString();
					ModelEventEntry modelEventEntry = new ModelEventEntry(text)
					{
						m_DispatcherProperty = last._0002().SortClient(text),
						m_TokenProperty = last._0001().SortClient(text)
					};
					list.Add(modelEventEntry);
					ProductInstanceExpression productInstanceExpression = modelEventEntry.m_DispatcherProperty ?? modelEventEntry.m_TokenProperty;
					if (productInstanceExpression != null && !productInstanceExpression._0001())
					{
						if (productInstanceExpression._0001() == null)
						{
							productInstanceExpression._0001(DisableBroadcaster(productInstanceExpression._0002()));
						}
						BroadcasterError broadcasterError = CompareBroadcaster(productInstanceExpression._0001(), productInstanceExpression._0001(), last, selection);
						if (!role.PublishError(productInstanceExpression._0001(), broadcasterError != null))
						{
							throw StrategyError.PatchComposer(role, "Unexpected end when setting {0}'s value.".ListReader(CultureInfo.InvariantCulture, text));
						}
						if (broadcasterError != null && broadcasterError._0002())
						{
							modelEventEntry.singletonProperty = ReflectBroadcaster(broadcasterError, role, productInstanceExpression._0002(), null);
						}
						else
						{
							modelEventEntry.singletonProperty = ResolveBroadcaster(role, productInstanceExpression._0002(), productInstanceExpression._0001(), productInstanceExpression, last, selection, null);
						}
						break;
					}
					if (!role._0001())
					{
						throw StrategyError.PatchComposer(role, "Unexpected end when setting {0}'s value.".ListReader(CultureInfo.InvariantCulture, text));
					}
					if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
					{
						containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(role as IdentifierClientBridge, role._0002(), "Could not find member '{0}' on {1}.".SelectReader(CultureInfo.InvariantCulture, text, ((ProcTest)last)._0002())), null);
					}
					if ((last._0001() ?? baseProperty._ExceptionError) == (InternalArrayTypeE)1)
					{
						throw StrategyError.PatchComposer(role, "Could not find member '{0}' on object of type '{1}'".SelectReader(CultureInfo.InvariantCulture, text, pred2.Name));
					}
					if (last._0001() != null)
					{
						modelEventEntry.singletonProperty = SetBroadcaster(last, selection, role);
					}
					else
					{
						role.AssetError();
					}
					break;
				}
				case WatcherComposer.EndObject:
					flag = true;
					break;
				default:
					throw StrategyError.PatchComposer(role, "Unexpected token when deserializing object: " + role._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (!flag && role._0001());
			if (!flag)
			{
				AwakeBroadcaster(role, last, null, "Unexpected end when deserializing object.");
			}
			return list;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object RegisterBroadcaster(TagTestItem i, PrototypeFilterResolver cont, [_0008._0012(2)] ProductInstanceExpression _0004, [_0008._0012(2)] ProductInstanceExpression _0005, [_0008._0012(2)] string _0006, out bool setup4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object obj = null;
			if (cont._0001() != null)
			{
				if (cont._0002().Count > 0)
				{
					setup4 = true;
					return InstantiateBroadcaster(i, cont, _0004, cont._0001(), _0006);
				}
				obj = cont._0001()(ObserverIteratorMapping.CheckProperty<object>());
			}
			else if (((ProcTest)cont)._0001() != null && (!cont._0007() || baseProperty._SerializerError == (AttributeStyle)1 || cont._0002() == null))
			{
				obj = ((ProcTest)cont)._0001()();
			}
			else if (cont._0002() != null)
			{
				setup4 = true;
				return InstantiateBroadcaster(i, cont, _0004, cont._0002(), _0006);
			}
			if (obj == null)
			{
				if (!cont._IssuerProperty)
				{
					throw StrategyError.PatchComposer(i, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)cont)._0002()));
				}
				throw StrategyError.PatchComposer(i, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)cont)._0002()));
			}
			setup4 = false;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object RestartBroadcaster(object value, TagTestItem result, PrototypeFilterResolver util, ProductInstanceExpression reg2, string v3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ForgotBroadcaster(result, util, value);
			Dictionary<ProductInstanceExpression, TaskbarItemProgressState> dictionary = (util._0001() || ConnectBroadcaster(baseProperty._FactoryError, (ConnectActionCursor)2)) ? util._0001().ToDictionary((ProductInstanceExpression i) => i, (ProductInstanceExpression init) => (TaskbarItemProgressState)0) : null;
			if (v3 != null)
			{
				ViewBroadcaster(result, v3, value);
			}
			int num = result._0003();
			bool flag = false;
			do
			{
				switch (result._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string text = result._0001().ToString();
					if (!ComputeBroadcaster(result, text))
					{
						try
						{
							ProductInstanceExpression productInstanceExpression = util._0001().SortClient(text);
							if (productInstanceExpression == null)
							{
								if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
								{
									containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(result as IdentifierClientBridge, result._0002(), "Could not find member '{0}' on {1}".SelectReader(CultureInfo.InvariantCulture, text, ((ProcTest)util)._0002())), null);
								}
								if ((util._0001() ?? baseProperty._ExceptionError) == (InternalArrayTypeE)1)
								{
									throw StrategyError.PatchComposer(result, "Could not find member '{0}' on object of type '{1}'".SelectReader(CultureInfo.InvariantCulture, text, ((ProcTest)util)._0002().Name));
								}
								if (result._0001())
								{
									DestroyBroadcaster(util, reg2, result, text, value);
								}
							}
							else if (productInstanceExpression._0001() || !SearchBroadcaster(result, productInstanceExpression, value))
							{
								if (result._0001())
								{
									RemoveBroadcaster(result, productInstanceExpression, dictionary);
									DestroyBroadcaster(util, reg2, result, text, value);
								}
							}
							else
							{
								if (productInstanceExpression._0001() == null)
								{
									productInstanceExpression._0001(DisableBroadcaster(productInstanceExpression._0002()));
								}
								BroadcasterError broadcasterError = CompareBroadcaster(productInstanceExpression._0001(), productInstanceExpression._0001(), util, reg2);
								if (!result.PublishError(productInstanceExpression._0001(), broadcasterError != null))
								{
									throw StrategyError.PatchComposer(result, "Unexpected end when setting {0}'s value.".ListReader(CultureInfo.InvariantCulture, text));
								}
								RemoveBroadcaster(result, productInstanceExpression, dictionary);
								if (!LogoutBroadcaster(productInstanceExpression, broadcasterError, util, reg2, result, value))
								{
									DestroyBroadcaster(util, reg2, result, text, value);
								}
							}
						}
						catch (Exception ident)
						{
							if (!CheckBroadcaster(value, util, text, result as IdentifierClientBridge, result._0002(), ident))
							{
								throw;
							}
							PostBroadcaster(result, excludetoken: true, num);
						}
					}
					break;
				}
				case WatcherComposer.EndObject:
					flag = true;
					break;
				default:
					throw StrategyError.PatchComposer(result, "Unexpected token when deserializing object: " + result._0001());
				case WatcherComposer.Comment:
					break;
				}
			}
			while (!flag && result._0001());
			if (!flag)
			{
				AwakeBroadcaster(result, util, value, "Unexpected end when deserializing object.");
			}
			if (dictionary != null)
			{
				foreach (KeyValuePair<ProductInstanceExpression, TaskbarItemProgressState> item in dictionary)
				{
					ProductInstanceExpression key = item.Key;
					TaskbarItemProgressState value2 = item.Value;
					RateBroadcaster(value, result, util, num, key, value2, allowitem5: true);
				}
			}
			IncludeBroadcaster(result, util, value);
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool SearchBroadcaster(TagTestItem config, ProductInstanceExpression result, object comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (result._0002() == null)
			{
				return true;
			}
			bool flag = result._0002()(comp);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
			{
				containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, config._0002(), "ShouldDeserialize result for property '{0}' on {1}: {2}".DeleteReader(CultureInfo.InvariantCulture, result._0001(), result._0001(), flag)), null);
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ComputeBroadcaster(TagTestItem ident, string b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (baseProperty._0001() == (CacheActions)1)
			{
				switch (b)
				{
				case "$id":
				case "$ref":
				case "$type":
				case "$values":
					ident.AssetError();
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DestroyBroadcaster(PrototypeFilterResolver def, ProductInstanceExpression pol, TagTestItem temp, string visitor2, object second3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def._0001() != null)
			{
				try
				{
					object obj = SetBroadcaster(def, pol, temp);
					def._0001()(second3, visitor2, obj);
				}
				catch (Exception field)
				{
					throw StrategyError.FindComposer(temp, "Error setting value in extension data for type '{0}'.".ListReader(CultureInfo.InvariantCulture, ((ProcTest)def)._0002()), field);
				}
			}
			else
			{
				temp.AssetError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object SetBroadcaster(PrototypeFilterResolver last, ProductInstanceExpression connection, TagTestItem filter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (last.m_DefinitionProperty)
			{
				return ParserFilterResolver.SelectClass(filter);
			}
			return ResolveBroadcaster(filter, null, null, null, last, connection, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RateBroadcaster(object init, TagTestItem ivk, PrototypeFilterResolver rule, int indexOf_col2, ProductInstanceExpression reference3, TaskbarItemProgressState cust4, bool allowitem5)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (cust4 == (TaskbarItemProgressState)0 || cust4 == (TaskbarItemProgressState)1)
			{
				try
				{
					SpecificationTestItem specificationTestItem = (!reference3._0001()) ? (reference3.contextProperty ?? rule._0001().GetValueOrDefault()) : ((SpecificationTestItem)0);
					switch (cust4)
					{
					case (TaskbarItemProgressState)0:
						if (specificationTestItem == (SpecificationTestItem)1 || specificationTestItem == (SpecificationTestItem)2)
						{
							throw StrategyError.PatchComposer(ivk, "Required property '{0}' not found in JSON.".ListReader(CultureInfo.InvariantCulture, reference3._0001()));
						}
						if (allowitem5 && !reference3._0001())
						{
							if (reference3._0001() == null)
							{
								reference3._0001(DisableBroadcaster(reference3._0002()));
							}
							if (ConnectBroadcaster(reference3._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)2) && reference3._0003())
							{
								reference3._0001()._0001(init, CloneBroadcaster(ivk, reference3.InitClient(), CultureInfo.InvariantCulture, reference3._0001(), reference3._0002()));
							}
						}
						break;
					case (TaskbarItemProgressState)1:
						switch (specificationTestItem)
						{
						case (SpecificationTestItem)2:
							throw StrategyError.PatchComposer(ivk, "Required property '{0}' expects a value but got null.".ListReader(CultureInfo.InvariantCulture, reference3._0001()));
						case (SpecificationTestItem)3:
							throw StrategyError.PatchComposer(ivk, "Required property '{0}' expects a non-null value.".ListReader(CultureInfo.InvariantCulture, reference3._0001()));
						}
						break;
					}
				}
				catch (Exception ident)
				{
					if (!CheckBroadcaster(init, rule, reference3._0001(), ivk as IdentifierClientBridge, ivk._0002(), ident))
					{
						throw;
					}
					PostBroadcaster(ivk, excludetoken: true, indexOf_col2);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveBroadcaster(TagTestItem asset, ProductInstanceExpression selection, Dictionary<ProductInstanceExpression, TaskbarItemProgressState> serv)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (selection != null && serv != null)
			{
				TaskbarItemProgressState value;
				switch (asset._0001())
				{
				case WatcherComposer.String:
					value = (FillBroadcaster(selection._0002(), selection._0001(), (string)asset._0001()) ? ((TaskbarItemProgressState)1) : ((TaskbarItemProgressState)2));
					break;
				case WatcherComposer.Null:
				case WatcherComposer.Undefined:
					value = (TaskbarItemProgressState)1;
					break;
				default:
					value = (TaskbarItemProgressState)2;
					break;
				}
				serv[selection] = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PostBroadcaster(TagTestItem v, bool excludetoken, int flags_helper)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			LoginBroadcaster();
			if (excludetoken)
			{
				v.AssetError();
				while (v._0003() > flags_helper && v._0001())
				{
				}
			}
		}
	}
}
