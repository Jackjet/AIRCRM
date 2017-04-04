using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Sanben.Web.UploadPolicyResult
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Sanben.BLL.UploadPolicyResult bll=new Sanben.BLL.UploadPolicyResult();
		Sanben.Model.UploadPolicyResult model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblstartMode.Text=model.startMode;
		this.lblupload_platFrom.Text=model.upload_platFrom;
		this.lblupload_class.Text=model.upload_class.ToString();
		this.lbluploadType.Text=model.uploadType.ToString();
		this.lbluploadResult.Text=model.uploadResult;
		this.lbluploadNumber.Text=model.uploadNumber.ToString();
		this.lblerrorNumber.Text=model.errorNumber.ToString();
		this.lblresult.Text=model.result;
		this.lbluploadTime.Text=model.uploadTime.ToString();
		this.lblnoticeTime.Text=model.noticeTime.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();

	}


    }
}
