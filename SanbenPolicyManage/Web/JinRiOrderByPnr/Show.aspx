<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.JinRiOrderByPnr.Show" Title="显示页" %>
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
		orderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderNo" runat="server"></asp:Label>
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
		growDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgrowDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stayDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstayDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpayMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		profit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprofit" runat="server"></asp:Label>
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
		date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		scity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblscity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblecity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		etime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbletime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabin" runat="server"></asp:Label>
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
		tax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pcount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpcount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpCard" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		jouneryInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbljouneryInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isBuyInsurance
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisBuyInsurance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderinfo_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblorderinfo_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




