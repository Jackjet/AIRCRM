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
namespace Sanben.Web.Ticket380Policy
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
		Sanben.BLL.Ticket380Policy bll=new Sanben.BLL.Ticket380Policy();
		Sanben.Model.Ticket380Policy model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblpolicy_id.Text=model.policy_id;
		this.lblair_comp.Text=model.air_comp;
		this.lblstart_city.Text=model.start_city;
		this.lblarr_city.Text=model.arr_city;
		this.lblflight.Text=model.flight;
		this.lblcabin.Text=model.cabin;
		this.lblshare_line.Text=model.share_line;
		this.lblcabinprice.Text=model.cabinprice;
		this.lblpoint.Text=model.point;
		this.lblnakednum.Text=model.nakednum;
		this.lblis_auto_tic.Text=model.is_auto_tic;
		this.lbllogtime.Text=model.logtime;
		this.lbldeptime.Text=model.deptime;
		this.lblprice.Text=model.price;
		this.lblremark.Text=model.remark;
		this.lblfsdate.Text=model.fsdate;
		this.lblfedate.Text=model.fedate;
		this.lblsale_sdate.Text=model.sale_sdate;
		this.lblsale_edate.Text=model.sale_edate;
		this.lblAddTime.Text=model.AddTime.ToString();
		this.lblIsUpload.Text=model.IsUpload?"是":"否";
		this.lblIsUpdate.Text=model.IsUpdate?"是":"否";

	}


    }
}
