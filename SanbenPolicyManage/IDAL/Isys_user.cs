﻿using System;
using System.Data;
namespace Sanben.IDAL
{
	/// <summary>
	/// 接口层sys_user
	/// </summary>
	public interface Isys_user
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string username,int id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Sanben.Model.sys_user model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(Sanben.Model.sys_user model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int id);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string username,int id);
		bool DeleteList(string idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Sanben.Model.sys_user GetModel(int id);
		Sanben.Model.sys_user DataRowToModel(DataRow row);
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