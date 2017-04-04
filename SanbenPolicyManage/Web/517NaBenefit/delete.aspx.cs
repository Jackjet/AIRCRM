using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sanben.Web.517NaBenefit
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Sanben.BLL.517NaBenefit bll=new Sanben.BLL.517NaBenefit();
				#warning 代码生成提示：删除页面,请检查确认传递过来的参数是否正确
				// bll.Delete();
			}

        }
    }
}