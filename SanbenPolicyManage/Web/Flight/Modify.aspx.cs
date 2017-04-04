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
namespace Sanben.Web.Flight
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
		Sanben.BLL.Flight bll=new Sanben.BLL.Flight();
		Sanben.Model.Flight model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtcode.Text=model.code;
		this.txtcabin.Text=model.cabin;
		this.txtccabin.Text=model.ccabin;
		this.txtdep.Text=model.dep;
		this.txtarr.Text=model.arr;
		this.txtdepDay.Text=model.depDay;
		this.txtdepTime.Text=model.depTime;
		this.txtarrTime.Text=model.arrTime;
		this.txtrealCode.Text=model.realCode;
		this.txto_id.Text=model.o_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtcode.Text.Trim().Length==0)
			{
				strErr+="code不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(this.txtccabin.Text.Trim().Length==0)
			{
				strErr+="ccabin不能为空！\\n";	
			}
			if(this.txtdep.Text.Trim().Length==0)
			{
				strErr+="dep不能为空！\\n";	
			}
			if(this.txtarr.Text.Trim().Length==0)
			{
				strErr+="arr不能为空！\\n";	
			}
			if(this.txtdepDay.Text.Trim().Length==0)
			{
				strErr+="depDay不能为空！\\n";	
			}
			if(this.txtdepTime.Text.Trim().Length==0)
			{
				strErr+="depTime不能为空！\\n";	
			}
			if(this.txtarrTime.Text.Trim().Length==0)
			{
				strErr+="arrTime不能为空！\\n";	
			}
			if(this.txtrealCode.Text.Trim().Length==0)
			{
				strErr+="realCode不能为空！\\n";	
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
			string code=this.txtcode.Text;
			string cabin=this.txtcabin.Text;
			string ccabin=this.txtccabin.Text;
			string dep=this.txtdep.Text;
			string arr=this.txtarr.Text;
			string depDay=this.txtdepDay.Text;
			string depTime=this.txtdepTime.Text;
			string arrTime=this.txtarrTime.Text;
			string realCode=this.txtrealCode.Text;
			int o_id=int.Parse(this.txto_id.Text);


			Sanben.Model.Flight model=new Sanben.Model.Flight();
			model.id=id;
			model.code=code;
			model.cabin=cabin;
			model.ccabin=ccabin;
			model.dep=dep;
			model.arr=arr;
			model.depDay=depDay;
			model.depTime=depTime;
			model.arrTime=arrTime;
			model.realCode=realCode;
			model.o_id=o_id;

			Sanben.BLL.Flight bll=new Sanben.BLL.Flight();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
