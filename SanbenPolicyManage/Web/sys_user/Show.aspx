<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.sys_user.Show" Title="显示页" %>
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
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		username
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblusername" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		password
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpassword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RoleList
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRoleList" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CheckAuthority
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCheckAuthority" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stop
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStop" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsModify
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsModify" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RealName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRealName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Gender
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGender" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mobile
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMobile" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Telephone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTelephone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QQ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQQ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Emaile
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmaile" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Company
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompany" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ParentID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblParentID" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




