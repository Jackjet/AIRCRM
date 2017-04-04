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
namespace Sanben.Web.Log_Opera
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
		Sanben.BLL.Log_Opera bll=new Sanben.BLL.Log_Opera();
		Sanben.Model.Log_Opera model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtoperator.Text=model.operator;
		this.txttime.Text=model.time;
		this.txtaction.Text=model.action;
		this.txto_id.Text=model.o_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtoperator.Text.Trim().Length==0)
			{
				strErr+="operator不能为空！\\n";	
			}
			if(this.txttime.Text.Trim().Length==0)
			{
				strErr+="time不能为空！\\n";	
			}
			if(this.txtaction.Text.Trim().Length==0)
			{
				strErr+="action不能为空！\\n";	
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
			string operator=this.txtoperator.Text;
			string time=this.txttime.Text;
			string action=this.txtaction.Text;
			int o_id=int.Parse(this.txto_id.Text);


			Sanben.Model.Log_Opera model=new Sanben.Model.Log_Opera();
			model.id=id;
			model.operator=operator;
			model.time=time;
			model.action=action;
			model.o_id=o_id;

			Sanben.BLL.Log_Opera bll=new Sanben.BLL.Log_Opera();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
