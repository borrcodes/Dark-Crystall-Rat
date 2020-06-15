using _0008;
using GDBD.Workers;
using Newtonsoft.Expressions;
using System;
using System.Runtime.CompilerServices;

namespace GDBD.Strategies
{
	[_0008._0012(0)]
	internal sealed class ContextRequestStrategy : ObjectDic
	{
		[_0008._0012(0)]
		private sealed class ExpressionDic
		{
			internal readonly string _ConfigDic;

			internal readonly int connectionDic;

			internal ExpressionDic initializerDic;

			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ExpressionDic(string instance, int num_cont, ExpressionDic third)
			{
				//Discarded unreachable code: IL_0002, IL_0006
				//IL_0003: Incompatible stack heights: 0 vs 1
				//IL_0007: Incompatible stack heights: 0 vs 1
				SingletonReader.PushGlobal();
				base._002Ector();
				_ConfigDic = instance;
				connectionDic = num_cont;
				initializerDic = third;
			}
		}

		private static readonly int globalDic;

		private int m_WrapperDic;

		private ExpressionDic[] _ParamsDic;

		private int _TemplateDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static ContextRequestStrategy()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			globalDic = Environment.TickCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ContextRequestStrategy()
		{
			//Discarded unreachable code: IL_0002, IL_0006
			//IL_0003: Incompatible stack heights: 0 vs 1
			//IL_0007: Incompatible stack heights: 0 vs 1
			SingletonReader.PushGlobal();
			_TemplateDic = 31;
			base._002Ector();
			_ParamsDic = new ExpressionDic[_TemplateDic + 1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string _0001(char[] value, int caller_counter, int indexOf_util)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (indexOf_util == 0)
			{
				return string.Empty;
			}
			int num = indexOf_util + globalDic;
			num += ((num << 7) ^ value[caller_counter]);
			int num2 = caller_counter + indexOf_util;
			for (int i = caller_counter + 1; i < num2; i++)
			{
				num += ((num << 7) ^ value[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			int num3 = num & _TemplateDic;
			for (ExpressionDic expressionDic = _ParamsDic[num3]; expressionDic != null; expressionDic = expressionDic.initializerDic)
			{
				if (expressionDic.connectionDic == num && NewError(expressionDic._ConfigDic, value, caller_counter, indexOf_util))
				{
					return expressionDic._ConfigDic;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ConnectError(string res)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (res == null)
			{
				throw new ArgumentNullException("key");
			}
			int length = res.Length;
			if (length == 0)
			{
				return string.Empty;
			}
			int num = length + globalDic;
			for (int i = 0; i < res.Length; i++)
			{
				num += ((num << 7) ^ res[i]);
			}
			num -= num >> 17;
			num -= num >> 11;
			num -= num >> 5;
			for (ExpressionDic expressionDic = _ParamsDic[num & _TemplateDic]; expressionDic != null; expressionDic = expressionDic.initializerDic)
			{
				if (expressionDic.connectionDic == num && expressionDic._ConfigDic.Equals(res, StringComparison.Ordinal))
				{
					return expressionDic._ConfigDic;
				}
			}
			return MoveError(res, num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string MoveError(string v, int map_length)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			int num = map_length & _TemplateDic;
			ExpressionDic expressionDic = new ExpressionDic(v, map_length, _ParamsDic[num]);
			_ParamsDic[num] = expressionDic;
			if (m_WrapperDic++ == _TemplateDic)
			{
				PopError();
			}
			return expressionDic._ConfigDic;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PopError()
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			ExpressionDic[] paramsDic = _ParamsDic;
			int num = _TemplateDic * 2 + 1;
			ExpressionDic[] array = new ExpressionDic[num + 1];
			for (int i = 0; i < paramsDic.Length; i++)
			{
				ExpressionDic expressionDic = paramsDic[i];
				while (expressionDic != null)
				{
					int num2 = expressionDic.connectionDic & num;
					ExpressionDic initializerDic = expressionDic.initializerDic;
					expressionDic.initializerDic = array[num2];
					array[num2] = expressionDic;
					expressionDic = initializerDic;
				}
			}
			_ParamsDic = array;
			_TemplateDic = num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool NewError(string config, char[] pol, int position_tag, int endmap2)
		{
			//Discarded unreachable code: IL_0002
			//IL_0003: Incompatible stack heights: 0 vs 1
			if (config.Length != endmap2)
			{
				return false;
			}
			for (int i = 0; i < config.Length; i++)
			{
				if (config[i] != pol[position_tag + i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
