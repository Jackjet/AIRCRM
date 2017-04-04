<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.BaQianYiPolicy.Modify" Title="修改页" %>
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
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_num
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_num" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startcity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartcity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arrivecity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtarrivecity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		airline
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtairline" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		for_flight_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfor_flight_no" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ex_flight_no
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtex_flight_no" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_ratype
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_ratype" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin_discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcabin_discount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arrivedate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtarrivedate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		nomal_workday
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnomal_workday" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		weekday
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtweekday" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		vip_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtvip_policy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		return_policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtreturn_policy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_note
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_note" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		supplier_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsupplier_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		or_ticket_t
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtor_ticket_t" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		week_ticket_t
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtweek_ticket_t" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_flight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		end_state
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtend_state" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		office_code
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtoffice_code" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		salestart_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsalestart_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		saleend_date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsaleend_date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		support_pay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsupport_pay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ticket_efficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticket_efficient" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_cgnum_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtis_cgnum_ticket" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_open_low
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtis_open_low" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtaddtime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		last_modify_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlast_modify_time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpload" Text="IsUpload" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsUpdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsUpdate" Text="IsUpdate" runat="server" Checked="False" />
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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

