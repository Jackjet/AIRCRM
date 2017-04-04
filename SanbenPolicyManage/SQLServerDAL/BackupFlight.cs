using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BackupFlight
	/// </summary>
	public partial class BackupFlight:IBackupFlight
	{
		public BackupFlight()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "BackupFlight"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BackupFlight");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Sanben.Model.BackupFlight model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BackupFlight(");
			strSql.Append("id,code,cabin,ccabin,dep,arr,depDay,depTime,arrTime,realCode,o_id)");
			strSql.Append(" values (");
			strSql.Append("@id,@code,@cabin,@ccabin,@dep,@arr,@depDay,@depTime,@arrTime,@realCode,@o_id)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@code", SqlDbType.VarChar,50),
					new SqlParameter("@cabin", SqlDbType.VarChar,50),
					new SqlParameter("@ccabin", SqlDbType.VarChar,50),
					new SqlParameter("@dep", SqlDbType.VarChar,50),
					new SqlParameter("@arr", SqlDbType.VarChar,50),
					new SqlParameter("@depDay", SqlDbType.VarChar,50),
					new SqlParameter("@depTime", SqlDbType.VarChar,50),
					new SqlParameter("@arrTime", SqlDbType.VarChar,50),
					new SqlParameter("@realCode", SqlDbType.VarChar,100),
					new SqlParameter("@o_id", SqlDbType.Int,4)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.code;
			parameters[2].Value = model.cabin;
			parameters[3].Value = model.ccabin;
			parameters[4].Value = model.dep;
			parameters[5].Value = model.arr;
			parameters[6].Value = model.depDay;
			parameters[7].Value = model.depTime;
			parameters[8].Value = model.arrTime;
			parameters[9].Value = model.realCode;
			parameters[10].Value = model.o_id;

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
		public bool Update(Sanben.Model.BackupFlight model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BackupFlight set ");
			strSql.Append("code=@code,");
			strSql.Append("cabin=@cabin,");
			strSql.Append("ccabin=@ccabin,");
			strSql.Append("dep=@dep,");
			strSql.Append("arr=@arr,");
			strSql.Append("depDay=@depDay,");
			strSql.Append("depTime=@depTime,");
			strSql.Append("arrTime=@arrTime,");
			strSql.Append("realCode=@realCode,");
			strSql.Append("o_id=@o_id");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@code", SqlDbType.VarChar,50),
					new SqlParameter("@cabin", SqlDbType.VarChar,50),
					new SqlParameter("@ccabin", SqlDbType.VarChar,50),
					new SqlParameter("@dep", SqlDbType.VarChar,50),
					new SqlParameter("@arr", SqlDbType.VarChar,50),
					new SqlParameter("@depDay", SqlDbType.VarChar,50),
					new SqlParameter("@depTime", SqlDbType.VarChar,50),
					new SqlParameter("@arrTime", SqlDbType.VarChar,50),
					new SqlParameter("@realCode", SqlDbType.VarChar,100),
					new SqlParameter("@o_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.code;
			parameters[1].Value = model.cabin;
			parameters[2].Value = model.ccabin;
			parameters[3].Value = model.dep;
			parameters[4].Value = model.arr;
			parameters[5].Value = model.depDay;
			parameters[6].Value = model.depTime;
			parameters[7].Value = model.arrTime;
			parameters[8].Value = model.realCode;
			parameters[9].Value = model.o_id;
			parameters[10].Value = model.id;

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
			strSql.Append("delete from BackupFlight ");
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
			strSql.Append("delete from BackupFlight ");
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
		public Sanben.Model.BackupFlight GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,code,cabin,ccabin,dep,arr,depDay,depTime,arrTime,realCode,o_id from BackupFlight ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)			};
			parameters[0].Value = id;

			Sanben.Model.BackupFlight model=new Sanben.Model.BackupFlight();
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
		public Sanben.Model.BackupFlight DataRowToModel(DataRow row)
		{
			Sanben.Model.BackupFlight model=new Sanben.Model.BackupFlight();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["code"]!=null)
				{
					model.code=row["code"].ToString();
				}
				if(row["cabin"]!=null)
				{
					model.cabin=row["cabin"].ToString();
				}
				if(row["ccabin"]!=null)
				{
					model.ccabin=row["ccabin"].ToString();
				}
				if(row["dep"]!=null)
				{
					model.dep=row["dep"].ToString();
				}
				if(row["arr"]!=null)
				{
					model.arr=row["arr"].ToString();
				}
				if(row["depDay"]!=null)
				{
					model.depDay=row["depDay"].ToString();
				}
				if(row["depTime"]!=null)
				{
					model.depTime=row["depTime"].ToString();
				}
				if(row["arrTime"]!=null)
				{
					model.arrTime=row["arrTime"].ToString();
				}
				if(row["realCode"]!=null)
				{
					model.realCode=row["realCode"].ToString();
				}
				if(row["o_id"]!=null && row["o_id"].ToString()!="")
				{
					model.o_id=int.Parse(row["o_id"].ToString());
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
			strSql.Append("select id,code,cabin,ccabin,dep,arr,depDay,depTime,arrTime,realCode,o_id ");
			strSql.Append(" FROM BackupFlight ");
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
			strSql.Append(" id,code,cabin,ccabin,dep,arr,depDay,depTime,arrTime,realCode,o_id ");
			strSql.Append(" FROM BackupFlight ");
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
			strSql.Append("select count(1) FROM BackupFlight ");
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
			strSql.Append(")AS Row, T.*  from BackupFlight T ");
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
			parameters[0].Value = "BackupFlight";
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

