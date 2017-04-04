using System;
namespace Sanben.Model
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class UploadPolicyResult
	{
		public UploadPolicyResult()
		{}
		#region Model
		private int _id;
		private string _startmode;
		private string _upload_platfrom;
		private int? _upload_class;
		private int? _uploadtype;
		private string _uploadresult;
		private int? _uploadnumber;
		private int? _errornumber;
		private string _result;
		private DateTime? _uploadtime;
		private DateTime? _noticetime;
		private int _sys_id;
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
		public string startMode
		{
			set{ _startmode=value;}
			get{return _startmode;}
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
		public int? upload_class
		{
			set{ _upload_class=value;}
			get{return _upload_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? uploadType
		{
			set{ _uploadtype=value;}
			get{return _uploadtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string uploadResult
		{
			set{ _uploadresult=value;}
			get{return _uploadresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? uploadNumber
		{
			set{ _uploadnumber=value;}
			get{return _uploadnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? errorNumber
		{
			set{ _errornumber=value;}
			get{return _errornumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? uploadTime
		{
			set{ _uploadtime=value;}
			get{return _uploadtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? noticeTime
		{
			set{ _noticetime=value;}
			get{return _noticetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int sys_id
		{
			set{ _sys_id=value;}
			get{return _sys_id;}
		}
		#endregion Model

	}
}

