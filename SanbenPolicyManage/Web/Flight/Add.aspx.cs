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
namespace Sanben.Web.Flight
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcode.Text.Trim().Length==0)
			{
				strErr+="code不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(this.txtccabin.Text.Trim().Length==0)
			{
				strErr+="ccabin不能为空！\\n";	
			}
			if(this.txtdep.Text.Trim().Length==0)
			{
				strErr+="dep不能为空！\\n";	
			}
			if(this.txtarr.Text.Trim().Length==0)
			{
				strErr+="arr不能为空！\\n";	
			}
			if(this.txtdepDay.Text.Trim().Length==0)
			{
				strErr+="depDay不能为空！\\n";	
			}
			if(this.txtdepTime.Text.Trim().Length==0)
			{
				strErr+="depTime不能为空！\\n";	
			}
			if(this.txtarrTime.Text.Trim().Length==0)
			{
				strErr+="arrTime不能为空！\\n";	
			}
			if(this.txtrealCode.Text.Trim().Length==0)
			{
				strErr+="realCode不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txto_id.Text))
			{
				strErr+="o_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string code=this.txtcode.Text;
			string cabin=this.txtcabin.Text;
			string ccabin=this.txtccabin.Text;
			string dep=this.txtdep.Text;
			string arr=this.txtarr.Text;
			string depDay=this.txtdepDay.Text;
			string depTime=this.txtdepTime.Text;
			string arrTime=this.txtarrTime.Text;
			string realCode=this.txtrealCode.Text;
			int o_id=int.Parse(this.txto_id.Text);

			Sanben.Model.Flight model=new Sanben.Model.Flight();
			model.code=code;
			model.cabin=cabin;
			model.ccabin=ccabin;
			model.dep=dep;
			model.arr=arr;
			model.depDay=depDay;
			model.depTime=depTime;
			model.arrTime=arrTime;
			model.realCode=realCode;
			model.o_id=o_id;

			Sanben.BLL.Flight bll=new Sanben.BLL.Flight();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
