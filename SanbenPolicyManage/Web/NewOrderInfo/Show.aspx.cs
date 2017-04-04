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
namespace Sanben.Web.NewOrderInfo
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int pk_id=(Convert.ToInt32(strid));
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


    }
}
