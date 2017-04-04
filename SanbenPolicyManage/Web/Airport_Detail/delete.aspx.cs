using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.Airport_Detail
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.Airport_Detail bll=new Sanben.BLL.Airport_Detail();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(ID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}