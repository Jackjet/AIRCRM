#region MyRegion
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;
using System.Threading;
using Policy;
using Policy.entity;
using Policy.ServiceReference2;
using Policy.ServiceReference3;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Web; 
#endregion

namespace AIRCRM.UI
{
    public partial class CRM_PolicyGet : DevExpress.XtraEditors.XtraForm
    {
        #region MyRegion
        private String bquser = "test8000";
        private String bqpwd = "test8000";
        private String jruser = "sanben";
        private int obqyCount = 0;  //没更新前的八千翼政策数量
        private int bqyCount = 0;   //更新后的八千翼政策数量
        private int jrCount = 0;    //没更新前的今日政策数量
        private int ojrCount = 0;   //更新后的今日政策数量
        private int osblCount = 0;  //没更新前的380政策数量
        private int sblCount = 0;   //更新后的380政策数量

        #region 变量声明
        string tabTitle = null;
        string[] Titles = null;
        string[] strQuick = new string[] { "B", "W", "J", "S" };
        string[] strIcons = new string[] { "8000yi.png", "51book.png", "jinri.png", "380.png" };
        int TitleIndex = 0;
        Image img = null;
        DataGridView dgv = null;
        DevExpress.XtraTab.XtraTabPage tab = null;
        private bool isExecuted = false;
        private delegate void InvokeHandler();
        #endregion
        public CRM_PolicyGet()
        {
            InitializeComponent();
            Label.CheckForIllegalCrossThreadCalls = false;
            tabTitle = ConfigurationManager.AppSettings["Platform"];
            InitControl();
        }

        private void CRM_PolicyGet_Load(object sender, EventArgs e)
        {
            xtraTabControl1.TabPages[1].PageVisible = false;
            xtraTabControl1.TabPages[2].PageVisible = false;
            this.ojrCount = (int)DBHelper.ExecuteScalar("select COUNT(id) from GetRateList");
            this.obqyCount = (int)DBHelper.ExecuteScalar("select COUNT(id) from BaQianYiPolicy");
            this.sblCount = (int)DBHelper.ExecuteScalar("select COUNT(id) from Ticket380Policy");
        } 
        #endregion

        #region 启动线程任务
        /// <summary>
        /// 开始执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_ExecutePolicy_Click(object sender, EventArgs e)
        {
            isExecuted = !isExecuted;
            btn_ExecuteGetPolicy.Text = isExecuted ? "停止任务(&T)" : "获取政策(&G)";
            ThreadStart[] PolicyThreads = new ThreadStart[] {
                new ThreadStart(Add800yi),
                new ThreadStart(Jinri),
                new ThreadStart(Get380Add)
            };
            foreach (ThreadStart ts in PolicyThreads)
            {
                new Thread(ts).Start();
            };
        }
        #endregion

        #region 初始化提控件
        /// <summary>
        /// 初始化提控件
        /// </summary>
        public void InitControl()
        {
            foreach (string pName in tabTitle.Split(';'))
            {
                Titles = pName.Split(',');
                img = Image.FromFile(Application.StartupPath + "\\Images\\" + strIcons[TitleIndex]);
                var tab = new DevExpress.XtraTab.XtraTabPage();
                tab.Name = Titles[0];
                tab.Text = Titles[1];
                tab.Image = img;
                dgv = new DataGridView();
                dgv.Name = "dgv_" + Titles[0];
                dgv.Dock = DockStyle.Fill;
                tab.Controls.Add(dgv);
                xtraTabControl1.TabPages.Add(tab);
                TitleIndex++;
            }
        }
        #endregion

        #region 政策
        #region 八千翼政策
        #region 获取八千翼平台政策
        /// <summary>
        /// 获取八千翼平台政策
        /// </summary>
        /// <returns></returns>
        private List<BaQianYiPolicy> Yi8000()
        {
            try
            {
                PlyIntefaceServiceSoapClient ply = new PlyIntefaceServiceSoapClient();
                string name = bquser;
                string pwd = bqpwd;
                string lastupdatetime = DBHelper.ExecuteScalar("select last_modify_time from BaQianYiPolicy order by last_modify_time desc").ToString();

                DataSet ds = ply.AlreadyDisposalSynchronizationNew(name, pwd, lastupdatetime);
                string result = ds.GetXml();
                if (result.Contains("_x0034_8"))
                    return null;
                XmlDocument document = new XmlDocument();
                document.LoadXml(result);
                XmlNodeList table = document.FirstChild.ChildNodes;
                this.bqyCount = table.Count;
                List<BaQianYiPolicy> list = new List<BaQianYiPolicy>();
                foreach (XmlNode item in table)
                {
                    BaQianYiPolicy bq = new BaQianYiPolicy();
                    bq.policy_num = item.ChildNodes[0].InnerText;
                    bq.startcity = item.ChildNodes[1].InnerText;
                    bq.arrivecity = item.ChildNodes[2].InnerText;
                    bq.airline = item.ChildNodes[3].InnerText;
                    bq.for_flight_no = item.ChildNodes[4].InnerText;
                    bq.ex_flight_no = item.ChildNodes[5].InnerText;
                    bq.policy_ratype = item.ChildNodes[6].InnerText;
                    bq.point = item.ChildNodes[7].InnerText;
                    string cabin = item.ChildNodes[8].InnerText;
                    if (cabin.Contains("p"))
                    {
                        int index = cabin.IndexOf("p");
                        cabin = cabin.Remove(index, 1);
                        cabin = cabin.Remove(index - 1, 1);
                    }
                    cabin = cabin.Replace("\n", "");
                    cabin = cabin.Replace("\r", "");
                    bq.cabin_discount = cabin;
                    bq.startdate = item.ChildNodes[9].InnerText;
                    bq.arrivedate = item.ChildNodes[10].InnerText;
                    bq.nomal_workday = item.ChildNodes[11].InnerText;
                    bq.weekday = item.ChildNodes[12].InnerText;
                    bq.vip_policy = item.ChildNodes[13].InnerText;
                    bq.return_policy = item.ChildNodes[14].InnerText;
                    bq.policy_type = item.ChildNodes[15].InnerText;
                    bq.policy_note = item.ChildNodes[16].InnerText;
                    bq.supplier_id = item.ChildNodes[17].InnerText;
                    bq.or_ticket_t = item.ChildNodes[18].InnerText;
                    bq.week_ticket_t = item.ChildNodes[19].InnerText;
                    bq.policy_flight = item.ChildNodes[20].InnerText;
                    bq.end_state = item.ChildNodes[21].InnerText;
                    bq.last_modify_time = item.ChildNodes[22].InnerText;
                    bq.office_code = item.ChildNodes[23].InnerText;
                    bq.salestart_date = item.ChildNodes[24].InnerText;
                    bq.saleend_date = item.ChildNodes[25].InnerText;
                    bq.support_pay = item.ChildNodes[26].InnerText;
                    bq.ticket_efficient = item.ChildNodes[27].InnerText;
                    bq.is_cgnum_ticket = item.ChildNodes[28].InnerText;
                    bq.is_open_low = item.ChildNodes[29].InnerText;
                    bq.addtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    list.Add(bq);
                }
                return list;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }
        #endregion

        #region 添加八千翼政策到数据库
        /// <summary>
        /// 添加八千翼政策到数据库
        /// </summary>
        /// <param name="list"></param>
        private void Add800yi()
        {
            lbl_Status.Text = "正在获取八千翼政策...";
            List<BaQianYiPolicy> list = Yi8000();
            if (list != null && list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    BaQianYiPolicy bq = list[i];
                    StringBuilder sb = new StringBuilder("insert into BaQianYiPolicy values(");
                    sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}',", bq.policy_num, bq.startcity, bq.arrivecity, bq.airline, bq.for_flight_no, bq.ex_flight_no);
                    sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}',", bq.policy_ratype, bq.point, bq.cabin_discount, bq.startdate, bq.arrivedate, bq.nomal_workday);
                    sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}',", bq.weekday, bq.vip_policy, bq.return_policy, bq.policy_type, bq.policy_note, bq.supplier_id);
                    sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}',", bq.or_ticket_t, bq.week_ticket_t, bq.policy_flight, bq.end_state, bq.office_code, bq.salestart_date);
                    sb.AppendFormat("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','','')", bq.saleend_date, bq.support_pay, bq.ticket_efficient, bq.is_cgnum_ticket, bq.is_open_low, bq.addtime, bq.last_modify_time);
                    try
                    {
                        lbl_Status.Text = "正在存储八千翼政策...";
                        DBHelper.ExecuteNonQuery(sb.ToString());
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + "执行方法Add800yi()时出错");
                    }
                }
                foreach (DevExpress.XtraTab.XtraTabPage p in xtraTabControl1.TabPages)
                {
                    var dgv = p.Controls.Find("dgv_8000yi", true);
                    if (dgv.Length > 0)
                    {
                        DataGridView myView = dgv[0] as DataGridView;
                        this.Invoke(new InvokeHandler(delegate() {
                            myView.DataSource = null;
                            myView.DataSource = list;
                        }));
                    }
                }
            }
            lbl_Status.Text = "八千翼政策更新成功！\n等待下一次更新...";
            btn_ExecuteGetPolicy.Text = "获取政策(&G)";
        }
        #endregion 
        #endregion

        #region 今日政策

        #region 获取今日天下通政策
        /// <summary>
        /// 获取今日天下通政策
        /// </summary>
        /// <param name="username"></param>
        /// <param name="am"></param>
        private void Jinri()
        {
            try
            {
                lbl_Status.Text = "正在获取今日天下通政策...";
                int count = (int)DBHelper.ExecuteScalar("select COUNT(id) from AirMan where id in(select max(id) from AirMan  group by StartCode,ArriveCode)");
                int pageCount = 0;
                if (count % 50 == 0)
                    pageCount = count / 50;
                else
                    pageCount = count / 50 + 1;
                for (int i = 0; i < pageCount; i++)
                {
                    List<AirMan> airs = GetAirman(i);
                    for (int j = 0; j < airs.Count; j++)
                    {
                        StringBuilder sb = new StringBuilder("<?xml version='1.0' encoding='gb2312' ?>");
                        sb.Append("<JIT-Policy-Request>");
                        sb.AppendFormat("<Request username='{0}' SystemId='{1}' scity='{2}' ecity='{3}' date='{4}' aircome='' voyagetype='' amount='10' cabin='' /> ", jruser, "", airs[j].StartCode, airs[j].ArriveCode, DateTime.Today.ToString("yyyy-MM-dd"));
                        sb.Append("</JIT-Policy-Request>");
                        JinRiRateServerSoapClient jinri = new JinRiRateServerSoapClient();
                        string result = jinri.GetRateList(sb.ToString());

                        if (!result.Contains("Response"))
                            continue;
                        else
                        {
                            lbl_Status.Text = "正在存储今日天下通政策...";
                            ThreadSave(result);
                            lbl_Status.Text = "今日天下通政策更新成功，\n等待下一次更新...";
                            btn_ExecuteGetPolicy.Text = "获取政策(&G)";
                        }
                        Thread.Sleep(30000);
                    }
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message + "执行方法Jinri()出错了");
            }
        }
        #endregion

        #region 添加今日政策到数据库
        /// <summary>
        /// 添加今日政策到数据库
        /// </summary>
        /// <param name="xmldata"></param>
        private void SaveJinri(object xmldata)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(xmldata.ToString());
                XmlNodeList response = document.GetElementsByTagName("Response");
                if (response.Count > 0)
                {
                    List<JinriPolicy> list = new List<JinriPolicy>();
                    foreach (XmlNode item in response)
                    {
                        JinriPolicy j = new JinriPolicy();
                        j.PolicyID = item.Attributes[0].InnerText;
                        j.RateID = item.Attributes[1].InnerText;
                        j.ScityE = item.Attributes[2].InnerText;
                        j.EcityE = item.Attributes[3].InnerText;
                        j.AirComE = item.Attributes[4].InnerText;
                        j.NoAirComE = item.Attributes[5].InnerText;
                        j.PolicyType = item.Attributes[6].InnerText;
                        j.Cabin = item.Attributes[7].InnerText;
                        j.VoyageType = item.Attributes[8].InnerText;
                        j.UserType = item.Attributes[9].InnerText;
                        j.RateType = item.Attributes[10].InnerText;
                        j.Discounts = item.Attributes[11].InnerText;
                        j.Sdate = item.Attributes[12].InnerText;
                        j.Edate = item.Attributes[13].InnerText;
                        j.WorkTimBegin = item.Attributes[14].InnerText;
                        j.WorkTImeEnd = item.Attributes[15].InnerText;
                        j.Rewards = item.Attributes[16].InnerText;
                        j.Remark = item.Attributes[17].InnerText;
                        j.ET = item.Attributes[18].InnerText;
                        j.WP = item.Attributes[19].InnerText;
                        j.SP = item.Attributes[20].InnerText;
                        j.XF = item.Attributes[21].InnerText;
                        j.PromotionDiscount = item.Attributes[22].InnerText;
                        j.NewRateNo = item.Attributes[23].InnerText;
                        j.OfficeNum = item.Attributes[24].InnerText;
                        if (item.Attributes["RefundTimeBegin"] != null)
                            j.RefundTimeBegin = item.Attributes["RefundTimeBegin"].InnerText;
                        if (item.Attributes["RefundTimeEnd"] != null)
                            j.RefundTimeEnd = item.Attributes["RefundTimeEnd"].InnerText;
                        if (item.Attributes["LastModifyTime"] != null)
                            j.LastModifyTime = item.Attributes["LastModifyTime"].InnerText;
                        list.Add(j);
                    }
                    foreach (JinriPolicy item in list)
                    {
                        StringBuilder sql = new StringBuilder("insert into GetRateList values( ");
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.PolicyID, item.RateID, item.ScityE, item.EcityE);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.AirComE, item.NoAirComE, item.PolicyType, item.Cabin);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.VoyageType, item.UserType, item.RateType, item.Discounts);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.Sdate, item.Edate, item.WorkTimBegin, item.WorkTImeEnd);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.Rewards, item.Remark, item.ET, item.WP);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.SP, item.XF, item.PromotionDiscount, item.NewRateNo);
                        sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.OfficeNum, item.RefundTimeBegin, item.RefundTimeEnd, item.LastModifyTime);
                        sql.Append("'','','','',");
                        sql.Append("'','','','',");
                        sql.Append("'','','','',");
                        sql.AppendFormat("'','','{0}','{1}',", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), item.AirComE);
                        sql.AppendFormat("'{0}','','')", item.ScityE + "-" + item.EcityE);
                        int ir = DBHelper.ExecuteNonQuery(sql.ToString());
                    }
                    foreach (DevExpress.XtraTab.XtraTabPage p in xtraTabControl1.TabPages)
                    {
                        var dgv = p.Controls.Find("dgv_jinri", true);
                        if (dgv.Length > 0)
                        {
                            DataGridView myView = dgv[0] as DataGridView;
                            this.Invoke(new InvokeHandler(delegate () {
                                myView.DataSource = null;
                                myView.DataSource = list;
                            }));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "执行方法SaveJinri()时间出错");
            }

        }
        #endregion

        #region 线程存储今日政策
        /// <summary>
        /// 线程存储今日政策
        /// </summary>
        /// <param name="xmldata"></param>
        public void ThreadSave(string xmldata)
        {
            Thread th = new Thread(new ParameterizedThreadStart(SaveJinri));
            th.Start(xmldata);
        }
        #endregion

        #region 添加今日政策
        /// <summary>
        /// 添加今日政策
        /// </summary>
        /// <param name="list"></param>
        private void AddJinri(List<JinriPolicy> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                JinriPolicy item = list[i];
                StringBuilder sql = new StringBuilder("insert into GetRateList values( ");
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.PolicyID, item.RateID, item.ScityE, item.EcityE);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.AirComE, item.NoAirComE, item.PolicyType, item.Cabin);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.VoyageType, item.UserType, item.RateType, item.Discounts);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.Sdate, item.Edate, item.WorkTimBegin, item.WorkTImeEnd);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.Rewards, item.Remark, item.ET, item.WP);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.SP, item.XF, item.PromotionDiscount, item.NewRateNo);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", item.OfficeNum, item.RefundTimeBegin, item.RefundTimeEnd, item.LastModifyTime);
                sql.Append("'','','','',");
                sql.Append("'','','','',");
                sql.Append("'','','','',");
                sql.AppendFormat("'','','{0}','{1}',", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), item.AirComE);
                sql.AppendFormat("'{0}','','')", item.ScityE + "-" + item.EcityE);
                int result = DBHelper.ExecuteNonQuery(sql.ToString());
            }
        }
        #endregion
        #endregion

        #region 380政策
        #region 获取380全量政策数据
        /// <summary>
        /// 获取380全量政策数据
        /// </summary>
        private void Get380All()
        {
            string key = "d2a2161e2cd3434a874e80674a0bae7e";
            string charset = "utf-8";
            string parameter = @"<policyfile><lastupdatetime/></policyfile>";
            SortedDictionary<string, string> data = new SortedDictionary<string, string>();
            data.Add("charset", charset);
            data.Add("partner", "2015041409000001");
            data.Add("parameter", parameter.ToLower());
            data.Add("service", "policyfile");
            data.Add("ver", "1.0");
            data.Add("xmlhead", "1");
            string sign = SignHelper.BuildMD5sign(data, key, charset);
            data["parameter"] = HttpUtility.UrlDecode(parameter.ToLower(), Encoding.GetEncoding(charset));
            string postData = SignHelper.BuildRequestQuery(data) + "&signtype=md5&sign=" + sign;
            string error = string.Empty;
            //string url = "http://api.banglv.cn/OpenApi.aspx";
            string url = "http://api.380.cn/openApi.aspx";

            try
            {
                string result = HttpPost(url, postData);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(result);

                XmlNode code = doc.ChildNodes[1].ChildNodes[0];
                if (!code.InnerText.Equals("0"))
                {
                    string inputStr = doc.SelectSingleNode("policyfile").SelectSingleNode("result").InnerText;
                    if (!string.IsNullOrEmpty(inputStr))
                    {
                        byte[] inputBytes = System.Convert.FromBase64String(inputStr);
                        string path = "d:\\380policy";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        FileStream fs = new FileStream(path + "\\policy.zip", FileMode.Create);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(inputBytes);
                        bw.Close();
                        fs.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 获取380增量政策数据
        /// <summary>
        /// 获取380增量政策数据
        /// </summary>
        private void Get380Add()
        {
            string lastupdatetime = DBHelper.ExecuteScalar("select logtime from Ticket380Policy order by logtime desc").ToString();
            string key = "d2a2161e2cd3434a874e80674a0bae7e";
            string charset = "utf-8";
            string parameter = string.Format(@"<policyadd><lastupdatetime>2015-04-20 00:00:00</lastupdatetime><type>add</type></policyadd>");
            SortedDictionary<string, string> data = new SortedDictionary<string, string>();
            data.Add("charset", charset);
            data.Add("partner", "2015041409000001");
            data.Add("parameter", parameter.ToLower());
            data.Add("service", "policyadd");
            data.Add("ver", "1.0");
            data.Add("xmlhead", "1");
            string sign = SignHelper.BuildMD5sign(data, key, charset);
            data["parameter"] = HttpUtility.UrlDecode(parameter.ToLower(), Encoding.GetEncoding(charset));
            string postData = SignHelper.BuildRequestQuery(data) + "&signtype=md5&sign=" + sign;
            string error = string.Empty;

            //string url = "http://api.banglv.cn/OpenApi.aspx";
            string url = "http://api.380.cn/openApi.aspx";

            try
            {
                string result = HttpPost(url, postData);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(result);
                XmlNode code = doc.ChildNodes[1].ChildNodes[0];
                if (!code.InnerText.Equals("0"))
                {
                    XmlNodeList policys = doc.ChildNodes[1].ChildNodes[2].ChildNodes;
                    List<Ticket380Policy> list = new List<Ticket380Policy>();
                    foreach (XmlNode item in policys)
                    {
                        Ticket380Policy t = new Ticket380Policy();
                        t.policy_id = item.ChildNodes[0].InnerText;
                        t.air_comp = item.ChildNodes[1].InnerText;
                        t.start_city = item.ChildNodes[2].InnerText;
                        t.arr_city = item.ChildNodes[3].InnerText;
                        t.flight = item.ChildNodes[4].InnerText;
                        t.cabin = item.ChildNodes[5].InnerText;
                        t.share_line = item.ChildNodes[6].InnerText;
                        t.price = item.ChildNodes[7].InnerText;
                        t.point = item.ChildNodes[8].InnerText;
                        t.nakednum = item.ChildNodes[9].InnerText;
                        t.is_auto_tic = item.ChildNodes[10].InnerText;
                        t.logtime = item.ChildNodes[11].InnerText;
                        t.deptime = item.ChildNodes[12].InnerText;
                        t.remark = item.ChildNodes[13].InnerText;
                        t.fsdate = item.ChildNodes[14].InnerText;
                        t.fedate = item.ChildNodes[15].InnerText;
                        t.sale_sdate = item.ChildNodes[16].InnerText;
                        t.sale_edate = item.ChildNodes[17].InnerText;
                        t.AddTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        list.Add(t);
                    }
                    foreach (DevExpress.XtraTab.XtraTabPage p in xtraTabControl1.TabPages)
                    {
                        var dgv = p.Controls.Find("dgv_380", true);
                        if (dgv.Length > 0)
                        {
                            DataGridView myView = dgv[0] as DataGridView;
                            this.Invoke(new InvokeHandler(delegate () {
                                myView.DataSource = null;
                                myView.DataSource = list;
                            }));
                        }
                    }
                    Insert380Add(list);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 插入380全量政策数据到数据库
        /// <summary>
        /// 插入380全量政策数据到数据库
        /// </summary>
        private void Insert380All()
        {
            string file = "d:\\380policy\\policy.xml";
            if (File.Exists(file))
            {
                ZipHepler.UnZip("d:\\380policy\\policy.zip", "d:\\380policy\\", "", false);
                XmlDocument doc = new XmlDocument();
                doc.Load("f:\\380policy\\policy.xml");
                XmlNodeList policys = doc.ChildNodes[1].ChildNodes;
                foreach (XmlNode item in policys)
                {
                    Ticket380Policy t = new Ticket380Policy();
                    t.policy_id = item.ChildNodes[0].InnerText;
                    t.air_comp = item.ChildNodes[1].InnerText;
                    t.start_city = item.ChildNodes[2].InnerText;
                    t.arr_city = item.ChildNodes[3].InnerText;
                    t.flight = item.ChildNodes[4].InnerText;
                    t.cabin = item.ChildNodes[5].InnerText;
                    t.share_line = item.ChildNodes[6].InnerText;
                    t.price = item.ChildNodes[7].InnerText;
                    t.point = item.ChildNodes[8].InnerText;
                    t.nakednum = item.ChildNodes[9].InnerText;
                    t.is_auto_tic = item.ChildNodes[10].InnerText;
                    t.logtime = item.ChildNodes[11].InnerText;
                    t.deptime = item.ChildNodes[12].InnerText;
                    t.remark = item.ChildNodes[13].InnerText;
                    t.fsdate = item.ChildNodes[14].InnerText;
                    t.fedate = item.ChildNodes[15].InnerText;
                    t.sale_sdate = item.ChildNodes[16].InnerText;
                    t.sale_edate = item.ChildNodes[17].InnerText;
                    t.AddTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    break;
                }
            }
        }
        #endregion

        #region 插入380增量政策数据到数据库
        /// <summary>
        /// 插入380增量政策数据到数据库
        /// </summary>
        /// <param name="list"></param>
        private void Insert380Add(List<Ticket380Policy> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Ticket380Policy t = list[i];
                StringBuilder sql = new StringBuilder("insert into Ticket380Policy ");
                sql.AppendFormat("values('{0}','{1}','{2}','{3}',", t.policy_id, t.air_comp, t.start_city, t.arr_city);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", t.flight, t.cabin, t.share_line, t.cabinprice);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", t.point, t.nakednum, t.is_auto_tic, t.logtime);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", t.deptime, t.price, t.remark, t.fsdate);
                sql.AppendFormat("'{0}','{1}','{2}','{3}',", t.fedate, t.sale_sdate, t.sale_edate, t.AddTime);
                sql.Append("'','')");
                DBHelper.ExecuteNonQuery(sql.ToString());
            }
        }
        #endregion
        #endregion 
        #endregion

        #region 获取航线
        /// <summary>
        /// 获取航线
        /// </summary>
        /// <returns></returns>
        private List<AirMan> GetAirman()
        {
            SqlDataReader sdr = DBHelper.ExecuteReader("select * from AirMan where id in(select max(id) from AirMan  group by StartCode,ArriveCode)");
            if (sdr.HasRows)
            {
                List<AirMan> list = new List<AirMan>();
                while (sdr.Read())
                {
                    AirMan a = new AirMan();
                    a.id = sdr.GetInt32(0);
                    a.StartCode = sdr.GetString(1);
                    a.ArriveCode = sdr.GetString(2);
                    a.CarrierName = sdr.GetString(3);
                    a.Status = sdr.GetString(4);
                    a.AddTime = sdr.GetDateTime(5);
                    list.Add(a);
                }
                return list;
            }
            return null;
        }
        #endregion

        #region 获取航线-分页
        /// <summary>
        /// 获取航线-分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        private List<AirMan> GetAirman(int pageIndex)
        {
            //DataTable db = DBHelper.GetTable("select * from AirMan where id in(select max(id) from AirMan  group by StartCode,ArriveCode)");
            StringBuilder sb = new StringBuilder("select top 50 * from AirMan where id in(select max(id) from AirMan  group by StartCode,ArriveCode)");
            sb.AppendFormat("and id not in(select top ({0}*50) id from AirMan where id in(select max(id) from AirMan  group by StartCode,ArriveCode))", pageIndex);
            SqlDataReader sdr = DBHelper.ExecuteReader(sb.ToString());
            if (sdr.HasRows)
            {
                List<AirMan> list = new List<AirMan>();
                while (sdr.Read())
                {
                    AirMan a = new AirMan();
                    a.id = sdr.GetInt32(0);
                    a.StartCode = sdr.GetString(1);
                    a.ArriveCode = sdr.GetString(2);
                    a.CarrierName = sdr.GetString(3);
                    a.Status = sdr.GetString(4);
                    a.AddTime = sdr.GetDateTime(5);
                    list.Add(a);
                }
                return list;
            }
            return null;
        }
        #endregion

        #region 执行HTTP-Post请求
        /// <summary>
        /// 执行HTTP-Post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string HttpPost(String url, string parameters)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";


            request.ContentLength = parameters.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII);
            writer.Write(parameters);
            writer.Flush();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码  
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;
        }
        #endregion
    }
}
