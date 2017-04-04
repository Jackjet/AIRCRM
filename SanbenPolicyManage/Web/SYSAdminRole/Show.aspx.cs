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
namespace Sanben.Web.SYSAdminRole
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
		Sanben.BLL.SYSAdminRole bll=new Sanben.BLL.SYSAdminRole();
		Sanben.Model.SYSAdminRole model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblRoleName.Text=model.RoleName;
		this.lblStop.Text=model.Stop?"是":"否";
		this.lblOrdering.Text=model.Ordering.ToString();
		this.lblMenuList.Text=model.MenuList;
		this.lblAuthorityList.Text=model.AuthorityList;
		this.lblIsModify.Text=model.IsModify?"是":"否";
		this.lblRemark.Text=model.Remark;

	}


    }
}
