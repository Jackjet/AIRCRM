﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.Airport_Unknown.Modify" Title="修改页" %>
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
		<asp:label id="lblID" runat="server"></asp:label>
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
		ChildCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChildCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDiscount" runat="server" Width="200px"></asp:TextBox>
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
		Surplus_Seat_Qty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSurplus_Seat_Qty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin_Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin_Status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Line_Number
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLine_Number" runat="server" Width="200px"></asp:TextBox>
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

