using System;
namespace Sanben.Model
{
	/// <summary>
	/// JinRiOrderByPnr:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JinRiOrderByPnr
	{
		public JinRiOrderByPnr()
		{}
		#region Model
		private int _id;
		private string _orderno;
		private string _pnr;
		private decimal _growdiscount;
		private decimal _staydiscount;
		private decimal _paymoney;
		private decimal _profit;
		private int _status;
		private string _date;
		private string _scity;
		private string _ecity;
		private string _flight;
		private string _stime;
		private string _etime;
		private string _cabin;
		private decimal _price;
		private decimal _tax;
		private int _pcount;
		private string _pname;
		private string _pcard;
		private string _jouneryinfo;
		private string _isbuyinsurance;
		private int _orderinfo_id;
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
		public string pnr
		{
			set{ _pnr=value;}
			get{return _pnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal growDiscount
		{
			set{ _growdiscount=value;}
			get{return _growdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal stayDiscount
		{
			set{ _staydiscount=value;}
			get{return _staydiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal payMoney
		{
			set{ _paymoney=value;}
			get{return _paymoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal profit
		{
			set{ _profit=value;}
			get{return _profit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string scity
		{
			set{ _scity=value;}
			get{return _scity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ecity
		{
			set{ _ecity=value;}
			get{return _ecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flight
		{
			set{ _flight=value;}
			get{return _flight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stime
		{
			set{ _stime=value;}
			get{return _stime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string etime
		{
			set{ _etime=value;}
			get{return _etime;}
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
		public decimal price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal tax
		{
			set{ _tax=value;}
			get{return _tax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int pcount
		{
			set{ _pcount=value;}
			get{return _pcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pName
		{
			set{ _pname=value;}
			get{return _pname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pCard
		{
			set{ _pcard=value;}
			get{return _pcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jouneryInfo
		{
			set{ _jouneryinfo=value;}
			get{return _jouneryinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isBuyInsurance
		{
			set{ _isbuyinsurance=value;}
			get{return _isbuyinsurance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int orderinfo_id
		{
			set{ _orderinfo_id=value;}
			get{return _orderinfo_id;}
		}
		#endregion Model

	}
}

