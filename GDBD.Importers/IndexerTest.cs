using _0008;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal sealed class IndexerTest : SerializationBinder, UtilsRequestStrategy
	{
		internal static readonly IndexerTest m_DecoratorTest;

		[_0008._0012(new byte[]
		{
			1,
			0,
			2,
			1,
			1
		})]
		private readonly Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<string, string>, Type> fieldTest;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IndexerTest()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			fieldTest = new Newtonsoft.Database.DispatcherEventEntry<GDBD.Workers.TemplateComposerWorker<string, string>, Type>(RemoveClient);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type RemoveClient(GDBD.Workers.TemplateComposerWorker<string, string> res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string workerTest = res.workerTest;
			string advisorTest = res._AdvisorTest;
			if (workerTest != null)
			{
				Assembly assembly = Assembly.LoadWithPartialName(workerTest);
				if (assembly == null)
				{
					Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
					foreach (Assembly assembly2 in assemblies)
					{
						if (assembly2.FullName == workerTest || assembly2.GetName().Name == workerTest)
						{
							assembly = assembly2;
							break;
						}
					}
				}
				if (assembly == null)
				{
					throw new StrategyError("Could not load assembly '{0}'.".ListReader(CultureInfo.InvariantCulture, workerTest));
				}
				Type type = assembly.GetType(advisorTest);
				if (type == null)
				{
					if (advisorTest.IndexOf('`') >= 0)
					{
						try
						{
							type = PostClient(advisorTest, assembly);
						}
						catch (Exception second)
						{
							throw new StrategyError("Could not find type '{0}' in assembly '{1}'.".SelectReader(CultureInfo.InvariantCulture, advisorTest, assembly.FullName), second);
						}
					}
					if (type == null)
					{
						throw new StrategyError("Could not find type '{0}' in assembly '{1}'.".SelectReader(CultureInfo.InvariantCulture, advisorTest, assembly.FullName));
					}
				}
				return type;
			}
			return Type.GetType(advisorTest);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type PostClient(string res, Assembly pol)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			Type result = null;
			int num = res.IndexOf('[');
			if (num >= 0)
			{
				string name = res.Substring(0, num);
				Type type = pol.GetType(name);
				if (type != null)
				{
					List<Type> list = new List<Type>();
					int num2 = 0;
					int num3 = 0;
					int num4 = res.Length - 1;
					for (int i = num + 1; i < num4; i++)
					{
						switch (res[i])
						{
						case '[':
							if (num2 == 0)
							{
								num3 = i + 1;
							}
							num2++;
							break;
						case ']':
							num2--;
							if (num2 == 0)
							{
								GDBD.Workers.TemplateComposerWorker<string, string> first = ResolverErrorFilter.IncludeReader(res.Substring(num3, i - num3));
								list.Add(ChangeClient(first));
							}
							break;
						}
					}
					result = type.MakeGenericType(list.ToArray());
				}
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type ChangeClient(GDBD.Workers.TemplateComposerWorker<string, string> first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return fieldTest.InitReader(first);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Type BindToType(string reference, string vis)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ChangeClient(new GDBD.Workers.TemplateComposerWorker<string, string>(reference, vis));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BindToName([_0008._0012(1)] Type _0002, out string second, out string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			second = _0002.Assembly.FullName;
			res = _0002.FullName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static IndexerTest()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			m_DecoratorTest = new IndexerTest();
		}
	}
}
