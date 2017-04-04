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
namespace Sanben.Web.GaiQianWangFanRetirement
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
		Sanben.BLL.GaiQianWangFanRetirement bll=new Sanben.BLL.GaiQianWangFanRetirement();
		Sanben.Model.GaiQianWangFanRetirement model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtnavigation_company.Text=model.navigation_company;
		this.txtair_line.Text=model.air_line;
		this.txtquchengSpace.Text=model.quchengSpace;
		this.txthuichengSpace.Text=model.huichengSpace;
		this.chkinitiate_mode.Checked=model.initiate_mode;
		this.txtstartDate.Text=model.startDate.ToString();
		this.txtendDate.Text=model.endDate.ToString();
		this.txtrefund_rule.Text=model.refund_rule;
		this.txtchangedate_rule.Text=model.changedate_rule;
		this.chkis_allowed_sign.Checked=model.is_allowed_sign;
		this.txtsys_id.Text=model.sys_id.ToString();
		this.txtplatform_type_id.Text=model.platform_type_id.ToString();

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
			if(this.txtquchengSpace.Text.Trim().Length==0)
			{
				strErr+="quchengSpace不能为空！\\n";	
			}
			if(this.txthuichengSpace.Text.Trim().Length==0)
			{
				strErr+="huichengSpace不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartDate.Text))
			{
				strErr+="startDate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtendDate.Text))
			{
				strErr+="endDate格式错误！\\n";	
			}
			if(this.txtrefund_rule.Text.Trim().Length==0)
			{
				strErr+="refund_rule不能为空！\\n";	
			}
			if(this.txtchangedate_rule.Text.Trim().Length==0)
			{
				strErr+="changedate_rule不能为空！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			string navigation_company=this.txtnavigation_company.Text;
			string air_line=this.txtair_line.Text;
			string quchengSpace=this.txtquchengSpace.Text;
			string huichengSpace=this.txthuichengSpace.Text;
			bool initiate_mode=this.chkinitiate_mode.Checked;
			DateTime startDate=DateTime.Parse(this.txtstartDate.Text);
			DateTime endDate=DateTime.Parse(this.txtendDate.Text);
			string refund_rule=this.txtrefund_rule.Text;
			string changedate_rule=this.txtchangedate_rule.Text;
			bool is_allowed_sign=this.chkis_allowed_sign.Checked;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int platform_type_id=int.Parse(this.txtplatform_type_id.Text);


			Sanben.Model.GaiQianWangFanRetirement model=new Sanben.Model.GaiQianWangFanRetirement();
			model.id=id;
			model.navigation_company=navigation_company;
			model.air_line=air_line;
			model.quchengSpace=quchengSpace;
			model.huichengSpace=huichengSpace;
			model.initiate_mode=initiate_mode;
			model.startDate=startDate;
			model.endDate=endDate;
			model.refund_rule=refund_rule;
			model.changedate_rule=changedate_rule;
			model.is_allowed_sign=is_allowed_sign;
			model.sys_id=sys_id;
			model.platform_type_id=platform_type_id;

			Sanben.BLL.GaiQianWangFanRetirement bll=new Sanben.BLL.GaiQianWangFanRetirement();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
