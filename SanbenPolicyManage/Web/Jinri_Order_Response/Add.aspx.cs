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
namespace Sanben.Web.Jinri_Order_Response
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtOrderNo.Text.Trim().Length==0)
			{
				strErr+="OrderNo不能为空！\\n";	
			}
			if(this.txtPNR.Text.Trim().Length==0)
			{
				strErr+="PNR不能为空！\\n";	
			}
			if(this.txtGrowDiscount.Text.Trim().Length==0)
			{
				strErr+="GrowDiscount不能为空！\\n";	
			}
			if(this.txtStayDiscount.Text.Trim().Length==0)
			{
				strErr+="StayDiscount不能为空！\\n";	
			}
			if(this.txtPayMoney.Text.Trim().Length==0)
			{
				strErr+="PayMoney不能为空！\\n";	
			}
			if(this.txtProfit.Text.Trim().Length==0)
			{
				strErr+="Profit不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(this.txtDate.Text.Trim().Length==0)
			{
				strErr+="Date不能为空！\\n";	
			}
			if(this.txtScity.Text.Trim().Length==0)
			{
				strErr+="Scity不能为空！\\n";	
			}
			if(this.txtEcity.Text.Trim().Length==0)
			{
				strErr+="Ecity不能为空！\\n";	
			}
			if(this.txtFlight.Text.Trim().Length==0)
			{
				strErr+="Flight不能为空！\\n";	
			}
			if(this.txtStime.Text.Trim().Length==0)
			{
				strErr+="Stime不能为空！\\n";	
			}
			if(this.txtEtime.Text.Trim().Length==0)
			{
				strErr+="Etime不能为空！\\n";	
			}
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTax.Text))
			{
				strErr+="Tax格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPCount.Text))
			{
				strErr+="PCount格式错误！\\n";	
			}
			if(this.txtPName.Text.Trim().Length==0)
			{
				strErr+="PName不能为空！\\n";	
			}
			if(this.txtPCard.Text.Trim().Length==0)
			{
				strErr+="PCard不能为空！\\n";	
			}
			if(this.txtJouneryInfo.Text.Trim().Length==0)
			{
				strErr+="JouneryInfo不能为空！\\n";	
			}
			if(this.txtIsBuyInsurance.Text.Trim().Length==0)
			{
				strErr+="IsBuyInsurance不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(this.txtticket_no.Text.Trim().Length==0)
			{
				strErr+="ticket_no不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtrefund_type.Text))
			{
				strErr+="refund_type格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtamount.Text))
			{
				strErr+="amount格式错误！\\n";	
			}
			if(this.txtpay_type.Text.Trim().Length==0)
			{
				strErr+="pay_type不能为空！\\n";	
			}
			if(this.txttrade_no.Text.Trim().Length==0)
			{
				strErr+="trade_no不能为空！\\n";	
			}
			if(this.txtpay_time.Text.Trim().Length==0)
			{
				strErr+="pay_time不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrderInfo_id.Text))
			{
				strErr+="OrderInfo_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatformB2B_name_id.Text))
			{
				strErr+="platformB2B_name_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string OrderNo=this.txtOrderNo.Text;
			string PNR=this.txtPNR.Text;
			string GrowDiscount=this.txtGrowDiscount.Text;
			string StayDiscount=this.txtStayDiscount.Text;
			string PayMoney=this.txtPayMoney.Text;
			string Profit=this.txtProfit.Text;
			string Status=this.txtStatus.Text;
			string Date=this.txtDate.Text;
			string Scity=this.txtScity.Text;
			string Ecity=this.txtEcity.Text;
			string Flight=this.txtFlight.Text;
			string Stime=this.txtStime.Text;
			string Etime=this.txtEtime.Text;
			string Cabin=this.txtCabin.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			decimal Tax=decimal.Parse(this.txtTax.Text);
			int PCount=int.Parse(this.txtPCount.Text);
			string PName=this.txtPName.Text;
			string PCard=this.txtPCard.Text;
			string JouneryInfo=this.txtJouneryInfo.Text;
			string IsBuyInsurance=this.txtIsBuyInsurance.Text;
			string remark=this.txtremark.Text;
			string ticket_no=this.txtticket_no.Text;
			int refund_type=int.Parse(this.txtrefund_type.Text);
			decimal amount=decimal.Parse(this.txtamount.Text);
			string pay_type=this.txtpay_type.Text;
			string trade_no=this.txttrade_no.Text;
			string pay_time=this.txtpay_time.Text;
			int OrderInfo_id=int.Parse(this.txtOrderInfo_id.Text);
			int platformB2B_name_id=int.Parse(this.txtplatformB2B_name_id.Text);

			Sanben.Model.Jinri_Order_Response model=new Sanben.Model.Jinri_Order_Response();
			model.OrderNo=OrderNo;
			model.PNR=PNR;
			model.GrowDiscount=GrowDiscount;
			model.StayDiscount=StayDiscount;
			model.PayMoney=PayMoney;
			model.Profit=Profit;
			model.Status=Status;
			model.Date=Date;
			model.Scity=Scity;
			model.Ecity=Ecity;
			model.Flight=Flight;
			model.Stime=Stime;
			model.Etime=Etime;
			model.Cabin=Cabin;
			model.Price=Price;
			model.Tax=Tax;
			model.PCount=PCount;
			model.PName=PName;
			model.PCard=PCard;
			model.JouneryInfo=JouneryInfo;
			model.IsBuyInsurance=IsBuyInsurance;
			model.remark=remark;
			model.ticket_no=ticket_no;
			model.refund_type=refund_type;
			model.amount=amount;
			model.pay_type=pay_type;
			model.trade_no=trade_no;
			model.pay_time=pay_time;
			model.OrderInfo_id=OrderInfo_id;
			model.platformB2B_name_id=platformB2B_name_id;

			Sanben.BLL.Jinri_Order_Response bll=new Sanben.BLL.Jinri_Order_Response();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
