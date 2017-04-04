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
namespace Sanben.Web.BaQianYiPolicy
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Sanben.BLL.BaQianYiPolicy bll=new Sanben.BLL.BaQianYiPolicy();
		Sanben.Model.BaQianYiPolicy model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblpolicy_num.Text=model.policy_num;
		this.lblstartcity.Text=model.startcity;
		this.lblarrivecity.Text=model.arrivecity;
		this.lblairline.Text=model.airline;
		this.lblfor_flight_no.Text=model.for_flight_no;
		this.lblex_flight_no.Text=model.ex_flight_no;
		this.lblpolicy_ratype.Text=model.policy_ratype;
		this.lblpoint.Text=model.point;
		this.lblcabin_discount.Text=model.cabin_discount;
		this.lblstartdate.Text=model.startdate;
		this.lblarrivedate.Text=model.arrivedate;
		this.lblnomal_workday.Text=model.nomal_workday;
		this.lblweekday.Text=model.weekday;
		this.lblvip_policy.Text=model.vip_policy;
		this.lblreturn_policy.Text=model.return_policy;
		this.lblpolicy_type.Text=model.policy_type;
		this.lblpolicy_note.Text=model.policy_note;
		this.lblsupplier_id.Text=model.supplier_id;
		this.lblor_ticket_t.Text=model.or_ticket_t;
		this.lblweek_ticket_t.Text=model.week_ticket_t;
		this.lblpolicy_flight.Text=model.policy_flight;
		this.lblend_state.Text=model.end_state;
		this.lbloffice_code.Text=model.office_code;
		this.lblsalestart_date.Text=model.salestart_date;
		this.lblsaleend_date.Text=model.saleend_date;
		this.lblsupport_pay.Text=model.support_pay;
		this.lblticket_efficient.Text=model.ticket_efficient;
		this.lblis_cgnum_ticket.Text=model.is_cgnum_ticket;
		this.lblis_open_low.Text=model.is_open_low;
		this.lbladdtime.Text=model.addtime.ToString();
		this.lbllast_modify_time.Text=model.last_modify_time;
		this.lblIsUpload.Text=model.IsUpload?"是":"否";
		this.lblIsUpdate.Text=model.IsUpdate?"是":"否";

	}


    }
}
