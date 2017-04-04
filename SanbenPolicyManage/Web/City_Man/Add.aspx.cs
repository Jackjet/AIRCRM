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
namespace Sanben.Web.City_Man
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFrom_Code.Text.Trim().Length==0)
			{
				strErr+="From_Code不能为空！\\n";	
			}
			if(this.txtTo_Code.Text.Trim().Length==0)
			{
				strErr+="To_Code不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDate.Text))
			{
				strErr+="Date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string From_Code=this.txtFrom_Code.Text;
			string To_Code=this.txtTo_Code.Text;
			int Status=int.Parse(this.txtStatus.Text);
			DateTime Date=DateTime.Parse(this.txtDate.Text);

			Sanben.Model.City_Man model=new Sanben.Model.City_Man();
			model.From_Code=From_Code;
			model.To_Code=To_Code;
			model.Status=Status;
			model.Date=Date;

			Sanben.BLL.City_Man bll=new Sanben.BLL.City_Man();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
