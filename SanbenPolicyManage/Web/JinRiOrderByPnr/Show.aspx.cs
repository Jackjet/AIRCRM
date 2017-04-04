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
namespace Sanben.Web.JinRiOrderByPnr
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
		Sanben.BLL.JinRiOrderByPnr bll=new Sanben.BLL.JinRiOrderByPnr();
		Sanben.Model.JinRiOrderByPnr model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblorderNo.Text=model.orderNo;
		this.lblpnr.Text=model.pnr;
		this.lblgrowDiscount.Text=model.growDiscount.ToString();
		this.lblstayDiscount.Text=model.stayDiscount.ToString();
		this.lblpayMoney.Text=model.payMoney.ToString();
		this.lblprofit.Text=model.profit.ToString();
		this.lblstatus.Text=model.status.ToString();
		this.lbldate.Text=model.date;
		this.lblscity.Text=model.scity;
		this.lblecity.Text=model.ecity;
		this.lblflight.Text=model.flight;
		this.lblstime.Text=model.stime;
		this.lbletime.Text=model.etime;
		this.lblcabin.Text=model.cabin;
		this.lblprice.Text=model.price.ToString();
		this.lbltax.Text=model.tax.ToString();
		this.lblpcount.Text=model.pcount.ToString();
		this.lblpName.Text=model.pName;
		this.lblpCard.Text=model.pCard;
		this.lbljouneryInfo.Text=model.jouneryInfo;
		this.lblisBuyInsurance.Text=model.isBuyInsurance;
		this.lblorderinfo_id.Text=model.orderinfo_id.ToString();

	}


    }
}
