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
namespace Sanben.Web.517NaBenefit
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		Sanben.BLL.517NaBenefit bll=new Sanben.BLL.517NaBenefit();
		Sanben.Model.517NaBenefit model=bll.GetModel();
		this.lblID.Text=model.ID.ToString();
		this.lblPolicyNum.Text=model.PolicyNum;
		this.lblAirline.Text=model.Airline;
		this.lblScity.Text=model.Scity;
		this.lblAcity.Text=model.Acity;
		this.lblAirType.Text=model.AirType;
		this.lblFlight.Text=model.Flight;
		this.lblCabin.Text=model.Cabin;
		this.lblTripType.Text=model.TripType;
		this.lblPolicyType.Text=model.PolicyType;
		this.lblPolicyPoint.Text=model.PolicyPoint;
		this.lblScheduleRestr.Text=model.ScheduleRestr;
		this.lblTicketCondition.Text=model.TicketCondition;
		this.lblAvaDate.Text=model.AvaDate;
		this.lblEndDate.Text=model.EndDate;
		this.lblSupplierTimeDay.Text=model.SupplierTimeDay;
		this.lblSupplierTimeWeek.Text=model.SupplierTimeWeek;
		this.lblIsSpeciPolicy.Text=model.IsSpeciPolicy;
		this.lblIsChange.Text=model.IsChange;
		this.lblChildPolicyNum.Text=model.ChildPolicyNum;
		this.lblPayPrice.Text=model.PayPrice;
		this.lblTicket.Text=model.Ticket;
		this.lblAirrax.Text=model.Airrax;
		this.lblFuel.Text=model.Fuel;
		this.lblSupplierDelDay.Text=model.SupplierDelDay;
		this.lblSupplierDelWeek.Text=model.SupplierDelWeek;
		this.lblTicketEffic.Text=model.TicketEffic;
		this.lblUpgradeChange.Text=model.UpgradeChange;
		this.lblOfficeCode.Text=model.OfficeCode;
		this.lblAddTime.Text=model.AddTime.ToString();
		this.lblIsUpload.Text=model.IsUpload?"是":"否";
		this.lblIsUpdate.Text=model.IsUpdate?"是":"否";

	}


    }
}
