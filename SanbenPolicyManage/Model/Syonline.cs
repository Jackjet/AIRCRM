using System;
namespace Sanben.Model
{
	/// <summary>
	/// Syonline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Syonline
	{
		public Syonline()
		{}
		#region Model
		private int _id;
		private string _loginname;
		private string _ip;
		private DateTime? _createdate= DateTime.Now;
		private bool _type;
		private string _ipinfo;
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
		public string loginname
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ip
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createdate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ipinfo
		{
			set{ _ipinfo=value;}
			get{return _ipinfo;}
		}
		#endregion Model

	}
}

