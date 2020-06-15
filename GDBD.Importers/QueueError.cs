using _0008;
using GDBD.Bridges;
using GDBD.Filter;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal struct QueueError
	{
		private static readonly char[] proxyError;

		internal tagURLTEMPLATE _RegistryError;

		internal int _AttrError;

		[_0008._0012(2)]
		internal string m_ConfigurationError;

		internal bool m_CandidateError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public QueueError(tagURLTEMPLATE instance)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_RegistryError = instance;
			m_CandidateError = RestartError(instance);
			_AttrError = -1;
			m_ConfigurationError = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int ResetError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (_RegistryError)
			{
			case tagURLTEMPLATE.Object:
				return m_ConfigurationError.Length + 5;
			case tagURLTEMPLATE.Array:
			case tagURLTEMPLATE.Constructor:
				return IteratorComposerPool.ListIssuer((ulong)_AttrError) + 2;
			default:
				throw new ArgumentOutOfRangeException("Type");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RegisterError(StringBuilder config, ref StringWriter connection, ref char[] temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (_RegistryError)
			{
			case tagURLTEMPLATE.Object:
			{
				string configurationError = m_ConfigurationError;
				if (configurationError.IndexOfAny(proxyError) != -1)
				{
					config.Append("['");
					if (connection == null)
					{
						connection = new StringWriter(config);
					}
					RegistryBroadcasterFilter.SetIssuer(connection, configurationError, '\'', wantord2: false, RegistryBroadcasterFilter._ObserverTest, (GraphGroupStyle)0, null, ref temp);
					config.Append("']");
				}
				else
				{
					if (config.Length > 0)
					{
						config.Append('.');
					}
					config.Append(configurationError);
				}
				break;
			}
			case tagURLTEMPLATE.Array:
			case tagURLTEMPLATE.Constructor:
				config.Append('[');
				config.Append(_AttrError);
				config.Append(']');
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RestartError(tagURLTEMPLATE instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (instance != tagURLTEMPLATE.Array)
			{
				return instance == tagURLTEMPLATE.Constructor;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string SearchError(List<QueueError> ident, QueueError? ord)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = 0;
			if (ident != null)
			{
				for (int i = 0; i < ident.Count; i++)
				{
					num += ident[i].ResetError();
				}
			}
			if (ord.HasValue)
			{
				num += ord.GetValueOrDefault().ResetError();
			}
			StringBuilder stringBuilder = new StringBuilder(num);
			StringWriter connection = null;
			char[] temp = null;
			if (ident != null)
			{
				foreach (QueueError item in ident)
				{
					item.RegisterError(stringBuilder, ref connection, ref temp);
				}
			}
			ord?.RegisterError(stringBuilder, ref connection, ref temp);
			return stringBuilder.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string ComputeError(IdentifierClientBridge instance, string pred, string temp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!temp.EndsWith(Environment.NewLine, StringComparison.Ordinal))
			{
				temp = temp.Trim();
				if (!temp.SetupReader('.'))
				{
					temp += ".";
				}
				temp += " ";
			}
			temp += "Path '{0}'".ListReader(CultureInfo.InvariantCulture, pred);
			if (instance != null && instance._0002())
			{
				temp += ", line {0}, position {1}".SelectReader(CultureInfo.InvariantCulture, instance._0001(), instance._0002());
			}
			temp += ".";
			return temp;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static QueueError()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			proxyError = new char[18]
			{
				'.',
				' ',
				'\'',
				'/',
				'"',
				'[',
				']',
				'(',
				')',
				'\t',
				'\n',
				'\r',
				'\f',
				'\b',
				'\\',
				'\u0085',
				'\u2028',
				'\u2029'
			};
		}
	}
}
