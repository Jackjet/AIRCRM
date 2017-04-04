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
		Sanben.BLL.Platform_type bll=new Sanben.BLL.Platform_type();
		Sanben.Model.Platform_type model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtwebsite_name.Text=model.website_name;
		this.txtplatform_interface.Text=model.platform_interface;
		this.txtwebsite_platfrom.Text=model.website_platfrom;
		this.txtplatform_name.Text=model.platform_name;
		this.txtplatform_id.Text=model.platform_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int id=int.Parse(this.lblid.Text);
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
