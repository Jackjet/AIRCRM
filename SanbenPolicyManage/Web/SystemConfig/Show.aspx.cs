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
namespace Sanben.Web.SystemConfig
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Sanben.BLL.SystemConfig bll=new Sanben.BLL.SystemConfig();
		Sanben.Model.SystemConfig model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblAfterDays.Text=model.AfterDays;
		this.lblTimingDays.Text=model.TimingDays.ToString();
		this.lblAccount.Text=model.Account;
		this.lblLogPath.Text=model.LogPath;
		this.lblJinRiAmount.Text=model.JinRiAmount.ToString();
		this.lblJinRiBerth.Text=model.JinRiBerth;
		this.lblJinRiRateWay.Text=model.JinRiRateWay;
		this.lblJinRiUserType.Text=model.JinRiUserType;
		this.lblJinRiUserName.Text=model.JinRiUserName;
		this.lblJinRiVOYAGE.Text=model.JinRiVOYAGE;
		this.lblServerAddress.Text=model.ServerAddress;
		this.lblJinRiTiming.Text=model.JinRiTiming.ToString();
		this.lblC517natime.Text=model.C517natime.ToString();
		this.lblC517name.Text=model.C517name;
		this.lblC517pid.Text=model.C517pid;
		this.lblC517pidsafe.Text=model.C517pidsafe;
		this.lblYi8000name.Text=model.Yi8000name;
		this.lblYi8000psword.Text=model.Yi8000psword;
		this.lblYi8000distime.Text=model.Yi8000distime.ToString();
		this.lblTicket380partner.Text=model.Ticket380partner;
		this.lblTicket380key.Text=model.Ticket380key;
		this.lblTicket380time.Text=model.Ticket380time.ToString();
		this.lblTicket380timeadd.Text=model.Ticket380timeadd.ToString();
		this.lblTicket380gettime.Text=model.Ticket380gettime;
		this.lblC51bookname.Text=model.C51bookname;
		this.lblC51booktime.Text=model.C51booktime.ToString();
		this.lblC51bookyear.Text=model.C51bookyear.ToString();

	}


    }
}
