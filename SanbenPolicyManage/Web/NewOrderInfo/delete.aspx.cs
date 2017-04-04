using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.NewOrderInfo
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.NewOrderInfo bll=new Sanben.BLL.NewOrderInfo();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int pk_id=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(pk_id);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}