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
namespace Sanben.Web.Table_1
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
					string id= strid;
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(string id)
	{
		Sanben.BLL.Table_1 bll=new Sanben.BLL.Table_1();
		Sanben.Model.Table_1 model=bll.GetModel(id);
		this.lblid.Text=model.id;
		this.lblname.Text=model.name;
		this.lblsex.Text=model.sex;
		this.lblage.Text=model.age;

	}


    }
}
