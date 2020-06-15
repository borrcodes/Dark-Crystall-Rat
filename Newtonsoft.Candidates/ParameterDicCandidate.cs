using GDBD.Workers;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Candidates
{
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	internal sealed class ParameterDicCandidate
	{
		private static ResourceManager parameterEvent;

		private static CultureInfo _PrototypeEvent;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ExcludeList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				if (parameterEvent == null)
				{
					ResourceManager resourceManager = parameterEvent = new ResourceManager("Newtonsoft.Candidates.ParameterDicCandidate", typeof(ParameterDicCandidate).Assembly);
				}
				return parameterEvent;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo InitList
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				return _PrototypeEvent;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0002
				//IL_0003: Incompatible stack heights: 0 vs 1
				_PrototypeEvent = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ParameterDicCandidate()
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
		}
	}
}
