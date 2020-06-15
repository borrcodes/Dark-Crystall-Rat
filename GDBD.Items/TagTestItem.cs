using _0008;
using GDBD.Bridges;
using GDBD.Importers;
using GDBD.Maps;
using GDBD.Workers;
using Newtonsoft.Annotations;
using Newtonsoft.Candidates;
using Newtonsoft.Consumers;
using Newtonsoft.Database;
using Newtonsoft.Filters;
using Newtonsoft.Pools;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace GDBD.Items
{
	[global::_0008._0012(0)]
	internal abstract class TagTestItem : IDisposable
	{
		protected internal enum MethodAttributes
		{

		}

		private WatcherComposer facadeError;

		private object _ManagerError;

		internal char m_StateError;

		internal MethodAttributes resolverError;

		private QueueError _PoolError;

		private CultureInfo valError;

		private PsMaxLengths _InvocationError;

		private int? definitionError;

		private bool m_SystemError;

		internal StubListAnnotation _IdentifierError;

		internal SudsUse m_GetterError;

		private string setterError;

		private List<QueueError> workerError;

		[CompilerGenerated]
		private bool m_AdvisorError;

		[CompilerGenerated]
		private bool _RulesError;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected MethodAttributes _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return resolverError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_AdvisorError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0001(bool isparam)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			m_AdvisorError = isparam;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public bool _0004()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _RulesError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public void _0002(bool includelast)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_RulesError = includelast;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PsMaxLengths _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _InvocationError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(PsMaxLengths info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (info < (PsMaxLengths)0 || info > (PsMaxLengths)3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_InvocationError = info;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StubListAnnotation _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _IdentifierError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(StubListAnnotation setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (setup < (StubListAnnotation)0 || setup > (StubListAnnotation)2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			_IdentifierError = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SudsUse _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return m_GetterError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(SudsUse ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (ident < (SudsUse)0 || ident > (SudsUse)1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			m_GetterError = ident;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return setterError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(string var1)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			setterError = var1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int? _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return definitionError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(int? v)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (v <= 0)
			{
				throw new ArgumentException("Value must be positive.", "value");
			}
			definitionError = v;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual WatcherComposer _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return facadeError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual object _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ManagerError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Type _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _ManagerError?.GetType();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int _0003()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = workerError?.Count ?? 0;
			if (RulesClientBridge.GetIssuer(this._0001()) || _PoolError._RegistryError == tagURLTEMPLATE.None)
			{
				return num;
			}
			return num + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0002()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_PoolError._RegistryError == tagURLTEMPLATE.None)
			{
				return string.Empty;
			}
			QueueError? ord = (resolverError != (MethodAttributes)5 && resolverError != (MethodAttributes)9 && resolverError != (MethodAttributes)3) ? new QueueError?(_PoolError) : null;
			return QueueError.SearchError(workerError, ord);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CultureInfo _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return valError ?? CultureInfo.InvariantCulture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void _0001(CultureInfo res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			valError = res;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal QueueError DestroyError(int size_i)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (workerError != null && size_i < workerError.Count)
			{
				return workerError[size_i];
			}
			return _PoolError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TagTestItem()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			resolverError = (MethodAttributes)0;
			_InvocationError = (PsMaxLengths)3;
			_IdentifierError = (StubListAnnotation)1;
			m_GetterError = (SudsUse)0;
			_0001(isparam: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetError(tagURLTEMPLATE ident)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			SetupError();
			if (_PoolError._RegistryError == tagURLTEMPLATE.None)
			{
				_PoolError = new QueueError(ident);
				return;
			}
			if (workerError == null)
			{
				workerError = new List<QueueError>();
			}
			workerError.Add(_PoolError);
			_PoolError = new QueueError(ident);
			if (!definitionError.HasValue || !(this._0003() + 1 > definitionError) || m_SystemError)
			{
				return;
			}
			m_SystemError = true;
			throw ContextError.CheckComposer(this, "The reader's MaxDepth of {0} has been exceeded.".ListReader(CultureInfo.InvariantCulture, definitionError));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private tagURLTEMPLATE RateError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			QueueError poolError;
			if (workerError != null && workerError.Count > 0)
			{
				poolError = _PoolError;
				_PoolError = workerError[workerError.Count - 1];
				workerError.RemoveAt(workerError.Count - 1);
			}
			else
			{
				poolError = _PoolError;
				_PoolError = default(QueueError);
			}
			if (definitionError.HasValue && this._0003() <= definitionError)
			{
				m_SystemError = false;
			}
			return poolError._RegistryError;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private tagURLTEMPLATE RemoveError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _PoolError._RegistryError;
		}

		public abstract bool _0001();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			{
				object obj = this._0001();
				if (obj is int)
				{
					return (int)obj;
				}
				int num;
				if (obj is BigInteger)
				{
					BigInteger value = (BigInteger)obj;
					num = (int)value;
				}
				else
				{
					try
					{
						num = Convert.ToInt32(obj, CultureInfo.InvariantCulture);
					}
					catch (Exception field)
					{
						throw ContextError.DisableComposer(this, "Could not convert to integer: {0}.".ListReader(CultureInfo.InvariantCulture, obj), field);
					}
				}
				CancelError(WatcherComposer.Integer, num, isstate: false);
				return num;
			}
			case WatcherComposer.String:
			{
				string param = (string)this._0001();
				return PostError(param);
			}
			default:
				throw ContextError.CheckComposer(this, "Error reading integer. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int? PostError(string param)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(param))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (int.TryParse(param, NumberStyles.Integer, this._0001(), out int result))
			{
				CancelError(WatcherComposer.Integer, result, isstate: false);
				return result;
			}
			CancelError(WatcherComposer.String, param, isstate: false);
			throw ContextError.CheckComposer(this, "Could not convert string to integer: {0}.".ListReader(CultureInfo.InvariantCulture, param));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.String:
				return (string)this._0001();
			default:
				if (RulesClientBridge.StartIssuer(watcherComposer))
				{
					object obj = this._0001();
					if (obj != null)
					{
						IFormattable formattable = obj as IFormattable;
						string text;
						if (formattable != null)
						{
							text = formattable.ToString(null, this._0001());
						}
						else
						{
							Uri uri = obj as Uri;
							text = (((object)uri != null) ? uri.OriginalString : obj.ToString());
						}
						CancelError(WatcherComposer.String, text, isstate: false);
						return text;
					}
				}
				throw ContextError.CheckComposer(this, "Error reading string. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual byte[] _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.StartObject:
			{
				CountError();
				byte[] array3 = this._0001();
				InvokeError();
				if (this._0001() != WatcherComposer.EndObject)
				{
					throw ContextError.CheckComposer(this, "Error reading bytes. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, this._0001()));
				}
				CancelError(WatcherComposer.Bytes, array3, isstate: false);
				return array3;
			}
			case WatcherComposer.String:
			{
				string text = (string)this._0001();
				Guid connection;
				byte[] array2 = (text.Length == 0) ? ObserverIteratorMapping.CheckProperty<byte>() : ((!HelperDicCandidate.VisitProperty(text, out connection)) ? Convert.FromBase64String(text) : connection.ToByteArray());
				CancelError(WatcherComposer.Bytes, array2, isstate: false);
				return array2;
			}
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Bytes:
			{
				object obj = this._0001();
				if (obj is Guid)
				{
					byte[] array = ((Guid)obj).ToByteArray();
					CancelError(WatcherComposer.Bytes, array, isstate: false);
					return array;
				}
				return (byte[])this._0001();
			}
			case WatcherComposer.StartArray:
				return ChangeError();
			default:
				throw ContextError.CheckComposer(this, "Error reading bytes. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] ChangeError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			List<byte> list = new List<byte>();
			do
			{
				if (!this._0001())
				{
					CustomizeError(WatcherComposer.None);
				}
			}
			while (!CalculateError(list));
			byte[] array = list.ToArray();
			CancelError(WatcherComposer.Bytes, array, isstate: false);
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CalculateError(List<byte> reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (this._0001())
			{
			case WatcherComposer.None:
				throw ContextError.CheckComposer(this, "Unexpected end when reading bytes.");
			case WatcherComposer.Integer:
				reference.Add(Convert.ToByte(this._0001(), CultureInfo.InvariantCulture));
				return false;
			case WatcherComposer.EndArray:
				return true;
			case WatcherComposer.Comment:
				return false;
			default:
				throw ContextError.CheckComposer(this, "Unexpected token when reading bytes: {0}.".ListReader(CultureInfo.InvariantCulture, this._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual double? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			{
				object obj = this._0001();
				if (obj is double)
				{
					return (double)obj;
				}
				double num;
				if (obj is BigInteger)
				{
					BigInteger value = (BigInteger)obj;
					num = (double)value;
				}
				else
				{
					num = Convert.ToDouble(obj, CultureInfo.InvariantCulture);
				}
				CancelError(WatcherComposer.Float, num, isstate: false);
				return num;
			}
			case WatcherComposer.String:
				return GetError((string)this._0001());
			default:
				throw ContextError.CheckComposer(this, "Error reading double. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double? GetError(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(first))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (double.TryParse(first, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, this._0001(), out double result))
			{
				CancelError(WatcherComposer.Float, result, isstate: false);
				return result;
			}
			CancelError(WatcherComposer.String, first, isstate: false);
			throw ContextError.CheckComposer(this, "Could not convert string to double: {0}.".ListReader(CultureInfo.InvariantCulture, first));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			{
				object obj = this._0001();
				bool flag;
				if (obj is BigInteger)
				{
					BigInteger left = (BigInteger)obj;
					flag = (left != 0L);
				}
				else
				{
					flag = Convert.ToBoolean(this._0001(), CultureInfo.InvariantCulture);
				}
				CancelError(WatcherComposer.Boolean, flag, isstate: false);
				return flag;
			}
			case WatcherComposer.String:
				return StartError((string)this._0001());
			case WatcherComposer.Boolean:
				return (bool)this._0001();
			default:
				throw ContextError.CheckComposer(this, "Error reading boolean. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool? StartError(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(first))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (bool.TryParse(first, out bool result))
			{
				CancelError(WatcherComposer.Boolean, result, isstate: false);
				return result;
			}
			CancelError(WatcherComposer.String, first, isstate: false);
			throw ContextError.CheckComposer(this, "Could not convert string to boolean: {0}.".ListReader(CultureInfo.InvariantCulture, first));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual decimal? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			{
				object obj = this._0001();
				if (obj is decimal)
				{
					return (decimal)obj;
				}
				decimal num;
				if (obj is BigInteger)
				{
					BigInteger value = (BigInteger)obj;
					num = (decimal)value;
				}
				else
				{
					try
					{
						num = Convert.ToDecimal(obj, CultureInfo.InvariantCulture);
					}
					catch (Exception field)
					{
						throw ContextError.DisableComposer(this, "Could not convert to decimal: {0}.".ListReader(CultureInfo.InvariantCulture, obj), field);
					}
				}
				CancelError(WatcherComposer.Float, num, isstate: false);
				return num;
			}
			case WatcherComposer.String:
				return SelectError((string)this._0001());
			default:
				throw ContextError.CheckComposer(this, "Error reading decimal. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal decimal? SelectError(string first)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(first))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (decimal.TryParse(first, NumberStyles.Number, this._0001(), out decimal result))
			{
				CancelError(WatcherComposer.Float, result, isstate: false);
				return result;
			}
			if (HelperDicCandidate.LogoutProperty(first.ToCharArray(), 0, first.Length, out result) == (TYMED)1)
			{
				CancelError(WatcherComposer.Float, result, isstate: false);
				return result;
			}
			CancelError(WatcherComposer.String, first, isstate: false);
			throw ContextError.CheckComposer(this, "Could not convert string to decimal: {0}.".ListReader(CultureInfo.InvariantCulture, first));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual DateTime? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (LoginComposer())
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Date:
			{
				object obj = this._0001();
				if (obj is DateTimeOffset)
				{
					CancelError(WatcherComposer.Date, ((DateTimeOffset)obj).DateTime, isstate: false);
				}
				return (DateTime)this._0001();
			}
			case WatcherComposer.String:
				return DeleteError((string)this._0001());
			default:
				throw ContextError.CheckComposer(this, "Error reading date. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, this._0001()));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTime? DeleteError(string info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(info))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (DescriptorIteratorMapping.RemoveProperty(info, this._0001(), setterError, this._0001(), out DateTime res))
			{
				res = DescriptorIteratorMapping.ReadProperty(res, this._0001());
				CancelError(WatcherComposer.Date, res, isstate: false);
				return res;
			}
			if (DateTime.TryParse(info, this._0001(), DateTimeStyles.RoundtripKind, out res))
			{
				res = DescriptorIteratorMapping.ReadProperty(res, this._0001());
				CancelError(WatcherComposer.Date, res, isstate: false);
				return res;
			}
			throw ContextError.CheckComposer(this, "Could not convert string to DateTime: {0}.".ListReader(CultureInfo.InvariantCulture, info));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual DateTimeOffset? _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = LoginComposer();
			switch (watcherComposer)
			{
			case WatcherComposer.None:
			case WatcherComposer.Null:
			case WatcherComposer.EndArray:
				return null;
			case WatcherComposer.Date:
			{
				object obj = this._0001();
				if (obj is DateTime)
				{
					DateTime dateTime = (DateTime)obj;
					CancelError(WatcherComposer.Date, new DateTimeOffset(dateTime), isstate: false);
				}
				return (DateTimeOffset)this._0001();
			}
			case WatcherComposer.String:
			{
				string info = (string)this._0001();
				return ConcatError(info);
			}
			default:
				throw ContextError.CheckComposer(this, "Error reading date. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, watcherComposer));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTimeOffset? ConcatError(string info)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (SetterTest.StartReader(info))
			{
				CancelError(WatcherComposer.Null, null, isstate: false);
				return null;
			}
			if (DescriptorIteratorMapping.ChangeProperty(info, setterError, this._0001(), out DateTimeOffset connection))
			{
				CancelError(WatcherComposer.Date, connection, isstate: false);
				return connection;
			}
			if (DateTimeOffset.TryParse(info, this._0001(), DateTimeStyles.RoundtripKind, out connection))
			{
				CancelError(WatcherComposer.Date, connection, isstate: false);
				return connection;
			}
			CancelError(WatcherComposer.String, info, isstate: false);
			throw ContextError.CheckComposer(this, "Could not convert string to DateTimeOffset: {0}.".ListReader(CultureInfo.InvariantCulture, info));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InvokeError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!this._0001())
			{
				throw PrintError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ContextError PrintError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return ContextError.CheckComposer(this, "Unexpected end when reading JSON.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CountError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			InvokeError();
			if (this._0001() != null && this._0001().ToString() == "$type")
			{
				InvokeError();
				if (this._0001() != null && this._0001().ToString().StartsWith("System.Byte[]", StringComparison.Ordinal))
				{
					InvokeError();
					if (this._0001().ToString() == "$value")
					{
						return;
					}
				}
			}
			throw ContextError.CheckComposer(this, "Error reading bytes. Unexpected token: {0}.".ListReader(CultureInfo.InvariantCulture, WatcherComposer.StartObject));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssetError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001() == WatcherComposer.PropertyName)
			{
				this._0001();
			}
			if (RulesClientBridge.GetIssuer(this._0001()))
			{
				int num = this._0003();
				while (this._0001() && num < this._0003())
				{
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CustomizeError(WatcherComposer asset)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CancelError(asset, null, isstate: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void QueryError(WatcherComposer i, object cfg)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			CancelError(i, cfg, isstate: true);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CancelError(WatcherComposer instance, object reg, bool isstate)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			facadeError = instance;
			_ManagerError = reg;
			switch (instance)
			{
			case WatcherComposer.Comment:
				break;
			case WatcherComposer.StartObject:
				resolverError = (MethodAttributes)3;
				SetError(tagURLTEMPLATE.Object);
				break;
			case WatcherComposer.StartArray:
				resolverError = (MethodAttributes)5;
				SetError(tagURLTEMPLATE.Array);
				break;
			case WatcherComposer.StartConstructor:
				resolverError = (MethodAttributes)9;
				SetError(tagURLTEMPLATE.Constructor);
				break;
			case WatcherComposer.EndObject:
				ManageError(WatcherComposer.EndObject);
				break;
			case WatcherComposer.EndArray:
				ManageError(WatcherComposer.EndArray);
				break;
			case WatcherComposer.EndConstructor:
				ManageError(WatcherComposer.EndConstructor);
				break;
			case WatcherComposer.PropertyName:
				resolverError = (MethodAttributes)2;
				_PoolError.m_ConfigurationError = (string)reg;
				break;
			case WatcherComposer.Raw:
			case WatcherComposer.Integer:
			case WatcherComposer.Float:
			case WatcherComposer.String:
			case WatcherComposer.Boolean:
			case WatcherComposer.Null:
			case WatcherComposer.Undefined:
			case WatcherComposer.Date:
			case WatcherComposer.Bytes:
				ExcludeError(isstate);
				break;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ExcludeError(bool countitem)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (RemoveError() != 0 || _0004())
			{
				resolverError = (MethodAttributes)8;
			}
			else
			{
				DefineError();
			}
			if (countitem)
			{
				SetupError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (_PoolError.m_CandidateError)
			{
				_PoolError._AttrError++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ManageError(WatcherComposer config)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tagURLTEMPLATE tagURLTEMPLATE = RateError();
			if (CollectError(config) != tagURLTEMPLATE)
			{
				throw ContextError.CheckComposer(this, "JsonToken {0} is not valid for closing JsonType {1}.".SelectReader(CultureInfo.InvariantCulture, config, tagURLTEMPLATE));
			}
			if (RemoveError() != 0 || _0004())
			{
				resolverError = (MethodAttributes)8;
			}
			else
			{
				DefineError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InitError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			tagURLTEMPLATE tagURLTEMPLATE = RemoveError();
			switch (tagURLTEMPLATE)
			{
			case tagURLTEMPLATE.Object:
				resolverError = (MethodAttributes)4;
				break;
			case tagURLTEMPLATE.Array:
				resolverError = (MethodAttributes)6;
				break;
			case tagURLTEMPLATE.Constructor:
				resolverError = (MethodAttributes)10;
				break;
			case tagURLTEMPLATE.None:
				DefineError();
				break;
			default:
				throw ContextError.CheckComposer(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".ListReader(CultureInfo.InvariantCulture, tagURLTEMPLATE));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DefineError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			resolverError = ((!_0004()) ? ((MethodAttributes)12) : ((MethodAttributes)0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private tagURLTEMPLATE CollectError(WatcherComposer item)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			switch (item)
			{
			case WatcherComposer.EndObject:
				return tagURLTEMPLATE.Object;
			case WatcherComposer.EndArray:
				return tagURLTEMPLATE.Array;
			case WatcherComposer.EndConstructor:
				return tagURLTEMPLATE.Constructor;
			default:
				throw ContextError.CheckComposer(this, "Not a valid close JsonToken: {0}".ListReader(CultureInfo.InvariantCulture, item));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _0008()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_0004(assetopen: true);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			this._0008();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void _0004(bool assetopen)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (resolverError != (MethodAttributes)7 && assetopen)
			{
				this._0001();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void _0001()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			resolverError = (MethodAttributes)7;
			facadeError = WatcherComposer.None;
			_ManagerError = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SortError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!this._0001())
			{
				throw StrategyError.PatchComposer(this, "Unexpected end when reading JSON.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void CallError(ProcTest first, bool iscaller)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (!PublishError(first, iscaller))
			{
				throw StrategyError.PatchComposer(this, "Unexpected end when reading JSON.");
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool PublishError(ProcTest i, bool polstop)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (polstop)
			{
				return this._0001();
			}
			switch (i?.dicProperty ?? ((Docking)0))
			{
			case (Docking)0:
				return WriteError();
			case (Docking)1:
				this._0001();
				break;
			case (Docking)2:
			{
				bool result = WriteError();
				if (this._0001() == WatcherComposer.Undefined)
				{
					throw ContextError.CheckComposer(this, "An undefined token is not a valid {0}.".ListReader(CultureInfo.InvariantCulture, i?._0002() ?? typeof(long)));
				}
				return result;
			}
			case (Docking)5:
				this._0001();
				break;
			case (Docking)8:
				this._0001();
				break;
			case (Docking)3:
				this._0001();
				break;
			case (Docking)9:
				this._0001();
				break;
			case (Docking)4:
				this._0001();
				break;
			case (Docking)6:
				this._0001();
				break;
			case (Docking)7:
				this._0001();
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			return this._0001() != WatcherComposer.None;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool WriteError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (this._0001())
			{
				return RevertError();
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool RevertError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer = this._0001();
			while (watcherComposer == WatcherComposer.None || watcherComposer == WatcherComposer.Comment)
			{
				if (!this._0001())
				{
					return false;
				}
				watcherComposer = this._0001();
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private WatcherComposer LoginComposer()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			WatcherComposer watcherComposer;
			do
			{
				if (!this._0001())
				{
					CustomizeError(WatcherComposer.None);
					return WatcherComposer.None;
				}
				watcherComposer = this._0001();
			}
			while (watcherComposer == WatcherComposer.Comment);
			return watcherComposer;
		}
	}
}
