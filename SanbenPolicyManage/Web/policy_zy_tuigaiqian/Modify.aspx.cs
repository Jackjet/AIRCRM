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
namespace Sanben.Web.policy_zy_tuigaiqian
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
		Sanben.BLL.policy_zy_tuigaiqian bll=new Sanben.BLL.policy_zy_tuigaiqian();
		Sanben.Model.policy_zy_tuigaiqian model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtnavigation_company.Text=model.navigation_company;
		this.txtair_line.Text=model.air_line;
		this.txtapplication_space.Text=model.application_space;
		this.chkinitiaie_mode.Checked=model.initiaie_mode;
		this.txtstartDate.Text=model.startDate.ToString();
		this.txtendDate.Text=model.endDate.ToString();
		this.txtchangedate.Text=model.changedate.ToString();
		this.txtplatform_id.Text=model.platform_id.ToString();
		this.txtsys_id.Text=model.sys_id.ToString();
		this.chkis_allowed_sign.Checked=model.is_allowed_sign;
		this.txtrefund_rule.Text=model.refund_rule;
		this.txtchangedate_rule.Text=model.changedate_rule;

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
			if(!PageValidate.IsDateTime(txtstartDate.Text))
			{
				strErr+="startDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtendDate.Text))
			{
				strErr+="endDate格式错误！\\n";	
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
			if(this.txtrefund_rule.Text.Trim().Length==0)
			{
				strErr+="refund_rule不能为空！\\n";	
			}
			if(this.txtchangedate_rule.Text.Trim().Length==0)
			{
				strErr+="changedate_rule不能为空！\\n";	
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
			bool initiaie_mode=this.chkinitiaie_mode.Checked;
			DateTime startDate=DateTime.Parse(this.txtstartDate.Text);
			DateTime endDate=DateTime.Parse(this.txtendDate.Text);
			DateTime changedate=DateTime.Parse(this.txtchangedate.Text);
			int platform_id=int.Parse(this.txtplatform_id.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);
			bool is_allowed_sign=this.chkis_allowed_sign.Checked;
			string refund_rule=this.txtrefund_rule.Text;
			string changedate_rule=this.txtchangedate_rule.Text;


			Sanben.Model.policy_zy_tuigaiqian model=new Sanben.Model.policy_zy_tuigaiqian();
			model.id=id;
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.application_space=application_space;
			model.initiaie_mode=initiaie_mode;
			model.startDate=startDate;
			model.endDate=endDate;
			model.changedate=changedate;
			model.platform_id=platform_id;
			model.sys_id=sys_id;
			model.is_allowed_sign=is_allowed_sign;
			model.refund_rule=refund_rule;
			model.changedate_rule=changedate_rule;

			Sanben.BLL.policy_zy_tuigaiqian bll=new Sanben.BLL.policy_zy_tuigaiqian();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
