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
namespace Sanben.Web.AirMan
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
		Sanben.BLL.AirMan bll=new Sanben.BLL.AirMan();
		Sanben.Model.AirMan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblStartCode.Text=model.StartCode;
		this.lblArriveCode.Text=model.ArriveCode;
		this.lblCarrierName.Text=model.CarrierName;
		this.lblStatus.Text=model.Status;
		this.lblAddTime.Text=model.AddTime.ToString();

	}


    }
}
