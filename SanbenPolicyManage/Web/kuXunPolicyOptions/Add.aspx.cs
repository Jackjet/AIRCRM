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
namespace Sanben.Web.kuXunPolicyOptions
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
			if(!PageValidate.IsDecimal(txtdiscount.Text))
			{
				strErr+="discount格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtagent_rate.Text))
			{
				strErr+="agent_rate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtinsurance_number.Text))
			{
				strErr+="insurance_number格式错误！\\n";	
			}
			if(this.txtvalidatePatA.Text.Trim().Length==0)
			{
				strErr+="validatePatA不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtvalidateClass.Text))
			{
				strErr+="validateClass格式错误！\\n";	
			}
			if(this.txtrefund_change_rule.Text.Trim().Length==0)
			{
				strErr+="refund_change_rule不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_type_id.Text))
			{
				strErr+="platform_type_id格式错误！\\n";	
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
			decimal discount=decimal.Parse(this.txtdiscount.Text);
			decimal agent_rate=decimal.Parse(this.txtagent_rate.Text);
			int insurance_number=int.Parse(this.txtinsurance_number.Text);
			bool foundPnr=this.chkfoundPnr.Checked;
			bool is_mail_itinerary=this.chkis_mail_itinerary.Checked;
			string validatePatA=this.txtvalidatePatA.Text;
			int validateClass=int.Parse(this.txtvalidateClass.Text);
			string refund_change_rule=this.txtrefund_change_rule.Text;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);

			Sanben.Model.kuXunPolicyOptions model=new Sanben.Model.kuXunPolicyOptions();
			model.tolerate_stationary_point=tolerate_stationary_point;
			model.tolerate_leave_money=tolerate_leave_money;
			model.lowest_rebate=lowest_rebate;
			model.highest_rebate=highest_rebate;
			model.earliest_advance_days=earliest_advance_days;
			model.night_before_days=night_before_days;
			model.rebate_class_set=rebate_class_set;
			model.discount=discount;
			model.agent_rate=agent_rate;
			model.insurance_number=insurance_number;
			model.foundPnr=foundPnr;
			model.is_mail_itinerary=is_mail_itinerary;
			model.validatePatA=validatePatA;
			model.validateClass=validateClass;
			model.refund_change_rule=refund_change_rule;
			model.sys_id=sys_id;
			model.platform_type_id=platform_type_id;

			Sanben.BLL.kuXunPolicyOptions bll=new Sanben.BLL.kuXunPolicyOptions();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
