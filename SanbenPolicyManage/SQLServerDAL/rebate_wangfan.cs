using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:rebate_wangfan
	/// </summary>
	public partial class rebate_wangfan:Irebate_wangfan
	{
		public rebate_wangfan()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "rebate_wangfan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from rebate_wangfan");
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
		public int Add(Sanben.Model.rebate_wangfan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into rebate_wangfan(");
			strSql.Append("navigation_company,air_line,qucheng_space,huicheng_space,rabate_number,leave_money,ticket_price_lowest,ticket_price_highest,rabate_class,sys_id,platform_type_id)");
			strSql.Append(" values (");
			strSql.Append("@navigation_company,@air_line,@qucheng_space,@huicheng_space,@rabate_number,@leave_money,@ticket_price_lowest,@ticket_price_highest,@rabate_class,@sys_id,@platform_type_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,10),
					new SqlParameter("@qucheng_space", SqlDbType.VarChar,255),
					new SqlParameter("@huicheng_space", SqlDbType.VarChar,255),
					new SqlParameter("@rabate_number", SqlDbType.Float,8),
					new SqlParameter("@leave_money", SqlDbType.Float,8),
					new SqlParameter("@ticket_price_lowest", SqlDbType.Int,4),
					new SqlParameter("@ticket_price_highest", SqlDbType.Int,4),
					new SqlParameter("@rabate_class", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.qucheng_space;
			parameters[3].Value = model.huicheng_space;
			parameters[4].Value = model.rabate_number;
			parameters[5].Value = model.leave_money;
			parameters[6].Value = model.ticket_price_lowest;
			parameters[7].Value = model.ticket_price_highest;
			parameters[8].Value = model.rabate_class;
			parameters[9].Value = model.sys_id;
			parameters[10].Value = model.platform_type_id;

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
		public bool Update(Sanben.Model.rebate_wangfan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update rebate_wangfan set ");
			strSql.Append("navigation_company=@navigation_company,");
			strSql.Append("air_line=@air_line,");
			strSql.Append("qucheng_space=@qucheng_space,");
			strSql.Append("huicheng_space=@huicheng_space,");
			strSql.Append("rabate_number=@rabate_number,");
			strSql.Append("leave_money=@leave_money,");
			strSql.Append("ticket_price_lowest=@ticket_price_lowest,");
			strSql.Append("ticket_price_highest=@ticket_price_highest,");
			strSql.Append("rabate_class=@rabate_class,");
			strSql.Append("sys_id=@sys_id,");
			strSql.Append("platform_type_id=@platform_type_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,10),
					new SqlParameter("@qucheng_space", SqlDbType.VarChar,255),
					new SqlParameter("@huicheng_space", SqlDbType.VarChar,255),
					new SqlParameter("@rabate_number", SqlDbType.Float,8),
					new SqlParameter("@leave_money", SqlDbType.Float,8),
					new SqlParameter("@ticket_price_lowest", SqlDbType.Int,4),
					new SqlParameter("@ticket_price_highest", SqlDbType.Int,4),
					new SqlParameter("@rabate_class", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@platform_type_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.qucheng_space;
			parameters[3].Value = model.huicheng_space;
			parameters[4].Value = model.rabate_number;
			parameters[5].Value = model.leave_money;
			parameters[6].Value = model.ticket_price_lowest;
			parameters[7].Value = model.ticket_price_highest;
			parameters[8].Value = model.rabate_class;
			parameters[9].Value = model.sys_id;
			parameters[10].Value = model.platform_type_id;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from rebate_wangfan ");
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
			strSql.Append("delete from rebate_wangfan ");
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
		public Sanben.Model.rebate_wangfan GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,navigation_company,air_line,qucheng_space,huicheng_space,rabate_number,leave_money,ticket_price_lowest,ticket_price_highest,rabate_class,sys_id,platform_type_id from rebate_wangfan ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.rebate_wangfan model=new Sanben.Model.rebate_wangfan();
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
		public Sanben.Model.rebate_wangfan DataRowToModel(DataRow row)
		{
			Sanben.Model.rebate_wangfan model=new Sanben.Model.rebate_wangfan();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["navigation_company"]!=null)
				{
					model.navigation_company=row["navigation_company"].ToString();
				}
				if(row["air_line"]!=null)
				{
					model.air_line=row["air_line"].ToString();
				}
				if(row["qucheng_space"]!=null)
				{
					model.qucheng_space=row["qucheng_space"].ToString();
				}
				if(row["huicheng_space"]!=null)
				{
					model.huicheng_space=row["huicheng_space"].ToString();
				}
				if(row["rabate_number"]!=null && row["rabate_number"].ToString()!="")
				{
					model.rabate_number=decimal.Parse(row["rabate_number"].ToString());
				}
				if(row["leave_money"]!=null && row["leave_money"].ToString()!="")
				{
					model.leave_money=decimal.Parse(row["leave_money"].ToString());
				}
				if(row["ticket_price_lowest"]!=null && row["ticket_price_lowest"].ToString()!="")
				{
					model.ticket_price_lowest=int.Parse(row["ticket_price_lowest"].ToString());
				}
				if(row["ticket_price_highest"]!=null && row["ticket_price_highest"].ToString()!="")
				{
					model.ticket_price_highest=int.Parse(row["ticket_price_highest"].ToString());
				}
				if(row["rabate_class"]!=null && row["rabate_class"].ToString()!="")
				{
					model.rabate_class=int.Parse(row["rabate_class"].ToString());
				}
				if(row["sys_id"]!=null && row["sys_id"].ToString()!="")
				{
					model.sys_id=int.Parse(row["sys_id"].ToString());
				}
				if(row["platform_type_id"]!=null && row["platform_type_id"].ToString()!="")
				{
					model.platform_type_id=int.Parse(row["platform_type_id"].ToString());
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
			strSql.Append("select id,navigation_company,air_line,qucheng_space,huicheng_space,rabate_number,leave_money,ticket_price_lowest,ticket_price_highest,rabate_class,sys_id,platform_type_id ");
			strSql.Append(" FROM rebate_wangfan ");
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
			strSql.Append(" id,navigation_company,air_line,qucheng_space,huicheng_space,rabate_number,leave_money,ticket_price_lowest,ticket_price_highest,rabate_class,sys_id,platform_type_id ");
			strSql.Append(" FROM rebate_wangfan ");
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
			strSql.Append("select count(1) FROM rebate_wangfan ");
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
			strSql.Append(")AS Row, T.*  from rebate_wangfan T ");
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
			parameters[0].Value = "rebate_wangfan";
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

