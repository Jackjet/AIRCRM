﻿using System;
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
namespace Sanben.Web.GetRateList
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Sanben.BLL.GetRateList bll=new Sanben.BLL.GetRateList();
		Sanben.Model.GetRateList model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtPolicyId.Text=model.PolicyId;
		this.txtRateId.Text=model.RateId;
		this.txtScityE.Text=model.ScityE;
		this.txtEcityE.Text=model.EcityE;
		this.txtAirComE.Text=model.AirComE;
		this.txtNoAirComE.Text=model.NoAirComE;
		this.txtPolicyType.Text=model.PolicyType;
		this.txtCabin.Text=model.Cabin;
		this.txtVoyageType.Text=model.VoyageType;
		this.txtUserType.Text=model.UserType;
		this.txtRateType.Text=model.RateType;
		this.txtDiscounts.Text=model.Discounts.ToString();
		this.txtSdate.Text=model.Sdate;
		this.txtEdate.Text=model.Edate;
		this.txtWorkTimBegin.Text=model.WorkTimBegin;
		this.txtWorkTImeEnd.Text=model.WorkTImeEnd;
		this.txtRewards.Text=model.Rewards;
		this.txtRemark.Text=model.Remark;
		this.txtET.Text=model.ET;
		this.txtWP.Text=model.WP;
		this.txtSP.Text=model.SP;
		this.txtXF.Text=model.XF;
		this.txtPromotionDiscount.Text=model.PromotionDiscount;
		this.txtNewRateNo.Text=model.NewRateNo;
		this.txtOfficeNum.Text=model.OfficeNum;
		this.txtRefundTimeBegin.Text=model.RefundTimeBegin;
		this.txtRefundTimeEnd.Text=model.RefundTimeEnd;
		this.txtLastModifyTime.Text=model.LastModifyTime;
		this.txtLimitModels.Text=model.LimitModels;
		this.txtRefundRulesWay.Text=model.RefundRulesWay;
		this.txtTPRemark.Text=model.TPRemark;
		this.txtChangeMsg.Text=model.ChangeMsg;
		this.txtInvalidMsg.Text=model.InvalidMsg;
		this.txtRiseCabin.Text=model.RiseCabin;
		this.txtForeignMsg.Text=model.ForeignMsg;
		this.txtOutTicketPercent.Text=model.OutTicketPercent;
		this.txtInvoiceMsg.Text=model.InvoiceMsg;
		this.txtPrintInvoice.Text=model.PrintInvoice;
		this.txtSwitchPNR.Text=model.SwitchPNR;
		this.txtChange.Text=model.Change;
		this.txtcomReturn.Text=model.comReturn;
		this.txtPlatForm.Text=model.PlatForm;
		this.txtAddTime.Text=model.AddTime.ToString();
		this.txtCompany.Text=model.Company;
		this.txtAirLine.Text=model.AirLine;
		this.chkIsUpload.Checked=model.IsUpload;
		this.chkIsUpdate.Checked=model.IsUpdate;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPolicyId.Text.Trim().Length==0)
			{
				strErr+="PolicyId不能为空！\\n";	
			}
			if(this.txtRateId.Text.Trim().Length==0)
			{
				strErr+="RateId不能为空！\\n";	
			}
			if(this.txtScityE.Text.Trim().Length==0)
			{
				strErr+="ScityE不能为空！\\n";	
			}
			if(this.txtEcityE.Text.Trim().Length==0)
			{
				strErr+="EcityE不能为空！\\n";	
			}
			if(this.txtAirComE.Text.Trim().Length==0)
			{
				strErr+="AirComE不能为空！\\n";	
			}
			if(this.txtNoAirComE.Text.Trim().Length==0)
			{
				strErr+="NoAirComE不能为空！\\n";	
			}
			if(this.txtPolicyType.Text.Trim().Length==0)
			{
				strErr+="PolicyType不能为空！\\n";	
			}
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(this.txtVoyageType.Text.Trim().Length==0)
			{
				strErr+="VoyageType不能为空！\\n";	
			}
			if(this.txtUserType.Text.Trim().Length==0)
			{
				strErr+="UserType不能为空！\\n";	
			}
			if(this.txtRateType.Text.Trim().Length==0)
			{
				strErr+="RateType不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDiscounts.Text))
			{
				strErr+="Discounts格式错误！\\n";	
			}
			if(this.txtSdate.Text.Trim().Length==0)
			{
				strErr+="Sdate不能为空！\\n";	
			}
			if(this.txtEdate.Text.Trim().Length==0)
			{
				strErr+="Edate不能为空！\\n";	
			}
			if(this.txtWorkTimBegin.Text.Trim().Length==0)
			{
				strErr+="WorkTimBegin不能为空！\\n";	
			}
			if(this.txtWorkTImeEnd.Text.Trim().Length==0)
			{
				strErr+="WorkTImeEnd不能为空！\\n";	
			}
			if(this.txtRewards.Text.Trim().Length==0)
			{
				strErr+="Rewards不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtET.Text.Trim().Length==0)
			{
				strErr+="ET不能为空！\\n";	
			}
			if(this.txtWP.Text.Trim().Length==0)
			{
				strErr+="WP不能为空！\\n";	
			}
			if(this.txtSP.Text.Trim().Length==0)
			{
				strErr+="SP不能为空！\\n";	
			}
			if(this.txtXF.Text.Trim().Length==0)
			{
				strErr+="XF不能为空！\\n";	
			}
			if(this.txtPromotionDiscount.Text.Trim().Length==0)
			{
				strErr+="PromotionDiscount不能为空！\\n";	
			}
			if(this.txtNewRateNo.Text.Trim().Length==0)
			{
				strErr+="NewRateNo不能为空！\\n";	
			}
			if(this.txtOfficeNum.Text.Trim().Length==0)
			{
				strErr+="OfficeNum不能为空！\\n";	
			}
			if(this.txtRefundTimeBegin.Text.Trim().Length==0)
			{
				strErr+="RefundTimeBegin不能为空！\\n";	
			}
			if(this.txtRefundTimeEnd.Text.Trim().Length==0)
			{
				strErr+="RefundTimeEnd不能为空！\\n";	
			}
			if(this.txtLastModifyTime.Text.Trim().Length==0)
			{
				strErr+="LastModifyTime不能为空！\\n";	
			}
			if(this.txtLimitModels.Text.Trim().Length==0)
			{
				strErr+="LimitModels不能为空！\\n";	
			}
			if(this.txtRefundRulesWay.Text.Trim().Length==0)
			{
				strErr+="RefundRulesWay不能为空！\\n";	
			}
			if(this.txtTPRemark.Text.Trim().Length==0)
			{
				strErr+="TPRemark不能为空！\\n";	
			}
			if(this.txtChangeMsg.Text.Trim().Length==0)
			{
				strErr+="ChangeMsg不能为空！\\n";	
			}
			if(this.txtInvalidMsg.Text.Trim().Length==0)
			{
				strErr+="InvalidMsg不能为空！\\n";	
			}
			if(this.txtRiseCabin.Text.Trim().Length==0)
			{
				strErr+="RiseCabin不能为空！\\n";	
			}
			if(this.txtForeignMsg.Text.Trim().Length==0)
			{
				strErr+="ForeignMsg不能为空！\\n";	
			}
			if(this.txtOutTicketPercent.Text.Trim().Length==0)
			{
				strErr+="OutTicketPercent不能为空！\\n";	
			}
			if(this.txtInvoiceMsg.Text.Trim().Length==0)
			{
				strErr+="InvoiceMsg不能为空！\\n";	
			}
			if(this.txtPrintInvoice.Text.Trim().Length==0)
			{
				strErr+="PrintInvoice不能为空！\\n";	
			}
			if(this.txtSwitchPNR.Text.Trim().Length==0)
			{
				strErr+="SwitchPNR不能为空！\\n";	
			}
			if(this.txtChange.Text.Trim().Length==0)
			{
				strErr+="Change不能为空！\\n";	
			}
			if(this.txtcomReturn.Text.Trim().Length==0)
			{
				strErr+="comReturn不能为空！\\n";	
			}
			if(this.txtPlatForm.Text.Trim().Length==0)
			{
				strErr+="PlatForm不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}
			if(this.txtCompany.Text.Trim().Length==0)
			{
				strErr+="Company不能为空！\\n";	
			}
			if(this.txtAirLine.Text.Trim().Length==0)
			{
				strErr+="AirLine不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string PolicyId=this.txtPolicyId.Text;
			string RateId=this.txtRateId.Text;
			string ScityE=this.txtScityE.Text;
			string EcityE=this.txtEcityE.Text;
			string AirComE=this.txtAirComE.Text;
			string NoAirComE=this.txtNoAirComE.Text;
			string PolicyType=this.txtPolicyType.Text;
			string Cabin=this.txtCabin.Text;
			string VoyageType=this.txtVoyageType.Text;
			string UserType=this.txtUserType.Text;
			string RateType=this.txtRateType.Text;
			decimal Discounts=decimal.Parse(this.txtDiscounts.Text);
			string Sdate=this.txtSdate.Text;
			string Edate=this.txtEdate.Text;
			string WorkTimBegin=this.txtWorkTimBegin.Text;
			string WorkTImeEnd=this.txtWorkTImeEnd.Text;
			string Rewards=this.txtRewards.Text;
			string Remark=this.txtRemark.Text;
			string ET=this.txtET.Text;
			string WP=this.txtWP.Text;
			string SP=this.txtSP.Text;
			string XF=this.txtXF.Text;
			string PromotionDiscount=this.txtPromotionDiscount.Text;
			string NewRateNo=this.txtNewRateNo.Text;
			string OfficeNum=this.txtOfficeNum.Text;
			string RefundTimeBegin=this.txtRefundTimeBegin.Text;
			string RefundTimeEnd=this.txtRefundTimeEnd.Text;
			string LastModifyTime=this.txtLastModifyTime.Text;
			string LimitModels=this.txtLimitModels.Text;
			string RefundRulesWay=this.txtRefundRulesWay.Text;
			string TPRemark=this.txtTPRemark.Text;
			string ChangeMsg=this.txtChangeMsg.Text;
			string InvalidMsg=this.txtInvalidMsg.Text;
			string RiseCabin=this.txtRiseCabin.Text;
			string ForeignMsg=this.txtForeignMsg.Text;
			string OutTicketPercent=this.txtOutTicketPercent.Text;
			string InvoiceMsg=this.txtInvoiceMsg.Text;
			string PrintInvoice=this.txtPrintInvoice.Text;
			string SwitchPNR=this.txtSwitchPNR.Text;
			string Change=this.txtChange.Text;
			string comReturn=this.txtcomReturn.Text;
			string PlatForm=this.txtPlatForm.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);
			string Company=this.txtCompany.Text;
			string AirLine=this.txtAirLine.Text;
			bool IsUpload=this.chkIsUpload.Checked;
			bool IsUpdate=this.chkIsUpdate.Checked;


			Sanben.Model.GetRateList model=new Sanben.Model.GetRateList();
			model.ID=ID;
			model.PolicyId=PolicyId;
			model.RateId=RateId;
			model.ScityE=ScityE;
			model.EcityE=EcityE;
			model.AirComE=AirComE;
			model.NoAirComE=NoAirComE;
			model.PolicyType=PolicyType;
			model.Cabin=Cabin;
			model.VoyageType=VoyageType;
			model.UserType=UserType;
			model.RateType=RateType;
			model.Discounts=Discounts;
			model.Sdate=Sdate;
			model.Edate=Edate;
			model.WorkTimBegin=WorkTimBegin;
			model.WorkTImeEnd=WorkTImeEnd;
			model.Rewards=Rewards;
			model.Remark=Remark;
			model.ET=ET;
			model.WP=WP;
			model.SP=SP;
			model.XF=XF;
			model.PromotionDiscount=PromotionDiscount;
			model.NewRateNo=NewRateNo;
			model.OfficeNum=OfficeNum;
			model.RefundTimeBegin=RefundTimeBegin;
			model.RefundTimeEnd=RefundTimeEnd;
			model.LastModifyTime=LastModifyTime;
			model.LimitModels=LimitModels;
			model.RefundRulesWay=RefundRulesWay;
			model.TPRemark=TPRemark;
			model.ChangeMsg=ChangeMsg;
			model.InvalidMsg=InvalidMsg;
			model.RiseCabin=RiseCabin;
			model.ForeignMsg=ForeignMsg;
			model.OutTicketPercent=OutTicketPercent;
			model.InvoiceMsg=InvoiceMsg;
			model.PrintInvoice=PrintInvoice;
			model.SwitchPNR=SwitchPNR;
			model.Change=Change;
			model.comReturn=comReturn;
			model.PlatForm=PlatForm;
			model.AddTime=AddTime;
			model.Company=Company;
			model.AirLine=AirLine;
			model.IsUpload=IsUpload;
			model.IsUpdate=IsUpdate;

			Sanben.BLL.GetRateList bll=new Sanben.BLL.GetRateList();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
