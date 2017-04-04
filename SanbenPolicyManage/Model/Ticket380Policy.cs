using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class Ticket380Policy
	{
		public Ticket380Policy()
		{}
		#region Model
		private int _id;
		private string _policy_id;
		private string _air_comp;
		private string _start_city;
		private string _arr_city;
		private string _flight;
		private string _cabin;
		private string _share_line;
		private string _cabinprice;
		private string _point;
		private string _nakednum;
		private string _is_auto_tic;
		private string _logtime;
		private string _deptime;
		private string _price;
		private string _remark;
		private string _fsdate;
		private string _fedate;
		private string _sale_sdate;
		private string _sale_edate;
		private DateTime? _addtime;
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
		public string policy_id
		{
			set{ _policy_id=value;}
			get{return _policy_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string air_comp
		{
			set{ _air_comp=value;}
			get{return _air_comp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string start_city
		{
			set{ _start_city=value;}
			get{return _start_city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arr_city
		{
			set{ _arr_city=value;}
			get{return _arr_city;}
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
		public string cabin
		{
			set{ _cabin=value;}
			get{return _cabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string share_line
		{
			set{ _share_line=value;}
			get{return _share_line;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cabinprice
		{
			set{ _cabinprice=value;}
			get{return _cabinprice;}
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
		public string nakednum
		{
			set{ _nakednum=value;}
			get{return _nakednum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string is_auto_tic
		{
			set{ _is_auto_tic=value;}
			get{return _is_auto_tic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string logtime
		{
			set{ _logtime=value;}
			get{return _logtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string deptime
		{
			set{ _deptime=value;}
			get{return _deptime;}
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
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fsdate
		{
			set{ _fsdate=value;}
			get{return _fsdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fedate
		{
			set{ _fedate=value;}
			get{return _fedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sale_sdate
		{
			set{ _sale_sdate=value;}
			get{return _sale_sdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sale_edate
		{
			set{ _sale_edate=value;}
			get{return _sale_edate;}
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

