<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.51bookPolicy.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		adultAirportTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadultAirportTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adultFuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadultFuelTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childAirportTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildAirportTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childFuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildFuelTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflightNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		adultSettlePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtadultSettlePrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		airlineCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtairlineCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		comment
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcomment" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		commisionPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcommisionPoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needSwitchPNR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtneedSwitchPNR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicyId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicyType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		productType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtproductType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		routeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrouteType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seatType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseatType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		supplyOfficeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsupplyOfficeNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketSpeed
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticketSpeed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vtWorkTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtvtWorkTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		workTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtworkTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		seatCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtseatCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticketPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticketPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Addtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtAddtime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpload" Text="IsUpload" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpdate" Text="IsUpdate" runat="server" Checked="False" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
