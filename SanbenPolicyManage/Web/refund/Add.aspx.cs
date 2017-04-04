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
namespace Sanben.Web.refund
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtrefund_time.Text.Trim().Length==0)
			{
				strErr+="refund_time不能为空！\\n";	
			}
			if(this.txtrefund_price.Text.Trim().Length==0)
			{
				strErr+="refund_price不能为空！\\n";	
			}
			if(this.txtrefund_no.Text.Trim().Length==0)
			{
				strErr+="refund_no不能为空！\\n";	
			}
			if(this.txttype.Text.Trim().Length==0)
			{
				strErr+="type不能为空！\\n";	
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
			string refund_time=this.txtrefund_time.Text;
			string refund_price=this.txtrefund_price.Text;
			string refund_no=this.txtrefund_no.Text;
			string type=this.txttype.Text;
			int o_id=int.Parse(this.txto_id.Text);

			Sanben.Model.refund model=new Sanben.Model.refund();
			model.refund_time=refund_time;
			model.refund_price=refund_price;
			model.refund_no=refund_no;
			model.type=type;
			model.o_id=o_id;

			Sanben.BLL.refund bll=new Sanben.BLL.refund();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
