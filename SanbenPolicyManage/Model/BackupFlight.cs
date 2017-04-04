using System;
namespace Sanben.Model
{
	/// <summary>
	/// BackupFlight:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BackupFlight
	{
		public BackupFlight()
		{}
		#region Model
		private int _id;
		private string _code;
		private string _cabin;
		private string _ccabin;
		private string _dep;
		private string _arr;
		private string _depday;
		private string _deptime;
		private string _arrtime;
		private string _realcode;
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
		public string code
		{
			set{ _code=value;}
			get{return _code;}
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
		public string ccabin
		{
			set{ _ccabin=value;}
			get{return _ccabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dep
		{
			set{ _dep=value;}
			get{return _dep;}
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
		public string depDay
		{
			set{ _depday=value;}
			get{return _depday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string depTime
		{
			set{ _deptime=value;}
			get{return _deptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string arrTime
		{
			set{ _arrtime=value;}
			get{return _arrtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string realCode
		{
			set{ _realcode=value;}
			get{return _realcode;}
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

