using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.Table_1
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.Table_1 bll=new Sanben.BLL.Table_1();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id= Request.Params["id"];
					bll.Delete(id);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}