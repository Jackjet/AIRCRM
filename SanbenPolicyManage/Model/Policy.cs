using System;
namespace Sanben.Model
{
	/// <summary>
	/// Policy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Policy
	{
		public Policy()
		{}
		#region Model
		private int _id;
		private string _flightcode;
		private string _policycode;
		private string _dpt;
		private string _arr;
		private string _flightnumlimit;
		private string _flightcondition;
		private string _daycondition;
		private string _cabin;
		private string _discounttype;
		private string _discountvalue;
		private decimal? _returnpoint;
		private int? _returnprice;
		private DateTime? _startdate_ticket;
		private DateTime? _enfdate_ticket;
		private DateTime? _startdate;
		private DateTime? _enddate;
		private int? _beforevalidday;
		private string _backnote;
		private string _cabinnote;
		private bool _autoticket;
		private bool _shared;
		private string _officeno;
		private string _ktype;
		private int? _checkcycletime;
		private int? _autocheckovertime;
		private int? _manualcheckovertime;
		private string _policy;
		private decimal? _downdiscount;
		private bool _pata;
		private string _specialrule;
		private int? _allcabin;
		private bool _canpay;
		private string _depttimeslot;
		private bool _needpnr;
		private string _one_flightlimit;
		private string _one_limitnum;
		private string _two_flightlimit;
		private string _two_limitnum;
		private string _one_daylimit;
		private string _two_daylimit;
		private string _gocabin;
		private string _backcabin;
		private DateTime? _one_startdate;
		private DateTime? _one_enddate;
		private DateTime? _two_startdate;
		private DateTime? _two_enddate;
		private int? _short_stoptime;
		private int? _long_stoptime;
		private string _costtype;
		private decimal? _costprice;
		private decimal? _proxyprice;
		private decimal? _backprice;
		private string _policysource;
		private string _xcd;
		private string _returnrule;
		private string _changerule;
		private bool _endorsement;
		private bool _flyerpoints;
		private int? _cardtype;
		private int? _maxage;
		private int? _minage;
		private int _sys_id;
		private string _uploadpolicytype;
		private int? _earliestbeforevalidday;
		private int? _isupload;
		private DateTime? _importtime;
		private string _uploadplat;
		private int? _uploadresult;
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
		public string flightcode
		{
			set{ _flightcode=value;}
			get{return _flightcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policyCode
		{
			set{ _policycode=value;}
			get{return _policycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dpt
		{
			set{ _dpt=value;}
			get{return _dpt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arr
		{
			set{ _arr=value;}
			get{return _arr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flightNumLimit
		{
			set{ _flightnumlimit=value;}
			get{return _flightnumlimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flightcondition
		{
			set{ _flightcondition=value;}
			get{return _flightcondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string daycondition
		{
			set{ _daycondition=value;}
			get{return _daycondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cabin
		{
			set{ _cabin=value;}
			get{return _cabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discountType
		{
			set{ _discounttype=value;}
			get{return _discounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string discountValue
		{
			set{ _discountvalue=value;}
			get{return _discountvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? returnpoint
		{
			set{ _returnpoint=value;}
			get{return _returnpoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? returnprice
		{
			set{ _returnprice=value;}
			get{return _returnprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? startdate_ticket
		{
			set{ _startdate_ticket=value;}
			get{return _startdate_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? enfdate_ticket
		{
			set{ _enfdate_ticket=value;}
			get{return _enfdate_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? startdate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? enddate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? beforeValidDay
		{
			set{ _beforevalidday=value;}
			get{return _beforevalidday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string backnote
		{
			set{ _backnote=value;}
			get{return _backnote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cabinnote
		{
			set{ _cabinnote=value;}
			get{return _cabinnote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool autoTicket
		{
			set{ _autoticket=value;}
			get{return _autoticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool shared
		{
			set{ _shared=value;}
			get{return _shared;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string officeno
		{
			set{ _officeno=value;}
			get{return _officeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ktype
		{
			set{ _ktype=value;}
			get{return _ktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? checkCycleTime
		{
			set{ _checkcycletime=value;}
			get{return _checkcycletime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? autoCheckOverTime
		{
			set{ _autocheckovertime=value;}
			get{return _autocheckovertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? manualCheckOverTime
		{
			set{ _manualcheckovertime=value;}
			get{return _manualcheckovertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy
		{
			set{ _policy=value;}
			get{return _policy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? downDiscount
		{
			set{ _downdiscount=value;}
			get{return _downdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool pata
		{
			set{ _pata=value;}
			get{return _pata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specialRule
		{
			set{ _specialrule=value;}
			get{return _specialrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? allCabin
		{
			set{ _allcabin=value;}
			get{return _allcabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool canPay
		{
			set{ _canpay=value;}
			get{return _canpay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string deptTimeSlot
		{
			set{ _depttimeslot=value;}
			get{return _depttimeslot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool needPnr
		{
			set{ _needpnr=value;}
			get{return _needpnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string one_flightlimit
		{
			set{ _one_flightlimit=value;}
			get{return _one_flightlimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string one_limitnum
		{
			set{ _one_limitnum=value;}
			get{return _one_limitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string two_flightlimit
		{
			set{ _two_flightlimit=value;}
			get{return _two_flightlimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string two_limitnum
		{
			set{ _two_limitnum=value;}
			get{return _two_limitnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string one_daylimit
		{
			set{ _one_daylimit=value;}
			get{return _one_daylimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string two_daylimit
		{
			set{ _two_daylimit=value;}
			get{return _two_daylimit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gocabin
		{
			set{ _gocabin=value;}
			get{return _gocabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string backcabin
		{
			set{ _backcabin=value;}
			get{return _backcabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? one_startdate
		{
			set{ _one_startdate=value;}
			get{return _one_startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? one_enddate
		{
			set{ _one_enddate=value;}
			get{return _one_enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? two_startdate
		{
			set{ _two_startdate=value;}
			get{return _two_startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? two_enddate
		{
			set{ _two_enddate=value;}
			get{return _two_enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? short_stoptime
		{
			set{ _short_stoptime=value;}
			get{return _short_stoptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? long_stoptime
		{
			set{ _long_stoptime=value;}
			get{return _long_stoptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string costtype
		{
			set{ _costtype=value;}
			get{return _costtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? costPrice
		{
			set{ _costprice=value;}
			get{return _costprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? proxyPrice
		{
			set{ _proxyprice=value;}
			get{return _proxyprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? backPrice
		{
			set{ _backprice=value;}
			get{return _backprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policySource
		{
			set{ _policysource=value;}
			get{return _policysource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xcd
		{
			set{ _xcd=value;}
			get{return _xcd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string returnRule
		{
			set{ _returnrule=value;}
			get{return _returnrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string changeRule
		{
			set{ _changerule=value;}
			get{return _changerule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool endorsement
		{
			set{ _endorsement=value;}
			get{return _endorsement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool flyerpoints
		{
			set{ _flyerpoints=value;}
			get{return _flyerpoints;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? cardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? maxAge
		{
			set{ _maxage=value;}
			get{return _maxage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? minAge
		{
			set{ _minage=value;}
			get{return _minage;}
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
		public string uploadPolicyType
		{
			set{ _uploadpolicytype=value;}
			get{return _uploadpolicytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? earliestBeforeValidDay
		{
			set{ _earliestbeforevalidday=value;}
			get{return _earliestbeforevalidday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? isUpload
		{
			set{ _isupload=value;}
			get{return _isupload;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? importTime
		{
			set{ _importtime=value;}
			get{return _importtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uploadPlat
		{
			set{ _uploadplat=value;}
			get{return _uploadplat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? uploadResult
		{
			set{ _uploadresult=value;}
			get{return _uploadresult;}
		}
		#endregion Model

	}
}

