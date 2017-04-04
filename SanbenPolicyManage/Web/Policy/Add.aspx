<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.Policy.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		flightcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflightcode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicyCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		dpt
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdpt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		arr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtarr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightNumLimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflightNumLimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flightcondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflightcondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		daycondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdaycondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discountType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdiscountType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		discountValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdiscountValue" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnpoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtreturnpoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnprice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtreturnprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartdate_ticket" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enfdate_ticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtenfdate_ticket" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstartdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtenddate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		beforeValidDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbeforeValidDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbacknote" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cabinnote
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcabinnote" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		autoTicket
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkautoTicket" Text="autoTicket" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		shared
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkshared" Text="shared" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		officeno
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtofficeno" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ktype
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtktype" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		checkCycleTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcheckCycleTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		autoCheckOverTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtautoCheckOverTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		manualCheckOverTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmanualCheckOverTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		downDiscount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdownDiscount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pata
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkpata" Text="pata" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		specialRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspecialRule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		allCabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtallCabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		canPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkcanPay" Text="canPay" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		deptTimeSlot
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdeptTimeSlot" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needPnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkneedPnr" Text="needPnr" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_flightlimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_flightlimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_limitnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_limitnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_flightlimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwo_flightlimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_limitnum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwo_limitnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_daylimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_daylimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_daylimit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwo_daylimit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		gocabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtgocabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backcabin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbackcabin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_startdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		one_enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtone_enddate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_startdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwo_startdate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		two_enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttwo_enddate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		short_stoptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtshort_stoptime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		long_stoptime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlong_stoptime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		costtype
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcosttype" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		costPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcostPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		proxyPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtproxyPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		backPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbackPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policySource
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicySource" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xcd
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtxcd" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		returnRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtreturnRule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changeRule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchangeRule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endorsement
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkendorsement" Text="endorsement" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flyerpoints
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkflyerpoints" Text="flyerpoints" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cardType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcardType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxAge
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmaxAge" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		minAge
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtminAge" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sys_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsys_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadPolicyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuploadPolicyType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliestBeforeValidDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtearliestBeforeValidDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtisUpload" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		importTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtimportTime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadPlat
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuploadPlat" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadResult
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuploadResult" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
