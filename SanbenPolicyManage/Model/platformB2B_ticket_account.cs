using System;
namespace Sanben.Model
{
	/// <summary>
	/// platformB2B_ticket_account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class platformB2B_ticket_account
	{
		public platformB2B_ticket_account()
		{}
		#region Model
		private int _id;
		private string _maccount;
		private string _caccount;
		private string _paysrc;
		private string _paytype;
		private int _sysuserid;
		private int _platformname_id;
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
		public string Maccount
		{
			set{ _maccount=value;}
			get{return _maccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Caccount
		{
			set{ _caccount=value;}
			get{return _caccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paysrc
		{
			set{ _paysrc=value;}
			get{return _paysrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string paytype
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sysUserId
		{
			set{ _sysuserid=value;}
			get{return _sysuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int platformName_id
		{
			set{ _platformname_id=value;}
			get{return _platformname_id;}
		}
		#endregion Model

	}
}

