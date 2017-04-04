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
namespace Sanben.Web.uploadTask
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtexecution_frequency.Text.Trim().Length==0)
			{
				strErr+="execution_frequency不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtexecution_time.Text))
			{
				strErr+="execution_time格式错误！\\n";	
			}
			if(this.txtupload_platFrom.Text.Trim().Length==0)
			{
				strErr+="upload_platFrom不能为空！\\n";	
			}
			if(this.txtpolicy_class.Text.Trim().Length==0)
			{
				strErr+="policy_class不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtupload_class.Text))
			{
				strErr+="upload_class格式错误！\\n";	
			}
			if(this.txtpolicySource.Text.Trim().Length==0)
			{
				strErr+="policySource不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txttripType.Text))
			{
				strErr+="tripType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtexecute_number.Text))
			{
				strErr+="execute_number格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuploadType.Text))
			{
				strErr+="uploadType格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtNextFullTime.Text))
			{
				strErr+="NextFullTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtNextAddTime.Text))
			{
				strErr+="NextAddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string execution_frequency=this.txtexecution_frequency.Text;
			DateTime execution_time=DateTime.Parse(this.txtexecution_time.Text);
			string upload_platFrom=this.txtupload_platFrom.Text;
			string policy_class=this.txtpolicy_class.Text;
			int upload_class=int.Parse(this.txtupload_class.Text);
			bool uploadPlatFrom_specialPolicies=this.chkuploadPlatFrom_specialPolicies.Checked;
			string policySource=this.txtpolicySource.Text;
			int tripType=int.Parse(this.txttripType.Text);
			int execute_number=int.Parse(this.txtexecute_number.Text);
			bool condition=this.chkcondition.Checked;
			int sys_id=int.Parse(this.txtsys_id.Text);
			int uploadType=int.Parse(this.txtuploadType.Text);
			DateTime NextFullTime=DateTime.Parse(this.txtNextFullTime.Text);
			DateTime NextAddTime=DateTime.Parse(this.txtNextAddTime.Text);
			bool Uploading=this.chkUploading.Checked;

			Sanben.Model.uploadTask model=new Sanben.Model.uploadTask();
			model.execution_frequency=execution_frequency;
			model.execution_time=execution_time;
			model.upload_platFrom=upload_platFrom;
			model.policy_class=policy_class;
			model.upload_class=upload_class;
			model.uploadPlatFrom_specialPolicies=uploadPlatFrom_specialPolicies;
			model.policySource=policySource;
			model.tripType=tripType;
			model.execute_number=execute_number;
			model.condition=condition;
			model.sys_id=sys_id;
			model.uploadType=uploadType;
			model.NextFullTime=NextFullTime;
			model.NextAddTime=NextAddTime;
			model.Uploading=Uploading;

			Sanben.BLL.uploadTask bll=new Sanben.BLL.uploadTask();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
