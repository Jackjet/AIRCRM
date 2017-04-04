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
namespace Sanben.Web.platformB2B_ticket_account
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
		Sanben.BLL.platformB2B_ticket_account bll=new Sanben.BLL.platformB2B_ticket_account();
		Sanben.Model.platformB2B_ticket_account model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtMaccount.Text=model.Maccount;
		this.txtCaccount.Text=model.Caccount;
		this.txtpaysrc.Text=model.paysrc;
		this.txtpaytype.Text=model.paytype;
		this.txtsysUserId.Text=model.sysUserId.ToString();
		this.txtplatformName_id.Text=model.platformName_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMaccount.Text.Trim().Length==0)
			{
				strErr+="Maccount不能为空！\\n";	
			}
			if(this.txtCaccount.Text.Trim().Length==0)
			{
				strErr+="Caccount不能为空！\\n";	
			}
			if(this.txtpaysrc.Text.Trim().Length==0)
			{
				strErr+="paysrc不能为空！\\n";	
			}
			if(this.txtpaytype.Text.Trim().Length==0)
			{
				strErr+="paytype不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtsysUserId.Text))
			{
				strErr+="sysUserId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatformName_id.Text))
			{
				strErr+="platformName_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string Maccount=this.txtMaccount.Text;
			string Caccount=this.txtCaccount.Text;
			string paysrc=this.txtpaysrc.Text;
			string paytype=this.txtpaytype.Text;
			int sysUserId=int.Parse(this.txtsysUserId.Text);
			int platformName_id=int.Parse(this.txtplatformName_id.Text);


			Sanben.Model.platformB2B_ticket_account model=new Sanben.Model.platformB2B_ticket_account();
			model.id=id;
			model.Maccount=Maccount;
			model.Caccount=Caccount;
			model.paysrc=paysrc;
			model.paytype=paytype;
			model.sysUserId=sysUserId;
			model.platformName_id=platformName_id;

			Sanben.BLL.platformB2B_ticket_account bll=new Sanben.BLL.platformB2B_ticket_account();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
