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
namespace Sanben.Web.Passenger
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
		Sanben.BLL.Passenger bll=new Sanben.BLL.Passenger();
		Sanben.Model.Passenger model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblageType.Text=model.ageType;
		this.lblcardType.Text=model.cardType;
		this.lblprice.Text=model.price;
		this.lblpriceType.Text=model.priceType;
		this.lblcardNum.Text=model.cardNum;
		this.lbleticketNum.Text=model.eticketNum;
		this.lblinsuranceCount.Text=model.insuranceCount;
		this.lblbxSource.Text=model.bxSource;
		this.lblbxName.Text=model.bxName;
		this.lblo_id.Text=model.o_id.ToString();

	}


    }
}
