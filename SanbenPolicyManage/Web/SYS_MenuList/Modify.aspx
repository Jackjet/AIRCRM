<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.SYS_MenuList.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		编码
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		模块ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtText" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TabID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTabID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		权限ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNavigateUrl" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ParentID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtParentID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SingleClickExpand
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkSingleClickExpand" Text="SingleClickExpand" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Icon
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIcon" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsModule
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsModule" Text="IsModule" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsFuntion
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsFuntion" Text="IsFuntion" runat="server" Checked="False" />
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
		Stop
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkStop" Text="Stop" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVersion" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sort
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsort" runat="server" Width="200px"></asp:TextBox>
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

