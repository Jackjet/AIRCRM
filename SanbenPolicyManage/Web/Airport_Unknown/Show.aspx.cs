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
namespace Sanben.Web.Airport_Unknown
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
		Sanben.BLL.Airport_Unknown bll=new Sanben.BLL.Airport_Unknown();
		Sanben.Model.Airport_Unknown model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblCabin.Text=model.Cabin;
		this.lblChildCabin.Text=model.ChildCabin.ToString();
		this.lblDiscount.Text=model.Discount;
		this.lblPrice.Text=model.Price.ToString();
		this.lblSurplus_Seat_Qty.Text=model.Surplus_Seat_Qty;
		this.lblCabin_Status.Text=model.Cabin_Status;
		this.lblLine_Number.Text=model.Line_Number;

	}


    }
}
