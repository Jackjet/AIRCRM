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
namespace Sanben.Web.SYSAdminRole
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Sanben.BLL.SYSAdminRole bll=new Sanben.BLL.SYSAdminRole();
		Sanben.Model.SYSAdminRole model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
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
				strErr+="RoleName不能为空！\\n";	
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
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string RoleName=this.txtRoleName.Text;
			bool Stop=this.chkStop.Checked;
			int Ordering=int.Parse(this.txtOrdering.Text);
			string MenuList=this.txtMenuList.Text;
			string AuthorityList=this.txtAuthorityList.Text;
			bool IsModify=this.chkIsModify.Checked;
			string Remark=this.txtRemark.Text;


			Sanben.Model.SYSAdminRole model=new Sanben.Model.SYSAdminRole();
			model.id=id;
			model.RoleName=RoleName;
			model.Stop=Stop;
			model.Ordering=Ordering;
			model.MenuList=MenuList;
			model.AuthorityList=AuthorityList;
			model.IsModify=IsModify;
			model.Remark=Remark;

			Sanben.BLL.SYSAdminRole bll=new Sanben.BLL.SYSAdminRole();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
