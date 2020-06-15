using _0008;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Rules
{
	[_0008._0012(0)]
	internal sealed class ValueIssuer : BroadcasterError
	{
		[_0008._0012(0)]
		internal sealed class UtilsClientBridge
		{
			public readonly ParamsComposerWorker _ParserIssuer;

			public readonly List<FactoryDicCandidate> m_StatusIssuer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UtilsClientBridge(ParamsComposerWorker asset, List<FactoryDicCandidate> visitor)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				_ParserIssuer = asset;
				m_StatusIssuer = visitor;
			}
		}

		[_0008._0012(0)]
		internal sealed class FactoryDicCandidate
		{
			public readonly int pageIssuer;

			public readonly string _HelperIssuer;

			public readonly PropertyInfo[] exceptionIssuer;

			public readonly ParamsComposerWorker attributeIssuer;

			public readonly ParamsComposerWorker m_DatabaseIssuer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FactoryDicCandidate(int endspec, string ivk, PropertyInfo[] comp, ParamsComposerWorker result2, ParamsComposerWorker ord3)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				pageIssuer = endspec;
				_HelperIssuer = ivk;
				exceptionIssuer = comp;
				attributeIssuer = result2;
				m_DatabaseIssuer = ord3;
			}
		}

		[CompilerGenerated]
		private sealed class _0003
		{
			public int _0001;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0003()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(FactoryDicCandidate P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0.pageIssuer == this._0001;
			}
		}

		[CompilerGenerated]
		private sealed class _0004
		{
			[_0008._0012(0)]
			public string _0001;

			[_0008._0012(0)]
			public Func<FactoryDicCandidate, bool> _0002;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public _0004()
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool _0001(FactoryDicCandidate P_0)
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return P_0._HelperIssuer == this._0001;
			}
		}

		private static readonly Newtonsoft.Database.DispatcherEventEntry<Type, UtilsClientBridge> m_ParameterIssuer;

		private static readonly Newtonsoft.Database.DispatcherEventEntry<Type, Type> m_PrototypeIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Type ComputeRequest(Type param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object arg = ((object[])PropertyTest._0001()._0002()(null, new object[2]
			{
				param,
				null
			})).First();
			return (Type)PropertyTest._0001()._0001()(arg);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static UtilsClientBridge DestroyRequest(Type last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			UtilsClientBridge utilsClientBridge = new UtilsClientBridge((ParamsComposerWorker)PropertyTest._0001()._0003()(null, new object[2]
			{
				last,
				null
			}), new List<FactoryDicCandidate>());
			object[] array = (object[])PropertyTest._0001()._0002()(null, new object[2]
			{
				last,
				null
			});
			foreach (object obj in array)
			{
				FactoryDicCandidate item = new FactoryDicCandidate((int)PropertyTest._0001()._0003()(obj), (string)PropertyTest._0001()._0002()(obj), (PropertyInfo[])PropertyTest._0001()._0006()(obj, new object[0]), (ParamsComposerWorker)PropertyTest._0001()._0004()(null, new object[2]
				{
					obj,
					null
				}), (ParamsComposerWorker)PropertyTest._0001()._0005()(null, new object[2]
				{
					obj,
					null
				}));
				utilsClientBridge.m_StatusIssuer.Add(item);
			}
			return utilsClientBridge;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher v, object ivk, PrototypeError util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ivk == null)
			{
				v._0008();
				return;
			}
			PublisherRequestStrategy publisherRequestStrategy = util._0001() as PublisherRequestStrategy;
			Type res = m_PrototypeIssuer.InitReader(ivk.GetType());
			UtilsClientBridge utilsClientBridge = m_ParameterIssuer.InitReader(res);
			int num = (int)utilsClientBridge._ParserIssuer.ConnectIssuer(new object[1]
			{
				ivk
			});
			FactoryDicCandidate factoryDicCandidate = utilsClientBridge.m_StatusIssuer.Single((FactoryDicCandidate P_0) => P_0.pageIssuer == num);
			v._0002();
			v._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Case") : "Case");
			v._0004(factoryDicCandidate._HelperIssuer);
			if (factoryDicCandidate.exceptionIssuer != null && factoryDicCandidate.exceptionIssuer.Length != 0)
			{
				object[] obj = (object[])factoryDicCandidate.attributeIssuer.ConnectIssuer(new object[1]
				{
					ivk
				});
				v._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Fields") : "Fields");
				v._0003();
				object[] array = obj;
				foreach (object reg in array)
				{
					util.FlushComposer(v, reg);
				}
				v._000F();
			}
			v._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem ident, Type b, object field, PrototypeError config2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident._0001() == WatcherComposer.Null)
			{
				return null;
			}
			FactoryDicCandidate factoryDicCandidate = null;
			string text = null;
			InstanceClassDispatcher instanceClassDispatcher = null;
			ident.SortError();
			while (ident._0001() == WatcherComposer.PropertyName)
			{
				string text2 = ident._0001().ToString();
				if (string.Equals(text2, "Case", StringComparison.OrdinalIgnoreCase))
				{
					ident.SortError();
					UtilsClientBridge utilsClientBridge = m_ParameterIssuer.InitReader(b);
					text = ident._0001().ToString();
					factoryDicCandidate = utilsClientBridge.m_StatusIssuer.SingleOrDefault((FactoryDicCandidate P_0) => P_0._HelperIssuer == text);
					if (factoryDicCandidate == null)
					{
						throw StrategyError.PatchComposer(ident, "No union type found with the name '{0}'.".ListReader(CultureInfo.InvariantCulture, text));
					}
				}
				else
				{
					if (!string.Equals(text2, "Fields", StringComparison.OrdinalIgnoreCase))
					{
						throw StrategyError.PatchComposer(ident, "Unexpected property '{0}' found when reading union.".ListReader(CultureInfo.InvariantCulture, text2));
					}
					ident.SortError();
					if (ident._0001() != WatcherComposer.StartArray)
					{
						throw StrategyError.PatchComposer(ident, "Union fields must been an array.");
					}
					instanceClassDispatcher = (InstanceClassDispatcher)ParserFilterResolver.SelectClass(ident);
				}
				ident.SortError();
			}
			if (factoryDicCandidate == null)
			{
				throw StrategyError.PatchComposer(ident, "No '{0}' property with union name found.".ListReader(CultureInfo.InvariantCulture, "Case"));
			}
			object[] array = new object[factoryDicCandidate.exceptionIssuer.Length];
			if (factoryDicCandidate.exceptionIssuer.Length != 0 && instanceClassDispatcher == null)
			{
				throw StrategyError.PatchComposer(ident, "No '{0}' property with union fields found.".ListReader(CultureInfo.InvariantCulture, "Fields"));
			}
			if (instanceClassDispatcher != null)
			{
				if (factoryDicCandidate.exceptionIssuer.Length != instanceClassDispatcher.get_Count())
				{
					throw StrategyError.PatchComposer(ident, "The number of field values does not match the number of properties defined by union '{0}'.".ListReader(CultureInfo.InvariantCulture, text));
				}
				for (int i = 0; i < instanceClassDispatcher.get_Count(); i++)
				{
					ParserFilterResolver parserFilterResolver = instanceClassDispatcher[i];
					PropertyInfo propertyInfo = factoryDicCandidate.exceptionIssuer[i];
					array[i] = parserFilterResolver.ListClass(propertyInfo.PropertyType, config2);
				}
			}
			object[] task = new object[1]
			{
				array
			};
			return factoryDicCandidate.m_DatabaseIssuer.ConnectIssuer(task);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (typeof(IEnumerable).IsAssignableFrom(def))
			{
				return false;
			}
			object[] customAttributes = def.GetCustomAttributes(inherit: true);
			bool flag = false;
			object[] array = customAttributes;
			for (int i = 0; i < array.Length; i++)
			{
				Type type = array[i].GetType();
				if (type.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
				{
					PropertyTest.MoveIssuer(type.RevertReader());
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return false;
			}
			return (bool)PropertyTest._0001()._0001()(null, new object[2]
			{
				def,
				null
			});
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ValueIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_ParameterIssuer = new Newtonsoft.Database.DispatcherEventEntry<Type, UtilsClientBridge>(DestroyRequest);
			m_PrototypeIssuer = new Newtonsoft.Database.DispatcherEventEntry<Type, Type>(ComputeRequest);
		}
	}
}
