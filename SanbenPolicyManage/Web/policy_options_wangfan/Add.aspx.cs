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
namespace Sanben.Web.policy_options_wangfan
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txttolerate_stationary_point.Text))
			{
				strErr+="tolerate_stationary_point格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txttolerate_leave_money.Text))
			{
				strErr+="tolerate_leave_money格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlowest_rebate.Text))
			{
				strErr+="lowest_rebate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txthighest_rebate.Text))
			{
				strErr+="highest_rebate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtearliest_advance_days.Text))
			{
				strErr+="earliest_advance_days格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnight_before_days.Text))
			{
				strErr+="night_before_days格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtrebate_class_set.Text))
			{
				strErr+="rebate_class_set格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFlight_departure_time_start.Text))
			{
				strErr+="Flight_departure_time_start格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFlight_departure_time_end.Text))
			{
				strErr+="Flight_departure_time_end格式错误！\\n";	
			}
			if(this.txtempower_office_number.Text.Trim().Length==0)
			{
				strErr+="empower_office_number不能为空！\\n";	
			}
			if(this.txttolerate_refund_change_rule.Text.Trim().Length==0)
			{
				strErr+="tolerate_refund_change_rule不能为空！\\n";	
			}
			if(this.txtclass_description.Text.Trim().Length==0)
			{
				strErr+="class_description不能为空！\\n";	
			}
			if(this.txtspecial_ticketing_instructions.Text.Trim().Length==0)
			{
				strErr+="special_ticketing_instructions不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPolicy_interface_id.Text))
			{
				strErr+="Policy_interface_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_userId.Text))
			{
				strErr+="sys_userId格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			decimal tolerate_stationary_point=decimal.Parse(this.txttolerate_stationary_point.Text);
			decimal tolerate_leave_money=decimal.Parse(this.txttolerate_leave_money.Text);
			decimal lowest_rebate=decimal.Parse(this.txtlowest_rebate.Text);
			decimal highest_rebate=decimal.Parse(this.txthighest_rebate.Text);
			int earliest_advance_days=int.Parse(this.txtearliest_advance_days.Text);
			int night_before_days=int.Parse(this.txtnight_before_days.Text);
			int rebate_class_set=int.Parse(this.txtrebate_class_set.Text);
			DateTime Flight_departure_time_start=DateTime.Parse(this.txtFlight_departure_time_start.Text);
			DateTime Flight_departure_time_end=DateTime.Parse(this.txtFlight_departure_time_end.Text);
			bool is_automatic_ticket=this.chkis_automatic_ticket.Checked;
			bool is_mail_itinerary=this.chkis_mail_itinerary.Checked;
			string empower_office_number=this.txtempower_office_number.Text;
			string tolerate_refund_change_rule=this.txttolerate_refund_change_rule.Text;
			string class_description=this.txtclass_description.Text;
			string special_ticketing_instructions=this.txtspecial_ticketing_instructions.Text;
			int Policy_interface_id=int.Parse(this.txtPolicy_interface_id.Text);
			int sys_userId=int.Parse(this.txtsys_userId.Text);

			Sanben.Model.policy_options_wangfan model=new Sanben.Model.policy_options_wangfan();
			model.tolerate_stationary_point=tolerate_stationary_point;
			model.tolerate_leave_money=tolerate_leave_money;
			model.lowest_rebate=lowest_rebate;
			model.highest_rebate=highest_rebate;
			model.earliest_advance_days=earliest_advance_days;
			model.night_before_days=night_before_days;
			model.rebate_class_set=rebate_class_set;
			model.Flight_departure_time_start=Flight_departure_time_start;
			model.Flight_departure_time_end=Flight_departure_time_end;
			model.is_automatic_ticket=is_automatic_ticket;
			model.is_mail_itinerary=is_mail_itinerary;
			model.empower_office_number=empower_office_number;
			model.tolerate_refund_change_rule=tolerate_refund_change_rule;
			model.class_description=class_description;
			model.special_ticketing_instructions=special_ticketing_instructions;
			model.Policy_interface_id=Policy_interface_id;
			model.sys_userId=sys_userId;

			Sanben.BLL.policy_options_wangfan bll=new Sanben.BLL.policy_options_wangfan();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
