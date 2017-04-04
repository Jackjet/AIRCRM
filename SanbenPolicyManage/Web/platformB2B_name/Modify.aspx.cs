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
namespace Sanben.Web.platformB2B_name
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
		Sanben.BLL.platformB2B_name bll=new Sanben.BLL.platformB2B_name();
		Sanben.Model.platformB2B_name model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtplatform_name.Text=model.platform_name;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtplatform_name.Text.Trim().Length==0)
			{
				strErr+="platform_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string platform_name=this.txtplatform_name.Text;


			Sanben.Model.platformB2B_name model=new Sanben.Model.platformB2B_name();
			model.id=id;
			model.platform_name=platform_name;

			Sanben.BLL.platformB2B_name bll=new Sanben.BLL.platformB2B_name();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
