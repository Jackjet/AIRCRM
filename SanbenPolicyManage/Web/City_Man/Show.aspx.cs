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
namespace Sanben.Web.City_Man
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Sanben.BLL.City_Man bll=new Sanben.BLL.City_Man();
		Sanben.Model.City_Man model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblFrom_Code.Text=model.From_Code;
		this.lblTo_Code.Text=model.To_Code;
		this.lblStatus.Text=model.Status.ToString();
		this.lblDate.Text=model.Date.ToString();

	}


    }
}
