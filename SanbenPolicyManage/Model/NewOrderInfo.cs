using System;
namespace Sanben.Model
{
	/// <summary>
	/// NewOrderInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NewOrderInfo
	{
		public NewOrderInfo()
		{}
		#region Model
		private int _pk_id;
		/// <summary>
		/// 
		/// </summary>
		public int pk_id
		{
			set{ _pk_id=value;}
			get{return _pk_id;}
		}
		#endregion Model

	}
}

