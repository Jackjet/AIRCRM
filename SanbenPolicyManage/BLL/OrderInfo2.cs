using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Sanben.Model;
using Sanben.DALFactory;
using Sanben.IDAL;
namespace Sanben.BLL
{
	/// <summary>
	/// OrderInfo2
	/// </summary>
	public partial class OrderInfo2
	{
		private readonly IOrderInfo2 dal=DataAccess.CreateOrderInfo2();
		public OrderInfo2()
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
		public bool Exists(string orderNo,int pk_id)
		{
			return dal.Exists(orderNo,pk_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Sanben.Model.OrderInfo2 model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.OrderInfo2 model)
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
		public bool Delete(string orderNo,int pk_id)
		{
			
			return dal.Delete(orderNo,pk_id);
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
		public Sanben.Model.OrderInfo2 GetModel(int pk_id)
		{
			
			return dal.GetModel(pk_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Sanben.Model.OrderInfo2 GetModelByCache(int pk_id)
		{
			
			string CacheKey = "OrderInfo2Model-" + pk_id;
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
			return (Sanben.Model.OrderInfo2)objModel;
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
		public List<Sanben.Model.OrderInfo2> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Sanben.Model.OrderInfo2> DataTableToList(DataTable dt)
		{
			List<Sanben.Model.OrderInfo2> modelList = new List<Sanben.Model.OrderInfo2>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Sanben.Model.OrderInfo2 model;
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

