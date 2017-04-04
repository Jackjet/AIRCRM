using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_options_wangfan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_options_wangfan
	{
		public policy_options_wangfan()
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
		private DateTime _flight_departure_time_start;
		private DateTime _flight_departure_time_end;
		private bool _is_automatic_ticket;
		private bool _is_mail_itinerary;
		private string _empower_office_number;
		private string _tolerate_refund_change_rule;
		private string _class_description;
		private string _special_ticketing_instructions;
		private int _policy_interface_id;
		private int _sys_userid;
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
		public DateTime Flight_departure_time_start
		{
			set{ _flight_departure_time_start=value;}
			get{return _flight_departure_time_start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Flight_departure_time_end
		{
			set{ _flight_departure_time_end=value;}
			get{return _flight_departure_time_end;}
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
		public string empower_office_number
		{
			set{ _empower_office_number=value;}
			get{return _empower_office_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tolerate_refund_change_rule
		{
			set{ _tolerate_refund_change_rule=value;}
			get{return _tolerate_refund_change_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string class_description
		{
			set{ _class_description=value;}
			get{return _class_description;}
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
		public int Policy_interface_id
		{
			set{ _policy_interface_id=value;}
			get{return _policy_interface_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_userId
		{
			set{ _sys_userid=value;}
			get{return _sys_userid;}
		}
		#endregion Model

	}
}

