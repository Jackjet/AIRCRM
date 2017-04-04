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
		Sanben.BLL.Passenger bll=new Sanben.BLL.Passenger();
		Sanben.Model.Passenger model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtageType.Text=model.ageType;
		this.txtcardType.Text=model.cardType;
		this.txtprice.Text=model.price;
		this.txtpriceType.Text=model.priceType;
		this.txtcardNum.Text=model.cardNum;
		this.txteticketNum.Text=model.eticketNum;
		this.txtinsuranceCount.Text=model.insuranceCount;
		this.txtbxSource.Text=model.bxSource;
		this.txtbxName.Text=model.bxName;
		this.txto_id.Text=model.o_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
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
			model.id=id;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
