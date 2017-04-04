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
namespace Sanben.Web.policy_zy_Base
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Sanben.BLL.policy_zy_Base bll=new Sanben.BLL.policy_zy_Base();
		Sanben.Model.policy_zy_Base model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtleavepoint.Text=model.leavepoint.ToString();
		this.txtleavemoney.Text=model.leavemoney.ToString();
		this.chkis_filter.Checked=model.is_filter;
		this.txtstarttime.Text=model.starttime.ToString();
		this.txtendtime.Text=model.endtime.ToString();
		this.txtlowest_rebate.Text=model.lowest_rebate.ToString();
		this.txthighest_rebate.Text=model.highest_rebate.ToString();
		this.txtearliest_advance_days.Text=model.earliest_advance_days.ToString();
		this.txtnight_before_days.Text=model.night_before_days.ToString();
		this.txtpointSetType.Text=model.pointSetType.ToString();
		this.chkisuploadfirstclass.Checked=model.isuploadfirstclass;
		this.chkisuploadchildclass.Checked=model.isuploadchildclass;
		this.chkNFDpolicy.Checked=model.NFDpolicy;
		this.txtflylimittime.Text=model.flylimittime;
		this.txtplatfromPolicy.Text=model.platfromPolicy;
		this.txtGWpolicy.Text=model.GWpolicy;
		this.chkuploadway.Checked=model.uploadway;
		this.chkisuploadsharefight.Checked=model.isuploadsharefight;
		this.chkaddpricejisuan.Checked=model.addpricejisuan;
		this.txtaddpriceCovertType.Text=model.addpriceCovertType.ToString();
		this.txtaddPriceSet.Text=model.addPriceSet.ToString();
		this.txtlimitSit.Text=model.limitSit.ToString();
		this.txtsaleSit.Text=model.saleSit.ToString();
		this.chkis_autoticket.Checked=model.is_autoticket;
		this.chkis_Need.Checked=model.is_Need;
		this.txtisMail.Text=model.isMail.ToString();
		this.chkisPay.Checked=model.isPay;
		this.txtAuthorizeOffice.Text=model.AuthorizeOffice;
		this.txtrefund_rule.Text=model.refund_rule;
		this.txtchangedate_rule.Text=model.changedate_rule;
		this.chkis_allowed_sign.Checked=model.is_allowed_sign;
		this.chkis_provide_regular_passenger_integral.Checked=model.is_provide_regular_passenger_integral;
		this.txtdocument_type.Text=model.document_type.ToString();
		this.txtmaxage.Text=model.maxage.ToString();
		this.txtminage.Text=model.minage.ToString();
		this.txtclass_description.Text=model.class_description;
		this.txtspecial_ticketing_instructions.Text=model.special_ticketing_instructions;
		this.txtlowest_price.Text=model.lowest_price.ToString();
		this.txthighest_price.Text=model.highest_price.ToString();
		this.txtlastupdatetime.Text=model.lastupdatetime.ToString();
		this.txtsysuser_id.Text=model.sysuser_id.ToString();
		this.txtplatform_id.Text=model.platform_id.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDecimal(txtleavepoint.Text))
			{
				strErr+="leavepoint格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtleavemoney.Text))
			{
				strErr+="leavemoney格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstarttime.Text))
			{
				strErr+="starttime格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtendtime.Text))
			{
				strErr+="endtime格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlowest_rebate.Text))
			{
				strErr+="lowest_rebate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txthighest_rebate.Text))
			{
				strErr+="highest_rebate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtearliest_advance_days.Text))
			{
				strErr+="earliest_advance_days格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtnight_before_days.Text))
			{
				strErr+="night_before_days格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpointSetType.Text))
			{
				strErr+="pointSetType格式错误！\\n";	
			}
			if(this.txtflylimittime.Text.Trim().Length==0)
			{
				strErr+="flylimittime不能为空！\\n";	
			}
			if(this.txtplatfromPolicy.Text.Trim().Length==0)
			{
				strErr+="platfromPolicy不能为空！\\n";	
			}
			if(this.txtGWpolicy.Text.Trim().Length==0)
			{
				strErr+="GWpolicy不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtaddpriceCovertType.Text))
			{
				strErr+="addpriceCovertType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtaddPriceSet.Text))
			{
				strErr+="addPriceSet格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlimitSit.Text))
			{
				strErr+="limitSit格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsaleSit.Text))
			{
				strErr+="saleSit格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisMail.Text))
			{
				strErr+="isMail格式错误！\\n";	
			}
			if(this.txtAuthorizeOffice.Text.Trim().Length==0)
			{
				strErr+="AuthorizeOffice不能为空！\\n";	
			}
			if(this.txtrefund_rule.Text.Trim().Length==0)
			{
				strErr+="refund_rule不能为空！\\n";	
			}
			if(this.txtchangedate_rule.Text.Trim().Length==0)
			{
				strErr+="changedate_rule不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtdocument_type.Text))
			{
				strErr+="document_type格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmaxage.Text))
			{
				strErr+="maxage格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtminage.Text))
			{
				strErr+="minage格式错误！\\n";	
			}
			if(this.txtclass_description.Text.Trim().Length==0)
			{
				strErr+="class_description不能为空！\\n";	
			}
			if(this.txtspecial_ticketing_instructions.Text.Trim().Length==0)
			{
				strErr+="special_ticketing_instructions不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtlowest_price.Text))
			{
				strErr+="lowest_price格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txthighest_price.Text))
			{
				strErr+="highest_price格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtlastupdatetime.Text))
			{
				strErr+="lastupdatetime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsysuser_id.Text))
			{
				strErr+="sysuser_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtplatform_id.Text))
			{
				strErr+="platform_id格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			decimal leavepoint=decimal.Parse(this.txtleavepoint.Text);
			decimal leavemoney=decimal.Parse(this.txtleavemoney.Text);
			bool is_filter=this.chkis_filter.Checked;
			DateTime starttime=DateTime.Parse(this.txtstarttime.Text);
			DateTime endtime=DateTime.Parse(this.txtendtime.Text);
			decimal lowest_rebate=decimal.Parse(this.txtlowest_rebate.Text);
			decimal highest_rebate=decimal.Parse(this.txthighest_rebate.Text);
			int earliest_advance_days=int.Parse(this.txtearliest_advance_days.Text);
			int night_before_days=int.Parse(this.txtnight_before_days.Text);
			int pointSetType=int.Parse(this.txtpointSetType.Text);
			bool isuploadfirstclass=this.chkisuploadfirstclass.Checked;
			bool isuploadchildclass=this.chkisuploadchildclass.Checked;
			bool NFDpolicy=this.chkNFDpolicy.Checked;
			string flylimittime=this.txtflylimittime.Text;
			string platfromPolicy=this.txtplatfromPolicy.Text;
			string GWpolicy=this.txtGWpolicy.Text;
			bool uploadway=this.chkuploadway.Checked;
			bool isuploadsharefight=this.chkisuploadsharefight.Checked;
			bool addpricejisuan=this.chkaddpricejisuan.Checked;
			int addpriceCovertType=int.Parse(this.txtaddpriceCovertType.Text);
			int addPriceSet=int.Parse(this.txtaddPriceSet.Text);
			int limitSit=int.Parse(this.txtlimitSit.Text);
			int saleSit=int.Parse(this.txtsaleSit.Text);
			bool is_autoticket=this.chkis_autoticket.Checked;
			bool is_Need=this.chkis_Need.Checked;
			int isMail=int.Parse(this.txtisMail.Text);
			bool isPay=this.chkisPay.Checked;
			string AuthorizeOffice=this.txtAuthorizeOffice.Text;
			string refund_rule=this.txtrefund_rule.Text;
			string changedate_rule=this.txtchangedate_rule.Text;
			bool is_allowed_sign=this.chkis_allowed_sign.Checked;
			bool is_provide_regular_passenger_integral=this.chkis_provide_regular_passenger_integral.Checked;
			int document_type=int.Parse(this.txtdocument_type.Text);
			int maxage=int.Parse(this.txtmaxage.Text);
			int minage=int.Parse(this.txtminage.Text);
			string class_description=this.txtclass_description.Text;
			string special_ticketing_instructions=this.txtspecial_ticketing_instructions.Text;
			decimal lowest_price=decimal.Parse(this.txtlowest_price.Text);
			decimal highest_price=decimal.Parse(this.txthighest_price.Text);
			DateTime lastupdatetime=DateTime.Parse(this.txtlastupdatetime.Text);
			int sysuser_id=int.Parse(this.txtsysuser_id.Text);
			int platform_id=int.Parse(this.txtplatform_id.Text);


			Sanben.Model.policy_zy_Base model=new Sanben.Model.policy_zy_Base();
			model.id=id;
			model.leavepoint=leavepoint;
			model.leavemoney=leavemoney;
			model.is_filter=is_filter;
			model.starttime=starttime;
			model.endtime=endtime;
			model.lowest_rebate=lowest_rebate;
			model.highest_rebate=highest_rebate;
			model.earliest_advance_days=earliest_advance_days;
			model.night_before_days=night_before_days;
			model.pointSetType=pointSetType;
			model.isuploadfirstclass=isuploadfirstclass;
			model.isuploadchildclass=isuploadchildclass;
			model.NFDpolicy=NFDpolicy;
			model.flylimittime=flylimittime;
			model.platfromPolicy=platfromPolicy;
			model.GWpolicy=GWpolicy;
			model.uploadway=uploadway;
			model.isuploadsharefight=isuploadsharefight;
			model.addpricejisuan=addpricejisuan;
			model.addpriceCovertType=addpriceCovertType;
			model.addPriceSet=addPriceSet;
			model.limitSit=limitSit;
			model.saleSit=saleSit;
			model.is_autoticket=is_autoticket;
			model.is_Need=is_Need;
			model.isMail=isMail;
			model.isPay=isPay;
			model.AuthorizeOffice=AuthorizeOffice;
			model.refund_rule=refund_rule;
			model.changedate_rule=changedate_rule;
			model.is_allowed_sign=is_allowed_sign;
			model.is_provide_regular_passenger_integral=is_provide_regular_passenger_integral;
			model.document_type=document_type;
			model.maxage=maxage;
			model.minage=minage;
			model.class_description=class_description;
			model.special_ticketing_instructions=special_ticketing_instructions;
			model.lowest_price=lowest_price;
			model.highest_price=highest_price;
			model.lastupdatetime=lastupdatetime;
			model.sysuser_id=sysuser_id;
			model.platform_id=platform_id;

			Sanben.BLL.policy_zy_Base bll=new Sanben.BLL.policy_zy_Base();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
