using System.Data;

namespace PolicyAutoUploadLib.Policy
{
    /// <summary>
    /// 政策来源接口
    /// </summary>
    public interface IPolicySources
    {
        /// <summary>
        /// 过滤
        /// </summary>
        /// <param name="strWhere">条件查询SQL语句</param>
        ///// <param name="ds">保存查询结果的数据集</param>
        ///// <returns>返回保存查询结果的数据集</returns>
        //DataSet Filler(string strWhere,DataSet ds);
        DataSet Filler();
        /// <summary>
        /// 修改返点
        /// </summary>
        /// <param name="ds">传入过滤后的数据集对象</param>
        /// <returns>修改数据集中的返点数的数据集对象</returns>
        DataSet DiscountsModefy(DataSet ds);
        /// <summary>
        /// 退改签修改
        /// </summary>
        /// <param name="ds">传入过滤后并修改返点后的数据集对象</param>
        /// <returns>修改退改签数据集对象</returns>
        DataSet GeiQian(DataSet ds);
        /// <summary>
        /// 仓位说明
        /// </summary>
        /// <param name="ds">传入过滤后并修改返点和退改签后的数据集对象</param>
        /// <returns>修改了仓位说明的数据集对象</returns>
        DataSet CabinDetail( DataSet ds);
    }
}
