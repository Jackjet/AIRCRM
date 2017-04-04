using System;
namespace Sanben.Model
{
	/// <summary>
	/// Platform_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Platform_type
	{
		public Platform_type()
		{}
		#region Model
		private int _id;
		private string _website_name;
		private string _platform_interface;
		private string _website_platfrom;
		private string _platform_name;
		private int? _platform_id;
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
		public string website_name
		{
			set{ _website_name=value;}
			get{return _website_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_interface
		{
			set{ _platform_interface=value;}
			get{return _platform_interface;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string website_platfrom
		{
			set{ _website_platfrom=value;}
			get{return _website_platfrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string platform_name
		{
			set{ _platform_name=value;}
			get{return _platform_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? platform_id
		{
			set{ _platform_id=value;}
			get{return _platform_id;}
		}
		#endregion Model

	}
}

