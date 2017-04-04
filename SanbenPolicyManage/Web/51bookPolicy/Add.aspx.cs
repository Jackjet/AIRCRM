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
namespace Sanben.Web.51bookPolicy
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtadultAirportTax.Text.Trim().Length==0)
			{
				strErr+="adultAirportTax不能为空！\\n";	
			}
			if(this.txtadultFuelTax.Text.Trim().Length==0)
			{
				strErr+="adultFuelTax不能为空！\\n";	
			}
			if(this.txtchildAirportTax.Text.Trim().Length==0)
			{
				strErr+="childAirportTax不能为空！\\n";	
			}
			if(this.txtchildFuelTax.Text.Trim().Length==0)
			{
				strErr+="childFuelTax不能为空！\\n";	
			}
			if(this.txtflightNo.Text.Trim().Length==0)
			{
				strErr+="flightNo不能为空！\\n";	
			}
			if(this.txtadultSettlePrice.Text.Trim().Length==0)
			{
				strErr+="adultSettlePrice不能为空！\\n";	
			}
			if(this.txtairlineCode.Text.Trim().Length==0)
			{
				strErr+="airlineCode不能为空！\\n";	
			}
			if(this.txtcomment.Text.Trim().Length==0)
			{
				strErr+="comment不能为空！\\n";	
			}
			if(this.txtcommisionPoint.Text.Trim().Length==0)
			{
				strErr+="commisionPoint不能为空！\\n";	
			}
			if(this.txtneedSwitchPNR.Text.Trim().Length==0)
			{
				strErr+="needSwitchPNR不能为空！\\n";	
			}
			if(this.txtpolicyId.Text.Trim().Length==0)
			{
				strErr+="policyId不能为空！\\n";	
			}
			if(this.txtpolicyType.Text.Trim().Length==0)
			{
				strErr+="policyType不能为空！\\n";	
			}
			if(this.txtproductType.Text.Trim().Length==0)
			{
				strErr+="productType不能为空！\\n";	
			}
			if(this.txtrouteType.Text.Trim().Length==0)
			{
				strErr+="routeType不能为空！\\n";	
			}
			if(this.txtseatType.Text.Trim().Length==0)
			{
				strErr+="seatType不能为空！\\n";	
			}
			if(this.txtsupplyOfficeNo.Text.Trim().Length==0)
			{
				strErr+="supplyOfficeNo不能为空！\\n";	
			}
			if(this.txtticketSpeed.Text.Trim().Length==0)
			{
				strErr+="ticketSpeed不能为空！\\n";	
			}
			if(this.txtvtWorkTime.Text.Trim().Length==0)
			{
				strErr+="vtWorkTime不能为空！\\n";	
			}
			if(this.txtworkTime.Text.Trim().Length==0)
			{
				strErr+="workTime不能为空！\\n";	
			}
			if(this.txtseatCode.Text.Trim().Length==0)
			{
				strErr+="seatCode不能为空！\\n";	
			}
			if(this.txtticketPrice.Text.Trim().Length==0)
			{
				strErr+="ticketPrice不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddtime.Text))
			{
				strErr+="Addtime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string adultAirportTax=this.txtadultAirportTax.Text;
			string adultFuelTax=this.txtadultFuelTax.Text;
			string childAirportTax=this.txtchildAirportTax.Text;
			string childFuelTax=this.txtchildFuelTax.Text;
			string flightNo=this.txtflightNo.Text;
			string adultSettlePrice=this.txtadultSettlePrice.Text;
			string airlineCode=this.txtairlineCode.Text;
			string comment=this.txtcomment.Text;
			string commisionPoint=this.txtcommisionPoint.Text;
			string needSwitchPNR=this.txtneedSwitchPNR.Text;
			string policyId=this.txtpolicyId.Text;
			string policyType=this.txtpolicyType.Text;
			string productType=this.txtproductType.Text;
			string routeType=this.txtrouteType.Text;
			string seatType=this.txtseatType.Text;
			string supplyOfficeNo=this.txtsupplyOfficeNo.Text;
			string ticketSpeed=this.txtticketSpeed.Text;
			string vtWorkTime=this.txtvtWorkTime.Text;
			string workTime=this.txtworkTime.Text;
			string seatCode=this.txtseatCode.Text;
			string ticketPrice=this.txtticketPrice.Text;
			DateTime Addtime=DateTime.Parse(this.txtAddtime.Text);
			bool IsUpload=this.chkIsUpload.Checked;
			bool IsUpdate=this.chkIsUpdate.Checked;

			Sanben.Model.51bookPolicy model=new Sanben.Model.51bookPolicy();
			model.adultAirportTax=adultAirportTax;
			model.adultFuelTax=adultFuelTax;
			model.childAirportTax=childAirportTax;
			model.childFuelTax=childFuelTax;
			model.flightNo=flightNo;
			model.adultSettlePrice=adultSettlePrice;
			model.airlineCode=airlineCode;
			model.comment=comment;
			model.commisionPoint=commisionPoint;
			model.needSwitchPNR=needSwitchPNR;
			model.policyId=policyId;
			model.policyType=policyType;
			model.productType=productType;
			model.routeType=routeType;
			model.seatType=seatType;
			model.supplyOfficeNo=supplyOfficeNo;
			model.ticketSpeed=ticketSpeed;
			model.vtWorkTime=vtWorkTime;
			model.workTime=workTime;
			model.seatCode=seatCode;
			model.ticketPrice=ticketPrice;
			model.Addtime=Addtime;
			model.IsUpload=IsUpload;
			model.IsUpdate=IsUpdate;

			Sanben.BLL.51bookPolicy bll=new Sanben.BLL.51bookPolicy();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
