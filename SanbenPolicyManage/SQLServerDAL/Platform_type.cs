using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Platform_type
	/// </summary>
	public partial class Platform_type:IPlatform_type
	{
		public Platform_type()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Platform_type"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Platform_type");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sanben.Model.Platform_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Platform_type(");
			strSql.Append("id,website_name,platform_interface,website_platfrom,platform_name,platform_id)");
			strSql.Append(" values (");
			strSql.Append("@id,@website_name,@platform_interface,@website_platfrom,@platform_name,@platform_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@website_name", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_interface", SqlDbType.NVarChar,250),
					new SqlParameter("@website_platfrom", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_name", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_id", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.website_name;
			parameters[2].Value = model.platform_interface;
			parameters[3].Value = model.website_platfrom;
			parameters[4].Value = model.platform_name;
			parameters[5].Value = model.platform_id;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Sanben.Model.Platform_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Platform_type set ");
			strSql.Append("website_name=@website_name,");
			strSql.Append("platform_interface=@platform_interface,");
			strSql.Append("website_platfrom=@website_platfrom,");
			strSql.Append("platform_name=@platform_name,");
			strSql.Append("platform_id=@platform_id");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@website_name", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_interface", SqlDbType.NVarChar,250),
					new SqlParameter("@website_platfrom", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_name", SqlDbType.NVarChar,250),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.website_name;
			parameters[1].Value = model.platform_interface;
			parameters[2].Value = model.website_platfrom;
			parameters[3].Value = model.platform_name;
			parameters[4].Value = model.platform_id;
			parameters[5].Value = model.id;

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
			strSql.Append("delete from Platform_type ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
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
			strSql.Append("delete from Platform_type ");
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
		public Sanben.Model.Platform_type GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,website_name,platform_interface,website_platfrom,platform_name,platform_id from Platform_type ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			Sanben.Model.Platform_type model=new Sanben.Model.Platform_type();
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
		public Sanben.Model.Platform_type DataRowToModel(DataRow row)
		{
			Sanben.Model.Platform_type model=new Sanben.Model.Platform_type();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["website_name"]!=null)
				{
					model.website_name=row["website_name"].ToString();
				}
				if(row["platform_interface"]!=null)
				{
					model.platform_interface=row["platform_interface"].ToString();
				}
				if(row["website_platfrom"]!=null)
				{
					model.website_platfrom=row["website_platfrom"].ToString();
				}
				if(row["platform_name"]!=null)
				{
					model.platform_name=row["platform_name"].ToString();
				}
				if(row["platform_id"]!=null && row["platform_id"].ToString()!="")
				{
					model.platform_id=int.Parse(row["platform_id"].ToString());
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
			strSql.Append("select id,website_name,platform_interface,website_platfrom,platform_name,platform_id ");
			strSql.Append(" FROM Platform_type ");
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
			strSql.Append(" id,website_name,platform_interface,website_platfrom,platform_name,platform_id ");
			strSql.Append(" FROM Platform_type ");
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
			strSql.Append("select count(1) FROM Platform_type ");
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
			strSql.Append(")AS Row, T.*  from Platform_type T ");
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
			parameters[0].Value = "Platform_type";
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

