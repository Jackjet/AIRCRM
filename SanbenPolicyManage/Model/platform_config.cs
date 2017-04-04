using System;
namespace Sanben.Model
{
	/// <summary>
	/// platform_config:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class platform_config
	{
		public platform_config()
		{}
		#region Model
		private int _id;
		private int _platform_type_id;
		private string _username;
		private string _password;
		private string _realm_name;
		private string _bind_ip_address;
		private int _sys_user_id;
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
		public int platform_type_id
		{
			set{ _platform_type_id=value;}
			get{return _platform_type_id;}
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
		public string realm_name
		{
			set{ _realm_name=value;}
			get{return _realm_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bind_ip_address
		{
			set{ _bind_ip_address=value;}
			get{return _bind_ip_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_user_id
		{
			set{ _sys_user_id=value;}
			get{return _sys_user_id;}
		}
		#endregion Model

	}
}

