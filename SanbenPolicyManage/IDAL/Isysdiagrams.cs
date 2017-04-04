using System;
using System.Data;
namespace Sanben.IDAL
{
	/// <summary>
	/// 接口层1
	/// </summary>
	public interface Isysdiagrams
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string name,int principal_id,int diagram_id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Sanben.Model.sysdiagrams model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Sanben.Model.sysdiagrams model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int diagram_id);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string name,int principal_id,int diagram_id);
		bool DeleteList(string diagram_idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Sanben.Model.sysdiagrams GetModel(int diagram_id);
		Sanben.Model.sysdiagrams DataRowToModel(DataRow row);
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
