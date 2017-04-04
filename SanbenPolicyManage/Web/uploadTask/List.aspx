<%@ Page Title="1" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.uploadTask.List" %>
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
                            
		<asp:BoundField DataField="execution_frequency" HeaderText="execution_frequency" SortExpression="execution_frequency" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="execution_time" HeaderText="execution_time" SortExpression="execution_time" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="upload_platFrom" HeaderText="upload_platFrom" SortExpression="upload_platFrom" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy_class" HeaderText="policy_class" SortExpression="policy_class" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="upload_class" HeaderText="upload_class" SortExpression="upload_class" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadPlatFrom_specialPolicies" HeaderText="uploadPlatFrom_specialPolicies" SortExpression="uploadPlatFrom_specialPolicies" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policySource" HeaderText="policySource" SortExpression="policySource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="tripType" HeaderText="tripType" SortExpression="tripType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="execute_number" HeaderText="execute_number" SortExpression="execute_number" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="condition" HeaderText="condition" SortExpression="condition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sys_id" HeaderText="sys_id" SortExpression="sys_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadType" HeaderText="uploadType" SortExpression="uploadType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NextFullTime" HeaderText="NextFullTime" SortExpression="NextFullTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NextAddTime" HeaderText="NextAddTime" SortExpression="NextAddTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Uploading" HeaderText="Uploading" SortExpression="Uploading" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
