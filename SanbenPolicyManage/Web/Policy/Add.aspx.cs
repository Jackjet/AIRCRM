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
namespace Sanben.Web.Policy
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtflightcode.Text.Trim().Length==0)
			{
				strErr+="flightcode不能为空！\\n";	
			}
			if(this.txtpolicyCode.Text.Trim().Length==0)
			{
				strErr+="policyCode不能为空！\\n";	
			}
			if(this.txtdpt.Text.Trim().Length==0)
			{
				strErr+="dpt不能为空！\\n";	
			}
			if(this.txtarr.Text.Trim().Length==0)
			{
				strErr+="arr不能为空！\\n";	
			}
			if(this.txtflightNumLimit.Text.Trim().Length==0)
			{
				strErr+="flightNumLimit不能为空！\\n";	
			}
			if(this.txtflightcondition.Text.Trim().Length==0)
			{
				strErr+="flightcondition不能为空！\\n";	
			}
			if(this.txtdaycondition.Text.Trim().Length==0)
			{
				strErr+="daycondition不能为空！\\n";	
			}
			if(this.txtcabin.Text.Trim().Length==0)
			{
				strErr+="cabin不能为空！\\n";	
			}
			if(this.txtdiscountType.Text.Trim().Length==0)
			{
				strErr+="discountType不能为空！\\n";	
			}
			if(this.txtdiscountValue.Text.Trim().Length==0)
			{
				strErr+="discountValue不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtreturnpoint.Text))
			{
				strErr+="returnpoint格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtreturnprice.Text))
			{
				strErr+="returnprice格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartdate_ticket.Text))
			{
				strErr+="startdate_ticket格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtenfdate_ticket.Text))
			{
				strErr+="enfdate_ticket格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtstartdate.Text))
			{
				strErr+="startdate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtenddate.Text))
			{
				strErr+="enddate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtbeforeValidDay.Text))
			{
				strErr+="beforeValidDay格式错误！\\n";	
			}
			if(this.txtbacknote.Text.Trim().Length==0)
			{
				strErr+="backnote不能为空！\\n";	
			}
			if(this.txtcabinnote.Text.Trim().Length==0)
			{
				strErr+="cabinnote不能为空！\\n";	
			}
			if(this.txtofficeno.Text.Trim().Length==0)
			{
				strErr+="officeno不能为空！\\n";	
			}
			if(this.txtktype.Text.Trim().Length==0)
			{
				strErr+="ktype不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcheckCycleTime.Text))
			{
				strErr+="checkCycleTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtautoCheckOverTime.Text))
			{
				strErr+="autoCheckOverTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmanualCheckOverTime.Text))
			{
				strErr+="manualCheckOverTime格式错误！\\n";	
			}
			if(this.txtpolicy.Text.Trim().Length==0)
			{
				strErr+="policy不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdownDiscount.Text))
			{
				strErr+="downDiscount格式错误！\\n";	
			}
			if(this.txtspecialRule.Text.Trim().Length==0)
			{
				strErr+="specialRule不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtallCabin.Text))
			{
				strErr+="allCabin格式错误！\\n";	
			}
			if(this.txtdeptTimeSlot.Text.Trim().Length==0)
			{
				strErr+="deptTimeSlot不能为空！\\n";	
			}
			if(this.txtone_flightlimit.Text.Trim().Length==0)
			{
				strErr+="one_flightlimit不能为空！\\n";	
			}
			if(this.txtone_limitnum.Text.Trim().Length==0)
			{
				strErr+="one_limitnum不能为空！\\n";	
			}
			if(this.txttwo_flightlimit.Text.Trim().Length==0)
			{
				strErr+="two_flightlimit不能为空！\\n";	
			}
			if(this.txttwo_limitnum.Text.Trim().Length==0)
			{
				strErr+="two_limitnum不能为空！\\n";	
			}
			if(this.txtone_daylimit.Text.Trim().Length==0)
			{
				strErr+="one_daylimit不能为空！\\n";	
			}
			if(this.txttwo_daylimit.Text.Trim().Length==0)
			{
				strErr+="two_daylimit不能为空！\\n";	
			}
			if(this.txtgocabin.Text.Trim().Length==0)
			{
				strErr+="gocabin不能为空！\\n";	
			}
			if(this.txtbackcabin.Text.Trim().Length==0)
			{
				strErr+="backcabin不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtone_startdate.Text))
			{
				strErr+="one_startdate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtone_enddate.Text))
			{
				strErr+="one_enddate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttwo_startdate.Text))
			{
				strErr+="two_startdate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttwo_enddate.Text))
			{
				strErr+="two_enddate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtshort_stoptime.Text))
			{
				strErr+="short_stoptime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtlong_stoptime.Text))
			{
				strErr+="long_stoptime格式错误！\\n";	
			}
			if(this.txtcosttype.Text.Trim().Length==0)
			{
				strErr+="costtype不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcostPrice.Text))
			{
				strErr+="costPrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtproxyPrice.Text))
			{
				strErr+="proxyPrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbackPrice.Text))
			{
				strErr+="backPrice格式错误！\\n";	
			}
			if(this.txtpolicySource.Text.Trim().Length==0)
			{
				strErr+="policySource不能为空！\\n";	
			}
			if(this.txtxcd.Text.Trim().Length==0)
			{
				strErr+="xcd不能为空！\\n";	
			}
			if(this.txtreturnRule.Text.Trim().Length==0)
			{
				strErr+="returnRule不能为空！\\n";	
			}
			if(this.txtchangeRule.Text.Trim().Length==0)
			{
				strErr+="changeRule不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtcardType.Text))
			{
				strErr+="cardType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtmaxAge.Text))
			{
				strErr+="maxAge格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtminAge.Text))
			{
				strErr+="minAge格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsys_id.Text))
			{
				strErr+="sys_id格式错误！\\n";	
			}
			if(this.txtuploadPolicyType.Text.Trim().Length==0)
			{
				strErr+="uploadPolicyType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtearliestBeforeValidDay.Text))
			{
				strErr+="earliestBeforeValidDay格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtisUpload.Text))
			{
				strErr+="isUpload格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtimportTime.Text))
			{
				strErr+="importTime格式错误！\\n";	
			}
			if(this.txtuploadPlat.Text.Trim().Length==0)
			{
				strErr+="uploadPlat不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtuploadResult.Text))
			{
				strErr+="uploadResult格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string flightcode=this.txtflightcode.Text;
			string policyCode=this.txtpolicyCode.Text;
			string dpt=this.txtdpt.Text;
			string arr=this.txtarr.Text;
			string flightNumLimit=this.txtflightNumLimit.Text;
			string flightcondition=this.txtflightcondition.Text;
			string daycondition=this.txtdaycondition.Text;
			string cabin=this.txtcabin.Text;
			string discountType=this.txtdiscountType.Text;
			string discountValue=this.txtdiscountValue.Text;
			decimal returnpoint=decimal.Parse(this.txtreturnpoint.Text);
			int returnprice=int.Parse(this.txtreturnprice.Text);
			DateTime startdate_ticket=DateTime.Parse(this.txtstartdate_ticket.Text);
			DateTime enfdate_ticket=DateTime.Parse(this.txtenfdate_ticket.Text);
			DateTime startdate=DateTime.Parse(this.txtstartdate.Text);
			DateTime enddate=DateTime.Parse(this.txtenddate.Text);
			int beforeValidDay=int.Parse(this.txtbeforeValidDay.Text);
			string backnote=this.txtbacknote.Text;
			string cabinnote=this.txtcabinnote.Text;
			bool autoTicket=this.chkautoTicket.Checked;
			bool shared=this.chkshared.Checked;
			string officeno=this.txtofficeno.Text;
			string ktype=this.txtktype.Text;
			int checkCycleTime=int.Parse(this.txtcheckCycleTime.Text);
			int autoCheckOverTime=int.Parse(this.txtautoCheckOverTime.Text);
			int manualCheckOverTime=int.Parse(this.txtmanualCheckOverTime.Text);
			string policy=this.txtpolicy.Text;
			decimal downDiscount=decimal.Parse(this.txtdownDiscount.Text);
			bool pata=this.chkpata.Checked;
			string specialRule=this.txtspecialRule.Text;
			int allCabin=int.Parse(this.txtallCabin.Text);
			bool canPay=this.chkcanPay.Checked;
			string deptTimeSlot=this.txtdeptTimeSlot.Text;
			bool needPnr=this.chkneedPnr.Checked;
			string one_flightlimit=this.txtone_flightlimit.Text;
			string one_limitnum=this.txtone_limitnum.Text;
			string two_flightlimit=this.txttwo_flightlimit.Text;
			string two_limitnum=this.txttwo_limitnum.Text;
			string one_daylimit=this.txtone_daylimit.Text;
			string two_daylimit=this.txttwo_daylimit.Text;
			string gocabin=this.txtgocabin.Text;
			string backcabin=this.txtbackcabin.Text;
			DateTime one_startdate=DateTime.Parse(this.txtone_startdate.Text);
			DateTime one_enddate=DateTime.Parse(this.txtone_enddate.Text);
			DateTime two_startdate=DateTime.Parse(this.txttwo_startdate.Text);
			DateTime two_enddate=DateTime.Parse(this.txttwo_enddate.Text);
			int short_stoptime=int.Parse(this.txtshort_stoptime.Text);
			int long_stoptime=int.Parse(this.txtlong_stoptime.Text);
			string costtype=this.txtcosttype.Text;
			decimal costPrice=decimal.Parse(this.txtcostPrice.Text);
			decimal proxyPrice=decimal.Parse(this.txtproxyPrice.Text);
			decimal backPrice=decimal.Parse(this.txtbackPrice.Text);
			string policySource=this.txtpolicySource.Text;
			string xcd=this.txtxcd.Text;
			string returnRule=this.txtreturnRule.Text;
			string changeRule=this.txtchangeRule.Text;
			bool endorsement=this.chkendorsement.Checked;
			bool flyerpoints=this.chkflyerpoints.Checked;
			int cardType=int.Parse(this.txtcardType.Text);
			int maxAge=int.Parse(this.txtmaxAge.Text);
			int minAge=int.Parse(this.txtminAge.Text);
			int sys_id=int.Parse(this.txtsys_id.Text);
			string uploadPolicyType=this.txtuploadPolicyType.Text;
			int earliestBeforeValidDay=int.Parse(this.txtearliestBeforeValidDay.Text);
			int isUpload=int.Parse(this.txtisUpload.Text);
			DateTime importTime=DateTime.Parse(this.txtimportTime.Text);
			string uploadPlat=this.txtuploadPlat.Text;
			int uploadResult=int.Parse(this.txtuploadResult.Text);

			Sanben.Model.Policy model=new Sanben.Model.Policy();
			model.flightcode=flightcode;
			model.policyCode=policyCode;
			model.dpt=dpt;
			model.arr=arr;
			model.flightNumLimit=flightNumLimit;
			model.flightcondition=flightcondition;
			model.daycondition=daycondition;
			model.cabin=cabin;
			model.discountType=discountType;
			model.discountValue=discountValue;
			model.returnpoint=returnpoint;
			model.returnprice=returnprice;
			model.startdate_ticket=startdate_ticket;
			model.enfdate_ticket=enfdate_ticket;
			model.startdate=startdate;
			model.enddate=enddate;
			model.beforeValidDay=beforeValidDay;
			model.backnote=backnote;
			model.cabinnote=cabinnote;
			model.autoTicket=autoTicket;
			model.shared=shared;
			model.officeno=officeno;
			model.ktype=ktype;
			model.checkCycleTime=checkCycleTime;
			model.autoCheckOverTime=autoCheckOverTime;
			model.manualCheckOverTime=manualCheckOverTime;
			model.policy=policy;
			model.downDiscount=downDiscount;
			model.pata=pata;
			model.specialRule=specialRule;
			model.allCabin=allCabin;
			model.canPay=canPay;
			model.deptTimeSlot=deptTimeSlot;
			model.needPnr=needPnr;
			model.one_flightlimit=one_flightlimit;
			model.one_limitnum=one_limitnum;
			model.two_flightlimit=two_flightlimit;
			model.two_limitnum=two_limitnum;
			model.one_daylimit=one_daylimit;
			model.two_daylimit=two_daylimit;
			model.gocabin=gocabin;
			model.backcabin=backcabin;
			model.one_startdate=one_startdate;
			model.one_enddate=one_enddate;
			model.two_startdate=two_startdate;
			model.two_enddate=two_enddate;
			model.short_stoptime=short_stoptime;
			model.long_stoptime=long_stoptime;
			model.costtype=costtype;
			model.costPrice=costPrice;
			model.proxyPrice=proxyPrice;
			model.backPrice=backPrice;
			model.policySource=policySource;
			model.xcd=xcd;
			model.returnRule=returnRule;
			model.changeRule=changeRule;
			model.endorsement=endorsement;
			model.flyerpoints=flyerpoints;
			model.cardType=cardType;
			model.maxAge=maxAge;
			model.minAge=minAge;
			model.sys_id=sys_id;
			model.uploadPolicyType=uploadPolicyType;
			model.earliestBeforeValidDay=earliestBeforeValidDay;
			model.isUpload=isUpload;
			model.importTime=importTime;
			model.uploadPlat=uploadPlat;
			model.uploadResult=uploadResult;

			Sanben.BLL.Policy bll=new Sanben.BLL.Policy();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
