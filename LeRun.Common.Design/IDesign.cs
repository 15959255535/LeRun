/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2016/4/9
 * Time: 15:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace LeRun.Common.Design
{
	/// <summary>模型定义基接口</summary>
	public interface IDesignBase
	{
		string Name{get;}
		string DisplayName{get;}
	}
	
	/// <summary>字段定义接口</summary>
	public interface IFieldDesign:IDesignBase
	{
		/// <summary>字段名</summary>
		string FieldName{get;}
	}
	
	public interface IDataFieldDesign:IFieldDesign
	{
		
	}
	
	/// <summary>表定义接口</summary>
	public interface ITableDesign:IDesignBase
	{
		/// <summary>表名</summary>
		string TableName{get;}
	}
	
	/// <summary>功能定义接口</summary>
	public interface ISourceDesign:IDesignBase
	{
		/// <summary>功能名</summary>
		string SourceName{get;}
	}
}