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
namespace Sanben.Web.rebate_wangfan
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
		Sanben.BLL.rebate_wangfan bll=new Sanben.BLL.rebate_wangfan();
		Sanben.Model.rebate_wangfan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblnavigation_company.Text=model.navigation_company;
		this.lblair_line.Text=model.air_line;
		this.lblqucheng_space.Text=model.qucheng_space;
		this.lblhuicheng_space.Text=model.huicheng_space;
		this.lblrabate_number.Text=model.rabate_number.ToString();
		this.lblleave_money.Text=model.leave_money.ToString();
		this.lblticket_price_lowest.Text=model.ticket_price_lowest.ToString();
		this.lblticket_price_highest.Text=model.ticket_price_highest.ToString();
		this.lblrabate_class.Text=model.rabate_class.ToString();
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();

	}


    }
}
