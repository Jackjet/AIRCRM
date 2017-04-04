<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.51bookPolicy.Show" Title="显示页" %>
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
		adultAirportTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladultAirportTax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adultFuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladultFuelTax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childAirportTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchildAirportTax" runat="server"></asp:Label>
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
		flightNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflightNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adultSettlePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladultSettlePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		airlineCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblairlineCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		comment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcomment" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commisionPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcommisionPoint" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needSwitchPNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblneedSwitchPNR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicyId" runat="server"></asp:Label>
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
		productType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproductType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		routeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrouteType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seatType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseatType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		supplyOfficeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsupplyOfficeNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketSpeed
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticketSpeed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vtWorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblvtWorkTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		workTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblworkTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seatCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblseatCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticketPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Addtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddtime" runat="server"></asp:Label>
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




