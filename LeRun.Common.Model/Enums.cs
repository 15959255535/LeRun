/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/4/9
 * Time: 15:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LeRun.Common.Model
{
	/// <summary>数据类型</summary>
	public enum LRDataType
	{
		/// <summary>整形</summary>
		Int = 1,
		/// <summary>长整形</summary>
		Long = 2,
		/// <summary>数值型</summary>
		Decimal = 3,
		/// <summary>字符</summary>
		ASCII = 4,
		/// <summary>Unicode</summary>
		Unicode = 5,
		/// <summary>时间</summary>
		DateTime = 6,
		/// <summary>布尔型</summary>
		Boolean=7
	}
	
	/// <summary>字段类型</summary>
	public enum LRFieldKind
	{
		/// <summary>实字段</summary>
		Actual=1,
		/// <summary>虚字段</summary>
		Virtual=2
	}
}
