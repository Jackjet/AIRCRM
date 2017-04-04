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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string insuranceNo=this.txtinsuranceNo.Text;
			string bxFlight=this.txtbxFlight.Text;
			string bxStatus=this.txtbxStatus.Text;
			int p_id=int.Parse(this.txtp_id.Text);

			Sanben.Model.Insurance model=new Sanben.Model.Insurance();
			model.insuranceNo=insuranceNo;
			model.bxFlight=bxFlight;
			model.bxStatus=bxStatus;
			model.p_id=p_id;

			Sanben.BLL.Insurance bll=new Sanben.BLL.Insurance();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
