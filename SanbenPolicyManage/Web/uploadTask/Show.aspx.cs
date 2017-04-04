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
namespace Sanben.Web.uploadTask
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
		Sanben.BLL.uploadTask bll=new Sanben.BLL.uploadTask();
		Sanben.Model.uploadTask model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblexecution_frequency.Text=model.execution_frequency;
		this.lblexecution_time.Text=model.execution_time.ToString();
		this.lblupload_platFrom.Text=model.upload_platFrom;
		this.lblpolicy_class.Text=model.policy_class;
		this.lblupload_class.Text=model.upload_class.ToString();
		this.lbluploadPlatFrom_specialPolicies.Text=model.uploadPlatFrom_specialPolicies?"是":"否";
		this.lblpolicySource.Text=model.policySource;
		this.lbltripType.Text=model.tripType.ToString();
		this.lblexecute_number.Text=model.execute_number.ToString();
		this.lblcondition.Text=model.condition?"是":"否";
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lbluploadType.Text=model.uploadType.ToString();
		this.lblNextFullTime.Text=model.NextFullTime.ToString();
		this.lblNextAddTime.Text=model.NextAddTime.ToString();
		this.lblUploading.Text=model.Uploading?"是":"否";

	}


    }
}
