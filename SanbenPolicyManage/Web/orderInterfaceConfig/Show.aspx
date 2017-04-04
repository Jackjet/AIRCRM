<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.orderInterfaceConfig.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
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
		password
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		interfaceAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblinterfaceAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isAutomaticGainOrder
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisAutomaticGainOrder" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isAutomaticTicket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisAutomaticTicket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightCompany
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflightCompany" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartAirport" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblendAirport" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxDeficit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmaxDeficit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		linkPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllinkPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		automaticTicketPlat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblautomaticTicketPlat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsys_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_type_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatform_type_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rt_user
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrt_user" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rt_pwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrt_pwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEtermRT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRTuser
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEtermRTuser" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRTpwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEtermRTpwd" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




