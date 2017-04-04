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
namespace Sanben.Web.sys_user
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateDate.Text))
			{
				strErr+="CreateDate格式错误！\\n";	
			}
			if(this.txtRoleList.Text.Trim().Length==0)
			{
				strErr+="RoleList不能为空！\\n";	
			}
			if(this.txtCheckAuthority.Text.Trim().Length==0)
			{
				strErr+="CheckAuthority不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtRealName.Text.Trim().Length==0)
			{
				strErr+="RealName不能为空！\\n";	
			}
			if(this.txtCode.Text.Trim().Length==0)
			{
				strErr+="Code不能为空！\\n";	
			}
			if(this.txtGender.Text.Trim().Length==0)
			{
				strErr+="Gender不能为空！\\n";	
			}
			if(this.txtMobile.Text.Trim().Length==0)
			{
				strErr+="Mobile不能为空！\\n";	
			}
			if(this.txtTelephone.Text.Trim().Length==0)
			{
				strErr+="Telephone不能为空！\\n";	
			}
			if(this.txtQQ.Text.Trim().Length==0)
			{
				strErr+="QQ不能为空！\\n";	
			}
			if(this.txtEmaile.Text.Trim().Length==0)
			{
				strErr+="Emaile不能为空！\\n";	
			}
			if(this.txtCompany.Text.Trim().Length==0)
			{
				strErr+="Company不能为空！\\n";	
			}
			if(this.txtCompanyAddress.Text.Trim().Length==0)
			{
				strErr+="CompanyAddress不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtParentID.Text))
			{
				strErr+="ParentID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			DateTime CreateDate=DateTime.Parse(this.txtCreateDate.Text);
			string RoleList=this.txtRoleList.Text;
			string CheckAuthority=this.txtCheckAuthority.Text;
			bool Stop=this.chkStop.Checked;
			bool IsModify=this.chkIsModify.Checked;
			string Remark=this.txtRemark.Text;
			string RealName=this.txtRealName.Text;
			string Code=this.txtCode.Text;
			string Gender=this.txtGender.Text;
			string Mobile=this.txtMobile.Text;
			string Telephone=this.txtTelephone.Text;
			string QQ=this.txtQQ.Text;
			string Emaile=this.txtEmaile.Text;
			string Company=this.txtCompany.Text;
			string CompanyAddress=this.txtCompanyAddress.Text;
			int ParentID=int.Parse(this.txtParentID.Text);

			Sanben.Model.sys_user model=new Sanben.Model.sys_user();
			model.username=username;
			model.password=password;
			model.CreateDate=CreateDate;
			model.RoleList=RoleList;
			model.CheckAuthority=CheckAuthority;
			model.Stop=Stop;
			model.IsModify=IsModify;
			model.Remark=Remark;
			model.RealName=RealName;
			model.Code=Code;
			model.Gender=Gender;
			model.Mobile=Mobile;
			model.Telephone=Telephone;
			model.QQ=QQ;
			model.Emaile=Emaile;
			model.Company=Company;
			model.CompanyAddress=CompanyAddress;
			model.ParentID=ParentID;

			Sanben.BLL.sys_user bll=new Sanben.BLL.sys_user();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
