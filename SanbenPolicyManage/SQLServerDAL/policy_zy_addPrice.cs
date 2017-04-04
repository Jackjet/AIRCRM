using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:policy_zy_addPrice
	/// </summary>
	public partial class policy_zy_addPrice:Ipolicy_zy_addPrice
	{
		public policy_zy_addPrice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "policy_zy_addPrice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from policy_zy_addPrice");
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
		public int Add(Sanben.Model.policy_zy_addPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into policy_zy_addPrice(");
			strSql.Append("navigation_company,air_line,application_space,jisuanbase,convertType,addValue,platform_id,sys_id)");
			strSql.Append(" values (");
			strSql.Append("@navigation_company,@air_line,@application_space,@jisuanbase,@convertType,@addValue,@platform_id,@sys_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,50),
					new SqlParameter("@application_space", SqlDbType.VarChar,50),
					new SqlParameter("@jisuanbase", SqlDbType.Bit,1),
					new SqlParameter("@convertType", SqlDbType.VarChar,50),
					new SqlParameter("@addValue", SqlDbType.Float,8),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.application_space;
			parameters[3].Value = model.jisuanbase;
			parameters[4].Value = model.convertType;
			parameters[5].Value = model.addValue;
			parameters[6].Value = model.platform_id;
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
		public bool Update(Sanben.Model.policy_zy_addPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update policy_zy_addPrice set ");
			strSql.Append("navigation_company=@navigation_company,");
			strSql.Append("air_line=@air_line,");
			strSql.Append("application_space=@application_space,");
			strSql.Append("jisuanbase=@jisuanbase,");
			strSql.Append("convertType=@convertType,");
			strSql.Append("addValue=@addValue,");
			strSql.Append("platform_id=@platform_id,");
			strSql.Append("sys_id=@sys_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@navigation_company", SqlDbType.VarChar,50),
					new SqlParameter("@air_line", SqlDbType.VarChar,50),
					new SqlParameter("@application_space", SqlDbType.VarChar,50),
					new SqlParameter("@jisuanbase", SqlDbType.Bit,1),
					new SqlParameter("@convertType", SqlDbType.VarChar,50),
					new SqlParameter("@addValue", SqlDbType.Float,8),
					new SqlParameter("@platform_id", SqlDbType.Int,4),
					new SqlParameter("@sys_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.navigation_company;
			parameters[1].Value = model.air_line;
			parameters[2].Value = model.application_space;
			parameters[3].Value = model.jisuanbase;
			parameters[4].Value = model.convertType;
			parameters[5].Value = model.addValue;
			parameters[6].Value = model.platform_id;
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
			strSql.Append("delete from policy_zy_addPrice ");
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
			strSql.Append("delete from policy_zy_addPrice ");
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
		public Sanben.Model.policy_zy_addPrice GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,navigation_company,air_line,application_space,jisuanbase,convertType,addValue,platform_id,sys_id from policy_zy_addPrice ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.policy_zy_addPrice model=new Sanben.Model.policy_zy_addPrice();
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
		public Sanben.Model.policy_zy_addPrice DataRowToModel(DataRow row)
		{
			Sanben.Model.policy_zy_addPrice model=new Sanben.Model.policy_zy_addPrice();
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
				if(row["application_space"]!=null)
				{
					model.application_space=row["application_space"].ToString();
				}
				if(row["jisuanbase"]!=null && row["jisuanbase"].ToString()!="")
				{
					if((row["jisuanbase"].ToString()=="1")||(row["jisuanbase"].ToString().ToLower()=="true"))
					{
						model.jisuanbase=true;
					}
					else
					{
						model.jisuanbase=false;
					}
				}
				if(row["convertType"]!=null)
				{
					model.convertType=row["convertType"].ToString();
				}
				if(row["addValue"]!=null && row["addValue"].ToString()!="")
				{
					model.addValue=decimal.Parse(row["addValue"].ToString());
				}
				if(row["platform_id"]!=null && row["platform_id"].ToString()!="")
				{
					model.platform_id=int.Parse(row["platform_id"].ToString());
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
			strSql.Append("select id,navigation_company,air_line,application_space,jisuanbase,convertType,addValue,platform_id,sys_id ");
			strSql.Append(" FROM policy_zy_addPrice ");
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
			strSql.Append(" id,navigation_company,air_line,application_space,jisuanbase,convertType,addValue,platform_id,sys_id ");
			strSql.Append(" FROM policy_zy_addPrice ");
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
			strSql.Append("select count(1) FROM policy_zy_addPrice ");
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
			strSql.Append(")AS Row, T.*  from policy_zy_addPrice T ");
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
			parameters[0].Value = "policy_zy_addPrice";
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

