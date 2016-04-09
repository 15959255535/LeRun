/*
 * Created by SharpDevelop.
 * User: HT先生
 * Date: 2016/4/9
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LeRun.Common.Design
{
    /// <summary>参照<see cref="IDesignBase" />说明</summary>
	public class DesignBase:IDesignBase
	{
		private string _name;
	    private string _displayName;
		
		/// <summary>参照<see cref="IDesignBase.Name" />说明</summary>
		public string Name
		{
			get{return _name;}
			set{_name=value;}
		}

		/// <summary>参照<see cref="IDesignBase.DisplayName" />说明</summary>		
		public string DisplayName
		{
			get{return _displayName;}
			set{_displayName=value;}
		}
	}
	
	/// <summary>参照<see cref="IDataFieldDesign" />说明</summary>
	public class DataFieldDesign:DesignBase,IDataFieldDesign
	{
		private LRDataType _dataType;
		private LRFieldKind _fieldKind;
		
		/// <summary>参照<see cref="IDataFieldDesign.DataType" />说明</summary>
		public LRDataType DataType
		{
			get{return _dataType;}
			set{_dataType=value;}
		}
		
        /// <summary>参照<see cref="IDataFieldDesign.FieldKind" />说明</summary>
		public LRFieldKind FieldKind
		{
			get{return _fieldKind;}
			set{_fieldKind=value;}
		}

		/// <summary>参照<see cref="IDataFieldDesign.FieldName" />说明</summary>
		public string FieldName 
		{
			get {return Name;}
		}
	}
}
