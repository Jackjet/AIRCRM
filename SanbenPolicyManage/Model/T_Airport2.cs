using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class T_Airport2
	{
		public T_Airport2()
		{}
		#region Model
		private int _id;
		private string _airport_code;
		private string _airport_city;
		private string _airport_name;
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
		public string airport_code
		{
			set{ _airport_code=value;}
			get{return _airport_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string airport_city
		{
			set{ _airport_city=value;}
			get{return _airport_city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string airport_name
		{
			set{ _airport_name=value;}
			get{return _airport_name;}
		}
		#endregion Model

	}
}

