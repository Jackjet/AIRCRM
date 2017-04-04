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
namespace Sanben.Web.51bookPolicy
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
		Sanben.BLL.51bookPolicy bll=new Sanben.BLL.51bookPolicy();
		Sanben.Model.51bookPolicy model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lbladultAirportTax.Text=model.adultAirportTax;
		this.lbladultFuelTax.Text=model.adultFuelTax;
		this.lblchildAirportTax.Text=model.childAirportTax;
		this.lblchildFuelTax.Text=model.childFuelTax;
		this.lblflightNo.Text=model.flightNo;
		this.lbladultSettlePrice.Text=model.adultSettlePrice;
		this.lblairlineCode.Text=model.airlineCode;
		this.lblcomment.Text=model.comment;
		this.lblcommisionPoint.Text=model.commisionPoint;
		this.lblneedSwitchPNR.Text=model.needSwitchPNR;
		this.lblpolicyId.Text=model.policyId;
		this.lblpolicyType.Text=model.policyType;
		this.lblproductType.Text=model.productType;
		this.lblrouteType.Text=model.routeType;
		this.lblseatType.Text=model.seatType;
		this.lblsupplyOfficeNo.Text=model.supplyOfficeNo;
		this.lblticketSpeed.Text=model.ticketSpeed;
		this.lblvtWorkTime.Text=model.vtWorkTime;
		this.lblworkTime.Text=model.workTime;
		this.lblseatCode.Text=model.seatCode;
		this.lblticketPrice.Text=model.ticketPrice;
		this.lblAddtime.Text=model.Addtime.ToString();
		this.lblIsUpload.Text=model.IsUpload?"是":"否";
		this.lblIsUpdate.Text=model.IsUpdate?"是":"否";

	}


    }
}
