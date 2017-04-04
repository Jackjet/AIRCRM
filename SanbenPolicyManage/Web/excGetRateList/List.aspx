<%@ Page Title="excGetRateList" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.excGetRateList.List" %>
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
                            
		<asp:BoundField DataField="PolicyId" HeaderText="PolicyId" SortExpression="PolicyId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RateId" HeaderText="RateId" SortExpression="RateId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ScityE" HeaderText="ScityE" SortExpression="ScityE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EcityE" HeaderText="EcityE" SortExpression="EcityE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AirComE" HeaderText="AirComE" SortExpression="AirComE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NoAirComE" HeaderText="NoAirComE" SortExpression="NoAirComE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PolicyType" HeaderText="PolicyType" SortExpression="PolicyType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Cabin" HeaderText="Cabin" SortExpression="Cabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="VoyageType" HeaderText="VoyageType" SortExpression="VoyageType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserType" HeaderText="UserType" SortExpression="UserType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RateType" HeaderText="RateType" SortExpression="RateType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Discounts" HeaderText="Discounts" SortExpression="Discounts" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sdate" HeaderText="Sdate" SortExpression="Sdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Edate" HeaderText="Edate" SortExpression="Edate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkTimBegin" HeaderText="WorkTimBegin" SortExpression="WorkTimBegin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkTImeEnd" HeaderText="WorkTImeEnd" SortExpression="WorkTImeEnd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Rewards" HeaderText="Rewards" SortExpression="Rewards" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ET" HeaderText="ET" SortExpression="ET" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WP" HeaderText="WP" SortExpression="WP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SP" HeaderText="SP" SortExpression="SP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="XF" HeaderText="XF" SortExpression="XF" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PromotionDiscount" HeaderText="PromotionDiscount" SortExpression="PromotionDiscount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NewRateNo" HeaderText="NewRateNo" SortExpression="NewRateNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OfficeNum" HeaderText="OfficeNum" SortExpression="OfficeNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RefundTimeBegin" HeaderText="RefundTimeBegin" SortExpression="RefundTimeBegin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RefundTimeEnd" HeaderText="RefundTimeEnd" SortExpression="RefundTimeEnd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastModifyTime" HeaderText="LastModifyTime" SortExpression="LastModifyTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LimitModels" HeaderText="LimitModels" SortExpression="LimitModels" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RefundRulesWay" HeaderText="RefundRulesWay" SortExpression="RefundRulesWay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TPRemark" HeaderText="TPRemark" SortExpression="TPRemark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ChangeMsg" HeaderText="ChangeMsg" SortExpression="ChangeMsg" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvalidMsg" HeaderText="InvalidMsg" SortExpression="InvalidMsg" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RiseCabin" HeaderText="RiseCabin" SortExpression="RiseCabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ForeignMsg" HeaderText="ForeignMsg" SortExpression="ForeignMsg" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OutTicketPercent" HeaderText="OutTicketPercent" SortExpression="OutTicketPercent" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceMsg" HeaderText="InvoiceMsg" SortExpression="InvoiceMsg" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PrintInvoice" HeaderText="PrintInvoice" SortExpression="PrintInvoice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SwitchPNR" HeaderText="SwitchPNR" SortExpression="SwitchPNR" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Change" HeaderText="Change" SortExpression="Change" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sed" HeaderText="sed" SortExpression="sed" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PlatForm" HeaderText="PlatForm" SortExpression="PlatForm" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddTime" HeaderText="AddTime" SortExpression="AddTime" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
