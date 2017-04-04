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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Sanben.Web.SystemConfig
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtAfterDays.Text.Trim().Length==0)
			{
				strErr+="AfterDays不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTimingDays.Text))
			{
				strErr+="TimingDays格式错误！\\n";	
			}
			if(this.txtAccount.Text.Trim().Length==0)
			{
				strErr+="Account不能为空！\\n";	
			}
			if(this.txtLogPath.Text.Trim().Length==0)
			{
				strErr+="LogPath不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtJinRiAmount.Text))
			{
				strErr+="JinRiAmount格式错误！\\n";	
			}
			if(this.txtJinRiBerth.Text.Trim().Length==0)
			{
				strErr+="JinRiBerth不能为空！\\n";	
			}
			if(this.txtJinRiRateWay.Text.Trim().Length==0)
			{
				strErr+="JinRiRateWay不能为空！\\n";	
			}
			if(this.txtJinRiUserType.Text.Trim().Length==0)
			{
				strErr+="JinRiUserType不能为空！\\n";	
			}
			if(this.txtJinRiUserName.Text.Trim().Length==0)
			{
				strErr+="JinRiUserName不能为空！\\n";	
			}
			if(this.txtJinRiVOYAGE.Text.Trim().Length==0)
			{
				strErr+="JinRiVOYAGE不能为空！\\n";	
			}
			if(this.txtServerAddress.Text.Trim().Length==0)
			{
				strErr+="ServerAddress不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtJinRiTiming.Text))
			{
				strErr+="JinRiTiming格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtC517natime.Text))
			{
				strErr+="C517natime格式错误！\\n";	
			}
			if(this.txtC517name.Text.Trim().Length==0)
			{
				strErr+="C517name不能为空！\\n";	
			}
			if(this.txtC517pid.Text.Trim().Length==0)
			{
				strErr+="C517pid不能为空！\\n";	
			}
			if(this.txtC517pidsafe.Text.Trim().Length==0)
			{
				strErr+="C517pidsafe不能为空！\\n";	
			}
			if(this.txtYi8000name.Text.Trim().Length==0)
			{
				strErr+="Yi8000name不能为空！\\n";	
			}
			if(this.txtYi8000psword.Text.Trim().Length==0)
			{
				strErr+="Yi8000psword不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtYi8000distime.Text))
			{
				strErr+="Yi8000distime格式错误！\\n";	
			}
			if(this.txtTicket380partner.Text.Trim().Length==0)
			{
				strErr+="Ticket380partner不能为空！\\n";	
			}
			if(this.txtTicket380key.Text.Trim().Length==0)
			{
				strErr+="Ticket380key不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtTicket380time.Text))
			{
				strErr+="Ticket380time格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTicket380timeadd.Text))
			{
				strErr+="Ticket380timeadd格式错误！\\n";	
			}
			if(this.txtTicket380gettime.Text.Trim().Length==0)
			{
				strErr+="Ticket380gettime不能为空！\\n";	
			}
			if(this.txtC51bookname.Text.Trim().Length==0)
			{
				strErr+="C51bookname不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtC51booktime.Text))
			{
				strErr+="C51booktime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtC51bookyear.Text))
			{
				strErr+="C51bookyear格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string AfterDays=this.txtAfterDays.Text;
			int TimingDays=int.Parse(this.txtTimingDays.Text);
			string Account=this.txtAccount.Text;
			string LogPath=this.txtLogPath.Text;
			int JinRiAmount=int.Parse(this.txtJinRiAmount.Text);
			string JinRiBerth=this.txtJinRiBerth.Text;
			string JinRiRateWay=this.txtJinRiRateWay.Text;
			string JinRiUserType=this.txtJinRiUserType.Text;
			string JinRiUserName=this.txtJinRiUserName.Text;
			string JinRiVOYAGE=this.txtJinRiVOYAGE.Text;
			string ServerAddress=this.txtServerAddress.Text;
			int JinRiTiming=int.Parse(this.txtJinRiTiming.Text);
			int C517natime=int.Parse(this.txtC517natime.Text);
			string C517name=this.txtC517name.Text;
			string C517pid=this.txtC517pid.Text;
			string C517pidsafe=this.txtC517pidsafe.Text;
			string Yi8000name=this.txtYi8000name.Text;
			string Yi8000psword=this.txtYi8000psword.Text;
			int Yi8000distime=int.Parse(this.txtYi8000distime.Text);
			string Ticket380partner=this.txtTicket380partner.Text;
			string Ticket380key=this.txtTicket380key.Text;
			int Ticket380time=int.Parse(this.txtTicket380time.Text);
			int Ticket380timeadd=int.Parse(this.txtTicket380timeadd.Text);
			string Ticket380gettime=this.txtTicket380gettime.Text;
			string C51bookname=this.txtC51bookname.Text;
			int C51booktime=int.Parse(this.txtC51booktime.Text);
			int C51bookyear=int.Parse(this.txtC51bookyear.Text);

			Sanben.Model.SystemConfig model=new Sanben.Model.SystemConfig();
			model.AfterDays=AfterDays;
			model.TimingDays=TimingDays;
			model.Account=Account;
			model.LogPath=LogPath;
			model.JinRiAmount=JinRiAmount;
			model.JinRiBerth=JinRiBerth;
			model.JinRiRateWay=JinRiRateWay;
			model.JinRiUserType=JinRiUserType;
			model.JinRiUserName=JinRiUserName;
			model.JinRiVOYAGE=JinRiVOYAGE;
			model.ServerAddress=ServerAddress;
			model.JinRiTiming=JinRiTiming;
			model.C517natime=C517natime;
			model.C517name=C517name;
			model.C517pid=C517pid;
			model.C517pidsafe=C517pidsafe;
			model.Yi8000name=Yi8000name;
			model.Yi8000psword=Yi8000psword;
			model.Yi8000distime=Yi8000distime;
			model.Ticket380partner=Ticket380partner;
			model.Ticket380key=Ticket380key;
			model.Ticket380time=Ticket380time;
			model.Ticket380timeadd=Ticket380timeadd;
			model.Ticket380gettime=Ticket380gettime;
			model.C51bookname=C51bookname;
			model.C51booktime=C51booktime;
			model.C51bookyear=C51bookyear;

			Sanben.BLL.SystemConfig bll=new Sanben.BLL.SystemConfig();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
