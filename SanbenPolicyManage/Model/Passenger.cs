using System;
namespace Sanben.Model
{
	/// <summary>
	/// Passenger:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Passenger
	{
		public Passenger()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _agetype;
		private string _cardtype;
		private string _price;
		private string _pricetype;
		private string _cardnum;
		private string _eticketnum;
		private string _insurancecount;
		private string _bxsource;
		private string _bxname;
		private int? _o_id;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ageType
		{
			set{ _agetype=value;}
			get{return _agetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cardType
		{
			set{ _cardtype=value;}
			get{return _cardtype;}
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
		public string priceType
		{
			set{ _pricetype=value;}
			get{return _pricetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cardNum
		{
			set{ _cardnum=value;}
			get{return _cardnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string eticketNum
		{
			set{ _eticketnum=value;}
			get{return _eticketnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string insuranceCount
		{
			set{ _insurancecount=value;}
			get{return _insurancecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bxSource
		{
			set{ _bxsource=value;}
			get{return _bxsource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bxName
		{
			set{ _bxname=value;}
			get{return _bxname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? o_id
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		#endregion Model

	}
}

