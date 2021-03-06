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
namespace Sanben.Web.EtermRT
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtEtermRTuser.Text.Trim().Length==0)
			{
				strErr+="EtermRTuser不能为空！\\n";	
			}
			if(this.txtEtermRTpwd.Text.Trim().Length==0)
			{
				strErr+="EtermRTpwd不能为空！\\n";	
			}
			if(this.txtairline.Text.Trim().Length==0)
			{
				strErr+="airline不能为空！\\n";	
			}
			if(this.txteffect.Text.Trim().Length==0)
			{
				strErr+="effect不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuserID.Text))
			{
				strErr+="userID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string EtermRTuser=this.txtEtermRTuser.Text;
			string EtermRTpwd=this.txtEtermRTpwd.Text;
			string airline=this.txtairline.Text;
			string effect=this.txteffect.Text;
			int userID=int.Parse(this.txtuserID.Text);

			Sanben.Model.EtermRT model=new Sanben.Model.EtermRT();
			model.EtermRTuser=EtermRTuser;
			model.EtermRTpwd=EtermRTpwd;
			model.airline=airline;
			model.effect=effect;
			model.userID=userID;

			Sanben.BLL.EtermRT bll=new Sanben.BLL.EtermRT();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
