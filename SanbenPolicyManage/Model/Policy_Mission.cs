using System;
namespace Sanben.Model
{
	/// <summary>
	/// Policy_Mission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Policy_Mission
	{
		public Policy_Mission()
		{}
		#region Model
		private int _id;
		private string _from_code;
		private string _to_code;
		private string _company;
		private int? _status;
		private DateTime? _date;
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
		public string From_code
		{
			set{ _from_code=value;}
			get{return _from_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string To_code
		{
			set{ _to_code=value;}
			get{return _to_code;}
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
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		#endregion Model

	}
}

