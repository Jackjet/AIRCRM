<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Sanben.Web.uploadTask.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		execution_frequency
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtexecution_frequency" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		execution_time
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtexecution_time" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		upload_platFrom
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtupload_platFrom" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		policy_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpolicy_class" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		upload_class
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtupload_class" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		uploadPlatFrom_specialPolicies
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkuploadPlatFrom_specialPolicies" Text="uploadPlatFrom_specialPolicies" runat="server" Checked="False" />
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
		tripType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttripType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		execute_number
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtexecute_number" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		condition
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkcondition" Text="condition" runat="server" Checked="False" />
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
		uploadType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtuploadType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NextFullTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtNextFullTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NextAddTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtNextAddTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Uploading
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkUploading" Text="Uploading" runat="server" Checked="False" />
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
