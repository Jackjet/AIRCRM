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
namespace Sanben.Web.Platform_type
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
		Sanben.BLL.Platform_type bll=new Sanben.BLL.Platform_type();
		Sanben.Model.Platform_type model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblwebsite_name.Text=model.website_name;
		this.lblplatform_interface.Text=model.platform_interface;
		this.lblwebsite_platfrom.Text=model.website_platfrom;
		this.lblplatform_name.Text=model.platform_name;
		this.lblplatform_id.Text=model.platform_id.ToString();

	}


    }
}
