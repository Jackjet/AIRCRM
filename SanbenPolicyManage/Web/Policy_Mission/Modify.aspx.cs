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
namespace Sanben.Web.Policy_Mission
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Sanben.BLL.Policy_Mission bll=new Sanben.BLL.Policy_Mission();
		Sanben.Model.Policy_Mission model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtFrom_code.Text=model.From_code;
		this.txtTo_code.Text=model.To_code;
		this.txtCompany.Text=model.Company;
		this.txtStatus.Text=model.Status.ToString();
		this.txtDate.Text=model.Date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFrom_code.Text.Trim().Length==0)
			{
				strErr+="From_code不能为空！\\n";	
			}
			if(this.txtTo_code.Text.Trim().Length==0)
			{
				strErr+="To_code不能为空！\\n";	
			}
			if(this.txtCompany.Text.Trim().Length==0)
			{
				strErr+="Company不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtStatus.Text))
			{
				strErr+="Status格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDate.Text))
			{
				strErr+="Date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string From_code=this.txtFrom_code.Text;
			string To_code=this.txtTo_code.Text;
			string Company=this.txtCompany.Text;
			int Status=int.Parse(this.txtStatus.Text);
			DateTime Date=DateTime.Parse(this.txtDate.Text);


			Sanben.Model.Policy_Mission model=new Sanben.Model.Policy_Mission();
			model.ID=ID;
			model.From_code=From_code;
			model.To_code=To_code;
			model.Company=Company;
			model.Status=Status;
			model.Date=Date;

			Sanben.BLL.Policy_Mission bll=new Sanben.BLL.Policy_Mission();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
