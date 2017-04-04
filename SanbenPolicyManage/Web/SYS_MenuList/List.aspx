<%@ Page Title="SYS_MenuList" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.SYS_MenuList.List" %>
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
                            
		<asp:BoundField DataField="Text" HeaderText="模块ID" SortExpression="Text" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TabID" HeaderText="TabID" SortExpression="TabID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NavigateUrl" HeaderText="权限ID" SortExpression="NavigateUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ParentID" HeaderText="ParentID" SortExpression="ParentID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SingleClickExpand" HeaderText="SingleClickExpand" SortExpression="SingleClickExpand" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Icon" HeaderText="Icon" SortExpression="Icon" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsModule" HeaderText="IsModule" SortExpression="IsModule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsFuntion" HeaderText="IsFuntion" SortExpression="IsFuntion" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ordering" HeaderText="Ordering" SortExpression="Ordering" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Stop" HeaderText="Stop" SortExpression="Stop" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Version" HeaderText="Version" SortExpression="Version" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sort" HeaderText="sort" SortExpression="sort" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
