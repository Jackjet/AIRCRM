<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.OrderInfo2.Add" Title="增加页" %>

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
		<asp:TextBox id="txtid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		allPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtallPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		noPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnoPay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPrintPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildPrintPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childFaceValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildFaceValue" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		source
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsource" runat="server" Width="200px"></asp:TextBox>
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
		ticketMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtticketMode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyFriendly
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicyFriendly" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payChannel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpayChannel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		payStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpayStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		insuranceUnitPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtinsuranceUnitPrice" runat="server" Width="200px"></asp:TextBox>
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
		insuranceCuttingPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtinsuranceCuttingPrice" runat="server" Width="200px"></asp:TextBox>
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
		xcdPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtxcdPrice" runat="server" Width="200px"></asp:TextBox>
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
		sjr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsjr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactTel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontactTel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		address
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtaddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		company
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcompany" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		expType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtexpType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ordernumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtordernumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sendtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsendtime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		viewPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtviewPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtprice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpnr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		cpnr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcpnr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pnrText
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpnrText" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPnrText
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildPnrText" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pataText
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpataText" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childPataText
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildPataText" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		constructionFee
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtconstructionFee" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		fuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfuelTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		childFuelTax
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchildFuelTax" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policyType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicyType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		status
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contact
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontact" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactMob
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontactMob" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		contactEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontactEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		createTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtcreateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		needPS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtneedPS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		username
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtusername" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderFrom
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderFrom" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lockStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlockStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		updateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtupdateTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		userid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuserid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		orderDesc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtorderDesc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
