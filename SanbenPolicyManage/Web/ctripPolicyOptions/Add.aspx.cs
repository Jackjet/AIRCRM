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
namespace Sanben.Web.ctripPolicyOptions
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
			if(!PageValidate.IsNumber(txtticket_price_set.Text))
			{
				strErr+="ticket_price_set格式错误！\\n";	
			}
			if(this.txtworkTimeLimit.Text.Trim().Length==0)
			{
				strErr+="workTimeLimit不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdiscount.Text))
			{
				strErr+="discount格式错误！\\n";	
			}
			if(this.txtoff_number.Text.Trim().Length==0)
			{
				strErr+="off_number不能为空！\\n";	
			}
			if(this.txtspecial_ticketing_instructions.Text.Trim().Length==0)
			{
				strErr+="special_ticketing_instructions不能为空！\\n";	
			}
			if(this.txtrefund_change_rule.Text.Trim().Length==0)
			{
				strErr+="refund_change_rule不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_type_id.Text))
			{
				strErr+="platform_type_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
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
			int ticket_price_set=int.Parse(this.txtticket_price_set.Text);
			string workTimeLimit=this.txtworkTimeLimit.Text;
			decimal discount=decimal.Parse(this.txtdiscount.Text);
			bool is_automatic_ticket=this.chkis_automatic_ticket.Checked;
			bool is_mail_itinerary=this.chkis_mail_itinerary.Checked;
			string off_number=this.txtoff_number.Text;
			bool is_orientate=this.chkis_orientate.Checked;
			string special_ticketing_instructions=this.txtspecial_ticketing_instructions.Text;
			string refund_change_rule=this.txtrefund_change_rule.Text;
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);

			Sanben.Model.ctripPolicyOptions model=new Sanben.Model.ctripPolicyOptions();
			model.tolerate_stationary_point=tolerate_stationary_point;
			model.tolerate_leave_money=tolerate_leave_money;
			model.lowest_rebate=lowest_rebate;
			model.highest_rebate=highest_rebate;
			model.earliest_advance_days=earliest_advance_days;
			model.night_before_days=night_before_days;
			model.rebate_class_set=rebate_class_set;
			model.ticket_price_set=ticket_price_set;
			model.workTimeLimit=workTimeLimit;
			model.discount=discount;
			model.is_automatic_ticket=is_automatic_ticket;
			model.is_mail_itinerary=is_mail_itinerary;
			model.off_number=off_number;
			model.is_orientate=is_orientate;
			model.special_ticketing_instructions=special_ticketing_instructions;
			model.refund_change_rule=refund_change_rule;
			model.platform_type_id=platform_type_id;
			model.sys_id=sys_id;

			Sanben.BLL.ctripPolicyOptions bll=new Sanben.BLL.ctripPolicyOptions();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
