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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string RoleName=this.txtRoleName.Text;
			bool Stop=this.chkStop.Checked;
			int Ordering=int.Parse(this.txtOrdering.Text);
			string MenuList=this.txtMenuList.Text;
			string AuthorityList=this.txtAuthorityList.Text;
			bool IsModify=this.chkIsModify.Checked;
			string Remark=this.txtRemark.Text;

			Sanben.Model.SYSAdminRole model=new Sanben.Model.SYSAdminRole();
			model.RoleName=RoleName;
			model.Stop=Stop;
			model.Ordering=Ordering;
			model.MenuList=MenuList;
			model.AuthorityList=AuthorityList;
			model.IsModify=IsModify;
			model.Remark=Remark;

			Sanben.BLL.SYSAdminRole bll=new Sanben.BLL.SYSAdminRole();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
