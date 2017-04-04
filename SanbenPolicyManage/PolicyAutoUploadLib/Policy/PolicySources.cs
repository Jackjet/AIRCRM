using System;
using System.Data;
using System.Reflection;
using System.Runtime.Remoting;
using model = Sanben.Model;
namespace PolicyAutoUploadLib.Policy
{
    /// <summary>
    /// 政策来源过滤与修改
    /// </summary>
    public class PolicySources : IPolicySources
    {
      

        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="strWhere">条件查询SQL语句</param>
        /// <param name="ds">保存查询结果的数据集</param>
        /// <returns>返回保存查询结果的数据集</returns>
        public DataSet Filler(string strWhere, DataSet ds)
        {
            try
            {
                ObjectHandle handle = Activator.CreateInstance("Sanben.BLL", "Sanben.BLL.GetRateList");
                object p = handle.Unwrap();
                Type t = p.GetType();
                MethodInfo method = t.GetMethod("GetList", new Type[] { typeof(string) });
                ds = (DataSet)method.Invoke(p, new object[]{strWhere});
                return ds;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
            
        }
        /// <summary>
        /// 修改返点
        /// </summary>
        /// <param name="ds">传入过滤后的数据集对象</param>
        /// <returns>修改数据集中的返点数的数据集对象</returns>
        public DataSet DiscountsModefy(DataSet ds)
        {
            return new DataSet();
        }
        /// <summary>
        /// 退改签修改
        /// </summary>
        /// <param name="ds">传入过滤后并修改返点后的数据集对象</param>
        /// <returns>修改退改签数据集对象</returns>
        public DataSet GeiQian(DataSet ds)
        {
            return new DataSet();
        }
        /// <summary>
        /// 仓位说明
        /// </summary>
        /// <param name="ds">传入过滤后并修改返点和退改签后的数据集对象</param>
        /// <returns>修改了仓位说明的数据集对象</returns>
        public DataSet CabinDetail(DataSet ds)
        {
            return new DataSet();
        }

        public DataSet Filler()
        {
            return  new DataSet();
        }
    }
}
