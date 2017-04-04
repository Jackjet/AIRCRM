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
namespace Sanben.Web.Airport_Detail
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDate.Text.Trim().Length==0)
			{
				strErr+="Date不能为空！\\n";	
			}
			if(this.txtFrom_Code.Text.Trim().Length==0)
			{
				strErr+="From_Code不能为空！\\n";	
			}
			if(this.txtTo_Code.Text.Trim().Length==0)
			{
				strErr+="To_Code不能为空！\\n";	
			}
			if(this.txtStartCity.Text.Trim().Length==0)
			{
				strErr+="StartCity不能为空！\\n";	
			}
			if(this.txtArriveCity.Text.Trim().Length==0)
			{
				strErr+="ArriveCity不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMileage.Text))
			{
				strErr+="Mileage格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFule_Adult.Text))
			{
				strErr+="Fule_Adult格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFule_Child.Text))
			{
				strErr+="Fule_Child格式错误！\\n";	
			}
			if(this.txtLine_Number.Text.Trim().Length==0)
			{
				strErr+="Line_Number不能为空！\\n";	
			}
			if(this.txtShare_Line.Text.Trim().Length==0)
			{
				strErr+="Share_Line不能为空！\\n";	
			}
			if(this.txtCompany.Text.Trim().Length==0)
			{
				strErr+="Company不能为空！\\n";	
			}
			if(this.txtStartCode.Text.Trim().Length==0)
			{
				strErr+="StartCode不能为空！\\n";	
			}
			if(this.txtStartAirport.Text.Trim().Length==0)
			{
				strErr+="StartAirport不能为空！\\n";	
			}
			if(this.txtArriveCode.Text.Trim().Length==0)
			{
				strErr+="ArriveCode不能为空！\\n";	
			}
			if(this.txtArriveAirport.Text.Trim().Length==0)
			{
				strErr+="ArriveAirport不能为空！\\n";	
			}
			if(this.txtStartTime.Text.Trim().Length==0)
			{
				strErr+="StartTime不能为空！\\n";	
			}
			if(this.txtArriveTime.Text.Trim().Length==0)
			{
				strErr+="ArriveTime不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAirRax.Text))
			{
				strErr+="AirRax格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuleRax.Text))
			{
				strErr+="FuleRax格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuelAdu.Text))
			{
				strErr+="FuelAdu格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFuelChd.Text))
			{
				strErr+="FuelChd格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtFood.Text))
			{
				strErr+="Food格式错误！\\n";	
			}
			if(this.txtFood_Detail.Text.Trim().Length==0)
			{
				strErr+="Food_Detail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtDirect_Flight.Text))
			{
				strErr+="Direct_Flight格式错误！\\n";	
			}
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtElectronic_Ticket.Text))
			{
				strErr+="Electronic_Ticket格式错误！\\n";	
			}
			if(this.txtStart_Terminal.Text.Trim().Length==0)
			{
				strErr+="Start_Terminal不能为空！\\n";	
			}
			if(this.txtArrive_Terminal.Text.Trim().Length==0)
			{
				strErr+="Arrive_Terminal不能为空！\\n";	
			}
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtChildCabin.Text))
			{
				strErr+="ChildCabin格式错误！\\n";	
			}
			if(this.txtDiscount.Text.Trim().Length==0)
			{
				strErr+="Discount不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(this.txtSurplus_Seat_Qty.Text.Trim().Length==0)
			{
				strErr+="Surplus_Seat_Qty不能为空！\\n";	
			}
			if(this.txtCabin_Status.Text.Trim().Length==0)
			{
				strErr+="Cabin_Status不能为空！\\n";	
			}
			if(this.txtCabin_Point.Text.Trim().Length==0)
			{
				strErr+="Cabin_Point不能为空！\\n";	
			}
			if(this.txtValidity_Period.Text.Trim().Length==0)
			{
				strErr+="Validity_Period不能为空！\\n";	
			}
			if(this.txtReturn_Date.Text.Trim().Length==0)
			{
				strErr+="Return_Date不能为空！\\n";	
			}
			if(this.txtValid_Date.Text.Trim().Length==0)
			{
				strErr+="Valid_Date不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Date=this.txtDate.Text;
			string From_Code=this.txtFrom_Code.Text;
			string To_Code=this.txtTo_Code.Text;
			string StartCity=this.txtStartCity.Text;
			string ArriveCity=this.txtArriveCity.Text;
			int Mileage=int.Parse(this.txtMileage.Text);
			int Fule_Adult=int.Parse(this.txtFule_Adult.Text);
			int Fule_Child=int.Parse(this.txtFule_Child.Text);
			string Line_Number=this.txtLine_Number.Text;
			string Share_Line=this.txtShare_Line.Text;
			string Company=this.txtCompany.Text;
			string StartCode=this.txtStartCode.Text;
			string StartAirport=this.txtStartAirport.Text;
			string ArriveCode=this.txtArriveCode.Text;
			string ArriveAirport=this.txtArriveAirport.Text;
			string StartTime=this.txtStartTime.Text;
			string ArriveTime=this.txtArriveTime.Text;
			int AirRax=int.Parse(this.txtAirRax.Text);
			int FuleRax=int.Parse(this.txtFuleRax.Text);
			int FuelAdu=int.Parse(this.txtFuelAdu.Text);
			int FuelChd=int.Parse(this.txtFuelChd.Text);
			int Food=int.Parse(this.txtFood.Text);
			string Food_Detail=this.txtFood_Detail.Text;
			int Direct_Flight=int.Parse(this.txtDirect_Flight.Text);
			string Type=this.txtType.Text;
			int Electronic_Ticket=int.Parse(this.txtElectronic_Ticket.Text);
			string Start_Terminal=this.txtStart_Terminal.Text;
			string Arrive_Terminal=this.txtArrive_Terminal.Text;
			string Cabin=this.txtCabin.Text;
			int ChildCabin=int.Parse(this.txtChildCabin.Text);
			string Discount=this.txtDiscount.Text;
			int Price=int.Parse(this.txtPrice.Text);
			string Surplus_Seat_Qty=this.txtSurplus_Seat_Qty.Text;
			string Cabin_Status=this.txtCabin_Status.Text;
			string Cabin_Point=this.txtCabin_Point.Text;
			string Validity_Period=this.txtValidity_Period.Text;
			string Return_Date=this.txtReturn_Date.Text;
			string Valid_Date=this.txtValid_Date.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);

			Sanben.Model.Airport_Detail model=new Sanben.Model.Airport_Detail();
			model.Date=Date;
			model.From_Code=From_Code;
			model.To_Code=To_Code;
			model.StartCity=StartCity;
			model.ArriveCity=ArriveCity;
			model.Mileage=Mileage;
			model.Fule_Adult=Fule_Adult;
			model.Fule_Child=Fule_Child;
			model.Line_Number=Line_Number;
			model.Share_Line=Share_Line;
			model.Company=Company;
			model.StartCode=StartCode;
			model.StartAirport=StartAirport;
			model.ArriveCode=ArriveCode;
			model.ArriveAirport=ArriveAirport;
			model.StartTime=StartTime;
			model.ArriveTime=ArriveTime;
			model.AirRax=AirRax;
			model.FuleRax=FuleRax;
			model.FuelAdu=FuelAdu;
			model.FuelChd=FuelChd;
			model.Food=Food;
			model.Food_Detail=Food_Detail;
			model.Direct_Flight=Direct_Flight;
			model.Type=Type;
			model.Electronic_Ticket=Electronic_Ticket;
			model.Start_Terminal=Start_Terminal;
			model.Arrive_Terminal=Arrive_Terminal;
			model.Cabin=Cabin;
			model.ChildCabin=ChildCabin;
			model.Discount=Discount;
			model.Price=Price;
			model.Surplus_Seat_Qty=Surplus_Seat_Qty;
			model.Cabin_Status=Cabin_Status;
			model.Cabin_Point=Cabin_Point;
			model.Validity_Period=Validity_Period;
			model.Return_Date=Return_Date;
			model.Valid_Date=Valid_Date;
			model.AddTime=AddTime;

			Sanben.BLL.Airport_Detail bll=new Sanben.BLL.Airport_Detail();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
