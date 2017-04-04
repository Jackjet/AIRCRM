using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanben.BLL;

namespace PolicyAutoUploadLib.Policy
{
    public class JinRiPolicy : IPolicySources,IDisposable
    {
        private double lRabete = 1.0;
        private double hRabete = 20.0;
        private double rPoint = 0.0;
        private string strWhere = "";
        DataSet jinri = null;
        private DataSet configSet = null;
        private int _sysid = 0;
        public JinRiPolicy()
        {
            _sysid = 482;
            strWhere = @" Company in (select navigation_company from Policy_filter) and AirLine in (select air_line from Policy_filter)";
            strWhere += string.Format(@" and Discounts between {0} and {1}", lRabete, hRabete);
        }


        public DataSet Filler()
        {
            GetRateList _bll = new GetRateList();
            jinri = _bll.GetList(strWhere);
            return  jinri;
        }

        public DataSet DiscountsModefy(DataSet ds)
        {
            //自定义留点
            rebate _rebateBll = new rebate();//返点
            DataSet rDataSet = _rebateBll.GetList(string.Format("sys_id = {0}", _sysid));
            int rebateCount = rDataSet.Tables[0].Rows.Count;
            if (ds!=null)
            {
                int counts = ds.Tables[0].Rows.Count;
                double k = 0.0;
                if (counts <= 0)
                    return new DataSet();
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
            
            return ds;
        }

        public DataSet GeiQian(DataSet ds)
        {
            Sanben.BLL.gaiqian_retirement _gaiqianBll = new gaiqian_retirement();//改签
            DataSet gqSet = _gaiqianBll.GetList(string.Format("sys_id = {0}", _sysid));
            int gqCount = gqSet.Tables[0].Rows.Count;

            int counts = ds.Tables[0].Rows.Count;
            if (counts <= 0)
               return new DataSet();
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
            return new DataSet();
        }

        public DataSet CabinDetail(DataSet ds)
        {
            Sanben.BLL.cabin_description _cabinDescriptionBll = new cabin_description();//仓位说明 
            DataSet cabinSet = _cabinDescriptionBll.GetList(string.Format("sys_id = {0}", _sysid));
            int cabinCount = cabinSet.Tables[0].Rows.Count;

            int counts = ds.Tables[0].Rows.Count;
            if (counts <= 0)
                return new DataSet();
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
            return new DataSet();
        }

        // Flag: Has Dispose already been called?
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);           
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

    }
}
