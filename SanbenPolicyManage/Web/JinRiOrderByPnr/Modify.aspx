<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.JinRiOrderByPnr.Modify" Title="修改页" %>
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
		<asp:label id="lblid" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpnr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		growDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgrowDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stayDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstayDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpayMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		profit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprofit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		scity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtscity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtecity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		stime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		etime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtetime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pcount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpcount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpCard" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		jouneryInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtjouneryInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isBuyInsurance
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtisBuyInsurance" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderinfo_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderinfo_id" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

