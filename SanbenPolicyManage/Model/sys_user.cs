using System;
namespace Sanben.Model
{
	/// <summary>
	/// sys_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class sys_user
	{
		public sys_user()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
		private DateTime? _createdate= DateTime.Now;
		private string _rolelist;
		private string _checkauthority;
		private bool _stop;
		private bool _ismodify;
		private string _remark;
		private string _realname;
		private string _code;
		private string _gender;
		private string _mobile;
		private string _telephone;
		private string _qq;
		private string _emaile;
		private string _company;
		private string _companyaddress;
		private int? _parentid;
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
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoleList
		{
			set{ _rolelist=value;}
			get{return _rolelist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckAuthority
		{
			set{ _checkauthority=value;}
			get{return _checkauthority;}
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
		/// <summary>
		/// 
		/// </summary>
		public string RealName
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gender
		{
			set{ _gender=value;}
			get{return _gender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telephone
		{
			set{ _telephone=value;}
			get{return _telephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Emaile
		{
			set{ _emaile=value;}
			get{return _emaile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAddress
		{
			set{ _companyaddress=value;}
			get{return _companyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ParentID
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		#endregion Model

	}
}

