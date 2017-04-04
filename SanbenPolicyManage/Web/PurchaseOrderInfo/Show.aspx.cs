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
namespace Sanben.Web.PurchaseOrderInfo
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
		Sanben.BLL.PurchaseOrderInfo bll=new Sanben.BLL.PurchaseOrderInfo();
		Sanben.Model.PurchaseOrderInfo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblprice.Text=model.price;
		this.lblissue_ticket_type.Text=model.issue_ticket_type;
		this.lblissue_ticket_platform_code.Text=model.issue_ticket_platform_code;
		this.lblsource_transaction_id.Text=model.source_transaction_id;
		this.lblsource_order_no.Text=model.source_order_no;
		this.lbltpp_type.Text=model.tpp_type;
		this.lblstatus.Text=model.status;
		this.lblpay_commercial_no.Text=model.pay_commercial_no;
		this.lbloffline_pay_type.Text=model.offline_pay_type;
		this.lbloffline_pay_cardno.Text=model.offline_pay_cardno;
		this.lblplatform_mem_id.Text=model.platform_mem_id;
		this.lbloperator.Text=model.operator;
		this.lblrefund_price.Text=model.refund_price;
		this.lblo_id.Text=model.o_id.ToString();

	}


    }
}
