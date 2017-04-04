using System;
namespace Sanben.Model
{
	/// <summary>
	/// Airport_Detail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Airport_Detail
	{
		public Airport_Detail()
		{}
		#region Model
		private int _id;
		private string _date;
		private string _from_code;
		private string _to_code;
		private string _startcity;
		private string _arrivecity;
		private int? _mileage;
		private int? _fule_adult;
		private int? _fule_child;
		private string _line_number;
		private string _share_line;
		private string _company;
		private string _startcode;
		private string _startairport;
		private string _arrivecode;
		private string _arriveairport;
		private string _starttime;
		private string _arrivetime;
		private int? _airrax;
		private int? _fulerax;
		private int? _fueladu;
		private int? _fuelchd;
		private int? _food;
		private string _food_detail;
		private int? _direct_flight;
		private string _type;
		private int? _electronic_ticket;
		private string _start_terminal;
		private string _arrive_terminal;
		private string _cabin;
		private int? _childcabin;
		private string _discount;
		private int? _price;
		private string _surplus_seat_qty;
		private string _cabin_status;
		private string _cabin_point;
		private string _validity_period;
		private string _return_date;
		private string _valid_date;
		private DateTime? _addtime;
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
		public string Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string From_Code
		{
			set{ _from_code=value;}
			get{return _from_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string To_Code
		{
			set{ _to_code=value;}
			get{return _to_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartCity
		{
			set{ _startcity=value;}
			get{return _startcity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ArriveCity
		{
			set{ _arrivecity=value;}
			get{return _arrivecity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mileage
		{
			set{ _mileage=value;}
			get{return _mileage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Fule_Adult
		{
			set{ _fule_adult=value;}
			get{return _fule_adult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Fule_Child
		{
			set{ _fule_child=value;}
			get{return _fule_child;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Line_Number
		{
			set{ _line_number=value;}
			get{return _line_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Share_Line
		{
			set{ _share_line=value;}
			get{return _share_line;}
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
		public string StartCode
		{
			set{ _startcode=value;}
			get{return _startcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartAirport
		{
			set{ _startairport=value;}
			get{return _startairport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ArriveCode
		{
			set{ _arrivecode=value;}
			get{return _arrivecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ArriveAirport
		{
			set{ _arriveairport=value;}
			get{return _arriveairport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ArriveTime
		{
			set{ _arrivetime=value;}
			get{return _arrivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AirRax
		{
			set{ _airrax=value;}
			get{return _airrax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FuleRax
		{
			set{ _fulerax=value;}
			get{return _fulerax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FuelAdu
		{
			set{ _fueladu=value;}
			get{return _fueladu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FuelChd
		{
			set{ _fuelchd=value;}
			get{return _fuelchd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Food
		{
			set{ _food=value;}
			get{return _food;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Food_Detail
		{
			set{ _food_detail=value;}
			get{return _food_detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Direct_Flight
		{
			set{ _direct_flight=value;}
			get{return _direct_flight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Electronic_Ticket
		{
			set{ _electronic_ticket=value;}
			get{return _electronic_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Start_Terminal
		{
			set{ _start_terminal=value;}
			get{return _start_terminal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Arrive_Terminal
		{
			set{ _arrive_terminal=value;}
			get{return _arrive_terminal;}
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
		public int? ChildCabin
		{
			set{ _childcabin=value;}
			get{return _childcabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Surplus_Seat_Qty
		{
			set{ _surplus_seat_qty=value;}
			get{return _surplus_seat_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cabin_Status
		{
			set{ _cabin_status=value;}
			get{return _cabin_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cabin_Point
		{
			set{ _cabin_point=value;}
			get{return _cabin_point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Validity_Period
		{
			set{ _validity_period=value;}
			get{return _validity_period;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Return_Date
		{
			set{ _return_date=value;}
			get{return _return_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Valid_Date
		{
			set{ _valid_date=value;}
			get{return _valid_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		#endregion Model

	}
}

