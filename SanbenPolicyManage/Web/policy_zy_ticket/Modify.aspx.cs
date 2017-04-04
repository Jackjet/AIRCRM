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
namespace Sanben.Web.policy_zy_ticket
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
		Sanben.BLL.policy_zy_ticket bll=new Sanben.BLL.policy_zy_ticket();
		Sanben.Model.policy_zy_ticket model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtnavigation_company.Text=model.navigation_company;
		this.txtair_line.Text=model.air_line;
		this.txtapplication_space.Text=model.application_space;
		this.txtstartdate_ticket.Text=model.startdate_ticket.ToString();
		this.txtenddate_ticket.Text=model.enddate_ticket.ToString();
		this.txtchangedate.Text=model.changedate.ToString();
		this.txtplatform_id.Text=model.platform_id.ToString();
		this.txtsys_id.Text=model.sys_id.ToString();

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
			if(!PageValidate.IsNumber(txtstartdate_ticket.Text))
			{
				strErr+="startdate_ticket格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtenddate_ticket.Text))
			{
				strErr+="enddate_ticket格式错误！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string application_space=this.txtapplication_space.Text;
			int startdate_ticket=int.Parse(this.txtstartdate_ticket.Text);
			int enddate_ticket=int.Parse(this.txtenddate_ticket.Text);
			DateTime changedate=DateTime.Parse(this.txtchangedate.Text);
			int platform_id=int.Parse(this.txtplatform_id.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);


			Sanben.Model.policy_zy_ticket model=new Sanben.Model.policy_zy_ticket();
			model.id=id;
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.application_space=application_space;
			model.startdate_ticket=startdate_ticket;
			model.enddate_ticket=enddate_ticket;
			model.changedate=changedate;
			model.platform_id=platform_id;
			model.sys_id=sys_id;

			Sanben.BLL.policy_zy_ticket bll=new Sanben.BLL.policy_zy_ticket();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
