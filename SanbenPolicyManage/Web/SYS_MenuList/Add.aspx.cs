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
namespace Sanben.Web.SYS_MenuList
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtText.Text.Trim().Length==0)
			{
				strErr+="模块ID不能为空！\\n";	
			}
			if(this.txtTabID.Text.Trim().Length==0)
			{
				strErr+="TabID不能为空！\\n";	
			}
			if(this.txtNavigateUrl.Text.Trim().Length==0)
			{
				strErr+="权限ID不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtParentID.Text))
			{
				strErr+="ParentID格式错误！\\n";	
			}
			if(this.txtIcon.Text.Trim().Length==0)
			{
				strErr+="Icon不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtOrdering.Text))
			{
				strErr+="Ordering格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtVersion.Text))
			{
				strErr+="Version格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsort.Text))
			{
				strErr+="sort格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Text=this.txtText.Text;
			string TabID=this.txtTabID.Text;
			string NavigateUrl=this.txtNavigateUrl.Text;
			int ParentID=int.Parse(this.txtParentID.Text);
			bool SingleClickExpand=this.chkSingleClickExpand.Checked;
			string Icon=this.txtIcon.Text;
			bool IsModule=this.chkIsModule.Checked;
			bool IsFuntion=this.chkIsFuntion.Checked;
			int Ordering=int.Parse(this.txtOrdering.Text);
			bool Stop=this.chkStop.Checked;
			string Remark=this.txtRemark.Text;
			DateTime Version=DateTime.Parse(this.txtVersion.Text);
			int sort=int.Parse(this.txtsort.Text);

			Sanben.Model.SYS_MenuList model=new Sanben.Model.SYS_MenuList();
			model.Text=Text;
			model.TabID=TabID;
			model.NavigateUrl=NavigateUrl;
			model.ParentID=ParentID;
			model.SingleClickExpand=SingleClickExpand;
			model.Icon=Icon;
			model.IsModule=IsModule;
			model.IsFuntion=IsFuntion;
			model.Ordering=Ordering;
			model.Stop=Stop;
			model.Remark=Remark;
			model.Version=Version;
			model.sort=sort;

			Sanben.BLL.SYS_MenuList bll=new Sanben.BLL.SYS_MenuList();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
