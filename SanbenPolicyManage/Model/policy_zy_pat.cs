using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_zy_pat:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_zy_pat
	{
		public policy_zy_pat()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _application_space;
		private bool _patcheck;
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
		public bool patCheck
		{
			set{ _patcheck=value;}
			get{return _patcheck;}
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

