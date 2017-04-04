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
namespace Sanben.Web.API380Ticket
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
		Sanben.BLL.API380Ticket bll=new Sanben.BLL.API380Ticket();
		Sanben.Model.API380Ticket model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtcode.Text=model.code.ToString();
		this.txtmessage.Text=model.message;
		this.txtbigpnr.Text=model.bigpnr;
		this.txtair.Text=model.air;
		this.txtpnr.Text=model.pnr;
		this.txtpaystatus.Text=model.paystatus;
		this.txttotaltax.Text=model.totaltax;
		this.txtticketprice.Text=model.ticketprice;
		this.txtorderno.Text=model.orderno;
		this.txtplatformB2B_name_id.Text=model.platformB2B_name_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtcode.Text))
			{
				strErr+="code格式错误！\\n";	
			}
			if(this.txtmessage.Text.Trim().Length==0)
			{
				strErr+="message不能为空！\\n";	
			}
			if(this.txtbigpnr.Text.Trim().Length==0)
			{
				strErr+="bigpnr不能为空！\\n";	
			}
			if(this.txtair.Text.Trim().Length==0)
			{
				strErr+="air不能为空！\\n";	
			}
			if(this.txtpnr.Text.Trim().Length==0)
			{
				strErr+="pnr不能为空！\\n";	
			}
			if(this.txtpaystatus.Text.Trim().Length==0)
			{
				strErr+="paystatus不能为空！\\n";	
			}
			if(this.txttotaltax.Text.Trim().Length==0)
			{
				strErr+="totaltax不能为空！\\n";	
			}
			if(this.txtticketprice.Text.Trim().Length==0)
			{
				strErr+="ticketprice不能为空！\\n";	
			}
			if(this.txtorderno.Text.Trim().Length==0)
			{
				strErr+="orderno不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatformB2B_name_id.Text))
			{
				strErr+="platformB2B_name_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			int code=int.Parse(this.txtcode.Text);
			string message=this.txtmessage.Text;
			string bigpnr=this.txtbigpnr.Text;
			string air=this.txtair.Text;
			string pnr=this.txtpnr.Text;
			string paystatus=this.txtpaystatus.Text;
			string totaltax=this.txttotaltax.Text;
			string ticketprice=this.txtticketprice.Text;
			string orderno=this.txtorderno.Text;
			int platformB2B_name_id=int.Parse(this.txtplatformB2B_name_id.Text);


			Sanben.Model.API380Ticket model=new Sanben.Model.API380Ticket();
			model.id=id;
			model.code=code;
			model.message=message;
			model.bigpnr=bigpnr;
			model.air=air;
			model.pnr=pnr;
			model.paystatus=paystatus;
			model.totaltax=totaltax;
			model.ticketprice=ticketprice;
			model.orderno=orderno;
			model.platformB2B_name_id=platformB2B_name_id;

			Sanben.BLL.API380Ticket bll=new Sanben.BLL.API380Ticket();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
