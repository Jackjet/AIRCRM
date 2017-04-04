using System;
namespace Sanben.Model
{
	/// <summary>
	/// BaQianYiPolicy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BaQianYiPolicy
	{
		public BaQianYiPolicy()
		{}
		#region Model
		private int _id;
		private string _policy_num;
		private string _startcity;
		private string _arrivecity;
		private string _airline;
		private string _for_flight_no;
		private string _ex_flight_no;
		private string _policy_ratype;
		private string _point;
		private string _cabin_discount;
		private string _startdate;
		private string _arrivedate;
		private string _nomal_workday;
		private string _weekday;
		private string _vip_policy;
		private string _return_policy;
		private string _policy_type;
		private string _policy_note;
		private string _supplier_id;
		private string _or_ticket_t;
		private string _week_ticket_t;
		private string _policy_flight;
		private string _end_state;
		private string _office_code;
		private string _salestart_date;
		private string _saleend_date;
		private string _support_pay;
		private string _ticket_efficient;
		private string _is_cgnum_ticket;
		private string _is_open_low;
		private DateTime? _addtime;
		private string _last_modify_time;
		private bool _isupload;
		private bool _isupdate;
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
		public string policy_num
		{
			set{ _policy_num=value;}
			get{return _policy_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string startcity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arrivecity
		{
			set{ _arrivecity=value;}
			get{return _arrivecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string airline
		{
			set{ _airline=value;}
			get{return _airline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string for_flight_no
		{
			set{ _for_flight_no=value;}
			get{return _for_flight_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ex_flight_no
		{
			set{ _ex_flight_no=value;}
			get{return _ex_flight_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy_ratype
		{
			set{ _policy_ratype=value;}
			get{return _policy_ratype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cabin_discount
		{
			set{ _cabin_discount=value;}
			get{return _cabin_discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string startdate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arrivedate
		{
			set{ _arrivedate=value;}
			get{return _arrivedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string nomal_workday
		{
			set{ _nomal_workday=value;}
			get{return _nomal_workday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string weekday
		{
			set{ _weekday=value;}
			get{return _weekday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string vip_policy
		{
			set{ _vip_policy=value;}
			get{return _vip_policy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string return_policy
		{
			set{ _return_policy=value;}
			get{return _return_policy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy_type
		{
			set{ _policy_type=value;}
			get{return _policy_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy_note
		{
			set{ _policy_note=value;}
			get{return _policy_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string supplier_id
		{
			set{ _supplier_id=value;}
			get{return _supplier_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string or_ticket_t
		{
			set{ _or_ticket_t=value;}
			get{return _or_ticket_t;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string week_ticket_t
		{
			set{ _week_ticket_t=value;}
			get{return _week_ticket_t;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy_flight
		{
			set{ _policy_flight=value;}
			get{return _policy_flight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string end_state
		{
			set{ _end_state=value;}
			get{return _end_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string office_code
		{
			set{ _office_code=value;}
			get{return _office_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string salestart_date
		{
			set{ _salestart_date=value;}
			get{return _salestart_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string saleend_date
		{
			set{ _saleend_date=value;}
			get{return _saleend_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string support_pay
		{
			set{ _support_pay=value;}
			get{return _support_pay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ticket_efficient
		{
			set{ _ticket_efficient=value;}
			get{return _ticket_efficient;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_cgnum_ticket
		{
			set{ _is_cgnum_ticket=value;}
			get{return _is_cgnum_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_open_low
		{
			set{ _is_open_low=value;}
			get{return _is_open_low;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? addtime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string last_modify_time
		{
			set{ _last_modify_time=value;}
			get{return _last_modify_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUpload
		{
			set{ _isupload=value;}
			get{return _isupload;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUpdate
		{
			set{ _isupdate=value;}
			get{return _isupdate;}
		}
		#endregion Model

	}
}

