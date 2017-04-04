using System;
namespace Sanben.Model
{
	/// <summary>
	/// kuXunPolicyOptions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class kuXunPolicyOptions
	{
		public kuXunPolicyOptions()
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
		private decimal _discount;
		private decimal _agent_rate;
		private int _insurance_number;
		private bool _foundpnr;
		private bool _is_mail_itinerary;
		private string _validatepata;
		private int _validateclass;
		private string _refund_change_rule;
		private int _sys_id;
		private int _platform_type_id;
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
		public decimal discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal agent_rate
		{
			set{ _agent_rate=value;}
			get{return _agent_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int insurance_number
		{
			set{ _insurance_number=value;}
			get{return _insurance_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool foundPnr
		{
			set{ _foundpnr=value;}
			get{return _foundpnr;}
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
		public string validatePatA
		{
			set{ _validatepata=value;}
			get{return _validatepata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int validateClass
		{
			set{ _validateclass=value;}
			get{return _validateclass;}
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
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int platform_type_id
		{
			set{ _platform_type_id=value;}
			get{return _platform_type_id;}
		}
		#endregion Model

	}
}

