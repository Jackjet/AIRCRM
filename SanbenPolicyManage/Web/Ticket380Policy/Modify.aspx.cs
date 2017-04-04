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
namespace Sanben.Web.Ticket380Policy
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Sanben.BLL.Ticket380Policy bll=new Sanben.BLL.Ticket380Policy();
		Sanben.Model.Ticket380Policy model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtpolicy_id.Text=model.policy_id;
		this.txtair_comp.Text=model.air_comp;
		this.txtstart_city.Text=model.start_city;
		this.txtarr_city.Text=model.arr_city;
		this.txtflight.Text=model.flight;
		this.txtcabin.Text=model.cabin;
		this.txtshare_line.Text=model.share_line;
		this.txtcabinprice.Text=model.cabinprice;
		this.txtpoint.Text=model.point;
		this.txtnakednum.Text=model.nakednum;
		this.txtis_auto_tic.Text=model.is_auto_tic;
		this.txtlogtime.Text=model.logtime;
		this.txtdeptime.Text=model.deptime;
		this.txtprice.Text=model.price;
		this.txtremark.Text=model.remark;
		this.txtfsdate.Text=model.fsdate;
		this.txtfedate.Text=model.fedate;
		this.txtsale_sdate.Text=model.sale_sdate;
		this.txtsale_edate.Text=model.sale_edate;
		this.txtAddTime.Text=model.AddTime.ToString();
		this.chkIsUpload.Checked=model.IsUpload;
		this.chkIsUpdate.Checked=model.IsUpdate;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtpolicy_id.Text.Trim().Length==0)
			{
				strErr+="policy_id不能为空！\\n";	
			}
			if(this.txtair_comp.Text.Trim().Length==0)
			{
				strErr+="air_comp不能为空！\\n";	
			}
			if(this.txtstart_city.Text.Trim().Length==0)
			{
				strErr+="start_city不能为空！\\n";	
			}
			if(this.txtarr_city.Text.Trim().Length==0)
			{
				strErr+="arr_city不能为空！\\n";	
			}
			if(this.txtflight.Text.Trim().Length==0)
			{
				strErr+="flight不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(this.txtshare_line.Text.Trim().Length==0)
			{
				strErr+="share_line不能为空！\\n";	
			}
			if(this.txtcabinprice.Text.Trim().Length==0)
			{
				strErr+="cabinprice不能为空！\\n";	
			}
			if(this.txtpoint.Text.Trim().Length==0)
			{
				strErr+="point不能为空！\\n";	
			}
			if(this.txtnakednum.Text.Trim().Length==0)
			{
				strErr+="nakednum不能为空！\\n";	
			}
			if(this.txtis_auto_tic.Text.Trim().Length==0)
			{
				strErr+="is_auto_tic不能为空！\\n";	
			}
			if(this.txtlogtime.Text.Trim().Length==0)
			{
				strErr+="logtime不能为空！\\n";	
			}
			if(this.txtdeptime.Text.Trim().Length==0)
			{
				strErr+="deptime不能为空！\\n";	
			}
			if(this.txtprice.Text.Trim().Length==0)
			{
				strErr+="price不能为空！\\n";	
			}
			if(this.txtremark.Text.Trim().Length==0)
			{
				strErr+="remark不能为空！\\n";	
			}
			if(this.txtfsdate.Text.Trim().Length==0)
			{
				strErr+="fsdate不能为空！\\n";	
			}
			if(this.txtfedate.Text.Trim().Length==0)
			{
				strErr+="fedate不能为空！\\n";	
			}
			if(this.txtsale_sdate.Text.Trim().Length==0)
			{
				strErr+="sale_sdate不能为空！\\n";	
			}
			if(this.txtsale_edate.Text.Trim().Length==0)
			{
				strErr+="sale_edate不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddTime.Text))
			{
				strErr+="AddTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string policy_id=this.txtpolicy_id.Text;
			string air_comp=this.txtair_comp.Text;
			string start_city=this.txtstart_city.Text;
			string arr_city=this.txtarr_city.Text;
			string flight=this.txtflight.Text;
			string cabin=this.txtcabin.Text;
			string share_line=this.txtshare_line.Text;
			string cabinprice=this.txtcabinprice.Text;
			string point=this.txtpoint.Text;
			string nakednum=this.txtnakednum.Text;
			string is_auto_tic=this.txtis_auto_tic.Text;
			string logtime=this.txtlogtime.Text;
			string deptime=this.txtdeptime.Text;
			string price=this.txtprice.Text;
			string remark=this.txtremark.Text;
			string fsdate=this.txtfsdate.Text;
			string fedate=this.txtfedate.Text;
			string sale_sdate=this.txtsale_sdate.Text;
			string sale_edate=this.txtsale_edate.Text;
			DateTime AddTime=DateTime.Parse(this.txtAddTime.Text);
			bool IsUpload=this.chkIsUpload.Checked;
			bool IsUpdate=this.chkIsUpdate.Checked;


			Sanben.Model.Ticket380Policy model=new Sanben.Model.Ticket380Policy();
			model.ID=ID;
			model.policy_id=policy_id;
			model.air_comp=air_comp;
			model.start_city=start_city;
			model.arr_city=arr_city;
			model.flight=flight;
			model.cabin=cabin;
			model.share_line=share_line;
			model.cabinprice=cabinprice;
			model.point=point;
			model.nakednum=nakednum;
			model.is_auto_tic=is_auto_tic;
			model.logtime=logtime;
			model.deptime=deptime;
			model.price=price;
			model.remark=remark;
			model.fsdate=fsdate;
			model.fedate=fedate;
			model.sale_sdate=sale_sdate;
			model.sale_edate=sale_edate;
			model.AddTime=AddTime;
			model.IsUpload=IsUpload;
			model.IsUpdate=IsUpdate;

			Sanben.BLL.Ticket380Policy bll=new Sanben.BLL.Ticket380Policy();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
