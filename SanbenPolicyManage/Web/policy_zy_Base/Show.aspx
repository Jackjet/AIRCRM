<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.policy_zy_Base.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leavepoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleavepoint" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leavemoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleavemoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_filter
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_filter" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		starttime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstarttime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblendtime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllowest_rebate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhighest_rebate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliest_advance_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblearliest_advance_days" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		night_before_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblnight_before_days" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pointSetType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpointSetType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadfirstclass
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisuploadfirstclass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadchildclass
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisuploadchildclass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NFDpolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNFDpolicy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flylimittime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflylimittime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platfromPolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatfromPolicy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GWpolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGWpolicy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadway
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadway" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadsharefight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisuploadsharefight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addpricejisuan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdpricejisuan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addpriceCovertType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdpriceCovertType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addPriceSet
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbladdPriceSet" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		limitSit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllimitSit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		saleSit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsaleSit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_autoticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_autoticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_Need
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_Need" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isMail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisMail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AuthorizeOffice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAuthorizeOffice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblrefund_rule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changedate_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchangedate_rule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_allowed_sign
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_allowed_sign" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_provide_regular_passenger_integral
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblis_provide_regular_passenger_integral" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		document_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldocument_type" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmaxage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		minage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblminage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		class_description
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblclass_description" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		special_ticketing_instructions
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblspecial_ticketing_instructions" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllowest_price" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhighest_price" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lastupdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllastupdatetime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sysuser_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsysuser_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblplatform_id" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




