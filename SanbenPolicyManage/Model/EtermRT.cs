using System;
namespace Sanben.Model
{
	/// <summary>
	/// EtermRT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EtermRT
	{
		public EtermRT()
		{}
		#region Model
		private int _id;
		private string _etermrtuser;
		private string _etermrtpwd;
		private string _airline;
		private string _effect;
		private int _userid;
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
		public string EtermRTuser
		{
			set{ _etermrtuser=value;}
			get{return _etermrtuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EtermRTpwd
		{
			set{ _etermrtpwd=value;}
			get{return _etermrtpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string airline
		{
			set{ _airline=value;}
			get{return _airline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string effect
		{
			set{ _effect=value;}
			get{return _effect;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

