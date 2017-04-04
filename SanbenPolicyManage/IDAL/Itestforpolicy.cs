using System;
using System.Data;
namespace Sanben.IDAL
{
	/// <summary>
	/// 接口层1
	/// </summary>
	public interface Itestforpolicy
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(Sanben.Model.testforpolicy model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Sanben.Model.testforpolicy model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete();
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Sanben.Model.testforpolicy GetModel();
		Sanben.Model.testforpolicy DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
