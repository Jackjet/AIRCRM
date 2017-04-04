using System;
namespace Sanben.Model
{
	/// <summary>
	/// SYS_MenuList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_MenuList
	{
		public SYS_MenuList()
		{}
		#region Model
		private int _id;
		private string _text;
		private string _tabid;
		private string _navigateurl;
		private int? _parentid;
		private bool _singleclickexpand;
		private string _icon;
		private bool _ismodule;
		private bool _isfuntion;
		private int? _ordering;
		private bool _stop;
		private string _remark;
		private DateTime? _version;
		private int? _sort;
		/// <summary>
		/// 编码
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public string Text
		{
			set{ _text=value;}
			get{return _text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TabID
		{
			set{ _tabid=value;}
			get{return _tabid;}
		}
		/// <summary>
		/// 权限ID
		/// </summary>
		public string NavigateUrl
		{
			set{ _navigateurl=value;}
			get{return _navigateurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SingleClickExpand
		{
			set{ _singleclickexpand=value;}
			get{return _singleclickexpand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Icon
		{
			set{ _icon=value;}
			get{return _icon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsModule
		{
			set{ _ismodule=value;}
			get{return _ismodule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsFuntion
		{
			set{ _isfuntion=value;}
			get{return _isfuntion;}
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
		public bool Stop
		{
			set{ _stop=value;}
			get{return _stop;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		#endregion Model

	}
}

