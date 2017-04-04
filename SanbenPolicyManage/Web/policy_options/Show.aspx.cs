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
namespace Sanben.Web.policy_options
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
		Sanben.BLL.policy_options bll=new Sanben.BLL.policy_options();
		Sanben.Model.policy_options model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblPolicy_interface_id.Text=model.Policy_interface_id.ToString();
		this.lbltolerate_stationary_point.Text=model.tolerate_stationary_point.ToString();
		this.lbltolerate_leave_money.Text=model.tolerate_leave_money.ToString();
		this.lblis_screening.Text=model.is_screening?"是":"否";
		this.lbllowest_rebate.Text=model.lowest_rebate.ToString();
		this.lblhighest_rebate.Text=model.highest_rebate.ToString();
		this.lblearliest_advance_days.Text=model.earliest_advance_days.ToString();
		this.lblnight_before_days.Text=model.night_before_days.ToString();
		this.lblrebate_class_set.Text=model.rebate_class_set.ToString();
		this.lblFlight_departure_time_start.Text=model.Flight_departure_time_start.ToString();
		this.lblis_automatic_ticket.Text=model.is_automatic_ticket?"是":"否";
		this.lblis_mail_itinerary.Text=model.is_mail_itinerary?"是":"否";
		this.lblempower_office_number.Text=model.empower_office_number;
		this.lblrefund_rule.Text=model.refund_rule;
		this.lblchangedate_rule.Text=model.changedate_rule;
		this.lblis_allowed_sign.Text=model.is_allowed_sign?"是":"否";
		this.lblis_provide_regular_passenger_integral.Text=model.is_provide_regular_passenger_integral?"是":"否";
		this.lbldocument_type.Text=model.document_type.ToString();
		this.lblminimum_age.Text=model.minimum_age.ToString();
		this.lblmaximum_age.Text=model.maximum_age.ToString();
		this.lblclass_description.Text=model.class_description;
		this.lblspecial_ticketing_instructions.Text=model.special_ticketing_instructions;
		this.lblsys_userId.Text=model.sys_userId.ToString();
		this.lblFlight_departure_time_end.Text=model.Flight_departure_time_end.ToString();

	}


    }
}
