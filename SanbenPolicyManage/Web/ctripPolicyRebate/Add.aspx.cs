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
namespace Sanben.Web.ctripPolicyRebate
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtnavigation_company.Text.Trim().Length==0)
			{
				strErr+="navigation_company不能为空！\\n";	
			}
			if(this.txtair_line.Text.Trim().Length==0)
			{
				strErr+="air_line不能为空！\\n";	
			}
			if(this.txtapplication_space.Text.Trim().Length==0)
			{
				strErr+="application_space不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtrabate_number.Text))
			{
				strErr+="rabate_number格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtleave_money.Text))
			{
				strErr+="leave_money格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtticket_price_lowest.Text))
			{
				strErr+="ticket_price_lowest格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtticket_price_highest.Text))
			{
				strErr+="ticket_price_highest格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtrabate_class.Text))
			{
				strErr+="rabate_class格式错误！\\n";	
			}
			if(this.txtreturnType.Text.Trim().Length==0)
			{
				strErr+="returnType不能为空！\\n";	
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
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string application_space=this.txtapplication_space.Text;
			decimal rabate_number=decimal.Parse(this.txtrabate_number.Text);
			decimal leave_money=decimal.Parse(this.txtleave_money.Text);
			int ticket_price_lowest=int.Parse(this.txtticket_price_lowest.Text);
			int ticket_price_highest=int.Parse(this.txtticket_price_highest.Text);
			int rabate_class=int.Parse(this.txtrabate_class.Text);
			string returnType=this.txtreturnType.Text;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);

			Sanben.Model.ctripPolicyRebate model=new Sanben.Model.ctripPolicyRebate();
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.application_space=application_space;
			model.rabate_number=rabate_number;
			model.leave_money=leave_money;
			model.ticket_price_lowest=ticket_price_lowest;
			model.ticket_price_highest=ticket_price_highest;
			model.rabate_class=rabate_class;
			model.returnType=returnType;
			model.sys_id=sys_id;
			model.platform_type_id=platform_type_id;

			Sanben.BLL.ctripPolicyRebate bll=new Sanben.BLL.ctripPolicyRebate();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
