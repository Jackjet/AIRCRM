using System;
namespace Sanben.Model
{
	/// <summary>
	/// City_Man:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class City_Man
	{
		public City_Man()
		{}
		#region Model
		private int _id;
		private string _from_code;
		private string _to_code;
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
		public string From_Code
		{
			set{ _from_code=value;}
			get{return _from_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string To_Code
		{
			set{ _to_code=value;}
			get{return _to_code;}
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

