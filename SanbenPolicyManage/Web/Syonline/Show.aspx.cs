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
namespace Sanben.Web.Syonline
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
		Sanben.BLL.Syonline bll=new Sanben.BLL.Syonline();
		Sanben.Model.Syonline model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblloginname.Text=model.loginname;
		this.lblip.Text=model.ip;
		this.lblcreatedate.Text=model.createdate.ToString();
		this.lbltype.Text=model.type?"是":"否";
		this.lblipinfo.Text=model.ipinfo;

	}


    }
}
