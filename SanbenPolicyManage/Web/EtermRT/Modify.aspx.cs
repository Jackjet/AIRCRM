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
namespace Sanben.Web.EtermRT
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
		Sanben.BLL.EtermRT bll=new Sanben.BLL.EtermRT();
		Sanben.Model.EtermRT model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtEtermRTuser.Text=model.EtermRTuser;
		this.txtEtermRTpwd.Text=model.EtermRTpwd;
		this.txtairline.Text=model.airline;
		this.txteffect.Text=model.effect;
		this.txtuserID.Text=model.userID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtEtermRTuser.Text.Trim().Length==0)
			{
				strErr+="EtermRTuser不能为空！\\n";	
			}
			if(this.txtEtermRTpwd.Text.Trim().Length==0)
			{
				strErr+="EtermRTpwd不能为空！\\n";	
			}
			if(this.txtairline.Text.Trim().Length==0)
			{
				strErr+="airline不能为空！\\n";	
			}
			if(this.txteffect.Text.Trim().Length==0)
			{
				strErr+="effect不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string EtermRTuser=this.txtEtermRTuser.Text;
			string EtermRTpwd=this.txtEtermRTpwd.Text;
			string airline=this.txtairline.Text;
			string effect=this.txteffect.Text;
			int userID=int.Parse(this.txtuserID.Text);


			Sanben.Model.EtermRT model=new Sanben.Model.EtermRT();
			model.id=id;
			model.EtermRTuser=EtermRTuser;
			model.EtermRTpwd=EtermRTpwd;
			model.airline=airline;
			model.effect=effect;
			model.userID=userID;

			Sanben.BLL.EtermRT bll=new Sanben.BLL.EtermRT();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
