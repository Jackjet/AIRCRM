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
namespace Sanben.Web.BaQianYiPolicy
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtpolicy_num.Text.Trim().Length==0)
			{
				strErr+="policy_num不能为空！\\n";	
			}
			if(this.txtstartcity.Text.Trim().Length==0)
			{
				strErr+="startcity不能为空！\\n";	
			}
			if(this.txtarrivecity.Text.Trim().Length==0)
			{
				strErr+="arrivecity不能为空！\\n";	
			}
			if(this.txtairline.Text.Trim().Length==0)
			{
				strErr+="airline不能为空！\\n";	
			}
			if(this.txtfor_flight_no.Text.Trim().Length==0)
			{
				strErr+="for_flight_no不能为空！\\n";	
			}
			if(this.txtex_flight_no.Text.Trim().Length==0)
			{
				strErr+="ex_flight_no不能为空！\\n";	
			}
			if(this.txtpolicy_ratype.Text.Trim().Length==0)
			{
				strErr+="policy_ratype不能为空！\\n";	
			}
			if(this.txtpoint.Text.Trim().Length==0)
			{
				strErr+="point不能为空！\\n";	
			}
			if(this.txtcabin_discount.Text.Trim().Length==0)
			{
				strErr+="cabin_discount不能为空！\\n";	
			}
			if(this.txtstartdate.Text.Trim().Length==0)
			{
				strErr+="startdate不能为空！\\n";	
			}
			if(this.txtarrivedate.Text.Trim().Length==0)
			{
				strErr+="arrivedate不能为空！\\n";	
			}
			if(this.txtnomal_workday.Text.Trim().Length==0)
			{
				strErr+="nomal_workday不能为空！\\n";	
			}
			if(this.txtweekday.Text.Trim().Length==0)
			{
				strErr+="weekday不能为空！\\n";	
			}
			if(this.txtvip_policy.Text.Trim().Length==0)
			{
				strErr+="vip_policy不能为空！\\n";	
			}
			if(this.txtreturn_policy.Text.Trim().Length==0)
			{
				strErr+="return_policy不能为空！\\n";	
			}
			if(this.txtpolicy_type.Text.Trim().Length==0)
			{
				strErr+="policy_type不能为空！\\n";	
			}
			if(this.txtpolicy_note.Text.Trim().Length==0)
			{
				strErr+="policy_note不能为空！\\n";	
			}
			if(this.txtsupplier_id.Text.Trim().Length==0)
			{
				strErr+="supplier_id不能为空！\\n";	
			}
			if(this.txtor_ticket_t.Text.Trim().Length==0)
			{
				strErr+="or_ticket_t不能为空！\\n";	
			}
			if(this.txtweek_ticket_t.Text.Trim().Length==0)
			{
				strErr+="week_ticket_t不能为空！\\n";	
			}
			if(this.txtpolicy_flight.Text.Trim().Length==0)
			{
				strErr+="policy_flight不能为空！\\n";	
			}
			if(this.txtend_state.Text.Trim().Length==0)
			{
				strErr+="end_state不能为空！\\n";	
			}
			if(this.txtoffice_code.Text.Trim().Length==0)
			{
				strErr+="office_code不能为空！\\n";	
			}
			if(this.txtsalestart_date.Text.Trim().Length==0)
			{
				strErr+="salestart_date不能为空！\\n";	
			}
			if(this.txtsaleend_date.Text.Trim().Length==0)
			{
				strErr+="saleend_date不能为空！\\n";	
			}
			if(this.txtsupport_pay.Text.Trim().Length==0)
			{
				strErr+="support_pay不能为空！\\n";	
			}
			if(this.txtticket_efficient.Text.Trim().Length==0)
			{
				strErr+="ticket_efficient不能为空！\\n";	
			}
			if(this.txtis_cgnum_ticket.Text.Trim().Length==0)
			{
				strErr+="is_cgnum_ticket不能为空！\\n";	
			}
			if(this.txtis_open_low.Text.Trim().Length==0)
			{
				strErr+="is_open_low不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtaddtime.Text))
			{
				strErr+="addtime格式错误！\\n";	
			}
			if(this.txtlast_modify_time.Text.Trim().Length==0)
			{
				strErr+="last_modify_time不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string policy_num=this.txtpolicy_num.Text;
			string startcity=this.txtstartcity.Text;
			string arrivecity=this.txtarrivecity.Text;
			string airline=this.txtairline.Text;
			string for_flight_no=this.txtfor_flight_no.Text;
			string ex_flight_no=this.txtex_flight_no.Text;
			string policy_ratype=this.txtpolicy_ratype.Text;
			string point=this.txtpoint.Text;
			string cabin_discount=this.txtcabin_discount.Text;
			string startdate=this.txtstartdate.Text;
			string arrivedate=this.txtarrivedate.Text;
			string nomal_workday=this.txtnomal_workday.Text;
			string weekday=this.txtweekday.Text;
			string vip_policy=this.txtvip_policy.Text;
			string return_policy=this.txtreturn_policy.Text;
			string policy_type=this.txtpolicy_type.Text;
			string policy_note=this.txtpolicy_note.Text;
			string supplier_id=this.txtsupplier_id.Text;
			string or_ticket_t=this.txtor_ticket_t.Text;
			string week_ticket_t=this.txtweek_ticket_t.Text;
			string policy_flight=this.txtpolicy_flight.Text;
			string end_state=this.txtend_state.Text;
			string office_code=this.txtoffice_code.Text;
			string salestart_date=this.txtsalestart_date.Text;
			string saleend_date=this.txtsaleend_date.Text;
			string support_pay=this.txtsupport_pay.Text;
			string ticket_efficient=this.txtticket_efficient.Text;
			string is_cgnum_ticket=this.txtis_cgnum_ticket.Text;
			string is_open_low=this.txtis_open_low.Text;
			DateTime addtime=DateTime.Parse(this.txtaddtime.Text);
			string last_modify_time=this.txtlast_modify_time.Text;
			bool IsUpload=this.chkIsUpload.Checked;
			bool IsUpdate=this.chkIsUpdate.Checked;

			Sanben.Model.BaQianYiPolicy model=new Sanben.Model.BaQianYiPolicy();
			model.policy_num=policy_num;
			model.startcity=startcity;
			model.arrivecity=arrivecity;
			model.airline=airline;
			model.for_flight_no=for_flight_no;
			model.ex_flight_no=ex_flight_no;
			model.policy_ratype=policy_ratype;
			model.point=point;
			model.cabin_discount=cabin_discount;
			model.startdate=startdate;
			model.arrivedate=arrivedate;
			model.nomal_workday=nomal_workday;
			model.weekday=weekday;
			model.vip_policy=vip_policy;
			model.return_policy=return_policy;
			model.policy_type=policy_type;
			model.policy_note=policy_note;
			model.supplier_id=supplier_id;
			model.or_ticket_t=or_ticket_t;
			model.week_ticket_t=week_ticket_t;
			model.policy_flight=policy_flight;
			model.end_state=end_state;
			model.office_code=office_code;
			model.salestart_date=salestart_date;
			model.saleend_date=saleend_date;
			model.support_pay=support_pay;
			model.ticket_efficient=ticket_efficient;
			model.is_cgnum_ticket=is_cgnum_ticket;
			model.is_open_low=is_open_low;
			model.addtime=addtime;
			model.last_modify_time=last_modify_time;
			model.IsUpload=IsUpload;
			model.IsUpdate=IsUpdate;

			Sanben.BLL.BaQianYiPolicy bll=new Sanben.BLL.BaQianYiPolicy();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
