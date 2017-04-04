<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.OrderInfo2.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		pk_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpk_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		allPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblallPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		noPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnoPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPrintPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildPrintPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childFaceValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildFaceValue" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsource" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policySource
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicySource" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticketMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyFriendly
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicyFriendly" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payChannel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpayChannel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpayStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		insuranceUnitPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblinsuranceUnitPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbacknote" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		insuranceCuttingPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblinsuranceCuttingPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabinnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabinnote" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xcdPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblxcdPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xcd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblxcd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sjr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsjr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactTel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcontactTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		company
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcompany" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		expType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblexpType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ordernumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblordernumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sendtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsendtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		viewPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblviewPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpnr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cpnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcpnr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pnrText
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpnrText" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPnrText
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildPnrText" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pataText
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpataText" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPataText
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildPataText" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		constructionFee
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblconstructionFee" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		fuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfuelTax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childFuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildFuelTax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicyType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contact
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcontact" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactMob
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcontactMob" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcontactEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		createTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needPS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblneedPS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		username
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblusername" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderFrom
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderFrom" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lockStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllockStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		updateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluserid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderDesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderDesc" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




