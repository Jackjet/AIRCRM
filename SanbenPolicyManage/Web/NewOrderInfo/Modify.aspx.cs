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
namespace Sanben.Web.NewOrderInfo
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int pk_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(pk_id);
				}
			}
		}
			
	private void ShowInfo(int pk_id)
	{
		Sanben.BLL.NewOrderInfo bll=new Sanben.BLL.NewOrderInfo();
		Sanben.Model.NewOrderInfo model=bll.GetModel(pk_id);
		this.lblpk_id.Text=model.pk_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int pk_id=int.Parse(this.lblpk_id.Text);


			Sanben.Model.NewOrderInfo model=new Sanben.Model.NewOrderInfo();
			model.pk_id=pk_id;

			Sanben.BLL.NewOrderInfo bll=new Sanben.BLL.NewOrderInfo();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
