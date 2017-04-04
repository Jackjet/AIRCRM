using System;
namespace Sanben.Model
{
	/// <summary>
	/// platformB2B_name:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class platformB2B_name
	{
		public platformB2B_name()
		{}
		#region Model
		private int _id;
		private string _platform_name;
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
		public string platform_name
		{
			set{ _platform_name=value;}
			get{return _platform_name;}
		}
		#endregion Model

	}
}

