<%@ Page Title="PurchaseOrderInfo" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.PurchaseOrderInfo.List" %>
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
                            
		<asp:BoundField DataField="price" HeaderText="price" SortExpression="price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="issue_ticket_type" HeaderText="issue_ticket_type" SortExpression="issue_ticket_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="issue_ticket_platform_code" HeaderText="issue_ticket_platform_code" SortExpression="issue_ticket_platform_code" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="source_transaction_id" HeaderText="source_transaction_id" SortExpression="source_transaction_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="source_order_no" HeaderText="source_order_no" SortExpression="source_order_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tpp_type" HeaderText="tpp_type" SortExpression="tpp_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="status" HeaderText="status" SortExpression="status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pay_commercial_no" HeaderText="pay_commercial_no" SortExpression="pay_commercial_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="offline_pay_type" HeaderText="offline_pay_type" SortExpression="offline_pay_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="offline_pay_cardno" HeaderText="offline_pay_cardno" SortExpression="offline_pay_cardno" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="platform_mem_id" HeaderText="platform_mem_id" SortExpression="platform_mem_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="operator" HeaderText="operator" SortExpression="operator" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="refund_price" HeaderText="refund_price" SortExpression="refund_price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="o_id" HeaderText="o_id" SortExpression="o_id" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
