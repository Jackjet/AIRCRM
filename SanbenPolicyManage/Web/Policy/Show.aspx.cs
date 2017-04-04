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
namespace Sanben.Web.Policy
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
		Sanben.BLL.Policy bll=new Sanben.BLL.Policy();
		Sanben.Model.Policy model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblflightcode.Text=model.flightcode;
		this.lblpolicyCode.Text=model.policyCode;
		this.lbldpt.Text=model.dpt;
		this.lblarr.Text=model.arr;
		this.lblflightNumLimit.Text=model.flightNumLimit;
		this.lblflightcondition.Text=model.flightcondition;
		this.lbldaycondition.Text=model.daycondition;
		this.lblcabin.Text=model.cabin;
		this.lbldiscountType.Text=model.discountType;
		this.lbldiscountValue.Text=model.discountValue;
		this.lblreturnpoint.Text=model.returnpoint.ToString();
		this.lblreturnprice.Text=model.returnprice.ToString();
		this.lblstartdate_ticket.Text=model.startdate_ticket.ToString();
		this.lblenfdate_ticket.Text=model.enfdate_ticket.ToString();
		this.lblstartdate.Text=model.startdate.ToString();
		this.lblenddate.Text=model.enddate.ToString();
		this.lblbeforeValidDay.Text=model.beforeValidDay.ToString();
		this.lblbacknote.Text=model.backnote;
		this.lblcabinnote.Text=model.cabinnote;
		this.lblautoTicket.Text=model.autoTicket?"是":"否";
		this.lblshared.Text=model.shared?"是":"否";
		this.lblofficeno.Text=model.officeno;
		this.lblktype.Text=model.ktype;
		this.lblcheckCycleTime.Text=model.checkCycleTime.ToString();
		this.lblautoCheckOverTime.Text=model.autoCheckOverTime.ToString();
		this.lblmanualCheckOverTime.Text=model.manualCheckOverTime.ToString();
		this.lblpolicy.Text=model.policy;
		this.lbldownDiscount.Text=model.downDiscount.ToString();
		this.lblpata.Text=model.pata?"是":"否";
		this.lblspecialRule.Text=model.specialRule;
		this.lblallCabin.Text=model.allCabin.ToString();
		this.lblcanPay.Text=model.canPay?"是":"否";
		this.lbldeptTimeSlot.Text=model.deptTimeSlot;
		this.lblneedPnr.Text=model.needPnr?"是":"否";
		this.lblone_flightlimit.Text=model.one_flightlimit;
		this.lblone_limitnum.Text=model.one_limitnum;
		this.lbltwo_flightlimit.Text=model.two_flightlimit;
		this.lbltwo_limitnum.Text=model.two_limitnum;
		this.lblone_daylimit.Text=model.one_daylimit;
		this.lbltwo_daylimit.Text=model.two_daylimit;
		this.lblgocabin.Text=model.gocabin;
		this.lblbackcabin.Text=model.backcabin;
		this.lblone_startdate.Text=model.one_startdate.ToString();
		this.lblone_enddate.Text=model.one_enddate.ToString();
		this.lbltwo_startdate.Text=model.two_startdate.ToString();
		this.lbltwo_enddate.Text=model.two_enddate.ToString();
		this.lblshort_stoptime.Text=model.short_stoptime.ToString();
		this.lbllong_stoptime.Text=model.long_stoptime.ToString();
		this.lblcosttype.Text=model.costtype;
		this.lblcostPrice.Text=model.costPrice.ToString();
		this.lblproxyPrice.Text=model.proxyPrice.ToString();
		this.lblbackPrice.Text=model.backPrice.ToString();
		this.lblpolicySource.Text=model.policySource;
		this.lblxcd.Text=model.xcd;
		this.lblreturnRule.Text=model.returnRule;
		this.lblchangeRule.Text=model.changeRule;
		this.lblendorsement.Text=model.endorsement?"是":"否";
		this.lblflyerpoints.Text=model.flyerpoints?"是":"否";
		this.lblcardType.Text=model.cardType.ToString();
		this.lblmaxAge.Text=model.maxAge.ToString();
		this.lblminAge.Text=model.minAge.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lbluploadPolicyType.Text=model.uploadPolicyType;
		this.lblearliestBeforeValidDay.Text=model.earliestBeforeValidDay.ToString();
		this.lblisUpload.Text=model.isUpload.ToString();
		this.lblimportTime.Text=model.importTime.ToString();
		this.lbluploadPlat.Text=model.uploadPlat;
		this.lbluploadResult.Text=model.uploadResult.ToString();

	}


    }
}
