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
namespace Sanben.Web.EtermRT
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
		Sanben.BLL.EtermRT bll=new Sanben.BLL.EtermRT();
		Sanben.Model.EtermRT model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblEtermRTuser.Text=model.EtermRTuser;
		this.lblEtermRTpwd.Text=model.EtermRTpwd;
		this.lblairline.Text=model.airline;
		this.lbleffect.Text=model.effect;
		this.lbluserID.Text=model.userID.ToString();

	}


    }
}
