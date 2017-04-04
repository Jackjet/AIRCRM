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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Sanben.Web.sysdiagrams
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int diagram_id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(diagram_id);
				}
			}
		}
			
	private void ShowInfo(int diagram_id)
	{
		Sanben.BLL.sysdiagrams bll=new Sanben.BLL.sysdiagrams();
		Sanben.Model.sysdiagrams model=bll.GetModel(diagram_id);
		this.lblname.Text=model.name;
		this.lblprincipal_id.Text=model.principal_id.ToString();
		this.lbldiagram_id.Text=model.diagram_id.ToString();
		this.txtversion.Text=model.version.ToString();
		this.txtdefinition.Text=model.definition.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtversion.Text))
			{
				strErr+="version格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.lblname.Text;
			int principal_id=int.Parse(this.lblprincipal_id.Text);
			int diagram_id=int.Parse(this.lbldiagram_id.Text);
			int version=int.Parse(this.txtversion.Text);
			byte[] definition= new UnicodeEncoding().GetBytes(this.txtdefinition.Text);


			Sanben.Model.sysdiagrams model=new Sanben.Model.sysdiagrams();
			model.name=name;
			model.principal_id=principal_id;
			model.diagram_id=diagram_id;
			model.version=version;
			model.definition=definition;

			Sanben.BLL.sysdiagrams bll=new Sanben.BLL.sysdiagrams();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
