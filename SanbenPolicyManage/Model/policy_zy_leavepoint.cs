using System;
namespace Sanben.Model
{
	/// <summary>
	/// policy_zy_leavepoint:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class policy_zy_leavepoint
	{
		public policy_zy_leavepoint()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _application_space;
		private string _rabate_number;
		private decimal? _leave_point;
		private decimal? _leave_money;
		private int? _startdate_ticket;
		private int? _enddate_ticket;
		private DateTime? _traveldate;
		private bool _isleavepointandmoney;
		private bool _isset;
		private string _remark;
		private DateTime? _changedate;
		private int? _platform_id;
		private int _sys_id;
		private int _rabate_class;
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
		public string navigation_company
		{
			set{ _navigation_company=value;}
			get{return _navigation_company;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string air_line
		{
			set{ _air_line=value;}
			get{return _air_line;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string application_space
		{
			set{ _application_space=value;}
			get{return _application_space;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rabate_number
		{
			set{ _rabate_number=value;}
			get{return _rabate_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? leave_point
		{
			set{ _leave_point=value;}
			get{return _leave_point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? leave_money
		{
			set{ _leave_money=value;}
			get{return _leave_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? startdate_ticket
		{
			set{ _startdate_ticket=value;}
			get{return _startdate_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? enddate_ticket
		{
			set{ _enddate_ticket=value;}
			get{return _enddate_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? traveldate
		{
			set{ _traveldate=value;}
			get{return _traveldate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isleavepointandmoney
		{
			set{ _isleavepointandmoney=value;}
			get{return _isleavepointandmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isSet
		{
			set{ _isset=value;}
			get{return _isset;}
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
		public DateTime? changedate
		{
			set{ _changedate=value;}
			get{return _changedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? platform_id
		{
			set{ _platform_id=value;}
			get{return _platform_id;}
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
		public int rabate_class
		{
			set{ _rabate_class=value;}
			get{return _rabate_class;}
		}
		#endregion Model

	}
}

