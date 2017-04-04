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
namespace Sanben.Web.AirMan
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
		Sanben.BLL.AirMan bll=new Sanben.BLL.AirMan();
		Sanben.Model.AirMan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtStartCode.Text=model.StartCode;
		this.txtArriveCode.Text=model.ArriveCode;
		this.txtCarrierName.Text=model.CarrierName;
		this.txtStatus.Text=model.Status;
		this.txtAddTime.Text=model.AddTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtStartCode.Text.Trim().Length==0)
			{
				strErr+="StartCode不能为空！\\n";	
			}
			if(this.txtArriveCode.Text.Trim().Length==0)
			{
				strErr+="ArriveCode不能为空！\\n";	
			}
			if(this.txtCarrierName.Text.Trim().Length==0)
			{
				strErr+="CarrierName不能为空！\\n";	
			}
			if(this.txtStatus.Text.Trim().Length==0)
			{
				strErr+="Status不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string StartCode=this.txtStartCode.Text;
			string ArriveCode=this.txtArriveCode.Text;
			string CarrierName=this.txtCarrierName.Text;
			string Status=this.txtStatus.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);


			Sanben.Model.AirMan model=new Sanben.Model.AirMan();
			model.id=id;
			model.StartCode=StartCode;
			model.ArriveCode=ArriveCode;
			model.CarrierName=CarrierName;
			model.Status=Status;
			model.AddTime=AddTime;

			Sanben.BLL.AirMan bll=new Sanben.BLL.AirMan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
