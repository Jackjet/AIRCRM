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
namespace Sanben.Web.AirMan
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStartCode.Text.Trim().Length==0)
			{
				strErr+="StartCode不能为空！\\n";	
			}
			if(this.txtArriveCode.Text.Trim().Length==0)
			{
				strErr+="ArriveCode不能为空！\\n";	
			}
			if(this.txtCarrierName.Text.Trim().Length==0)
			{
				strErr+="CarrierName不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string StartCode=this.txtStartCode.Text;
			string ArriveCode=this.txtArriveCode.Text;
			string CarrierName=this.txtCarrierName.Text;
			string Status=this.txtStatus.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);

			Sanben.Model.AirMan model=new Sanben.Model.AirMan();
			model.StartCode=StartCode;
			model.ArriveCode=ArriveCode;
			model.CarrierName=CarrierName;
			model.Status=Status;
			model.AddTime=AddTime;

			Sanben.BLL.AirMan bll=new Sanben.BLL.AirMan();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
