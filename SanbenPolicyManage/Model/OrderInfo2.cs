using System;
namespace Sanben.Model
{
	/// <summary>
	/// OrderInfo2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderInfo2
	{
		public OrderInfo2()
		{}
		#region Model
		private int _pk_id;
		private int _id;
		private string _orderno;
		private string _allprice;
		private string _nopay;
		private string _childprintprice;
		private string _childfacevalue;
		private string _source;
		private string _policysource;
		private string _ticketmode;
		private string _policyfriendly;
		private string _paychannel;
		private string _paystatus;
		private string _insuranceunitprice;
		private string _backnote;
		private string _insurancecuttingprice;
		private string _cabinnote;
		private string _xcdprice;
		private string _xcd;
		private string _sjr;
		private string _contacttel;
		private string _address;
		private string _company;
		private string _exptype;
		private string _ordernumber;
		private string _sendtime;
		private string _viewprice;
		private string _price;
		private string _pnr;
		private string _cpnr;
		private string _pnrtext;
		private string _childpnrtext;
		private string _patatext;
		private string _childpatatext;
		private string _constructionfee;
		private string _fueltax;
		private string _childfueltax;
		private string _policytype;
		private string _status;
		private string _contact;
		private string _contactmob;
		private string _contactemail;
		private DateTime? _createtime;
		private string _needps;
		private string _username;
		private string _orderfrom;
		private string _lockstatus;
		private DateTime? _updatetime;
		private int? _userid;
		private string _orderdesc;
		/// <summary>
		/// 
		/// </summary>
		public int pk_id
		{
			set{ _pk_id=value;}
			get{return _pk_id;}
		}
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
		public string orderNo
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string allPrice
		{
			set{ _allprice=value;}
			get{return _allprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string noPay
		{
			set{ _nopay=value;}
			get{return _nopay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string childPrintPrice
		{
			set{ _childprintprice=value;}
			get{return _childprintprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string childFaceValue
		{
			set{ _childfacevalue=value;}
			get{return _childfacevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string source
		{
			set{ _source=value;}
			get{return _source;}
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
		public string ticketMode
		{
			set{ _ticketmode=value;}
			get{return _ticketmode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policyFriendly
		{
			set{ _policyfriendly=value;}
			get{return _policyfriendly;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payChannel
		{
			set{ _paychannel=value;}
			get{return _paychannel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string payStatus
		{
			set{ _paystatus=value;}
			get{return _paystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string insuranceUnitPrice
		{
			set{ _insuranceunitprice=value;}
			get{return _insuranceunitprice;}
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
		public string insuranceCuttingPrice
		{
			set{ _insurancecuttingprice=value;}
			get{return _insurancecuttingprice;}
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
		public string xcdPrice
		{
			set{ _xcdprice=value;}
			get{return _xcdprice;}
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
		public string sjr
		{
			set{ _sjr=value;}
			get{return _sjr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contactTel
		{
			set{ _contacttel=value;}
			get{return _contacttel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string company
		{
			set{ _company=value;}
			get{return _company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string expType
		{
			set{ _exptype=value;}
			get{return _exptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ordernumber
		{
			set{ _ordernumber=value;}
			get{return _ordernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sendtime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string viewPrice
		{
			set{ _viewprice=value;}
			get{return _viewprice;}
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
		public string pnr
		{
			set{ _pnr=value;}
			get{return _pnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cpnr
		{
			set{ _cpnr=value;}
			get{return _cpnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pnrText
		{
			set{ _pnrtext=value;}
			get{return _pnrtext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string childPnrText
		{
			set{ _childpnrtext=value;}
			get{return _childpnrtext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pataText
		{
			set{ _patatext=value;}
			get{return _patatext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string childPataText
		{
			set{ _childpatatext=value;}
			get{return _childpatatext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string constructionFee
		{
			set{ _constructionfee=value;}
			get{return _constructionfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fuelTax
		{
			set{ _fueltax=value;}
			get{return _fueltax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string childFuelTax
		{
			set{ _childfueltax=value;}
			get{return _childfueltax;}
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
		public string status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contactMob
		{
			set{ _contactmob=value;}
			get{return _contactmob;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contactEmail
		{
			set{ _contactemail=value;}
			get{return _contactemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? createTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string needPS
		{
			set{ _needps=value;}
			get{return _needps;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderFrom
		{
			set{ _orderfrom=value;}
			get{return _orderfrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lockStatus
		{
			set{ _lockstatus=value;}
			get{return _lockstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? updateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderDesc
		{
			set{ _orderdesc=value;}
			get{return _orderdesc;}
		}
		#endregion Model

	}
}

