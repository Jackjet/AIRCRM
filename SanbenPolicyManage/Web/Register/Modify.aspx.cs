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
namespace Sanben.Web.Register
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
		Sanben.BLL.Register bll=new Sanben.BLL.Register();
		Sanben.Model.Register model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtusername.Text=model.username;
		this.txtpassword.Text=model.password;
		this.txtcompany.Text=model.company;
		this.txtphone.Text=model.phone;
		this.txtname.Text=model.name;
		this.txtQQ.Text=model.QQ;
		this.txtidcard.Text=model.idcard;
		this.txtlogin_date.Text=model.login_date.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtusername.Text.Trim().Length==0)
			{
				strErr+="username不能为空！\\n";	
			}
			if(this.txtpassword.Text.Trim().Length==0)
			{
				strErr+="password不能为空！\\n";	
			}
			if(this.txtcompany.Text.Trim().Length==0)
			{
				strErr+="company不能为空！\\n";	
			}
			if(this.txtphone.Text.Trim().Length==0)
			{
				strErr+="phone不能为空！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtQQ.Text.Trim().Length==0)
			{
				strErr+="QQ不能为空！\\n";	
			}
			if(this.txtidcard.Text.Trim().Length==0)
			{
				strErr+="idcard不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtlogin_date.Text))
			{
				strErr+="login_date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string username=this.txtusername.Text;
			string password=this.txtpassword.Text;
			string company=this.txtcompany.Text;
			string phone=this.txtphone.Text;
			string name=this.txtname.Text;
			string QQ=this.txtQQ.Text;
			string idcard=this.txtidcard.Text;
			DateTime login_date=DateTime.Parse(this.txtlogin_date.Text);


			Sanben.Model.Register model=new Sanben.Model.Register();
			model.ID=ID;
			model.username=username;
			model.password=password;
			model.company=company;
			model.phone=phone;
			model.name=name;
			model.QQ=QQ;
			model.idcard=idcard;
			model.login_date=login_date;

			Sanben.BLL.Register bll=new Sanben.BLL.Register();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
