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
namespace Sanben.Web.Jinri_Order_Response
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
		Sanben.BLL.Jinri_Order_Response bll=new Sanben.BLL.Jinri_Order_Response();
		Sanben.Model.Jinri_Order_Response model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblOrderNo.Text=model.OrderNo;
		this.lblPNR.Text=model.PNR;
		this.lblGrowDiscount.Text=model.GrowDiscount;
		this.lblStayDiscount.Text=model.StayDiscount;
		this.lblPayMoney.Text=model.PayMoney;
		this.lblProfit.Text=model.Profit;
		this.lblStatus.Text=model.Status;
		this.lblDate.Text=model.Date;
		this.lblScity.Text=model.Scity;
		this.lblEcity.Text=model.Ecity;
		this.lblFlight.Text=model.Flight;
		this.lblStime.Text=model.Stime;
		this.lblEtime.Text=model.Etime;
		this.lblCabin.Text=model.Cabin;
		this.lblPrice.Text=model.Price.ToString();
		this.lblTax.Text=model.Tax.ToString();
		this.lblPCount.Text=model.PCount.ToString();
		this.lblPName.Text=model.PName;
		this.lblPCard.Text=model.PCard;
		this.lblJouneryInfo.Text=model.JouneryInfo;
		this.lblIsBuyInsurance.Text=model.IsBuyInsurance;
		this.lblremark.Text=model.remark;
		this.lblticket_no.Text=model.ticket_no;
		this.lblrefund_type.Text=model.refund_type.ToString();
		this.lblamount.Text=model.amount.ToString();
		this.lblpay_type.Text=model.pay_type;
		this.lbltrade_no.Text=model.trade_no;
		this.lblpay_time.Text=model.pay_time;
		this.lblOrderInfo_id.Text=model.OrderInfo_id.ToString();
		this.lblplatformB2B_name_id.Text=model.platformB2B_name_id.ToString();

	}


    }
}
