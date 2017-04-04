using System;
namespace Sanben.Model
{
	/// <summary>
	/// SYS_Role:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_Role
	{
		public SYS_Role()
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
		/// 编码
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 角色名
		/// </summary>
		public string RoleName
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 停用标志
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
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

