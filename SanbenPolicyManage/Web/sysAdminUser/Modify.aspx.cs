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
namespace Sanben.Web.sysAdminUser
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
		Sanben.BLL.sysAdminUser bll=new Sanben.BLL.sysAdminUser();
		Sanben.Model.sysAdminUser model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtusername.Text=model.username;
		this.txtpassword.Text=model.password;
		this.txtCreateDate.Text=model.CreateDate.ToString();
		this.txtRoleList.Text=model.RoleList;
		this.txtCheckAuthority.Text=model.CheckAuthority;
		this.chkStop.Checked=model.Stop;
		this.chkIsMoify.Checked=model.IsMoify;
		this.txtRemark.Text=model.Remark;
		this.txtRealName.Text=model.RealName;
		this.txtCode.Text=model.Code;
		this.txtMobile.Text=model.Mobile;
		this.txtTelephone.Text=model.Telephone;
		this.txtQQ.Text=model.QQ;
		this.txtEmaile.Text=model.Emaile;
		this.txtCompany.Text=model.Company;
		this.txtCompanyAddress.Text=model.CompanyAddress;
		this.txtParentID.Text=model.ParentID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			DateTime CreateDate=DateTime.Parse(this.txtCreateDate.Text);
			string RoleList=this.txtRoleList.Text;
			string CheckAuthority=this.txtCheckAuthority.Text;
			bool Stop=this.chkStop.Checked;
			bool IsMoify=this.chkIsMoify.Checked;
			string Remark=this.txtRemark.Text;
			string RealName=this.txtRealName.Text;
			string Code=this.txtCode.Text;
			string Mobile=this.txtMobile.Text;
			string Telephone=this.txtTelephone.Text;
			string QQ=this.txtQQ.Text;
			string Emaile=this.txtEmaile.Text;
			string Company=this.txtCompany.Text;
			string CompanyAddress=this.txtCompanyAddress.Text;
			int ParentID=int.Parse(this.txtParentID.Text);


			Sanben.Model.sysAdminUser model=new Sanben.Model.sysAdminUser();
			model.id=id;
			model.username=username;
			model.password=password;
			model.CreateDate=CreateDate;
			model.RoleList=RoleList;
			model.CheckAuthority=CheckAuthority;
			model.Stop=Stop;
			model.IsMoify=IsMoify;
			model.Remark=Remark;
			model.RealName=RealName;
			model.Code=Code;
			model.Mobile=Mobile;
			model.Telephone=Telephone;
			model.QQ=QQ;
			model.Emaile=Emaile;
			model.Company=Company;
			model.CompanyAddress=CompanyAddress;
			model.ParentID=ParentID;

			Sanben.BLL.sysAdminUser bll=new Sanben.BLL.sysAdminUser();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
