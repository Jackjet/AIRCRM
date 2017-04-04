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
namespace Sanben.Web.City_Man
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
		Sanben.BLL.City_Man bll=new Sanben.BLL.City_Man();
		Sanben.Model.City_Man model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtFrom_Code.Text=model.From_Code;
		this.txtTo_Code.Text=model.To_Code;
		this.txtStatus.Text=model.Status.ToString();
		this.txtDate.Text=model.Date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtFrom_Code.Text.Trim().Length==0)
			{
				strErr+="From_Code不能为空！\\n";	
			}
			if(this.txtTo_Code.Text.Trim().Length==0)
			{
				strErr+="To_Code不能为空！\\n";	
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
			string From_Code=this.txtFrom_Code.Text;
			string To_Code=this.txtTo_Code.Text;
			int Status=int.Parse(this.txtStatus.Text);
			DateTime Date=DateTime.Parse(this.txtDate.Text);


			Sanben.Model.City_Man model=new Sanben.Model.City_Man();
			model.ID=ID;
			model.From_Code=From_Code;
			model.To_Code=To_Code;
			model.Status=Status;
			model.Date=Date;

			Sanben.BLL.City_Man bll=new Sanben.BLL.City_Man();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
