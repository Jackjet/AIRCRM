using System;
namespace Sanben.Model
{
	/// <summary>
	/// orderInterfaceConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class orderInterfaceConfig
	{
		public orderInterfaceConfig()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _password;
		private string _orderaddress;
		private string _interfaceaddress;
		private DateTime _startdate;
		private string _orderstatus;
		private bool _isautomaticgainorder;
		private bool _isautomaticticket;
		private string _flightcompany;
		private string _startairport;
		private string _endairport;
		private decimal? _maxdeficit;
		private string _linkphone;
		private string _automaticticketplat;
		private int _sys_id;
		private int _platform_type_id;
		private string _rt_user;
		private string _rt_pwd;
		private string _etermrt;
		private string _etermrtuser;
		private string _etermrtpwd;
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
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderAddress
		{
			set{ _orderaddress=value;}
			get{return _orderaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string interfaceAddress
		{
			set{ _interfaceaddress=value;}
			get{return _interfaceaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime startDate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string orderStatus
		{
			set{ _orderstatus=value;}
			get{return _orderstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isAutomaticGainOrder
		{
			set{ _isautomaticgainorder=value;}
			get{return _isautomaticgainorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool isAutomaticTicket
		{
			set{ _isautomaticticket=value;}
			get{return _isautomaticticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flightCompany
		{
			set{ _flightcompany=value;}
			get{return _flightcompany;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string startAirport
		{
			set{ _startairport=value;}
			get{return _startairport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string endAirport
		{
			set{ _endairport=value;}
			get{return _endairport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? maxDeficit
		{
			set{ _maxdeficit=value;}
			get{return _maxdeficit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string linkPhone
		{
			set{ _linkphone=value;}
			get{return _linkphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string automaticTicketPlat
		{
			set{ _automaticticketplat=value;}
			get{return _automaticticketplat;}
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
		public int platform_type_id
		{
			set{ _platform_type_id=value;}
			get{return _platform_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rt_user
		{
			set{ _rt_user=value;}
			get{return _rt_user;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rt_pwd
		{
			set{ _rt_pwd=value;}
			get{return _rt_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EtermRT
		{
			set{ _etermrt=value;}
			get{return _etermrt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EtermRTuser
		{
			set{ _etermrtuser=value;}
			get{return _etermrtuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EtermRTpwd
		{
			set{ _etermrtpwd=value;}
			get{return _etermrtpwd;}
		}
		#endregion Model

	}
}

