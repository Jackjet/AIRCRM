<%@ Page Title="517NaBenefit" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.517NaBenefit.List" %>
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
                    BorderWidth="1px" DataKeyNames="" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PolicyNum" HeaderText="PolicyNum" SortExpression="PolicyNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Airline" HeaderText="Airline" SortExpression="Airline" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Scity" HeaderText="Scity" SortExpression="Scity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Acity" HeaderText="Acity" SortExpression="Acity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AirType" HeaderText="AirType" SortExpression="AirType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flight" HeaderText="Flight" SortExpression="Flight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin" HeaderText="Cabin" SortExpression="Cabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TripType" HeaderText="TripType" SortExpression="TripType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PolicyType" HeaderText="PolicyType" SortExpression="PolicyType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PolicyPoint" HeaderText="PolicyPoint" SortExpression="PolicyPoint" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ScheduleRestr" HeaderText="ScheduleRestr" SortExpression="ScheduleRestr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TicketCondition" HeaderText="TicketCondition" SortExpression="TicketCondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AvaDate" HeaderText="AvaDate" SortExpression="AvaDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EndDate" HeaderText="EndDate" SortExpression="EndDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SupplierTimeDay" HeaderText="SupplierTimeDay" SortExpression="SupplierTimeDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SupplierTimeWeek" HeaderText="SupplierTimeWeek" SortExpression="SupplierTimeWeek" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsSpeciPolicy" HeaderText="IsSpeciPolicy" SortExpression="IsSpeciPolicy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsChange" HeaderText="IsChange" SortExpression="IsChange" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ChildPolicyNum" HeaderText="ChildPolicyNum" SortExpression="ChildPolicyNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayPrice" HeaderText="PayPrice" SortExpression="PayPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket" HeaderText="Ticket" SortExpression="Ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Airrax" HeaderText="Airrax" SortExpression="Airrax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Fuel" HeaderText="Fuel" SortExpression="Fuel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SupplierDelDay" HeaderText="SupplierDelDay" SortExpression="SupplierDelDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SupplierDelWeek" HeaderText="SupplierDelWeek" SortExpression="SupplierDelWeek" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TicketEffic" HeaderText="TicketEffic" SortExpression="TicketEffic" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpgradeChange" HeaderText="UpgradeChange" SortExpression="UpgradeChange" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OfficeCode" HeaderText="OfficeCode" SortExpression="OfficeCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddTime" HeaderText="AddTime" SortExpression="AddTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsUpload" HeaderText="IsUpload" SortExpression="IsUpload" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsUpdate" HeaderText="IsUpdate" SortExpression="IsUpdate" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Show.aspx?"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Modify.aspx?"
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
