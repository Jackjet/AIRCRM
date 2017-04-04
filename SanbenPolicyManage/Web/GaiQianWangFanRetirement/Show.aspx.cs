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
namespace Sanben.Web.GaiQianWangFanRetirement
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
		Sanben.BLL.GaiQianWangFanRetirement bll=new Sanben.BLL.GaiQianWangFanRetirement();
		Sanben.Model.GaiQianWangFanRetirement model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblnavigation_company.Text=model.navigation_company;
		this.lblair_line.Text=model.air_line;
		this.lblquchengSpace.Text=model.quchengSpace;
		this.lblhuichengSpace.Text=model.huichengSpace;
		this.lblinitiate_mode.Text=model.initiate_mode?"是":"否";
		this.lblstartDate.Text=model.startDate.ToString();
		this.lblendDate.Text=model.endDate.ToString();
		this.lblrefund_rule.Text=model.refund_rule;
		this.lblchangedate_rule.Text=model.changedate_rule;
		this.lblis_allowed_sign.Text=model.is_allowed_sign?"是":"否";
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();

	}


    }
}
