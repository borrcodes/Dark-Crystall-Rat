using _0008;
using GDBD.Dispatcher;
using GDBD.Filter;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Annotations;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Consumers
{
	[_0008._0012(0)]
	internal static class ProcConsumer
	{
		[_0008._0012(new byte[]
		{
			2,
			1
		})]
		[CompilerGenerated]
		private static Func<CodeListAnnotation> _DicError;

		public static readonly string _ErrorError;

		public static readonly string composerError;

		public static readonly string testError;

		public static readonly string _PropertyError;

		public static readonly string m_IssuerError;

		public static readonly string readerError;

		public static readonly string _ClientError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public static Func<CodeListAnnotation> _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DicError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ForgotError(bool isident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!isident)
			{
				return composerError;
			}
			return _ErrorError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string IncludeError(char key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return CalcError(char.ToString(key));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string PushError(float key, ApplicationPartitionType pol, char control, bool isivk2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PrepareError(key, UpdateError(key, key.ToString("R", CultureInfo.InvariantCulture)), pol, control, isivk2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string PrepareError(double last, string ord, ApplicationPartitionType role, char instance2, bool iscust3)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (role == (ApplicationPartitionType)1 || (!double.IsInfinity(last) && !double.IsNaN(last)))
			{
				return ord;
			}
			if (role == (ApplicationPartitionType)2)
			{
				if (iscust3)
				{
					return testError;
				}
				return "0.0";
			}
			return instance2 + ord + instance2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string AwakeError(double task, ApplicationPartitionType counter, char dir, bool allowtoken2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return PrepareError(task, UpdateError(task, task.ToString("R", CultureInfo.InvariantCulture)), counter, dir, allowtoken2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string UpdateError(double instance, string visitor)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (double.IsNaN(instance) || double.IsInfinity(instance) || visitor.IndexOf('.') != -1 || visitor.IndexOf('E') != -1 || visitor.IndexOf('e') != -1)
			{
				return visitor;
			}
			return visitor + ".0";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ReadError(string task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (task.IndexOf('.') != -1)
			{
				return task;
			}
			return task + ".0";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InterruptError(decimal var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ReadError(var1.ToString(null, CultureInfo.InvariantCulture));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string CalcError(string init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return InstantiateError(init, '"');
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string InstantiateError(string init, char cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ReflectError(init, cfg, (GraphGroupStyle)0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ReflectError(string last, char token, GraphGroupStyle comp)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (token != '"' && token != '\'')
			{
				throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
			}
			return RegistryBroadcasterFilter.RateIssuer(last, token, appendtemplate: true, comp);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ProcConsumer()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_ErrorError = "true";
			composerError = "false";
			testError = "null";
			_PropertyError = "undefined";
			m_IssuerError = "Infinity";
			readerError = "-Infinity";
			_ClientError = "NaN";
		}
	}
}
