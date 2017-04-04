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
namespace Sanben.Web.Log_Opera
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
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Sanben.BLL.Log_Opera bll=new Sanben.BLL.Log_Opera();
		Sanben.Model.Log_Opera model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbloperator.Text=model.operator;
		this.lbltime.Text=model.time;
		this.lblaction.Text=model.action;
		this.lblo_id.Text=model.o_id.ToString();

	}


    }
}
