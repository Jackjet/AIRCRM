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
namespace Sanben.Web.OrderInfo2
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
			if(this.txtorderNo.Text.Trim().Length==0)
			{
				strErr+="orderNo不能为空！\\n";	
			}
			if(this.txtallPrice.Text.Trim().Length==0)
			{
				strErr+="allPrice不能为空！\\n";	
			}
			if(this.txtnoPay.Text.Trim().Length==0)
			{
				strErr+="noPay不能为空！\\n";	
			}
			if(this.txtchildPrintPrice.Text.Trim().Length==0)
			{
				strErr+="childPrintPrice不能为空！\\n";	
			}
			if(this.txtchildFaceValue.Text.Trim().Length==0)
			{
				strErr+="childFaceValue不能为空！\\n";	
			}
			if(this.txtsource.Text.Trim().Length==0)
			{
				strErr+="source不能为空！\\n";	
			}
			if(this.txtpolicySource.Text.Trim().Length==0)
			{
				strErr+="policySource不能为空！\\n";	
			}
			if(this.txtticketMode.Text.Trim().Length==0)
			{
				strErr+="ticketMode不能为空！\\n";	
			}
			if(this.txtpolicyFriendly.Text.Trim().Length==0)
			{
				strErr+="policyFriendly不能为空！\\n";	
			}
			if(this.txtpayChannel.Text.Trim().Length==0)
			{
				strErr+="payChannel不能为空！\\n";	
			}
			if(this.txtpayStatus.Text.Trim().Length==0)
			{
				strErr+="payStatus不能为空！\\n";	
			}
			if(this.txtinsuranceUnitPrice.Text.Trim().Length==0)
			{
				strErr+="insuranceUnitPrice不能为空！\\n";	
			}
			if(this.txtbacknote.Text.Trim().Length==0)
			{
				strErr+="backnote不能为空！\\n";	
			}
			if(this.txtinsuranceCuttingPrice.Text.Trim().Length==0)
			{
				strErr+="insuranceCuttingPrice不能为空！\\n";	
			}
			if(this.txtcabinnote.Text.Trim().Length==0)
			{
				strErr+="cabinnote不能为空！\\n";	
			}
			if(this.txtxcdPrice.Text.Trim().Length==0)
			{
				strErr+="xcdPrice不能为空！\\n";	
			}
			if(this.txtxcd.Text.Trim().Length==0)
			{
				strErr+="xcd不能为空！\\n";	
			}
			if(this.txtsjr.Text.Trim().Length==0)
			{
				strErr+="sjr不能为空！\\n";	
			}
			if(this.txtcontactTel.Text.Trim().Length==0)
			{
				strErr+="contactTel不能为空！\\n";	
			}
			if(this.txtaddress.Text.Trim().Length==0)
			{
				strErr+="address不能为空！\\n";	
			}
			if(this.txtcompany.Text.Trim().Length==0)
			{
				strErr+="company不能为空！\\n";	
			}
			if(this.txtexpType.Text.Trim().Length==0)
			{
				strErr+="expType不能为空！\\n";	
			}
			if(this.txtordernumber.Text.Trim().Length==0)
			{
				strErr+="ordernumber不能为空！\\n";	
			}
			if(this.txtsendtime.Text.Trim().Length==0)
			{
				strErr+="sendtime不能为空！\\n";	
			}
			if(this.txtviewPrice.Text.Trim().Length==0)
			{
				strErr+="viewPrice不能为空！\\n";	
			}
			if(this.txtprice.Text.Trim().Length==0)
			{
				strErr+="price不能为空！\\n";	
			}
			if(this.txtpnr.Text.Trim().Length==0)
			{
				strErr+="pnr不能为空！\\n";	
			}
			if(this.txtcpnr.Text.Trim().Length==0)
			{
				strErr+="cpnr不能为空！\\n";	
			}
			if(this.txtpnrText.Text.Trim().Length==0)
			{
				strErr+="pnrText不能为空！\\n";	
			}
			if(this.txtchildPnrText.Text.Trim().Length==0)
			{
				strErr+="childPnrText不能为空！\\n";	
			}
			if(this.txtpataText.Text.Trim().Length==0)
			{
				strErr+="pataText不能为空！\\n";	
			}
			if(this.txtchildPataText.Text.Trim().Length==0)
			{
				strErr+="childPataText不能为空！\\n";	
			}
			if(this.txtconstructionFee.Text.Trim().Length==0)
			{
				strErr+="constructionFee不能为空！\\n";	
			}
			if(this.txtfuelTax.Text.Trim().Length==0)
			{
				strErr+="fuelTax不能为空！\\n";	
			}
			if(this.txtchildFuelTax.Text.Trim().Length==0)
			{
				strErr+="childFuelTax不能为空！\\n";	
			}
			if(this.txtpolicyType.Text.Trim().Length==0)
			{
				strErr+="policyType不能为空！\\n";	
			}
			if(this.txtstatus.Text.Trim().Length==0)
			{
				strErr+="status不能为空！\\n";	
			}
			if(this.txtcontact.Text.Trim().Length==0)
			{
				strErr+="contact不能为空！\\n";	
			}
			if(this.txtcontactMob.Text.Trim().Length==0)
			{
				strErr+="contactMob不能为空！\\n";	
			}
			if(this.txtcontactEmail.Text.Trim().Length==0)
			{
				strErr+="contactEmail不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreateTime.Text))
			{
				strErr+="createTime格式错误！\\n";	
			}
			if(this.txtneedPS.Text.Trim().Length==0)
			{
				strErr+="needPS不能为空！\\n";	
			}
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtorderFrom.Text.Trim().Length==0)
			{
				strErr+="orderFrom不能为空！\\n";	
			}
			if(this.txtlockStatus.Text.Trim().Length==0)
			{
				strErr+="lockStatus不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtupdateTime.Text))
			{
				strErr+="updateTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserid.Text))
			{
				strErr+="userid格式错误！\\n";	
			}
			if(this.txtorderDesc.Text.Trim().Length==0)
			{
				strErr+="orderDesc不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			string orderNo=this.txtorderNo.Text;
			string allPrice=this.txtallPrice.Text;
			string noPay=this.txtnoPay.Text;
			string childPrintPrice=this.txtchildPrintPrice.Text;
			string childFaceValue=this.txtchildFaceValue.Text;
			string source=this.txtsource.Text;
			string policySource=this.txtpolicySource.Text;
			string ticketMode=this.txtticketMode.Text;
			string policyFriendly=this.txtpolicyFriendly.Text;
			string payChannel=this.txtpayChannel.Text;
			string payStatus=this.txtpayStatus.Text;
			string insuranceUnitPrice=this.txtinsuranceUnitPrice.Text;
			string backnote=this.txtbacknote.Text;
			string insuranceCuttingPrice=this.txtinsuranceCuttingPrice.Text;
			string cabinnote=this.txtcabinnote.Text;
			string xcdPrice=this.txtxcdPrice.Text;
			string xcd=this.txtxcd.Text;
			string sjr=this.txtsjr.Text;
			string contactTel=this.txtcontactTel.Text;
			string address=this.txtaddress.Text;
			string company=this.txtcompany.Text;
			string expType=this.txtexpType.Text;
			string ordernumber=this.txtordernumber.Text;
			string sendtime=this.txtsendtime.Text;
			string viewPrice=this.txtviewPrice.Text;
			string price=this.txtprice.Text;
			string pnr=this.txtpnr.Text;
			string cpnr=this.txtcpnr.Text;
			string pnrText=this.txtpnrText.Text;
			string childPnrText=this.txtchildPnrText.Text;
			string pataText=this.txtpataText.Text;
			string childPataText=this.txtchildPataText.Text;
			string constructionFee=this.txtconstructionFee.Text;
			string fuelTax=this.txtfuelTax.Text;
			string childFuelTax=this.txtchildFuelTax.Text;
			string policyType=this.txtpolicyType.Text;
			string status=this.txtstatus.Text;
			string contact=this.txtcontact.Text;
			string contactMob=this.txtcontactMob.Text;
			string contactEmail=this.txtcontactEmail.Text;
			DateTime createTime=DateTime.Parse(this.txtcreateTime.Text);
			string needPS=this.txtneedPS.Text;
			string username=this.txtusername.Text;
			string orderFrom=this.txtorderFrom.Text;
			string lockStatus=this.txtlockStatus.Text;
			DateTime updateTime=DateTime.Parse(this.txtupdateTime.Text);
			int userid=int.Parse(this.txtuserid.Text);
			string orderDesc=this.txtorderDesc.Text;

			Sanben.Model.OrderInfo2 model=new Sanben.Model.OrderInfo2();
			model.id=id;
			model.orderNo=orderNo;
			model.allPrice=allPrice;
			model.noPay=noPay;
			model.childPrintPrice=childPrintPrice;
			model.childFaceValue=childFaceValue;
			model.source=source;
			model.policySource=policySource;
			model.ticketMode=ticketMode;
			model.policyFriendly=policyFriendly;
			model.payChannel=payChannel;
			model.payStatus=payStatus;
			model.insuranceUnitPrice=insuranceUnitPrice;
			model.backnote=backnote;
			model.insuranceCuttingPrice=insuranceCuttingPrice;
			model.cabinnote=cabinnote;
			model.xcdPrice=xcdPrice;
			model.xcd=xcd;
			model.sjr=sjr;
			model.contactTel=contactTel;
			model.address=address;
			model.company=company;
			model.expType=expType;
			model.ordernumber=ordernumber;
			model.sendtime=sendtime;
			model.viewPrice=viewPrice;
			model.price=price;
			model.pnr=pnr;
			model.cpnr=cpnr;
			model.pnrText=pnrText;
			model.childPnrText=childPnrText;
			model.pataText=pataText;
			model.childPataText=childPataText;
			model.constructionFee=constructionFee;
			model.fuelTax=fuelTax;
			model.childFuelTax=childFuelTax;
			model.policyType=policyType;
			model.status=status;
			model.contact=contact;
			model.contactMob=contactMob;
			model.contactEmail=contactEmail;
			model.createTime=createTime;
			model.needPS=needPS;
			model.username=username;
			model.orderFrom=orderFrom;
			model.lockStatus=lockStatus;
			model.updateTime=updateTime;
			model.userid=userid;
			model.orderDesc=orderDesc;

			Sanben.BLL.OrderInfo2 bll=new Sanben.BLL.OrderInfo2();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
