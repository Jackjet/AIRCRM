using System;
namespace Sanben.Model
{
	/// <summary>
	/// ROUTE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ROUTE
	{
		public ROUTE()
		{}
		#region Model
		private int _id;
		private string _scity;
		private string _ecity;
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
		/// 出发城市三字代码
		/// </summary>
		public string SCITY
		{
			set{ _scity=value;}
			get{return _scity;}
		}
		/// <summary>
		/// 到达城市三字代码
		/// </summary>
		public string ECITY
		{
			set{ _ecity=value;}
			get{return _ecity;}
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

