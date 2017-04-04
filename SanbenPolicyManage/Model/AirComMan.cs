using System;
namespace Sanben.Model
{
	/// <summary>
	/// AirComMan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AirComMan
	{
		public AirComMan()
		{}
		#region Model
		private int _id;
		private string _carriercode;
		private string _carriername;
		private string _cabin;
		private string _discount;
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
		public string CarrierCode
		{
			set{ _carriercode=value;}
			get{return _carriercode;}
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
		public string Cabin
		{
			set{ _cabin=value;}
			get{return _cabin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		#endregion Model

	}
}

