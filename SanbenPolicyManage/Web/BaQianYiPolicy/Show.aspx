<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.BaQianYiPolicy.Show" Title="显示页" %>
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
		policy_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_num" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startcity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartcity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arrivecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblarrivecity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		airline
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblairline" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		for_flight_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblfor_flight_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ex_flight_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblex_flight_no" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_ratype
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_ratype" runat="server"></asp:Label>
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
		cabin_discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabin_discount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arrivedate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblarrivedate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nomal_workday
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnomal_workday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		weekday
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblweekday" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vip_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblvip_policy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		return_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreturn_policy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_note
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_note" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		supplier_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsupplier_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		or_ticket_t
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblor_ticket_t" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		week_ticket_t
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblweek_ticket_t" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy_flight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		end_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblend_state" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		office_code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbloffice_code" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		salestart_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsalestart_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		saleend_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsaleend_date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		support_pay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsupport_pay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_efficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblticket_efficient" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_cgnum_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_cgnum_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_open_low
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_open_low" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		last_modify_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllast_modify_time" runat="server"></asp:Label>
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




