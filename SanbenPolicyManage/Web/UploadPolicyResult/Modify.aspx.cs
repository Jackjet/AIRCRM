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
namespace Sanben.Web.UploadPolicyResult
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
		Sanben.BLL.UploadPolicyResult bll=new Sanben.BLL.UploadPolicyResult();
		Sanben.Model.UploadPolicyResult model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtstartMode.Text=model.startMode;
		this.txtupload_platFrom.Text=model.upload_platFrom;
		this.txtupload_class.Text=model.upload_class.ToString();
		this.txtuploadType.Text=model.uploadType.ToString();
		this.txtuploadResult.Text=model.uploadResult;
		this.txtuploadNumber.Text=model.uploadNumber.ToString();
		this.txterrorNumber.Text=model.errorNumber.ToString();
		this.txtresult.Text=model.result;
		this.txtuploadTime.Text=model.uploadTime.ToString();
		this.txtnoticeTime.Text=model.noticeTime.ToString();
		this.txtsys_id.Text=model.sys_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtstartMode.Text.Trim().Length==0)
			{
				strErr+="startMode不能为空！\\n";	
			}
			if(this.txtupload_platFrom.Text.Trim().Length==0)
			{
				strErr+="upload_platFrom不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtupload_class.Text))
			{
				strErr+="upload_class格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtuploadType.Text))
			{
				strErr+="uploadType格式错误！\\n";	
			}
			if(this.txtuploadResult.Text.Trim().Length==0)
			{
				strErr+="uploadResult不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuploadNumber.Text))
			{
				strErr+="uploadNumber格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txterrorNumber.Text))
			{
				strErr+="errorNumber格式错误！\\n";	
			}
			if(this.txtresult.Text.Trim().Length==0)
			{
				strErr+="result不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtuploadTime.Text))
			{
				strErr+="uploadTime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtnoticeTime.Text))
			{
				strErr+="noticeTime格式错误！\\n";	
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
			string startMode=this.txtstartMode.Text;
			string upload_platFrom=this.txtupload_platFrom.Text;
			int upload_class=int.Parse(this.txtupload_class.Text);
			int uploadType=int.Parse(this.txtuploadType.Text);
			string uploadResult=this.txtuploadResult.Text;
			int uploadNumber=int.Parse(this.txtuploadNumber.Text);
			int errorNumber=int.Parse(this.txterrorNumber.Text);
			string result=this.txtresult.Text;
			DateTime uploadTime=DateTime.Parse(this.txtuploadTime.Text);
			DateTime noticeTime=DateTime.Parse(this.txtnoticeTime.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);


			Sanben.Model.UploadPolicyResult model=new Sanben.Model.UploadPolicyResult();
			model.id=id;
			model.startMode=startMode;
			model.upload_platFrom=upload_platFrom;
			model.upload_class=upload_class;
			model.uploadType=uploadType;
			model.uploadResult=uploadResult;
			model.uploadNumber=uploadNumber;
			model.errorNumber=errorNumber;
			model.result=result;
			model.uploadTime=uploadTime;
			model.noticeTime=noticeTime;
			model.sys_id=sys_id;

			Sanben.BLL.UploadPolicyResult bll=new Sanben.BLL.UploadPolicyResult();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
