using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Security.Cryptography;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Net;
using System.Reflection;
using System.Xml.Serialization;
using System.Windows.Forms;
using Sanben.BLL;
using Formatting = System.Xml.Formatting;

namespace RunTask
{
    class Ctrip
    {
        #region MD5加密
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string MD5(string str, int code)
        {
            if (code == 16)  //16 位MD5MD5 加密（取 32 位加密的 9~25 9~25 字
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower().Substring(8, 16);
            }
            if (code == 32) //32 位加密
            {
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
            }
            return "00000000000000000000000000000000";
        }
        #endregion

        #region  利用GZip压缩字符串
        /// <summary>
        /// 利用GZIP压缩字符串
        /// </summary>
        /// <param name="str">需要压缩的字符串</param>
        /// <returns>GZip压缩后的字符串</returns>
        public static string Commpress(string str)
        {
            try
            {
                //   return Convert.ToBase64String(Commpress(Convert.FromBase64String(Convert.FromBase64String(Encoding.UTF8.GetBytes(str)))));
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        #endregion

        #region 利用GZip压缩数组
        /// <summary>
        /// 利用GZip压缩数组
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] Commpress(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (GZipStream Commpress = new GZipStream(ms, CompressionMode.Compress))
                {
                    Commpress.Write(bytes, 0, bytes.Length);
                    Commpress.Close();
                }
                return ms.ToArray();
            }
        }
        #endregion

        #region 利用GZip解压字符串
        /// <summary>
        /// 利用GZip解压字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Decompress(String str)
        {
            try
            {
                return Encoding.UTF8.GetString(Decompress(Convert.FromBase64String(str)));
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        #endregion

        #region 解压GZip字节数组
        /// <summary>
        /// 解压GZip字节数组
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private static byte[] Decompress(Byte[] bytes)
        {
            using (MemoryStream tempMs = new MemoryStream())
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    GZipStream Decompress = new GZipStream(ms, CompressionMode.Decompress);
                    Decompress.CopyTo(tempMs);
                    Decompress.Close();
                    return tempMs.ToArray();
                }
            }
        }
        #endregion

        string RequstUrl = "http://exchdata.ctrip.com/Flight-Proxy-TradeQuickAPI/api/xml/CommonPolicyAdd ";
        string UserName = "内部测试";
        string Passwrod = "Ctrip@2014Test";
        string RequstType = "CommonPolicyAdd";
        string Passwrod_MD5 = null;
        string RequstGuid = null;

        private DataSet ds = null;
        private DataSet configSet = null;
        private int _sysid = 0;
        private Sanben.BLL.policy_options _bll = null;
        private Sanben.BLL.GetRateList _getRateBll = null;//今日政策
        private Sanben.BLL.BaQianYiPolicy _bqyPolicyBll = null;//8000yi
        private Sanben.BLL.rebate _rebateBll = null;//返点
        private Sanben.BLL.gaiqian_retirement _gaiqianBll = null;//改签
        private Sanben.BLL.cabin_description _cabinDescriptionBll = null;//仓位说明 
        Sanben.BLL.UploadPolicyResult _policyResultBll = new UploadPolicyResult();//上传结果
        private Sanben.BLL.Platform_type _platformBll = null;//平台类型
        private Sanben.BLL.platform_config _configBll = null;//平台配置
        private Sanben.BLL.sys_user _sysUserBll = null;
        private Sanben.BLL.uploadTask _uploadTask = null;
        Sanben.BLL.Policy_filter _policyFilter = null;
        private double lRabete = 0.0;
        private double hRabete = 0.0;
        private double rPoint = 0.0;
        private string strTtsUrl = null;
        private Sanben.Model.platform_config platform = null;
        private bool _isAll = false;

        private Dictionary<string, string> requestTypeList = new Dictionary<string, string>();
        private Dictionary<string, Assembly> requestAssemblyList = new Dictionary<string, Assembly>();  
        string xmlfilepath =   @"\xml\CtripCommonPolicyAdd.xml";

        public  Ctrip(int sysid,bool isAll) 
        {
            _sysid = sysid;
            _isAll = isAll;
            Init();
            UploadCtrip();
        }

        public void UploadCtrip()
        {
            Passwrod_MD5 = FormsAuthentication.HashPasswordForStoringInConfigFile(string.Format("{0}#{1}", UserName, Passwrod), "MD5");
            RequstGuid = Guid.NewGuid().ToString();
            DataSet dsCtrip = new DataSet();
            dsCtrip.ReadXml(Application.StartupPath + xmlfilepath);
            dsCtrip.Tables["UserInfo"].Rows[0]["UserName"] = UserName;
            dsCtrip.Tables["UserInfo"].Rows[0]["Password"] = Passwrod_MD5;
            dsCtrip.Tables["MessageHead"].Rows[0]["ClientID"] = 5;
            dsCtrip.Tables["MessageHead"].Rows[0]["RequestGUID"] = RequstGuid;
            _policyResultBll = new UploadPolicyResult();

            #region 生成XML文件-UTF8
            string strFileName = Application.StartupPath + @"\Ctrip.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(strFileName, Encoding.UTF8);//UTF-8编码
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.Indentation = 4;
            xmlWriter.WriteStartDocument();//写入XML头声明

            #region XML Head
            xmlWriter.WriteStartElement("CommonPolicyAddRequest");
            xmlWriter.WriteStartAttribute("xmlns:xsd");
            xmlWriter.WriteString("http://www.w3.org/2001/XMLSchema");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteStartAttribute("xmlns:xsi");
            xmlWriter.WriteString("http://www.w3.org/2001/XMLSchema-instance");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteStartAttribute("xmlns");
            xmlWriter.WriteString("urn:ctrip:api:flight:trade:message:rawPolicy:v1");
            xmlWriter.WriteEndAttribute();
            #endregion XML Head

            #region MessageHead
            xmlWriter.WriteStartElement("MessageHead");
            xmlWriter.WriteStartElement("UserInfo");
            xmlWriter.WriteStartAttribute("xmlns");
            xmlWriter.WriteString("urn:ctrip:api:flight:trade:common:baseType:v1");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteStartElement("UserName");
            xmlWriter.WriteString(UserName);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("Password");
            xmlWriter.WriteString(Passwrod_MD5);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("ClientID");
            xmlWriter.WriteStartAttribute("xmlns");
            xmlWriter.WriteString("urn:ctrip:api:flight:trade:common:baseType:v1");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("5");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteStartElement("RequestGUID");
            xmlWriter.WriteStartAttribute("xmlns");
            xmlWriter.WriteString("urn:ctrip:api:flight:trade:common:baseType:v1");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString(RequstGuid);
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
            #endregion MessageHead

            #region MessageBody
            xmlWriter.WriteStartElement("MessageBody");
            xmlWriter.WriteStartElement("PolicyList");
            
            int policyCounts = ds.Tables[0].Rows.Count;
            string cabin = "";
            for (int i = 0; i < policyCounts; i++)
            {
                cabin = ds.Tables[0].Rows[i]["Cabin"].ToString();
                string strCabin = cabin.Substring(cabin.Length - 1, 1) == "/" ? cabin.Substring(0,cabin.Length - 1).Replace('/', ',') : cabin.Replace('/', ',');
                xmlWriter.WriteStartElement("Policy");
                xmlWriter.WriteStartElement("PolicyID");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["PolicyId"].ToString());
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("SummaryUnit");
                xmlWriter.WriteStartElement("PolicyCode");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Company"] + "_JINRI_" + ds.Tables[0].Rows[i]["PolicyId"]);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("AirLine");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Company"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("FlightWay");
                xmlWriter.WriteString("S");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("DepartPort");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["ScityE"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("ArrivePort");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["EcityE"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("ExpiryDate");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Edate"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("EffectDate");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Sdate"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("OfficeNo");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["OfficeNum"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("IsValid");
                xmlWriter.WriteString("T");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("GoFlightUnit");
                xmlWriter.WriteStartElement("EffectDate");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Sdate"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("ExpiryDate");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Edate"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Days");
                xmlWriter.WriteString("1234567");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("SubClass");
                xmlWriter.WriteString(strCabin);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("IsCanSale");
                xmlWriter.WriteString("T");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("RuleDetail");
                xmlWriter.WriteString("");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                //xmlWriter.WriteStartElement("BackFlightUnit");
                //xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("PriceUnit");
                xmlWriter.WriteStartElement("HasAssignPrice");
                xmlWriter.WriteStartAttribute("xsi:nil");
                xmlWriter.WriteString("true");
                xmlWriter.WriteEndAttribute();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("MinPrintPrice");
                xmlWriter.WriteStartAttribute("xsi:nil");
                xmlWriter.WriteString("true");
                xmlWriter.WriteEndAttribute();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("MaxPrintPrice");
                xmlWriter.WriteStartAttribute("xsi:nil");
                xmlWriter.WriteString("true");
                xmlWriter.WriteEndAttribute();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("ReturnPrice");
                xmlWriter.WriteString("1");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("ReturnPoint");
                xmlWriter.WriteString(ds.Tables[0].Rows[i]["Discounts"].ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
            }
            #endregion  MessageBody
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
            #endregion 

            string str = LoadContenFormFile(Application.StartupPath + "\\Ctrip.xml");
            string result = RequestPost(RequstUrl, str);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(result);
            xmldoc.Save("result.xml");
            DataSet tmpset = new DataSet();
            tmpset.ReadXml("result.xml");
            string _platform = ConfigurationManager.AppSettings["Platform"];
            string[] dicArray = _platform.Split(';');
            Dictionary<string, string> items = new Dictionary<string, string>();
            string[] item = new string[2];
            foreach (string s in dicArray)
            {
                item = s.Split(',');
                items.Add(item[0], item[1]);
            }
            int Uploadresult = _policyResultBll.Add(new Sanben.Model.UploadPolicyResult
            {
                sys_id = _sysid,
                startMode = "自动",
                upload_platFrom = items.ContainsKey("ctrip") ? items["ctrip"] : "",
                uploadTime = DateTime.Now,
                uploadType = 1,
                upload_class = 1,
                uploadNumber = Convert.ToInt32( tmpset.Tables["Summary"].Rows[0]["SuccessCount"]),
                uploadResult = Convert.ToInt32(tmpset.Tables["Summary"].Rows[0]["FailedCount"]) > 0 ? "失败" : "成功",
                errorNumber = Convert.ToInt32(tmpset.Tables["Summary"].Rows[0]["FailedCount"])

            });
        }

        public void Init()
        {
            _bll = new policy_options();
            ds = new DataSet();
            configSet = new DataSet();
            _getRateBll = new GetRateList();
            _bqyPolicyBll = new BaQianYiPolicy();
            _rebateBll = new rebate();
            _gaiqianBll = new gaiqian_retirement();
            _cabinDescriptionBll = new cabin_description();
            _policyResultBll = new UploadPolicyResult();
            _platformBll = new Platform_type();//平台类型
            _configBll =  new platform_config();//平台配置
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
                Filler();
                DiscountsModefy();
                GeiQian();
                CabinDetail();
            }
        }

        /// <summary>
        /// 过滤
        /// </summary>
        public void Filler()
        {
            string strWhere = @" Company in (select navigation_company from Policy_filter) and AirLine in (select air_line from Policy_filter)";
            strWhere += string.Format(@" and Discounts between {0} and {1}", lRabete, hRabete);
            ds = _getRateBll.GetList(strWhere);
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
                object st1 = ds.Tables[0].Rows[i]["Company"].ToString(); //
                object st2 = ds.Tables[0].Rows[i]["AirLine"].ToString();//
                object st3 = ds.Tables[0].Rows[i]["Discounts"].ToString(); //政策源返点
                //自定义留点
                if (rebateCount > 0)
                {
                    for (int j = 0; j < rebateCount; j++)
                    {
                        object s1 = rDataSet.Tables[0].Rows[j]["navigation_company"];  //航司
                        object s2 = rDataSet.Tables[0].Rows[j]["air_line"];//航线
                        object s3 = rDataSet.Tables[0].Rows[j]["rabate_number"];//返点
                        if (s1 == st1 && s2 == st2)
                        {
                            st3 = s3;
                        }
                    }
                }
                k = Convert.ToDouble(st3);
                k = k - rPoint;//默认留点
                ds.Tables[0].Rows[i]["Discounts"] = k;
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
                string st1 = ds.Tables[0].Rows[i]["Company"].ToString();
                string st2 = ds.Tables[0].Rows[i]["AirLine"].ToString();
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
                string st1 = ds.Tables[0].Rows[i]["Company"].ToString();
                string st2 = ds.Tables[0].Rows[i]["AirLine"].ToString();
                //仓位说明
                if (cabinCount > 0)
                {
                    for (int j = 0; j < cabinCount; j++)
                    {
                        string s1 = cabinSet.Tables[0].Rows[j]["navigation_company"].ToString();  //航司
                        string s2 = cabinSet.Tables[0].Rows[j]["air_line"].ToString();//航线
                        if (s1.ToLower() == st1.ToLower() && s2.ToLower() == st2.ToLower())
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

        private string LoadContenFormFile(string file)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    FileStream fs = new FileStream(file, FileMode.Open);
                    using (MemoryStream ms = new MemoryStream((int)fs.Length))
                    {
                        fs.CopyTo(ms);
                        fs.Close();

                        int position = 0;
                        byte[] buffer = ms.ToArray();
                        if (buffer.Length >= 3 && buffer[0] == 239 && buffer[1] == 187 && buffer[2] == 191)
                        {   // UTF8文件
                            position = 3;
                        }

                        result = Encoding.UTF8.GetString(ms.ToArray(), position, (int)ms.Length - position);
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
            }

            return result;
        }
        /// <summary>
        /// 返回经过格式化处理的xml文档
        /// </summary>
        /// <param name="result">请求文本</param>
        /// <returns></returns>
        private string GetFormatXml(string result)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            if (doc != null)
            {
                MemoryStream mstream = null;
                XmlTextWriter writer = null;
                try
                {
                    mstream = new MemoryStream(1024 * 1024 * 10);
                    writer = new XmlTextWriter(mstream, null);
                    writer.Formatting = System.Xml.Formatting.Indented;
                    doc.WriteTo(writer);
                    writer.Flush();
                    writer.Close();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    result = encoding.GetString(mstream.ToArray());
                    mstream.Close();
                }
                catch
                {
                    // 只能实现换行
                    result = doc.OuterXml.Replace(">\r\n", ">").Replace(">", ">\r\n");
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                    if (mstream != null)
                    {
                        mstream.Close();
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 提交请求报文，获得响应报文
        /// </summary>
        /// <param name="Url">url地址</param>
        /// <param name="Context">请求报文</param>
        /// <returns></returns>
        private string RequestPost(string Url, string Context)
        {
            string PageStr = string.Empty;
            Uri url = new Uri(Url);

            byte[] reqbytes = Encoding.UTF8.GetBytes(Context);

            Stream requestStream = null;
            Stream responseStream = null;
            StreamReader srd = null;
            HttpWebResponse resp = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Timeout = 300000;   // 5分钟超时
                req.Method = "POST";
                using (MemoryStream gzipStream = Gzip.Compress(reqbytes))
                {
                    reqbytes = gzipStream.ToArray();
                }
                req.Headers.Add("Content-Encoding", "gzip");
                req.Accept = "application/xml, */*";
                req.ContentType = "application/xml";
                req.ContentLength = reqbytes.Length;
                requestStream = req.GetRequestStream();
                requestStream.Write(reqbytes, 0, reqbytes.Length);
                requestStream.Close();
                resp = (HttpWebResponse)req.GetResponse();
                responseStream = resp.GetResponseStream();

                if (resp.ContentEncoding.ToLower().Contains("gzip"))
                {
                    responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                }

                srd = new StreamReader(responseStream, Encoding.UTF8);
                PageStr += srd.ReadToEnd();
                PageStr = GetFormatXml(PageStr);
                //req.KeepAlive = false;
                responseStream.Close();
                srd.Close();
                resp.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (requestStream != null)
                {
                    requestStream.Close();
                }
                if (responseStream != null)
                {
                    responseStream.Close();
                }
                if (resp != null)
                {
                    resp.Close();
                }
                if (srd != null)
                {
                    srd.Close();
                }
            }
            return PageStr;
        }


        /// <summary>
        /// 序列化请求
        /// </summary>
        /// <param name="requestType"></param>
        /// <param name="o"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string SerializeRequest(string requestType, object o, MessageFormatType format)
        {
            string s = string.Empty;
            if (requestTypeList.ContainsKey(requestType))
            {
                Type t = requestAssemblyList[requestType].GetType(requestTypeList[requestType]);
                XmlSerializer serilizer = new XmlSerializer(t);
                using (MemoryStream ms = new MemoryStream())
                {
                    serilizer.Serialize(ms, o);
                    s = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            return s;
        }

        /// <summary>
        /// 生成示例请求
        /// </summary>
        /// <param name="requestType"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string GenerateRequest(string requestType, MessageFormatType format)
        {
            string result = string.Empty;

            object request = null;
            Assembly ass = requestAssemblyList[requestType];
            if (ass != null)
            {
                request = ass.CreateInstance(requestTypeList[requestType]);
                request.InitSelf(new FlightObjectPropertySetter());
            }

            if (request != null)
            {
                result = SerializeRequest(requestType, request, format);
            }

            return result;
        }
        
        
    }
    public static class Gzip
    {
        public static MemoryStream Compress(Stream input)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream stream = new GZipStream(ms, CompressionMode.Compress);
            input.CopyTo(stream);
            stream.Close();

            return ms;
        }

        public static MemoryStream Compress(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            GZipStream stream = new GZipStream(ms, CompressionMode.Compress);
            stream.Write(data, 0, data.Length);
            stream.Close();

            return ms;
        }

        public static MemoryStream Decompress(Stream input)
        {
            int length = 65536;

            if (input.CanSeek)
            {
                //流可定位 取出压缩流长度 Gzip最后4位
                input.Position = input.Length - 4;
                byte[] bytes = new byte[4];
                input.Read(bytes, 0, 4);
                length = BitConverter.ToInt32(bytes, 0);
                input.Position = 0;
            }
            else
            {
                //如果输入流有Length 长度为Length * 30 因为压缩率为3%
                try { length = (int)input.Length * 20; }
                catch { length = 65536; }
            }


            using (GZipStream compressedzipStream = new GZipStream(input, CompressionMode.Decompress))
            {
                MemoryStream ms = new MemoryStream(length);
                byte[] block = new byte[65536];

                int byteRead = 0;
                do
                {
                    byteRead = compressedzipStream.Read(block, 0, block.Length);
                    ms.Write(block, 0, byteRead);
                }
                while (byteRead == block.Length);

                ms.Position = 0;
                return ms;
            }

            //int bytesRead = compressedzipStream.Read(block, 0, block.Length);
            //if (bytesRead > 0)
            //    ms.Write(block, 0, bytesRead);

            //while (true)
            //{
            //    bytesRead = compressedzipStream.Read(block, 0, block.Length);
            //    if (bytesRead <= 0)
            //        break;
            //    else
            //        ms.Write(block, 0, bytesRead);
            //}
            //compressedzipStream.Close();

        }

        public static MemoryStream Decompress(byte[] buffer)
        {
            MemoryStream input = new MemoryStream(buffer);

            return Decompress(input);
        }
    }
}
