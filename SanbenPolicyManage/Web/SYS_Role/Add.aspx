<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.SYS_Role.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		角色名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRoleName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		停用标志
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkStop" Text="停用标志" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ordering
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrdering" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MenuList
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMenuList" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AuthorityList
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAuthorityList" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsModify
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsModify" Text="IsModify" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
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
