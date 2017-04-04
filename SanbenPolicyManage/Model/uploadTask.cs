using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class uploadTask
	{
		public uploadTask()
		{}
		#region Model
		private int _id;
		private string _execution_frequency;
		private DateTime _execution_time;
		private string _upload_platfrom;
		private string _policy_class;
		private int _upload_class;
		private bool _uploadplatfrom_specialpolicies;
		private string _policysource;
		private int _triptype;
		private int _execute_number;
		private bool _condition;
		private int _sys_id;
		private int _uploadtype;
		private DateTime? _nextfulltime;
		private DateTime? _nextaddtime;
		private bool _uploading;
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
		public string execution_frequency
		{
			set{ _execution_frequency=value;}
			get{return _execution_frequency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime execution_time
		{
			set{ _execution_time=value;}
			get{return _execution_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string upload_platFrom
		{
			set{ _upload_platfrom=value;}
			get{return _upload_platfrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policy_class
		{
			set{ _policy_class=value;}
			get{return _policy_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int upload_class
		{
			set{ _upload_class=value;}
			get{return _upload_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool uploadPlatFrom_specialPolicies
		{
			set{ _uploadplatfrom_specialpolicies=value;}
			get{return _uploadplatfrom_specialpolicies;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string policySource
		{
			set{ _policysource=value;}
			get{return _policysource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tripType
		{
			set{ _triptype=value;}
			get{return _triptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int execute_number
		{
			set{ _execute_number=value;}
			get{return _execute_number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool condition
		{
			set{ _condition=value;}
			get{return _condition;}
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
		public int uploadType
		{
			set{ _uploadtype=value;}
			get{return _uploadtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NextFullTime
		{
			set{ _nextfulltime=value;}
			get{return _nextfulltime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NextAddTime
		{
			set{ _nextaddtime=value;}
			get{return _nextaddtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Uploading
		{
			set{ _uploading=value;}
			get{return _uploading;}
		}
		#endregion Model

	}
}

