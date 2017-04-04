<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.gaiqian_retirement.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		navigation_company
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnavigation_company" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		air_line
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtair_line" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		application_space
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtapplication_space" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		initiate_mode
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkinitiate_mode" Text="initiate_mode" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtendDate" runat="server" Width="200px"></asp:TextBox>
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
