using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.OrderInfo2
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.OrderInfo2 bll=new Sanben.BLL.OrderInfo2();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int pk_id=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(pk_id);
				}
			}

        }
    }
}