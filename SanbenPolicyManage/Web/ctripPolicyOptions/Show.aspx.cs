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
namespace Sanben.Web.ctripPolicyOptions
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
		Sanben.BLL.ctripPolicyOptions bll=new Sanben.BLL.ctripPolicyOptions();
		Sanben.Model.ctripPolicyOptions model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbltolerate_stationary_point.Text=model.tolerate_stationary_point.ToString();
		this.lbltolerate_leave_money.Text=model.tolerate_leave_money.ToString();
		this.lbllowest_rebate.Text=model.lowest_rebate.ToString();
		this.lblhighest_rebate.Text=model.highest_rebate.ToString();
		this.lblearliest_advance_days.Text=model.earliest_advance_days.ToString();
		this.lblnight_before_days.Text=model.night_before_days.ToString();
		this.lblrebate_class_set.Text=model.rebate_class_set.ToString();
		this.lblticket_price_set.Text=model.ticket_price_set.ToString();
		this.lblworkTimeLimit.Text=model.workTimeLimit;
		this.lbldiscount.Text=model.discount.ToString();
		this.lblis_automatic_ticket.Text=model.is_automatic_ticket?"是":"否";
		this.lblis_mail_itinerary.Text=model.is_mail_itinerary?"是":"否";
		this.lbloff_number.Text=model.off_number;
		this.lblis_orientate.Text=model.is_orientate?"是":"否";
		this.lblspecial_ticketing_instructions.Text=model.special_ticketing_instructions;
		this.lblrefund_change_rule.Text=model.refund_change_rule;
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();

	}


    }
}
