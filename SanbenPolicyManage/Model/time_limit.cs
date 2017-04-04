using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class time_limit
	{
		public time_limit()
		{}
		#region Model
		private int _id;
		private string _navigation_company;
		private string _air_line;
		private int _earliest_advance_days;
		private int _night_before_days;
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
		public int earliest_advance_days
		{
			set{ _earliest_advance_days=value;}
			get{return _earliest_advance_days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int night_before_days
		{
			set{ _night_before_days=value;}
			get{return _night_before_days;}
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

