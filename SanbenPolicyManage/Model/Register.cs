using System;
namespace Sanben.Model
{
	/// <summary>
	/// Register:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Register
	{
		public Register()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
		private string _company;
		private string _phone;
		private string _name;
		private string _qq;
		private string _idcard;
		private DateTime? _login_date;
		/// <summary>
		/// 
		/// </summary>
		public int ID
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
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string idcard
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? login_date
		{
			set{ _login_date=value;}
			get{return _login_date;}
		}
		#endregion Model

	}
}

