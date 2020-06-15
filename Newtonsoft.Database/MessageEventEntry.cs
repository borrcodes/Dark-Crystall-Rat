using _0008;
using GDBD.Items;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Common;
using Newtonsoft.Resolver;
using Newtonsoft.Rules;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Database
{
	[_0008._0012(0)]
	internal sealed class MessageEventEntry : PoolIssuer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MessageEventEntry(MessageEventEntry param)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(param);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MessageEventEntry(object var1)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector(var1, Newtonsoft.Rules.UnicodeCategory.Raw);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MessageEventEntry FlushRequest(TagTestItem config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
			{
				using (StatusDicCandidate statusDicCandidate = new StatusDicCandidate(stringWriter))
				{
					statusDicCandidate.IncludeTest(config);
					return new MessageEventEntry(stringWriter.ToString());
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override ParserFilterResolver _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return new MessageEventEntry(this);
		}
	}
}
