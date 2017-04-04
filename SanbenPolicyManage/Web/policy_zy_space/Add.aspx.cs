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
namespace Sanben.Web.policy_zy_space
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnavigation_company.Text.Trim().Length==0)
			{
				strErr+="navigation_company不能为空！\\n";	
			}
			if(this.txtair_line.Text.Trim().Length==0)
			{
				strErr+="air_line不能为空！\\n";	
			}
			if(this.txtapplication_space.Text.Trim().Length==0)
			{
				strErr+="application_space不能为空！\\n";	
			}
			if(this.txtdescription.Text.Trim().Length==0)
			{
				strErr+="description不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_id.Text))
			{
				strErr+="platform_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string application_space=this.txtapplication_space.Text;
			string description=this.txtdescription.Text;
			int platform_id=int.Parse(this.txtplatform_id.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);

			Sanben.Model.policy_zy_space model=new Sanben.Model.policy_zy_space();
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.application_space=application_space;
			model.description=description;
			model.platform_id=platform_id;
			model.sys_id=sys_id;

			Sanben.BLL.policy_zy_space bll=new Sanben.BLL.policy_zy_space();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
