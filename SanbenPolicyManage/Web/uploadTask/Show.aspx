<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.uploadTask.Show" Title="显示页" %>
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
		execution_frequency
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblexecution_frequency" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		execution_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblexecution_time" runat="server"></asp:Label>
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
		policy_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_class" runat="server"></asp:Label>
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
		uploadPlatFrom_specialPolicies
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadPlatFrom_specialPolicies" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policySource
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicySource" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		tripType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltripType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		execute_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblexecute_number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		condition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsys_id" runat="server"></asp:Label>
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
		NextFullTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNextFullTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NextAddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNextAddTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Uploading
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUploading" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




