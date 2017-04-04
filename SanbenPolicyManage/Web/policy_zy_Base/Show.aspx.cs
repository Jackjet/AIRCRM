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
namespace Sanben.Web.policy_zy_Base
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
		Sanben.BLL.policy_zy_Base bll=new Sanben.BLL.policy_zy_Base();
		Sanben.Model.policy_zy_Base model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblleavepoint.Text=model.leavepoint.ToString();
		this.lblleavemoney.Text=model.leavemoney.ToString();
		this.lblis_filter.Text=model.is_filter?"是":"否";
		this.lblstarttime.Text=model.starttime.ToString();
		this.lblendtime.Text=model.endtime.ToString();
		this.lbllowest_rebate.Text=model.lowest_rebate.ToString();
		this.lblhighest_rebate.Text=model.highest_rebate.ToString();
		this.lblearliest_advance_days.Text=model.earliest_advance_days.ToString();
		this.lblnight_before_days.Text=model.night_before_days.ToString();
		this.lblpointSetType.Text=model.pointSetType.ToString();
		this.lblisuploadfirstclass.Text=model.isuploadfirstclass?"是":"否";
		this.lblisuploadchildclass.Text=model.isuploadchildclass?"是":"否";
		this.lblNFDpolicy.Text=model.NFDpolicy?"是":"否";
		this.lblflylimittime.Text=model.flylimittime;
		this.lblplatfromPolicy.Text=model.platfromPolicy;
		this.lblGWpolicy.Text=model.GWpolicy;
		this.lbluploadway.Text=model.uploadway?"是":"否";
		this.lblisuploadsharefight.Text=model.isuploadsharefight?"是":"否";
		this.lbladdpricejisuan.Text=model.addpricejisuan?"是":"否";
		this.lbladdpriceCovertType.Text=model.addpriceCovertType.ToString();
		this.lbladdPriceSet.Text=model.addPriceSet.ToString();
		this.lbllimitSit.Text=model.limitSit.ToString();
		this.lblsaleSit.Text=model.saleSit.ToString();
		this.lblis_autoticket.Text=model.is_autoticket?"是":"否";
		this.lblis_Need.Text=model.is_Need?"是":"否";
		this.lblisMail.Text=model.isMail.ToString();
		this.lblisPay.Text=model.isPay?"是":"否";
		this.lblAuthorizeOffice.Text=model.AuthorizeOffice;
		this.lblrefund_rule.Text=model.refund_rule;
		this.lblchangedate_rule.Text=model.changedate_rule;
		this.lblis_allowed_sign.Text=model.is_allowed_sign?"是":"否";
		this.lblis_provide_regular_passenger_integral.Text=model.is_provide_regular_passenger_integral?"是":"否";
		this.lbldocument_type.Text=model.document_type.ToString();
		this.lblmaxage.Text=model.maxage.ToString();
		this.lblminage.Text=model.minage.ToString();
		this.lblclass_description.Text=model.class_description;
		this.lblspecial_ticketing_instructions.Text=model.special_ticketing_instructions;
		this.lbllowest_price.Text=model.lowest_price.ToString();
		this.lblhighest_price.Text=model.highest_price.ToString();
		this.lbllastupdatetime.Text=model.lastupdatetime.ToString();
		this.lblsysuser_id.Text=model.sysuser_id.ToString();
		this.lblplatform_id.Text=model.platform_id.ToString();

	}


    }
}
