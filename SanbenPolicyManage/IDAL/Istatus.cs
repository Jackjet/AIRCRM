﻿using System;
using System.Data;
namespace Sanben.IDAL
{
	/// <summary>
	/// 接口层status
	/// </summary>
	public interface Istatus
	{
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Sanben.Model.status model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Sanben.Model.status model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int ID);
		bool DeleteList(string IDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Sanben.Model.status GetModel(int ID);
		Sanben.Model.status DataRowToModel(DataRow row);
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
