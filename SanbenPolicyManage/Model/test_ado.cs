using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class test_ado
	{
		public test_ado()
		{}
		#region Model
		private string _add;
		/// <summary>
		/// 
		/// </summary>
		public string ADD
		{
			set{ _add=value;}
			get{return _add;}
		}
		#endregion Model

	}
}

