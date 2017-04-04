<%@ Page Title="1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.SystemConfig.List" %>
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
                            
		<asp:BoundField DataField="AfterDays" HeaderText="AfterDays" SortExpression="AfterDays" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TimingDays" HeaderText="TimingDays" SortExpression="TimingDays" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Account" HeaderText="Account" SortExpression="Account" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LogPath" HeaderText="LogPath" SortExpression="LogPath" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiAmount" HeaderText="JinRiAmount" SortExpression="JinRiAmount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiBerth" HeaderText="JinRiBerth" SortExpression="JinRiBerth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiRateWay" HeaderText="JinRiRateWay" SortExpression="JinRiRateWay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiUserType" HeaderText="JinRiUserType" SortExpression="JinRiUserType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiUserName" HeaderText="JinRiUserName" SortExpression="JinRiUserName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiVOYAGE" HeaderText="JinRiVOYAGE" SortExpression="JinRiVOYAGE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ServerAddress" HeaderText="ServerAddress" SortExpression="ServerAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="JinRiTiming" HeaderText="JinRiTiming" SortExpression="JinRiTiming" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C517natime" HeaderText="C517natime" SortExpression="C517natime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C517name" HeaderText="C517name" SortExpression="C517name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C517pid" HeaderText="C517pid" SortExpression="C517pid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C517pidsafe" HeaderText="C517pidsafe" SortExpression="C517pidsafe" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Yi8000name" HeaderText="Yi8000name" SortExpression="Yi8000name" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Yi8000psword" HeaderText="Yi8000psword" SortExpression="Yi8000psword" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Yi8000distime" HeaderText="Yi8000distime" SortExpression="Yi8000distime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket380partner" HeaderText="Ticket380partner" SortExpression="Ticket380partner" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket380key" HeaderText="Ticket380key" SortExpression="Ticket380key" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket380time" HeaderText="Ticket380time" SortExpression="Ticket380time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket380timeadd" HeaderText="Ticket380timeadd" SortExpression="Ticket380timeadd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ticket380gettime" HeaderText="Ticket380gettime" SortExpression="Ticket380gettime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C51bookname" HeaderText="C51bookname" SortExpression="C51bookname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C51booktime" HeaderText="C51booktime" SortExpression="C51booktime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="C51bookyear" HeaderText="C51bookyear" SortExpression="C51bookyear" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
