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
namespace Sanben.Web.Policy_filter_wangfan
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
			if(this.txtqucheng_space.Text.Trim().Length==0)
			{
				strErr+="qucheng_space不能为空！\\n";	
			}
			if(this.txthuicheng_space.Text.Trim().Length==0)
			{
				strErr+="huicheng_space不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_type_id.Text))
			{
				strErr+="platform_type_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string qucheng_space=this.txtqucheng_space.Text;
			string huicheng_space=this.txthuicheng_space.Text;
			bool limit_type=this.chklimit_type.Checked;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);

			Sanben.Model.Policy_filter_wangfan model=new Sanben.Model.Policy_filter_wangfan();
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.qucheng_space=qucheng_space;
			model.huicheng_space=huicheng_space;
			model.limit_type=limit_type;
			model.sys_id=sys_id;
			model.platform_type_id=platform_type_id;

			Sanben.BLL.Policy_filter_wangfan bll=new Sanben.BLL.Policy_filter_wangfan();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
