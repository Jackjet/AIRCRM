<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.PurchaseOrderInfo.Show" Title="显示页" %>
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
		price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		issue_ticket_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblissue_ticket_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		issue_ticket_platform_code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblissue_ticket_platform_code" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source_transaction_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsource_transaction_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source_order_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsource_order_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tpp_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltpp_type" runat="server"></asp:Label>
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
		pay_commercial_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpay_commercial_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		offline_pay_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloffline_pay_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		offline_pay_cardno
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloffline_pay_cardno" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_mem_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatform_mem_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		operator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloperator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefund_price" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		o_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblo_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




