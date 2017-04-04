<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.GaiQianWangFanRetirement.Show" Title="显示页" %>
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
		quchengSpace
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblquchengSpace" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		huichengSpace
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhuichengSpace" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		initiate_mode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblinitiate_mode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblendDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefund_rule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changedate_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchangedate_rule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_allowed_sign
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_allowed_sign" runat="server"></asp:Label>
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
		platform_type_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatform_type_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




