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
namespace Sanben.Web.AirComMan
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCarrierCode.Text.Trim().Length==0)
			{
				strErr+="CarrierCode不能为空！\\n";	
			}
			if(this.txtCarrierName.Text.Trim().Length==0)
			{
				strErr+="CarrierName不能为空！\\n";	
			}
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(this.txtDiscount.Text.Trim().Length==0)
			{
				strErr+="Discount不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CarrierCode=this.txtCarrierCode.Text;
			string CarrierName=this.txtCarrierName.Text;
			string Cabin=this.txtCabin.Text;
			string Discount=this.txtDiscount.Text;

			Sanben.Model.AirComMan model=new Sanben.Model.AirComMan();
			model.CarrierCode=CarrierCode;
			model.CarrierName=CarrierName;
			model.Cabin=Cabin;
			model.Discount=Discount;

			Sanben.BLL.AirComMan bll=new Sanben.BLL.AirComMan();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
