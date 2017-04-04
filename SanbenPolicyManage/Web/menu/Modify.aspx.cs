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
namespace Sanben.Web.menu
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
		Sanben.BLL.menu bll=new Sanben.BLL.menu();
		Sanben.Model.menu model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txticon.Text=model.icon;
		this.txtmenuname.Text=model.menuname;
		this.txturl.Text=model.url;
		this.txtparentId.Text=model.parentId.ToString();
		this.txtsort.Text=model.sort.ToString();
		this.txtremark.Text=model.remark;
		this.chkstop.Checked=model.stop;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txticon.Text.Trim().Length==0)
			{
				strErr+="icon不能为空！\\n";	
			}
			if(this.txtmenuname.Text.Trim().Length==0)
			{
				strErr+="menuname不能为空！\\n";	
			}
			if(this.txturl.Text.Trim().Length==0)
			{
				strErr+="url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtparentId.Text))
			{
				strErr+="parentId格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsort.Text))
			{
				strErr+="sort格式错误！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string icon=this.txticon.Text;
			string menuname=this.txtmenuname.Text;
			string url=this.txturl.Text;
			int parentId=int.Parse(this.txtparentId.Text);
			int sort=int.Parse(this.txtsort.Text);
			string remark=this.txtremark.Text;
			bool stop=this.chkstop.Checked;


			Sanben.Model.menu model=new Sanben.Model.menu();
			model.id=id;
			model.icon=icon;
			model.menuname=menuname;
			model.url=url;
			model.parentId=parentId;
			model.sort=sort;
			model.remark=remark;
			model.stop=stop;

			Sanben.BLL.menu bll=new Sanben.BLL.menu();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
