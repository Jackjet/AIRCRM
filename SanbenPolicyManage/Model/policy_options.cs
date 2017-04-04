using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_options:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_options
	{
		public policy_options()
		{}
		#region Model
		private int _id;
		private int _policy_interface_id;
		private decimal? _tolerate_stationary_point;
		private decimal? _tolerate_leave_money;
		private bool _is_screening;
		private decimal? _lowest_rebate;
		private decimal? _highest_rebate;
		private int? _earliest_advance_days;
		private int? _night_before_days;
		private int? _rebate_class_set;
		private DateTime? _flight_departure_time_start;
		private bool _is_automatic_ticket;
		private bool _is_mail_itinerary;
		private string _empower_office_number;
		private string _refund_rule;
		private string _changedate_rule;
		private bool _is_allowed_sign;
		private bool _is_provide_regular_passenger_integral;
		private int? _document_type;
		private int? _minimum_age;
		private int? _maximum_age;
		private string _class_description;
		private string _special_ticketing_instructions;
		private int _sys_userid;
		private DateTime? _flight_departure_time_end;
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
		public int Policy_interface_id
		{
			set{ _policy_interface_id=value;}
			get{return _policy_interface_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tolerate_stationary_point
		{
			set{ _tolerate_stationary_point=value;}
			get{return _tolerate_stationary_point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? tolerate_leave_money
		{
			set{ _tolerate_leave_money=value;}
			get{return _tolerate_leave_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_screening
		{
			set{ _is_screening=value;}
			get{return _is_screening;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? lowest_rebate
		{
			set{ _lowest_rebate=value;}
			get{return _lowest_rebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? highest_rebate
		{
			set{ _highest_rebate=value;}
			get{return _highest_rebate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? earliest_advance_days
		{
			set{ _earliest_advance_days=value;}
			get{return _earliest_advance_days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? night_before_days
		{
			set{ _night_before_days=value;}
			get{return _night_before_days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? rebate_class_set
		{
			set{ _rebate_class_set=value;}
			get{return _rebate_class_set;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Flight_departure_time_start
		{
			set{ _flight_departure_time_start=value;}
			get{return _flight_departure_time_start;}
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
		public string refund_rule
		{
			set{ _refund_rule=value;}
			get{return _refund_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string changedate_rule
		{
			set{ _changedate_rule=value;}
			get{return _changedate_rule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_allowed_sign
		{
			set{ _is_allowed_sign=value;}
			get{return _is_allowed_sign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_provide_regular_passenger_integral
		{
			set{ _is_provide_regular_passenger_integral=value;}
			get{return _is_provide_regular_passenger_integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? document_type
		{
			set{ _document_type=value;}
			get{return _document_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? minimum_age
		{
			set{ _minimum_age=value;}
			get{return _minimum_age;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? maximum_age
		{
			set{ _maximum_age=value;}
			get{return _maximum_age;}
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
		public int sys_userId
		{
			set{ _sys_userid=value;}
			get{return _sys_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Flight_departure_time_end
		{
			set{ _flight_departure_time_end=value;}
			get{return _flight_departure_time_end;}
		}
		#endregion Model

	}
}

