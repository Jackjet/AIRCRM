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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Sanben.Web.SYS_Role
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Sanben.BLL.SYS_Role bll=new Sanben.BLL.SYS_Role();
		Sanben.Model.SYS_Role model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtRoleName.Text=model.RoleName;
		this.chkStop.Checked=model.Stop;
		this.txtOrdering.Text=model.Ordering.ToString();
		this.txtMenuList.Text=model.MenuList;
		this.txtAuthorityList.Text=model.AuthorityList;
		this.chkIsModify.Checked=model.IsModify;
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRoleName.Text.Trim().Length==0)
			{
				strErr+="角色名不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrdering.Text))
			{
				strErr+="Ordering格式错误！\\n";	
			}
			if(this.txtMenuList.Text.Trim().Length==0)
			{
				strErr+="MenuList不能为空！\\n";	
			}
			if(this.txtAuthorityList.Text.Trim().Length==0)
			{
				strErr+="AuthorityList不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string RoleName=this.txtRoleName.Text;
			bool Stop=this.chkStop.Checked;
			int Ordering=int.Parse(this.txtOrdering.Text);
			string MenuList=this.txtMenuList.Text;
			string AuthorityList=this.txtAuthorityList.Text;
			bool IsModify=this.chkIsModify.Checked;
			string Remark=this.txtRemark.Text;


			Sanben.Model.SYS_Role model=new Sanben.Model.SYS_Role();
			model.ID=ID;
			model.RoleName=RoleName;
			model.Stop=Stop;
			model.Ordering=Ordering;
			model.MenuList=MenuList;
			model.AuthorityList=AuthorityList;
			model.IsModify=IsModify;
			model.Remark=Remark;

			Sanben.BLL.SYS_Role bll=new Sanben.BLL.SYS_Role();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
