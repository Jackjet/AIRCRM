<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.ctripPolicyOptions.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		tolerate_stationary_point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttolerate_stationary_point" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tolerate_leave_money
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttolerate_leave_money" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlowest_rebate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthighest_rebate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliest_advance_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtearliest_advance_days" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		night_before_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnight_before_days" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rebate_class_set
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrebate_class_set" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_price_set
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticket_price_set" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		workTimeLimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtworkTimeLimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_automatic_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_automatic_ticket" Text="is_automatic_ticket" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_mail_itinerary
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_mail_itinerary" Text="is_mail_itinerary" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		off_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtoff_number" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_orientate
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_orientate" Text="is_orientate" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		special_ticketing_instructions
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspecial_ticketing_instructions" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_change_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrefund_change_rule" runat="server" Width="200px"></asp:TextBox>
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
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsys_id" runat="server" Width="200px"></asp:TextBox>
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
