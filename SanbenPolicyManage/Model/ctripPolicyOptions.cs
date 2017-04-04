using System;
namespace Sanben.Model
{
	/// <summary>
	/// ctripPolicyOptions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ctripPolicyOptions
	{
		public ctripPolicyOptions()
		{}
		#region Model
		private int _id;
		private decimal _tolerate_stationary_point;
		private decimal _tolerate_leave_money;
		private decimal _lowest_rebate;
		private decimal _highest_rebate;
		private int _earliest_advance_days;
		private int _night_before_days;
		private int _rebate_class_set;
		private int _ticket_price_set;
		private string _worktimelimit;
		private decimal _discount;
		private bool _is_automatic_ticket;
		private bool _is_mail_itinerary;
		private string _off_number;
		private bool _is_orientate;
		private string _special_ticketing_instructions;
		private string _refund_change_rule;
		private int _platform_type_id;
		private int _sys_id;
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
		public decimal tolerate_stationary_point
		{
			set{ _tolerate_stationary_point=value;}
			get{return _tolerate_stationary_point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal tolerate_leave_money
		{
			set{ _tolerate_leave_money=value;}
			get{return _tolerate_leave_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal lowest_rebate
		{
			set{ _lowest_rebate=value;}
			get{return _lowest_rebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal highest_rebate
		{
			set{ _highest_rebate=value;}
			get{return _highest_rebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int earliest_advance_days
		{
			set{ _earliest_advance_days=value;}
			get{return _earliest_advance_days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int night_before_days
		{
			set{ _night_before_days=value;}
			get{return _night_before_days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rebate_class_set
		{
			set{ _rebate_class_set=value;}
			get{return _rebate_class_set;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ticket_price_set
		{
			set{ _ticket_price_set=value;}
			get{return _ticket_price_set;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string workTimeLimit
		{
			set{ _worktimelimit=value;}
			get{return _worktimelimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_automatic_ticket
		{
			set{ _is_automatic_ticket=value;}
			get{return _is_automatic_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_mail_itinerary
		{
			set{ _is_mail_itinerary=value;}
			get{return _is_mail_itinerary;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string off_number
		{
			set{ _off_number=value;}
			get{return _off_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_orientate
		{
			set{ _is_orientate=value;}
			get{return _is_orientate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string special_ticketing_instructions
		{
			set{ _special_ticketing_instructions=value;}
			get{return _special_ticketing_instructions;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string refund_change_rule
		{
			set{ _refund_change_rule=value;}
			get{return _refund_change_rule;}
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
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		#endregion Model

	}
}

