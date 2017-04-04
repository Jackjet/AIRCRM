<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.SystemConfig.Show" Title="显示页" %>
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
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AfterDays
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAfterDays" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TimingDays
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTimingDays" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Account
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAccount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LogPath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLogPath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiBerth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiBerth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiRateWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiRateWay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiUserType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiUserType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiUserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiVOYAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiVOYAGE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServerAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblServerAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JinRiTiming
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJinRiTiming" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517natime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC517natime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC517name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517pid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC517pid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C517pidsafe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC517pidsafe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblYi8000name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000psword
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblYi8000psword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Yi8000distime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblYi8000distime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380partner
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket380partner" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380key
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket380key" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket380time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380timeadd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket380timeadd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket380gettime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTicket380gettime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51bookname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC51bookname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51booktime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC51booktime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		C51bookyear
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblC51bookyear" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




