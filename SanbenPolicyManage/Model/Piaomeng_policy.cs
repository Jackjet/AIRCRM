using System;
namespace Sanben.Model
{
	/// <summary>
	/// Piaomeng_policy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Piaomeng_policy
	{
		public Piaomeng_policy()
		{}
		#region Model
		private int _id;
		private string _policyid;
		private string _fromplace;
		private string _toplace;
		private string _flightno;
		private DateTime _fromtime;
		private DateTime _totime;
		private decimal? _discountmax;
		private decimal? _discountmin;
		private decimal? _rate;
		private string _remarks;
		private string _flightscope;
		private DateTime _printtickfromtime;
		private DateTime _printticktotime;
		private string _publisherid;
		private string _status;
		private string _lastusername;
		private DateTime? _submittime;
		private DateTime? _lastupdatetime= DateTime.Now;
		private string _routetype;
		private string _applyclass;
		private string _specmark;
		private string _specnote;
		private string _policytype;
		private string _aircom;
		private string _type;
		private string _changepnr;
		private string _bookingremarks;
		private string _bounceremarks;
		private string _ticketchangingremarks;
		private string _openremarks;
		private string _policyway;
		private string _providerid;
		private int? _worktimeto;
		private int? _worktimefrom;
		private string _paytype;
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
		public string policyID
		{
			set{ _policyid=value;}
			get{return _policyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fromPlace
		{
			set{ _fromplace=value;}
			get{return _fromplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string toPlace
		{
			set{ _toplace=value;}
			get{return _toplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flightNo
		{
			set{ _flightno=value;}
			get{return _flightno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime fromTime
		{
			set{ _fromtime=value;}
			get{return _fromtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime toTime
		{
			set{ _totime=value;}
			get{return _totime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? discountMax
		{
			set{ _discountmax=value;}
			get{return _discountmax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? discountMin
		{
			set{ _discountmin=value;}
			get{return _discountmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? rate
		{
			set{ _rate=value;}
			get{return _rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flightScope
		{
			set{ _flightscope=value;}
			get{return _flightscope;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime printTickFromTime
		{
			set{ _printtickfromtime=value;}
			get{return _printtickfromtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime printTickToTime
		{
			set{ _printticktotime=value;}
			get{return _printticktotime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string publisherId
		{
			set{ _publisherid=value;}
			get{return _publisherid;}
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
		public string lastUserName
		{
			set{ _lastusername=value;}
			get{return _lastusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? submitTime
		{
			set{ _submittime=value;}
			get{return _submittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? lastUpdateTime
		{
			set{ _lastupdatetime=value;}
			get{return _lastupdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string routeType
		{
			set{ _routetype=value;}
			get{return _routetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string applyClass
		{
			set{ _applyclass=value;}
			get{return _applyclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specMark
		{
			set{ _specmark=value;}
			get{return _specmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string specNote
		{
			set{ _specnote=value;}
			get{return _specnote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policyType
		{
			set{ _policytype=value;}
			get{return _policytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string airCom
		{
			set{ _aircom=value;}
			get{return _aircom;}
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
		public string changePNR
		{
			set{ _changepnr=value;}
			get{return _changepnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bookingRemarks
		{
			set{ _bookingremarks=value;}
			get{return _bookingremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bounceRemarks
		{
			set{ _bounceremarks=value;}
			get{return _bounceremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ticketChangingRemarks
		{
			set{ _ticketchangingremarks=value;}
			get{return _ticketchangingremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string openRemarks
		{
			set{ _openremarks=value;}
			get{return _openremarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policyWay
		{
			set{ _policyway=value;}
			get{return _policyway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string providerId
		{
			set{ _providerid=value;}
			get{return _providerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? worktimeto
		{
			set{ _worktimeto=value;}
			get{return _worktimeto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? worktimeFrom
		{
			set{ _worktimefrom=value;}
			get{return _worktimefrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		#endregion Model

	}
}

