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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			string realm_name=this.txtrealm_name.Text;
			string bind_ip_address=this.txtbind_ip_address.Text;
			int sys_user_id=int.Parse(this.txtsys_user_id.Text);

			Sanben.Model.platform_config model=new Sanben.Model.platform_config();
			model.platform_type_id=platform_type_id;
			model.username=username;
			model.password=password;
			model.realm_name=realm_name;
			model.bind_ip_address=bind_ip_address;
			model.sys_user_id=sys_user_id;

			Sanben.BLL.platform_config bll=new Sanben.BLL.platform_config();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
