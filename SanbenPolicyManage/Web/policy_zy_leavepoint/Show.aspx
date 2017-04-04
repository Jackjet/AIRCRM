<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.policy_zy_leavepoint.Show" Title="显示页" %>
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
		navigation_company
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnavigation_company" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		air_line
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblair_line" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		application_space
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblapplication_space" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		rabate_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrabate_number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leave_point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleave_point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leave_money
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleave_money" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartdate_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enddate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenddate_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		traveldate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltraveldate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isleavepointandmoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisleavepointandmoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isSet
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisSet" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblremark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changedate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchangedate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatform_id" runat="server"></asp:Label>
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
		rabate_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrabate_class" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




