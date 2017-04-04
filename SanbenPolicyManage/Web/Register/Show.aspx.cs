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
namespace Sanben.Web.Register
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
		Sanben.BLL.Register bll=new Sanben.BLL.Register();
		Sanben.Model.Register model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblusername.Text=model.username;
		this.lblpassword.Text=model.password;
		this.lblcompany.Text=model.company;
		this.lblphone.Text=model.phone;
		this.lblname.Text=model.name;
		this.lblQQ.Text=model.QQ;
		this.lblidcard.Text=model.idcard;
		this.lbllogin_date.Text=model.login_date.ToString();

	}


    }
}
