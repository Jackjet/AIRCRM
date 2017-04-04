using System;
namespace Sanben.Model
{
	/// <summary>
	/// BackupLog_Opera:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BackupLog_Opera
	{
		public BackupLog_Opera()
		{}
		#region Model
		private int _id;
		private string _operator;
		private string _time;
		private string _action;
		private int? _o_id;
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
		public string LogOperator
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string action
		{
			set{ _action=value;}
			get{return _action;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? o_id
		{
			set{ _o_id=value;}
			get{return _o_id;}
		}
		#endregion Model

	}
}

