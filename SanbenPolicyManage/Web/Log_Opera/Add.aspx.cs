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
namespace Sanben.Web.Log_Opera
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtoperator.Text.Trim().Length==0)
			{
				strErr+="operator不能为空！\\n";	
			}
			if(this.txttime.Text.Trim().Length==0)
			{
				strErr+="time不能为空！\\n";	
			}
			if(this.txtaction.Text.Trim().Length==0)
			{
				strErr+="action不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txto_id.Text))
			{
				strErr+="o_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string operator=this.txtoperator.Text;
			string time=this.txttime.Text;
			string action=this.txtaction.Text;
			int o_id=int.Parse(this.txto_id.Text);

			Sanben.Model.Log_Opera model=new Sanben.Model.Log_Opera();
			model.operator=operator;
			model.time=time;
			model.action=action;
			model.o_id=o_id;

			Sanben.BLL.Log_Opera bll=new Sanben.BLL.Log_Opera();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
