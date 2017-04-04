<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.517NaBenefit.Show" Title="显示页" %>
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
		PolicyNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPolicyNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airline
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirline" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Scity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblScity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Acity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAcity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlight" runat="server"></asp:Label>
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
		TripType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTripType" runat="server"></asp:Label>
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
		PolicyPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPolicyPoint" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScheduleRestr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblScheduleRestr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TicketCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicketCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AvaDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAvaDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EndDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEndDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierTimeDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSupplierTimeDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierTimeWeek
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSupplierTimeWeek" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsSpeciPolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsSpeciPolicy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsChange
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsChange" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChildPolicyNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChildPolicyNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airrax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirrax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fuel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierDelDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSupplierDelDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierDelWeek
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSupplierDelWeek" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TicketEffic
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicketEffic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpgradeChange
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpgradeChange" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OfficeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOfficeCode" runat="server"></asp:Label>
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




