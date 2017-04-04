using System;
namespace Sanben.Model
{
	/// <summary>
	/// DeletePolicy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeletePolicy
	{
		public DeletePolicy()
		{}
		#region Model
		private int _id;
		private string _flightcode;
		private string _policycode;
		private string _dpt;
		private string _arr;
		private string _cabin;
		private DateTime? _startdate;
		private DateTime? _enddate;
		private int _sys_id;
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
		public string flightcode
		{
			set{ _flightcode=value;}
			get{return _flightcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policyCode
		{
			set{ _policycode=value;}
			get{return _policycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dpt
		{
			set{ _dpt=value;}
			get{return _dpt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arr
		{
			set{ _arr=value;}
			get{return _arr;}
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
		public DateTime? startdate
		{
			set{ _startdate=value;}
			get{return _startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? enddate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		#endregion Model

	}
}

