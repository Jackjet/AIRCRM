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
namespace Sanben.Web.test_ado
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		Sanben.BLL.test_ado bll=new Sanben.BLL.test_ado();
		Sanben.Model.test_ado model=bll.GetModel();
		this.txtADD.Text=model.ADD;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtADD.Text.Trim().Length==0)
			{
				strErr+="ADD不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ADD=this.txtADD.Text;


			Sanben.Model.test_ado model=new Sanben.Model.test_ado();
			model.ADD=ADD;

			Sanben.BLL.test_ado bll=new Sanben.BLL.test_ado();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
