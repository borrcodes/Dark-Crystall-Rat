using _0008;
using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Importers;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Mocks;
using GDBD.Specifications;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Common;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace Newtonsoft.Expressions
{
	[_0008._0012(0)]
	internal sealed class InterceptorInstanceExpression : RuleTestItem
	{
		[_0008._0012(2)]
		private Type _VisitorProperty;

		private int globalProperty;

		private readonly List<object> wrapperProperty;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InterceptorInstanceExpression(PrototypeError config)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			wrapperProperty = new List<object>();
			base._002Ector(config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ListBroadcaster(RecordClassDispatcher def, object selection, Type c)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (def == null)
			{
				throw new ArgumentNullException("jsonWriter");
			}
			_VisitorProperty = c;
			globalProperty = wrapperProperty.Count + 1;
			ProcTest procTest = DeleteBroadcaster(selection);
			try
			{
				if (CountBroadcaster(selection, null, procTest, null, null))
				{
					QueryBroadcaster(def, selection);
				}
				else
				{
					InvokeBroadcaster(def, selection, procTest, null, null, null);
				}
			}
			catch (Exception ident)
			{
				if (!CheckBroadcaster(null, procTest, null, null, def._0002(), ident))
				{
					LoginBroadcaster();
					throw;
				}
				EnableClass(def, 0);
			}
			finally
			{
				_VisitorProperty = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private AlgoInstanceExpression SelectBroadcaster()
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
		private ProcTest DeleteBroadcaster(object value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (value == null)
			{
				return null;
			}
			return TestBroadcaster(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ProcTest TestBroadcaster(object ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return baseProperty.listenerError._0001(ident.GetType());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConcatBroadcaster(RecordClassDispatcher def, object selection, ProccesorClassSpec third, ProductInstanceExpression item2, InitializerTest setup3, ProductInstanceExpression attr4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (third._0001() == (SettingsSerializeAs)40 && RunClass((SparklineAxisMinMaxValues)1, third, item2, setup3, attr4))
			{
				def._0002();
				WriteBroadcaster(def, ((ProcTest)third)._0003());
				def._0001("$value", injectcust: false);
				RecordClassDispatcher.ComputeTest(def, third._0001(), selection);
				def._0011();
			}
			else
			{
				RecordClassDispatcher.ComputeTest(def, third._0001(), selection);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InvokeBroadcaster(RecordClassDispatcher last, object b, ProcTest proc, ProductInstanceExpression second2, InitializerTest second3, ProductInstanceExpression vis4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (b == null)
			{
				last._0008();
				return;
			}
			BroadcasterError broadcasterError = second2?._0001() ?? vis4?._0002() ?? second3?._0001() ?? proc._0002() ?? baseProperty.CloneComposer(proc._0002()) ?? proc._0003();
			if (broadcasterError != null && broadcasterError._0001())
			{
				DisableClass(last, broadcasterError, b, proc, second3, vis4);
				return;
			}
			switch (proc._ErrorProperty)
			{
			case (ParameterFilterResolver)1:
				DefineBroadcaster(last, b, (PrototypeFilterResolver)proc, second2, second3, vis4);
				break;
			case (ParameterFilterResolver)2:
			{
				MessageTest messageTest = (MessageTest)proc;
				if (!messageTest._0001())
				{
					VerifyClass(last, (IEnumerable)b, messageTest, second2, second3, vis4);
				}
				else
				{
					PatchClass(last, (Array)b, messageTest, second2, second3, vis4);
				}
				break;
			}
			case (ParameterFilterResolver)3:
				ConcatBroadcaster(last, b, (ProccesorClassSpec)proc, second2, second3, vis4);
				break;
			case (ParameterFilterResolver)4:
				SetupBroadcaster(last, b, (StubIteratorMapping)proc);
				break;
			case (ParameterFilterResolver)5:
			{
				ParamClientBridge paramClientBridge = (ParamClientBridge)proc;
				IDictionary dictionary = b as IDictionary;
				IDictionary attr;
				if (dictionary == null)
				{
					IDictionary dictionary2 = paramClientBridge.CountClient(b);
					attr = dictionary2;
				}
				else
				{
					attr = dictionary;
				}
				CompareClass(last, attr, paramClientBridge, second2, second3, vis4);
				break;
			}
			case (ParameterFilterResolver)6:
				ResolveClass(last, (IDynamicMetaObjectProvider)b, (ProducerProperty)proc, second2, second3, vis4);
				break;
			case (ParameterFilterResolver)7:
				OrderClass(last, (ISerializable)b, (CollectionProperty)proc, second2, second3, vis4);
				break;
			case (ParameterFilterResolver)8:
				((ParserFilterResolver)b)._0001(last, baseProperty._0001().ToArray());
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool? PrintBroadcaster(ProcTest v, ProductInstanceExpression cfg, InitializerTest serv, ProductInstanceExpression param2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool? result = null;
			if (cfg != null)
			{
				result = cfg._0001();
			}
			if (!result.HasValue && param2 != null)
			{
				result = param2._0002();
			}
			if (!result.HasValue && serv != null)
			{
				result = serv._0001();
			}
			if (!result.HasValue)
			{
				result = v._0002();
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CountBroadcaster(object config, ProductInstanceExpression col, ProcTest dic, InitializerTest asset2, ProductInstanceExpression vis3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config == null)
			{
				return false;
			}
			if (dic._ErrorProperty == (ParameterFilterResolver)3 || dic._ErrorProperty == (ParameterFilterResolver)4)
			{
				return false;
			}
			bool? flag = PrintBroadcaster(dic, col, asset2, vis3);
			if (!flag.HasValue)
			{
				flag = ((dic._ErrorProperty == (ParameterFilterResolver)2) ? new bool?(LoginClass(baseProperty.m_PageError, (TaskListAnnotation)2)) : new bool?(LoginClass(baseProperty.m_PageError, (TaskListAnnotation)1)));
			}
			if (!flag.GetValueOrDefault())
			{
				return false;
			}
			return baseProperty.StopComposer()._0001((object)this, config);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool AssetBroadcaster(object asset, PrototypeFilterResolver cont, ProductInstanceExpression consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (asset == null && WriteClient(cont, consumer) == (ApplicationState)1)
			{
				return false;
			}
			if (RevertBroadcaster(consumer._0001().GetValueOrDefault(baseProperty._FactoryError), (ConnectActionCursor)1) && CustomerListAnnotation.TestIssuer(asset, consumer.InitClient()))
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CustomizeBroadcaster(RecordClassDispatcher res, object pol, ProductInstanceExpression filter, ProcTest second2, InitializerTest cfg3, ProductInstanceExpression visitor4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (pol == null)
			{
				return true;
			}
			if (second2._ErrorProperty == (ParameterFilterResolver)3 || second2._ErrorProperty == (ParameterFilterResolver)4)
			{
				return true;
			}
			FacadeComposer? facadeComposer = null;
			if (filter != null)
			{
				facadeComposer = filter._0001();
			}
			if (!facadeComposer.HasValue && visitor4 != null)
			{
				facadeComposer = visitor4._0002();
			}
			if (!facadeComposer.HasValue && cfg3 != null)
			{
				facadeComposer = cfg3._0001();
			}
			if ((baseProperty.m_SpecificationError != null) ? wrapperProperty.CollectTest(pol, baseProperty.m_SpecificationError) : wrapperProperty.Contains(pol))
			{
				string str = "Self referencing loop detected";
				if (filter != null)
				{
					str += " for property '{0}'".ListReader(CultureInfo.InvariantCulture, filter._0001());
				}
				str += " with type '{0}'.".ListReader(CultureInfo.InvariantCulture, pol.GetType());
				switch (facadeComposer.GetValueOrDefault(baseProperty.helperError))
				{
				case (FacadeComposer)0:
					throw StrategyError.ValidateComposer(null, res._0001(), str, null);
				case (FacadeComposer)1:
					if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
					{
						containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, res._0002(), str + ". Skipping serializing self referenced value."), null);
					}
					return false;
				case (FacadeComposer)2:
					if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
					{
						containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, res._0002(), str + ". Serializing self referenced value."), null);
					}
					return true;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void QueryBroadcaster(RecordClassDispatcher var1, object cust)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = CancelBroadcaster(var1, cust);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(null, var1._0002(), "Writing object reference to Id '{0}' for {1}.".SelectReader(CultureInfo.InvariantCulture, text, cust.GetType())), null);
			}
			var1._0002();
			var1._0001("$ref", injectcust: false);
			var1._0004(text);
			var1._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string CancelBroadcaster(RecordClassDispatcher info, object attr)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			try
			{
				return baseProperty.StopComposer()._0001((object)this, attr);
			}
			catch (Exception setup)
			{
				throw StrategyError.ValidateComposer(null, info._0001(), "Error writing object reference for '{0}'.".ListReader(CultureInfo.InvariantCulture, attr.GetType()), setup);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ExcludeBroadcaster(object i, Type token, [ConsumerBroadcasterDispatcher(true)] [_0008._0012(2)] out string _0004)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ConfigProperty.StopClass(token, out TypeConverter token2))
			{
				_0004 = token2.ConvertToInvariantString(i);
				return true;
			}
			Type type = i as Type;
			if ((object)type != null)
			{
				_0004 = type.AssemblyQualifiedName;
				return true;
			}
			_0004 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupBroadcaster(RecordClassDispatcher init, object pol, StubIteratorMapping field)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageBroadcaster(init, field, pol);
			ExcludeBroadcaster(pol, ((ProcTest)field)._0002(), out string _0004);
			init._0004(_0004);
			InitBroadcaster(init, field, pol);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ManageBroadcaster(RecordClassDispatcher asset, ProcTest counter, object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(null, asset._0002(), "Started serializing {0}".ListReader(CultureInfo.InvariantCulture, counter._0002())), null);
			}
			counter.ListClient(res, baseProperty.roleError);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitBroadcaster(RecordClassDispatcher value, ProcTest caller, object rule)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
			{
				containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(null, value._0002(), "Finished serializing {0}".ListReader(CultureInfo.InvariantCulture, caller._0002())), null);
			}
			caller.SelectClient(rule, baseProperty.roleError);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DefineBroadcaster(RecordClassDispatcher task, object visitor, PrototypeFilterResolver proc, ProductInstanceExpression cust2, InitializerTest first3, ProductInstanceExpression v4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageBroadcaster(task, proc, visitor);
			wrapperProperty.Add(visitor);
			SortBroadcaster(task, visitor, proc, cust2, first3, v4);
			int lengthpred = task._0002();
			for (int i = 0; i < proc._0001().Count; i++)
			{
				ProductInstanceExpression productInstanceExpression = proc._0001()[i];
				try
				{
					if (CollectBroadcaster(task, visitor, proc, cust2, productInstanceExpression, out ProcTest _0007, out object _0008))
					{
						productInstanceExpression.DefineClient(task);
						InvokeBroadcaster(task, _0008, _0007, productInstanceExpression, proc, cust2);
					}
				}
				catch (Exception ident)
				{
					if (!CheckBroadcaster(visitor, proc, productInstanceExpression._0001(), null, task._0001(), ident))
					{
						throw;
					}
					EnableClass(task, lengthpred);
				}
			}
			IEnumerable<KeyValuePair<object, object>> enumerable = proc._0001()?.Invoke(visitor);
			if (enumerable != null)
			{
				foreach (KeyValuePair<object, object> item in enumerable)
				{
					ProcTest temp = TestBroadcaster(item.Key);
					ProcTest procTest = DeleteBroadcaster(item.Value);
					string text = AddClass(task, item.Key, temp, out bool _);
					text = ((proc._0001() != null) ? proc._0001()(text) : text);
					if (CountBroadcaster(item.Value, null, procTest, proc, cust2))
					{
						task._0002(text);
						QueryBroadcaster(task, item.Value);
					}
					else if (CustomizeBroadcaster(task, item.Value, null, procTest, proc, cust2))
					{
						task._0002(text);
						InvokeBroadcaster(task, item.Value, procTest, null, proc, cust2);
					}
				}
			}
			task._0011();
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(task, proc, visitor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CollectBroadcaster(RecordClassDispatcher init, object pol, InitializerTest helper, [global::_0008._0012(2)] ProductInstanceExpression _0005, ProductInstanceExpression asset3, [global::_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out ProcTest _0007, [ConsumerBroadcasterDispatcher(true)] [global::_0008._0012(2)] out object _0008)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!asset3._0001() && asset3._0002() && MapClass(init, asset3, pol) && InsertClass(init, asset3, pol))
			{
				if (asset3._0001() == null)
				{
					asset3._0001(baseProperty.listenerError._0001(asset3._0002()));
				}
				_0008 = asset3._0001()._0001(pol);
				_0007 = (asset3._0001().propertyProperty ? asset3._0001() : DeleteBroadcaster(_0008));
				if (AssetBroadcaster(_0008, helper as PrototypeFilterResolver, asset3))
				{
					if (CountBroadcaster(_0008, asset3, _0007, helper, _0005))
					{
						asset3.DefineClient(init);
						QueryBroadcaster(init, _0008);
						return false;
					}
					if (!CustomizeBroadcaster(init, _0008, asset3, _0007, helper, _0005))
					{
						return false;
					}
					if (_0008 == null)
					{
						PrototypeFilterResolver prototypeFilterResolver = helper as PrototypeFilterResolver;
						switch (asset3.contextProperty ?? (prototypeFilterResolver?._0001()).GetValueOrDefault())
						{
						case (SpecificationTestItem)2:
							throw StrategyError.ValidateComposer(null, init._0001(), "Cannot write a null value for property '{0}'. Property requires a value.".ListReader(CultureInfo.InvariantCulture, asset3._0001()), null);
						case (SpecificationTestItem)3:
							throw StrategyError.ValidateComposer(null, init._0001(), "Cannot write a null value for property '{0}'. Property requires a non-null value.".ListReader(CultureInfo.InvariantCulture, asset3._0001()), null);
						}
					}
					return true;
				}
			}
			_0007 = null;
			_0008 = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SortBroadcaster(RecordClassDispatcher v, object attr, ProcTest role, ProductInstanceExpression t2, InitializerTest visitor3, ProductInstanceExpression selection4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			v._0002();
			if ((PrintBroadcaster(role, t2, visitor3, selection4) ?? LoginClass(baseProperty.m_PageError, (TaskListAnnotation)1)) && (t2 == null || t2._0003() || CallBroadcaster(visitor3, t2)))
			{
				PublishBroadcaster(v, role._0002(), attr);
			}
			if (RunClass((SparklineAxisMinMaxValues)1, role, t2, visitor3, selection4))
			{
				WriteBroadcaster(v, role._0002());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CallBroadcaster(InitializerTest init, ProductInstanceExpression col)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (init as PrototypeFilterResolver)?._0002().Contains(col._0001()) ?? false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PublishBroadcaster(RecordClassDispatcher init, Type pred, object control)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = CancelBroadcaster(init, control);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
			{
				containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, init._0002(), "Writing object reference Id '{0}' for {1}.".SelectReader(CultureInfo.InvariantCulture, text, pred)), null);
			}
			init._0001("$id", injectcust: false);
			init._0004(text);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteBroadcaster(RecordClassDispatcher ident, Type map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = ResolverErrorFilter.PublishIssuer(map, baseProperty._StatusError, baseProperty.writerError);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
			{
				containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, ident._0002(), "Writing type name '{0}' for {1}.".SelectReader(CultureInfo.InvariantCulture, text, map)), null);
			}
			ident._0001("$type", injectcust: false);
			ident._0004(text);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool RevertBroadcaster(ConnectActionCursor var1, ConnectActionCursor pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (var1 & pred) == pred;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool LoginClass(TaskListAnnotation i, TaskListAnnotation counter)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (i & counter) == counter;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckClass(SparklineAxisMinMaxValues first, SparklineAxisMinMaxValues b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (first & b) == b;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DisableClass(RecordClassDispatcher var1, BroadcasterError second, object temp, ProcTest pol2, InitializerTest last3, ProductInstanceExpression res4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (CountBroadcaster(temp, null, pol2, last3, res4))
			{
				QueryBroadcaster(var1, temp);
			}
			else if (CustomizeBroadcaster(var1, temp, null, pol2, last3, res4))
			{
				wrapperProperty.Add(temp);
				if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
				{
					containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(null, var1._0002(), "Started serializing {0} with converter {1}.".SelectReader(CultureInfo.InvariantCulture, temp.GetType(), second.GetType())), null);
				}
				second._0001(var1, temp, SelectBroadcaster());
				if (containerProperty != null && containerProperty._0001() >= TraceLevel.Info)
				{
					containerProperty._0001(TraceLevel.Info, QueueError.ComputeError(null, var1._0002(), "Finished serializing {0} with converter {1}.".SelectReader(CultureInfo.InvariantCulture, temp.GetType(), second.GetType())), null);
				}
				wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VerifyClass(RecordClassDispatcher value, IEnumerable second, MessageTest state, ProductInstanceExpression reference2, InitializerTest v3, ProductInstanceExpression init4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManagerErrorFilter managerErrorFilter = second as ManagerErrorFilter;
			object obj = (managerErrorFilter != null) ? managerErrorFilter._0001() : second;
			ManageBroadcaster(value, state, obj);
			wrapperProperty.Add(obj);
			bool flag = ValidateClass(value, obj, state, reference2, v3, init4);
			value._0003();
			int lengthpred = value._0002();
			int num = 0;
			foreach (object item in second)
			{
				try
				{
					ProcTest procTest = ((InitializerTest)state)._0002() ?? DeleteBroadcaster(item);
					if (CountBroadcaster(item, null, procTest, state, reference2))
					{
						QueryBroadcaster(value, item);
					}
					else if (CustomizeBroadcaster(value, item, null, procTest, state, reference2))
					{
						InvokeBroadcaster(value, item, procTest, null, state, reference2);
					}
				}
				catch (Exception ident)
				{
					if (!CheckBroadcaster(obj, state, num, null, value._0001(), ident))
					{
						throw;
					}
					EnableClass(value, lengthpred);
				}
				finally
				{
					num++;
				}
			}
			value._000F();
			if (flag)
			{
				value._0011();
			}
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(value, state, obj);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PatchClass(RecordClassDispatcher i, Array result, MessageTest tag, ProductInstanceExpression connection2, InitializerTest ord3, ProductInstanceExpression asset4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageBroadcaster(i, tag, result);
			wrapperProperty.Add(result);
			bool num = ValidateClass(i, result, tag, connection2, ord3, asset4);
			FindClass(i, result, tag, connection2, i._0002(), ObserverIteratorMapping.CheckProperty<int>());
			if (num)
			{
				i._0011();
			}
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(i, tag, result);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindClass(RecordClassDispatcher instance, Array cont, MessageTest rule, ProductInstanceExpression ivk2, int cust3max, int[] last4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = last4.Length;
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = last4[i];
			}
			instance._0003();
			for (int j = cont.GetLowerBound(num); j <= cont.GetUpperBound(num); j++)
			{
				array[num] = j;
				if (array.Length == cont.Rank)
				{
					object value = cont.GetValue(array);
					try
					{
						ProcTest procTest = ((InitializerTest)rule)._0002() ?? DeleteBroadcaster(value);
						if (CountBroadcaster(value, null, procTest, rule, ivk2))
						{
							QueryBroadcaster(instance, value);
						}
						else if (CustomizeBroadcaster(instance, value, null, procTest, rule, ivk2))
						{
							InvokeBroadcaster(instance, value, procTest, null, rule, ivk2);
						}
					}
					catch (Exception ident)
					{
						if (!CheckBroadcaster(cont, rule, j, null, instance._0001(), ident))
						{
							throw;
						}
						EnableClass(instance, cust3max + 1);
					}
				}
				else
				{
					FindClass(instance, cont, rule, ivk2, cust3max + 1, array);
				}
			}
			instance._000F();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ValidateClass(RecordClassDispatcher value, object second, MessageTest helper, ProductInstanceExpression ord2, InitializerTest last3, ProductInstanceExpression t4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool flag = (PrintBroadcaster(helper, ord2, last3, t4) ?? LoginClass(baseProperty.m_PageError, (TaskListAnnotation)2)) && (ord2 == null || ord2._0003() || CallBroadcaster(last3, ord2));
			bool flag2 = RunClass((SparklineAxisMinMaxValues)2, helper, ord2, last3, t4);
			bool num = flag || flag2;
			if (num)
			{
				value._0002();
				if (flag)
				{
					PublishBroadcaster(value, ((ProcTest)helper)._0002(), second);
				}
				if (flag2)
				{
					WriteBroadcaster(value, second.GetType());
				}
				value._0001("$values", injectcust: false);
			}
			if (((InitializerTest)helper)._0001() == null)
			{
				helper._0001(baseProperty.listenerError._0001(helper._0001() ?? typeof(object)));
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecuritySafeCritical]
		private void OrderClass(RecordClassDispatcher first, ISerializable visitor, CollectionProperty dic, ProductInstanceExpression selection2, InitializerTest cust3, ProductInstanceExpression asset4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!ConfigProperty._0002())
			{
				string asset5 = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
				asset5 = asset5.ListReader(CultureInfo.InvariantCulture, visitor.GetType());
				throw StrategyError.ValidateComposer(null, first._0001(), asset5, null);
			}
			ManageBroadcaster(first, dic, visitor);
			wrapperProperty.Add(visitor);
			SortBroadcaster(first, visitor, dic, selection2, cust3, asset4);
			SerializationInfo serializationInfo = new SerializationInfo(((ProcTest)dic)._0002(), new FormatterConverter());
			visitor.GetObjectData(serializationInfo, baseProperty.roleError);
			SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
			while (enumerator.MoveNext())
			{
				SerializationEntry current = enumerator.Current;
				ProcTest procTest = DeleteBroadcaster(current.Value);
				if (CountBroadcaster(current.Value, null, procTest, dic, selection2))
				{
					first._0002(current.Name);
					QueryBroadcaster(first, current.Value);
				}
				else if (CustomizeBroadcaster(first, current.Value, null, procTest, dic, selection2))
				{
					first._0002(current.Name);
					InvokeBroadcaster(first, current.Value, procTest, null, dic, selection2);
				}
			}
			first._0011();
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(first, dic, visitor);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResolveClass(RecordClassDispatcher task, IDynamicMetaObjectProvider connection, ProducerProperty role, ProductInstanceExpression last2, InitializerTest result3, ProductInstanceExpression reg4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ManageBroadcaster(task, role, connection);
			wrapperProperty.Add(connection);
			SortBroadcaster(task, connection, role, last2, result3, reg4);
			int lengthpred = task._0002();
			for (int i = 0; i < role._0001().Count; i++)
			{
				ProductInstanceExpression productInstanceExpression = role._0001()[i];
				if (productInstanceExpression._0004())
				{
					try
					{
						if (CollectBroadcaster(task, connection, role, last2, productInstanceExpression, out ProcTest _0007, out object _0008))
						{
							productInstanceExpression.DefineClient(task);
							InvokeBroadcaster(task, _0008, _0007, productInstanceExpression, role, last2);
						}
					}
					catch (Exception ident)
					{
						if (!CheckBroadcaster(connection, role, productInstanceExpression._0001(), null, task._0001(), ident))
						{
							throw;
						}
						EnableClass(task, lengthpred);
					}
				}
			}
			foreach (string item in connection.ResolveIssuer())
			{
				if (role.CancelClient(connection, item, out object _0004))
				{
					try
					{
						ProcTest procTest = DeleteBroadcaster(_0004);
						if (FillClass(_0004) && CustomizeBroadcaster(task, _0004, null, procTest, role, last2))
						{
							string task2 = (role._0001() != null) ? role._0001()(item) : item;
							task._0002(task2);
							InvokeBroadcaster(task, _0004, procTest, null, role, last2);
						}
					}
					catch (Exception ident2)
					{
						if (!CheckBroadcaster(connection, role, item, null, task._0001(), ident2))
						{
							throw;
						}
						EnableClass(task, lengthpred);
					}
				}
			}
			task._0011();
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(task, role, connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool FillClass(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (baseProperty.m_DatabaseError == (ApplicationState)1 && res == null)
			{
				return false;
			}
			if (RevertBroadcaster(baseProperty._FactoryError, (ConnectActionCursor)1) && (res == null || CustomerListAnnotation.TestIssuer(res, ResolverErrorFilter.ReflectReader(res.GetType()))))
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool RunClass(SparklineAxisMinMaxValues spec, ProcTest caller, ProductInstanceExpression field, InitializerTest connection2, ProductInstanceExpression selection3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			SparklineAxisMinMaxValues first = field?._0001() ?? selection3?._0002() ?? connection2?._0001() ?? baseProperty.m_ParserError;
			if (CheckClass(first, spec))
			{
				return true;
			}
			if (CheckClass(first, (SparklineAxisMinMaxValues)4))
			{
				if (field != null)
				{
					if (caller._InstanceProperty != field._0001()._0003())
					{
						return true;
					}
				}
				else if (connection2 != null)
				{
					if (connection2._0001() == null || caller._InstanceProperty != connection2._0001()._0003())
					{
						return true;
					}
				}
				else if (_VisitorProperty != null && wrapperProperty.Count == globalProperty)
				{
					ProcTest procTest = baseProperty.listenerError._0001(_VisitorProperty);
					if (caller._InstanceProperty != procTest._0003())
					{
						return true;
					}
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CompareClass(RecordClassDispatcher instance, IDictionary attr, ParamClientBridge c, ProductInstanceExpression param2, InitializerTest caller3, ProductInstanceExpression ivk4)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ProcessComposer processComposer = attr as ProcessComposer;
			object obj = (processComposer != null) ? processComposer._0001() : attr;
			ManageBroadcaster(instance, c, obj);
			wrapperProperty.Add(obj);
			SortBroadcaster(instance, obj, c, param2, caller3, ivk4);
			if (((InitializerTest)c)._0001() == null)
			{
				c._0001(baseProperty.listenerError._0001(c._0004() ?? typeof(object)));
			}
			if (c._0003() == null)
			{
				c._0002(baseProperty.listenerError._0001(c._0001() ?? typeof(object)));
			}
			int lengthpred = instance._0002();
			foreach (DictionaryEntry item in attr)
			{
				string text = AddClass(instance, item.Key, c._0003(), out bool last);
				text = ((c._0001() != null) ? c._0001()(text) : text);
				try
				{
					object value = item.Value;
					ProcTest procTest = ((InitializerTest)c)._0002() ?? DeleteBroadcaster(value);
					if (CountBroadcaster(value, null, procTest, c, param2))
					{
						instance._0001(text, last);
						QueryBroadcaster(instance, value);
					}
					else if (CustomizeBroadcaster(instance, value, null, procTest, c, param2))
					{
						instance._0001(text, last);
						InvokeBroadcaster(instance, value, procTest, null, c, param2);
					}
				}
				catch (Exception ident)
				{
					if (!CheckBroadcaster(obj, c, text, null, instance._0001(), ident))
					{
						throw;
					}
					EnableClass(instance, lengthpred);
				}
			}
			instance._0011();
			wrapperProperty.RemoveAt(wrapperProperty.Count - 1);
			InitBroadcaster(instance, c, obj);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string AddClass(RecordClassDispatcher item, object result, ProcTest temp, out bool last2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (temp._ErrorProperty == (ParameterFilterResolver)3)
			{
				ProccesorClassSpec proccesorClassSpec = (ProccesorClassSpec)temp;
				switch (proccesorClassSpec._0001())
				{
				case (SettingsSerializeAs)26:
				case (SettingsSerializeAs)27:
				{
					DateTime token = DescriptorIteratorMapping.ReadProperty((DateTime)result, item._0001());
					last2 = false;
					StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
					DescriptorIteratorMapping.TestProperty(stringWriter2, token, item._0001(), item._0003(), item._0001());
					return stringWriter2.ToString();
				}
				case (SettingsSerializeAs)28:
				case (SettingsSerializeAs)29:
				{
					last2 = false;
					StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
					DescriptorIteratorMapping.AssetProperty(stringWriter, (DateTimeOffset)result, item._0001(), item._0003(), item._0001());
					return stringWriter.ToString();
				}
				case (SettingsSerializeAs)24:
				case (SettingsSerializeAs)25:
				{
					double num = (double)result;
					last2 = false;
					return num.ToString("R", CultureInfo.InvariantCulture);
				}
				case (SettingsSerializeAs)22:
				case (SettingsSerializeAs)23:
				{
					float num2 = (float)result;
					last2 = false;
					return num2.ToString("R", CultureInfo.InvariantCulture);
				}
				default:
				{
					last2 = true;
					if (proccesorClassSpec._FilterProperty && InfoFilterResolver.InsertIssuer(proccesorClassSpec._InstanceProperty, result, null, out string _0005))
					{
						return _0005;
					}
					return Convert.ToString(result, CultureInfo.InvariantCulture);
				}
				}
			}
			if (ExcludeBroadcaster(result, result.GetType(), out string _0004))
			{
				last2 = true;
				return _0004;
			}
			last2 = true;
			return result.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnableClass(RecordClassDispatcher item, int lengthpred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			LoginBroadcaster();
			if (item._0001() == (PlatformType)5)
			{
				item._0008();
			}
			while (item._0002() > lengthpred)
			{
				item.CollectTests();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MapClass(RecordClassDispatcher res, ProductInstanceExpression attr, object temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (attr._0001() == null)
			{
				return true;
			}
			bool flag = attr._0001()(temp);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
			{
				containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, res._0002(), "ShouldSerialize result for property '{0}' on {1}: {2}".DeleteReader(CultureInfo.InvariantCulture, attr._0001(), attr._0001(), flag)), null);
			}
			return flag;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool InsertClass(RecordClassDispatcher value, ProductInstanceExpression visitor, object helper)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (visitor._0003() == null)
			{
				return true;
			}
			bool flag = visitor._0003()(helper);
			if (containerProperty != null && containerProperty._0001() >= TraceLevel.Verbose)
			{
				containerProperty._0001(TraceLevel.Verbose, QueueError.ComputeError(null, value._0002(), "IsSpecified result for property '{0}' on {1}: {2}".DeleteReader(CultureInfo.InvariantCulture, visitor._0001(), visitor._0001(), flag)), null);
			}
			return flag;
		}
	}
}
