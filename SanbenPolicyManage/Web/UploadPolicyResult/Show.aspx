<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.UploadPolicyResult.Show" Title="显示页" %>
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
		startMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		upload_platFrom
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupload_platFrom" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		upload_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblupload_class" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadResult
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadResult" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		errorNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblerrorNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		result
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblresult" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		noticeTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnoticeTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsys_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




