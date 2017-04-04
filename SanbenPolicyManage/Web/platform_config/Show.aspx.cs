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
namespace Sanben.Web.platform_config
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
		Sanben.BLL.platform_config bll=new Sanben.BLL.platform_config();
		Sanben.Model.platform_config model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();
		this.lblusername.Text=model.username;
		this.lblpassword.Text=model.password;
		this.lblrealm_name.Text=model.realm_name;
		this.lblbind_ip_address.Text=model.bind_ip_address;
		this.lblsys_user_id.Text=model.sys_user_id.ToString();

	}


    }
}
