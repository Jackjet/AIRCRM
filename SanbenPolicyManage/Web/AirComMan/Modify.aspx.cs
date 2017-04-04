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
		Sanben.BLL.AirComMan bll=new Sanben.BLL.AirComMan();
		Sanben.Model.AirComMan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtCarrierCode.Text=model.CarrierCode;
		this.txtCarrierName.Text=model.CarrierName;
		this.txtCabin.Text=model.Cabin;
		this.txtDiscount.Text=model.Discount;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			string CarrierCode=this.txtCarrierCode.Text;
			string CarrierName=this.txtCarrierName.Text;
			string Cabin=this.txtCabin.Text;
			string Discount=this.txtDiscount.Text;


			Sanben.Model.AirComMan model=new Sanben.Model.AirComMan();
			model.id=id;
			model.CarrierCode=CarrierCode;
			model.CarrierName=CarrierName;
			model.Cabin=Cabin;
			model.Discount=Discount;

			Sanben.BLL.AirComMan bll=new Sanben.BLL.AirComMan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
