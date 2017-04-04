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
namespace Sanben.Web.Policy_Mission
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
		Sanben.BLL.Policy_Mission bll=new Sanben.BLL.Policy_Mission();
		Sanben.Model.Policy_Mission model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblFrom_code.Text=model.From_code;
		this.lblTo_code.Text=model.To_code;
		this.lblCompany.Text=model.Company;
		this.lblStatus.Text=model.Status.ToString();
		this.lblDate.Text=model.Date.ToString();

	}


    }
}
