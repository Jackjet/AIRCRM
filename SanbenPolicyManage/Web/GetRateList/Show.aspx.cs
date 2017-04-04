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
namespace Sanben.Web.GetRateList
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
		Sanben.BLL.GetRateList bll=new Sanben.BLL.GetRateList();
		Sanben.Model.GetRateList model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblPolicyId.Text=model.PolicyId;
		this.lblRateId.Text=model.RateId;
		this.lblScityE.Text=model.ScityE;
		this.lblEcityE.Text=model.EcityE;
		this.lblAirComE.Text=model.AirComE;
		this.lblNoAirComE.Text=model.NoAirComE;
		this.lblPolicyType.Text=model.PolicyType;
		this.lblCabin.Text=model.Cabin;
		this.lblVoyageType.Text=model.VoyageType;
		this.lblUserType.Text=model.UserType;
		this.lblRateType.Text=model.RateType;
		this.lblDiscounts.Text=model.Discounts.ToString();
		this.lblSdate.Text=model.Sdate;
		this.lblEdate.Text=model.Edate;
		this.lblWorkTimBegin.Text=model.WorkTimBegin;
		this.lblWorkTImeEnd.Text=model.WorkTImeEnd;
		this.lblRewards.Text=model.Rewards;
		this.lblRemark.Text=model.Remark;
		this.lblET.Text=model.ET;
		this.lblWP.Text=model.WP;
		this.lblSP.Text=model.SP;
		this.lblXF.Text=model.XF;
		this.lblPromotionDiscount.Text=model.PromotionDiscount;
		this.lblNewRateNo.Text=model.NewRateNo;
		this.lblOfficeNum.Text=model.OfficeNum;
		this.lblRefundTimeBegin.Text=model.RefundTimeBegin;
		this.lblRefundTimeEnd.Text=model.RefundTimeEnd;
		this.lblLastModifyTime.Text=model.LastModifyTime;
		this.lblLimitModels.Text=model.LimitModels;
		this.lblRefundRulesWay.Text=model.RefundRulesWay;
		this.lblTPRemark.Text=model.TPRemark;
		this.lblChangeMsg.Text=model.ChangeMsg;
		this.lblInvalidMsg.Text=model.InvalidMsg;
		this.lblRiseCabin.Text=model.RiseCabin;
		this.lblForeignMsg.Text=model.ForeignMsg;
		this.lblOutTicketPercent.Text=model.OutTicketPercent;
		this.lblInvoiceMsg.Text=model.InvoiceMsg;
		this.lblPrintInvoice.Text=model.PrintInvoice;
		this.lblSwitchPNR.Text=model.SwitchPNR;
		this.lblChange.Text=model.Change;
		this.lblcomReturn.Text=model.comReturn;
		this.lblPlatForm.Text=model.PlatForm;
		this.lblAddTime.Text=model.AddTime.ToString();
		this.lblCompany.Text=model.Company;
		this.lblAirLine.Text=model.AirLine;
		this.lblIsUpload.Text=model.IsUpload?"是":"否";
		this.lblIsUpdate.Text=model.IsUpdate?"是":"否";

	}


    }
}
