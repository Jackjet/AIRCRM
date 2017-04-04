using System;
namespace Sanben.Model
{
	/// <summary>
	/// menu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class menu
	{
		public menu()
		{}
		#region Model
		private int _id;
		private string _icon;
		private string _menuname;
		private string _url;
		private int? _parentid;
		private int? _sort;
		private string _remark;
		private bool _stop;
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
		public string icon
		{
			set{ _icon=value;}
			get{return _icon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string menuname
		{
			set{ _menuname=value;}
			get{return _menuname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? parentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool stop
		{
			set{ _stop=value;}
			get{return _stop;}
		}
		#endregion Model

	}
}

