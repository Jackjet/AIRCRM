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
namespace Sanben.Web.policy_zy_leavepoint
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
		Sanben.BLL.policy_zy_leavepoint bll=new Sanben.BLL.policy_zy_leavepoint();
		Sanben.Model.policy_zy_leavepoint model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblnavigation_company.Text=model.navigation_company;
		this.lblair_line.Text=model.air_line;
		this.lblapplication_space.Text=model.application_space;
		this.lblrabate_number.Text=model.rabate_number;
		this.lblleave_point.Text=model.leave_point.ToString();
		this.lblleave_money.Text=model.leave_money.ToString();
		this.lblstartdate_ticket.Text=model.startdate_ticket.ToString();
		this.lblenddate_ticket.Text=model.enddate_ticket.ToString();
		this.lbltraveldate.Text=model.traveldate.ToString();
		this.lblisleavepointandmoney.Text=model.isleavepointandmoney?"是":"否";
		this.lblisSet.Text=model.isSet?"是":"否";
		this.lblremark.Text=model.remark;
		this.lblchangedate.Text=model.changedate.ToString();
		this.lblplatform_id.Text=model.platform_id.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lblrabate_class.Text=model.rabate_class.ToString();

	}


    }
}
