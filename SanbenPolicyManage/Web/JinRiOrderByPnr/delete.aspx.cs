using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.JinRiOrderByPnr
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.JinRiOrderByPnr bll=new Sanben.BLL.JinRiOrderByPnr();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(id);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}