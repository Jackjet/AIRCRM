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
namespace Sanben.Web.Passenger
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtageType.Text.Trim().Length==0)
			{
				strErr+="ageType不能为空！\\n";	
			}
			if(this.txtcardType.Text.Trim().Length==0)
			{
				strErr+="cardType不能为空！\\n";	
			}
			if(this.txtprice.Text.Trim().Length==0)
			{
				strErr+="price不能为空！\\n";	
			}
			if(this.txtpriceType.Text.Trim().Length==0)
			{
				strErr+="priceType不能为空！\\n";	
			}
			if(this.txtcardNum.Text.Trim().Length==0)
			{
				strErr+="cardNum不能为空！\\n";	
			}
			if(this.txteticketNum.Text.Trim().Length==0)
			{
				strErr+="eticketNum不能为空！\\n";	
			}
			if(this.txtinsuranceCount.Text.Trim().Length==0)
			{
				strErr+="insuranceCount不能为空！\\n";	
			}
			if(this.txtbxSource.Text.Trim().Length==0)
			{
				strErr+="bxSource不能为空！\\n";	
			}
			if(this.txtbxName.Text.Trim().Length==0)
			{
				strErr+="bxName不能为空！\\n";	
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
			string name=this.txtname.Text;
			string ageType=this.txtageType.Text;
			string cardType=this.txtcardType.Text;
			string price=this.txtprice.Text;
			string priceType=this.txtpriceType.Text;
			string cardNum=this.txtcardNum.Text;
			string eticketNum=this.txteticketNum.Text;
			string insuranceCount=this.txtinsuranceCount.Text;
			string bxSource=this.txtbxSource.Text;
			string bxName=this.txtbxName.Text;
			int o_id=int.Parse(this.txto_id.Text);

			Sanben.Model.Passenger model=new Sanben.Model.Passenger();
			model.name=name;
			model.ageType=ageType;
			model.cardType=cardType;
			model.price=price;
			model.priceType=priceType;
			model.cardNum=cardNum;
			model.eticketNum=eticketNum;
			model.insuranceCount=insuranceCount;
			model.bxSource=bxSource;
			model.bxName=bxName;
			model.o_id=o_id;

			Sanben.BLL.Passenger bll=new Sanben.BLL.Passenger();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
