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
namespace Sanben.Web.orderInterfaceConfig
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Sanben.BLL.orderInterfaceConfig bll=new Sanben.BLL.orderInterfaceConfig();
		Sanben.Model.orderInterfaceConfig model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblusername.Text=model.username;
		this.lblpassword.Text=model.password;
		this.lblorderAddress.Text=model.orderAddress;
		this.lblinterfaceAddress.Text=model.interfaceAddress;
		this.lblstartDate.Text=model.startDate.ToString();
		this.lblorderStatus.Text=model.orderStatus;
		this.lblisAutomaticGainOrder.Text=model.isAutomaticGainOrder?"是":"否";
		this.lblisAutomaticTicket.Text=model.isAutomaticTicket?"是":"否";
		this.lblflightCompany.Text=model.flightCompany;
		this.lblstartAirport.Text=model.startAirport;
		this.lblendAirport.Text=model.endAirport;
		this.lblmaxDeficit.Text=model.maxDeficit.ToString();
		this.lbllinkPhone.Text=model.linkPhone;
		this.lblautomaticTicketPlat.Text=model.automaticTicketPlat;
		this.lblsys_id.Text=model.sys_id.ToString();
		this.lblplatform_type_id.Text=model.platform_type_id.ToString();
		this.lblrt_user.Text=model.rt_user;
		this.lblrt_pwd.Text=model.rt_pwd;
		this.lblEtermRT.Text=model.EtermRT;
		this.lblEtermRTuser.Text=model.EtermRTuser;
		this.lblEtermRTpwd.Text=model.EtermRTpwd;

	}


    }
}
