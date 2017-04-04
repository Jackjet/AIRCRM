using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DeletePolicy
	/// </summary>
	public partial class DeletePolicy:IDeletePolicy
	{
		public DeletePolicy()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "DeletePolicy"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DeletePolicy");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sanben.Model.DeletePolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DeletePolicy(");
			strSql.Append("flightcode,policyCode,dpt,arr,cabin,startdate,enddate,sys_id)");
			strSql.Append(" values (");
			strSql.Append("@flightcode,@policyCode,@dpt,@arr,@cabin,@startdate,@enddate,@sys_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@flightcode", SqlDbType.VarChar,50),
					new SqlParameter("@policyCode", SqlDbType.VarChar,50),
					new SqlParameter("@dpt", SqlDbType.Char,3),
					new SqlParameter("@arr", SqlDbType.Char,3),
					new SqlParameter("@cabin", SqlDbType.Char,1),
					new SqlParameter("@startdate", SqlDbType.DateTime),
					new SqlParameter("@enddate", SqlDbType.DateTime),
					new SqlParameter("@sys_id", SqlDbType.Int,4)};
			parameters[0].Value = model.flightcode;
			parameters[1].Value = model.policyCode;
			parameters[2].Value = model.dpt;
			parameters[3].Value = model.arr;
			parameters[4].Value = model.cabin;
			parameters[5].Value = model.startdate;
			parameters[6].Value = model.enddate;
			parameters[7].Value = model.sys_id;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.DeletePolicy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DeletePolicy set ");
			strSql.Append("flightcode=@flightcode,");
			strSql.Append("policyCode=@policyCode,");
			strSql.Append("dpt=@dpt,");
			strSql.Append("arr=@arr,");
			strSql.Append("cabin=@cabin,");
			strSql.Append("startdate=@startdate,");
			strSql.Append("enddate=@enddate,");
			strSql.Append("sys_id=@sys_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@flightcode", SqlDbType.VarChar,50),
					new SqlParameter("@policyCode", SqlDbType.VarChar,50),
					new SqlParameter("@dpt", SqlDbType.Char,3),
					new SqlParameter("@arr", SqlDbType.Char,3),
					new SqlParameter("@cabin", SqlDbType.Char,1),
					new SqlParameter("@startdate", SqlDbType.DateTime),
					new SqlParameter("@enddate", SqlDbType.DateTime),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.flightcode;
			parameters[1].Value = model.policyCode;
			parameters[2].Value = model.dpt;
			parameters[3].Value = model.arr;
			parameters[4].Value = model.cabin;
			parameters[5].Value = model.startdate;
			parameters[6].Value = model.enddate;
			parameters[7].Value = model.sys_id;
			parameters[8].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeletePolicy ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DeletePolicy ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.DeletePolicy GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,flightcode,policyCode,dpt,arr,cabin,startdate,enddate,sys_id from DeletePolicy ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.DeletePolicy model=new Sanben.Model.DeletePolicy();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sanben.Model.DeletePolicy DataRowToModel(DataRow row)
		{
			Sanben.Model.DeletePolicy model=new Sanben.Model.DeletePolicy();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["flightcode"]!=null)
				{
					model.flightcode=row["flightcode"].ToString();
				}
				if(row["policyCode"]!=null)
				{
					model.policyCode=row["policyCode"].ToString();
				}
				if(row["dpt"]!=null)
				{
					model.dpt=row["dpt"].ToString();
				}
				if(row["arr"]!=null)
				{
					model.arr=row["arr"].ToString();
				}
				if(row["cabin"]!=null)
				{
					model.cabin=row["cabin"].ToString();
				}
				if(row["startdate"]!=null && row["startdate"].ToString()!="")
				{
					model.startdate=DateTime.Parse(row["startdate"].ToString());
				}
				if(row["enddate"]!=null && row["enddate"].ToString()!="")
				{
					model.enddate=DateTime.Parse(row["enddate"].ToString());
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,flightcode,policyCode,dpt,arr,cabin,startdate,enddate,sys_id ");
			strSql.Append(" FROM DeletePolicy ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,flightcode,policyCode,dpt,arr,cabin,startdate,enddate,sys_id ");
			strSql.Append(" FROM DeletePolicy ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DeletePolicy ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from DeletePolicy T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DeletePolicy";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

