<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Sanben.Web.Policy.Show" Title="显示页" %>
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
		flightcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflightcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicyCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dpt
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldpt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblarr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightNumLimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflightNumLimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightcondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflightcondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		daycondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldaycondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discountType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldiscountType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discountValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldiscountValue" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnpoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreturnpoint" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreturnprice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartdate_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enfdate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenfdate_ticket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstartdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenddate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		beforeValidDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbeforeValidDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbacknote" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabinnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcabinnote" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		autoTicket
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblautoTicket" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shared
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshared" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		officeno
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblofficeno" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ktype
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblktype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		checkCycleTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcheckCycleTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		autoCheckOverTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblautoCheckOverTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		manualCheckOverTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmanualCheckOverTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		downDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldownDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pata
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpata" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		specialRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblspecialRule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		allCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblallCabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		canPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcanPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		deptTimeSlot
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbldeptTimeSlot" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needPnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblneedPnr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_flightlimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_flightlimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_limitnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_limitnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_flightlimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwo_flightlimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_limitnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwo_limitnum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_daylimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_daylimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_daylimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwo_daylimit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gocabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblgocabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backcabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbackcabin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_startdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblone_enddate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwo_startdate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbltwo_enddate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		short_stoptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblshort_stoptime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		long_stoptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbllong_stoptime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		costtype
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcosttype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		costPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcostPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		proxyPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblproxyPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbackPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policySource
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblpolicySource" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xcd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblxcd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblreturnRule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changeRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblchangeRule" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endorsement
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblendorsement" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flyerpoints
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflyerpoints" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cardType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcardType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxAge
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblmaxAge" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		minAge
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblminAge" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsys_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadPolicyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadPolicyType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliestBeforeValidDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblearliestBeforeValidDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblisUpload" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		importTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblimportTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadPlat
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadPlat" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadResult
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbluploadResult" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




