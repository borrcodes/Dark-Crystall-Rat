using _0008;
using GDBD.Bridges;
using GDBD.Items;
using GDBD.Specifications;
using GDBD.Workers;
using Newtonsoft.Candidates;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace GDBD.Importers
{
	[_0008._0012(0)]
	internal sealed class ObjectIssuerImporter : TagTestItem, IdentifierClientBridge
	{
		private readonly TagTestItem _EventIssuer;

		private readonly StatusDicCandidate filterIssuer;

		private readonly StringWriter m_InstanceIssuer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectIssuerImporter(TagTestItem res)
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			_EventIssuer = res;
			m_InstanceIssuer = new StringWriter(CultureInfo.InvariantCulture);
			m_InstanceIssuer.Write("Deserialized JSON: " + Environment.NewLine);
			filterIssuer = new StatusDicCandidate(m_InstanceIssuer);
			filterIssuer._0001((TimeState)1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CalcClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_InstanceIssuer.ToString();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			string result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			byte[] result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override decimal? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			decimal? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override double? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			double? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			bool? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTime? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DateTime? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override DateTimeOffset? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			DateTimeOffset? result = _EventIssuer._0001();
			InstantiateClass();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InstantiateClass()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			filterIssuer._0001(_EventIssuer, requiresconnection: false, usedir: false, checkcaller2: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventIssuer._0003();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventIssuer._0002();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override WatcherComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventIssuer._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventIssuer._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _EventIssuer._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_EventIssuer._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool _0007()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (_EventIssuer as IdentifierClientBridge)?._0002() ?? false;
		}

		bool IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0007();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private new int _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (_EventIssuer as IdentifierClientBridge)?._0001() ?? 0;
		}

		int IdentifierClientBridge._0001()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0004();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int _0005()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return (_EventIssuer as IdentifierClientBridge)?._0002() ?? 0;
		}

		int IdentifierClientBridge._0002()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0005();
		}
	}
}
