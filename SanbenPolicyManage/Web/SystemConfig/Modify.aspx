<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.SystemConfig.Modify" Title="修改页" %>
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
		AfterDays
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAfterDays" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TimingDays
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTimingDays" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Account
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAccount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LogPath
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLogPath" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiAmount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiBerth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiBerth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiRateWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiRateWay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiUserType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiUserType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiUserName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiVOYAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiVOYAGE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServerAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServerAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiTiming
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtJinRiTiming" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517natime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC517natime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC517name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517pid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC517pid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517pidsafe
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC517pidsafe" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtYi8000name" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000psword
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtYi8000psword" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000distime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtYi8000distime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380partner
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket380partner" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380key
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket380key" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket380time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380timeadd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket380timeadd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380gettime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket380gettime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51bookname
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC51bookname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51booktime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC51booktime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51bookyear
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtC51bookyear" runat="server" Width="200px"></asp:TextBox>
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

