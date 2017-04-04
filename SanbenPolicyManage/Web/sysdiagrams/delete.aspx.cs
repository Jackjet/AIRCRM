using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.sysdiagrams
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.sysdiagrams bll=new Sanben.BLL.sysdiagrams();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int diagram_id=(Convert.ToInt32(Request.Params["id"]));
				bll.Delete(diagram_id);
				}
			}

        }
    }
}