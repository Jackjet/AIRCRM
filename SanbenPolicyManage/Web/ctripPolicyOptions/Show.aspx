<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.ctripPolicyOptions.Show" Title="显示页" %>
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
		tolerate_stationary_point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltolerate_stationary_point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tolerate_leave_money
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltolerate_leave_money" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllowest_rebate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhighest_rebate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliest_advance_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblearliest_advance_days" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		night_before_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnight_before_days" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rebate_class_set
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrebate_class_set" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_price_set
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticket_price_set" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		workTimeLimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblworkTimeLimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_automatic_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_automatic_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_mail_itinerary
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_mail_itinerary" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		off_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloff_number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_orientate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_orientate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		special_ticketing_instructions
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblspecial_ticketing_instructions" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_change_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefund_change_rule" runat="server"></asp:Label>
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
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsys_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




