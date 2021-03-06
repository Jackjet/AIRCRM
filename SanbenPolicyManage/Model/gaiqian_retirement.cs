﻿using System;
namespace Sanben.Model
{
	/// <summary>
	/// gaiqian_retirement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class gaiqian_retirement
	{
		public gaiqian_retirement()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _application_space;
		private bool _initiate_mode;
		private DateTime _startdate;
		private DateTime _enddate;
		private string _refund_rule;
		private string _changedate_rule;
		private bool _is_allowed_sign;
		private int _sys_id;
		private int _platform_type_id;
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
		public bool initiate_mode
		{
			set{ _initiate_mode=value;}
			get{return _initiate_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime startDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime endDate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string refund_rule
		{
			set{ _refund_rule=value;}
			get{return _refund_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string changedate_rule
		{
			set{ _changedate_rule=value;}
			get{return _changedate_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_allowed_sign
		{
			set{ _is_allowed_sign=value;}
			get{return _is_allowed_sign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int platform_type_id
		{
			set{ _platform_type_id=value;}
			get{return _platform_type_id;}
		}
		#endregion Model

	}
}

