using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Sanben.Web.orderInterfaceConfig
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Sanben.BLL.orderInterfaceConfig bll=new Sanben.BLL.orderInterfaceConfig();
		Sanben.Model.orderInterfaceConfig model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtusername.Text=model.username;
		this.txtpassword.Text=model.password;
		this.txtorderAddress.Text=model.orderAddress;
		this.txtinterfaceAddress.Text=model.interfaceAddress;
		this.txtstartDate.Text=model.startDate.ToString();
		this.txtorderStatus.Text=model.orderStatus;
		this.chkisAutomaticGainOrder.Checked=model.isAutomaticGainOrder;
		this.chkisAutomaticTicket.Checked=model.isAutomaticTicket;
		this.txtflightCompany.Text=model.flightCompany;
		this.txtstartAirport.Text=model.startAirport;
		this.txtendAirport.Text=model.endAirport;
		this.txtmaxDeficit.Text=model.maxDeficit.ToString();
		this.txtlinkPhone.Text=model.linkPhone;
		this.txtautomaticTicketPlat.Text=model.automaticTicketPlat;
		this.txtsys_id.Text=model.sys_id.ToString();
		this.txtplatform_type_id.Text=model.platform_type_id.ToString();
		this.txtrt_user.Text=model.rt_user;
		this.txtrt_pwd.Text=model.rt_pwd;
		this.txtEtermRT.Text=model.EtermRT;
		this.txtEtermRTuser.Text=model.EtermRTuser;
		this.txtEtermRTpwd.Text=model.EtermRTpwd;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(this.txtorderAddress.Text.Trim().Length==0)
			{
				strErr+="orderAddress不能为空！\\n";	
			}
			if(this.txtinterfaceAddress.Text.Trim().Length==0)
			{
				strErr+="interfaceAddress不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartDate.Text))
			{
				strErr+="startDate格式错误！\\n";	
			}
			if(this.txtorderStatus.Text.Trim().Length==0)
			{
				strErr+="orderStatus不能为空！\\n";	
			}
			if(this.txtflightCompany.Text.Trim().Length==0)
			{
				strErr+="flightCompany不能为空！\\n";	
			}
			if(this.txtstartAirport.Text.Trim().Length==0)
			{
				strErr+="startAirport不能为空！\\n";	
			}
			if(this.txtendAirport.Text.Trim().Length==0)
			{
				strErr+="endAirport不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtmaxDeficit.Text))
			{
				strErr+="maxDeficit格式错误！\\n";	
			}
			if(this.txtlinkPhone.Text.Trim().Length==0)
			{
				strErr+="linkPhone不能为空！\\n";	
			}
			if(this.txtautomaticTicketPlat.Text.Trim().Length==0)
			{
				strErr+="automaticTicketPlat不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_type_id.Text))
			{
				strErr+="platform_type_id格式错误！\\n";	
			}
			if(this.txtrt_user.Text.Trim().Length==0)
			{
				strErr+="rt_user不能为空！\\n";	
			}
			if(this.txtrt_pwd.Text.Trim().Length==0)
			{
				strErr+="rt_pwd不能为空！\\n";	
			}
			if(this.txtEtermRT.Text.Trim().Length==0)
			{
				strErr+="EtermRT不能为空！\\n";	
			}
			if(this.txtEtermRTuser.Text.Trim().Length==0)
			{
				strErr+="EtermRTuser不能为空！\\n";	
			}
			if(this.txtEtermRTpwd.Text.Trim().Length==0)
			{
				strErr+="EtermRTpwd不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			string orderAddress=this.txtorderAddress.Text;
			string interfaceAddress=this.txtinterfaceAddress.Text;
			DateTime startDate=DateTime.Parse(this.txtstartDate.Text);
			string orderStatus=this.txtorderStatus.Text;
			bool isAutomaticGainOrder=this.chkisAutomaticGainOrder.Checked;
			bool isAutomaticTicket=this.chkisAutomaticTicket.Checked;
			string flightCompany=this.txtflightCompany.Text;
			string startAirport=this.txtstartAirport.Text;
			string endAirport=this.txtendAirport.Text;
			decimal maxDeficit=decimal.Parse(this.txtmaxDeficit.Text);
			string linkPhone=this.txtlinkPhone.Text;
			string automaticTicketPlat=this.txtautomaticTicketPlat.Text;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);
			string rt_user=this.txtrt_user.Text;
			string rt_pwd=this.txtrt_pwd.Text;
			string EtermRT=this.txtEtermRT.Text;
			string EtermRTuser=this.txtEtermRTuser.Text;
			string EtermRTpwd=this.txtEtermRTpwd.Text;


			Sanben.Model.orderInterfaceConfig model=new Sanben.Model.orderInterfaceConfig();
			model.id=id;
			model.username=username;
			model.password=password;
			model.orderAddress=orderAddress;
			model.interfaceAddress=interfaceAddress;
			model.startDate=startDate;
			model.orderStatus=orderStatus;
			model.isAutomaticGainOrder=isAutomaticGainOrder;
			model.isAutomaticTicket=isAutomaticTicket;
			model.flightCompany=flightCompany;
			model.startAirport=startAirport;
			model.endAirport=endAirport;
			model.maxDeficit=maxDeficit;
			model.linkPhone=linkPhone;
			model.automaticTicketPlat=automaticTicketPlat;
			model.sys_id=sys_id;
			model.platform_type_id=platform_type_id;
			model.rt_user=rt_user;
			model.rt_pwd=rt_pwd;
			model.EtermRT=EtermRT;
			model.EtermRTuser=EtermRTuser;
			model.EtermRTpwd=EtermRTpwd;

			Sanben.BLL.orderInterfaceConfig bll=new Sanben.BLL.orderInterfaceConfig();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
