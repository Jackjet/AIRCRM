using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Sanben.BLL;
using ICSharpCode.SharpZipLib.Zip;
using System.Text.RegularExpressions;

namespace RunTask
{
    class PM
    {
        #region 变量
        private DataSet ds = null;
        private DataSet configSet = null;
        private int _sysid = 0;
        private Sanben.BLL.policy_options _bll = null;
        private Sanben.BLL.GetRateList _getRateBll = null;//今日政策
       private Sanben.BLL.Piaomeng_policy _pmPolicyBll = null;//票盟
      
        private Sanben.BLL.rebate _rebateBll = null;//返点
        private Sanben.BLL.gaiqian_retirement _gaiqianBll = null;//改签
        private Sanben.BLL.cabin_description _cabinDescriptionBll = null;//仓位说明 
        Sanben.BLL.UploadPolicyResult _policyResultBll = new UploadPolicyResult();//上传结果
        private Sanben.BLL.Platform_type _platformBll = null;//平台类型
        private Sanben.BLL.platform_config _configBll = null;//平台配置
        private Sanben.BLL.sys_user _sysUserBll = null;
        private Sanben.BLL.uploadTask _uploadTask = null;
        Sanben.BLL.Policy_filter _policyFilter = null;
        Sanben.BLL.AirMan _airmanBll = null;//航线管理
        List<Sanben.Model.AirMan> airlist = null;
        private double lRabete = 0.0;
        private double hRabete = 0.0;
        private double rPoint = 0.0;
        private string strTtsUrl = null;
        private Sanben.Model.platform_config platform = null;
        private bool _isAll = false;
        string strStartCity = null;
        #endregion
        public PM(int sysid,bool isAll)
        {
            _sysid = sysid;
            _isAll = isAll;
            Init();
        }

        public void Init()
        {
            _bll = new policy_options();
            ds = new DataSet();
            configSet = new DataSet();
            _getRateBll = new GetRateList();
            _pmPolicyBll = new Piaomeng_policy();
            _rebateBll = new rebate();
            _gaiqianBll = new gaiqian_retirement();
            _cabinDescriptionBll = new cabin_description();
            _policyResultBll = new UploadPolicyResult();
            _platformBll = new Platform_type();//平台类型
            _configBll =  new platform_config();//平台配置
            _airmanBll = new AirMan();
            airlist = new List<Sanben.Model.AirMan>();
            _policyFilter = new Policy_filter();
            _sysUserBll = new sys_user();
            strTtsUrl = ConfigurationManager.AppSettings["TtsUrl"].ToLower();
            platform = new Sanben.Model.platform_config();
            _uploadTask = new uploadTask();
            ds = _bll.GetList(string.Format(" sys_userid = {0}", _sysid));
            if (ds.Tables[0].Rows.Count > 0)
            {
                lRabete = Convert.ToDouble(ds.Tables[0].Rows[0]["lowest_rebate"].ToString());
                hRabete = Convert.ToDouble(ds.Tables[0].Rows[0]["highest_rebate"].ToString());
                rPoint = Convert.ToDouble(ds.Tables[0].Rows[0]["tolerate_stationary_point"].ToString());
                configSet = ds.Copy();
                Filler("");
                BuildXmlAndGzip();
            }
        }

        public string MakeParm(string parm)
        {
            string tmpstr = null;
            if (parm.Length > 1)
            {
                string[] array = parm.Split(',');
                for (int k = 0;k < array.Length;k++)
                {
                   tmpstr  += "'" + array[k] + "'" + ",";
                }
            }
            return tmpstr.Substring(0, tmpstr.Length - 1);
        }

        /// <summary>
        /// 获取航线组
        /// </summary>
        /// <param name="air_company"></param>
        /// <param name="start_city"></param>
        /// <returns></returns>
        public List<Sanben.Model.AirMan> GetArriveCity(string air_company,string start_city)
        {
            string tmpstr = MakeParm(start_city);
            airlist = _airmanBll.GetModelList(string.Format(@" CarrierName = '{0}' AND StartCode IN ({1} )", air_company,tmpstr));
            return airlist;
        }
        /// <summary>
        /// 过滤
        /// </summary>
        public void Filler(string Where)
        {
            string strWhere = string.Format(@"  airCom in (	select navigation_company from Policy_filter)   
                                                       AND fromPlace IN (
                                                           SELECT StartCode FROM AirMan
                                                           WHERE CarrierName in (	select navigation_company from Policy_filter)) and rate between 1 and 20 ");
                                                           
            if (!string.IsNullOrEmpty(Where))
            {
                strWhere += string.Format (" AND StartCode IN  ({0})) ", Where); 
            }
            strWhere += string.Format(@" and rate between {0} and {1}", lRabete, hRabete);
            ds = _pmPolicyBll.GetList(strWhere);
            DiscountsModefy();
            GeiQian();
            CabinDetail();
        }
        /// <summary>
        /// 修改返点
        /// </summary>
        public void DiscountsModefy()
        {
            //自定义留点
            DataSet rDataSet = _rebateBll.GetList(string.Format("sys_id = {0}", _sysid));
            int rebateCount = rDataSet.Tables[0].Rows.Count;

            int counts = ds.Tables[0].Rows.Count;
            double k = 0.0;
            if (counts <= 0)
                return;
            for (int i = 0; i < counts; i++)
            {
                object st1 = ds.Tables[0].Rows[i]["airCom"].ToString(); //
                string scity = ds.Tables[0].Rows[i]["fromPlace"].ToString();//
                string ecity = ds.Tables[0].Rows[i]["toPlace"].ToString();//
                object st3 = ds.Tables[0].Rows[i]["rate"].ToString(); //政策源返点
                //自定义留点
                if (rebateCount > 0)
                {
                    for (int j = 0; j < rebateCount; j++)
                    {
                        object s1 = rDataSet.Tables[0].Rows[j]["navigation_company"];  //航司
                        string[] city = rDataSet.Tables[0].Rows[j]["air_line"].ToString().Trim().Split('-');//航线
                        object s3 = rDataSet.Tables[0].Rows[j]["rabate_number"];//返点
                        if (s1 == st1 && scity.Contains(city[0]) && (ecity.Contains(city[1]) || ecity[1].ToString() == "ALL"))
                        {
                            st3 = s3;
                        }
                    }
                }
                k = Convert.ToDouble(st3);
                k = k - rPoint;//默认留点
                ds.Tables[0].Rows[i]["rate"] = k;
            }
        }
        /// <summary>
        /// 改签
        /// </summary>
        public void GeiQian()
        {
            DataSet gqSet = _gaiqianBll.GetList(string.Format("sys_id = {0}", _sysid));
            int gqCount = gqSet.Tables[0].Rows.Count;

            int counts = ds.Tables[0].Rows.Count;
            if (counts <= 0)
                return;
            ds.Tables[0].Columns.Add("refund_rule");
            ds.Tables[0].Columns.Add("changedate_rule");
            for (int i = 0; i < counts; i++)
            {
                string st1 = ds.Tables[0].Rows[i]["airCom"].ToString();
                string st2 = ds.Tables[0].Rows[i]["fromPlace"] + "-" + ds.Tables[0].Rows[i]["toPlace"]; 
                //改签
                if (gqCount > 0)
                {
                    for (int j = 0; j < gqCount; j++)
                    {
                        string s1 = gqSet.Tables[0].Rows[j]["navigation_company"].ToString();  //航司
                        string s2 = gqSet.Tables[0].Rows[j]["air_line"].ToString();//航线
                        if (s1 == st1 && s2 == st2)
                        {
                            ds.Tables[0].Rows[i]["refund_rule"] = gqSet.Tables[0].Rows[j]["refund_rule"];
                            ds.Tables[0].Rows[i]["changedate_rule"] = gqSet.Tables[0].Rows[j]["changedate_rule"];
                        }
                        else
                        {
                            ds.Tables[0].Rows[i]["refund_rule"] = configSet.Tables[0].Rows[0]["refund_rule"];
                            ds.Tables[0].Rows[i]["changedate_rule"] = configSet.Tables[0].Rows[0]["changedate_rule"];
                        }
                    }
                }
                else
                {
                    ds.Tables[0].Rows[i]["refund_rule"] = configSet.Tables[0].Rows[0]["refund_rule"];
                    ds.Tables[0].Rows[i]["changedate_rule"] = configSet.Tables[0].Rows[0]["changedate_rule"];
                }

            }
        }
        /// <summary>
        /// 仓位说明
        /// </summary>
        public void CabinDetail()
        {
            DataSet cabinSet = _cabinDescriptionBll.GetList(string.Format("sys_id = {0}", _sysid));
            int cabinCount = cabinSet.Tables[0].Rows.Count;

            int counts = ds.Tables[0].Rows.Count;
            if (counts <= 0)
                return;
            ds.Tables[0].Columns.Add("cabinDescription");
            for (int i = 0; i < counts; i++)
            {
                string st1 = ds.Tables[0].Rows[i]["airCom"].ToString();
                string scity = ds.Tables[0].Rows[i]["fromPlace"].ToString();//
                string ecity = ds.Tables[0].Rows[i]["toPlace"].ToString();//
                //string st2 = ds.Tables[0].Rows[i]["AirLine"].ToString();
                //仓位说明
                if (cabinCount > 0)
                {
                    for (int j = 0; j < cabinCount; j++)
                    {
                        string s1 = cabinSet.Tables[0].Rows[j]["navigation_company"].ToString();  //航司
                        string[] city = cabinSet.Tables[0].Rows[j]["air_line"].ToString().Trim().Split('-');//航线
                        //string s2 = cabinSet.Tables[0].Rows[j]["air_line"].ToString();//航线
                        if (s1.ToLower() == st1.ToLower() && scity.Contains(city[0]) && (ecity.Contains(city[1]) || ecity[1].ToString() == "ALL" ))
                        {
                            ds.Tables[0].Rows[i]["cabinDescription"] = cabinSet.Tables[0].Rows[j]["cabin_explain"];
                        }
                        else
                        {
                            ds.Tables[0].Rows[i]["cabinDescription"] = configSet.Tables[0].Rows[0]["class_description"];
                        }
                    }
                }
                else
                {
                    ds.Tables[0].Rows[i]["cabinDescription"] = configSet.Tables[0].Rows[0]["class_description"];
                }

            }
        }
        /// <summary>
        /// 生成XML
        /// </summary>
        public void BuildXmlAndGzip()
        {
            #region 读取政策XML模板文件到DataSet
            DataSet tmpds = new DataSet("xmldataset");
            string path = ConfigurationManager.AppSettings["XmlPath"];
            tmpds.ReadXml(Application.StartupPath + string.Format(@"{0}", path));
            #endregion
            string username = _sysUserBll.GetModel(_sysid).username;//用户名
            int id = Convert.ToInt32(configSet.Tables[0].Rows[0]["Policy_interface_id"]);//政策接口ID
            Sanben.Model.uploadTask uploadTask = new Sanben.Model.uploadTask();
            Sanben.Model.Platform_type platformType = new Sanben.Model.Platform_type();
            uploadTask = _uploadTask.GetModelList(string.Format(" sys_id = {0}", _sysid)).First();
            tmpds.Tables["PolicyList"].Rows[0]["type"] = uploadTask.policy_class; //政策上传类型 
            #region 政策明细
            int iCount = ds.Tables[0].Rows.Count;
            string cabin = "";
            string tmpstr = "";
            string lines = null;
            string endLines = null;

            tmpds.Tables["Policy"].Columns.Add("canPay");
            tmpds.Tables["Policy"].Columns.Add("needPnr");
            tmpds.Tables["Policy"].Columns.Add("pata");
            tmpds.Tables["Policy"].Columns.Add("minAge");
            tmpds.Tables["Policy"].Columns.Add("maxAge");
            tmpds.Tables["Policy"].Columns.Add("specialRule");
            tmpds.Tables["Policy"].Columns.Add("returnRule");
            tmpds.Tables["Policy"].Columns.Add("changeRule");

            for (int i = 0; i < iCount; i++)
            {
                lines = ds.Tables[0].Rows[i]["fromPlace"].ToString();//
                endLines = ds.Tables[0].Rows[i]["toPlace"].ToString();//
                string company = ds.Tables[0].Rows[i]["airCom"].ToString();//
                if (!string.IsNullOrEmpty(lines))
                {
                    if (lines.Length > 3)//如果出发地有多个
                    {
                        strStartCity = MakeParm(lines.Replace('/', ','));
                        this.Filler(strStartCity);
                        #region Cabin Format

                       tmpstr = ds.Tables[0].Rows[i]["applyClass"].ToString();
                        if (tmpstr.Length > 1)
                        {
                            cabin = tmpstr.Replace(';', ',');//替换成去哪儿仓位格式
                        }
                        else { cabin = tmpstr; }
                        #endregion
                        for (int j = 0; j < lines.Length; j++)//每个出发地添加一条记录
                        {
                            DataRow dr = tmpds.Tables["Policy"].NewRow();
                            #region Cells Data
                            tmpds.Tables["Policy"].Rows[j]["flightcode"] = ds.Tables[0].Rows[i]["airCom"];//航空公司
                            tmpds.Tables["Policy"].Rows[j]["policyCode"] = username + ds.Tables[0].Rows[i]["airCom"] + "_" + "PM" + "_" + ds.Tables[0].Rows[i]["policyID"].ToString().Substring(14,22);//政策标识
                            tmpds.Tables["Policy"].Rows[j]["dpt"] = ds.Tables[0].Rows[i]["fromPlace"]; //出发地
                            tmpds.Tables["Policy"].Rows[j]["arr"] = ds.Tables[0].Rows[i]["toPlace"].ToString().Substring(0,3); //到达地
                            tmpds.Tables["Policy"].Rows[j]["flightNumLimit"] = "所有";// Convert.ToInt32(ds.Tables[0].Rows[i]["flightScope"]) == 0 ? "所有" : "适用"; //航班限制 === 所有、适用、不适用 
                            tmpds.Tables["Policy"].Rows[j]["flightcondition"] = "";//ds.Tables[0].Rows[i]["flightNo"];//航班号
                            tmpds.Tables["Policy"].Rows[j]["cabin"] = cabin.Trim(); //只有普通政策才能指定多仓位
                            tmpds.Tables["Policy"].Rows[j]["discountType"] = "指定票面价";//票面价类型
                            tmpds.Tables["Policy"].Rows[j]["discountValue"] = 0;//票面价/折扣
                            tmpds.Tables["Policy"].Rows[j]["returnpoint"] = ds.Tables[0].Rows[i]["rate"];//返点
                            tmpds.Tables["Policy"].Rows[j]["returnprice"] = configSet.Tables[0].Rows[0]["tolerate_leave_money"];//留钱
                            tmpds.Tables["Policy"].Rows[j]["startdate_ticket"] = DateTime.Now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//政策有效期开始日期
                            tmpds.Tables["Policy"].Rows[j]["enfdate_ticket"] = DateTime.Now.AddDays(7.0).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//政策有效期截止日期
                            tmpds.Tables["Policy"].Rows[j]["startdate"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["fromTime"]).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//旅行开始日期
                            tmpds.Tables["Policy"].Rows[j]["enddate"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["toTime"]).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//旅行截止日期
                            tmpds.Tables["Policy"].Rows[j]["beforeValidDay"] = "0";//提前出票时限
                            tmpds.Tables["Policy"].Rows[j]["backnote"] = configSet.Tables[0].Rows[0]["refund_rule"].ToString();//退改签说明
                            tmpds.Tables["Policy"].Rows[j]["cabinnote"] = ds.Tables[0].Rows[i]["cabinDescription"];//仓位说明
                            tmpds.Tables["Policy"].Rows[j]["autoTicket"] = "否";//退改签说明
                            tmpds.Tables["Policy"].Rows[j]["officeno"] = configSet.Tables[0].Rows[0]["empower_office_number"];//支持代码共享航班
                            tmpds.Tables["Policy"].Rows[j]["xcd"] = 1;//行程单
                            tmpds.Tables["Policy"].Rows[j]["flyerpoints"] = configSet.Tables[0].Rows[0]["is_provide_regular_passenger_integral"].ToString() == "True" ? "是" : "否";//是否提供常旅客积分
                            tmpds.Tables["Policy"].Rows[j]["cardType"] = configSet.Tables[0].Rows[0]["document_type"].ToString();//证件类型  
                            

                            if (uploadTask.policy_class == "COMMON")
                            {
                                tmpds.Tables["Policy"].Rows[j]["daycondition"] = "1234567";//班期限制
                                tmpds.Tables["Policy"].Rows[j]["shared"] = "否";//支持代码共享航班
                            }
                            if (uploadTask.policy_class == "PREPAY")
                            {
                                tmpds.Tables["Policy"].Rows[j]["canPay"] = "是";//是否可以支付，取值“是”或“否”
                                tmpds.Tables["Policy"].Rows[j]["needPnr"] = "是";//是否生成PNR，取值“是”或“否”
                                tmpds.Tables["Policy"].Rows[j]["pata"] = "是";//是否进行PAT：A校验，取值“是”或“否”
                                tmpds.Tables["Policy"].Rows[j]["minAge"] = configSet.Tables[0].Rows[0]["minimum_age"].ToString();//最小购买年龄，大于13的整数；允许购买机票的最小年龄；默认为空表示无年龄下限限制(可选)
                                tmpds.Tables["Policy"].Rows[j]["maxAge"] = configSet.Tables[0].Rows[0]["maximum_age"].ToString();//最大购买年龄，小于70的整数；允许购买机票的最大年龄；默认为空表示无年龄上限限制(可选)
                                tmpds.Tables["Policy"].Rows[j]["specialRule"] = configSet.Tables[0].Rows[0]["special_ticketing_instructions"].ToString(); //特殊票务说明，填写如下中括号内序号,最多支持4
                                tmpds.Tables["Policy"].Rows[j]["returnRule"] = configSet.Tables[0].Rows[0]["refund_rule"].ToString();//退票规则
                                tmpds.Tables["Policy"].Rows[j]["changeRule"] = configSet.Tables[0].Rows[0]["changedate_rule"].ToString(); //改期规则
                                tmpds.Tables["Policy"].Rows[j]["daycondition"] = "1234567";//班期限制
                            }
                            tmpds.Tables["Policy"].Rows.Add(dr);
                            #endregion
                        }

                    }
                    else if (lines.Length == 3)//如果出发地只有一个
                    {

                        #region Cabin Format


                        tmpstr = ds.Tables[0].Rows[i]["applyClass"].ToString();
                        if (tmpstr.Length > 1)
                        {
                            cabin = tmpstr.Replace(';', ',');//替换成去哪儿仓位格式
                        }
                        else { cabin = tmpstr; }
                      
                        #endregion
                        DataRow dr = tmpds.Tables["Policy"].NewRow();
                        #region Cells Data
                        tmpds.Tables["Policy"].Rows[i]["flightcode"] = ds.Tables[0].Rows[i]["airCom"];//航空公司
                        tmpds.Tables["Policy"].Rows[i]["policyCode"] = username + ds.Tables[0].Rows[i]["airCom"] + "_" + "PM" + "_" + ds.Tables[0].Rows[i]["policyID"].ToString().Substring(14, 22);//政策标识
                        tmpds.Tables["Policy"].Rows[i]["dpt"] = lines;//出发地
                        tmpds.Tables["Policy"].Rows[i]["arr"] = ds.Tables[0].Rows[i]["toPlace"].ToString().Substring(0,3); //到达地
                        tmpds.Tables["Policy"].Rows[i]["flightNumLimit"] = "所有"; //Convert.ToInt32(ds.Tables[0].Rows[i]["flightScope"]) == 0 ? "所有" : "适用";//航班限制 === 所有、适用、不适用 
                        tmpds.Tables["Policy"].Rows[i]["flightcondition"] = "";//ds.Tables[0].Rows[i]["flightNo"];//航班号
                        tmpds.Tables["Policy"].Rows[i]["cabin"] = cabin.Trim(); //只有普通政策才能指定多仓位
                        tmpds.Tables["Policy"].Rows[i]["discountType"] = "指定票面价";//票面价类型
                        tmpds.Tables["Policy"].Rows[i]["discountValue"] = 0;//票面价/折扣
                        tmpds.Tables["Policy"].Rows[i]["returnpoint"] = ds.Tables[0].Rows[i]["rate"];//返点
                        tmpds.Tables["Policy"].Rows[i]["returnprice"] = configSet.Tables[0].Rows[0]["tolerate_leave_money"];//留钱
                        tmpds.Tables["Policy"].Rows[i]["startdate_ticket"] = DateTime.Now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//政策有效期开始日期
                        tmpds.Tables["Policy"].Rows[i]["enfdate_ticket"] = DateTime.Now.AddDays(7.0).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//政策有效期截止日期
                        tmpds.Tables["Policy"].Rows[i]["startdate"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["fromTime"]).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//旅行开始日期
                        tmpds.Tables["Policy"].Rows[i]["enddate"] = Convert.ToDateTime(ds.Tables[0].Rows[i]["toTime"]).ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);//旅行截止日期
                        tmpds.Tables["Policy"].Rows[i]["beforeValidDay"] = "0";//提前出票时限
                        tmpds.Tables["Policy"].Rows[i]["backnote"] = configSet.Tables[0].Rows[0]["refund_rule"].ToString();//退改签说明
                        tmpds.Tables["Policy"].Rows[i]["cabinnote"] = ds.Tables[0].Rows[i]["cabinDescription"];//仓位说明
                        tmpds.Tables["Policy"].Rows[i]["autoTicket"] = "否";//退改签说明
                        tmpds.Tables["Policy"].Rows[i]["officeno"] = configSet.Tables[0].Rows[0]["empower_office_number"];//支持代码共享航班
                        tmpds.Tables["Policy"].Rows[i]["xcd"] = 1;//行程单
                        tmpds.Tables["Policy"].Rows[i]["flyerpoints"] = configSet.Tables[0].Rows[0]["is_provide_regular_passenger_integral"].ToString() == "True" ? "是" : "否";//是否提供常旅客积分
                        tmpds.Tables["Policy"].Rows[i]["cardType"] = configSet.Tables[0].Rows[0]["document_type"].ToString();//证件类型  
                        
                        if (uploadTask.policy_class == "COMMON")
                        {
                            tmpds.Tables["Policy"].Rows[i]["daycondition"] = "1234567";//班期限制
                            tmpds.Tables["Policy"].Rows[i]["shared"] = "否";//支持代码共享航班
                        }
                        if (uploadTask.policy_class == "PREPAY")
                        {
                            tmpds.Tables["Policy"].Rows[i]["canPay"] = "是";//是否可以支付，取值“是”或“否”
                            tmpds.Tables["Policy"].Rows[i]["needPnr"] = "是";//是否生成PNR，取值“是”或“否”
                            tmpds.Tables["Policy"].Rows[i]["pata"] = "是";//是否进行PAT：A校验，取值“是”或“否”
                            tmpds.Tables["Policy"].Rows[i]["minAge"] = configSet.Tables[0].Rows[0]["minimum_age"].ToString();//最小购买年龄，大于13的整数；允许购买机票的最小年龄；默认为空表示无年龄下限限制(可选)
                            tmpds.Tables["Policy"].Rows[i]["maxAge"] = configSet.Tables[0].Rows[0]["maximum_age"].ToString();//最大购买年龄，小于70的整数；允许购买机票的最大年龄；默认为空表示无年龄上限限制(可选)
                            tmpds.Tables["Policy"].Rows[i]["specialRule"] = configSet.Tables[0].Rows[0]["special_ticketing_instructions"].ToString(); //特殊票务说明，填写如下中括号内序号,最多支持4
                            tmpds.Tables["Policy"].Rows[i]["returnRule"] = configSet.Tables[0].Rows[0]["refund_rule"].ToString();//退票规则
                            tmpds.Tables["Policy"].Rows[i]["changeRule"] = configSet.Tables[0].Rows[0]["changedate_rule"].ToString(); //改期规则
                            tmpds.Tables["Policy"].Rows[i]["daycondition"] = "1234567";//班期限制
                        }

                        tmpds.Tables["Policy"].Rows.Add(dr);
                        #endregion
                    }
                }
              
            }
            tmpds.Tables["Policy"].Rows.RemoveAt(iCount);
            #endregion

            int result = _policyResultBll.Add(new Sanben.Model.UploadPolicyResult
            {
                sys_id = _sysid,
                startMode = "自动",
                upload_platFrom = _platformBll.GetModel(id).platform_name,
                uploadTime = DateTime.Now,
                uploadType = 1,
                upload_class = 1,
                uploadNumber = iCount

            });
            #region 政策头部信息
            platformType = _platformBll.GetModelList(string.Format("platform_name = '{0}'", uploadTask.upload_platFrom)).First();
            if (uploadTask.upload_platFrom == platformType.platform_name )
            {
                int platformId = platformType.id;
                platform = _configBll.GetModelList(string.Format(" sys_user_id = {0} and platform_type_id = {1} ", _sysid,platformId)).First();
            }
            tmpds.Tables["PolicyList"].Rows[0]["username"] = platform.username;
            tmpds.Tables["PolicyList"].Rows[0]["password"] = platform.password;
            tmpds.Tables["PolicyList"].Rows[0]["execType"] = _isAll ? "FULL" : "ADD";
            tmpds.Tables["PolicyList"].Rows[0]["ext"] = result;
           
            #endregion


            #region 生成XML文件-UTF8
            string strFileName = Application.StartupPath + @"\PM.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(strFileName, Encoding.UTF8);//UTF-8编码
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 4;
            xmlWriter.WriteStartDocument();//写入XML头声明
            #region PolicyList根节点
            xmlWriter.WriteStartElement("PolicyList");//PolicyList根节点
            int policyColumns = tmpds.Tables["PolicyList"].Columns.Count;
            //PolicyList根节点属性
            for (int i = 0; i < policyColumns - 1; i++)
            {
                xmlWriter.WriteStartAttribute(tmpds.Tables["PolicyList"].Columns[i].ColumnName);
                xmlWriter.WriteString(tmpds.Tables["PolicyList"].Rows[0][i].ToString());
                xmlWriter.WriteEndAttribute();
            }
            #endregion

            #region DeletePolicy节点
            //xmlWriter.WriteStartElement("DeletePolicy");//DeletePolicy节点
            //int delPolicyColumns = ds.Tables["DeletePolicy"].Columns.Count;
            //for (int i = 0; i < delPolicyColumns - 1; i++)
            //{
            //    xmlWriter.WriteStartAttribute(ds.Tables["DeletePolicy"].Columns[i].ColumnName);
            //    if (ds.Tables["DeletePolicy"].Rows.Count > 0)
            //    {
            //        xmlWriter.WriteString(ds.Tables["DeletePolicy"].Rows[0][i].ToString());
            //        xmlWriter.WriteEndAttribute();
            //    }
            //}
            //xmlWriter.WriteEndElement(); 
            #endregion

            #region Policy节点
            //Policy节点
            int policyCounts = tmpds.Tables["Policy"].Rows.Count;
            for (int i = 0; i < policyCounts; i++)
            {
                xmlWriter.WriteStartElement("Policy");
                int pColumns = tmpds.Tables["Policy"].Columns.Count;
                for (int j = 0; j < pColumns - 1; j++)
                {
                    xmlWriter.WriteStartAttribute(tmpds.Tables["Policy"].Columns[j].ColumnName);
                    if (!string.IsNullOrEmpty(tmpds.Tables["Policy"].Rows[i][j].ToString()))
                    {
                        xmlWriter.WriteString(tmpds.Tables["Policy"].Rows[i][j].ToString());
                    }
                    xmlWriter.WriteEndAttribute();
                }
                xmlWriter.WriteEndElement();
            }
            #endregion

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
            #endregion
            CompressFile(strFileName, "demo.zip");
            UploadFile("demo.zip");
        }

        #region 压缩文件
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="strSouceFile">源文件</param>
        /// <param name="strDestFile">目标文件</param>
        public void CompressFile(string strSouceFile, string strDestFile)
        {
            using (ZipOutputStream stream = new ZipOutputStream(File.Create(strDestFile)))
            {
                stream.SetLevel(5);
                byte[] buffer = new byte[0x1000];
                ZipEntry entry = new ZipEntry(Path.GetFileName(strSouceFile));
                entry.DateTime = DateTime.Now;
                stream.PutNextEntry(entry);
                using (FileStream stream2 = File.OpenRead(strSouceFile))
                {
                    int num;
                    do
                    {
                        num = stream2.Read(buffer, 0, buffer.Length);
                        stream.Write(buffer, 0, num);
                    }
                    while (num > 0);

                }
                stream.Finish();
                stream.Close();
            }
        }
        #endregion
        #region 上传文件
        /// <summary>
        /// 上传文件 
        /// </summary>
        /// <param name="filename"></param>
        public void UploadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] bytes = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            fs.Dispose();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(platform.realm_name + strTtsUrl);
            req.Method = "POST";
            req.ContentLength = bytes.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bytes, 0, bytes.Length);
                reqStream.Close();
            }
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
        }
        #endregion
    }
}
