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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtid.Text.Trim().Length==0)
			{
				strErr+="id不能为空！\\n";	
			}
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
			string id=this.txtid.Text;
			string name=this.txtname.Text;
			string sex=this.txtsex.Text;
			string age=this.txtage.Text;

			Sanben.Model.Table_1 model=new Sanben.Model.Table_1();
			model.id=id;
			model.name=name;
			model.sex=sex;
			model.age=age;

			Sanben.BLL.Table_1 bll=new Sanben.BLL.Table_1();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
