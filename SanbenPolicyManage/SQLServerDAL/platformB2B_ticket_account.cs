using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Sanben.IDAL;
using Maticsoft.DBUtility;//Please add references
namespace Sanben.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:platformB2B_ticket_account
	/// </summary>
	public partial class platformB2B_ticket_account:IplatformB2B_ticket_account
	{
		public platformB2B_ticket_account()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "platformB2B_ticket_account"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from platformB2B_ticket_account");
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
		public int Add(Sanben.Model.platformB2B_ticket_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into platformB2B_ticket_account(");
			strSql.Append("Maccount,Caccount,paysrc,paytype,sysUserId,platformName_id)");
			strSql.Append(" values (");
			strSql.Append("@Maccount,@Caccount,@paysrc,@paytype,@sysUserId,@platformName_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Maccount", SqlDbType.VarChar,50),
					new SqlParameter("@Caccount", SqlDbType.VarChar,50),
					new SqlParameter("@paysrc", SqlDbType.VarChar,50),
					new SqlParameter("@paytype", SqlDbType.VarChar,50),
					new SqlParameter("@sysUserId", SqlDbType.Int,4),
					new SqlParameter("@platformName_id", SqlDbType.Int,4)};
			parameters[0].Value = model.Maccount;
			parameters[1].Value = model.Caccount;
			parameters[2].Value = model.paysrc;
			parameters[3].Value = model.paytype;
			parameters[4].Value = model.sysUserId;
			parameters[5].Value = model.platformName_id;

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
		public bool Update(Sanben.Model.platformB2B_ticket_account model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update platformB2B_ticket_account set ");
			strSql.Append("Maccount=@Maccount,");
			strSql.Append("Caccount=@Caccount,");
			strSql.Append("paysrc=@paysrc,");
			strSql.Append("paytype=@paytype,");
			strSql.Append("sysUserId=@sysUserId,");
			strSql.Append("platformName_id=@platformName_id");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@Maccount", SqlDbType.VarChar,50),
					new SqlParameter("@Caccount", SqlDbType.VarChar,50),
					new SqlParameter("@paysrc", SqlDbType.VarChar,50),
					new SqlParameter("@paytype", SqlDbType.VarChar,50),
					new SqlParameter("@sysUserId", SqlDbType.Int,4),
					new SqlParameter("@platformName_id", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.Maccount;
			parameters[1].Value = model.Caccount;
			parameters[2].Value = model.paysrc;
			parameters[3].Value = model.paytype;
			parameters[4].Value = model.sysUserId;
			parameters[5].Value = model.platformName_id;
			parameters[6].Value = model.id;

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
			strSql.Append("delete from platformB2B_ticket_account ");
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
			strSql.Append("delete from platformB2B_ticket_account ");
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
		public Sanben.Model.platformB2B_ticket_account GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,Maccount,Caccount,paysrc,paytype,sysUserId,platformName_id from platformB2B_ticket_account ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Sanben.Model.platformB2B_ticket_account model=new Sanben.Model.platformB2B_ticket_account();
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
		public Sanben.Model.platformB2B_ticket_account DataRowToModel(DataRow row)
		{
			Sanben.Model.platformB2B_ticket_account model=new Sanben.Model.platformB2B_ticket_account();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["Maccount"]!=null)
				{
					model.Maccount=row["Maccount"].ToString();
				}
				if(row["Caccount"]!=null)
				{
					model.Caccount=row["Caccount"].ToString();
				}
				if(row["paysrc"]!=null)
				{
					model.paysrc=row["paysrc"].ToString();
				}
				if(row["paytype"]!=null)
				{
					model.paytype=row["paytype"].ToString();
				}
				if(row["sysUserId"]!=null && row["sysUserId"].ToString()!="")
				{
					model.sysUserId=int.Parse(row["sysUserId"].ToString());
				}
				if(row["platformName_id"]!=null && row["platformName_id"].ToString()!="")
				{
					model.platformName_id=int.Parse(row["platformName_id"].ToString());
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
			strSql.Append("select id,Maccount,Caccount,paysrc,paytype,sysUserId,platformName_id ");
			strSql.Append(" FROM platformB2B_ticket_account ");
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
			strSql.Append(" id,Maccount,Caccount,paysrc,paytype,sysUserId,platformName_id ");
			strSql.Append(" FROM platformB2B_ticket_account ");
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
			strSql.Append("select count(1) FROM platformB2B_ticket_account ");
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
			strSql.Append(")AS Row, T.*  from platformB2B_ticket_account T ");
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
			parameters[0].Value = "platformB2B_ticket_account";
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

