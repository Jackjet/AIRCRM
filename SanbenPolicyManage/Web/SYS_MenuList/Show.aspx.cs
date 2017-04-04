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
namespace Sanben.Web.SYS_MenuList
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
		Sanben.BLL.SYS_MenuList bll=new Sanben.BLL.SYS_MenuList();
		Sanben.Model.SYS_MenuList model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblText.Text=model.Text;
		this.lblTabID.Text=model.TabID;
		this.lblNavigateUrl.Text=model.NavigateUrl;
		this.lblParentID.Text=model.ParentID.ToString();
		this.lblSingleClickExpand.Text=model.SingleClickExpand?"是":"否";
		this.lblIcon.Text=model.Icon;
		this.lblIsModule.Text=model.IsModule?"是":"否";
		this.lblIsFuntion.Text=model.IsFuntion?"是":"否";
		this.lblOrdering.Text=model.Ordering.ToString();
		this.lblStop.Text=model.Stop?"是":"否";
		this.lblRemark.Text=model.Remark;
		this.lblVersion.Text=model.Version.ToString();
		this.lblsort.Text=model.sort.ToString();

	}


    }
}
