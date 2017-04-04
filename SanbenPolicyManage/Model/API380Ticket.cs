using System;
namespace Sanben.Model
{
	/// <summary>
	/// API380Ticket:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class API380Ticket
	{
		public API380Ticket()
		{}
		#region Model
		private int _id;
		private int _code;
		private string _message;
		private string _bigpnr;
		private string _air;
		private string _pnr;
		private string _paystatus;
		private string _totaltax;
		private string _ticketprice;
		private string _orderno;
		private int _platformb2b_name_id;
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
		public int code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string message
		{
			set{ _message=value;}
			get{return _message;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bigpnr
		{
			set{ _bigpnr=value;}
			get{return _bigpnr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string air
		{
			set{ _air=value;}
			get{return _air;}
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
		public string paystatus
		{
			set{ _paystatus=value;}
			get{return _paystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string totaltax
		{
			set{ _totaltax=value;}
			get{return _totaltax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ticketprice
		{
			set{ _ticketprice=value;}
			get{return _ticketprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderno
		{
			set{ _orderno=value;}
			get{return _orderno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int platformB2B_name_id
		{
			set{ _platformb2b_name_id=value;}
			get{return _platformb2b_name_id;}
		}
		#endregion Model

	}
}

