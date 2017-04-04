﻿<%@ Page Title="rebate_wangfan" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.rebate_wangfan.List" %>
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
                            
		<asp:BoundField DataField="navigation_company" HeaderText="navigation_company" SortExpression="navigation_company" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="air_line" HeaderText="air_line" SortExpression="air_line" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="qucheng_space" HeaderText="qucheng_space" SortExpression="qucheng_space" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="huicheng_space" HeaderText="huicheng_space" SortExpression="huicheng_space" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rabate_number" HeaderText="rabate_number" SortExpression="rabate_number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="leave_money" HeaderText="leave_money" SortExpression="leave_money" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ticket_price_lowest" HeaderText="ticket_price_lowest" SortExpression="ticket_price_lowest" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ticket_price_highest" HeaderText="ticket_price_highest" SortExpression="ticket_price_highest" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="rabate_class" HeaderText="rabate_class" SortExpression="rabate_class" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sys_id" HeaderText="sys_id" SortExpression="sys_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="platform_type_id" HeaderText="platform_type_id" SortExpression="platform_type_id" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
