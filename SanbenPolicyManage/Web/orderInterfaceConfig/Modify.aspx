<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.orderInterfaceConfig.Modify" Title="修改页" %>
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
		username
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtusername" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		password
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpassword" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		interfaceAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtinterfaceAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtstartDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isAutomaticGainOrder
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisAutomaticGainOrder" Text="isAutomaticGainOrder" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isAutomaticTicket
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisAutomaticTicket" Text="isAutomaticTicket" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightCompany
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflightCompany" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartAirport" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtendAirport" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxDeficit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmaxDeficit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		linkPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlinkPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		automaticTicketPlat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtautomaticTicketPlat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsys_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_type_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplatform_type_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rt_user
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrt_user" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rt_pwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrt_pwd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEtermRT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRTuser
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEtermRTuser" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EtermRTpwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEtermRTpwd" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

