using System;
namespace Sanben.Model
{
	/// <summary>
	/// ctripPolicyRebate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ctripPolicyRebate
	{
		public ctripPolicyRebate()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private string _application_space;
		private decimal _rabate_number;
		private decimal _leave_money;
		private int? _ticket_price_lowest;
		private int? _ticket_price_highest;
		private int _rabate_class;
		private string _returntype;
		private int _sys_id;
		private int _platform_type_id;
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
		public decimal rabate_number
		{
			set{ _rabate_number=value;}
			get{return _rabate_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal leave_money
		{
			set{ _leave_money=value;}
			get{return _leave_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ticket_price_lowest
		{
			set{ _ticket_price_lowest=value;}
			get{return _ticket_price_lowest;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ticket_price_highest
		{
			set{ _ticket_price_highest=value;}
			get{return _ticket_price_highest;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int rabate_class
		{
			set{ _rabate_class=value;}
			get{return _rabate_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string returnType
		{
			set{ _returntype=value;}
			get{return _returntype;}
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
		#endregion Model

	}
}

