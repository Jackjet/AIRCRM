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
namespace Sanben.Web.Insurance
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
		Sanben.BLL.Insurance bll=new Sanben.BLL.Insurance();
		Sanben.Model.Insurance model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtinsuranceNo.Text=model.insuranceNo;
		this.txtbxFlight.Text=model.bxFlight;
		this.txtbxStatus.Text=model.bxStatus;
		this.txtp_id.Text=model.p_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtinsuranceNo.Text.Trim().Length==0)
			{
				strErr+="insuranceNo不能为空！\\n";	
			}
			if(this.txtbxFlight.Text.Trim().Length==0)
			{
				strErr+="bxFlight不能为空！\\n";	
			}
			if(this.txtbxStatus.Text.Trim().Length==0)
			{
				strErr+="bxStatus不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtp_id.Text))
			{
				strErr+="p_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string insuranceNo=this.txtinsuranceNo.Text;
			string bxFlight=this.txtbxFlight.Text;
			string bxStatus=this.txtbxStatus.Text;
			int p_id=int.Parse(this.txtp_id.Text);


			Sanben.Model.Insurance model=new Sanben.Model.Insurance();
			model.id=id;
			model.insuranceNo=insuranceNo;
			model.bxFlight=bxFlight;
			model.bxStatus=bxStatus;
			model.p_id=p_id;

			Sanben.BLL.Insurance bll=new Sanben.BLL.Insurance();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
