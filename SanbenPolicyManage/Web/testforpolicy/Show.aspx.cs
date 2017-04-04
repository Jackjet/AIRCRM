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
namespace Sanben.Web.testforpolicy
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
		Sanben.BLL.testforpolicy bll=new Sanben.BLL.testforpolicy();
		Sanben.Model.testforpolicy model=bll.GetModel();
		this.lblID.Text=model.ID.ToString();
		this.lblDate.Text=model.Date;
		this.lblFrom_Code.Text=model.From_Code;
		this.lblTo_Code.Text=model.To_Code;
		this.lblStartCity.Text=model.StartCity;
		this.lblArriveCity.Text=model.ArriveCity;
		this.lblMileage.Text=model.Mileage.ToString();
		this.lblFule_Adult.Text=model.Fule_Adult.ToString();
		this.lblFule_Child.Text=model.Fule_Child.ToString();
		this.lblLine_Number.Text=model.Line_Number;
		this.lblShare_Line.Text=model.Share_Line;
		this.lblCompany.Text=model.Company;
		this.lblStartCode.Text=model.StartCode;
		this.lblStartAirport.Text=model.StartAirport;
		this.lblArriveCode.Text=model.ArriveCode;
		this.lblArriveAirport.Text=model.ArriveAirport;
		this.lblStartTime.Text=model.StartTime;
		this.lblArriveTime.Text=model.ArriveTime;
		this.lblAirRax.Text=model.AirRax.ToString();
		this.lblFuleRax.Text=model.FuleRax.ToString();
		this.lblFuelAdu.Text=model.FuelAdu.ToString();
		this.lblFuelChd.Text=model.FuelChd.ToString();
		this.lblFood.Text=model.Food.ToString();
		this.lblFood_Detail.Text=model.Food_Detail;
		this.lblDirect_Flight.Text=model.Direct_Flight.ToString();
		this.lblType.Text=model.Type;
		this.lblElectronic_Ticket.Text=model.Electronic_Ticket.ToString();
		this.lblStart_Terminal.Text=model.Start_Terminal;
		this.lblArrive_Terminal.Text=model.Arrive_Terminal;
		this.lblCabin.Text=model.Cabin;
		this.lblChildCabin.Text=model.ChildCabin.ToString();
		this.lblDiscount.Text=model.Discount;
		this.lblPrice.Text=model.Price.ToString();
		this.lblSurplus_Seat_Qty.Text=model.Surplus_Seat_Qty;
		this.lblCabin_Status.Text=model.Cabin_Status;
		this.lblCabin_Point.Text=model.Cabin_Point;
		this.lblValidity_Period.Text=model.Validity_Period;
		this.lblReturn_Date.Text=model.Return_Date;
		this.lblValid_Date.Text=model.Valid_Date;
		this.lblAddTime.Text=model.AddTime.ToString();
		this.lblFlag.Text=model.Flag.ToString();

	}


    }
}
