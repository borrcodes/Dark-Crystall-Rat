using GDBD.Items;
using GDBD.Strategies;
using GDBD.Workers;
using Newtonsoft.Candidates;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Newtonsoft.Common
{
	internal sealed class ExceptionEvent : IComparable
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string m_AttributeEvent;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string _DatabaseEvent;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get;
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		public string DisableInstance()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			return _DatabaseEvent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private void VerifyInstance(string setup)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			_DatabaseEvent = setup;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ExceptionEvent(string asset)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			VerifyInstance(asset);
			Name = RevertList(asset);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ExceptionEvent(IMoniker value)
		{
			//Discarded unreachable code: IL_0002, IL_0006, IL_0012, IL_0019
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			//IL_0013: Incompatible stack heights: 0 vs 1
			//IL_001a: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			base._002Ector();
			VerifyInstance(PublishList(value));
			Name = WriteList(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int _0001(object res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ExceptionEvent exceptionEvent = (ExceptionEvent)res;
			if (exceptionEvent == null)
			{
				return 1;
			}
			return Name.CompareTo(exceptionEvent.Name);
		}

		int IComparable.CompareTo(object res)
		{
			//ILSpy generated this explicit interface implementation from .override directive in 
			return this._0001(res);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object CallList(string key)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object ppvResult = null;
			IBindCtx selection = null;
			IMoniker res = null;
			int third = 0;
			if (AdvisorRequestStrategy.ExcludeInstance(0, out selection) == 0)
			{
				if (AdvisorRequestStrategy.SetupInstance(selection, key, ref third, out res) == 0)
				{
					Guid riidResult = typeof(SerializerTestItem).GUID;
					res.BindToObject(null, null, ref riidResult, out ppvResult);
					Marshal.ReleaseComObject(res);
				}
				Marshal.ReleaseComObject(selection);
			}
			return ppvResult;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string PublishList(IMoniker res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			res.GetDisplayName(null, null, out string ppszDisplayName);
			return ppszDisplayName;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string WriteList(IMoniker init)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			object ppvObj = null;
			ConsumerEvent consumerEvent = null;
			try
			{
				Guid riid = typeof(ConsumerEvent).GUID;
				init.BindToStorage(null, null, ref riid, out ppvObj);
				consumerEvent = (ConsumerEvent)ppvObj;
				object token = "";
				int num = consumerEvent._0001("FriendlyName", ref token, IntPtr.Zero);
				if (num != 0)
				{
					Marshal.ThrowExceptionForHR(num);
				}
				string text = (string)token;
				if (text == null || text.Length < 1)
				{
					throw new ApplicationException();
				}
				return text;
			}
			catch (Exception)
			{
				return "";
			}
			finally
			{
				consumerEvent = null;
				if (ppvObj != null)
				{
					Marshal.ReleaseComObject(ppvObj);
					ppvObj = null;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string RevertList(string reference)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			IBindCtx selection = null;
			IMoniker res = null;
			string result = "";
			int third = 0;
			if (AdvisorRequestStrategy.ExcludeInstance(0, out selection) == 0)
			{
				if (AdvisorRequestStrategy.SetupInstance(selection, reference, ref third, out res) == 0)
				{
					result = WriteList(res);
					Marshal.ReleaseComObject(res);
					res = null;
				}
				Marshal.ReleaseComObject(selection);
				selection = null;
			}
			return result;
		}
	}
}
