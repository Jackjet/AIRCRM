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
namespace Sanben.Web.ROUTE
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
			if(this.txtSCITY.Text.Trim().Length==0)
			{
				strErr+="出发城市三字代码不能为空！\\n";	
			}
			if(this.txtECITY.Text.Trim().Length==0)
			{
				strErr+="到达城市三字代码不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			string SCITY=this.txtSCITY.Text;
			string ECITY=this.txtECITY.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);

			Sanben.Model.ROUTE model=new Sanben.Model.ROUTE();
			model.id=id;
			model.SCITY=SCITY;
			model.ECITY=ECITY;
			model.AddTime=AddTime;

			Sanben.BLL.ROUTE bll=new Sanben.BLL.ROUTE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
