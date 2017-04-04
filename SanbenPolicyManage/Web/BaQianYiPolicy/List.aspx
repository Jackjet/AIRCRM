<%@ Page Title="BaQianYiPolicy" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.BaQianYiPolicy.List" %>
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
                            
		<asp:BoundField DataField="policy_num" HeaderText="policy_num" SortExpression="policy_num" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="startcity" HeaderText="startcity" SortExpression="startcity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="arrivecity" HeaderText="arrivecity" SortExpression="arrivecity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="airline" HeaderText="airline" SortExpression="airline" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="for_flight_no" HeaderText="for_flight_no" SortExpression="for_flight_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ex_flight_no" HeaderText="ex_flight_no" SortExpression="ex_flight_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy_ratype" HeaderText="policy_ratype" SortExpression="policy_ratype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="point" HeaderText="point" SortExpression="point" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cabin_discount" HeaderText="cabin_discount" SortExpression="cabin_discount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="startdate" HeaderText="startdate" SortExpression="startdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="arrivedate" HeaderText="arrivedate" SortExpression="arrivedate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="nomal_workday" HeaderText="nomal_workday" SortExpression="nomal_workday" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="weekday" HeaderText="weekday" SortExpression="weekday" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="vip_policy" HeaderText="vip_policy" SortExpression="vip_policy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="return_policy" HeaderText="return_policy" SortExpression="return_policy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy_type" HeaderText="policy_type" SortExpression="policy_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy_note" HeaderText="policy_note" SortExpression="policy_note" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="supplier_id" HeaderText="supplier_id" SortExpression="supplier_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="or_ticket_t" HeaderText="or_ticket_t" SortExpression="or_ticket_t" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="week_ticket_t" HeaderText="week_ticket_t" SortExpression="week_ticket_t" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy_flight" HeaderText="policy_flight" SortExpression="policy_flight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="end_state" HeaderText="end_state" SortExpression="end_state" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="office_code" HeaderText="office_code" SortExpression="office_code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="salestart_date" HeaderText="salestart_date" SortExpression="salestart_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="saleend_date" HeaderText="saleend_date" SortExpression="saleend_date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="support_pay" HeaderText="support_pay" SortExpression="support_pay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ticket_efficient" HeaderText="ticket_efficient" SortExpression="ticket_efficient" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_cgnum_ticket" HeaderText="is_cgnum_ticket" SortExpression="is_cgnum_ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_open_low" HeaderText="is_open_low" SortExpression="is_open_low" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addtime" HeaderText="addtime" SortExpression="addtime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="last_modify_time" HeaderText="last_modify_time" SortExpression="last_modify_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsUpload" HeaderText="IsUpload" SortExpression="IsUpload" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsUpdate" HeaderText="IsUpdate" SortExpression="IsUpdate" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
