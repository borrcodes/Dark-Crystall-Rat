using _0008;
using GDBD.Dispatcher;
using GDBD.Items;
using GDBD.Maps;
using GDBD.Specifications;
using GDBD.Strategies;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace GDBD.Workers
{
	[_0008._0012(0)]
	internal sealed class ConfigComposerWorker : BroadcasterError
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(RecordClassDispatcher spec, object map, PrototypeError consumer)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (map == null)
			{
				spec._0008();
				return;
			}
			Regex regex = (Regex)map;
			TaskIteratorMapping taskIteratorMapping = spec as TaskIteratorMapping;
			if (taskIteratorMapping != null)
			{
				StartRequest(taskIteratorMapping, regex);
			}
			else
			{
				ListRequest(spec, regex, consumer);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool GetRequest(RegexOptions info, RegexOptions caller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (info & caller) == caller;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartRequest(TaskIteratorMapping i, Regex ivk)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string str = null;
			if (GetRequest(ivk.Options, RegexOptions.IgnoreCase))
			{
				str += "i";
			}
			if (GetRequest(ivk.Options, RegexOptions.Multiline))
			{
				str += "m";
			}
			if (GetRequest(ivk.Options, RegexOptions.Singleline))
			{
				str += "s";
			}
			str += "u";
			if (GetRequest(ivk.Options, RegexOptions.ExplicitCapture))
			{
				str += "x";
			}
			i.NewIterator(ivk.ToString(), str);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ListRequest(RecordClassDispatcher i, Regex reg, PrototypeError tag)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			PublisherRequestStrategy publisherRequestStrategy = tag._0001() as PublisherRequestStrategy;
			i._0002();
			i._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Pattern") : "Pattern");
			i._0004(reg.ToString());
			i._0002((publisherRequestStrategy != null) ? publisherRequestStrategy.ResetClient("Options") : "Options");
			tag.FlushComposer(i, reg.Options);
			i._0011();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001(TagTestItem first, Type result, object pool, PrototypeError spec2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (first._0001())
			{
			case WatcherComposer.StartObject:
				return DeleteRequest(first, spec2);
			case WatcherComposer.String:
				return SelectRequest(first);
			case WatcherComposer.Null:
				return null;
			default:
				throw StrategyError.PatchComposer(first, "Unexpected token when reading Regex.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private object SelectRequest(TagTestItem ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = (string)ident._0001();
			if (text.Length > 0 && text[0] == '/')
			{
				int num = text.LastIndexOf('/');
				if (num > 0)
				{
					string pattern = text.Substring(1, num - 1);
					RegexOptions options = CustomerListAnnotation.QueryIssuer(text.Substring(num + 1));
					return new Regex(pattern, options);
				}
			}
			throw StrategyError.PatchComposer(ident, "Regex pattern must be enclosed by slashes.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Regex DeleteRequest(TagTestItem config, PrototypeError result)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = null;
			RegexOptions? regexOptions = null;
			while (config._0001())
			{
				switch (config._0001())
				{
				case WatcherComposer.PropertyName:
				{
					string a = config._0001().ToString();
					if (!config._0001())
					{
						throw StrategyError.PatchComposer(config, "Unexpected end when reading Regex.");
					}
					if (string.Equals(a, "Pattern", StringComparison.OrdinalIgnoreCase))
					{
						text = (string)config._0001();
					}
					else if (string.Equals(a, "Options", StringComparison.OrdinalIgnoreCase))
					{
						regexOptions = result.CompareComposer<RegexOptions>(config);
					}
					else
					{
						config.AssetError();
					}
					break;
				}
				case WatcherComposer.EndObject:
					if (text == null)
					{
						throw StrategyError.PatchComposer(config, "Error deserializing Regex. No pattern found.");
					}
					return new Regex(text, regexOptions.GetValueOrDefault());
				}
			}
			throw StrategyError.PatchComposer(config, "Unexpected end when reading Regex.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001(Type reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference.Name == "Regex")
			{
				return TestRequest(reference);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TestRequest(Type task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return task == typeof(Regex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ConfigComposerWorker()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
