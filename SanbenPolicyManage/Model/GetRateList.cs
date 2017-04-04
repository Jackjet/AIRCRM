using System;
namespace Sanben.Model
{
	/// <summary>
	/// GetRateList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GetRateList
	{
		public GetRateList()
		{}
		#region Model
		private int _id;
		private string _policyid;
		private string _rateid;
		private string _scitye;
		private string _ecitye;
		private string _aircome;
		private string _noaircome;
		private string _policytype;
		private string _cabin;
		private string _voyagetype;
		private string _usertype;
		private string _ratetype;
		private decimal _discounts;
		private string _sdate;
		private string _edate;
		private string _worktimbegin;
		private string _worktimeend;
		private string _rewards;
		private string _remark;
		private string _et;
		private string _wp;
		private string _sp;
		private string _xf;
		private string _promotiondiscount;
		private string _newrateno;
		private string _officenum;
		private string _refundtimebegin;
		private string _refundtimeend;
		private string _lastmodifytime;
		private string _limitmodels;
		private string _refundrulesway;
		private string _tpremark;
		private string _changemsg;
		private string _invalidmsg;
		private string _risecabin;
		private string _foreignmsg;
		private string _outticketpercent;
		private string _invoicemsg;
		private string _printinvoice;
		private string _switchpnr;
		private string _change;
		private string _comreturn;
		private string _platform;
		private DateTime? _addtime;
		private string _company;
		private string _airline;
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
		public string PolicyId
		{
			set{ _policyid=value;}
			get{return _policyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RateId
		{
			set{ _rateid=value;}
			get{return _rateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ScityE
		{
			set{ _scitye=value;}
			get{return _scitye;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EcityE
		{
			set{ _ecitye=value;}
			get{return _ecitye;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AirComE
		{
			set{ _aircome=value;}
			get{return _aircome;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NoAirComE
		{
			set{ _noaircome=value;}
			get{return _noaircome;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PolicyType
		{
			set{ _policytype=value;}
			get{return _policytype;}
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
		public string VoyageType
		{
			set{ _voyagetype=value;}
			get{return _voyagetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RateType
		{
			set{ _ratetype=value;}
			get{return _ratetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Discounts
		{
			set{ _discounts=value;}
			get{return _discounts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sdate
		{
			set{ _sdate=value;}
			get{return _sdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Edate
		{
			set{ _edate=value;}
			get{return _edate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkTimBegin
		{
			set{ _worktimbegin=value;}
			get{return _worktimbegin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkTImeEnd
		{
			set{ _worktimeend=value;}
			get{return _worktimeend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rewards
		{
			set{ _rewards=value;}
			get{return _rewards;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ET
		{
			set{ _et=value;}
			get{return _et;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WP
		{
			set{ _wp=value;}
			get{return _wp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SP
		{
			set{ _sp=value;}
			get{return _sp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XF
		{
			set{ _xf=value;}
			get{return _xf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PromotionDiscount
		{
			set{ _promotiondiscount=value;}
			get{return _promotiondiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NewRateNo
		{
			set{ _newrateno=value;}
			get{return _newrateno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OfficeNum
		{
			set{ _officenum=value;}
			get{return _officenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefundTimeBegin
		{
			set{ _refundtimebegin=value;}
			get{return _refundtimebegin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefundTimeEnd
		{
			set{ _refundtimeend=value;}
			get{return _refundtimeend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastModifyTime
		{
			set{ _lastmodifytime=value;}
			get{return _lastmodifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LimitModels
		{
			set{ _limitmodels=value;}
			get{return _limitmodels;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RefundRulesWay
		{
			set{ _refundrulesway=value;}
			get{return _refundrulesway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TPRemark
		{
			set{ _tpremark=value;}
			get{return _tpremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChangeMsg
		{
			set{ _changemsg=value;}
			get{return _changemsg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvalidMsg
		{
			set{ _invalidmsg=value;}
			get{return _invalidmsg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RiseCabin
		{
			set{ _risecabin=value;}
			get{return _risecabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ForeignMsg
		{
			set{ _foreignmsg=value;}
			get{return _foreignmsg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OutTicketPercent
		{
			set{ _outticketpercent=value;}
			get{return _outticketpercent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoiceMsg
		{
			set{ _invoicemsg=value;}
			get{return _invoicemsg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PrintInvoice
		{
			set{ _printinvoice=value;}
			get{return _printinvoice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SwitchPNR
		{
			set{ _switchpnr=value;}
			get{return _switchpnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Change
		{
			set{ _change=value;}
			get{return _change;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string comReturn
		{
			set{ _comreturn=value;}
			get{return _comreturn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PlatForm
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AirLine
		{
			set{ _airline=value;}
			get{return _airline;}
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

