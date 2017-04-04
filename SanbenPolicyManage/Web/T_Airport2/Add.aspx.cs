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
namespace Sanben.Web.T_Airport2
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtairport_code.Text.Trim().Length==0)
			{
				strErr+="airport_code不能为空！\\n";	
			}
			if(this.txtairport_city.Text.Trim().Length==0)
			{
				strErr+="airport_city不能为空！\\n";	
			}
			if(this.txtairport_name.Text.Trim().Length==0)
			{
				strErr+="airport_name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string airport_code=this.txtairport_code.Text;
			string airport_city=this.txtairport_city.Text;
			string airport_name=this.txtairport_name.Text;

			Sanben.Model.T_Airport2 model=new Sanben.Model.T_Airport2();
			model.airport_code=airport_code;
			model.airport_city=airport_city;
			model.airport_name=airport_name;

			Sanben.BLL.T_Airport2 bll=new Sanben.BLL.T_Airport2();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
