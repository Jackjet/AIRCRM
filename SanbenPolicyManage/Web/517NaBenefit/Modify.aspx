<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.517NaBenefit.Modify" Title="修改页" %>
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
		<asp:TextBox id="txtID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicyNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airline
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirline" runat="server" Width="200px"></asp:TextBox>
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
		Acity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAcity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirType" runat="server" Width="200px"></asp:TextBox>
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
		Cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TripType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTripType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicyType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PolicyPoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicyPoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScheduleRestr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtScheduleRestr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TicketCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicketCondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AvaDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAvaDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EndDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierTimeDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSupplierTimeDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierTimeWeek
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSupplierTimeWeek" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsSpeciPolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsSpeciPolicy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsChange
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsChange" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChildPolicyNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChildPolicyNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicket" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Airrax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirrax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fuel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFuel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierDelDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSupplierDelDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SupplierDelWeek
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSupplierDelWeek" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TicketEffic
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTicketEffic" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpgradeChange
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUpgradeChange" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OfficeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOfficeCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtAddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

