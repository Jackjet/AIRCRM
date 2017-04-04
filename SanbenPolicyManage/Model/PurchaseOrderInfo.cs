using System;
namespace Sanben.Model
{
	/// <summary>
	/// PurchaseOrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PurchaseOrderInfo
	{
		public PurchaseOrderInfo()
		{}
		#region Model
		private int _id;
		private string _price;
		private string _issue_ticket_type;
		private string _issue_ticket_platform_code;
		private string _source_transaction_id;
		private string _source_order_no;
		private string _tpp_type;
		private string _status;
		private string _pay_commercial_no;
		private string _offline_pay_type;
		private string _offline_pay_cardno;
		private string _platform_mem_id;
		private string _operator;
		private string _refund_price;
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
		public string price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string issue_ticket_type
		{
			set{ _issue_ticket_type=value;}
			get{return _issue_ticket_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string issue_ticket_platform_code
		{
			set{ _issue_ticket_platform_code=value;}
			get{return _issue_ticket_platform_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string source_transaction_id
		{
			set{ _source_transaction_id=value;}
			get{return _source_transaction_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string source_order_no
		{
			set{ _source_order_no=value;}
			get{return _source_order_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tpp_type
		{
			set{ _tpp_type=value;}
			get{return _tpp_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pay_commercial_no
		{
			set{ _pay_commercial_no=value;}
			get{return _pay_commercial_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string offline_pay_type
		{
			set{ _offline_pay_type=value;}
			get{return _offline_pay_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string offline_pay_cardno
		{
			set{ _offline_pay_cardno=value;}
			get{return _offline_pay_cardno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_mem_id
		{
			set{ _platform_mem_id=value;}
			get{return _platform_mem_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PurchaseOperator
		{
			set{ _operator=value;}
			get{return _operator;}
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
		public int? o_id
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		#endregion Model

	}
}

