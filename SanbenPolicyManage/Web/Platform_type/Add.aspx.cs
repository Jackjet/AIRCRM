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
namespace Sanben.Web.Platform_type
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(this.txtwebsite_name.Text.Trim().Length==0)
			{
				strErr+="website_name不能为空！\\n";	
			}
			if(this.txtplatform_interface.Text.Trim().Length==0)
			{
				strErr+="platform_interface不能为空！\\n";	
			}
			if(this.txtwebsite_platfrom.Text.Trim().Length==0)
			{
				strErr+="website_platfrom不能为空！\\n";	
			}
			if(this.txtplatform_name.Text.Trim().Length==0)
			{
				strErr+="platform_name不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_id.Text))
			{
				strErr+="platform_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			string website_name=this.txtwebsite_name.Text;
			string platform_interface=this.txtplatform_interface.Text;
			string website_platfrom=this.txtwebsite_platfrom.Text;
			string platform_name=this.txtplatform_name.Text;
			int platform_id=int.Parse(this.txtplatform_id.Text);

			Sanben.Model.Platform_type model=new Sanben.Model.Platform_type();
			model.id=id;
			model.website_name=website_name;
			model.platform_interface=platform_interface;
			model.website_platfrom=website_platfrom;
			model.platform_name=platform_name;
			model.platform_id=platform_id;

			Sanben.BLL.Platform_type bll=new Sanben.BLL.Platform_type();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
