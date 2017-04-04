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
namespace Sanben.Web.Flight
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
		Sanben.BLL.Flight bll=new Sanben.BLL.Flight();
		Sanben.Model.Flight model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblcode.Text=model.code;
		this.lblcabin.Text=model.cabin;
		this.lblccabin.Text=model.ccabin;
		this.lbldep.Text=model.dep;
		this.lblarr.Text=model.arr;
		this.lbldepDay.Text=model.depDay;
		this.lbldepTime.Text=model.depTime;
		this.lblarrTime.Text=model.arrTime;
		this.lblrealCode.Text=model.realCode;
		this.lblo_id.Text=model.o_id.ToString();

	}


    }
}
