<%@ Page Title="OrderInfo2" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.OrderInfo2.List" %>
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
                    BorderWidth="1px" DataKeyNames="pk_id" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="orderNo" HeaderText="orderNo" SortExpression="orderNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="allPrice" HeaderText="allPrice" SortExpression="allPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="noPay" HeaderText="noPay" SortExpression="noPay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="childPrintPrice" HeaderText="childPrintPrice" SortExpression="childPrintPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="childFaceValue" HeaderText="childFaceValue" SortExpression="childFaceValue" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="source" HeaderText="source" SortExpression="source" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policySource" HeaderText="policySource" SortExpression="policySource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ticketMode" HeaderText="ticketMode" SortExpression="ticketMode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policyFriendly" HeaderText="policyFriendly" SortExpression="policyFriendly" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="payChannel" HeaderText="payChannel" SortExpression="payChannel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="payStatus" HeaderText="payStatus" SortExpression="payStatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="insuranceUnitPrice" HeaderText="insuranceUnitPrice" SortExpression="insuranceUnitPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="backnote" HeaderText="backnote" SortExpression="backnote" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="insuranceCuttingPrice" HeaderText="insuranceCuttingPrice" SortExpression="insuranceCuttingPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cabinnote" HeaderText="cabinnote" SortExpression="cabinnote" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="xcdPrice" HeaderText="xcdPrice" SortExpression="xcdPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="xcd" HeaderText="xcd" SortExpression="xcd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sjr" HeaderText="sjr" SortExpression="sjr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="contactTel" HeaderText="contactTel" SortExpression="contactTel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="address" HeaderText="address" SortExpression="address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="company" HeaderText="company" SortExpression="company" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="expType" HeaderText="expType" SortExpression="expType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ordernumber" HeaderText="ordernumber" SortExpression="ordernumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sendtime" HeaderText="sendtime" SortExpression="sendtime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="viewPrice" HeaderText="viewPrice" SortExpression="viewPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="price" HeaderText="price" SortExpression="price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pnr" HeaderText="pnr" SortExpression="pnr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cpnr" HeaderText="cpnr" SortExpression="cpnr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pnrText" HeaderText="pnrText" SortExpression="pnrText" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="childPnrText" HeaderText="childPnrText" SortExpression="childPnrText" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pataText" HeaderText="pataText" SortExpression="pataText" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="childPataText" HeaderText="childPataText" SortExpression="childPataText" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="constructionFee" HeaderText="constructionFee" SortExpression="constructionFee" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="fuelTax" HeaderText="fuelTax" SortExpression="fuelTax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="childFuelTax" HeaderText="childFuelTax" SortExpression="childFuelTax" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policyType" HeaderText="policyType" SortExpression="policyType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="status" HeaderText="status" SortExpression="status" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="contactMob" HeaderText="contactMob" SortExpression="contactMob" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="contactEmail" HeaderText="contactEmail" SortExpression="contactEmail" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="createTime" HeaderText="createTime" SortExpression="createTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="needPS" HeaderText="needPS" SortExpression="needPS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="username" HeaderText="username" SortExpression="username" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="orderFrom" HeaderText="orderFrom" SortExpression="orderFrom" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="lockStatus" HeaderText="lockStatus" SortExpression="lockStatus" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="updateTime" HeaderText="updateTime" SortExpression="updateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="userid" HeaderText="userid" SortExpression="userid" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="orderDesc" HeaderText="orderDesc" SortExpression="orderDesc" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="pk_id" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="pk_id" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
