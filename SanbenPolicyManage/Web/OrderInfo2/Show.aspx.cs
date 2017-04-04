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
namespace Sanben.Web.OrderInfo2
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
					int pk_id=(Convert.ToInt32(strid));
					ShowInfo(pk_id);
				}
			}
		}
		
	private void ShowInfo(int pk_id)
	{
		Sanben.BLL.OrderInfo2 bll=new Sanben.BLL.OrderInfo2();
		Sanben.Model.OrderInfo2 model=bll.GetModel(pk_id);
		this.lblpk_id.Text=model.pk_id.ToString();
		this.lblid.Text=model.id.ToString();
		this.lblorderNo.Text=model.orderNo;
		this.lblallPrice.Text=model.allPrice;
		this.lblnoPay.Text=model.noPay;
		this.lblchildPrintPrice.Text=model.childPrintPrice;
		this.lblchildFaceValue.Text=model.childFaceValue;
		this.lblsource.Text=model.source;
		this.lblpolicySource.Text=model.policySource;
		this.lblticketMode.Text=model.ticketMode;
		this.lblpolicyFriendly.Text=model.policyFriendly;
		this.lblpayChannel.Text=model.payChannel;
		this.lblpayStatus.Text=model.payStatus;
		this.lblinsuranceUnitPrice.Text=model.insuranceUnitPrice;
		this.lblbacknote.Text=model.backnote;
		this.lblinsuranceCuttingPrice.Text=model.insuranceCuttingPrice;
		this.lblcabinnote.Text=model.cabinnote;
		this.lblxcdPrice.Text=model.xcdPrice;
		this.lblxcd.Text=model.xcd;
		this.lblsjr.Text=model.sjr;
		this.lblcontactTel.Text=model.contactTel;
		this.lbladdress.Text=model.address;
		this.lblcompany.Text=model.company;
		this.lblexpType.Text=model.expType;
		this.lblordernumber.Text=model.ordernumber;
		this.lblsendtime.Text=model.sendtime;
		this.lblviewPrice.Text=model.viewPrice;
		this.lblprice.Text=model.price;
		this.lblpnr.Text=model.pnr;
		this.lblcpnr.Text=model.cpnr;
		this.lblpnrText.Text=model.pnrText;
		this.lblchildPnrText.Text=model.childPnrText;
		this.lblpataText.Text=model.pataText;
		this.lblchildPataText.Text=model.childPataText;
		this.lblconstructionFee.Text=model.constructionFee;
		this.lblfuelTax.Text=model.fuelTax;
		this.lblchildFuelTax.Text=model.childFuelTax;
		this.lblpolicyType.Text=model.policyType;
		this.lblstatus.Text=model.status;
		this.lblcontact.Text=model.contact;
		this.lblcontactMob.Text=model.contactMob;
		this.lblcontactEmail.Text=model.contactEmail;
		this.lblcreateTime.Text=model.createTime.ToString();
		this.lblneedPS.Text=model.needPS;
		this.lblusername.Text=model.username;
		this.lblorderFrom.Text=model.orderFrom;
		this.lbllockStatus.Text=model.lockStatus;
		this.lblupdateTime.Text=model.updateTime.ToString();
		this.lbluserid.Text=model.userid.ToString();
		this.lblorderDesc.Text=model.orderDesc;

	}


    }
}
