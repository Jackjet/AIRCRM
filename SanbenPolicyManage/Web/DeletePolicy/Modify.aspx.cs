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
namespace Sanben.Web.DeletePolicy
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
		Sanben.BLL.DeletePolicy bll=new Sanben.BLL.DeletePolicy();
		Sanben.Model.DeletePolicy model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtflightcode.Text=model.flightcode;
		this.txtpolicyCode.Text=model.policyCode;
		this.txtdpt.Text=model.dpt;
		this.txtarr.Text=model.arr;
		this.txtcabin.Text=model.cabin;
		this.txtstartdate.Text=model.startdate.ToString();
		this.txtenddate.Text=model.enddate.ToString();
		this.txtsys_id.Text=model.sys_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtflightcode.Text.Trim().Length==0)
			{
				strErr+="flightcode不能为空！\\n";	
			}
			if(this.txtpolicyCode.Text.Trim().Length==0)
			{
				strErr+="policyCode不能为空！\\n";	
			}
			if(this.txtdpt.Text.Trim().Length==0)
			{
				strErr+="dpt不能为空！\\n";	
			}
			if(this.txtarr.Text.Trim().Length==0)
			{
				strErr+="arr不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartdate.Text))
			{
				strErr+="startdate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtenddate.Text))
			{
				strErr+="enddate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string flightcode=this.txtflightcode.Text;
			string policyCode=this.txtpolicyCode.Text;
			string dpt=this.txtdpt.Text;
			string arr=this.txtarr.Text;
			string cabin=this.txtcabin.Text;
			DateTime startdate=DateTime.Parse(this.txtstartdate.Text);
			DateTime enddate=DateTime.Parse(this.txtenddate.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);


			Sanben.Model.DeletePolicy model=new Sanben.Model.DeletePolicy();
			model.id=id;
			model.flightcode=flightcode;
			model.policyCode=policyCode;
			model.dpt=dpt;
			model.arr=arr;
			model.cabin=cabin;
			model.startdate=startdate;
			model.enddate=enddate;
			model.sys_id=sys_id;

			Sanben.BLL.DeletePolicy bll=new Sanben.BLL.DeletePolicy();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
