using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class Thtest
	{
		public Thtest()
		{}
		#region Model
		private int _id;
		private int _no;
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
		public int no
		{
			set{ _no=value;}
			get{return _no;}
		}
		#endregion Model

	}
}

