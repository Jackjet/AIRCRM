<%@ Page Title="policy_zy_Base" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.policy_zy_Base.List" %>
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
                            
		<asp:BoundField DataField="leavepoint" HeaderText="leavepoint" SortExpression="leavepoint" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="leavemoney" HeaderText="leavemoney" SortExpression="leavemoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_filter" HeaderText="is_filter" SortExpression="is_filter" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="starttime" HeaderText="starttime" SortExpression="starttime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="endtime" HeaderText="endtime" SortExpression="endtime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lowest_rebate" HeaderText="lowest_rebate" SortExpression="lowest_rebate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="highest_rebate" HeaderText="highest_rebate" SortExpression="highest_rebate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="earliest_advance_days" HeaderText="earliest_advance_days" SortExpression="earliest_advance_days" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="night_before_days" HeaderText="night_before_days" SortExpression="night_before_days" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pointSetType" HeaderText="pointSetType" SortExpression="pointSetType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isuploadfirstclass" HeaderText="isuploadfirstclass" SortExpression="isuploadfirstclass" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isuploadchildclass" HeaderText="isuploadchildclass" SortExpression="isuploadchildclass" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NFDpolicy" HeaderText="NFDpolicy" SortExpression="NFDpolicy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="flylimittime" HeaderText="flylimittime" SortExpression="flylimittime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="platfromPolicy" HeaderText="platfromPolicy" SortExpression="platfromPolicy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GWpolicy" HeaderText="GWpolicy" SortExpression="GWpolicy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadway" HeaderText="uploadway" SortExpression="uploadway" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isuploadsharefight" HeaderText="isuploadsharefight" SortExpression="isuploadsharefight" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addpricejisuan" HeaderText="addpricejisuan" SortExpression="addpricejisuan" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addpriceCovertType" HeaderText="addpriceCovertType" SortExpression="addpriceCovertType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="addPriceSet" HeaderText="addPriceSet" SortExpression="addPriceSet" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="limitSit" HeaderText="limitSit" SortExpression="limitSit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="saleSit" HeaderText="saleSit" SortExpression="saleSit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_autoticket" HeaderText="is_autoticket" SortExpression="is_autoticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_Need" HeaderText="is_Need" SortExpression="is_Need" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isMail" HeaderText="isMail" SortExpression="isMail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isPay" HeaderText="isPay" SortExpression="isPay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AuthorizeOffice" HeaderText="AuthorizeOffice" SortExpression="AuthorizeOffice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="refund_rule" HeaderText="refund_rule" SortExpression="refund_rule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="changedate_rule" HeaderText="changedate_rule" SortExpression="changedate_rule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_allowed_sign" HeaderText="is_allowed_sign" SortExpression="is_allowed_sign" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="is_provide_regular_passenger_integral" HeaderText="is_provide_regular_passenger_integral" SortExpression="is_provide_regular_passenger_integral" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="document_type" HeaderText="document_type" SortExpression="document_type" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="maxage" HeaderText="maxage" SortExpression="maxage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="minage" HeaderText="minage" SortExpression="minage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="class_description" HeaderText="class_description" SortExpression="class_description" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="special_ticketing_instructions" HeaderText="special_ticketing_instructions" SortExpression="special_ticketing_instructions" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lowest_price" HeaderText="lowest_price" SortExpression="lowest_price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="highest_price" HeaderText="highest_price" SortExpression="highest_price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lastupdatetime" HeaderText="lastupdatetime" SortExpression="lastupdatetime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sysuser_id" HeaderText="sysuser_id" SortExpression="sysuser_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="platform_id" HeaderText="platform_id" SortExpression="platform_id" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
