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
namespace Sanben.Web.cabin_description
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
		Sanben.BLL.cabin_description bll=new Sanben.BLL.cabin_description();
		Sanben.Model.cabin_description model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblnavigation_company.Text=model.navigation_company;
		this.lblair_line.Text=model.air_line;
		this.lblcabin_explain.Text=model.cabin_explain;
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();

	}


    }
}
