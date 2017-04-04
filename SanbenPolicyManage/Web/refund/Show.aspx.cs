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
namespace Sanben.Web.refund
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
		Sanben.BLL.refund bll=new Sanben.BLL.refund();
		Sanben.Model.refund model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblrefund_time.Text=model.refund_time;
		this.lblrefund_price.Text=model.refund_price;
		this.lblrefund_no.Text=model.refund_no;
		this.lbltype.Text=model.type;
		this.lblo_id.Text=model.o_id.ToString();

	}


    }
}
