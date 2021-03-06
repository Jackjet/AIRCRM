﻿using System;
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
namespace Sanben.Web.menu
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
		Sanben.BLL.menu bll=new Sanben.BLL.menu();
		Sanben.Model.menu model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblicon.Text=model.icon;
		this.lblmenuname.Text=model.menuname;
		this.lblurl.Text=model.url;
		this.lblparentId.Text=model.parentId.ToString();
		this.lblsort.Text=model.sort.ToString();
		this.lblremark.Text=model.remark;
		this.lblstop.Text=model.stop?"是":"否";

	}


    }
}
