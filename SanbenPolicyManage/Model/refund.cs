using System;
namespace Sanben.Model
{
	/// <summary>
	/// refund:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class refund
	{
		public refund()
		{}
		#region Model
		private int _id;
		private string _refund_time;
		private string _refund_price;
		private string _refund_no;
		private string _type;
		private int? _o_id;
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
		public string refund_time
		{
			set{ _refund_time=value;}
			get{return _refund_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string refund_price
		{
			set{ _refund_price=value;}
			get{return _refund_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string refund_no
		{
			set{ _refund_no=value;}
			get{return _refund_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? o_id
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		#endregion Model

	}
}

