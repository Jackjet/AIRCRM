<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.testforpolicy.Show" Title="显示页" %>
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
		Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		From_Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFrom_Code" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		To_Code
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTo_Code" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartCity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStartCity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveCity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArriveCity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mileage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMileage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fule_Adult
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFule_Adult" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Fule_Child
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFule_Child" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Line_Number
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLine_Number" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Share_Line
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShare_Line" runat="server"></asp:Label>
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
		StartCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStartCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStartAirport" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArriveCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveAirport
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArriveAirport" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StartTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStartTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArriveTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AirRax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAirRax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuleRax
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuleRax" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuelAdu
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuelAdu" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FuelChd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFuelChd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Food
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFood" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Food_Detail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFood_Detail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Direct_Flight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDirect_Flight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Electronic_Ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblElectronic_Ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Start_Terminal
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStart_Terminal" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Arrive_Terminal
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArrive_Terminal" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ChildCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChildCabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Surplus_Seat_Qty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurplus_Seat_Qty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin_Status
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCabin_Status" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Cabin_Point
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCabin_Point" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Validity_Period
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblValidity_Period" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Return_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReturn_Date" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Valid_Date
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblValid_Date" runat="server"></asp:Label>
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
		Flag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlag" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




