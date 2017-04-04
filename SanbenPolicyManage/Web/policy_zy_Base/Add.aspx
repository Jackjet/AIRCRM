<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.policy_zy_Base.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		leavepoint
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtleavepoint" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leavemoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtleavemoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_filter
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_filter" Text="is_filter" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		starttime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtstarttime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		endtime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtendtime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlowest_rebate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_rebate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthighest_rebate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		earliest_advance_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtearliest_advance_days" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		night_before_days
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnight_before_days" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		pointSetType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpointSetType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadfirstclass
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisuploadfirstclass" Text="isuploadfirstclass" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadchildclass
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisuploadchildclass" Text="isuploadchildclass" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NFDpolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkNFDpolicy" Text="NFDpolicy" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flylimittime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflylimittime" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platfromPolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplatfromPolicy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GWpolicy
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGWpolicy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadway
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkuploadway" Text="uploadway" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isuploadsharefight
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisuploadsharefight" Text="isuploadsharefight" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addpricejisuan
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkaddpricejisuan" Text="addpricejisuan" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addpriceCovertType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtaddpriceCovertType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		addPriceSet
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtaddPriceSet" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		limitSit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlimitSit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		saleSit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsaleSit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_autoticket
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_autoticket" Text="is_autoticket" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_Need
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_Need" Text="is_Need" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isMail
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtisMail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		isPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkisPay" Text="isPay" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AuthorizeOffice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAuthorizeOffice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		refund_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtrefund_rule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		changedate_rule
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtchangedate_rule" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_allowed_sign
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_allowed_sign" Text="is_allowed_sign" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		is_provide_regular_passenger_integral
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkis_provide_regular_passenger_integral" Text="is_provide_regular_passenger_integral" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		document_type
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtdocument_type" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		maxage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtmaxage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		minage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtminage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		class_description
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtclass_description" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		special_ticketing_instructions
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtspecial_ticketing_instructions" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lowest_price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtlowest_price" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		highest_price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthighest_price" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		lastupdatetime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtlastupdatetime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sysuser_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtsysuser_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		platform_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtplatform_id" runat="server" Width="200px"></asp:TextBox>
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
