<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.API380Ticket.Show" Title="显示页" %>
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
		code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		message
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmessage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		bigpnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbigpnr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		air
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblair" runat="server"></asp:Label>
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
		paystatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpaystatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		totaltax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltotaltax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticketprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderno
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderno" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platformB2B_name_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatformB2B_name_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




