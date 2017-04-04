<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.Jinri_Order_Response.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		OrderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrderNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPNR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GrowDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGrowDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StayDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStayDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Profit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProfit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Scity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtScity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEcity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Etime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEtime" runat="server" Width="200px"></asp:TextBox>
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
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Tax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPCount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPCard" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JouneryInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJouneryInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBuyInsurance
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsBuyInsurance" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtremark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticket_no" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrefund_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtamount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pay_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpay_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		trade_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttrade_no" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pay_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpay_time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderInfo_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrderInfo_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platformB2B_name_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplatformB2B_name_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
