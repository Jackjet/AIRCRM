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
namespace Sanben.Web.JinRiOrderByPnr
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtorderNo.Text.Trim().Length==0)
			{
				strErr+="orderNo不能为空！\\n";	
			}
			if(this.txtpnr.Text.Trim().Length==0)
			{
				strErr+="pnr不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtgrowDiscount.Text))
			{
				strErr+="growDiscount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtstayDiscount.Text))
			{
				strErr+="stayDiscount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtpayMoney.Text))
			{
				strErr+="payMoney格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtprofit.Text))
			{
				strErr+="profit格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstatus.Text))
			{
				strErr+="status格式错误！\\n";	
			}
			if(this.txtdate.Text.Trim().Length==0)
			{
				strErr+="date不能为空！\\n";	
			}
			if(this.txtscity.Text.Trim().Length==0)
			{
				strErr+="scity不能为空！\\n";	
			}
			if(this.txtecity.Text.Trim().Length==0)
			{
				strErr+="ecity不能为空！\\n";	
			}
			if(this.txtflight.Text.Trim().Length==0)
			{
				strErr+="flight不能为空！\\n";	
			}
			if(this.txtstime.Text.Trim().Length==0)
			{
				strErr+="stime不能为空！\\n";	
			}
			if(this.txtetime.Text.Trim().Length==0)
			{
				strErr+="etime不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtprice.Text))
			{
				strErr+="price格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttax.Text))
			{
				strErr+="tax格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpcount.Text))
			{
				strErr+="pcount格式错误！\\n";	
			}
			if(this.txtpName.Text.Trim().Length==0)
			{
				strErr+="pName不能为空！\\n";	
			}
			if(this.txtpCard.Text.Trim().Length==0)
			{
				strErr+="pCard不能为空！\\n";	
			}
			if(this.txtjouneryInfo.Text.Trim().Length==0)
			{
				strErr+="jouneryInfo不能为空！\\n";	
			}
			if(this.txtisBuyInsurance.Text.Trim().Length==0)
			{
				strErr+="isBuyInsurance不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtorderinfo_id.Text))
			{
				strErr+="orderinfo_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string orderNo=this.txtorderNo.Text;
			string pnr=this.txtpnr.Text;
			decimal growDiscount=decimal.Parse(this.txtgrowDiscount.Text);
			decimal stayDiscount=decimal.Parse(this.txtstayDiscount.Text);
			decimal payMoney=decimal.Parse(this.txtpayMoney.Text);
			decimal profit=decimal.Parse(this.txtprofit.Text);
			int status=int.Parse(this.txtstatus.Text);
			string date=this.txtdate.Text;
			string scity=this.txtscity.Text;
			string ecity=this.txtecity.Text;
			string flight=this.txtflight.Text;
			string stime=this.txtstime.Text;
			string etime=this.txtetime.Text;
			string cabin=this.txtcabin.Text;
			decimal price=decimal.Parse(this.txtprice.Text);
			decimal tax=decimal.Parse(this.txttax.Text);
			int pcount=int.Parse(this.txtpcount.Text);
			string pName=this.txtpName.Text;
			string pCard=this.txtpCard.Text;
			string jouneryInfo=this.txtjouneryInfo.Text;
			string isBuyInsurance=this.txtisBuyInsurance.Text;
			int orderinfo_id=int.Parse(this.txtorderinfo_id.Text);

			Sanben.Model.JinRiOrderByPnr model=new Sanben.Model.JinRiOrderByPnr();
			model.orderNo=orderNo;
			model.pnr=pnr;
			model.growDiscount=growDiscount;
			model.stayDiscount=stayDiscount;
			model.payMoney=payMoney;
			model.profit=profit;
			model.status=status;
			model.date=date;
			model.scity=scity;
			model.ecity=ecity;
			model.flight=flight;
			model.stime=stime;
			model.etime=etime;
			model.cabin=cabin;
			model.price=price;
			model.tax=tax;
			model.pcount=pcount;
			model.pName=pName;
			model.pCard=pCard;
			model.jouneryInfo=jouneryInfo;
			model.isBuyInsurance=isBuyInsurance;
			model.orderinfo_id=orderinfo_id;

			Sanben.BLL.JinRiOrderByPnr bll=new Sanben.BLL.JinRiOrderByPnr();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
