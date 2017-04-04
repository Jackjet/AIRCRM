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
namespace Sanben.Web.API380Ticket
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
		Sanben.BLL.API380Ticket bll=new Sanben.BLL.API380Ticket();
		Sanben.Model.API380Ticket model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcode.Text=model.code.ToString();
		this.lblmessage.Text=model.message;
		this.lblbigpnr.Text=model.bigpnr;
		this.lblair.Text=model.air;
		this.lblpnr.Text=model.pnr;
		this.lblpaystatus.Text=model.paystatus;
		this.lbltotaltax.Text=model.totaltax;
		this.lblticketprice.Text=model.ticketprice;
		this.lblorderno.Text=model.orderno;
		this.lblplatformB2B_name_id.Text=model.platformB2B_name_id.ToString();

	}


    }
}
