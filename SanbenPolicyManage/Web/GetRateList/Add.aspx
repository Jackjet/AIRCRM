<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.GetRateList.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		PolicyId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicyId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RateId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRateId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScityE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtScityE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EcityE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEcityE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirComE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirComE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NoAirComE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNoAirComE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicyType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VoyageType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVoyageType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RateType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRateType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discounts
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDiscounts" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Edate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTimBegin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkTimBegin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkTImeEnd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkTImeEnd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Rewards
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRewards" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ET
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtET" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		XF
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtXF" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PromotionDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPromotionDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NewRateNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNewRateNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OfficeNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOfficeNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundTimeBegin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRefundTimeBegin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundTimeEnd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRefundTimeEnd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastModifyTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastModifyTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LimitModels
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLimitModels" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RefundRulesWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRefundRulesWay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TPRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTPRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChangeMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChangeMsg" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvalidMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvalidMsg" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RiseCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRiseCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ForeignMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtForeignMsg" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutTicketPercent
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOutTicketPercent" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceMsg
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvoiceMsg" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrintInvoice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrintInvoice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SwitchPNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSwitchPNR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Change
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChange" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		comReturn
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcomReturn" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PlatForm
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPlatForm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtAddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Company
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCompany" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirLine
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirLine" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpload" Text="IsUpload" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpdate" Text="IsUpdate" runat="server" Checked="False" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
