using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class T_Carrier
	{
		public T_Carrier()
		{}
		#region Model
		private int _id;
		private string _carrier_code;
		private string _carrier_name;
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
		public string carrier_code
		{
			set{ _carrier_code=value;}
			get{return _carrier_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string carrier_name
		{
			set{ _carrier_name=value;}
			get{return _carrier_name;}
		}
		#endregion Model

	}
}

