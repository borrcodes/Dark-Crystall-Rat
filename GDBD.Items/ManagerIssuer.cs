using _0008;
using GDBD.Dispatcher;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Filters;
using Newtonsoft.Resolver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[_0008._0012(new byte[]
	{
		0,
		1
	})]
	internal sealed class ManagerIssuer : Collection<ParserFilterResolver>
	{
		private static readonly IEqualityComparer<string> _StateIssuer;

		[_0008._0012(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, ParserFilterResolver> m_ResolverIssuer;

		public ParserFilterResolver this[string config]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (config == null)
				{
					throw new ArgumentNullException("key");
				}
				if (m_ResolverIssuer != null)
				{
					return m_ResolverIssuer[config];
				}
				throw new KeyNotFoundException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ManagerIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector((IList<ParserFilterResolver>)new List<ParserFilterResolver>());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResolveRequest(string i, ParserFilterResolver pred)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RunRequest();
			m_ResolverIssuer[i] = pred;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base.ClearItems();
			m_ResolverIssuer?.Clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FillRequest(string instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance == null)
			{
				throw new ArgumentNullException("key");
			}
			if (m_ResolverIssuer != null)
			{
				return m_ResolverIssuer.ContainsKey(instance);
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RunRequest()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ResolverIssuer == null)
			{
				m_ResolverIssuer = new Dictionary<string, ParserFilterResolver>(_StateIssuer);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string CompareRequest(ParserFilterResolver i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((WatcherIssuer)i)._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(int mean_first, ParserFilterResolver map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ResolveRequest(CompareRequest(map), map);
			base.InsertItem(mean_first, map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(int previousspec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string var = CompareRequest(base.Items[previousspec]);
			AddRequest(var);
			base.RemoveItem(previousspec);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddRequest(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_ResolverIssuer?.Remove(var1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0002(int paramLow, ParserFilterResolver connection)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string text = CompareRequest(connection);
			string text2 = CompareRequest(base.Items[paramLow]);
			if (_StateIssuer.Equals(text2, text))
			{
				if (m_ResolverIssuer != null)
				{
					m_ResolverIssuer[text] = connection;
				}
			}
			else
			{
				ResolveRequest(text, connection);
				if (text2 != null)
				{
					AddRequest(text2);
				}
			}
			base.SetItem(paramLow, connection);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool EnableRequest(string param, [_0008._0012(2)] [ConsumerBroadcasterDispatcher(true)] out ParserFilterResolver _0003)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (m_ResolverIssuer == null)
			{
				_0003 = null;
				return false;
			}
			return m_ResolverIssuer.TryGetValue(param, out _0003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICollection<string> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			RunRequest();
			return m_ResolverIssuer.Keys;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int MapRequest(ParserFilterResolver last)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ((List<ParserFilterResolver>)base.Items).SortTest(last);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ManagerIssuer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_StateIssuer = StringComparer.Ordinal;
		}
	}
}
