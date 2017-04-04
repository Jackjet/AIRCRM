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
namespace Sanben.Web.Table_1
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id= Request.Params["id"];
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(string id)
	{
		Sanben.BLL.Table_1 bll=new Sanben.BLL.Table_1();
		Sanben.Model.Table_1 model=bll.GetModel(id);
		this.lblid.Text=model.id;
		this.txtname.Text=model.name;
		this.txtsex.Text=model.sex;
		this.txtage.Text=model.age;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtsex.Text.Trim().Length==0)
			{
				strErr+="sex不能为空！\\n";	
			}
			if(this.txtage.Text.Trim().Length==0)
			{
				strErr+="age不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string id=this.lblid.Text;
			string name=this.txtname.Text;
			string sex=this.txtsex.Text;
			string age=this.txtage.Text;


			Sanben.Model.Table_1 model=new Sanben.Model.Table_1();
			model.id=id;
			model.name=name;
			model.sex=sex;
			model.age=age;

			Sanben.BLL.Table_1 bll=new Sanben.BLL.Table_1();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
