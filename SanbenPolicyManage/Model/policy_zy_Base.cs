using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_zy_Base:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_zy_Base
	{
		public policy_zy_Base()
		{}
		#region Model
		private int _id;
		private decimal _leavepoint;
		private decimal _leavemoney;
		private bool _is_filter;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private decimal? _lowest_rebate;
		private decimal? _highest_rebate;
		private int? _earliest_advance_days;
		private int? _night_before_days;
		private int? _pointsettype;
		private bool _isuploadfirstclass;
		private bool _isuploadchildclass;
		private bool _nfdpolicy;
		private string _flylimittime;
		private string _platfrompolicy;
		private string _gwpolicy;
		private bool _uploadway;
		private bool _isuploadsharefight;
		private bool _addpricejisuan;
		private int? _addpricecoverttype;
		private int? _addpriceset;
		private int? _limitsit;
		private int? _salesit;
		private bool _is_autoticket;
		private bool _is_need;
		private int? _ismail;
		private bool _ispay;
		private string _authorizeoffice;
		private string _refund_rule;
		private string _changedate_rule;
		private bool _is_allowed_sign;
		private bool _is_provide_regular_passenger_integral;
		private int? _document_type;
		private int? _maxage;
		private int? _minage;
		private string _class_description;
		private string _special_ticketing_instructions;
		private decimal? _lowest_price;
		private decimal? _highest_price;
		private DateTime? _lastupdatetime;
		private int _sysuser_id;
		private int? _platform_id;
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
		public decimal leavepoint
		{
			set{ _leavepoint=value;}
			get{return _leavepoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal leavemoney
		{
			set{ _leavemoney=value;}
			get{return _leavemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_filter
		{
			set{ _is_filter=value;}
			get{return _is_filter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? starttime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? endtime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		public int? pointSetType
		{
			set{ _pointsettype=value;}
			get{return _pointsettype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isuploadfirstclass
		{
			set{ _isuploadfirstclass=value;}
			get{return _isuploadfirstclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isuploadchildclass
		{
			set{ _isuploadchildclass=value;}
			get{return _isuploadchildclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool NFDpolicy
		{
			set{ _nfdpolicy=value;}
			get{return _nfdpolicy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flylimittime
		{
			set{ _flylimittime=value;}
			get{return _flylimittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platfromPolicy
		{
			set{ _platfrompolicy=value;}
			get{return _platfrompolicy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GWpolicy
		{
			set{ _gwpolicy=value;}
			get{return _gwpolicy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool uploadway
		{
			set{ _uploadway=value;}
			get{return _uploadway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isuploadsharefight
		{
			set{ _isuploadsharefight=value;}
			get{return _isuploadsharefight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool addpricejisuan
		{
			set{ _addpricejisuan=value;}
			get{return _addpricejisuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? addpriceCovertType
		{
			set{ _addpricecoverttype=value;}
			get{return _addpricecoverttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? addPriceSet
		{
			set{ _addpriceset=value;}
			get{return _addpriceset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? limitSit
		{
			set{ _limitsit=value;}
			get{return _limitsit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? saleSit
		{
			set{ _salesit=value;}
			get{return _salesit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_autoticket
		{
			set{ _is_autoticket=value;}
			get{return _is_autoticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool is_Need
		{
			set{ _is_need=value;}
			get{return _is_need;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isMail
		{
			set{ _ismail=value;}
			get{return _ismail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isPay
		{
			set{ _ispay=value;}
			get{return _ispay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AuthorizeOffice
		{
			set{ _authorizeoffice=value;}
			get{return _authorizeoffice;}
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
		public int? maxage
		{
			set{ _maxage=value;}
			get{return _maxage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? minage
		{
			set{ _minage=value;}
			get{return _minage;}
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
		public decimal? lowest_price
		{
			set{ _lowest_price=value;}
			get{return _lowest_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? highest_price
		{
			set{ _highest_price=value;}
			get{return _highest_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? lastupdatetime
		{
			set{ _lastupdatetime=value;}
			get{return _lastupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sysuser_id
		{
			set{ _sysuser_id=value;}
			get{return _sysuser_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? platform_id
		{
			set{ _platform_id=value;}
			get{return _platform_id;}
		}
		#endregion Model

	}
}

