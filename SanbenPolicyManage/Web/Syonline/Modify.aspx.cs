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
namespace Sanben.Web.Syonline
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
		Sanben.BLL.Syonline bll=new Sanben.BLL.Syonline();
		Sanben.Model.Syonline model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtloginname.Text=model.loginname;
		this.txtip.Text=model.ip;
		this.txtcreatedate.Text=model.createdate.ToString();
		this.chktype.Checked=model.type;
		this.txtipinfo.Text=model.ipinfo;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtloginname.Text.Trim().Length==0)
			{
				strErr+="loginname不能为空！\\n";	
			}
			if(this.txtip.Text.Trim().Length==0)
			{
				strErr+="ip不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtcreatedate.Text))
			{
				strErr+="createdate格式错误！\\n";	
			}
			if(this.txtipinfo.Text.Trim().Length==0)
			{
				strErr+="ipinfo不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string loginname=this.txtloginname.Text;
			string ip=this.txtip.Text;
			DateTime createdate=DateTime.Parse(this.txtcreatedate.Text);
			bool type=this.chktype.Checked;
			string ipinfo=this.txtipinfo.Text;


			Sanben.Model.Syonline model=new Sanben.Model.Syonline();
			model.id=id;
			model.loginname=loginname;
			model.ip=ip;
			model.createdate=createdate;
			model.type=type;
			model.ipinfo=ipinfo;

			Sanben.BLL.Syonline bll=new Sanben.BLL.Syonline();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
