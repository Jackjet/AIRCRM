<%@ Page Title="Airport_Detail" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.Airport_Detail.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="From_Code" HeaderText="From_Code" SortExpression="From_Code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="To_Code" HeaderText="To_Code" SortExpression="To_Code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StartCity" HeaderText="StartCity" SortExpression="StartCity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ArriveCity" HeaderText="ArriveCity" SortExpression="ArriveCity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mileage" HeaderText="Mileage" SortExpression="Mileage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Fule_Adult" HeaderText="Fule_Adult" SortExpression="Fule_Adult" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Fule_Child" HeaderText="Fule_Child" SortExpression="Fule_Child" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Line_Number" HeaderText="Line_Number" SortExpression="Line_Number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Share_Line" HeaderText="Share_Line" SortExpression="Share_Line" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StartCode" HeaderText="StartCode" SortExpression="StartCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StartAirport" HeaderText="StartAirport" SortExpression="StartAirport" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ArriveCode" HeaderText="ArriveCode" SortExpression="ArriveCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ArriveAirport" HeaderText="ArriveAirport" SortExpression="ArriveAirport" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StartTime" HeaderText="StartTime" SortExpression="StartTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ArriveTime" HeaderText="ArriveTime" SortExpression="ArriveTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AirRax" HeaderText="AirRax" SortExpression="AirRax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FuleRax" HeaderText="FuleRax" SortExpression="FuleRax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FuelAdu" HeaderText="FuelAdu" SortExpression="FuelAdu" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FuelChd" HeaderText="FuelChd" SortExpression="FuelChd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Food" HeaderText="Food" SortExpression="Food" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Food_Detail" HeaderText="Food_Detail" SortExpression="Food_Detail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Direct_Flight" HeaderText="Direct_Flight" SortExpression="Direct_Flight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Electronic_Ticket" HeaderText="Electronic_Ticket" SortExpression="Electronic_Ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Start_Terminal" HeaderText="Start_Terminal" SortExpression="Start_Terminal" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Arrive_Terminal" HeaderText="Arrive_Terminal" SortExpression="Arrive_Terminal" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin" HeaderText="Cabin" SortExpression="Cabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ChildCabin" HeaderText="ChildCabin" SortExpression="ChildCabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Discount" HeaderText="Discount" SortExpression="Discount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Surplus_Seat_Qty" HeaderText="Surplus_Seat_Qty" SortExpression="Surplus_Seat_Qty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin_Status" HeaderText="Cabin_Status" SortExpression="Cabin_Status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin_Point" HeaderText="Cabin_Point" SortExpression="Cabin_Point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Validity_Period" HeaderText="Validity_Period" SortExpression="Validity_Period" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Return_Date" HeaderText="Return_Date" SortExpression="Return_Date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Valid_Date" HeaderText="Valid_Date" SortExpression="Valid_Date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddTime" HeaderText="AddTime" SortExpression="AddTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
