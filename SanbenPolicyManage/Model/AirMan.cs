using System;
namespace Sanben.Model
{
	/// <summary>
	/// AirMan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AirMan
	{
		public AirMan()
		{}
		#region Model
		private int _id;
		private string _startcode;
		private string _arrivecode;
		private string _carriername;
		private string _status;
		private DateTime? _addtime;
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
		public string StartCode
		{
			set{ _startcode=value;}
			get{return _startcode;}
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
		public string CarrierName
		{
			set{ _carriername=value;}
			get{return _carriername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
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

