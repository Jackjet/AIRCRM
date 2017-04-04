using System;
namespace Sanben.Model
{
	/// <summary>
	/// SYSAdminRole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYSAdminRole
	{
		public SYSAdminRole()
		{}
		#region Model
		private int _id;
		private string _rolename;
		private bool _stop;
		private int? _ordering;
		private string _menulist;
		private string _authoritylist;
		private bool _ismodify;
		private string _remark;
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
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Stop
		{
			set{ _stop=value;}
			get{return _stop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Ordering
		{
			set{ _ordering=value;}
			get{return _ordering;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MenuList
		{
			set{ _menulist=value;}
			get{return _menulist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuthorityList
		{
			set{ _authoritylist=value;}
			get{return _authoritylist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsModify
		{
			set{ _ismodify=value;}
			get{return _ismodify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

