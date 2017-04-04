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
namespace Sanben.Web.platformB2B_ticket_account
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
		Sanben.BLL.platformB2B_ticket_account bll=new Sanben.BLL.platformB2B_ticket_account();
		Sanben.Model.platformB2B_ticket_account model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblMaccount.Text=model.Maccount;
		this.lblCaccount.Text=model.Caccount;
		this.lblpaysrc.Text=model.paysrc;
		this.lblpaytype.Text=model.paytype;
		this.lblsysUserId.Text=model.sysUserId.ToString();
		this.lblplatformName_id.Text=model.platformName_id.ToString();

	}


    }
}
