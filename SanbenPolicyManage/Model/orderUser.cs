using System;
namespace Sanben.Model
{
	/// <summary>
	/// orderUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class orderUser
	{
		public orderUser()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
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
		#endregion Model

	}
}

