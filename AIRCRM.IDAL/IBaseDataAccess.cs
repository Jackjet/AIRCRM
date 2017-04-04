
using System;
using System.Collections.Generic;

namespace AIRCRM.IDAL
{
    /// <summary>
    /// 数据访问基接口
    /// </summary>
    public interface IBaseDataAccess<T> where T : class
    {
        /// <summary>
        ///添加一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int Add(T model);
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        bool Delete(Guid guid);
        /// <summary>
        /// 更新一条记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Update(T model);
        /// <summary>
        /// 查询一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Select(int id);
        /// <summary>
        /// 查询一条记录
        /// </summary>
        /// <param name="guid">记录的GUID</param>
        /// <returns>GUID对应的记录</returns>
        T Select(Guid guid);
        /// <summary>
        ///查询所有记录
        /// </summary>
        /// <returns></returns>
        List<T> SelectAll();
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="idList">ID清单</param>
        /// <returns>ID对应数据集合</returns>
        List<T> GetList(string idList);
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="guidList">GUID清单</param>
        /// <returns>GUID对应数据集合</returns>
        List<T> GetList(List<Guid> guidList);
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <param name="PageSize">页面大小</param>
        /// <param name="PageIndex">当前页索引</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns>分页数据集体</returns>
        List<T> GetPageList(int pageSize, int pageIndex, string strWhere);
    }
}
