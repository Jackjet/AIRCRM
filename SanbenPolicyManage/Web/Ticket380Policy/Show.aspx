<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.Ticket380Policy.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		air_comp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblair_comp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		start_city
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstart_city" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arr_city
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblarr_city" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		share_line
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshare_line" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabinprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabinprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpoint" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nakednum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnakednum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_auto_tic
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_auto_tic" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		logtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllogtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		deptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldeptime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprice" runat="server"></asp:Label>
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
		fsdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfsdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		fedate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfedate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sale_sdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsale_sdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sale_edate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsale_edate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsUpload" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsUpdate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




