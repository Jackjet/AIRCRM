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
namespace Sanben.Web.PurchaseOrderInfo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtprice.Text.Trim().Length==0)
			{
				strErr+="price不能为空！\\n";	
			}
			if(this.txtissue_ticket_type.Text.Trim().Length==0)
			{
				strErr+="issue_ticket_type不能为空！\\n";	
			}
			if(this.txtissue_ticket_platform_code.Text.Trim().Length==0)
			{
				strErr+="issue_ticket_platform_code不能为空！\\n";	
			}
			if(this.txtsource_transaction_id.Text.Trim().Length==0)
			{
				strErr+="source_transaction_id不能为空！\\n";	
			}
			if(this.txtsource_order_no.Text.Trim().Length==0)
			{
				strErr+="source_order_no不能为空！\\n";	
			}
			if(this.txttpp_type.Text.Trim().Length==0)
			{
				strErr+="tpp_type不能为空！\\n";	
			}
			if(this.txtstatus.Text.Trim().Length==0)
			{
				strErr+="status不能为空！\\n";	
			}
			if(this.txtpay_commercial_no.Text.Trim().Length==0)
			{
				strErr+="pay_commercial_no不能为空！\\n";	
			}
			if(this.txtoffline_pay_type.Text.Trim().Length==0)
			{
				strErr+="offline_pay_type不能为空！\\n";	
			}
			if(this.txtoffline_pay_cardno.Text.Trim().Length==0)
			{
				strErr+="offline_pay_cardno不能为空！\\n";	
			}
			if(this.txtplatform_mem_id.Text.Trim().Length==0)
			{
				strErr+="platform_mem_id不能为空！\\n";	
			}
			if(this.txtoperator.Text.Trim().Length==0)
			{
				strErr+="operator不能为空！\\n";	
			}
			if(this.txtrefund_price.Text.Trim().Length==0)
			{
				strErr+="refund_price不能为空！\\n";	
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
			string price=this.txtprice.Text;
			string issue_ticket_type=this.txtissue_ticket_type.Text;
			string issue_ticket_platform_code=this.txtissue_ticket_platform_code.Text;
			string source_transaction_id=this.txtsource_transaction_id.Text;
			string source_order_no=this.txtsource_order_no.Text;
			string tpp_type=this.txttpp_type.Text;
			string status=this.txtstatus.Text;
			string pay_commercial_no=this.txtpay_commercial_no.Text;
			string offline_pay_type=this.txtoffline_pay_type.Text;
			string offline_pay_cardno=this.txtoffline_pay_cardno.Text;
			string platform_mem_id=this.txtplatform_mem_id.Text;
			string operator=this.txtoperator.Text;
			string refund_price=this.txtrefund_price.Text;
			int o_id=int.Parse(this.txto_id.Text);

			Sanben.Model.PurchaseOrderInfo model=new Sanben.Model.PurchaseOrderInfo();
			model.price=price;
			model.issue_ticket_type=issue_ticket_type;
			model.issue_ticket_platform_code=issue_ticket_platform_code;
			model.source_transaction_id=source_transaction_id;
			model.source_order_no=source_order_no;
			model.tpp_type=tpp_type;
			model.status=status;
			model.pay_commercial_no=pay_commercial_no;
			model.offline_pay_type=offline_pay_type;
			model.offline_pay_cardno=offline_pay_cardno;
			model.platform_mem_id=platform_mem_id;
			model.operator=operator;
			model.refund_price=refund_price;
			model.o_id=o_id;

			Sanben.BLL.PurchaseOrderInfo bll=new Sanben.BLL.PurchaseOrderInfo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
