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
namespace Sanben.Web.T_Carrier
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcarrier_code.Text.Trim().Length==0)
			{
				strErr+="carrier_code不能为空！\\n";	
			}
			if(this.txtcarrier_name.Text.Trim().Length==0)
			{
				strErr+="carrier_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string carrier_code=this.txtcarrier_code.Text;
			string carrier_name=this.txtcarrier_name.Text;

			Sanben.Model.T_Carrier model=new Sanben.Model.T_Carrier();
			model.carrier_code=carrier_code;
			model.carrier_name=carrier_name;

			Sanben.BLL.T_Carrier bll=new Sanben.BLL.T_Carrier();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
