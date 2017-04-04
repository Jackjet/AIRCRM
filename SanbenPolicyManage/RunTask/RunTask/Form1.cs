#region 程序集
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Sanben.BLL; 
#endregion

namespace RunTask
{
    public partial class Form1 : Form
    {
        #region 变量声明
        private DataSet dsMain = null;
        private string _policySources = null;
        private string _policyType = null;
        private string _platform = null;
        private int alltime = 0;
        private int addtime = 0;
        private TimeSpan _timeSpanStart;
        TimeSpan _timeSpanStart2;
        private string userids = null;
        private int iCount = 0;
        private int curRowIndex = 0;
        public int Taskid = 0;
        private Sanben.BLL.sys_user _userbll = null;
        private Sanben.BLL.uploadTask _bll = null; 
        #endregion
        public Form1()
        {
            InitializeComponent();
            dsMain = new DataSet();
            _userbll = new sys_user();
            _bll = new uploadTask();

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            _bll = new uploadTask();
            _bll.UpdateAll();
            timer1.Interval = 1000;
            
            dgvTask.AutoGenerateColumns = false;
            _policySources = ConfigurationManager.AppSettings["PolicySources"];
            _policyType = ConfigurationManager.AppSettings["PolicyType"];
            _platform = ConfigurationManager.AppSettings["Platform"];
            alltime = Convert.ToInt32( ConfigurationManager.AppSettings["AllTime"]);
            addtime = Convert.ToInt32( ConfigurationManager.AppSettings["AddTime"]);
            _timeSpanStart = new TimeSpan(0,0,alltime,0);
            _timeSpanStart2 = new TimeSpan(0, 0, addtime, 0);
            FillDataGrid();
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillDataGrid();
            List<Sanben.Model.uploadTask> obj = _bll.GetModelList("");
            string nowTime = DateTime.Now.ToLongTimeString();
            foreach (Sanben.Model.uploadTask m in obj)
            {
                Sanben.Model.uploadTask task = _bll.GetModelList("").Where(a => a.execution_time == m.execution_time).First();
                if (nowTime == m.execution_time.ToLongTimeString() )
                {
                    task.condition = true;
                    task.execute_number++;
                    task.NextFullTime = task.NextFullTime.HasValue ? task.NextFullTime.Value.AddMinutes(alltime) : m.execution_time.AddMinutes(alltime) ;
                    task.NextAddTime = task.NextAddTime.HasValue ?  task.NextAddTime.Value.AddMinutes(addtime) : m.execution_time.AddMinutes(addtime);
                    _bll.Update(task);
                    this.Text = m.execution_time.ToLongTimeString();
                    FillDataGrid();
                    foreach (string s in task.policySource.Split(','))
                    {
                        if (s == "jinri")
                        {
                            if (task.upload_platFrom == "ctrip")
                            {
                                Ctrip myTrip = new Ctrip(task.sys_id, false);
                            }
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                run r = new run(task.sys_id, true);
                            }
                        }
                        if (s == "8000yi")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                BQY bqy = new BQY(task.sys_id, true);
                            }
                        }
                        if (s == "piaomeng")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                PM bqy = new PM(task.sys_id, true);
                            }
                        }

                    }
                    
                }

                if (m.NextFullTime.HasValue && nowTime == m.NextFullTime.Value.ToLongTimeString())
                {
                    task.condition = true;
                    task.execute_number++;
                    task.NextFullTime = task.NextFullTime.HasValue ? task.NextFullTime.Value.AddMinutes(alltime) : m.execution_time.AddMinutes(alltime);
                    _bll.Update(task);
                    this.Text = m.NextFullTime.Value.ToLongTimeString();
                    FillDataGrid();
                    foreach (string s in task.policySource.Split(','))
                    {
                        if (s == "jinri")
                        {
                            if (task.upload_platFrom == "ctrip")
                            {
                                Ctrip myTrip = new Ctrip(task.sys_id, false);
                            }
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                run r = new run(task.sys_id, true);
                            }
                        }
                        if (s == "8000yi")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                BQY bqy = new BQY(task.sys_id, true);
                            }
                        }
                        if (s == "piaomeng")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                PM bqy = new PM(task.sys_id, true);
                            }
                        }
                    }
                }

                if (m.NextAddTime.HasValue && nowTime == m.NextAddTime.Value.ToLongTimeString())
                {
                    task.condition = true;
                    task.execute_number++;
                    task.NextAddTime = task.NextAddTime.HasValue ? task.NextAddTime.Value.AddMinutes(addtime) : m.execution_time.AddMinutes(addtime);
                    _bll.Update(task);
                    this.Text = m.NextAddTime.Value.ToLongTimeString();
                    FillDataGrid();
                    foreach (string s in task.policySource.Split(','))
                    {
                        if (s == "jinri")
                        {
                            if (task.upload_platFrom == "ctrip")
                            {
                                Ctrip myTrip = new Ctrip(task.sys_id, false);
                            }
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                run r = new run(task.sys_id, true);
                            }
                        }
                        if (s == "8000yi")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                BQY bqy = new BQY(task.sys_id, true);
                            }
                        }
                        if (s == "piaomeng")
                        {
                            if (task.upload_platFrom == "qunaerTH")
                            {
                                PM bqy = new PM(task.sys_id, true);
                            }
                        }
                    }
                }

            }
        }


        public void FillDataGrid()
        {
            dsMain = _bll.GetList("");
            string dicString = _platform + ";" + _policySources + ";" + _policyType;
            string[] dicArray = dicString.Split(';');
            Dictionary<string, string> items = new Dictionary<string, string>();
            string[] item = new string[2];
            foreach (string s in dicArray)
            {
                item = s.Split(',');
                items.Add(item[0], item[1]);
            }
            dsMain.Tables[0].Columns.Add("StatusName");
            dsMain.Tables[0].Columns.Add("IsSpecial");
            dsMain.Tables[0].Columns.Add("PointAndMoney");
            dsMain.Tables[0].Columns.Add("AllOrAdd");
            dsMain.Tables[0].Columns.Add("TheTripType");
            dsMain.Tables[0].Columns.Add("Frequency");
            dsMain.Tables[0].Columns.Add("UserName");
            int count = dsMain.Tables[0].Rows.Count;
            #region 表格信息
            for (int i = 0; i < count; i++)
            {
                dsMain.Tables[0].Rows[i]["StatusName"] = dsMain.Tables[0].Rows[i]["condition"].Equals(true) ? "已启动" : "未启动";
                userids += dsMain.Tables[0].Rows[i]["sys_id"].ToString() + ",";
                int result = Convert.ToInt32(dsMain.Tables[0].Rows[i]["upload_class"]);
                switch (result)
                {
                    case 0:
                        dsMain.Tables[0].Rows[i]["PointAndMoney"] = "返点留钱";
                        break;
                    case 1:
                        dsMain.Tables[0].Rows[i]["PointAndMoney"] = "只返点";
                        break;
                    case 2:
                        dsMain.Tables[0].Rows[i]["PointAndMoney"] = "只留钱";
                        break;
                    default:
                        break;
                }
                dsMain.Tables[0].Rows[i]["IsSpecial"] = dsMain.Tables[0].Rows[i]["uploadPlatFrom_specialPolicies"].Equals(true) ? "是" : "否";
                dsMain.Tables[0].Rows[i]["AllOrAdd"] = Convert.IsDBNull(dsMain.Tables[0].Rows[i]["uploadType"]) ? "" : (Convert.ToInt32(dsMain.Tables[0].Rows[i]["uploadType"]) == 0 ? "全量" : "增量");
                dsMain.Tables[0].Rows[i]["TheTripType"] = Convert.IsDBNull(dsMain.Tables[0].Rows[i]["tripType"]) ? "" : (Convert.ToInt32(dsMain.Tables[0].Rows[i]["tripType"]) == 0 ? "单程" : "往返");
                dsMain.Tables[0].Rows[i]["Frequency"] = Convert.IsDBNull(dsMain.Tables[0].Rows[i]["execution_frequency"]) ? "" : (Convert.ToInt32(dsMain.Tables[0].Rows[i]["execution_frequency"]) == 1 ? "每天" : "");
                string strPlatform = dsMain.Tables[0].Rows[i]["upload_platFrom"].ToString();
                dsMain.Tables[0].Rows[i]["upload_platFrom"] = items.ContainsKey(strPlatform) ? items[strPlatform] : "";
                string strPolicyClass = dsMain.Tables[0].Rows[i]["policy_class"].ToString();
                dsMain.Tables[0].Rows[i]["policy_class"] = items.ContainsKey(strPolicyClass) ? items[strPolicyClass] : "";
                string strPolicySources = dsMain.Tables[0].Rows[i]["policySource"].ToString();
                if (strPolicySources.Contains(","))
                {
                    string strPolicy = "";
                    string[] sources = strPolicySources.Split(',');
                    foreach (string p in sources)
                    {
                        strPolicy += items.ContainsKey(p.Trim()) ? items[p.Trim()] + "," : "";
                    }
                    dsMain.Tables[0].Rows[i]["policySource"] = strPolicy.Substring(0, strPolicy.Length - 1);
                }
                else
                {
                    dsMain.Tables[0].Rows[i]["policySource"] = items.ContainsKey(strPolicySources) ? items[strPolicySources] : "";
                }
            }
            #endregion

            #region 用户名与ID
            string strWhere = string.Format(@" id in ( {0} )", userids.Substring(0, userids.Length - 1));
            DataSet userDataSet = _userbll.GetList(strWhere);
            Dictionary<int, string> dicUserList = new Dictionary<int, string>();
            for (int i = 0; i < userDataSet.Tables[0].Rows.Count; i++)
            {
                dicUserList.Add(Convert.ToInt32(userDataSet.Tables[0].Rows[i]["id"]), userDataSet.Tables[0].Rows[i]["RealName"].ToString());
            }

            for (int i = 0; i < count; i++)
            {
                int key = Convert.ToInt32(dsMain.Tables[0].Rows[i]["sys_id"]);
                if (dicUserList.ContainsKey(key))
                {
                    dsMain.Tables[0].Rows[i]["UserName"] = dicUserList[key];
                }
            }
            #endregion

            dgvTask.DataSource = dsMain.Tables[0];
        }

        private bool isStarted = false;
        private void btn_StartTask_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;
            btn_StartTask.Text = isStarted ? "停止任务(&T)" : "启动任务(&S)";
            lb_TaskStatus.Text = isStarted ? "所有任务已启动！" : "所有任务已停止！";
            timer1.Enabled = isStarted;
        }

    }
}
