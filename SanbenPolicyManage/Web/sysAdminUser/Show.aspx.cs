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
namespace Sanben.Web.sysAdminUser
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
		Sanben.BLL.sysAdminUser bll=new Sanben.BLL.sysAdminUser();
		Sanben.Model.sysAdminUser model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblusername.Text=model.username;
		this.lblpassword.Text=model.password;
		this.lblCreateDate.Text=model.CreateDate.ToString();
		this.lblRoleList.Text=model.RoleList;
		this.lblCheckAuthority.Text=model.CheckAuthority;
		this.lblStop.Text=model.Stop?"是":"否";
		this.lblIsMoify.Text=model.IsMoify?"是":"否";
		this.lblRemark.Text=model.Remark;
		this.lblRealName.Text=model.RealName;
		this.lblCode.Text=model.Code;
		this.lblMobile.Text=model.Mobile;
		this.lblTelephone.Text=model.Telephone;
		this.lblQQ.Text=model.QQ;
		this.lblEmaile.Text=model.Emaile;
		this.lblCompany.Text=model.Company;
		this.lblCompanyAddress.Text=model.CompanyAddress;
		this.lblParentID.Text=model.ParentID.ToString();

	}


    }
}
