using System;
namespace Sanben.Model
{
	/// <summary>
	/// Airport_Unknown:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Airport_Unknown
	{
		public Airport_Unknown()
		{}
		#region Model
		private int _id;
		private string _cabin;
		private int? _childcabin;
		private string _discount;
		private int? _price;
		private string _surplus_seat_qty;
		private string _cabin_status;
		private string _line_number;
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
		public string Cabin
		{
			set{ _cabin=value;}
			get{return _cabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ChildCabin
		{
			set{ _childcabin=value;}
			get{return _childcabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Surplus_Seat_Qty
		{
			set{ _surplus_seat_qty=value;}
			get{return _surplus_seat_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cabin_Status
		{
			set{ _cabin_status=value;}
			get{return _cabin_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Line_Number
		{
			set{ _line_number=value;}
			get{return _line_number;}
		}
		#endregion Model

	}
}

