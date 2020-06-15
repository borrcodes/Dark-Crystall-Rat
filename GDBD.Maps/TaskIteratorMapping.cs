using GDBD.Bridges;
using GDBD.Dispatcher;
using GDBD.Strategies;
using GDBD.Structs;
using GDBD.Workers;
using Newtonsoft.Candidates;
using Newtonsoft.Expressions;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace GDBD.Maps
{
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	internal sealed class TaskIteratorMapping : RecordClassDispatcher
	{
		private readonly DefinitionPropertyStruct m_ComposerReader;

		private SystemPropertyStruct _PropertyReader;

		private SystemPropertyStruct _IssuerReader;

		private string readerReader;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void _0001(WatcherComposer task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(task);
			ViewIterator();
			if (base._0002() == 0)
			{
				m_ComposerReader.AddIterator(_PropertyReader);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0005(string i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw CollectionComposer.ListTest(this, "Cannot write JSON comment as BSON.", null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw CollectionComposer.ListTest(this, "Cannot write JSON constructor as BSON.", null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw CollectionComposer.ListTest(this, "Cannot write raw JSON as BSON.", null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0006(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			throw CollectionComposer.ListTest(this, "Cannot write raw JSON as BSON.", null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0003();
			VisitIterator(new InitializerComposerWorker());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0002();
			VisitIterator(new TemplateIssuer());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0002(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0002(setup);
			readerReader = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001();
			if (base._0001())
			{
				m_ComposerReader?.CompareIterator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void VisitIterator(SystemPropertyStruct def)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveIterator(def);
			_IssuerReader = def;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ViewIterator()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_IssuerReader = _IssuerReader._0001();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConnectIterator(object param, ChildRunStatus map)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			MoveIterator(new ValueRequestStrategy(param, map));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void MoveIterator(SystemPropertyStruct info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_IssuerReader != null)
			{
				TemplateIssuer templateIssuer = _IssuerReader as TemplateIssuer;
				if (templateIssuer != null)
				{
					templateIssuer.CloneIterator(readerReader, info);
					readerReader = null;
				}
				else
				{
					((InitializerComposerWorker)_IssuerReader).LogoutIterator(info);
				}
			}
			else
			{
				if (info._0001() != (ChildRunStatus)3 && info._0001() != (ChildRunStatus)4)
				{
					throw CollectionComposer.ListTest(this, "Error writing {0} value. BSON must start with an Object or Array.".ListReader(CultureInfo.InvariantCulture, info._0001()), null);
				}
				_IssuerReader = info;
				_PropertyReader = info;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(object reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (reference is BigInteger)
			{
				BigInteger bigInteger = (BigInteger)reference;
				RateTest(WatcherComposer.Integer, null);
				MoveIterator(new FilterReader(bigInteger.ToByteArray(), (FileFormatVersions)0));
			}
			else
			{
				base._0001(reference);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0008();
			MoveIterator(DefinitionErrorFilter.m_ObjectIssuer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _000E()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._000E();
			MoveIterator(DefinitionErrorFilter.m_SchemaIssuer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0004(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0004(first);
			MoveIterator((first == null) ? DefinitionErrorFilter.m_ObjectIssuer : new ParameterRequestStrategy(first, haveb: true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(int offset_value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(offset_value);
			ConnectIterator(offset_value, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(uint start_instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (start_instance > int.MaxValue)
			{
				throw CollectionComposer.ListTest(this, "Value is too large to fit in a signed 32 bit integer. BSON does not support unsigned values.", null);
			}
			base._0001(start_instance);
			ConnectIterator(start_instance, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(long flagsvar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(flagsvar1);
			ConnectIterator(flagsvar1, (ChildRunStatus)18);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ulong positionvar1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (positionvar1 > long.MaxValue)
			{
				throw CollectionComposer.ListTest(this, "Value is too large to fit in a signed 64 bit integer. BSON does not support unsigned values.", null);
			}
			base._0001(positionvar1);
			ConnectIterator(positionvar1, (ChildRunStatus)18);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(float task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(task);
			ConnectIterator(task, (ChildRunStatus)1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(double key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(key);
			ConnectIterator(key, (ChildRunStatus)1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(bool useitem)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(useitem);
			MoveIterator(useitem ? IdentifierPropertyStruct._ProcIssuer : IdentifierPropertyStruct.comparatorIssuer);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(short columninit)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(columninit);
			ConnectIterator(columninit, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(ushort init_high)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(init_high);
			ConnectIterator(init_high, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(char task)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(task);
			string text = null;
			text = task.ToString(CultureInfo.InvariantCulture);
			MoveIterator(new ParameterRequestStrategy(text, haveb: true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte lastend)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(lastend);
			ConnectIterator(lastend, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CLSCompliant(false)]
		public override void _0001(sbyte i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(i);
			ConnectIterator(i, (ChildRunStatus)16);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(decimal reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(reference);
			ConnectIterator(reference, (ChildRunStatus)1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTime info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(info);
			info = DescriptorIteratorMapping.ReadProperty(info, base._0001());
			ConnectIterator(info, (ChildRunStatus)9);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(DateTimeOffset instance)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(instance);
			ConnectIterator(instance, (ChildRunStatus)9);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(byte[] spec)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (spec == null)
			{
				_0008();
				return;
			}
			base._0001(spec);
			MoveIterator(new FilterReader(spec, (FileFormatVersions)0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Guid item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(item);
			MoveIterator(new FilterReader(item.ToByteArray(), (FileFormatVersions)4));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(TimeSpan first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			base._0001(first);
			MoveIterator(new ParameterRequestStrategy(first.ToString(), haveb: true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void _0001(Uri var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (var1 == null)
			{
				_0008();
				return;
			}
			base._0001(var1);
			MoveIterator(new ParameterRequestStrategy(var1.ToString(), haveb: true));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopIterator(byte[] value)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(value, "value");
			if (value.Length != 12)
			{
				throw CollectionComposer.ListTest(this, "An object id must be 12 bytes", null);
			}
			RateTest(WatcherComposer.Undefined, null);
			ConnectIterator(value, (ChildRunStatus)7);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void NewIterator(string ident, string b)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ContextClientBridge.RunClient(ident, "pattern");
			RateTest(WatcherComposer.Undefined, null);
			MoveIterator(new MapperComposerPool(ident, b));
		}
	}
}
