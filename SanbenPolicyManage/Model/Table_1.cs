using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class Table_1
	{
		public Table_1()
		{}
		#region Model
		private string _id;
		private string _name;
		private string _sex;
		private string _age;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string age
		{
			set{ _age=value;}
			get{return _age;}
		}
		#endregion Model

	}
}

