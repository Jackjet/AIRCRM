using System;
namespace Sanben.Model
{
	/// <summary>
	/// BackupInsurance:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BackupInsurance
	{
		public BackupInsurance()
		{}
		#region Model
		private int _id;
		private string _insuranceno;
		private string _bxflight;
		private string _bxstatus;
		private int? _p_id;
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
		public string insuranceNo
		{
			set{ _insuranceno=value;}
			get{return _insuranceno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bxFlight
		{
			set{ _bxflight=value;}
			get{return _bxflight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bxStatus
		{
			set{ _bxstatus=value;}
			get{return _bxstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? p_id
		{
			set{ _p_id=value;}
			get{return _p_id;}
		}
		#endregion Model

	}
}

