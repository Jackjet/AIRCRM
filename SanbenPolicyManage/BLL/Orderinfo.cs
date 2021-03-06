﻿using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Sanben.Model;
using Sanben.DALFactory;
using Sanben.IDAL;
namespace Sanben.BLL
{
	/// <summary>
	/// Orderinfo
	/// </summary>
	public partial class Orderinfo
	{
		private readonly IOrderinfo dal=DataAccess.CreateOrderinfo();
		public Orderinfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pk_id)
		{
			return dal.Exists(pk_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Sanben.Model.Orderinfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.Orderinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int pk_id)
		{
			
			return dal.Delete(pk_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string pk_idlist )
		{
			return dal.DeleteList(pk_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.Orderinfo GetModel(int pk_id)
		{
			
			return dal.GetModel(pk_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Sanben.Model.Orderinfo GetModelByCache(int pk_id)
		{
			
			string CacheKey = "OrderinfoModel-" + pk_id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(pk_id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Sanben.Model.Orderinfo)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Sanben.Model.Orderinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Sanben.Model.Orderinfo> DataTableToList(DataTable dt)
		{
			List<Sanben.Model.Orderinfo> modelList = new List<Sanben.Model.Orderinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Sanben.Model.Orderinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

