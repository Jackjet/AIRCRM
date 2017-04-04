﻿using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_zy_addPrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_zy_addPrice
	{
		public policy_zy_addPrice()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _application_space;
		private bool _jisuanbase;
		private string _converttype;
		private decimal? _addvalue;
		private int? _platform_id;
		private int _sys_id;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string navigation_company
		{
			set{ _navigation_company=value;}
			get{return _navigation_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string air_line
		{
			set{ _air_line=value;}
			get{return _air_line;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string application_space
		{
			set{ _application_space=value;}
			get{return _application_space;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool jisuanbase
		{
			set{ _jisuanbase=value;}
			get{return _jisuanbase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string convertType
		{
			set{ _converttype=value;}
			get{return _converttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? addValue
		{
			set{ _addvalue=value;}
			get{return _addvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? platform_id
		{
			set{ _platform_id=value;}
			get{return _platform_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		#endregion Model

	}
}

