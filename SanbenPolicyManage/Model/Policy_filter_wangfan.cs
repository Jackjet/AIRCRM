﻿using System;
namespace Sanben.Model
{
	/// <summary>
	/// Policy_filter_wangfan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Policy_filter_wangfan
	{
		public Policy_filter_wangfan()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _qucheng_space;
		private string _huicheng_space;
		private bool _limit_type;
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
		public string qucheng_space
		{
			set{ _qucheng_space=value;}
			get{return _qucheng_space;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huicheng_space
		{
			set{ _huicheng_space=value;}
			get{return _huicheng_space;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool limit_type
		{
			set{ _limit_type=value;}
			get{return _limit_type;}
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

