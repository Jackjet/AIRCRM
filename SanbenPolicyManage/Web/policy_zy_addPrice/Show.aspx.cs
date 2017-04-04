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
namespace Sanben.Web.policy_zy_addPrice
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
		Sanben.BLL.policy_zy_addPrice bll=new Sanben.BLL.policy_zy_addPrice();
		Sanben.Model.policy_zy_addPrice model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblnavigation_company.Text=model.navigation_company;
		this.lblair_line.Text=model.air_line;
		this.lblapplication_space.Text=model.application_space;
		this.lbljisuanbase.Text=model.jisuanbase?"是":"否";
		this.lblconvertType.Text=model.convertType;
		this.lbladdValue.Text=model.addValue.ToString();
		this.lblplatform_id.Text=model.platform_id.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();

	}


    }
}
