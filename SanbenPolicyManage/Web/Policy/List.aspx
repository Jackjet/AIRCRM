<%@ Page Title="Policy" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Sanben.Web.Policy.List" %>
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
                            
		<asp:BoundField DataField="flightcode" HeaderText="flightcode" SortExpression="flightcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policyCode" HeaderText="policyCode" SortExpression="policyCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="dpt" HeaderText="dpt" SortExpression="dpt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="arr" HeaderText="arr" SortExpression="arr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="flightNumLimit" HeaderText="flightNumLimit" SortExpression="flightNumLimit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="flightcondition" HeaderText="flightcondition" SortExpression="flightcondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="daycondition" HeaderText="daycondition" SortExpression="daycondition" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cabin" HeaderText="cabin" SortExpression="cabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="discountType" HeaderText="discountType" SortExpression="discountType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="discountValue" HeaderText="discountValue" SortExpression="discountValue" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="returnpoint" HeaderText="returnpoint" SortExpression="returnpoint" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="returnprice" HeaderText="returnprice" SortExpression="returnprice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="startdate_ticket" HeaderText="startdate_ticket" SortExpression="startdate_ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="enfdate_ticket" HeaderText="enfdate_ticket" SortExpression="enfdate_ticket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="startdate" HeaderText="startdate" SortExpression="startdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="enddate" HeaderText="enddate" SortExpression="enddate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="beforeValidDay" HeaderText="beforeValidDay" SortExpression="beforeValidDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="backnote" HeaderText="backnote" SortExpression="backnote" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cabinnote" HeaderText="cabinnote" SortExpression="cabinnote" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="autoTicket" HeaderText="autoTicket" SortExpression="autoTicket" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="shared" HeaderText="shared" SortExpression="shared" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="officeno" HeaderText="officeno" SortExpression="officeno" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ktype" HeaderText="ktype" SortExpression="ktype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="checkCycleTime" HeaderText="checkCycleTime" SortExpression="checkCycleTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="autoCheckOverTime" HeaderText="autoCheckOverTime" SortExpression="autoCheckOverTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="manualCheckOverTime" HeaderText="manualCheckOverTime" SortExpression="manualCheckOverTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policy" HeaderText="policy" SortExpression="policy" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="downDiscount" HeaderText="downDiscount" SortExpression="downDiscount" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="pata" HeaderText="pata" SortExpression="pata" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="specialRule" HeaderText="specialRule" SortExpression="specialRule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="allCabin" HeaderText="allCabin" SortExpression="allCabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="canPay" HeaderText="canPay" SortExpression="canPay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="deptTimeSlot" HeaderText="deptTimeSlot" SortExpression="deptTimeSlot" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="needPnr" HeaderText="needPnr" SortExpression="needPnr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_flightlimit" HeaderText="one_flightlimit" SortExpression="one_flightlimit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_limitnum" HeaderText="one_limitnum" SortExpression="one_limitnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="two_flightlimit" HeaderText="two_flightlimit" SortExpression="two_flightlimit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="two_limitnum" HeaderText="two_limitnum" SortExpression="two_limitnum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_daylimit" HeaderText="one_daylimit" SortExpression="one_daylimit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="two_daylimit" HeaderText="two_daylimit" SortExpression="two_daylimit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="gocabin" HeaderText="gocabin" SortExpression="gocabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="backcabin" HeaderText="backcabin" SortExpression="backcabin" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_startdate" HeaderText="one_startdate" SortExpression="one_startdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="one_enddate" HeaderText="one_enddate" SortExpression="one_enddate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="two_startdate" HeaderText="two_startdate" SortExpression="two_startdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="two_enddate" HeaderText="two_enddate" SortExpression="two_enddate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="short_stoptime" HeaderText="short_stoptime" SortExpression="short_stoptime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="long_stoptime" HeaderText="long_stoptime" SortExpression="long_stoptime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="costtype" HeaderText="costtype" SortExpression="costtype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="costPrice" HeaderText="costPrice" SortExpression="costPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="proxyPrice" HeaderText="proxyPrice" SortExpression="proxyPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="backPrice" HeaderText="backPrice" SortExpression="backPrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="policySource" HeaderText="policySource" SortExpression="policySource" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="xcd" HeaderText="xcd" SortExpression="xcd" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="returnRule" HeaderText="returnRule" SortExpression="returnRule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="changeRule" HeaderText="changeRule" SortExpression="changeRule" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="endorsement" HeaderText="endorsement" SortExpression="endorsement" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="flyerpoints" HeaderText="flyerpoints" SortExpression="flyerpoints" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="cardType" HeaderText="cardType" SortExpression="cardType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="maxAge" HeaderText="maxAge" SortExpression="maxAge" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="minAge" HeaderText="minAge" SortExpression="minAge" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="sys_id" HeaderText="sys_id" SortExpression="sys_id" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadPolicyType" HeaderText="uploadPolicyType" SortExpression="uploadPolicyType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="earliestBeforeValidDay" HeaderText="earliestBeforeValidDay" SortExpression="earliestBeforeValidDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="isUpload" HeaderText="isUpload" SortExpression="isUpload" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="importTime" HeaderText="importTime" SortExpression="importTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadPlat" HeaderText="uploadPlat" SortExpression="uploadPlat" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="uploadResult" HeaderText="uploadResult" SortExpression="uploadResult" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
