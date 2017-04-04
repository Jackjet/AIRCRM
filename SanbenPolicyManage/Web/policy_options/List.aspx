<%@ Page Title="policy_options" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.policy_options.List" %>
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
                    BorderWidth="1px" DataKeyNames="id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="Policy_interface_id" HeaderText="Policy_interface_id" SortExpression="Policy_interface_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tolerate_stationary_point" HeaderText="tolerate_stationary_point" SortExpression="tolerate_stationary_point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tolerate_leave_money" HeaderText="tolerate_leave_money" SortExpression="tolerate_leave_money" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_screening" HeaderText="is_screening" SortExpression="is_screening" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lowest_rebate" HeaderText="lowest_rebate" SortExpression="lowest_rebate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="highest_rebate" HeaderText="highest_rebate" SortExpression="highest_rebate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="earliest_advance_days" HeaderText="earliest_advance_days" SortExpression="earliest_advance_days" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="night_before_days" HeaderText="night_before_days" SortExpression="night_before_days" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rebate_class_set" HeaderText="rebate_class_set" SortExpression="rebate_class_set" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flight_departure_time_start" HeaderText="Flight_departure_time_start" SortExpression="Flight_departure_time_start" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_automatic_ticket" HeaderText="is_automatic_ticket" SortExpression="is_automatic_ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_mail_itinerary" HeaderText="is_mail_itinerary" SortExpression="is_mail_itinerary" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="empower_office_number" HeaderText="empower_office_number" SortExpression="empower_office_number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="refund_rule" HeaderText="refund_rule" SortExpression="refund_rule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="changedate_rule" HeaderText="changedate_rule" SortExpression="changedate_rule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_allowed_sign" HeaderText="is_allowed_sign" SortExpression="is_allowed_sign" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_provide_regular_passenger_integral" HeaderText="is_provide_regular_passenger_integral" SortExpression="is_provide_regular_passenger_integral" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="document_type" HeaderText="document_type" SortExpression="document_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="minimum_age" HeaderText="minimum_age" SortExpression="minimum_age" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="maximum_age" HeaderText="maximum_age" SortExpression="maximum_age" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="class_description" HeaderText="class_description" SortExpression="class_description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="special_ticketing_instructions" HeaderText="special_ticketing_instructions" SortExpression="special_ticketing_instructions" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sys_userId" HeaderText="sys_userId" SortExpression="sys_userId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flight_departure_time_end" HeaderText="Flight_departure_time_end" SortExpression="Flight_departure_time_end" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
