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
namespace Sanben.Web.policy_zy_leavepoint
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Sanben.BLL.policy_zy_leavepoint bll=new Sanben.BLL.policy_zy_leavepoint();
		Sanben.Model.policy_zy_leavepoint model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtnavigation_company.Text=model.navigation_company;
		this.txtair_line.Text=model.air_line;
		this.txtapplication_space.Text=model.application_space;
		this.txtrabate_number.Text=model.rabate_number;
		this.txtleave_point.Text=model.leave_point.ToString();
		this.txtleave_money.Text=model.leave_money.ToString();
		this.txtstartdate_ticket.Text=model.startdate_ticket.ToString();
		this.txtenddate_ticket.Text=model.enddate_ticket.ToString();
		this.txttraveldate.Text=model.traveldate.ToString();
		this.chkisleavepointandmoney.Checked=model.isleavepointandmoney;
		this.chkisSet.Checked=model.isSet;
		this.txtremark.Text=model.remark;
		this.txtchangedate.Text=model.changedate.ToString();
		this.txtplatform_id.Text=model.platform_id.ToString();
		this.txtsys_id.Text=model.sys_id.ToString();
		this.txtrabate_class.Text=model.rabate_class.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtrabate_number.Text.Trim().Length==0)
			{
				strErr+="rabate_number不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtleave_point.Text))
			{
				strErr+="leave_point格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtleave_money.Text))
			{
				strErr+="leave_money格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstartdate_ticket.Text))
			{
				strErr+="startdate_ticket格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtenddate_ticket.Text))
			{
				strErr+="enddate_ticket格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttraveldate.Text))
			{
				strErr+="traveldate格式错误！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtchangedate.Text))
			{
				strErr+="changedate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_id.Text))
			{
				strErr+="platform_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtrabate_class.Text))
			{
				strErr+="rabate_class格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string application_space=this.txtapplication_space.Text;
			string rabate_number=this.txtrabate_number.Text;
			decimal leave_point=decimal.Parse(this.txtleave_point.Text);
			decimal leave_money=decimal.Parse(this.txtleave_money.Text);
			int startdate_ticket=int.Parse(this.txtstartdate_ticket.Text);
			int enddate_ticket=int.Parse(this.txtenddate_ticket.Text);
			DateTime traveldate=DateTime.Parse(this.txttraveldate.Text);
			bool isleavepointandmoney=this.chkisleavepointandmoney.Checked;
			bool isSet=this.chkisSet.Checked;
			string remark=this.txtremark.Text;
			DateTime changedate=DateTime.Parse(this.txtchangedate.Text);
			int platform_id=int.Parse(this.txtplatform_id.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);
			int rabate_class=int.Parse(this.txtrabate_class.Text);


			Sanben.Model.policy_zy_leavepoint model=new Sanben.Model.policy_zy_leavepoint();
			model.id=id;
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.application_space=application_space;
			model.rabate_number=rabate_number;
			model.leave_point=leave_point;
			model.leave_money=leave_money;
			model.startdate_ticket=startdate_ticket;
			model.enddate_ticket=enddate_ticket;
			model.traveldate=traveldate;
			model.isleavepointandmoney=isleavepointandmoney;
			model.isSet=isSet;
			model.remark=remark;
			model.changedate=changedate;
			model.platform_id=platform_id;
			model.sys_id=sys_id;
			model.rabate_class=rabate_class;

			Sanben.BLL.policy_zy_leavepoint bll=new Sanben.BLL.policy_zy_leavepoint();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
