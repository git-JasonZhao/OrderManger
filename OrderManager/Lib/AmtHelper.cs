using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Lib
{
	public class AmtHelper
	{
		/// <summary>
		/// 定义好大写的数字
		/// </summary>
		private const string CHNumber = "零壹贰叁肆伍陆柒捌玖";

		/// <summary>
		/// 定义好数位,从小到大排
		/// </summary>
		private const string IntegerPart = "元拾佰仟万拾佰仟亿拾佰仟万";

		/// <summary>
		/// 把整数和小数分开处理
		/// </summary>
		private const string DecimalPart = "角分";

		/// <summary>
		/// 将小写金额转换为中文金额（大写金额）
		/// </summary>
		/// <param name="amt">小写金额</param>
		/// <returns></returns>
		public static string ToCHAmt(string amt)
		{
			string result = string.Empty;
			if (amt.Contains('.'))//检测用户输入中是否包含小数点
			{
				string[] temp = amt.Split('.');//把用户输入的字符
				int index = temp[0].Length - 1;
				for (int i = 0; i < temp[0].Length; i++)
				{
					result += CHNumber[Convert.ToInt32(temp[0][i].ToString())];
					result += IntegerPart[index];
					index--;
				}
				if (temp[1].Length > 0)
				{
					for (int i = 0; i < temp[1].Length; i++)
					{
						result += CHNumber[Convert.ToInt32(temp[1][i].ToString())];
						result += DecimalPart[i];
					}
				}
			}
			else
			{
				int index = amt.Length - 1;
				for (int i = 0; i < amt.Length; i++)
				{
					result += CHNumber[Convert.ToInt32(amt[i].ToString())];
					result += IntegerPart[index];
					index--;
				}
				result += "整";
			}
			return result;
		}

		/// <summary>
		/// 将小写金额转换为中文金额（大写金额）
		/// </summary>
		/// <param name="amt">小写金额</param>
		/// <returns></returns>
		public static string ToCHAmt(int amt)
		{
			return ToCHAmt(amt.ToString());
		}

		/// <summary>
		/// 将小写金额转换为中文金额（大写金额）
		/// </summary>
		/// <param name="amt">小写金额</param>
		/// <returns></returns>
		public static string ToCHAmt(float amt)
		{
			return ToCHAmt(amt.ToString());
		}

		/// <summary>
		/// 将小写金额转换为中文金额（大写金额）
		/// </summary>
		/// <param name="amt">小写金额</param>
		/// <returns></returns>
		public static string ToCHAmt(double amt)
		{
			return ToCHAmt(amt.ToString());
		}

		/// <summary>
		/// 将小写金额转换为中文金额（大写金额）
		/// </summary>
		/// <param name="amt">小写金额</param>
		/// <returns></returns>
		public static string ToCHAmt(decimal amt)
		{
			return ToCHAmt(amt.ToString());
		}
	}
}
