<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Sanben.Web.testforpolicy.Modify" Title="修改页" %>
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
		<asp:TextBox id="txtID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		From_Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFrom_Code" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		To_Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTo_Code" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartCity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStartCity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveCity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtArriveCity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mileage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMileage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fule_Adult
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFule_Adult" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fule_Child
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFule_Child" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Line_Number
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLine_Number" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Share_Line
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShare_Line" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Company
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCompany" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStartCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStartAirport" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtArriveCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtArriveAirport" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStartTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtArriveTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirRax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAirRax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuleRax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFuleRax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuelAdu
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFuelAdu" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuelChd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFuelChd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Food
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFood" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Food_Detail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFood_Detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Direct_Flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDirect_Flight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Electronic_Ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtElectronic_Ticket" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Start_Terminal
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStart_Terminal" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Arrive_Terminal
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtArrive_Terminal" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChildCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtChildCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Surplus_Seat_Qty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSurplus_Seat_Qty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin_Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin_Status" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCabin_Point" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Validity_Period
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtValidity_Period" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Return_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReturn_Date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Valid_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtValid_Date" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtAddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlag" runat="server" Width="200px"></asp:TextBox>
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

