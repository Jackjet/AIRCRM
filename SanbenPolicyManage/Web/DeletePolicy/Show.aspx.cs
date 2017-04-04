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
namespace Sanben.Web.DeletePolicy
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
		Sanben.BLL.DeletePolicy bll=new Sanben.BLL.DeletePolicy();
		Sanben.Model.DeletePolicy model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblflightcode.Text=model.flightcode;
		this.lblpolicyCode.Text=model.policyCode;
		this.lbldpt.Text=model.dpt;
		this.lblarr.Text=model.arr;
		this.lblcabin.Text=model.cabin;
		this.lblstartdate.Text=model.startdate.ToString();
		this.lblenddate.Text=model.enddate.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();

	}


    }
}
