using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:EtermRT
	/// </summary>
	public partial class EtermRT:IEtermRT
	{
		public EtermRT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "EtermRT"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from EtermRT");
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
		public int Add(Sanben.Model.EtermRT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into EtermRT(");
			strSql.Append("EtermRTuser,EtermRTpwd,airline,effect,userID)");
			strSql.Append(" values (");
			strSql.Append("@EtermRTuser,@EtermRTpwd,@airline,@effect,@userID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EtermRTuser", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTpwd", SqlDbType.VarChar,50),
					new SqlParameter("@airline", SqlDbType.VarChar,50),
					new SqlParameter("@effect", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.Int,4)};
			parameters[0].Value = model.EtermRTuser;
			parameters[1].Value = model.EtermRTpwd;
			parameters[2].Value = model.airline;
			parameters[3].Value = model.effect;
			parameters[4].Value = model.userID;

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
		public bool Update(Sanben.Model.EtermRT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update EtermRT set ");
			strSql.Append("EtermRTuser=@EtermRTuser,");
			strSql.Append("EtermRTpwd=@EtermRTpwd,");
			strSql.Append("airline=@airline,");
			strSql.Append("effect=@effect,");
			strSql.Append("userID=@userID");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@EtermRTuser", SqlDbType.VarChar,50),
					new SqlParameter("@EtermRTpwd", SqlDbType.VarChar,50),
					new SqlParameter("@airline", SqlDbType.VarChar,50),
					new SqlParameter("@effect", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.EtermRTuser;
			parameters[1].Value = model.EtermRTpwd;
			parameters[2].Value = model.airline;
			parameters[3].Value = model.effect;
			parameters[4].Value = model.userID;
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
			strSql.Append("delete from EtermRT ");
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
			strSql.Append("delete from EtermRT ");
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
		public Sanben.Model.EtermRT GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,EtermRTuser,EtermRTpwd,airline,effect,userID from EtermRT ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.EtermRT model=new Sanben.Model.EtermRT();
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
		public Sanben.Model.EtermRT DataRowToModel(DataRow row)
		{
			Sanben.Model.EtermRT model=new Sanben.Model.EtermRT();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["EtermRTuser"]!=null)
				{
					model.EtermRTuser=row["EtermRTuser"].ToString();
				}
				if(row["EtermRTpwd"]!=null)
				{
					model.EtermRTpwd=row["EtermRTpwd"].ToString();
				}
				if(row["airline"]!=null)
				{
					model.airline=row["airline"].ToString();
				}
				if(row["effect"]!=null)
				{
					model.effect=row["effect"].ToString();
				}
				if(row["userID"]!=null && row["userID"].ToString()!="")
				{
					model.userID=int.Parse(row["userID"].ToString());
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
			strSql.Append("select id,EtermRTuser,EtermRTpwd,airline,effect,userID ");
			strSql.Append(" FROM EtermRT ");
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
			strSql.Append(" id,EtermRTuser,EtermRTpwd,airline,effect,userID ");
			strSql.Append(" FROM EtermRT ");
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
			strSql.Append("select count(1) FROM EtermRT ");
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
			strSql.Append(")AS Row, T.*  from EtermRT T ");
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
			parameters[0].Value = "EtermRT";
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

