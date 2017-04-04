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
namespace Sanben.Web.platform_config
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
		Sanben.BLL.platform_config bll=new Sanben.BLL.platform_config();
		Sanben.Model.platform_config model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtplatform_type_id.Text=model.platform_type_id.ToString();
		this.txtusername.Text=model.username;
		this.txtpassword.Text=model.password;
		this.txtrealm_name.Text=model.realm_name;
		this.txtbind_ip_address.Text=model.bind_ip_address;
		this.txtsys_user_id.Text=model.sys_user_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtplatform_type_id.Text))
			{
				strErr+="platform_type_id格式错误！\\n";	
			}
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(this.txtrealm_name.Text.Trim().Length==0)
			{
				strErr+="realm_name不能为空！\\n";	
			}
			if(this.txtbind_ip_address.Text.Trim().Length==0)
			{
				strErr+="bind_ip_address不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_user_id.Text))
			{
				strErr+="sys_user_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			string realm_name=this.txtrealm_name.Text;
			string bind_ip_address=this.txtbind_ip_address.Text;
			int sys_user_id=int.Parse(this.txtsys_user_id.Text);


			Sanben.Model.platform_config model=new Sanben.Model.platform_config();
			model.id=id;
			model.platform_type_id=platform_type_id;
			model.username=username;
			model.password=password;
			model.realm_name=realm_name;
			model.bind_ip_address=bind_ip_address;
			model.sys_user_id=sys_user_id;

			Sanben.BLL.platform_config bll=new Sanben.BLL.platform_config();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
