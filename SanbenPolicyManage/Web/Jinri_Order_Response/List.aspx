﻿<%@ Page Title="Jinri_Order_Response" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.Jinri_Order_Response.List" %>
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
                            
		<asp:BoundField DataField="OrderNo" HeaderText="OrderNo" SortExpression="OrderNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PNR" HeaderText="PNR" SortExpression="PNR" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GrowDiscount" HeaderText="GrowDiscount" SortExpression="GrowDiscount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StayDiscount" HeaderText="StayDiscount" SortExpression="StayDiscount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayMoney" HeaderText="PayMoney" SortExpression="PayMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Profit" HeaderText="Profit" SortExpression="Profit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Scity" HeaderText="Scity" SortExpression="Scity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ecity" HeaderText="Ecity" SortExpression="Ecity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flight" HeaderText="Flight" SortExpression="Flight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Stime" HeaderText="Stime" SortExpression="Stime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Etime" HeaderText="Etime" SortExpression="Etime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin" HeaderText="Cabin" SortExpression="Cabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tax" HeaderText="Tax" SortExpression="Tax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PCount" HeaderText="PCount" SortExpression="PCount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PName" HeaderText="PName" SortExpression="PName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PCard" HeaderText="PCard" SortExpression="PCard" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JouneryInfo" HeaderText="JouneryInfo" SortExpression="JouneryInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsBuyInsurance" HeaderText="IsBuyInsurance" SortExpression="IsBuyInsurance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ticket_no" HeaderText="ticket_no" SortExpression="ticket_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="refund_type" HeaderText="refund_type" SortExpression="refund_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pay_type" HeaderText="pay_type" SortExpression="pay_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="trade_no" HeaderText="trade_no" SortExpression="trade_no" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pay_time" HeaderText="pay_time" SortExpression="pay_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderInfo_id" HeaderText="OrderInfo_id" SortExpression="OrderInfo_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="platformB2B_name_id" HeaderText="platformB2B_name_id" SortExpression="platformB2B_name_id" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
