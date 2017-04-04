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
namespace Sanben.Web.SYS_Role
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Sanben.BLL.SYS_Role bll=new Sanben.BLL.SYS_Role();
		Sanben.Model.SYS_Role model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
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
