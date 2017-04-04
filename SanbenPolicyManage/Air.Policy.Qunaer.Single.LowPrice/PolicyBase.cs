
using System;

namespace Air.Policy.Qunaer.Single.Model
{
    /// <summary>
    ///机票-政策模板-去哪儿-基本模板
    /// </summary>
    public class PolicyBase
    {
        /// <summary>
        /// 政策XML文件编码格式
        /// </summary>
        private string _encoding;
        /// <summary>
        /// 政策清单
        /// </summary>
        private string _PolicyList;
        /// <summary>
        /// 删除政策清单
        /// </summary>
        private string _DeletePolicy;
        /// <summary>
        /// 政策明细
        /// </summary>
        private string _Policy;
        /// <summary>
        /// 用户名
        /// </summary>
        private string _username;
        /// <summary>
        /// 密码
        /// </summary>
        private string _password;
        /// <summary>
        /// 扩展信息(可选)
        /// </summary>
        private string _ext;
        /// <summary>
        /// 上传类型(只能取FULL或ADD,FULL-全量：30分钟时间间隔，一次不超过25万条，ADD-增量：5钟时间间隔，一次不超过5万条)
        /// </summary>
        private string _execType;
        /// <summary>
        /// COMMON-表示普通政策,PREPAY-表示预付政策,APPLY-表示申请政策,CUSTOMER-表示包机切位政策,LOWPRICE-表示特价政策,
        /// ROUNDPREPAY-往返预付政策,ROUNDSPECIAL-往返特价政策,SINGLEALL-单程所有类型政策,ROUNDALL-往返所有类型政策
        /// </summary>
        private string _type;
        /// <summary>
        /// 航空公司二字码，必须大写，只支持一个航空公司(可选)
        /// </summary>
        private string _flightcode;
        /// <summary>
        /// 政策标识，支持多个政策代码，多个政策代码以“,”分隔，最多支持1万个政策代码。
        /// 支持模糊检索，模糊检索部分用“*”代替。例：输入“abcpolicy*”，匹配“abcpolicy%”格式的所有政策（只支持* 在最后）(可选)
        /// </summary>
        private string _policyCode;
        /// <summary>
        /// 出发地,出发机场三字代码，大写且只支持单个出发地(可选)
        /// </summary>
        private string _dpt;
        /// <summary>
        /// 目的地,到达机场三字代码，大写且只支持单个目的地(可选)
        /// </summary>
        private string _arr;
        /// <summary>
        /// 舱位(往返政策对应去程舱位),舱位代码，大写且只支持单个舱位的录入，不支持子舱位(可选)
        /// </summary>
        private string _cabin;
        /// <summary>
        /// 旅行起始日期（往返政策对应去程旅行起始日期）格式为yyyy-MM-dd，日期不能早于当天(可选)
        /// </summary>
        private DateTime _startdate;
        /// <summary>
        /// 旅行结束日期（往返政策对应去程旅行结束日期）格式为yyyy-MM-dd，日期不能早于旅行起始日期(可选)
        /// </summary>
        private DateTime _enddate;

        /// <summary>
        /// 政策XML文件编码格式
        /// </summary>
        public string encoding
        {
            get { return _encoding; }
            set { _encoding = value; }
        }

        /// <summary>
        /// 政策清单
        /// </summary>
        public string PolicyList
        {
            get { return _PolicyList; }
            set { _PolicyList = value; }
        }

        /// <summary>
        /// 删除政策清单
        /// </summary>
        public string DeletePolicy
        {
            get { return _DeletePolicy; }
            set { _DeletePolicy = value; }
        }

        /// <summary>
        /// 政策明细
        /// </summary>
        public string Policy
        {
            get { return _Policy; }
            set { _Policy = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        /// <summary>
        /// 扩展信息(可选)
        /// </summary>
        public string ext
        {
            get { return _ext; }
            set { _ext = value; }
        }

        /// <summary>
        /// 上传类型(只能取FULL或ADD,FULL-全量：30分钟时间间隔，一次不超过25万条，ADD-增量：5钟时间间隔，一次不超过5万条)
        /// </summary>
        public string execType
        {
            get { return _execType; }
            set { _execType = value; }
        }

        /// <summary>
        /// COMMON-表示普通政策,PREPAY-表示预付政策,APPLY-表示申请政策,CUSTOMER-表示包机切位政策,LOWPRICE-表示特价政策,
        /// ROUNDPREPAY-往返预付政策,ROUNDSPECIAL-往返特价政策,SINGLEALL-单程所有类型政策,ROUNDALL-往返所有类型政策
        /// </summary>
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// 航空公司二字码，必须大写，只支持一个航空公司(可选)
        /// </summary>
        public string flightcode
        {
            get { return _flightcode; }
            set { _flightcode = value; }
        }

        /// <summary>
        /// 政策标识，支持多个政策代码，多个政策代码以“,”分隔，最多支持1万个政策代码。
        /// 支持模糊检索，模糊检索部分用“*”代替。例：输入“abcpolicy*”，匹配“abcpolicy%”格式的所有政策（只支持* 在最后）(可选)
        /// </summary>
        public string policyCode
        {
            get { return _policyCode; }
            set { _policyCode = value; }
        }

        /// <summary>
        /// 出发地,出发机场三字代码，大写且只支持单个出发地(可选)
        /// </summary>
        public string dpt
        {
            get { return _dpt; }
            set { _dpt = value; }
        }

        /// <summary>
        /// 目的地,到达机场三字代码，大写且只支持单个目的地(可选)
        /// </summary>
        public string arr
        {
            get { return _arr; }
            set { _arr = value; }
        }

        /// <summary>
        /// 舱位(往返政策对应去程舱位),舱位代码，大写且只支持单个舱位的录入，不支持子舱位(可选)
        /// </summary>
        public string cabin
        {
            get { return _cabin; }
            set { _cabin = value; }
        }

        /// <summary>
        /// 旅行起始日期（往返政策对应去程旅行起始日期）格式为yyyy-MM-dd，日期不能早于当天(可选)
        /// </summary>
        public DateTime startdate
        {
            get { return _startdate; }
            set { _startdate = value; }
        }

        /// <summary>
        /// 旅行结束日期（往返政策对应去程旅行结束日期）格式为yyyy-MM-dd，日期不能早于旅行起始日期(可选)
        /// </summary>
        public DateTime enddate
        {
            get { return _enddate; }
            set { _enddate = value; }
        }


        /// <summary>
        /// 航班限制，取值如下：所有、适用、不适用
        /// </summary>
        private string _flightNumLimit;

        /// <summary>
        /// 航班限制，取值如下：所有、适用、不适用
        /// </summary>
        public string flightNumLimit
        {
            get { return _flightNumLimit; }
            set { _flightNumLimit = value; }
        }

        /// <summary>
        /// 航班号(可选)，
        ///         1.航班限制为所有则不填
        ///         2.适用则填写适用航班号，多个用英文的“,”分隔，最多不超过25个航班号
        ///         3.不适用则填写不适用航班号
        /// </summary>
        private string _flightcondition;

        /// <summary>
        /// 航班号(可选)，
        ///         1.航班限制为所有则不填
        ///         2.适用则填写适用航班号，多个用英文的“,”分隔，最多不超过25个航班号
        ///         3.不适用则填写不适用航班号
        /// </summary>
        public string flightcondition
        {
            get { return _flightcondition; }
            set { _flightcondition = value; }
        }




        /// <summary>
        /// 票面价类型，取值如下： 1. 指定票面价 2. Y舱折扣  普通政策，此处取“指定票面价”
        /// </summary>
        private string _discountType;
        /// <summary>
        /// 票面价类型，取值如下： 1. 指定票面价 2. Y舱折扣  普通政策，此处取“指定票面价”
        /// </summary>
        public string discountType
        {
            get { return _discountType; }
            set { _discountType = value; }
        }



        /// <summary>
        /// 票面价/折扣，如果票面价类型为“指定票面价”此处填写票面价信息(普通政策填写0)， 如果为“Y舱折扣”则填写折扣信息（如0.85表示85折）
        /// </summary>
        private decimal _discountValue;
        /// <summary>
        /// 票面价/折扣，如果票面价类型为“指定票面价”此处填写票面价信息(普通政策填写0)， 如果为“Y舱折扣”则填写折扣信息（如0.85表示85折）
        /// </summary>
        public decimal discountValue
        {
            get { return _discountValue; }
            set { _discountValue = value; }
        }

        /// <summary>
        /// 返点，如：5.5表示返5.5个点
        /// </summary>
        private decimal _returnpoint;
        /// <summary>
        /// 留钱，支持正负整数
        /// </summary>
        private decimal _returnprice;

        /// <summary>
        /// 返点，如：5.5表示返5.5个点
        /// </summary>
        public decimal returnpoint
        {
            get { return _returnpoint; }
            set { _returnpoint = value; }
        }

        /// <summary>
        /// 留钱，支持正负整数
        /// </summary>
        public decimal returnprice
        {
            get { return _returnprice; }
            set { _returnprice = value; }
        }



        /// <summary>
        /// 销售起始日期，格式为yyyy-MM-dd
        /// </summary>
        private DateTime _startdate_ticket;
        /// <summary>
        /// 销售结束日期，格式为yyyy-MM-dd，日期不能早于销售起始日期 注意：字段名为“enfdata_ticket”，不是“enddata_ticket”
        /// </summary>
        private DateTime _enfdate_ticket;
        /// <summary>
        /// 销售起始日期，格式为yyyy-MM-dd
        /// </summary>
        public DateTime startdate_ticket
        {
            get { return _startdate_ticket; }
            set { _startdate_ticket = value; }
        }

        /// <summary>
        /// 销售结束日期，格式为yyyy-MM-dd，日期不能早于销售起始日期 注意：字段名为“enfdata_ticket”，不是“enddata_ticket”
        /// </summary>
        public DateTime enfdate_ticket
        {
            get { return _enfdate_ticket; }
            set { _enfdate_ticket = value; }
        }


        /// <summary>
        /// 提前出票时限，正整数，大于等于0 (可选)
        /// </summary>
        private int _beforeValidDay;
        /// <summary>
        /// 最早出票时限，正整数，大于等于0。表示用户至多需要提前几天预订机票。 (可选)
        /// </summary>
        private int _earliestBeforeValidDay;

        /// <summary>
        /// 提前出票时限，正整数，大于等于0 (可选)
        /// </summary>
        public int beforeValidDay
        {
            get { return _beforeValidDay; }
            set { _beforeValidDay = value; }
        }

        /// <summary>
        /// 最早出票时限，正整数，大于等于0。表示用户至多需要提前几天预订机票。 (可选)
        /// </summary>
        public int earliestBeforeValidDay
        {
            get { return _earliestBeforeValidDay; }
            set { _earliestBeforeValidDay = value; }
        }


        /// <summary>
        /// 航班起飞时间，HHMM-HHMM，如：2040-2359,至多录入3段航班起飞时间，中间用逗号隔开。(可选)
        /// </summary>
        private string _deptTimeSlot;
        /// <summary>
        /// 航班起飞时间，HHMM-HHMM，如：2040-2359,至多录入3段航班起飞时间，中间用逗号隔开。(可选)
        /// </summary>
        public string deptTimeSlot
        {
            get { return _deptTimeSlot; }
            set { _deptTimeSlot = value; }
        }



        /// <summary>
        /// 退改签说明，最大不超过255个字符的文本 (可选)
        /// </summary>
        private string _backnote;
        /// <summary>
        /// 舱位说明，最大不超过255个字符
        /// </summary>
        private string _cabinnote;
        /// <summary>
        /// 是否自动出票，取值“是”或者“否”
        /// </summary>
        private string _autoTicket;
        /// <summary>
        /// 退改签说明，最大不超过255个字符的文本 (可选)
        /// </summary>
        public string backnote
        {
            get { return _backnote; }
            set { _backnote = value; }
        }

        /// <summary>
        /// 舱位说明，最大不超过255个字符
        /// </summary>
        public string cabinnote
        {
            get { return _cabinnote; }
            set { _cabinnote = value; }
        }

        /// <summary>
        /// 是否自动出票，取值“是”或者“否”
        /// </summary>
        public string autoTicket
        {
            get { return _autoTicket; }
            set { _autoTicket = value; }
        }

        /// <summary>
        /// 授权搭桥的OFFICE号(可选)，授权其它OFFICE号也可以提取订单的PNR信息。可以为空，最多两个OFFICE号，两个OFFICE号时中间用英文的逗号隔开
        /// </summary>
        private string _officeno;
        /// <summary>
        /// 行程单(可选)，0，仅提供发票1，行程单2，行程单和差额发票强制为1，必须提供行程单
        /// </summary>
        private string _xcd;
        /// <summary>
        /// 授权搭桥的OFFICE号(可选)，授权其它OFFICE号也可以提取订单的PNR信息。可以为空，最多两个OFFICE号，两个OFFICE号时中间用英文的逗号隔开
        /// </summary>
        public string officeno
        {
            get { return _officeno; }
            set { _officeno = value; }
        }

        /// <summary>
        /// 行程单(可选)，0，仅提供发票1，行程单2，行程单和差额发票强制为1，必须提供行程单
        /// </summary>
        public string xcd
        {
            get { return _xcd; }
            set { _xcd = value; }
        }

        /// <summary>
        /// 常旅客积分，否:不提供,是:提供。默认为“是”(可选)
        /// </summary>
        private string _flyerpoints;
        /// <summary>
        /// 证件类型，0:支持所有证件类型 1:只支持身份证购买 默认为0，支持所有证件类型(可选)
        /// </summary>
        private string _cardType;
        /// <summary>
        /// 常旅客积分，否:不提供,是:提供。默认为“是”(可选)
        /// </summary>
        public string flyerpoints
        {
            get { return _flyerpoints; }
            set { _flyerpoints = value; }
        }

        /// <summary>
        /// 证件类型，0:支持所有证件类型 1:只支持身份证购买 默认为0，支持所有证件类型(可选)
        /// </summary>
        public string cardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }

        /// <summary>
        /// 退票规则，退票手续费编号:如10-2-20，表示起飞前2小时之前的手续费比例是10%，起飞前2小时之后的手续费比例是20%，具体见“新规则退改签录入”
        /// </summary>
        private string _returnRule;
        /// <summary>
        /// 改期规则，退票手续费编号:如10-2-20，表示起飞前2小时之前的手续费比例是10%， 起飞前2小时之后的手续费比例是20%，具体见“新规则退改签录入”
        /// </summary>
        private string _changeRule;
        /// <summary>
        /// 是否允许签转，是:允许签转,否:不允许签转。默认为“否”(可选)
        /// </summary>
        private string _endorsement;


        /// <summary>
        /// 退票规则，退票手续费编号:如10-2-20，表示起飞前2小时之前的手续费比例是10%，起飞前2小时之后的手续费比例是20%，具体见“新规则退改签录入”
        /// </summary>
        public string returnRule
        {
            get { return _returnRule; }
            set { _returnRule = value; }
        }

        /// <summary>
        /// 改期规则，退票手续费编号:如10-2-20，表示起飞前2小时之前的手续费比例是10%， 起飞前2小时之后的手续费比例是20%，具体见“新规则退改签录入”
        /// </summary>
        public string changeRule
        {
            get { return _changeRule; }
            set { _changeRule = value; }
        }

        /// <summary>
        /// 是否允许签转，是:允许签转,否:不允许签转。默认为“否”(可选)
        /// </summary>
        public string endorsement
        {
            get { return _endorsement; }
            set { _endorsement = value; }
        }
    }
}
