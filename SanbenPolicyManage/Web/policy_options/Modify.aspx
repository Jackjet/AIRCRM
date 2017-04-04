<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.policy_options.Modify" Title="修改页" %>
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
		Policy_interface_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPolicy_interface_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
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
		is_screening
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_screening" Text="is_screening" runat="server" Checked="False" />
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
		Flight_departure_time_start
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlight_departure_time_start" runat="server" Width="200px"></asp:TextBox>
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
		empower_office_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtempower_office_number" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrefund_rule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changedate_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchangedate_rule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_allowed_sign
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_allowed_sign" Text="is_allowed_sign" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_provide_regular_passenger_integral
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_provide_regular_passenger_integral" Text="is_provide_regular_passenger_integral" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		document_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdocument_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		minimum_age
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtminimum_age" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maximum_age
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmaximum_age" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		class_description
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclass_description" runat="server" Width="200px"></asp:TextBox>
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
		sys_userId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsys_userId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flight_departure_time_end
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlight_departure_time_end" runat="server" Width="200px"></asp:TextBox>
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

