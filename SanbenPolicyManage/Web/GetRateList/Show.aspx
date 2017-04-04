<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.GetRateList.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPolicyId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RateId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRateId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScityE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblScityE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EcityE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEcityE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirComE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirComE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NoAirComE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNoAirComE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPolicyType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VoyageType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVoyageType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RateType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRateType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discounts
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscounts" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Edate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTimBegin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkTimBegin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTImeEnd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkTImeEnd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Rewards
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRewards" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ET
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblET" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		XF
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblXF" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PromotionDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPromotionDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewRateNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNewRateNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OfficeNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOfficeNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundTimeBegin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRefundTimeBegin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundTimeEnd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRefundTimeEnd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastModifyTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastModifyTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LimitModels
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLimitModels" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundRulesWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRefundRulesWay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TPRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTPRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChangeMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChangeMsg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvalidMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvalidMsg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RiseCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRiseCabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ForeignMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblForeignMsg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutTicketPercent
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOutTicketPercent" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceMsg" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrintInvoice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrintInvoice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SwitchPNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSwitchPNR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Change
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChange" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		comReturn
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcomReturn" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlatForm
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPlatForm" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Company
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompany" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirLine
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirLine" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsUpload" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsUpdate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




