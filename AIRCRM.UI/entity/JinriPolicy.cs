using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policy.entity
{
    public class JinriPolicy
    {
        private String policyID; //政策ID

        public String PolicyID
        {
            get { return policyID; }
            set { policyID = value; }
        }
        private String rateID; //供票商代号

        public String RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }
        private String scityE; //出发城市 

        public String ScityE
        {
            get { return scityE; }
            set { scityE = value; }
        }
        private String ecityE; //到达城市

        public String EcityE
        {
            get { return ecityE; }
            set { ecityE = value; }
        }
        private String airComE; //适用的航空公司二字码

        public String AirComE
        {
            get { return airComE; }
            set { airComE = value; }
        }
        private String noAirComE; // 丌适用的航空公司二字码

        public String NoAirComE
        {
            get { return noAirComE; }
            set { noAirComE = value; }
        }
        private String policyType;//地区限制城市

        public String PolicyType
        {
            get { return policyType; }
            set { policyType = value; }
        }
        private String cabin;//舱位

        public String Cabin
        {
            get { return cabin; }
            set { cabin = value; }
        }
        private String voyageType;//航线类型(0:单程/1:往返/2:单程及往返)

        public String VoyageType
        {
            get { return voyageType; }
            set { voyageType = value; }
        }
        private String userType;//乘客类型(0:散客/1:团队/2:散客及团队)

        public String UserType
        {
            get { return userType; }
            set { userType = value; }
        }
        private String rateType;//政策类型(0:普通政策/1:特殊外放政策/2:特殊政策/为空则

        public String RateType
        {
            get { return rateType; }
            set { rateType = value; }
        }
        private String discounts;//政策返点

        public String Discounts
        {
            get { return discounts; }
            set { discounts = value; }
        }
        private String sdate;//政策有效期开始日期

        public String Sdate
        {
            get { return sdate; }
            set { sdate = value; }
        }
        private String edate;//政策有效期截止日期

        public String Edate
        {
            get { return edate; }
            set { edate = value; }
        }
        private String workTimBegin;//出票上班时间

        public String WorkTimBegin
        {
            get { return workTimBegin; }
            set { workTimBegin = value; }
        }
        private String workTImeEnd;//出票下班时间

        public String WorkTImeEnd
        {
            get { return workTImeEnd; }
            set { workTImeEnd = value; }
        }
        private String rewards;//奖励点

        public String Rewards
        {
            get { return rewards; }
            set { rewards = value; }
        }
        private String remark;//政策备注

        public String Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        private String eT;//出票类型 0：BSP； 1：B2B； 2：BSP自动出票； 3：B2B自动出票； 4：CRS

        public String ET
        {
            get { return eT; }
            set { eT = value; }
        }
        private String wP;//星期

        public String WP
        {
            get { return wP; }
            set { wP = value; }
        }
        private String sP;//出票速度

        public String SP
        {
            get { return sP; }
            set { sP = value; }
        }
        private String xF;//平台管理费

        public String XF
        {
            get { return xF; }
            set { xF = value; }
        }
        private String promotionDiscount;//促销返点

        public String PromotionDiscount
        {
            get { return promotionDiscount; }
            set { promotionDiscount = value; }
        }
        private String newRateNo;//新平台政策编号

        public String NewRateNo
        {
            get { return newRateNo; }
            set { newRateNo = value; }
        }
        private String officeNum;//供票商工作号

        public String OfficeNum
        {
            get { return officeNum; }
            set { officeNum = value; }
        }
        private String refundTimeBegin;//退废票上班时间

        public String RefundTimeBegin
        {
            get { return refundTimeBegin; }
            set { refundTimeBegin = value; }
        }
        private String refundTimeEnd;//退废票下班时间

        public String RefundTimeEnd
        {
            get { return refundTimeEnd; }
            set { refundTimeEnd = value; }
        }
        private String lastModifyTime;//最后一次更新时间

        public String LastModifyTime
        {
            get { return lastModifyTime; }
            set { lastModifyTime = value; }
        }
    }
}
