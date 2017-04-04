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
namespace Sanben.Web.Airport_Unknown
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCabin.Text.Trim().Length==0)
			{
				strErr+="Cabin不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtChildCabin.Text))
			{
				strErr+="ChildCabin格式错误！\\n";	
			}
			if(this.txtDiscount.Text.Trim().Length==0)
			{
				strErr+="Discount不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPrice.Text))
			{
				strErr+="Price格式错误！\\n";	
			}
			if(this.txtSurplus_Seat_Qty.Text.Trim().Length==0)
			{
				strErr+="Surplus_Seat_Qty不能为空！\\n";	
			}
			if(this.txtCabin_Status.Text.Trim().Length==0)
			{
				strErr+="Cabin_Status不能为空！\\n";	
			}
			if(this.txtLine_Number.Text.Trim().Length==0)
			{
				strErr+="Line_Number不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Cabin=this.txtCabin.Text;
			int ChildCabin=int.Parse(this.txtChildCabin.Text);
			string Discount=this.txtDiscount.Text;
			int Price=int.Parse(this.txtPrice.Text);
			string Surplus_Seat_Qty=this.txtSurplus_Seat_Qty.Text;
			string Cabin_Status=this.txtCabin_Status.Text;
			string Line_Number=this.txtLine_Number.Text;

			Sanben.Model.Airport_Unknown model=new Sanben.Model.Airport_Unknown();
			model.Cabin=Cabin;
			model.ChildCabin=ChildCabin;
			model.Discount=Discount;
			model.Price=Price;
			model.Surplus_Seat_Qty=Surplus_Seat_Qty;
			model.Cabin_Status=Cabin_Status;
			model.Line_Number=Line_Number;

			Sanben.BLL.Airport_Unknown bll=new Sanben.BLL.Airport_Unknown();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
