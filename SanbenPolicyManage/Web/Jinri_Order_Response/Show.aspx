<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.Jinri_Order_Response.Show" Title="显示页" %>
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
		OrderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPNR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GrowDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGrowDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StayDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStayDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Profit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProfit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDate" runat="server"></asp:Label>
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
		Ecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEcity" runat="server"></asp:Label>
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
		Stime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Etime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEtime" runat="server"></asp:Label>
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
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Tax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPCard" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JouneryInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJouneryInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBuyInsurance
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsBuyInsurance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticket_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefund_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblamount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pay_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpay_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trade_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltrade_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pay_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpay_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderInfo_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderInfo_id" runat="server"></asp:Label>
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




