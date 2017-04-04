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
namespace Sanben.Web.517NaBenefit
{
    public partial class Modify : Page
    {       

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
		this.txtID.Text=model.ID.ToString();
		this.txtPolicyNum.Text=model.PolicyNum;
		this.txtAirline.Text=model.Airline;
		this.txtScity.Text=model.Scity;
		this.txtAcity.Text=model.Acity;
		this.txtAirType.Text=model.AirType;
		this.txtFlight.Text=model.Flight;
		this.txtCabin.Text=model.Cabin;
		this.txtTripType.Text=model.TripType;
		this.txtPolicyType.Text=model.PolicyType;
		this.txtPolicyPoint.Text=model.PolicyPoint;
		this.txtScheduleRestr.Text=model.ScheduleRestr;
		this.txtTicketCondition.Text=model.TicketCondition;
		this.txtAvaDate.Text=model.AvaDate;
		this.txtEndDate.Text=model.EndDate;
		this.txtSupplierTimeDay.Text=model.SupplierTimeDay;
		this.txtSupplierTimeWeek.Text=model.SupplierTimeWeek;
		this.txtIsSpeciPolicy.Text=model.IsSpeciPolicy;
		this.txtIsChange.Text=model.IsChange;
		this.txtChildPolicyNum.Text=model.ChildPolicyNum;
		this.txtPayPrice.Text=model.PayPrice;
		this.txtTicket.Text=model.Ticket;
		this.txtAirrax.Text=model.Airrax;
		this.txtFuel.Text=model.Fuel;
		this.txtSupplierDelDay.Text=model.SupplierDelDay;
		this.txtSupplierDelWeek.Text=model.SupplierDelWeek;
		this.txtTicketEffic.Text=model.TicketEffic;
		this.txtUpgradeChange.Text=model.UpgradeChange;
		this.txtOfficeCode.Text=model.OfficeCode;
		this.txtAddTime.Text=model.AddTime.ToString();
		this.chkIsUpload.Checked=model.IsUpload;
		this.chkIsUpdate.Checked=model.IsUpdate;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtID.Text))
			{
				strErr+="ID格式错误！\\n";	
			}
			if(this.txtPolicyNum.Text.Trim().Length==0)
			{
				strErr+="PolicyNum不能为空！\\n";	
			}
			if(this.txtAirline.Text.Trim().Length==0)
			{
				strErr+="Airline不能为空！\\n";	
			}
			if(this.txtScity.Text.Trim().Length==0)
			{
				strErr+="Scity不能为空！\\n";	
			}
			if(this.txtAcity.Text.Trim().Length==0)
			{
				strErr+="Acity不能为空！\\n";	
			}
			if(this.txtAirType.Text.Trim().Length==0)
			{
				strErr+="AirType不能为空！\\n";	
			}
			if(this.txtFlight.Text.Trim().Length==0)
			{
				strErr+="Flight不能为空！\\n";	
			}
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(this.txtTripType.Text.Trim().Length==0)
			{
				strErr+="TripType不能为空！\\n";	
			}
			if(this.txtPolicyType.Text.Trim().Length==0)
			{
				strErr+="PolicyType不能为空！\\n";	
			}
			if(this.txtPolicyPoint.Text.Trim().Length==0)
			{
				strErr+="PolicyPoint不能为空！\\n";	
			}
			if(this.txtScheduleRestr.Text.Trim().Length==0)
			{
				strErr+="ScheduleRestr不能为空！\\n";	
			}
			if(this.txtTicketCondition.Text.Trim().Length==0)
			{
				strErr+="TicketCondition不能为空！\\n";	
			}
			if(this.txtAvaDate.Text.Trim().Length==0)
			{
				strErr+="AvaDate不能为空！\\n";	
			}
			if(this.txtEndDate.Text.Trim().Length==0)
			{
				strErr+="EndDate不能为空！\\n";	
			}
			if(this.txtSupplierTimeDay.Text.Trim().Length==0)
			{
				strErr+="SupplierTimeDay不能为空！\\n";	
			}
			if(this.txtSupplierTimeWeek.Text.Trim().Length==0)
			{
				strErr+="SupplierTimeWeek不能为空！\\n";	
			}
			if(this.txtIsSpeciPolicy.Text.Trim().Length==0)
			{
				strErr+="IsSpeciPolicy不能为空！\\n";	
			}
			if(this.txtIsChange.Text.Trim().Length==0)
			{
				strErr+="IsChange不能为空！\\n";	
			}
			if(this.txtChildPolicyNum.Text.Trim().Length==0)
			{
				strErr+="ChildPolicyNum不能为空！\\n";	
			}
			if(this.txtPayPrice.Text.Trim().Length==0)
			{
				strErr+="PayPrice不能为空！\\n";	
			}
			if(this.txtTicket.Text.Trim().Length==0)
			{
				strErr+="Ticket不能为空！\\n";	
			}
			if(this.txtAirrax.Text.Trim().Length==0)
			{
				strErr+="Airrax不能为空！\\n";	
			}
			if(this.txtFuel.Text.Trim().Length==0)
			{
				strErr+="Fuel不能为空！\\n";	
			}
			if(this.txtSupplierDelDay.Text.Trim().Length==0)
			{
				strErr+="SupplierDelDay不能为空！\\n";	
			}
			if(this.txtSupplierDelWeek.Text.Trim().Length==0)
			{
				strErr+="SupplierDelWeek不能为空！\\n";	
			}
			if(this.txtTicketEffic.Text.Trim().Length==0)
			{
				strErr+="TicketEffic不能为空！\\n";	
			}
			if(this.txtUpgradeChange.Text.Trim().Length==0)
			{
				strErr+="UpgradeChange不能为空！\\n";	
			}
			if(this.txtOfficeCode.Text.Trim().Length==0)
			{
				strErr+="OfficeCode不能为空！\\n";	
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
			int ID=int.Parse(this.txtID.Text);
			string PolicyNum=this.txtPolicyNum.Text;
			string Airline=this.txtAirline.Text;
			string Scity=this.txtScity.Text;
			string Acity=this.txtAcity.Text;
			string AirType=this.txtAirType.Text;
			string Flight=this.txtFlight.Text;
			string Cabin=this.txtCabin.Text;
			string TripType=this.txtTripType.Text;
			string PolicyType=this.txtPolicyType.Text;
			string PolicyPoint=this.txtPolicyPoint.Text;
			string ScheduleRestr=this.txtScheduleRestr.Text;
			string TicketCondition=this.txtTicketCondition.Text;
			string AvaDate=this.txtAvaDate.Text;
			string EndDate=this.txtEndDate.Text;
			string SupplierTimeDay=this.txtSupplierTimeDay.Text;
			string SupplierTimeWeek=this.txtSupplierTimeWeek.Text;
			string IsSpeciPolicy=this.txtIsSpeciPolicy.Text;
			string IsChange=this.txtIsChange.Text;
			string ChildPolicyNum=this.txtChildPolicyNum.Text;
			string PayPrice=this.txtPayPrice.Text;
			string Ticket=this.txtTicket.Text;
			string Airrax=this.txtAirrax.Text;
			string Fuel=this.txtFuel.Text;
			string SupplierDelDay=this.txtSupplierDelDay.Text;
			string SupplierDelWeek=this.txtSupplierDelWeek.Text;
			string TicketEffic=this.txtTicketEffic.Text;
			string UpgradeChange=this.txtUpgradeChange.Text;
			string OfficeCode=this.txtOfficeCode.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);
			bool IsUpload=this.chkIsUpload.Checked;
			bool IsUpdate=this.chkIsUpdate.Checked;


			Sanben.Model.517NaBenefit model=new Sanben.Model.517NaBenefit();
			model.ID=ID;
			model.PolicyNum=PolicyNum;
			model.Airline=Airline;
			model.Scity=Scity;
			model.Acity=Acity;
			model.AirType=AirType;
			model.Flight=Flight;
			model.Cabin=Cabin;
			model.TripType=TripType;
			model.PolicyType=PolicyType;
			model.PolicyPoint=PolicyPoint;
			model.ScheduleRestr=ScheduleRestr;
			model.TicketCondition=TicketCondition;
			model.AvaDate=AvaDate;
			model.EndDate=EndDate;
			model.SupplierTimeDay=SupplierTimeDay;
			model.SupplierTimeWeek=SupplierTimeWeek;
			model.IsSpeciPolicy=IsSpeciPolicy;
			model.IsChange=IsChange;
			model.ChildPolicyNum=ChildPolicyNum;
			model.PayPrice=PayPrice;
			model.Ticket=Ticket;
			model.Airrax=Airrax;
			model.Fuel=Fuel;
			model.SupplierDelDay=SupplierDelDay;
			model.SupplierDelWeek=SupplierDelWeek;
			model.TicketEffic=TicketEffic;
			model.UpgradeChange=UpgradeChange;
			model.OfficeCode=OfficeCode;
			model.AddTime=AddTime;
			model.IsUpload=IsUpload;
			model.IsUpdate=IsUpdate;

			Sanben.BLL.517NaBenefit bll=new Sanben.BLL.517NaBenefit();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
