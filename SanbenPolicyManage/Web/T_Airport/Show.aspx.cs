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
namespace Sanben.Web.T_Airport
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
		Sanben.BLL.T_Airport bll=new Sanben.BLL.T_Airport();
		Sanben.Model.T_Airport model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblairport_code.Text=model.airport_code;
		this.lblairport_city.Text=model.airport_city;
		this.lblairport_name.Text=model.airport_name;

	}


    }
}
